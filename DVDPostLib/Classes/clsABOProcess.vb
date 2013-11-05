Imports System.Threading

Public Class ClsABOProcess
    Const NbrThread As Integer = 100

    Private semStateCalcHowManyToAssign(NbrThread) As ManualResetEvent
    Private semExcluCalcHowManyToAssign As New Semaphore(1, 1)
    Private semExcluGUICalcHowManyToAssign As New Semaphore(1, 1)
    Private SharedI As Integer = 0

    Public CustView As DataView
    Public WLView As DataView
    'Public DS As DVDPostLib.dsABOProcess
    Public IsLoadComplete As Boolean = False
    Public DS As dsABOProcess

    Private Sub CalcHowManyToAssignThread(ByVal State As Object)
        Dim _CurRowI As Int16
        While True
            semExcluCalcHowManyToAssign.WaitOne()
            SharedI += 1
            _CurRowI = SharedI
            semExcluCalcHowManyToAssign.Release()
            If _CurRowI >= CustView.Count Then
                Exit While
            End If
            CalcHowManyToAssign2(CustView.Item(_CurRowI))
            semExcluCalcHowManyToAssign.WaitOne()
            '            txtCustomersToProcess.EditValue -= 1
            semExcluCalcHowManyToAssign.Release()
        End While
        State.Set()
    End Sub
    Private Sub CalcHowManyToAssign2(ByRef vCustRow As DataRowView)
        Dim _CompensationRow As DataRow
        Dim vNormToSend As Integer = 0
        Dim vAdultToSend As Integer = 0
        Dim vNormCompensation As Integer = 0
        Dim vAdultCompensation As Integer = 0
        Dim vIsCustInNeed As Boolean = False


        vNormToSend = vCustRow.Item("customers_abo_dvd_norm") - vCustRow.Item("customers_abo_dvd_home_norm")
        vAdultToSend = vCustRow.Item("customers_abo_dvd_adult") - vCustRow.Item("customers_abo_dvd_home_adult")
        If vNormToSend < 0 Then vNormToSend = 0
        If vAdultToSend < 0 Then vAdultToSend = 0
        'Check if Throtling
        If vCustRow.Item("throttling") = 1 Then
            'semExcluGUICalcHowManyToAssign.WaitOne()
            'txtXThrotling.EditValue += 1
            'txtCustomersNotServed.EditValue += 1
            'semExcluGUICalcHowManyToAssign.Release()
            'vCustRow.Item("NotServed") = 1
            vAdultToSend = 0
            vNormToSend = 0
            vNormCompensation = 0
            vAdultCompensation = 0
            Exit Sub
        End If

        'Check if suspended
        If vCustRow.Item("customers_abo_suspended") > 0 Then
            'semExcluGUICalcHowManyToAssign.WaitOne()
            'txtXSuspended.EditValue += 1
            'txtCustomersNotServed.EditValue += 1
            'semExcluGUICalcHowManyToAssign.Release()
            vAdultToSend = 0
            vNormToSend = 0
            vCustRow.Item("NotServed") = 1
            vNormCompensation = 0
            vAdultCompensation = 0
            Exit Sub
        End If
        If vCustRow.Item("Use_credit") = 1 Then
            'Use Credit , then check that customers has enough credit
            If vCustRow.Item("customers_abo_dvd_credit") <= 0 Then
                vCustRow.Item("customers_abo_dvd_credit") = 0
                'semExcluGUICalcHowManyToAssign.WaitOne()
                'txtXCredit.EditValue += 1
                'txtCustomersNotServed.EditValue += 1
                'semExcluGUICalcHowManyToAssign.Release()
                vCustRow.Item("NotServed") = 1
                vCustRow.Item("NotEnoughtCredit") = 1
                vNormToSend = 0
                vAdultToSend = 0
            Else
                vNormToSend = Math.Min(vNormToSend, vCustRow.Item("customers_abo_dvd_credit"))
                vCustRow.Item("customers_abo_dvd_credit") = vCustRow.Item("customers_abo_dvd_credit") - vNormToSend
                vAdultToSend = Math.Min(vAdultToSend, vCustRow.Item("customers_abo_dvd_credit"))
                vCustRow.Item("customers_abo_dvd_credit") = vCustRow.Item("customers_abo_dvd_credit") - vAdultToSend
                If vNormToSend + vAdultToSend = 0 Then
                    'semExcluGUICalcHowManyToAssign.WaitOne()
                    'txtXTooManyHome.EditValue += 1
                    'txtCustomersNotServed.EditValue += 1
                    'semExcluGUICalcHowManyToAssign.Release()
                    vCustRow.Item("NotServed") = 1
                    vCustRow.Item("TooManyAtHome") = 1
                End If
            End If
        Else
            If vNormToSend + vAdultToSend = 0 Then
                'semExcluGUICalcHowManyToAssign.WaitOne()
                'txtXTooManyHome.EditValue += 1
                'txtCustomersNotServed.EditValue += 1
                'semExcluGUICalcHowManyToAssign.Release()
                vCustRow.Item("NotServed") = 1
                vCustRow.Item("TooManyAtHome") = 1
            End If
            'Do not use credit then what has been calculated is orrect
        End If
        _CompensationRow = DS.Tables("compensation_summary").Rows.Find(New Object() {vCustRow.Item("customers_id"), "DVD_NORM"})
        If Not IsNothing(_CompensationRow) Then
            vNormCompensation = _CompensationRow.Item("compensation_qty")
        End If
        _CompensationRow = DS.Tables("compensation_summary").Rows.Find(New Object() {vCustRow.Item("customers_id"), "DVD_ADULT"})
        If Not IsNothing(_CompensationRow) Then
            vAdultCompensation = _CompensationRow.Item("compensation_qty")
        End If
        vCustRow.Item("NormCompensation") = vNormCompensation
        vCustRow.Item("AdultCompensation") = vAdultCompensation

        'semExcluGUICalcHowManyToAssign.WaitOne()
        'txtNormCompensation.EditValue += vNormCompensation
        'txtAdultCompensation.EditValue += vAdultCompensation
        'txtNormToSend.EditValue = txtNormToSend.EditValue + vNormToSend
        'txtAdultToSend.EditValue = txtAdultToSend.EditValue + vAdultToSend


        vCustRow.Item("NormToSend") = vNormToSend
        vCustRow.Item("AdultToSend") = vAdultToSend
        If vNormToSend + vAdultToSend > 0 Then
            '            txtCustomersInNeed.EditValue += 1
            vIsCustInNeed = True
            vCustRow.Item("InNeed") = 1
        Else
            vIsCustInNeed = False
            vCustRow.Item("InNeed") = 0
        End If
        'semExcluGUICalcHowManyToAssign.Release()
        '        State.Set()

    End Sub
    Public Sub aboprocess3(ByVal State As Object)
        'Go through all Customers for First DVD
        'Go Through again all customers for Next DVD
        Dim _custRow As DataRowView
        Dim _NormToSend As Integer = 0
        Dim _AdultToSend As Integer = 0
        Dim _NormCompensation As Integer = 0
        Dim _AdultCompensation As Integer = 0
        Dim _IsCustInNeed As Boolean = False
        Dim _WLRow As DataRowView
        Dim _WLRowID As Integer
        Dim _ProductView As DataView
        Dim _WLSerieViewAll As DataView
        Dim _ProductRow As DataRowView
        Dim _ProductRows() As DataRowView
        Dim _IsCustomerServed As Boolean
        Dim _IsDVDFound As Boolean
        Dim _IsCompensation As Boolean
        Dim _PRoductType As String = ""
        Dim _i, _iStart, _iEnd, _iStep As Integer
        Dim _AtLeastOneHasBeenServed As Boolean = False
        Dim _loop As Integer
        Dim _boolSerieNumberTooBig As Boolean = False
        Dim _SQLTxt As String
        '        txtInfo.Text = "Sorting WishList"
        CustView = New DataView(DS.Tables("customers"), "", "customers_abo_rank, customers_id ", DataViewRowState.CurrentRows)
        WLView = New DataView(DS.Tables("wishlist"), "", "customers_id, wishlist_type, rank", DataViewRowState.CurrentRows)
        _ProductView = New DataView(DS.Tables("products_dvd"), " ", "products_id, inout", DataViewRowState.CurrentRows)
        _WLSerieViewAll = New DataView(DS.Tables("wishlist"), " ", "customers_id, products_series_aboprocess_id, rank", DataViewRowState.CurrentRows)

        Dim zz As Integer
        For zz = 0 To NbrThread - 1
            semStateCalcHowManyToAssign(zz) = New ManualResetEvent(False)
        Next
        SharedI = 0
        For zz = 0 To NbrThread - 1
            ThreadPool.QueueUserWorkItem(AddressOf CalcHowManyToAssignThread, semStateCalcHowManyToAssign(zz))
        Next

        For zz = 0 To NbrThread - 1
            semStateCalcHowManyToAssign(zz).WaitOne()
        Next




        MsgBox("Part1 " & CustView.Count, MsgBoxStyle.Information)

        _iStart = 1
        _iEnd = 200
        _iStep = 1
        _loop = 1
       
        MsgBox("ABO Process Complete", MsgBoxStyle.Exclamation)
    End Sub
End Class
