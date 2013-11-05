Public Class FrmReconciliation
    Inherits BizzLib.frmBKForm

    Private Sub loadBankAccountMovement(ByVal datefrom As String, ByVal dateto As String, ByVal check As Boolean)

        Dim sql As String
        Dim dt As DataTable
        Dim chk As String
         Dim id As Integer


        If chkIsmatching.Checked Then
            chk = 0
        Else
            chk = 1
        End If
        If txtAccountMovement_id.EditValue = "" Then
            sql = DvdPostData.ClsMatching.getBankAccountMovementsDetails(datefrom, dateto, chk)
        Else
            Try
                id = Integer.Parse(txtAccountMovement_id.EditValue)
                sql = DvdPostData.ClsMatching.getBankAccountMovementsDetails(id)
            Catch ex As Exception
                MsgBox("ID is not valid")
                sql = ""
            End Try
        End If
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridBankAccountMovements.DataSource = dt

      
        ' GridViewBankAccountMovements.ActiveFilterEnabled = True
        ' GridViewBankAccountMovements.ApplyColumnsFilter()

      
        'GridViewBankAccountMovements.RefreshData()

    End Sub

    Private Sub refreshBankAccountMovement()
        Dim DateFromTxt As String = Year(txtStartDate.EditValue) & "-" & Month(txtStartDate.EditValue) & "-" & DateAndTime.Day(txtStartDate.EditValue)
        Dim DateToTxt As String = Year(txtEndDate.EditValue) & "-" & Month(txtEndDate.EditValue) & "-" & DateAndTime.Day(txtEndDate.EditValue)

        loadBankAccountMovement(DateFromTxt, DateToTxt, chkIsmatching.Checked)
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
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub loadPayment(ByVal customers_id As Integer, ByVal check As Boolean)
        Dim sql As String
        Try

            Dim dt As DataTable
           
            sql = DvdPostData.ClsMatching.GetDataPaymentAllTypePayments(customers_id, check)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            GridPayment.DataSource = dt
        Catch ex As Exception
            MsgBox("Num client is not valid")
        End Try
    End Sub

    Private Sub refreshpayment()
        Dim customers_id As Integer
        customers_id = Integer.Parse(txtcustomers_id.EditValue)

        loadPayment(customers_id, checkOpenPayment.Checked)
    End Sub
    Private Sub btnLoadPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadPayment.Click
        refreshpayment()
    End Sub

    Private Sub BtnReconciliation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReconciliation.Click
        Dim Payment_id As Integer
        Dim bankAccount_id As Integer
        Dim amount_bankAccount As Decimal
        Dim amount_payment As Decimal = 0
        Dim type_Payment As String
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
            If MsgBox("Are you sur to reconciliation payment ? " & vbNewLine & "Payment not equal (amount received : " & amount_bankAccount.ToString() & " -> amount factured : " & amount_payment.ToString(), MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                ok = False
            End If
        End If

        If ok Then


            Dim sql As String


            DvdPostData.clsConnection.CreateTransaction(True)
            For Each index As Integer In GridViewPayment.GetSelectedRows
                Payment_id = GridViewPayment.GetDataRow(index)("id")
                type_Payment = GridViewPayment.GetDataRow(index)("type_payment")

                sql = DvdPostData.ClsMatching.ClosePayment(bankAccount_id, Payment_id, type_Payment, DVDPostTools.ClsPrice.FormatPrice(amountremaining))
                DvdPostData.clsConnection.ExecuteNonQuery(sql)
                amountremaining = 0
            Next

            DvdPostData.clsConnection.ExecuteBulkQuery(DvdPostData.clsMsgError.processType.Matching, cpt_result)
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
        Dim menuStrip As New DVDPostBuziness.contextMenu
        GridBankAccountMovements.ContextMenuStrip = menuStrip
        GridPayment.ContextMenuStrip = menuStrip
    End Sub
End Class