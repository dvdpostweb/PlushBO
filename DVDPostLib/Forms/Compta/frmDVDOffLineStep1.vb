Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text

Public Class frmDVDOffLineStep1
    Inherits BizzLib.frmGeneral_Browse

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDVDOffLineStep1))
        Me.Panel1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.TabChart.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        resources.ApplyResources(Me.StatusBar1, "StatusBar1")
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.SelectedTabPage = Me.TabResult
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        '
        'TabParameters
        '
        resources.ApplyResources(Me.TabParameters, "TabParameters")
        '
        'TabResult
        '
        resources.ApplyResources(Me.TabResult, "TabResult")
        '
        'TabAnalyse
        '
        resources.ApplyResources(Me.TabAnalyse, "TabAnalyse")
        '
        'UcPivotGrid1
        '
        resources.ApplyResources(Me.UcPivotGrid1, "UcPivotGrid1")
        '
        'UcChart1
        '
        resources.ApplyResources(Me.UcChart1, "UcChart1")
        '
        'TabChart
        '
        resources.ApplyResources(Me.TabChart, "TabChart")
        '
        'frmDVDOffLineStep1
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmDVDOffLineStep1"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabChart.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "
    Dim mvarsmtpserver As String = "" '"192.168.0.203"
    Dim mvarsite As String = "" '"www.dvdpost.be"
    Dim mvarLogo As String = ""
    Dim intmessages_id As Integer = 14 'Relance Stopped ABO with DVD @ Home

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objDS = New dsCompta
        'TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "Offline_Payment_Step_View1"
        MyBase.IDField = "payment_offline_request_id"
        MyBase.NameField = "payment_offline_request_id"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = True
        MyBase.StartUp()
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser1.Caption = "Send E-Mail1"
        btnUser2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser2.Caption = "Check"
        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
        mvarsmtpserver = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'SMTPServer'")
        'mvarsite = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'BESite'")
        BKGlobal.Cls1.FillDataSet(objDS.Tables("languages"), "SELECT * from languages ")
        BKGlobal.Cls1.FillDataSet(objDS.Tables("site"), "SELECT * from site ")
        'btnOK
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If CurrentDefaultSetID <> 0 Then
            BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
            'LoadDataSet()
            TabControl1.SelectedTabPage = TabResult
        Else
            TabControl1.SelectedTabPage = TabParameters
        End If
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub
    Public Overrides Sub LoadDataSet()
        Dim _SQLTxt As String
        'Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue)
        'Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue)
        'Clear Table
        objDS.Tables(TableName).Clear()
        _SQLTxt = "SELECT * FROM payment_offline_request por left join customers c on c.customers_id = por.customers_id " & _
            "  LEFT JOIN address_book ab on ab.customers_id = c.customers_id and ab.address_book_id = c.customers_default_address_id " & _
            " where por.payment_offline_status = " & clsCompta.clsOffLinePayments.StepDvdatHome.MAIL_TOSEND
        BKGlobal.Cls1.FillDataSet(objDS.Tables(TableName), _SQLTxt)
        objDS.Tables(TableName).Columns.Add("products_titles")
        Dim _row, _row1 As DataRow
        For Each _row In objDS.Tables(TableName).Rows
            objDS.Tables("Offline_DvdAtHome").Clear()
            _SQLTxt = "SELECT op.products_id, pd.products_name  FROM orders o " & _
                   " LEFT JOIN orders_products op on op.orders_id = o.orders_id " & _
                   " LEFT JOIN products_description pd on pd.products_id = op.products_id and language_id = " & _row.Item("customers_language") & _
                   " where o.customers_id = " & _row.Item("customers_id") & "  AND o.orders_status = 2 " 'Expidited Only   " & _CustRow.Item("customers_id") & " 
            BKGlobal.Cls1.FillDataSet(objDS.Tables("Offline_DvdAtHome"), _SQLTxt)
            For Each _row1 In objDS.Tables("Offline_DvdAtHome").Rows
                _row.Item("products_titles") = _row.Item("products_titles") & " - " & _row1.Item("products_name").ToString
            Next
            _row.Item("products_titles") = _row.Item("products_titles") & " - "
        Next
        Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
        TabControl1.SelectedTabPage = TabResult
    End Sub
    Private Sub btnUser1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick
        'Sending E-Mails
        Dim strFrom As String = "dvdpost@dvdpost.be"
        Dim strTo As String
        Dim strSubject As String = ""
        Dim strMessage As String = ""
        Dim _CustRow, _SiteRow As DataRow
        Dim _MailRow As DataRow
        Dim _i As Integer
        Dim intcustomers_language As Integer
        Dim sSQL2, sSQL3 As String
        Dim intmaxmailid As Integer
        Dim i As Integer
        sSQL3 = "SELECT max(mail_messages_sent_history_id) as cc  FROM mail_messages_sent_history  "
        'intmaxmailid = BKGlobal.ExecuteFindFieldValueINT("cc", sSQL3)
        For _i = 0 To GridView1.RowCount - 1
            _CustRow = GridView1.GetDataRow(_i)
            intcustomers_language = _CustRow.Item("customers_language")
            _SiteRow = objDS.Tables("site").Rows.Find(New Object() {_CustRow.Item("site")})
            If Not IsNothing(_SiteRow) Then
                mvarsite = _SiteRow.Item("site_link")
                mvarLogo = _SiteRow.Item("logo")
            Else
                mvarsite = "www.dvdpost.be"
                mvarLogo = "http://images.dvdpost.be/www3/logo.jpg"
            End If
            strTo = _CustRow.Item("customers_email_address")
            objDS.Tables("mail_messages").Clear()
            sSQL2 = "SELECT * FROM mail_messages WHERE mail_messages_id = '" & intmessages_id & "' and language_id = '" & intcustomers_language & "'"
            BKGlobal.Cls1.FillDataSet(objDS.Tables("mail_messages"), sSQL2)
            For Each _MailRow In objDS.Tables("mail_messages").Rows
                strSubject = _MailRow.Item("messages_subject")
                strMessage = _MailRow.Item("messages_html")
                'titre
                strMessage = Replace(strMessage, "$$$title$$$", _MailRow.Item("messages_title"))
                'customers_name
                strMessage = Replace(strMessage, "$$$customers_name$$$", _CustRow.Item("customers_firstname") & " " & _CustRow.Item("customers_lastname"))
                strMessage = Replace(strMessage, "$$$customers_email$$$", _CustRow.Item("customers_email_address"))
                strMessage = Replace(strMessage, "$$$email$$$", _CustRow.Item("customers_email_address"))
                'site & Logo
                strMessage = Replace(strMessage, "$$$site$$$", "<a href='" & mvarsite & " '>" & mvarsite & "</a>")
                strMessage = Replace(strMessage, "$$$site_link$$$", mvarsite)
                strMessage = Replace(strMessage, "$$$site_image$$$", "<a href='" & mvarsite & " '>")
                strMessage = Replace(strMessage, "$$$logo_dvdpost$$$", "<a href='" & mvarsite & " '> <img src='" & mvarLogo & "' border='0'> </a>")
                'today
                strMessage = Replace(strMessage, "$$$today$$$", Today())
                'mailid 
                strMessage = Replace(strMessage, "$$$mail_id$$$", intmaxmailid + 1)
                'customers_id
                strMessage = Replace(strMessage, "$$$customers_id$$$", _CustRow.Item("customers_id"))
                'customers_abo_validityto
                strMessage = Replace(strMessage, "$$$next_reconduction_date$$$", _CustRow.Item("customers_abo_validityto") & "")

                'Finding DVD@Home
                Dim _DS As New DataSet
                _DS.Tables.Add("TmpTable1")
                Dim _prodrow As DataRow
                Dim _SQL As String
                Dim _products_name As String = ""
                _SQL = "SELECT *  FROM orders o " & _
                       " LEFT JOIN orders_products op on op.orders_id = o.orders_id " & _
                       " LEFT JOIN products p on p.products_id = op.products_id " & _
                       " LEFT JOIN products_description pd on pd.products_id = op.products_id and language_id = " & intcustomers_language & _
                       " where o.customers_id = " & _CustRow.Item("customers_id") & "  AND o.orders_status = 2 " 'Expidited Only   " & _CustRow.Item("customers_id") & " 
                BKGlobal.Cls1.FillDataSet(_DS.Tables("TmpTable1"), _SQL)
                For Each _prodrow In _DS.Tables("TmpTable1").Rows
                    _products_name = _products_name & _prodrow.Item("products_name") & "<br/>"
                Next
                strMessage = Replace(strMessage, "$$$products_name$$$", _products_name)

                Dim mymail As New MailMessage(strFrom, strTo)
                mymail.From = New MailAddress(strFrom, "DVDPost")
                mymail.Subject = strSubject
                mymail.IsBodyHtml = True
                mymail.Body = strMessage
                Dim SmtpMail As New SmtpClient(mvarsmtpserver)
                SmtpMail.Credentials = New System.Net.NetworkCredential("Administrator", "DVD8(post")
                Try
                    SmtpMail.Send(mymail)
                Catch ex As Exception
                    ex.Message.ToString()
                End Try
                sSQL3 = "insert into mail_messages_sent_history (mail_messages_sent_history_id, date, customers_id, " & _
                        " mail_messages_id , language_id ) values('" & intmaxmailid + 1 & _
                        "', now(), '" & _CustRow.Item("customers_id") & "', '" & intmessages_id & "', '" & _
                        intcustomers_language & "' ) "
                BKGlobal.Cls1.ExecuteNonQuery(sSQL3)
                intmaxmailid += 1
            Next
            'Change OffLinePayment_Status to "Mail1 Sent"
            Dim _Offline As New clsCompta.clsOffLinePayments(SessionInfo, _CustRow.Item("payment_offline_request_id"))
            _Offline.UpdatePaymentOfflineStatus(False, False, Nothing, clsCompta.clsOffLinePayments.StepDvdatHome.MAIL_SENT)
        Next
        MsgBox("E-Mail Sent", MsgBoxStyle.Information)

    End Sub
    Private Sub btnUser2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser2.ItemClick
        'Check if DVD Was Received
        Dim _i As Integer
        Dim _CustRow As DataRow
        Dim _SQl As String
        Dim _DS As New DataSet
        _DS.Tables.Add("TmpTable1")
        Dim _OpenOrders As Integer
        For _i = 0 To GridView1.RowCount - 1
            _CustRow = GridView1.GetDataRow(_i)
            'Check for Open Orders
            _SQl = "SELECT count(*) as cnt FROM orders o where o.customers_id = " & _CustRow.Item("customers_id") & " AND o.orders_status = 2 " 'Expidited Only
            _OpenOrders = BKGlobal.ExecuteCount(_SQl)
            If _OpenOrders = 0 Then
                'Close Current Payment
                'Change OffLinePayment_Status to "Canceled"
                Dim _Offline As New clsCompta.clsOffLinePayments(SessionInfo, _CustRow.Item("payment_offline_request_id"))
                _Offline.UpdatePaymentOfflineStatus(False, False, Nothing, clsCompta.clsOffLinePayments.PAYMENT_OFFLINE_STATUS_CANCELED)
            End If
        Next
    End Sub


    Public Overrides Sub gridview1_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridView1.FocusedRowHandle < 0 Then
            Exit Sub
        End If
        Dim _frm As New frmCustomers_Maint(SessionInfo)
        _frm.MdiParent = Me.ParentForm
        _frm.Text = "Cust. Maint"
        _frm.Show()
        _frm.txtQuickSearch.EditValue = GridView1.GetDataRow(GridView1.FocusedRowHandle).Item("customers_id")
        _frm.CurrentCustomerID = _frm.txtQuickSearch.EditValue
        _frm.LoadCustomerInfo()
        _frm.XtraTabControl1.SelectedTabPage = _frm.tabMain
    End Sub



End Class
