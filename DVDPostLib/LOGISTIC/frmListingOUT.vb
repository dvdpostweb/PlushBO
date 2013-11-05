Imports System.Collections.Generic

Public Class frmListingOUT
    Inherits BizzLib.frmBKForm

    Dim WithEvents _ExportExcel As DevExpress.XtraBars.BarButtonItem = MainBtns_btnExcel
    Dim WithEvents _btnExport As DevExpress.XtraBars.BarButtonItem = btnExportXML
    Dim WithEvents _User1 As DevExpress.XtraBars.BarButtonItem = btnUser1
    Dim WithEvents SFDExportExcel As New System.Windows.Forms.SaveFileDialog
    Dim _filter As DevExpress.XtraGrid.Views.Base.ViewColumnFilterInfo
    Dim _Lstview(4) As DataView
    Dim _dt As DataTable
    Const KEY_COUNTRY As String = "delivery_country"


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()



        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub frmListingOut_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Main_Bar.Visible = False
        Misc_Bar.Visible = True

        Dim menuStrip As New DVDPostBuziness.contextMenu()
        GridListingOut.ContextMenuStrip = menuStrip

        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser1.Caption = "Cancel Order"
        btnUser1.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple

        'btnUser2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'btnUser2.Caption = "DVD are Lost"
        'btnUser2.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple

        'Dim strdate As String = "'" & DVDPostTools.ClsDate.formatDate() + " 10:00:00'"
        _filter = New DevExpress.XtraGrid.Views.Base.ViewColumnFilterInfo(GridViewListingOut.Columns("box_id"), _
        New DevExpress.XtraGrid.Columns.ColumnFilterInfo("[box_id] > 0 "))

        'GridViewListingOut.ActiveFilter.Add(GridViewListingOut.Columns("date_purchased"), _
        '  New DevExpress.XtraGrid.Columns.ColumnFilterInfo("[date_purchased] <= " & strdate))
    End Sub

    Private Sub btnLoadOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadOrders.Click
        LoadOrders()
        TabControlListingOut.SelectedTabPage = TabResult
    End Sub

    Public Function LoadOrders() As List(Of DataView)
        Dim _SQLTxt As String

        _SQLTxt = DvdPostData.clsOdersStatusHistory.GetOrdersAssignPickGroup()
        _dt = DvdPostData.clsConnection.FillDataSet(_SQLTxt)
        '_dt.TableName = "orders_out_view1"
        'objDS = New DataSet
        'objDS.Tables.Add(dt)
        GridListingOut.DataSource = _dt
        clsDevExpress.AddHyperlinkDynamic(GridListingOut)
        Return CreateListCountry(_dt)
        '_Lstview = CreateLstView(_dt)
        'SetQtyClient(_Lstview)

        'Set_Pick_Group()
        ' Grid1.DataSource = dt  'objDS.Tables(TableName).DefaultView

    End Function

#Region "New Order Group box"
    Private Function CreateListCountry(ByVal dt As DataTable) As List(Of DataView)
        Dim lst As List(Of DataView) = New List(Of DataView)
        Dim dv As DataView

        For Each Item As DvdPostData.ClsCustomersData.Country In [Enum].GetValues(GetType(DvdPostData.ClsCustomersData.Country))
            dv = New DataView(_dt, KEY_COUNTRY & " ='" & DVDPostTools.clsEnum.getNameStrEnum(Item) & "'", _
                "customers_id", DataViewRowState.CurrentRows)
            If dv.Count > 0 Then
                lst.Add(dv)
                GetCptCustomers(DVDPostTools.clsEnum.getNameStrEnum(Item)).Text = dv.Count
            End If
        Next

        Return lst
    End Function
    Private Function GetCptCustomers(ByVal country As String) As Windows.Forms.Control

        Select Case country
            Case "BELGIUM"
                Return txtBelgiqueFRQtyClient

            Case "LUXEMBOURG"
                Return txtLuxembourgQtyClient

            Case "NEDERLANDS"
                Return txtNetherlandsQtyClient
            Case Else
                Return Nothing
        End Select


    End Function
    Private Function GetListPickGroupChose(ByVal country As String) As Windows.Forms.Control

        Select Case country
            Case "BELGIUM"
                Return txtBelgiqueFR

            Case "LUXEMBOURG"
                Return txtLuxembourg

            Case "NEDERLANDS"
                Return txtNetherlands

            Case Else
                Return Nothing
        End Select


    End Function

    Private Sub CreateGroupBox(ByVal lstView As List(Of DataView))

        Dim country As String
        Dim ctrlCptCust As Windows.Forms.Control
        Dim ctrlListPickGroup As Windows.Forms.Control
        Dim maxDVD As Integer
        Dim lstGroupBox() As String = Nothing
        Dim cptDVD As Integer
        Dim IndexLst As Integer
        Dim title As String
        Dim sql As String

        For Each dv As DataView In lstView
            country = dv(0)(KEY_COUNTRY)
            ctrlCptCust = GetCptCustomers(country)
            ctrlListPickGroup = GetListPickGroupChose(country)
            maxDVD = GetMaxDvdByGroupBox(ctrlCptCust, ctrlListPickGroup, lstGroupBox)
            cptDVD = 0
            IndexLst = 0
            For Each dr As DataRowView In dv

                title = country & "-" & Format(Int(lstGroupBox(IndexLst)), "00")
                sql = DvdPostData.clsOdersStatusHistory.getUpdateOrdersPickGroup(title, lstGroupBox(IndexLst), dr("orders_id"))
                DvdPostData.clsConnection.ExecuteNonQuery(sql)

                If cptDVD >= maxDVD Then
                    IndexLst += 1
                    cptDVD = 0
                End If
                cptDVD += 1
            Next

        Next

    End Sub

    Private Function GetMaxDvdByGroupBox(ByVal ctrlCptCust As Windows.Forms.Control, ByVal ctrlListBox As Windows.Forms.Control, ByRef lstpickgroup() As String) As Integer

        Dim cptcust As Integer
        Dim value As String
        cptcust = ctrlCptCust.Text
        value = ctrlListBox.Text
        lstpickgroup = value.Split(",")

        Return GetMaxDvdByGroupBox(cptcust, lstpickgroup)


    End Function
    Private Function GetMaxDvdByGroupBox(ByVal qtyClient As Integer, ByVal lstpickgroup() As String) As Integer

        Dim nb_pickgroup As Integer
        nb_pickgroup = lstpickgroup.Length

        Return CInt(qtyClient / nb_pickgroup) + 1
    End Function

#End Region

#Region "Old Version If new order group is ok this region can be deleted"

    'Private Function Getsigne(ByVal pos As Integer) As String
    '    If pos = 1 Then
    '        Return "="
    '    Else
    '        Return "<>"
    '    End If
    'End Function
    'Private Sub SetQtyClient(ByVal lstview As DataView())
    '    For i As Integer = 1 To 2
    '        For j As Integer = 1 To 2
    '            SetQtyClient(i = 1, j = 1, lstview(GetIndexView(i, j)))
    '        Next
    '    Next

    'End Sub
    'Private Sub SetQtyClient(ByVal isBelgique As Boolean, ByVal IsNL As Boolean, ByVal view As DataView)

    '    Dim ctrl As Windows.Forms.TextBox
    '    Dim dt As DataTable
    '    ctrl = GetctrlQtyClient(isBelgique, IsNL)

    '    dt = view.ToTable(True, "customers_id")
    '    ctrl.Text = dt.Rows.Count
    'End Sub
    'Private Function GetctrlQtyClient(ByVal isBelgique As Boolean, ByVal IsNL As Boolean) As Windows.Forms.TextBox
    '    Dim isfr As Boolean = Not IsNL

    '    If isBelgique Then
    '        If isfr Then
    '            Return txtBelgiqueFRQtyClient
    '        Else
    '            Return txtBelgiqueNLQtyClient
    '        End If
    '    Else
    '        If isfr Then
    '            Return txtLuxembourgQtyClient
    '        Else
    '            Return txtNetherlandsQtyClient
    '        End If
    '    End If

    'End Function
    'Private Function GetLstPickGroup(ByVal isBelgique As Boolean, ByVal IsNL As Boolean) As String
    '    Dim isFR As Boolean = Not IsNL

    '    If isBelgique Then
    '        If isFR Then
    '            Return txtBelgiqueFR.Text
    '        Else
    '            Return txtBelgiqueNL.Text
    '        End If
    '    Else
    '        If isFR Then
    '            Return txtLuxembourg.Text
    '        Else
    '            Return txtNetherlands.Text
    '        End If
    '    End If

    'End Function
    'Private Function GetIndexView(ByVal i As Integer, ByVal j As Integer) As Integer
    '    Return (i - 1) * 2 + j
    'End Function
    'Private Sub assignGroup(ByVal isBelgique As Boolean, ByVal IsNL As Boolean, ByVal view As DataView)
    '    Dim ctrl As Windows.Forms.TextBox
    '    Dim lstPickGroup() As String
    '    Dim strlstPickGroup As String
    '    Dim qtyClientPickGroup As Integer
    '    Dim oldCustomers_id As Integer = 0
    '    Dim qtycurrent As Integer = 0
    '    Dim indexCurrent As Integer = 0
    '    Dim pickgroupCurrent As Integer = 0


    '    Dim grp_country As String
    '    Dim grp_language As Integer
    '    Dim grp As String
    '    Dim grp_id As Integer

    '    Dim sql As String

    '    ctrl = GetctrlQtyClient(isBelgique, IsNL)
    '    strlstPickGroup = GetLstPickGroup(isBelgique, IsNL)

    '    lstPickGroup = strlstPickGroup.Split(",")
    '    qtyClientPickGroup = GetQtyClientInPickGroup(CInt(ctrl.Text), lstPickGroup)

    '    While indexCurrent < view.Count
    '        oldCustomers_id = view(indexCurrent)("customers_id")
    '        grp_id = lstPickGroup(pickgroupCurrent)
    '        While indexCurrent < view.Count AndAlso oldCustomers_id = view(indexCurrent)("customers_id")
    '            grp_country = view(indexCurrent)("delivery_country")
    '            grp_language = view(indexCurrent)("language_id")

    '            grp = grp_country & "-" & Format(grp_language, "00") & "-" & Format(grp_id, "00")
    '            view(indexCurrent)("pick_group") = grp

    '            sql = DvdPostData.clsOdersStatusHistory.getUpdateOrdersPickGroup(grp, grp_id, view(indexCurrent)("orders_id"))
    '            DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '            indexCurrent += 1
    '        End While

    '        qtycurrent += 1

    '        If qtycurrent >= qtyClientPickGroup Then
    '            qtycurrent = 0
    '            pickgroupCurrent += 1
    '        End If
    '    End While


    'End Sub
    'Private Function GetQtyClientInPickGroup(ByVal qtyClient As Integer, ByVal lstpickgroup() As String) As Integer

    '    Dim nb_pickgroup As Integer
    '    nb_pickgroup = lstpickgroup.Length

    '    Return CInt(qtyClient / nb_pickgroup) + 1
    'End Function
    'Private Sub assignGroup(ByVal lstView() As DataView)
    '    For i As Integer = 1 To 2
    '        For j As Integer = 1 To 2
    '            assignGroup(i = 1, j = 1, lstView(GetIndexView(i, j)))
    '        Next
    '    Next

    'End Sub
    'Private Function CreateLstView(ByVal dt As DataTable) As DataView()
    '    Dim Lstview(4) As DataView

    '    Dim signeI, signeJ As String
    '    Dim cpt As Integer
    '    For i As Integer = 1 To 2
    '        signeI = Getsigne(i)
    '        For j As Integer = 1 To 2
    '            signeJ = Getsigne(j)
    '            Lstview(GetIndexView(i, j)) = New DataView(_dt, _
    '            "delivery_country " & signeI & " 'Belgium' and (language_id " & signeJ & "2)", _
    '            "customers_id", DataViewRowState.CurrentRows)
    '            ' txtInfo.EditValue = _View.Count
    '            ' AssignGroup(_View)
    '        Next
    '    Next

    '    Return Lstview
    'End Function

#End Region


    Private Sub btnSetPickingGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPickingGroup.Click
        '  Set_Pick_Group()
        Dim lstView As List(Of DataView)
        lstView = LoadOrders()
        CreateGroupBox(lstView)
        ' assignGroup(_Lstview)
        LoadOrders()
        TabControlListingOut.SelectedTabPage = TabResult

    End Sub
    Private Sub btnCancelOrder_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _User1.ItemClick
        'Cancel Orders
        Dim _Orders_ID As Integer
        Dim _customers_id As Integer
        Dim _products_id As Integer
        Dim _dvd_id As Integer
        Dim _objProductsDVD As clsProduct_DVD
        Dim _DS As dsProducts
        Dim _i As Integer
        Dim _bool_line_selected As Boolean = False
        Dim isIllimitedAbo As Boolean
        Dim result As MsgBoxResult

        result = MsgBox("Est ce vous possedez physiquement ce dvd ? (sinon il passera en bizarrement perdu) ", MsgBoxStyle.YesNoCancel)

        If result = MsgBoxResult.Cancel Then Return

        For Each _i In GridViewListingOut.GetSelectedRows

            If GridViewListingOut.GetDataRow(_i)("products_id") Is DBNull.Value Then Continue For
            _Orders_ID = GridViewListingOut.GetDataRow(_i)("orders_id")
            _customers_id = GridViewListingOut.GetDataRow(_i)("customers_id")
            _products_id = GridViewListingOut.GetDataRow(_i)("products_id")
            _dvd_id = GridViewListingOut.GetDataRow(_i)("dvd_id")
            _DS = New dsProducts
            _objProductsDVD = New clsProduct_DVD(SessionInfo, _DS, _products_id, _dvd_id)
            isIllimitedAbo = DVDPostBuziness.ClsCustomers.isIllimitedaboByCustomers(_customers_id)

            _objProductsDVD.CancelOrder(isIllimitedAbo, _Orders_ID, _customers_id)
            If result = MsgBoxResult.No Then
                _objProductsDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.BIZARREMENT_PERDU, _
                                                 "Cancel Order SetDVDLost", _
                                                DvdPostData.ClsProducts_dvd_state.state.DVD_STATUS_MAINTENANCE, _objProductsDVD.INOUT)

            End If


        Next
        Do
            If GridViewListingOut.GetSelectedRows.Length = 0 Then Exit Do

            GridViewListingOut.DeleteRow(GridViewListingOut.GetSelectedRows(0))

        Loop
        MsgBox("Process Complete")
    End Sub

    Private Sub btnexcel_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _ExportExcel.ItemClick
        SFDExportExcel.DefaultExt = "xls"
        SFDExportExcel.Filter = "Excel(*.xls)|*.xls"

        If SFDExportExcel.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GridListingOut.ExportToXls(SFDExportExcel.FileName)
        End If
    End Sub

    Private Sub btnCptEnveloppe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sql As String
        Dim cpt As Integer
        sql = DvdPostData.clsOdersStatusHistory.GetCptEnveloppeToDay()
        cpt = DvdPostData.clsConnection.ExecuteScalar(sql)

        MsgBox(cpt)

    End Sub

    Private Sub Chkstock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chkstock.CheckedChanged
        If Chkstock.Checked Then
            GridViewListingOut.ActiveFilter.Add(_filter)
        Else
            GridViewListingOut.ActiveFilter.Clear()
        End If
    End Sub

    Private Sub ExportXml_click(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _btnExport.ItemClick

        Dim _frm As New BizzLib.frmDialogSelectXMLFile
        Dim _FileName As String
        _frm.mvarBoolSave = True
        _frm.ShowDialog(Me)
        If _frm.DialogResult = Windows.Forms.DialogResult.Cancel Then Exit Sub
        _FileName = _frm.txtFileName.Text
        'Dim _MyTable As DataTable
        '_MyTable = objDS.Tables("envelope_labels_multishipment_det").Copy
        'Dim _Ds As New DataSet
        '_Ds.Tables.Add(_MyTable)
        Dim ds As DataSet = New DataSet()
        ds.Tables.Add(_dt)
        ds.WriteXml(_FileName)
    End Sub

    Private Sub NbUserLogistic_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NbUserLogistic.EditValueChanged
        Dim nbuser As Integer = NbUserLogistic.Value
        Dim indexMin As Integer = 3
        Dim result As String = ""

        For index As Integer = indexMin To nbuser + indexMin - 1
            result = result & index & ","
        Next
        result = result.Remove(result.Length - 1)
        txtBelgiqueFR.Text = result
    End Sub
End Class