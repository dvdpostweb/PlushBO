Public Class FrmReconciliation
    Inherits BizzLib.frmBKForm

    Dim _sql As String
    Dim _dt As DataTable

    Private Sub loadTypeMatching()
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.ClsMatching.GetTypeMatching()
        dt = PlushData.clsConnection.FillDataSet(sql)

        RepositoryCmbMatching.DataSource = dt
        ' RepositoryCmbMatching.DisplayMember = "name"
        ' RepositoryCmbMatching.ValueMember = "id"


    End Sub
    Private Sub saveData()

        Me.BindingContext(_dt).EndCurrentEdit()

        PlushData.clsConnection.UpdateDataTableInDB(_dt, _sql)
        refreshBankAccountMovement()

    End Sub

    Private Sub loadBankAccountMovement(ByVal datefrom As String, ByVal dateto As String, ByVal check As Boolean)

        Dim id As Integer


        If txtAccountMovement_id.EditValue = "" Then
            _sql = PlushData.ClsMatching.getBankAccountMovementsDetails(datefrom, dateto, CheckOpenPaymentCoda.Checked)
        Else
            Try
                id = Integer.Parse(txtAccountMovement_id.EditValue)
                _sql = PlushData.ClsMatching.getBankAccountMovementsDetails(id)
            Catch ex As Exception
                MsgBox("ID is not valid")
                _sql = ""
            End Try
        End If
        _dt = PlushData.clsConnection.FillDataSet(_sql)
        GridBankAccountMovements.DataSource = _dt


        ' GridViewBankAccountMovements.ActiveFilterEnabled = True
        ' GridViewBankAccountMovements.ApplyColumnsFilter()


        'GridViewBankAccountMovements.RefreshData()

    End Sub

    Private Sub refreshBankAccountMovement()
        Dim DateFromTxt As String = Year(txtStartDate.EditValue) & "-" & Month(txtStartDate.EditValue) & "-" & DateAndTime.Day(txtStartDate.EditValue)
        Dim DateToTxt As String = Year(txtEndDate.EditValue) & "-" & Month(txtEndDate.EditValue) & "-" & DateAndTime.Day(txtEndDate.EditValue)

        loadBankAccountMovement(DateFromTxt, DateToTxt, CheckOpenPaymentCoda.Checked)
    End Sub
    Private Sub BtnLoadBankAccountMovements_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadBankAccountMovements.Click
        refreshBankAccountMovement()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        txtStartDate.DateTime = Now().ToString(txtStartDate.Properties.EditFormat.FormatString)
        txtEndDate.DateTime = Now().ToString(txtStartDate.Properties.EditFormat.FormatString)
        GridViewBankAccountMovements.ActiveFilter.Add(GridViewBankAccountMovements.Columns("Amount"), _
           New DevExpress.XtraGrid.Columns.ColumnFilterInfo("[Amount] < 100.0m"))

        loadTypeMatching()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub loadPayment(ByVal customers_id As Integer, ByVal matching_id As Integer, ByVal check As Boolean)
        Dim sql As String
        Try

            Dim dt As DataTable

            sql = PlushData.ClsMatching.GetDataPayment(customers_id, check, matching_id)
            dt = PlushData.clsConnection.FillDataSet(sql)
            GridPayment.DataSource = dt
        Catch ex As Exception
            MsgBox("Num client is not valid")
        End Try
    End Sub

    Private Sub refreshpayment()
        Dim customers_id As Integer = -1
        Dim matching_id As Integer = -1

        If Not txtcustomers_id.EditValue Is Nothing AndAlso txtcustomers_id.EditValue <> "" Then
            customers_id = Integer.Parse(txtcustomers_id.EditValue)
        End If

        If Not txtMatching_id.EditValue Is Nothing AndAlso txtMatching_id.EditValue <> "" Then
            matching_id = Integer.Parse(txtMatching_id.EditValue)
        End If

        loadPayment(customers_id, matching_id, checkOpenPayment.Checked)
    End Sub
    Private Sub btnLoadPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadPayment.Click
        refreshpayment()
    End Sub

    Private Sub BtnReconciliation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReconciliation.Click
        Dim Payment_id As Integer
        Dim bankAccount_id As Integer
        Dim customers_id As Integer
        Dim amount_bankAccount As Decimal
        Dim amount_payment As Decimal = 0
        Dim cpt_result As Integer
        Dim amountremaining As Decimal = 0
        Dim ok As Boolean = True
        Dim bankAccountRow As DataRow

        If (GridViewPayment.GetSelectedRows().Length = 0) Or (GridViewBankAccountMovements.GetSelectedRows().Length = 0) Then
            MsgBox("Please Select payment before reconciliation")
            Return
        End If
        bankAccountRow = GridViewBankAccountMovements.GetDataRow(GridViewBankAccountMovements.FocusedRowHandle)
        bankAccount_id = bankAccountRow("account_movements_id")
        amount_bankAccount = bankAccountRow("amount")

        For Each index As Integer In GridViewPayment.GetSelectedRows
            amount_payment = amount_payment + GridViewPayment.GetDataRow(index)("amount")
        Next

        If amount_payment <> amount_bankAccount Then
            amountremaining = amount_payment - amount_bankAccount
            If MsgBox("Are you sure to reconciliation payment ? " & vbNewLine & "Payment not equal (amount received : " & amount_bankAccount.ToString() & " -> amount factured : " & amount_payment.ToString(), MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                ok = False
            End If
        End If

        If ok Then


            Dim sql As String
            Dim last_status As PlushData.PaymentOfflineData.StepPayment

            PlushData.clsConnection.CreateTransaction(True)
            For Each index As Integer In GridViewPayment.GetSelectedRows
                Payment_id = GridViewPayment.GetDataRow(index)("id")
                last_status = GridViewPayment.GetDataRow(index)("payment_status_id")
                customers_id = GridViewPayment.GetDataRow(index)("customers_id")
                sql = PlushData.ClsMatching.ClosePayment(bankAccount_id, Payment_id, last_status, customers_id)
                PlushData.clsConnection.ExecuteNonQuery(sql)
                amountremaining = 0
            Next

            PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Matching, cpt_result)
            MsgBox("Reconciliation OK")
            refreshBankAccountMovement()
            refreshpayment()
        End If

    End Sub

    Private Sub GridBankAccountMovements_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridBankAccountMovements.DoubleClick
        Dim entireData As String
        Dim bankAccountRow As DataRow

        bankAccountRow = GridViewBankAccountMovements.GetDataRow(GridViewBankAccountMovements.FocusedRowHandle)
        If bankAccountRow("EntireData") IsNot DBNull.Value Then
            entireData = bankAccountRow("EntireData")
        Else
            entireData = "Empty"
        End If
        MsgBox(entireData)
    End Sub

    Private Sub FrmReconciliation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New PlushBuziness.contextMenu
        GridBankAccountMovements.ContextMenuStrip = menuStrip
        GridPayment.ContextMenuStrip = menuStrip
    End Sub

    Private Sub btn_noPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_noPayment.Click
        Dim bankAccountRow As DataRow
        Dim bankAccount_id As Integer
        Dim sql As String
        If MsgBox("Are you sure to change " & GridViewBankAccountMovements.GetSelectedRows.Length & " payment -> NoPayment ? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            For Each index As Integer In GridViewBankAccountMovements.GetSelectedRows
                bankAccountRow = GridViewBankAccountMovements.GetDataRow(index)
                bankAccount_id = bankAccountRow("account_movements_id")

                sql = PlushData.ClsMatching.getUpdateBankAccountMovementsNoPayment(bankAccount_id)
                PlushData.clsConnection.ExecuteNonQuery(sql)
            Next
            MsgBox("Changed NoPayment")
            refreshBankAccountMovement()
        End If
    End Sub

    Private Sub BtnReopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReopen.Click

        Dim Payment_id As Integer
        Dim last_status As String = ""
        Dim bankAccount_id As Integer

        Dim sql As String

        For Each index As Integer In GridViewPayment.GetSelectedRows
            Payment_id = GridViewPayment.GetDataRow(index)("id")
            If GridViewPayment.GetDataRow(index)("last_status_id") IsNot DBNull.Value Then
                last_status = GridViewPayment.GetDataRow(index)("last_status_id")
            End If
            bankAccount_id = GridViewPayment.GetDataRow(index)("id_matching")

            sql = PlushData.ClsMatching.ReOpenPayment(bankAccount_id, Payment_id, last_status)
            PlushData.clsConnection.ExecuteNonQuery(sql)

        Next

        MsgBox("Reopen Payment")
        refreshBankAccountMovement()
        refreshpayment()

    End Sub

    Private Sub GridViewBankAccountMovements_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridViewBankAccountMovements.CellValueChanged
        saveData()
    End Sub

    Private Sub GridViewBankAccountMovements_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridViewBankAccountMovements.ValidateRow
        'saveData()
    End Sub
   
End Class