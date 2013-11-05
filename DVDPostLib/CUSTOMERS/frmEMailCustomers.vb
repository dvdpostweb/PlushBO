Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text



Public Class frmEMailCustomers
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

    Friend WithEvents checkMemGetm As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckVodx As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckPartnerShip As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GBFilter As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckDateLastOrder As DevExpress.XtraEditors.CheckEdit

    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents lblMessage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CECustomersAcceptNews As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CEPartnersAcceptNews As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CEAboStoppedSince As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SEAboStoppedDelay As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CEResetPassword As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CEActivationCode As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CELAstAboAction As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SBTest As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TETestEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupFieldEmail As System.Windows.Forms.GroupBox
    Friend WithEvents LblDiscount As System.Windows.Forms.Label
    Friend WithEvents txtDiscUse As System.Windows.Forms.TextBox
    Friend WithEvents lblValueMgm As System.Windows.Forms.Label
    Friend WithEvents TextValue As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblStrFrom As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStrFrom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEmailName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents textEmailName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupEmailFrom As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbMessage As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEMailCustomers))
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.GroupFieldEmail = New System.Windows.Forms.GroupBox
        Me.CheckDateLastOrder = New DevExpress.XtraEditors.CheckEdit
        Me.checkMemGetm = New DevExpress.XtraEditors.CheckEdit
        Me.CELAstAboAction = New DevExpress.XtraEditors.CheckEdit
        Me.CheckVodx = New DevExpress.XtraEditors.CheckEdit
        Me.CEResetPassword = New DevExpress.XtraEditors.CheckEdit
        Me.CheckPartnerShip = New DevExpress.XtraEditors.CheckEdit
        Me.CEActivationCode = New DevExpress.XtraEditors.CheckEdit
        Me.lblValueMgm = New System.Windows.Forms.Label
        Me.txtDiscUse = New System.Windows.Forms.TextBox
        Me.TextValue = New System.Windows.Forms.TextBox
        Me.LblDiscount = New System.Windows.Forms.Label
        Me.GBFilter = New System.Windows.Forms.GroupBox
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.CECustomersAcceptNews = New DevExpress.XtraEditors.CheckEdit
        Me.CEPartnersAcceptNews = New DevExpress.XtraEditors.CheckEdit
        Me.CEAboStoppedSince = New DevExpress.XtraEditors.CheckEdit
        Me.SEAboStoppedDelay = New DevExpress.XtraEditors.SpinEdit
        Me.GroupEmailFrom = New System.Windows.Forms.GroupBox
        Me.lblMessage = New DevExpress.XtraEditors.LabelControl
        Me.cmbMessage = New DevExpress.XtraEditors.LookUpEdit
        Me.TETestEmail = New DevExpress.XtraEditors.TextEdit
        Me.SBTest = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtStrFrom = New DevExpress.XtraEditors.TextEdit
        Me.lblStrFrom = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.lblEmailName = New DevExpress.XtraEditors.LabelControl
        Me.textEmailName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
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
        Me.GroupFieldEmail.SuspendLayout()
        CType(Me.CheckDateLastOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkMemGetm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CELAstAboAction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckVodx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEResetPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckPartnerShip.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEActivationCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBFilter.SuspendLayout()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CECustomersAcceptNews.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEPartnersAcceptNews.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEAboStoppedSince.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEAboStoppedDelay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupEmailFrom.SuspendLayout()
        CType(Me.cmbMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TETestEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStrFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEmailName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabParameters.Controls.Add(Me.GroupEmailFrom)
        Me.TabParameters.Controls.Add(Me.GBFilter)
        Me.TabParameters.Controls.Add(Me.GroupFieldEmail)
        Me.TabParameters.Controls.Add(Me.SBTest)
        Me.TabParameters.Controls.Add(Me.LabelControl2)
        Me.TabParameters.Controls.Add(Me.TETestEmail)
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
        'GroupFieldEmail
        '
        Me.GroupFieldEmail.Controls.Add(Me.CheckDateLastOrder)
        Me.GroupFieldEmail.Controls.Add(Me.checkMemGetm)
        Me.GroupFieldEmail.Controls.Add(Me.CELAstAboAction)
        Me.GroupFieldEmail.Controls.Add(Me.CheckVodx)
        Me.GroupFieldEmail.Controls.Add(Me.CEResetPassword)
        Me.GroupFieldEmail.Controls.Add(Me.CheckPartnerShip)
        Me.GroupFieldEmail.Controls.Add(Me.CEActivationCode)
        Me.GroupFieldEmail.Controls.Add(Me.lblValueMgm)
        Me.GroupFieldEmail.Controls.Add(Me.txtDiscUse)
        Me.GroupFieldEmail.Controls.Add(Me.TextValue)
        Me.GroupFieldEmail.Controls.Add(Me.LblDiscount)
        resources.ApplyResources(Me.GroupFieldEmail, "GroupFieldEmail")
        Me.GroupFieldEmail.Name = "GroupFieldEmail"
        Me.HelpProvider1.SetShowHelp(Me.GroupFieldEmail, CType(resources.GetObject("GroupFieldEmail.ShowHelp"), Boolean))
        Me.ToolTipController1.SetSuperTip(Me.GroupFieldEmail, Nothing)
        Me.GroupFieldEmail.TabStop = False
        '
        'CheckDateLastOrder
        '
        Me.CheckDateLastOrder.AllowDrop = True
        resources.ApplyResources(Me.CheckDateLastOrder, "CheckDateLastOrder")
        Me.CheckDateLastOrder.Name = "CheckDateLastOrder"
        Me.CheckDateLastOrder.Properties.Caption = resources.GetString("CheckDateLastOrder.Properties.Caption")
        Me.HelpProvider1.SetShowHelp(Me.CheckDateLastOrder, CType(resources.GetObject("CheckDateLastOrder.ShowHelp"), Boolean))
        '
        'checkMemGetm
        '
        resources.ApplyResources(Me.checkMemGetm, "checkMemGetm")
        Me.checkMemGetm.Name = "checkMemGetm"
        Me.checkMemGetm.Properties.Caption = resources.GetString("checkMemGetm.Properties.Caption")
        Me.HelpProvider1.SetShowHelp(Me.checkMemGetm, CType(resources.GetObject("checkMemGetm.ShowHelp"), Boolean))
        '
        'CELAstAboAction
        '
        resources.ApplyResources(Me.CELAstAboAction, "CELAstAboAction")
        Me.CELAstAboAction.Name = "CELAstAboAction"
        Me.CELAstAboAction.Properties.Caption = resources.GetString("CELAstAboAction.Properties.Caption")
        Me.HelpProvider1.SetShowHelp(Me.CELAstAboAction, CType(resources.GetObject("CELAstAboAction.ShowHelp"), Boolean))
        '
        'CheckVodx
        '
        resources.ApplyResources(Me.CheckVodx, "CheckVodx")
        Me.CheckVodx.Name = "CheckVodx"
        Me.CheckVodx.Properties.Caption = resources.GetString("CheckVodx.Properties.Caption")
        Me.HelpProvider1.SetShowHelp(Me.CheckVodx, CType(resources.GetObject("CheckVodx.ShowHelp"), Boolean))
        '
        'CEResetPassword
        '
        resources.ApplyResources(Me.CEResetPassword, "CEResetPassword")
        Me.CEResetPassword.Name = "CEResetPassword"
        Me.CEResetPassword.Properties.Caption = resources.GetString("CEResetPassword.Properties.Caption")
        Me.HelpProvider1.SetShowHelp(Me.CEResetPassword, CType(resources.GetObject("CEResetPassword.ShowHelp"), Boolean))
        '
        'CheckPartnerShip
        '
        Me.CheckPartnerShip.AllowDrop = True
        resources.ApplyResources(Me.CheckPartnerShip, "CheckPartnerShip")
        Me.CheckPartnerShip.Name = "CheckPartnerShip"
        Me.CheckPartnerShip.Properties.Caption = resources.GetString("CheckPartnerShip.Properties.Caption")
        Me.HelpProvider1.SetShowHelp(Me.CheckPartnerShip, CType(resources.GetObject("CheckPartnerShip.ShowHelp"), Boolean))
        '
        'CEActivationCode
        '
        resources.ApplyResources(Me.CEActivationCode, "CEActivationCode")
        Me.CEActivationCode.Name = "CEActivationCode"
        Me.CEActivationCode.Properties.Caption = resources.GetString("CEActivationCode.Properties.Caption")
        Me.HelpProvider1.SetShowHelp(Me.CEActivationCode, CType(resources.GetObject("CEActivationCode.ShowHelp"), Boolean))
        '
        'lblValueMgm
        '
        resources.ApplyResources(Me.lblValueMgm, "lblValueMgm")
        Me.lblValueMgm.Name = "lblValueMgm"
        Me.HelpProvider1.SetShowHelp(Me.lblValueMgm, CType(resources.GetObject("lblValueMgm.ShowHelp"), Boolean))
        Me.ToolTipController1.SetSuperTip(Me.lblValueMgm, Nothing)
        '
        'txtDiscUse
        '
        resources.ApplyResources(Me.txtDiscUse, "txtDiscUse")
        Me.txtDiscUse.Name = "txtDiscUse"
        Me.ToolTipController1.SetSuperTip(Me.txtDiscUse, Nothing)
        '
        'TextValue
        '
        resources.ApplyResources(Me.TextValue, "TextValue")
        Me.TextValue.Name = "TextValue"
        Me.HelpProvider1.SetShowHelp(Me.TextValue, CType(resources.GetObject("TextValue.ShowHelp"), Boolean))
        Me.ToolTipController1.SetSuperTip(Me.TextValue, Nothing)
        '
        'LblDiscount
        '
        resources.ApplyResources(Me.LblDiscount, "LblDiscount")
        Me.LblDiscount.Name = "LblDiscount"
        Me.HelpProvider1.SetShowHelp(Me.LblDiscount, CType(resources.GetObject("LblDiscount.ShowHelp"), Boolean))
        Me.ToolTipController1.SetSuperTip(Me.LblDiscount, Nothing)
        '
        'GBFilter
        '
        Me.GBFilter.Controls.Add(Me.LabelControl1)
        Me.GBFilter.Controls.Add(Me.LabelControl3)
        Me.GBFilter.Controls.Add(Me.txtToDate)
        Me.GBFilter.Controls.Add(Me.txtFromDate)
        Me.GBFilter.Controls.Add(Me.CECustomersAcceptNews)
        Me.GBFilter.Controls.Add(Me.CEPartnersAcceptNews)
        Me.GBFilter.Controls.Add(Me.CEAboStoppedSince)
        Me.GBFilter.Controls.Add(Me.SEAboStoppedDelay)
        resources.ApplyResources(Me.GBFilter, "GBFilter")
        Me.GBFilter.Name = "GBFilter"
        Me.HelpProvider1.SetShowHelp(Me.GBFilter, CType(resources.GetObject("GBFilter.ShowHelp"), Boolean))
        Me.ToolTipController1.SetSuperTip(Me.GBFilter, Nothing)
        Me.GBFilter.TabStop = False
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, CType(resources.GetObject("LabelControl1.ShowHelp"), Boolean))
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl3, CType(resources.GetObject("LabelControl3.ShowHelp"), Boolean))
        '
        'txtToDate
        '
        Me.txtToDate.EditValue = Nothing
        resources.ApplyResources(Me.txtToDate, "txtToDate")
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtToDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtToDate, CType(resources.GetObject("txtToDate.ShowHelp"), Boolean))
        '
        'txtFromDate
        '
        Me.txtFromDate.EditValue = Nothing
        resources.ApplyResources(Me.txtFromDate, "txtFromDate")
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtFromDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtFromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtFromDate, CType(resources.GetObject("txtFromDate.ShowHelp"), Boolean))
        '
        'CECustomersAcceptNews
        '
        resources.ApplyResources(Me.CECustomersAcceptNews, "CECustomersAcceptNews")
        Me.CECustomersAcceptNews.Name = "CECustomersAcceptNews"
        Me.CECustomersAcceptNews.Properties.Caption = resources.GetString("CECustomersAcceptNews.Properties.Caption")
        '
        'CEPartnersAcceptNews
        '
        resources.ApplyResources(Me.CEPartnersAcceptNews, "CEPartnersAcceptNews")
        Me.CEPartnersAcceptNews.Name = "CEPartnersAcceptNews"
        Me.CEPartnersAcceptNews.Properties.Caption = resources.GetString("CEPartnersAcceptNews.Properties.Caption")
        Me.HelpProvider1.SetShowHelp(Me.CEPartnersAcceptNews, CType(resources.GetObject("CEPartnersAcceptNews.ShowHelp"), Boolean))
        '
        'CEAboStoppedSince
        '
        resources.ApplyResources(Me.CEAboStoppedSince, "CEAboStoppedSince")
        Me.CEAboStoppedSince.Name = "CEAboStoppedSince"
        Me.CEAboStoppedSince.Properties.Caption = resources.GetString("CEAboStoppedSince.Properties.Caption")
        '
        'SEAboStoppedDelay
        '
        resources.ApplyResources(Me.SEAboStoppedDelay, "SEAboStoppedDelay")
        Me.SEAboStoppedDelay.Name = "SEAboStoppedDelay"
        Me.SEAboStoppedDelay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'GroupEmailFrom
        '
        Me.GroupEmailFrom.Controls.Add(Me.txtStrFrom)
        Me.GroupEmailFrom.Controls.Add(Me.LabelControl5)
        Me.GroupEmailFrom.Controls.Add(Me.lblStrFrom)
        Me.GroupEmailFrom.Controls.Add(Me.textEmailName)
        Me.GroupEmailFrom.Controls.Add(Me.lblEmailName)
        Me.GroupEmailFrom.Controls.Add(Me.LabelControl4)
        resources.ApplyResources(Me.GroupEmailFrom, "GroupEmailFrom")
        Me.GroupEmailFrom.Name = "GroupEmailFrom"
        Me.HelpProvider1.SetShowHelp(Me.GroupEmailFrom, CType(resources.GetObject("GroupEmailFrom.ShowHelp"), Boolean))
        Me.ToolTipController1.SetSuperTip(Me.GroupEmailFrom, Nothing)
        Me.GroupEmailFrom.TabStop = False
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
        'TETestEmail
        '
        resources.ApplyResources(Me.TETestEmail, "TETestEmail")
        Me.TETestEmail.Name = "TETestEmail"
        '
        'SBTest
        '
        resources.ApplyResources(Me.SBTest, "SBTest")
        Me.SBTest.Name = "SBTest"
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, CType(resources.GetObject("LabelControl2.ShowHelp"), Boolean))
        '
        'txtStrFrom
        '
        resources.ApplyResources(Me.txtStrFrom, "txtStrFrom")
        Me.txtStrFrom.Name = "txtStrFrom"
        Me.HelpProvider1.SetShowHelp(Me.txtStrFrom, CType(resources.GetObject("txtStrFrom.ShowHelp"), Boolean))
        '
        'lblStrFrom
        '
        resources.ApplyResources(Me.lblStrFrom, "lblStrFrom")
        Me.lblStrFrom.Name = "lblStrFrom"
        Me.HelpProvider1.SetShowHelp(Me.lblStrFrom, CType(resources.GetObject("lblStrFrom.ShowHelp"), Boolean))
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl4, CType(resources.GetObject("LabelControl4.ShowHelp"), Boolean))
        '
        'lblEmailName
        '
        resources.ApplyResources(Me.lblEmailName, "lblEmailName")
        Me.lblEmailName.Name = "lblEmailName"
        Me.HelpProvider1.SetShowHelp(Me.lblEmailName, CType(resources.GetObject("lblEmailName.ShowHelp"), Boolean))
        '
        'textEmailName
        '
        resources.ApplyResources(Me.textEmailName, "textEmailName")
        Me.textEmailName.Name = "textEmailName"
        Me.HelpProvider1.SetShowHelp(Me.textEmailName, CType(resources.GetObject("textEmailName.ShowHelp"), Boolean))
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl5, CType(resources.GetObject("LabelControl5.ShowHelp"), Boolean))
        '
        'frmEMailCustomers
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmEMailCustomers"
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
        Me.GroupFieldEmail.ResumeLayout(False)
        Me.GroupFieldEmail.PerformLayout()
        CType(Me.CheckDateLastOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkMemGetm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CELAstAboAction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckVodx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEResetPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckPartnerShip.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEActivationCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBFilter.ResumeLayout(False)
        Me.GBFilter.PerformLayout()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CECustomersAcceptNews.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEPartnersAcceptNews.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEAboStoppedSince.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEAboStoppedDelay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupEmailFrom.ResumeLayout(False)
        Me.GroupEmailFrom.PerformLayout()
        CType(Me.cmbMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TETestEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStrFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEmailName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "
    Dim mvarsmtpserver As String = "" '"192.168.0.203"
    Dim mvarsite As String = "" '"www.dvdpost.be"
    Dim mvarLogo As String = ""
    Dim intmessages_id As Integer = 0 '94
    Dim _istest As Boolean = True


    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim menuStip As New PlushBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStip

        objDS = New DataSet()
        Dim dt As DataTable
        'dt = New DataTable()
        'dt.TableName = "customers_view1"
        'objDS.Tables.Add(dt)

        MyBase.TableName = "customers_view1"
        'MyBase.TableName = "mass_email_view"
        'MyBase.IDField = "customers_id"
        'MyBase.NameField = "customers_lastname"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = True
        MyBase.StartUp()


        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False

        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser1.Caption = "SEND E-Mails"


        dt = PlushData.clsConnection.FillDataSet(PlushData.clsMassEmail.getAllMailMessages)
        dt.TableName = "mail_messages1"
        objDS.Tables.Add(dt)
        cmbMessage.Properties.DataSource = dt
        mvarsmtpserver = BKGlobal.ExecuteFindFieldValue("ParamValue", PlushData.clsMassEmail.getSmtpServer)
        'mvarsite = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'BESite'")

        dt = PlushData.clsConnection.FillDataSet(PlushData.clsMassEmail.getLanguages)
        dt.TableName = "languages"
        objDS.Tables.Add(dt)


        'dt = DvdPostData.clsConnection.FillDataSet(DvdPostData.clsMassEmail.getSite)
        'dt.TableName = "site"
        'objDS.Tables.Add(dt)


        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, True, False, False, False, False, False, False)
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
        'btnFilter.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'btnPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'btnDefault.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'cmbFilterList.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'cmbDefaultList.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'cmbReportList.Visibility = DevExpress.XtraBars.BarItemVisibility.Never


        ' load a datset in a combobox "cmdcadeau"
        'objDS.Tables.Add("cadeaux")
        'loadCmbCadeaux()


    End Sub

    Public Overrides Sub LoadDataSet()

        If IsDBNull(cmbMessage.EditValue) OrElse cmbMessage.EditValue = 0 Then
            Dim dt As New DataTable()
            ' chargement bidon a cause de bizkey !!!
            dt = PlushData.clsConnection.FillDataSet("select * from customers where customers_id = 0")
            dt.DefaultView().Sort = NameField
            Grid1.DataSource = dt.DefaultView()
            UcPivotGrid1.PivotGrid1.DataSource = dt.DefaultView
            dt.TableName = TableName
            objDS.Tables.Add(dt)

            Exit Sub
        End If
        intmessages_id = cmbMessage.EditValue
        If Me.CheckPartnerShip.Checked = True And Me.txtDiscUse.Text <> "" Then

            LoadPartnerShip()

        Else

            Dim _SQLTxt As String = SQLTxt1

            Dim custNewsLetter As Boolean = 0
            Dim custNewsPartner As Boolean = 0

            If CECustomersAcceptNews.Checked = True Then
                custNewsLetter = 1
            End If
            If CEPartnersAcceptNews.Checked = True Then
                custNewsPartner = 1

            End If

            loadDataCommun(custNewsLetter, custNewsPartner, txtFromDate.EditValue, txtToDate.EditValue, _istest)


            'If CEActivationCode.Checked = True Then
            '    LoadDiscountCode()
            'End If
            addInfoNextReconduction()

            If CELAstAboAction.Checked = True Then
                LoadLastAboAction()
                'GridView1.RefreshData()
                'GridView1.Columns(GridView1.Columns.Count() - 1).Visible = True
            End If

            'If CEAboStoppedSince.Checked = True Then
            '    CheckAboStoppedDelay()
            'End If
        End If
        Grid1.DataSource = objDS.Tables(TableName).DefaultView()

        TabControl1.SelectedTabPage = TabResult
    End Sub

    'Public Overrides Sub LoadDataSet()
    '    Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
    '    Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
    '    Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
    '    TabControl1.SelectedTabPage = TabResult
    'End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        _istest = False
        LoadDataSet()
    End Sub

    Private Sub LoadLastAboAction()

        ' Dim _CustRow As DataRow

        ' Dim _i As Integer
        If IsDBNull(cmbMessage.EditValue) Then
            Exit Sub
        End If
        If objDS.Tables.Contains("LastAboActionTmp") Then
            objDS.Tables.Remove("LastAboActionTmp")
        End If


        For Each dr As DataRow In objDS.Tables(TableName).Rows
            objDS.Tables.Add("LastAboActionTmp")
            SQLTxt1 = PlushData.clsMassEmail.getLastAboAction(dr("customers_id"))
            Cls1.FillDataSet(objDS.Tables("LastAboActionTmp"), SQLTxt1)
            If objDS.Tables("LastAboActionTmp").Rows.Count > 0 Then
                dr("abo_action") = objDS.Tables("LastAboActionTmp").Rows(0)("name")
            End If
            objDS.Tables.Remove("LastAboActionTmp")

        Next

        '  _CustRow = GridView1.GetDataRow(_i)


    End Sub
    Private Sub addInfoNextReconduction()
        Dim price As String
        Dim credit As Integer
        Dim dvdremain As Integer
        Dim customers_id As Integer
        Dim clscust As New PlushBuziness.ClsCustomers

        objDS.Tables(TableName).Columns.Add("next_abo_price")
        objDS.Tables(TableName).Columns.Add("next_abo_dvd_credit")

        For Each dr As DataRow In objDS.Tables(TableName).Rows
            customers_id = dr("customers_id")
            clscust.GetInfoNextReconduction(customers_id, price)

            dr("next_abo_price") = price
            dr("next_abo_dvd_credit") = credit

        Next

    End Sub
    'Private Sub LoadDiscountCode()
    '    Dim _CustRow As DataRow
    '    Dim _ACRow() As DataRowView
    '    Dim _i As Integer
    '    If IsDBNull(cmbMessage.EditValue) Then
    '        Exit Sub
    '    End If
    '    'If objDS.Tables.Contains("code_tmp") Then
    '    '    objDS.Tables.Remove("code_tmp")
    '    'End If
    '    'objDS.Tables.Add("code_tmp")

    '    SQLTxt1 = DvdPostData.clsMassEmail.getCustomersWithDiscountCode
    '    Cls1.FillDataSet(objDS.Tables("code_tmp"), SQLTxt1)
    '    objDS.Tables("code_tmp").DefaultView.Sort = "customers_id"
    '    Dim _row1 As DataRowView
    '    For _i = 0 To GridView1.RowCount - 1
    '        _CustRow = GridView1.GetDataRow(_i)
    '        _ACRow = objDS.Tables("code_tmp").DefaultView.FindRows(_CustRow("customers_id"))
    '        For Each _row1 In _ACRow
    '            _CustRow("Code") = _row1("Code")
    '            _CustRow("Code_Creation_Date") = _row1("Code_Creation_Date")
    '            _CustRow("Code_Type") = _row1("Code_type")
    '            '                Exit For
    '        Next
    '    Next

    'End Sub

    Private Sub LoadPartnerShip()
        Dim sql As String
        sql = PlushData.clsMassEmail.getCustomersDiscountUse(Me.txtDiscUse.Text.ToString, intmessages_id)
        Dim dt As DataTable
        If objDS.Tables.Contains("PARTNERSHIP") Then
            objDS.Tables.Remove("PARTNERSHIP")
        End If
        dt = PlushData.clsConnection.FillDataSet(SQLTxt1)
        dt.TableName = "PARTNERSHIP"
        objDS.Tables.Add(dt)

        ' Dim view As New DataView(dt)
        Me.Grid1.DataSource = dt
    End Sub

    Private Sub loadDataCommun(ByVal custNewsLetter As Boolean, ByVal custNewsPartner As Boolean, ByVal dStart As DateTime, ByVal dStop As DateTime, ByVal istest As Boolean)

        If objDS.Tables.Contains(TableName) Then
            objDS.Tables.Remove(TableName)
        End If

        Dim dt As DataTable
        SQLTxt1 = PlushData.clsMassEmail.getCustWithMailHistSentAndAdressBook(intmessages_id, custNewsLetter, custNewsPartner, dStart, dStop, istest)
        dt = PlushData.clsConnection.FillDataSet(SQLTxt1)
        dt.DefaultView().Sort = NameField
        Grid1.DataSource = dt.DefaultView()
        UcPivotGrid1.PivotGrid1.DataSource = dt.DefaultView
        dt.TableName = TableName
        objDS.Tables.Add(dt)

    End Sub


    'Private Sub CheckAboStoppedDelay()
    '    Dim _CustRow As DataRow
    '    Dim _i As Integer

    '    For _i = 0 To GridView1.RowCount - 1
    '        _CustRow = GridView1.GetDataRow(_i)

    '        Dim sSQL As String = ""
    '        If _CustRow("customers_abo") = 1 Then
    '            _CustRow("AboStoppedSinceDelay") = 0
    '        Else
    '            objDS.Tables.Add("AboStoppedTmp")
    '            sSQL = DvdPostData.clsMassEmail.getAboStopDelay(SEAboStoppedDelay.Text, _CustRow("customers_id"))

    '             DvdPostData.clsConnection.FillDataSet(objDS.Tables("AboStoppedTmp"), sSQL)
    '            If objDS.Tables("AboStoppedTmp").Rows.Count = 1 Then
    '                _CustRow("AboStoppedSinceDelay") = 1
    '            Else
    '                _CustRow("AboStoppedSinceDelay") = 0
    '            End If
    '            objDS.Tables.Remove("AboStoppedTmp")
    '        End If
    '    Next
    'End Sub

    Public Shared Function MD5Encrypt(ByVal str As String) As String

        'Imports System.Security.Cryptography

        Dim md5 As MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim strOutput As String
        Dim i As Integer

        ' Create New Crypto Service Provider Object
        md5 = New MD5CryptoServiceProvider

        ' Convert the original string to array of Bytes
        bytValue = System.Text.Encoding.UTF8.GetBytes(str)

        ' Compute the Hash, returns an array of Bytes
        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            'don't lose the leading 0
            strOutput &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        MD5Encrypt = strOutput

    End Function

    Private Sub btnUser1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick
        send_email(False)
    End Sub

    'Private Sub ReplaceParamCommun(ByVal CustRow As DataRow, _
    '                               ByVal MailRow As DataRow, _
    '                               ByVal Site As String, _
    '                               ByVal logo As String, _
    '                               ByVal mailHistoryId As Integer, _
    '                               ByRef strSubject As String, _
    '                               ByRef strmessage As String)


    '    strSubject = MailRow("messages_subject")
    '    strmessage = MailRow("messages_html")
    '    'titre
    '    strmessage = Replace(strmessage, "$$$title$$$", MailRow("messages_title"))
    '    'customers_name
    '    strmessage = Replace(strmessage, "$$$customers_name$$$", CustRow("customers_firstname") & " " & CustRow("customers_lastname"))

    '    strmessage = Replace(strmessage, "$$$customers_email$$$", CustRow("customers_email_address"))
    '    strmessage = Replace(strmessage, "$$$email$$$", CustRow("customers_email_address"))
    '    'site & Logo
    '    strmessage = Replace(strmessage, "$$$site$$$", "<a href='" & Site & " '>" & Site & "</a>")
    '    strmessage = Replace(strmessage, "$$$site_link$$$", Site)
    '    strmessage = Replace(strmessage, "$$$site_image$$$", "<a href='" & Site & " '>")
    '    strmessage = Replace(strmessage, "$$$logo_dvdpost$$$", "<a href='" & Site & " '> <img src='" & logo & "' border='0'> </a>")
    '    'today
    '    strmessage = Replace(strmessage, "$$$today$$$", Today())
    '    'Abo Creation Date
    '    strmessage = Replace(strmessage, "$$$abo_creation_date$$$", CustRow("customers_info_date_account_created"))
    '    'mailid 
    '    strmessage = Replace(strmessage, "$$$mail_id$$$", mailHistoryId)
    '    strmessage = Replace(strmessage, "$$$mail_messages_sent_history_id$$$", mailHistoryId)
    '    'customers_id
    '    strmessage = Replace(strmessage, "$$$customers_id$$$", CustRow("customers_id"))
    '    'customers_abo_validityto
    '    strmessage = Replace(strmessage, "$$$next_reconduction_date$$$", CustRow("customers_abo_validityto") & "")

    'End Sub

    'Private Sub replaceAbo(ByVal CustRow As DataRow, ByVal lang As Integer, ByRef strmessage As String)
    '    Dim actual_abo, next_abo As ClsCustomersInfo.clsCustomerABOInfo
    '    If InStr(strmessage, "$$$actual_abo_name$$$", CompareMethod.Text) <> 0 Then
    ' actual_abo = New ClsCustomersInfo.clsCustomerABOInfo(SessionInfo, CustRow("customers_abo_type"), lang)
    ' next_abo = New ClsCustomersInfo.clsCustomerABOInfo(SessionInfo, GetNextAbo(CustRow("customers_abo_type")), lang)

    '        strmessage = Replace(strmessage, "$$$actual_abo_name$$$", actual_abo.ABO_Name)
    '        strmessage = Replace(strmessage, "$$$actual_abo_price$$$", actual_abo.ABO_price)
    '        strmessage = Replace(strmessage, "$$$next_abo_name$$$", next_abo.ABO_Name)
    '        strmessage = Replace(strmessage, "$$$next_abo_price$$$", next_abo.ABO_price)
    '        strmessage = Replace(strmessage, "$$$next_abo_dvd_credit$$$", next_abo.DVD_Credit)
    '        strmessage = Replace(strmessage, "$$$next_abo_dvd_at_home$$$", next_abo.DVD_At_Home)

    '        '
    '    End If
    ' End Sub
    'Private Sub replacePromoCode(ByVal CustRow As DataRow, ByRef strmessage As String)
    '    If InStr(strmessage, "$$$promo_code$$$", CompareMethod.Text) <> 0 Then
    '        Dim _PromoCode As String
    '        If CustRow("activation_discount_code_type") = "D" Then
    '            _PromoCode = BKGlobal.ExecuteFindFieldValue("discount_code", "SELECT discount_code from discount_code where discount_code_id = " & CustRow("activation_discount_code_id"))
    '        Else
    '            _PromoCode = BKGlobal.ExecuteFindFieldValue("activation_code", "SELECT activation_code from activation_code where activation_id = " & CustRow("activation_discount_code_id"))
    '        End If
    '        strmessage = Replace(strmessage, "$$$promo_code$$$", _PromoCode)
    '    End If
    'End Sub
    'Sub testEmail()

    '    Dim dt As DataTable
    '    Dim i As Integer
    '    dt = cmbMessage.Properties.DataSource
    '    '   For i = 0 To 10
    '    For Each Item As DataRow In dt.Rows
    '        clsMail.SendMail(609, Item("mail_messages_id"), "dvb@dvdpost.be")
    '        clsMail.SendMail(531, Item("mail_messages_id"), "dvb@dvdpost.be")
    '        clsMail.SendMail(634, Item("mail_messages_id"), "dvb@dvdpost.be")
    '    Next
    '    ' Next

    'End Sub
    Sub send_email(ByVal test As Boolean, Optional ByVal lang As Integer = PlushData.ClsCustomersData.Language.FR)

        Dim CustRow As DataRow
        Dim intmessages_id As Integer
        Dim i As Integer
        Dim max As Integer
        intmessages_id = cmbMessage.EditValue

        If test = True Then
            max = 0
        Else
            max = GridView1.RowCount - 1
        End If
        Dim ok As Boolean
        For i = 0 To max
            CustRow = GridView1.GetDataRow(i)
            If test Then
                CustRow("customers_language") = lang
                If (TETestEmail.Text.Trim() <> "") Then
                    ok = PlushBuziness.clsMail.SendMail(CustRow, intmessages_id, TETestEmail.Text, txtStrFrom.Text, textEmailName.Text)
                    If Not ok Then Return
                Else
                    MsgBox("Email Unvalid ")
                End If
            Else
                'If i Mod 1000 Then
                '    Threading.Thread.Sleep(1000)
                'End If
                PlushBuziness.clsMail.SendMail(CustRow, intmessages_id, , txtStrFrom.Text, textEmailName.Text)
            End If
        Next
    End Sub
    'Sub send_email(ByVal test As Boolean, Optional ByVal language As Integer = 0)
    '    'Sending E-Mails
    '    Dim strFrom As String = "dvdpost@dvdpost.be"
    '    Dim strTo As String
    '    Dim strSubject As String = ""
    '    Dim strMessage As String = ""
    '    Dim CustRow As DataRow
    '    Dim MailRow As DataRow
    '    Dim i As Integer
    '    Dim intcustomers_language As Integer
    '    Dim sSQL2, sSQL3 As String
    '    Dim intmaxmailid As Integer

    '    Dim tabErreur As New ArrayList()
    '    Dim is_email_valid As Boolean = False

    '    'sSQL3 = "SELECT max(mail_messages_sent_history_id) as cc  FROM mail_messages_sent_history  "
    '    'intmaxmailid = BKGlobal.ExecuteFindFieldValueINT("cc", sSQL3)

    '    If IsDBNull(cmbMessage.EditValue) Then
    '        Exit Sub
    '    End If
    '    intmessages_id = cmbMessage.EditValue
    '    Dim max As Integer
    '    If test = True Then
    '        max = 0
    '    Else
    '        max = GridView1.RowCount - 1
    '    End If

    '    For i = 0 To max
    '        intmaxmailid = BKGlobal.GetNextID("mail_messages_sent_history_id")
    '        CustRow = GridView1.GetDataRow(i)
    '        If language = 0 Then
    '            intcustomers_language = CustRow("customers_language")
    '        Else
    '            intcustomers_language = language
    '        End If


    '        'SiteRow = objDS.Tables("site").Rows.Find(New Object() {CustRow("site")})

    '        'If Not IsNothing(SiteRow) Then
    '        '    mvarsite = SiteRow("site_link")
    '        '    mvarLogo = SiteRow("logo")
    '        'Else
    '        '    mvarsite = "www.dvdpost.be"
    '        '    mvarLogo = "http://www.dvdpost.be/images/www3/logo.jpg"
    '        'End If

    '        strTo = CustRow("customers_email_address")
    '        objDS.Tables("mail_messages").Clear()
    '        sSQL2 = "SELECT * FROM mail_messages WHERE mail_messages_id = '" & intmessages_id & "' and language_id = '" & intcustomers_language & "'"
    '         DvdPostData.clsConnection.FillDataSet(objDS.Tables("mail_messages"), sSQL2)

    '        For Each MailRow In objDS.Tables("mail_messages").Rows
    '            Try
    '                clsMail.replaceParamCommun(CustRow, MailRow, mvarsite, strSubject, strMessage)
    '                'wl_size
    '                strMessage = Replace(strMessage, "$$$customers_wishlist_count$$$", CustRow("wl_size") & "")

    '                'customers_abo_dateLastorders
    '                If Me.CheckDateLastOrder.Checked = True Then
    '                    clsMail.replaceLastOrder(CustRow, strMessage)
    '                End If

    '                '' for email mgm receive presents
    '                If Me.checkMemGetm.Checked = True Then
    '                    clsMail.replaceMemGetMem(CustRow, intcustomers_language, strMessage)
    '                End If
    '                ''for create and insert vodx
    '                If Me.CheckVodx.Checked = True Then
    '                    clsMail.replaceVodx(CustRow, intcustomers_language, strMessage)
    '                End If


    '                If CEActivationCode.Checked = True Then
    '                    clsMail.replaceActivation(CustRow, strMessage)
    '                End If
    '                If test = True Then
    '                    strMessage = Replace(strMessage, "$$$pass$$$", "toto")
    '                Else
    '                    'If CEResetPassword.Checked = True Then
    '                    '    If InStr(strMessage, "$$$pass$$$", CompareMethod.Text) <> 0 Then
    '                    '        'Need to Create a New PassWord
    '                    '        Dim _PassWord As String = Mid(_CustRow("customers_firstname"), 1, Math.Min(5, Len(_CustRow("customers_firstname"))))
    '                    '        Dim _PassWordEncrypted As String
    '                    '        Dim _CodeChar As Char
    '                    '        Dim _CodeAscii As Integer
    '                    '        Dim _CodeType As Integer = 1 '1=Number, 2=A-Z, 3=a-z, 4=-or_
    '                    '        For i = 1 To 3
    '                    '            Randomize()
    '                    '            '_CodeType = CInt(Int((3 * Rnd()) + 1))
    '                    '            Select Case _CodeType
    '                    '                Case 1 '0-9
    '                    '                    _CodeAscii = CInt(Int((10 * Rnd()) + 48))
    '                    '                Case 2 'A-Z
    '                    '                    _CodeAscii = CInt(Int((26 * Rnd()) + 65))
    '                    '                Case 3 'a-z
    '                    '                    _CodeAscii = CInt(Int((26 * Rnd()) + 97))
    '                    '            End Select
    '                    '            _CodeChar = ChrW(_CodeAscii)
    '                    '            If _CodeChar = "O" Or _CodeChar = "o" Or _CodeChar = "0" Then _CodeChar = "1"
    '                    '            _PassWord = _PassWord & _CodeChar
    '                    '        Next i
    '                    '        Dim _MD5 As New System.Security.Cryptography.MD5CryptoServiceProvider
    '                    '        Dim _encoding As New System.Text.ASCIIEncoding()
    '                    '        _PassWordEncrypted = MD5Encrypt(_PassWord) '_encoding.GetString(_MD5.ComputeHash(_encoding.GetBytes(_PassWord)))
    '                    '        DvdPostData.clsConnection.ExecuteNonQuery("update customers set customers_password = '" & _PassWordEncrypted & _
    '                    '                       "' WHERE customers_id = " & _CustRow("customers_id"))
    '                    '        strMessage = Replace(strMessage, "$$$pass$$$", _PassWord)
    '                    '    End If
    '                    'End If
    '                End If
    '                replaceAbo(CustRow, intcustomers_language, strMessage)


    '                Dim mymail As MailMessage


    '                'Try
    '                If test = True Then
    '                    mymail = New MailMessage(strFrom, TETestEmail.Text)
    '                Else
    '                    mymail = New MailMessage(strFrom, strTo)
    '                End If


    '                mymail.From = New MailAddress(strFrom, "DVDPost")
    '                mymail.Subject = strSubject
    '                mymail.IsBodyHtml = True
    '                mymail.Body = strMessage
    '                is_email_valid = True
    '                'Catch ex As Exception
    '                '    is_email_valid = False
    '                'End Try
    '                If is_email_valid = True Then

    '                    Dim SmtpMail As New SmtpClient(mvarsmtpserver)
    '                    SmtpMail.Credentials = New System.Net.NetworkCredential("Administrator", "DVD8(post")

    '                    SmtpMail.Send(mymail)

    '                    sSQL3 = DvdPostData.clsMassEmail.insertMailSentHistory(intmaxmailid, CustRow("customers_id"), intmessages_id, intcustomers_language, strTo)

    '                    DvdPostData.clsConnection.ExecuteNonQuery(sSQL3)

    '                End If
    '            Catch ex As SmtpException
    '                is_email_valid = False
    '                ' stop boucle : probleme de connexion smtp
    '                tabErreur.Add("email : " + CustRow("customers_email_address").ToString + " " + ex.Message)
    '            Catch ex As ObjectDisposedException
    '                'stop la procedure
    '                MsgBox("email: " + CustRow("customers_email_address").ToString + " " + ex.Message)
    '                Exit Sub
    '            Catch ex As InvalidCastException
    '                tabErreur.Add("email : " + CustRow("customers_email_address").ToString + " " + ex.Message.ToString)
    '            Catch ex As Exception
    '                tabErreur.Add("email: " + CustRow("customers_email_address").ToString + " " + ex.Message.ToString)
    '            End Try

    '        Next
    '    Next
    '    'ajoutte les erreurs à la liste  dans la form errorList
    '    If tabErreur.Count <> 0 Then
    '        Dim listError As New errorList()
    '        For Each el As String In tabErreur
    '            listError.ListError.Items.Add(el)
    '        Next
    '        listError.Show()
    '    End If
    '    MsgBox("Done", MsgBoxStyle.Information)


    'End Sub
    'Function GetNextAbo(ByVal currentAbo As Integer) As Integer
    '    Select Case currentAbo
    '        Case 2
    '            Return 18
    '        Case 5
    '            Return 18
    '        Case 6
    '            Return 20
    '        Case 7
    '            Return 22
    '        Case 8
    '            Return 24
    '        Case 9
    '            Return 25
    '        Case Else
    '            Return currentAbo
    '    End Select

    'End Function

    Private Sub SBTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBTest.Click
        _istest = True
        LoadDataSet()
        send_email(True, PlushData.ClsCustomersData.Language.FR)
        send_email(True, PlushData.ClsCustomersData.Language.NL)
        send_email(True, PlushData.ClsCustomersData.Language.EN)

        'testEmail()
    End Sub


    Private Sub searchFieldEmail()

    End Sub



End Class
