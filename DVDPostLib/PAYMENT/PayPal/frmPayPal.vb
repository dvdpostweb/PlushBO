Imports System.IO
Imports System.Collections.Generic
Imports System.Xml

Public Class frmPayPal
    Inherits BizzLib.frmBKForm

    Enum StepForm
        EDIT
        [NEW]
        SAVE
        CANCEL
        INIT
        LOAD
        CHOOSEPAYPAL
        DETAILED
    End Enum

    Enum typeSearch
        DETAIL
        ALL
    End Enum

    Private _typesearch As typeSearch

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()

        GridViewSearch.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        GridViewSearch.OptionsBehavior.Editable = True
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        GridViewSearch.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        GridViewSearch.OptionsBehavior.Editable = True

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        search()
        TabResult.PageVisible = True
        XtraTabPayPal.SelectedTabPage = TabResult
    End Sub

    Public Sub search()

        Dim sql As String = "select (select name from payment_status ps where ps.id = p.payment_status) payment_status_name, p.*, pph.id as ppid, pph.notes, pph.pp_request, pph.pp_response, pph.message from payment p left join paypal_payments_history pph on p.id = pph.payment_id"
        Dim dt As DataTable = Nothing

        If txtCustomersIDSearch.Text <> String.Empty Then
            sql = sql & " where p.payment_method = 4 and p.customers_id = " & txtCustomersIDSearch.Text
        Else
            sql = sql & " where p.payment_method = 4 "
        End If
        If cmbPaymentStatusSearch.Text <> String.Empty Then
            sql = sql & " and p.payment_status like '%" & cmbPaymentStatusSearch.EditValue & "%' "
        End If

        If dtFromDateSearch.EditValue <> Nothing Then
            sql = sql & " AND p.date_added > '" & PlushTools.ClsDate.formatDateDB(dtFromDateSearch.EditValue) & "' "
        End If

        If dtToDateSearch.EditValue <> Nothing Then
            sql = sql & " AND p.date_added < '" & PlushTools.ClsDate.formatDateDB(dtToDateSearch.EditValue) & "' "
        End If

        dt = PlushData.clsConnection.FillDataSet(sql)
        GridPayPal.DataSource = dt

        clsDevExpress.AddHyperlinkDynamic(GridPayPal)

    End Sub

    Private Sub frmPayPal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GridViewSearch.OptionsView.ColumnAutoWidth = False
        GridViewSearch.OptionsBehavior.Editable = False

        XtraTabPayPal.SelectedTabPage = TabSearch
        ' Misc_Bar.Visible = True

        Misc_Bar.Visible = True
        Dim menuStrip As New PlushBuziness.contextMenu()
        GridPayPal.ContextMenuStrip = menuStrip
        loadPaymentType()

    End Sub

    Private Sub loadPaymentType()
        Dim dtStatus As DataTable

        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "name"

        sql = PlushData.ClsPayment.GetSelectPaymentStatuses()
        dtStatus = PlushData.clsConnection.FillDataSet(sql)
        ' value empty = -4 but the value 0 exist in this table
        'DVDPostBuziness.ClsCombo.addRowEmpty(dtStatus, -4)

        cmbPaymentStatusSearch.Properties.ValueMember = key
        cmbPaymentStatusSearch.Properties.DisplayMember = value
        cmbPaymentStatusSearch.Properties.DataSource = dtStatus

        cmbPaymentStatus.Properties.ValueMember = key
        cmbPaymentStatus.Properties.DisplayMember = value
        cmbPaymentStatus.Properties.DataSource = dtStatus
    End Sub

    Private Sub GridPayPal_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPayPal.DoubleClick
        loadInfoPayPal()
        ChangeStep(StepForm.CHOOSEPAYPAL)
    End Sub

    Private Sub loadInfoPayPal()

        Dim row As DataRow
        If GridViewSearch.RowCount > 0 Then
            row = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle())
            loadData(row)
        End If
    End Sub


    Private Sub ChangeStep(ByVal stepCurrent As StepForm)
        Select Case stepCurrent
            Case StepForm.CANCEL
                btnEditPayPal.Enabled = True
                btnSavePayPal.Enabled = False
                btnCancelPayPal.Enabled = False

                EnableField(False)

                'TabSearch.PageVisible = True
                'TabResult.PageVisible = True

            Case StepForm.EDIT
                btnEditPayPal.Enabled = False
                btnSavePayPal.Enabled = True
                btnCancelPayPal.Enabled = True

                EnableField(True)
                'TabInvoice.PageVisible = True
                'TabResult.PageVisible = False

            Case StepForm.INIT
                btnEditPayPal.Enabled = False
                btnSavePayPal.Enabled = False
                btnCancelPayPal.Enabled = False

                EnableField(False)

                'TabResult.PageVisible = True
                'TabSearch.PageVisible = True
                'TabInvoice.PageVisible = False
                XtraTabPayPal.SelectedTabPage = TabSearch


            Case StepForm.[NEW]
                btnEditPayPal.Enabled = False
                btnSavePayPal.Enabled = True
                btnCancelPayPal.Enabled = True

                EnableField(True)
                'TabResult.PageVisible = False
                'TabInvoice.PageVisible = True
                XtraTabPayPal.SelectedTabPage = TabPayment

            Case StepForm.SAVE
                btnEditPayPal.Enabled = True
                btnSavePayPal.Enabled = False
                btnCancelPayPal.Enabled = False

                EnableField(False)
                'TabInvoice.PageVisible = True
                'TabResult.PageVisible = True

            Case StepForm.LOAD
                btnEditPayPal.Enabled = True
                btnSavePayPal.Enabled = False
                btnCancelPayPal.Enabled = False

                EnableField(False)
                'TabSearch.PageVisible = False
                'TabResult.PageVisible = True

                XtraTabPayPal.SelectedTabPage = TabResult

            Case StepForm.CHOOSEPAYPAL
                btnEditPayPal.Enabled = True
                btnSavePayPal.Enabled = False
                btnCancelPayPal.Enabled = False

                EnableField(False)
                'TabResult.PageVisible = False
                'TabInvoice.PageVisible = True
                XtraTabPayPal.SelectedTabPage = TabPayment

            Case StepForm.DETAILED
                btnEditPayPal.Enabled = False
                btnSavePayPal.Enabled = False
                btnCancelPayPal.Enabled = False

                EnableField(False)
                'XTabResult.PageVisible = True
                'XTabView.PageVisible = False
                XtraTabPayPal.SelectedTabPage = TabPayment

        End Select
        XtraTabPayPal.Refresh()
    End Sub

    Private Sub EnableField(ByVal enable As Boolean)
        txtId.Enabled = False
        txtCustomersID.Enabled = False
        cmbPaymentStatus.Enabled = enable
        txtDateAdded.Enabled = False
        txtAmount.Enabled = False
        txtCommunication.Enabled = False
        txtMessage.Enabled = enable
        txtRequest.Enabled = enable
        txtResponse.Enabled = enable
        txtNote.Enabled = enable

    End Sub

    Private Sub loadData(ByVal row As DataRow)

        Dim xd As XmlDocument = New XmlDocument()

        If row("id") Is DBNull.Value Then
            txtId.EditValue = ""
        Else
            txtId.EditValue = row("id")
        End If
        If row("customers_id") Is DBNull.Value Then
            txtCustomersID.EditValue = ""
        Else
            txtCustomersID.EditValue = row("customers_id")
        End If

        If row("payment_status") Is DBNull.Value Then
            cmbPaymentStatus.EditValue = ""
        Else
            cmbPaymentStatus.EditValue = row("payment_status")
        End If

        If row("date_added") Is DBNull.Value Then
            txtDateAdded.Text = ""
        Else
            txtDateAdded.EditValue = row("date_added")
        End If

        If row("amount") Is DBNull.Value Then
            txtAmount.EditValue = 0
        Else
            txtAmount.EditValue = row("amount")
        End If

        If row("message") Is DBNull.Value Then
            txtMessage.EditValue = ""
        Else
            txtMessage.EditValue = row("message")
        End If

        If row("communication") Is DBNull.Value Then
            txtCommunication.Text = ""
        Else
            txtCommunication.Text = row("communication")
        End If

        If row("pp_request") Is DBNull.Value Then
            txtRequest.Text = ""
        Else
            txtRequest.Text = row("pp_request")
        End If

        If row("pp_response") Is DBNull.Value Then
            txtResponse.Text = ""
        Else
            txtResponse.Text = row("pp_response")
            Try
                xd.LoadXml(row("pp_response"))

                Dim nsmanager As XmlNamespaceManager = New XmlNamespaceManager(xd.NameTable)
                nsmanager.AddNamespace("SOAP-ENV", "http://schemas.xmlsoap.org/soap/envelope/")
                nsmanager.AddNamespace("dataexNs", "urn:ebay:api:PayPalAPI")
                nsmanager.AddNamespace("err", "urn:ebay:apis:eBLBaseComponents")


                Dim xpath As String = "SOAP-ENV:Envelope/SOAP-ENV:Body/dataexNs:DoReferenceTransactionResponse/err:Errors/err:ShortMessage"
                txtShortResponse.Text = xd.SelectSingleNode(xpath, nsmanager).InnerText
                txtLongResponse.Text = xd.SelectSingleNode("SOAP-ENV:Envelope/SOAP-ENV:Body/dataexNs:DoReferenceTransactionResponse/err:Errors/err:LongMessage", nsmanager).InnerText
            Catch ex As Exception

            End Try

        End If

        If row("notes") Is DBNull.Value Then
            txtNote.Text = ""
        Else
            txtNote.Text = row("notes")
        End If

        If row("ppid") Is DBNull.Value Then
            txtppid.Text = ""
        Else
            txtppid.Text = row("ppid")
        End If




    End Sub

    Private Sub btnEditPayPal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPayPal.Click
        ChangeStep(StepForm.EDIT)
    End Sub

    Private Sub btnSavePayPal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavePayPal.Click
        If Save() Then
            ChangeStep(StepForm.SAVE)
            If _typesearch = typeSearch.DETAIL Then
                btnSearch_Click(Nothing, Nothing)
            End If
        Else
            MsgBox("Error Save Invoice (voir log)", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnCancelPayPal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelPayPal.Click
        ChangeStep(StepForm.CANCEL)
    End Sub

    Private Function Save() As Boolean
        Dim sql As String
        Try

            If Not txtId.Text Is Nothing Or txtId.Text <> String.Empty Then
                sql = "update payment set payment_status = " & cmbPaymentStatus.EditValue & " where id = " & txtId.Text & _
                      "; update paypal_payments_history set notes = '" & txtNote.Text & "' where id = " & txtppid.Text & " ;"
                PlushData.clsConnection.ExecuteNonQuery(sql)
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.BO, ex)
            Return False
        End Try
    End Function
End Class