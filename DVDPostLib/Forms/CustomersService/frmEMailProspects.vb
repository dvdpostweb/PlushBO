'Imports System.Web.Mail
Imports System.Net.Mail
Public Class frmEMailProspects
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
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents lblMessage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SBUpdateQuizz As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SBUpdateContest As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SBUpdateProspects As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SBInsertQuizzToProspects As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SBInsertContestToProspects As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SBResetLast_email_sended As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbMessage As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEMailProspects))
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.lblMessage = New DevExpress.XtraEditors.LabelControl
        Me.cmbMessage = New DevExpress.XtraEditors.LookUpEdit
        Me.SBUpdateQuizz = New DevExpress.XtraEditors.SimpleButton
        Me.SBUpdateContest = New DevExpress.XtraEditors.SimpleButton
        Me.SBUpdateProspects = New DevExpress.XtraEditors.SimpleButton
        Me.SBInsertQuizzToProspects = New DevExpress.XtraEditors.SimpleButton
        Me.SBInsertContestToProspects = New DevExpress.XtraEditors.SimpleButton
        Me.SBResetLast_email_sended = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabParameters.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.TabChart.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        resources.ApplyResources(Me.StatusBar1, "StatusBar1")
        Me.ToolTipController1.SetSuperTip(Me.StatusBar1, Nothing)
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.ToolTipController1.SetSuperTip(Me.Panel1, Nothing)
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.SelectedTabPage = Me.TabResult
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.SBResetLast_email_sended)
        Me.TabParameters.Controls.Add(Me.SBInsertContestToProspects)
        Me.TabParameters.Controls.Add(Me.SBInsertQuizzToProspects)
        Me.TabParameters.Controls.Add(Me.SBUpdateProspects)
        Me.TabParameters.Controls.Add(Me.SBUpdateContest)
        Me.TabParameters.Controls.Add(Me.SBUpdateQuizz)
        Me.TabParameters.Controls.Add(Me.lblMessage)
        Me.TabParameters.Controls.Add(Me.cmbMessage)
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
        Me.ToolTipController1.SetSuperTip(Me.UcPivotGrid1, Nothing)
        '
        'UcChart1
        '
        resources.ApplyResources(Me.UcChart1, "UcChart1")
        Me.ToolTipController1.SetSuperTip(Me.UcChart1, Nothing)
        '
        'TabChart
        '
        resources.ApplyResources(Me.TabChart, "TabChart")
        '
        'lblMessage
        '
        resources.ApplyResources(Me.lblMessage, "lblMessage")
        Me.lblMessage.Name = "lblMessage"
        Me.HelpProvider1.SetShowHelp(Me.lblMessage, CType(resources.GetObject("lblMessage.ShowHelp"), Boolean))
        '
        'cmbMessage
        '
        resources.ApplyResources(Me.cmbMessage, "cmbMessage")
        Me.cmbMessage.Name = "cmbMessage"
        Me.cmbMessage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbMessage.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbMessage.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mail_messages_id", "mail_messages_id", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("messages_subject", "messages_subject", 94, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comment", "", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbMessage.Properties.DisplayMember = "messages_subject"
        Me.cmbMessage.Properties.NullText = resources.GetString("cmbMessage.Properties.NullText")
        Me.cmbMessage.Properties.ValueMember = "mail_messages_id"
        Me.HelpProvider1.SetShowHelp(Me.cmbMessage, CType(resources.GetObject("cmbMessage.ShowHelp"), Boolean))
        '
        'SBUpdateQuizz
        '
        resources.ApplyResources(Me.SBUpdateQuizz, "SBUpdateQuizz")
        Me.SBUpdateQuizz.Name = "SBUpdateQuizz"
        '
        'SBUpdateContest
        '
        resources.ApplyResources(Me.SBUpdateContest, "SBUpdateContest")
        Me.SBUpdateContest.Name = "SBUpdateContest"
        Me.HelpProvider1.SetShowHelp(Me.SBUpdateContest, CType(resources.GetObject("SBUpdateContest.ShowHelp"), Boolean))
        '
        'SBUpdateProspects
        '
        resources.ApplyResources(Me.SBUpdateProspects, "SBUpdateProspects")
        Me.SBUpdateProspects.Name = "SBUpdateProspects"
        Me.HelpProvider1.SetShowHelp(Me.SBUpdateProspects, CType(resources.GetObject("SBUpdateProspects.ShowHelp"), Boolean))
        '
        'SBInsertQuizzToProspects
        '
        resources.ApplyResources(Me.SBInsertQuizzToProspects, "SBInsertQuizzToProspects")
        Me.SBInsertQuizzToProspects.Name = "SBInsertQuizzToProspects"
        Me.HelpProvider1.SetShowHelp(Me.SBInsertQuizzToProspects, CType(resources.GetObject("SBInsertQuizzToProspects.ShowHelp"), Boolean))
        '
        'SBInsertContestToProspects
        '
        resources.ApplyResources(Me.SBInsertContestToProspects, "SBInsertContestToProspects")
        Me.SBInsertContestToProspects.Name = "SBInsertContestToProspects"
        Me.HelpProvider1.SetShowHelp(Me.SBInsertContestToProspects, CType(resources.GetObject("SBInsertContestToProspects.ShowHelp"), Boolean))
        '
        'SBResetLast_email_sended
        '
        resources.ApplyResources(Me.SBResetLast_email_sended, "SBResetLast_email_sended")
        Me.SBResetLast_email_sended.Name = "SBResetLast_email_sended"
        Me.HelpProvider1.SetShowHelp(Me.SBResetLast_email_sended, CType(resources.GetObject("SBResetLast_email_sended.ShowHelp"), Boolean))
        '
        'frmEMailProspects
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmEMailProspects"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.ToolTipController1.SetSuperTip(Me, Nothing)
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        Me.TabParameters.PerformLayout()
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabChart.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim mvarsmtpserver As String = "" '"192.168.0.203"
    Dim mvarsmtpserverlogin As String = ""
    Dim mvarsmtpserverpassword As String = ""
    Dim mvarsite As String = "" '"www.dvdpost.be"
    Dim mvarLogo As String = ""
    Dim intmessages_id As Integer = 0 '94



    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip


        objDS = New dsCustomers
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "propsects"
        MyBase.IDField = "customers_id"
        MyBase.NameField = "customers_lastname"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = False
        MyBase.StartUp()
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser1.Caption = "SEND E-Mails"

        DvdPostData.clsConnection.FillDataSet(objDS.Tables("mail_messages1"), "SELECT * from mail_messages WHERE language_id = 1")
        cmbMessage.Properties.DataSource = objDS.Tables("mail_messages1")
        mvarsmtpserver = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'SMTPServer'")
        mvarsmtpserverlogin = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'SMTPServerLogin'")
        mvarsmtpserverpassword = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'SMTPServerPassWord'")
        'mvarsite = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'BESite'")
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("languages"), "SELECT * from languages ")
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("site"), "SELECT * from site ")

        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
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
    Public Overrides Sub LoadDataSet()
        'Create a new dataset to hold the records returned from the call to FillDataSet.
        'A temporary dataset is used because filling the existing dataset would
        'require the databindings to be rebound.
        'ToBeChecked *** Change DataSet to use
        If IsDBNull(cmbMessage.EditValue) Then
            Exit Sub
        End If
        intmessages_id = cmbMessage.EditValue
        SQLTxt1 = "SELECT customers_id, customers_firstname, customers_lastname, customers_email_address, customers_language, site,  " & _
                  " EntityID, selected_for_email , unsubscribe, is_email_valid, last_email_sended " & _
                  " FROM prospects "

        Dim _SQLTxt As String = SQLTxt1
        If IsNothing(objDS.Tables(TableName)) Then
            objDS.Tables.Add(TableName)
        Else
            objDS.Tables(TableName).Clear()
        End If

        Try
            'Only Appropriate Entity
            'OledbAdpat = New OleDb.OleDbDataAdapter(_SQLTxt, SessionInfo.OleDBConn)
            BKFilter.ApplyFilter(_SQLTxt, IsFiltered, CurrentFilterID, WhereClause & "", StatusBar1.Panels(1))
            'Attempt to fill the temporary dataset.
            'OrderByClause = " GROUP BY customers_id"
            Cls1.FillDataSet(objDS.Tables(TableName), _SQLTxt & " " & OrderByClause)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            'objDS.Clear()
            'Merge the records into the main dataset.
            'objDS.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try
        objDS.Tables(TableName).DefaultView.Sort = NameField
        Grid1.DataSource = objDS.Tables(TableName).DefaultView
        UcPivotGrid1.PivotGrid1.DataSource = objDS.Tables(TableName).DefaultView
        TabControl1.SelectedTabPage = TabResult
    End Sub

    'Public Overrides Sub LoadDataSet()
    '    Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
    '    Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
    '    Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
    '    TabControl1.SelectedTabPage = TabResult
    'End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub
    Private Sub btnUser1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick
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
        Dim tabErreur As New ArrayList()
        sSQL3 = "SELECT max(mail_messages_sent_history_id) as cc  FROM mail_messages_sent_history  "
        intmaxmailid = BKGlobal.ExecuteFindFieldValueINT("cc", sSQL3)
        If IsDBNull(cmbMessage.EditValue) Then
            Exit Sub
        End If
        intmessages_id = cmbMessage.EditValue
        For _i = 0 To GridView1.RowCount - 1
            _CustRow = GridView1.GetDataRow(_i)
            intcustomers_language = _CustRow("customers_language")
            _SiteRow = objDS.Tables("site").Rows.Find(New Object() {_CustRow("site")})
            If Not IsNothing(_SiteRow) Then
                mvarsite = _SiteRow("site_link")
                mvarLogo = _SiteRow("logo")
            Else
                mvarsite = "http://www.dvdpost.be"
                mvarLogo = "http://www.dvdpost.be/images/www3/logo.jpg"
            End If
            strTo = _CustRow("customers_email_address")
            objDS.Tables("mail_messages").Clear()
            sSQL2 = "SELECT * FROM mail_messages WHERE mail_messages_id = '" & intmessages_id & "' and language_id = '" & intcustomers_language & "'"
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("mail_messages"), sSQL2)
            For Each _MailRow In objDS.Tables("mail_messages").Rows
                Try
                    strSubject = _MailRow("messages_subject")
                    strMessage = _MailRow("messages_html")
                    'titre
                    strMessage = Replace(strMessage, "$$$title$$$", _MailRow("messages_title"))
                    'customers_name
                    strMessage = Replace(strMessage, "$$$customers_name$$$", _CustRow("customers_firstname") & " " & _CustRow("customers_lastname"))
                    strMessage = Replace(strMessage, "$$$customers_email$$$", _CustRow("customers_email_address"))
                    'site & Logo
                    strMessage = Replace(strMessage, "$$$site$$$", "<a href='" & mvarsite & " '>" & mvarsite & "</a>")
                    strMessage = Replace(strMessage, "$$$site_image$$$", "<a href='" & mvarsite & " '>")
                    strMessage = Replace(strMessage, "$$$logo_dvdpost$$$", "<a href='" & mvarsite & " '> <img src='" & mvarLogo & "' border='0'> </a>")
                    'today
                    strMessage = Replace(strMessage, "$$$today$$$", Today())
                    'mailid 
                    strMessage = Replace(strMessage, "$$$mail_id$$$", intmaxmailid + 1)
                    strMessage = Replace(strMessage, "$$$email$$$", strTo)
                    'customers_id
                    strMessage = Replace(strMessage, "$$$customers_id$$$", _CustRow("customers_id"))
                    strMessage = Replace(strMessage, "$$$site$$$", "<a href='" & mvarsite & " '>" & mvarsite & "</a>")
                    strMessage = Replace(strMessage, "$$$site_link$$$", mvarsite)
                    strMessage = Replace(strMessage, "$$$site_image$$$", "<a href='" & mvarsite & " '>")
                    strMessage = Replace(strMessage, "$$$logo_dvdpost$$$", "<a href='" & mvarsite & " '> <img src='" & mvarLogo & "' border='0'> </a>")


                    Dim mymail As New MailMessage(strFrom, strTo)

                    'mymail.From = strFrom
                    'mymail.To = strTo
                    mymail.Subject = strSubject
                    mymail.IsBodyHtml = True
                    mymail.Body = strMessage
                    'mymail.BodyFormat = MailFormat.Html
                    'mymail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1")
                    'mymail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "Administrator")
                    'mymail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "DVD8(post")
                    'SmtpMail.SmtpServer = mvarsmtpserver
                    Dim SmtpMail As New SmtpClient(mvarsmtpserver)
                    SmtpMail.Credentials = New System.Net.NetworkCredential(mvarsmtpserverlogin, mvarsmtpserverpassword)

                    SmtpMail.Send(mymail)

                    sSQL3 = "update prospects set last_email_sended = 1 where customers_email_address = '" & strTo & "'"
                    DvdPostData.clsConnection.ExecuteNonQuery(sSQL3)
                    intmaxmailid += 1

                Catch ex As SmtpException
                    tabErreur.Add("problem of connection smtp: " + "cutomers_id : " + _CustRow("customers_id").ToString + " invalid email")
                Catch ex As ObjectDisposedException
                    'stop la procedure
                    MsgBox(ex.Message)
                    Exit Sub
                Catch ex As InvalidCastException
                    tabErreur.Add("cutomers_id : " + _CustRow("customers_id").ToString + ex.Message.ToString)
                Catch ex As Exception
                    tabErreur.Add("email: " + strTo + " " + ex.Message.ToString)
                End Try
            Next
        Next
        'ajoutte les erreurs à la liste  dans la form errorList
        If tabErreur.Count <> 0 Then
            Dim listError As New errorList()
            For Each el As String In tabErreur
                listError.ListError.Items.Add(el)
            Next
            listError.Show()
        End If
        MsgBox("Done", MsgBoxStyle.Information)
    End Sub


    Private Sub SBUpdateQuizz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBUpdateQuizz.Click
        Dim sSQL As String

        sSQL = "update quizz q " & _
                " inner join prospects p on q.email = p.customers_email_address" & _
                " set q.is_in_prospects = 1" & _
                " where q.is_in_prospects = 0"

        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)

        sSQL = "update quizz q " & _
                " inner join customers c on q.email = c.customers_email_address" & _
                " set q.customers_id = c.customers_id" & _
                " where q.customers_id = 0 and q.is_in_prospects = 0"

        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)
        '    sSQL = "set SQL_BIG_SELECTS = 1"
        '    DvdPostData.clsConnection.ExecuteNonQuery(sSQL)
        '    sSQL = "update quizz q1" & _
        '           " inner join quizz q2 on q1.email = q2.email" & _
        '           " set q1.unsubscribe = 1 " & _
        '           " where(q1.unsubscribe = 0 and q1.is_in_prospects = 0)" & _
        '           " and q2.unsubscribe = 1"

        '    DvdPostData.clsConnection.ExecuteNonQuery(sSQL)
    End Sub


    Private Sub SBUpdateContest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBUpdateContest.Click
        Dim sSQL As String

        sSQL = "update contest q " & _
                " inner join customers c on q.email = c.customers_email_address" & _
                " set q.customers_id = c.customers_id" & _
                " where q.customers_id = 0"

        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)

        sSQL = "update contest q " & _
                " inner join prospects p on q.email = p.customers_email_address" & _
                " set q.is_in_prospects = 1" & _
                " where q.is_in_prospects = 0"

        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)

        'sSQL = "update contest c1" & _
        '       " inner join contest c2 on c1.email = c2.email" & _
        '       " set c1.unsubscribe = 1 " & _
        '       " where(c1.unsubscribe = 0)" & _
        '       " and c2.unsubscribe = 1"

        'DvdPostData.clsConnection.ExecuteNonQuery(sSQL)

    End Sub

    Private Sub SBUpdateProspects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBUpdateProspects.Click
        Dim sSQL As String

        sSQL = "update prospects p " & _
                " inner join customers c on p.customers_email_address = c.customers_email_address" & _
                " set p.customers_id = c.customers_id" & _
                " where p.customers_id = 0"
        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)

        sSQL = "update prospects p " & _
               " inner join quizz q on q.email = p.customers_email_address" & _
               " set p.unsubscribe = 1" & _
               " where p.unsubscribe = 0 and q.unsubscribe = 1"
        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)

        sSQL = "update prospects p " & _
               " inner join contest c on c.email = p.customers_email_address" & _
               " set p.unsubscribe = 1" & _
               " where p.unsubscribe = 0 and c.unsubscribe = 1"
        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)

        sSQL = "update prospects" & _
               " set is_email_valid = 1" & _
               " where customers_email_address REGEXP '^[a-zA-Z0-9][a-zA-Z0-9._-]*[a-zA-Z0-9]@[a-zA-Z0-9][a-zA-Z0-9._-]*[a-zA-Z0-9]\.[a-zA-Z]{2,4}$'"
        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)



    End Sub

    Private Sub SBInsertQuizzToProspects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBInsertQuizzToProspects.Click
        Dim sSQL As String

        sSQL = "insert into prospects" & _
               " select q.customers_id, '', '',q.email, q.language_id,q.site,q.entityID, '', '', unsubscribe, 1, 0" & _
               " from quizz q" & _
               " where email REGEXP '^[a-zA-Z0-9][a-zA-Z0-9._-]*[a-zA-Z0-9]@[a-zA-Z0-9][a-zA-Z0-9._-]*[a-zA-Z0-9]\.[a-zA-Z]{2,4}$' and unsubscribe = 0 and is_in_prospects = 0" & _
               " group by email"
        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)
    End Sub

    Private Sub SBInsertContestToProspects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBInsertContestToProspects.Click
        Dim sSQL As String

        sSQL = "insert into prospects" & _
               " select c.customers_id, '', '', c.email, c.language_id, c.site,c.entityID, '', '', c.unsubscribe, 1, 0" & _
               " from contest c" & _
               " where email REGEXP '^[a-zA-Z0-9][a-zA-Z0-9._-]*[a-zA-Z0-9]@[a-zA-Z0-9][a-zA-Z0-9._-]*[a-zA-Z0-9]\.[a-zA-Z]{2,4}$' and unsubscribe = 0  and c.is_in_prospects = 0" & _
               " group by email"
        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)

    End Sub

    Private Sub SBResetLast_email_sended_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBResetLast_email_sended.Click
        Dim sSQL As String

        sSQL = "update prospects" & _
               " set last_email_sended = 0"
        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)
    End Sub

End Class
