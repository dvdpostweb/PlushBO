Imports System.Windows.Forms.Application

Public Class frmCustomers_Browse
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLimit As System.Windows.Forms.TextBox
    Friend WithEvents btnPrintEnveloppes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkOnlyABO As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkGetLastABOAction As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnCheckMails As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEMailToProcess As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBadMail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGoodMail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtFlyerTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFlyerFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFlyerNbrOfShipping As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnFlyerAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFlyerDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFlyerCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rdgFlyer As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtEMailBeingTested As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomers_Browse))
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLimit = New System.Windows.Forms.TextBox
        Me.btnPrintEnveloppes = New DevExpress.XtraEditors.SimpleButton
        Me.chkOnlyABO = New DevExpress.XtraEditors.CheckEdit
        Me.chkGetLastABOAction = New DevExpress.XtraEditors.CheckEdit
        Me.btnCheckMails = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtEMailBeingTested = New DevExpress.XtraEditors.TextEdit
        Me.txtGoodMail = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtBadMail = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtEMailToProcess = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.rdgFlyer = New DevExpress.XtraEditors.RadioGroup
        Me.btnFlyerAdd = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtFlyerDesc = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtFlyerCode = New DevExpress.XtraEditors.TextEdit
        Me.txtFlyerTo = New DevExpress.XtraEditors.DateEdit
        Me.txtFlyerFrom = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtFlyerNbrOfShipping = New DevExpress.XtraEditors.SpinEdit
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
        CType(Me.chkOnlyABO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGetLastABOAction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtEMailBeingTested.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGoodMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBadMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEMailToProcess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.rdgFlyer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFlyerDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFlyerCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFlyerTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFlyerTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFlyerFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFlyerFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFlyerNbrOfShipping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabParameters.Controls.Add(Me.GroupControl2)
        Me.TabParameters.Controls.Add(Me.GroupControl1)
        Me.TabParameters.Controls.Add(Me.chkGetLastABOAction)
        Me.TabParameters.Controls.Add(Me.chkOnlyABO)
        Me.TabParameters.Controls.Add(Me.btnPrintEnveloppes)
        Me.TabParameters.Controls.Add(Me.Label6)
        Me.TabParameters.Controls.Add(Me.txtLimit)
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
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        Me.HelpProvider1.SetShowHelp(Me.Label6, CType(resources.GetObject("Label6.ShowHelp"), Boolean))
        '
        'txtLimit
        '
        resources.ApplyResources(Me.txtLimit, "txtLimit")
        Me.txtLimit.Name = "txtLimit"
        Me.HelpProvider1.SetShowHelp(Me.txtLimit, CType(resources.GetObject("txtLimit.ShowHelp"), Boolean))
        '
        'btnPrintEnveloppes
        '
        resources.ApplyResources(Me.btnPrintEnveloppes, "btnPrintEnveloppes")
        Me.btnPrintEnveloppes.Name = "btnPrintEnveloppes"
        Me.HelpProvider1.SetShowHelp(Me.btnPrintEnveloppes, CType(resources.GetObject("btnPrintEnveloppes.ShowHelp"), Boolean))
        '
        'chkOnlyABO
        '
        resources.ApplyResources(Me.chkOnlyABO, "chkOnlyABO")
        Me.chkOnlyABO.Name = "chkOnlyABO"
        Me.chkOnlyABO.Properties.Caption = resources.GetString("chkOnlyABO.Properties.Caption")
        Me.HelpProvider1.SetShowHelp(Me.chkOnlyABO, CType(resources.GetObject("chkOnlyABO.ShowHelp"), Boolean))
        '
        'chkGetLastABOAction
        '
        resources.ApplyResources(Me.chkGetLastABOAction, "chkGetLastABOAction")
        Me.chkGetLastABOAction.Name = "chkGetLastABOAction"
        Me.chkGetLastABOAction.Properties.Caption = resources.GetString("chkGetLastABOAction.Properties.Caption")
        Me.HelpProvider1.SetShowHelp(Me.chkGetLastABOAction, CType(resources.GetObject("chkGetLastABOAction.ShowHelp"), Boolean))
        '
        'btnCheckMails
        '
        resources.ApplyResources(Me.btnCheckMails, "btnCheckMails")
        Me.btnCheckMails.Name = "btnCheckMails"
        Me.HelpProvider1.SetShowHelp(Me.btnCheckMails, CType(resources.GetObject("btnCheckMails.ShowHelp"), Boolean))
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtEMailBeingTested)
        Me.GroupControl1.Controls.Add(Me.txtGoodMail)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtBadMail)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtEMailToProcess)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.btnCheckMails)
        Me.GroupControl1.Name = "GroupControl1"
        Me.HelpProvider1.SetShowHelp(Me.GroupControl1, CType(resources.GetObject("GroupControl1.ShowHelp"), Boolean))
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl4, CType(resources.GetObject("LabelControl4.ShowHelp"), Boolean))
        '
        'txtEMailBeingTested
        '
        resources.ApplyResources(Me.txtEMailBeingTested, "txtEMailBeingTested")
        Me.txtEMailBeingTested.Name = "txtEMailBeingTested"
        Me.HelpProvider1.SetShowHelp(Me.txtEMailBeingTested, CType(resources.GetObject("txtEMailBeingTested.ShowHelp"), Boolean))
        '
        'txtGoodMail
        '
        resources.ApplyResources(Me.txtGoodMail, "txtGoodMail")
        Me.txtGoodMail.Name = "txtGoodMail"
        Me.HelpProvider1.SetShowHelp(Me.txtGoodMail, CType(resources.GetObject("txtGoodMail.ShowHelp"), Boolean))
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl3, CType(resources.GetObject("LabelControl3.ShowHelp"), Boolean))
        '
        'txtBadMail
        '
        resources.ApplyResources(Me.txtBadMail, "txtBadMail")
        Me.txtBadMail.Name = "txtBadMail"
        Me.HelpProvider1.SetShowHelp(Me.txtBadMail, CType(resources.GetObject("txtBadMail.ShowHelp"), Boolean))
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, CType(resources.GetObject("LabelControl2.ShowHelp"), Boolean))
        '
        'txtEMailToProcess
        '
        resources.ApplyResources(Me.txtEMailToProcess, "txtEMailToProcess")
        Me.txtEMailToProcess.Name = "txtEMailToProcess"
        Me.HelpProvider1.SetShowHelp(Me.txtEMailToProcess, CType(resources.GetObject("txtEMailToProcess.ShowHelp"), Boolean))
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, CType(resources.GetObject("LabelControl1.ShowHelp"), Boolean))
        '
        'GroupControl2
        '
        resources.ApplyResources(Me.GroupControl2, "GroupControl2")
        Me.GroupControl2.Controls.Add(Me.rdgFlyer)
        Me.GroupControl2.Controls.Add(Me.btnFlyerAdd)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.txtFlyerDesc)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.txtFlyerCode)
        Me.GroupControl2.Controls.Add(Me.txtFlyerTo)
        Me.GroupControl2.Controls.Add(Me.txtFlyerFrom)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.txtFlyerNbrOfShipping)
        Me.GroupControl2.Name = "GroupControl2"
        '
        'rdgFlyer
        '
        resources.ApplyResources(Me.rdgFlyer, "rdgFlyer")
        Me.rdgFlyer.Name = "rdgFlyer"
        Me.rdgFlyer.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Replace if Exist and Re-Open"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Increment if Exist and Re-Open"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Leave Un-Changed if Exist")})
        '
        'btnFlyerAdd
        '
        resources.ApplyResources(Me.btnFlyerAdd, "btnFlyerAdd")
        Me.btnFlyerAdd.Name = "btnFlyerAdd"
        Me.HelpProvider1.SetShowHelp(Me.btnFlyerAdd, CType(resources.GetObject("btnFlyerAdd.ShowHelp"), Boolean))
        '
        'LabelControl9
        '
        resources.ApplyResources(Me.LabelControl9, "LabelControl9")
        Me.LabelControl9.Name = "LabelControl9"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl9, CType(resources.GetObject("LabelControl9.ShowHelp"), Boolean))
        '
        'txtFlyerDesc
        '
        resources.ApplyResources(Me.txtFlyerDesc, "txtFlyerDesc")
        Me.txtFlyerDesc.Name = "txtFlyerDesc"
        Me.HelpProvider1.SetShowHelp(Me.txtFlyerDesc, CType(resources.GetObject("txtFlyerDesc.ShowHelp"), Boolean))
        '
        'LabelControl8
        '
        resources.ApplyResources(Me.LabelControl8, "LabelControl8")
        Me.LabelControl8.Name = "LabelControl8"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl8, CType(resources.GetObject("LabelControl8.ShowHelp"), Boolean))
        '
        'LabelControl7
        '
        resources.ApplyResources(Me.LabelControl7, "LabelControl7")
        Me.LabelControl7.Name = "LabelControl7"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl7, CType(resources.GetObject("LabelControl7.ShowHelp"), Boolean))
        '
        'LabelControl6
        '
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Name = "LabelControl6"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl6, CType(resources.GetObject("LabelControl6.ShowHelp"), Boolean))
        '
        'txtFlyerCode
        '
        resources.ApplyResources(Me.txtFlyerCode, "txtFlyerCode")
        Me.txtFlyerCode.Name = "txtFlyerCode"
        '
        'txtFlyerTo
        '
        Me.txtFlyerTo.EditValue = Nothing
        resources.ApplyResources(Me.txtFlyerTo, "txtFlyerTo")
        Me.txtFlyerTo.Name = "txtFlyerTo"
        Me.txtFlyerTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtFlyerTo.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtFlyerTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtFlyerTo, CType(resources.GetObject("txtFlyerTo.ShowHelp"), Boolean))
        '
        'txtFlyerFrom
        '
        Me.txtFlyerFrom.EditValue = Nothing
        resources.ApplyResources(Me.txtFlyerFrom, "txtFlyerFrom")
        Me.txtFlyerFrom.Name = "txtFlyerFrom"
        Me.txtFlyerFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtFlyerFrom.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtFlyerFrom.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        '
        'txtFlyerNbrOfShipping
        '
        resources.ApplyResources(Me.txtFlyerNbrOfShipping, "txtFlyerNbrOfShipping")
        Me.txtFlyerNbrOfShipping.Name = "txtFlyerNbrOfShipping"
        Me.txtFlyerNbrOfShipping.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'frmCustomers_Browse
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmCustomers_Browse"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
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
        CType(Me.chkOnlyABO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGetLastABOAction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtEMailBeingTested.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGoodMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBadMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEMailToProcess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.rdgFlyer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFlyerDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFlyerCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFlyerTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFlyerTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFlyerFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFlyerFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFlyerNbrOfShipping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 1000000 "

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New PlushBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        objDS = New dsCustomers
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "customers_view2"
        MyBase.IDField = "customers_id"
        MyBase.NameField = "customers_lastname"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = False
        rdgFlyer.EditValue = 2
        MyBase.StartUp()

        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
        'btnOK
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If CurrentDefaultSetID <> 0 Then
            BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)

            TabControl1.SelectedTabPage = TabResult
        Else

            TabControl1.SelectedTabPage = TabResult
        End If
    End Sub
    Public Overrides Sub LoadDataSet()
        Dim _SQLTxt As String
        Dim _WHERETxt As String
        Dim _GroupBy As String = " GROUP BY c.customers_id "

        'Clear Table
        objDS.Tables(TableName).Clear()


        _SQLTxt = "SELECT * ,(select count(*) from wishlist wl where wl.customers_id = c.customers_id) as nbr_dvd_wishlist" & _
        " FROM customers c " & _
        " LEFT JOIN address_book addr on addr.customers_id = c.customers_id and addr.address_book_id = c.customers_default_address_id " & _
        " LEFT JOIN countries ctry on ctry.countries_id = addr.entry_country_id " & _
        " LEFT JOIN languages lang on lang.languages_id = c.customers_language " & _
        " LEFT JOIN orders o on o.customers_id = c.customers_id "
        ' " LEFT JOIN survey_customers_2008 s on s.customers_id = c.customers_id "



        If chkOnlyABO.Checked = True Then
            _WHERETxt = " WHERE c.customers_abo = 1 "
        Else
            _WHERETxt = ""
        End If
        BKFilter.ApplyFilter(_SQLTxt, IsFiltered, CurrentFilterID, _WHERETxt, StatusBar1.Panels(1))
        _SQLTxt = _SQLTxt & _GroupBy & _Limit
        PlushData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)
        If chkGetLastABOAction.Checked = True Then
            GetLastAboAction()
            getPreviousAction()
        End If
        'Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        'Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = objDS.Tables(TableName).DefaultView '_View 
        TabControl1.SelectedTabPage = TabResult
    End Sub

    Private Sub GetLastAboAction()
        Dim _row As DataRow
        Dim _DS As New DataSet
        _DS.Tables.Add("ABO")
        Dim _SQLTxt As String
        For Each _row In objDS.Tables(TableName).Rows
            _DS.Tables("ABO").Clear()
            _SQLTxt = "SELECT * FROM abo a " & _
                      " left join abo_action ac on a.action = ac.id " & _
                      " where customerid = " & _row("customers_id") & _
                      " order by abo_id desc limit 1"
            PlushData.clsConnection.FillDataSet(_DS.Tables("ABO"), _SQLTxt)
            If _DS.Tables("ABO").Rows.Count = 1 Then
                _row("last_abo_action_id") = _DS.Tables("ABO").Rows(0)("Action")
                _row("last_abo_action_name") = _DS.Tables("ABO").Rows(0)("Name")
                _row("last_abo_action_date") = _DS.Tables("ABO").Rows(0)("Date")
            End If
        Next
    End Sub


    Public Sub getPreviousAction()
        Dim row As DataRow
        For Each row In objDS.Tables(TableName).Rows
            Dim previousAction As String
            Dim sqlPreviosAction As String = PlushData.clsAboStopWhy.getPreviousAction(row("customers_id"))
            previousAction = BKGlobal.ExecuteFindFieldValue("action_name", sqlPreviosAction)
            row("before_last_action") = previousAction
        Next
    End Sub
    Private Sub txtLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimit.TextChanged
        _Limit = "limit 0, " & txtLimit.Text
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub
    'Private Sub btnPrintEnveloppes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintEnveloppes.Click
    '    Dim _row, _row1 As DataRow
    '    Dim _DS As New dsEnvelopeLabels
    '    Dim _i, _j As Integer
    '    _DS.Tables("envelope_labels_multishipment_det").Clear()
    '    For _i = 0 To GridView1.DataRowCount - 1
    '        _j += 1
    '        _row = GridView1.GetDataRow(_i)
    '        _row1 = _DS.Tables("envelope_labels_multishipment_det").NewRow
    '        _row1("multishipment_id") = _j
    '        _row1("group_abc") = "a"
    '        _row1("delivery_name") = _row("ship_lastname") & " " & _row("ship_firstname")
    '        _row1("delivery_street_address") = _row("ship_address")
    '        _row1("delivery_city") = _row("ship_city")
    '        _row1("delivery_country") = _row("ship_country")
    '        _row1("delivery_postcode") = _row("ship_postcode")
    '        _row1("lang_name") = _row("lang_name")
    '        '_row1.ItemArray = _row.ItemArray
    '        _DS.Tables("envelope_labels_multishipment_det").Rows.Add(_row1)
    '    Next
    '    Dim _rpt As New rptMSEnveloppes
    '    _rpt.objDS = _DS
    '    _rpt.DataMember = ""
    '    _rpt.DataSource = _DS.Tables("envelope_labels_multishipment_det")
    '    _rpt.ShowPreview()

    'End Sub

    Private Sub btnCheckMails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckMails.Click
        Dim _i As Integer
        Dim _Row As DataRow
        Dim _EmailVerifier As EmailVerifierComponent.EmailVerifier
        Dim _EMailVerifierResult As EmailVerifierComponent.Result


        txtEMailToProcess.EditValue = GridView1.RowCount
        txtBadMail.EditValue = 0
        txtGoodMail.EditValue = 0
        Dim _SQLTxt As String = ""
        For _i = 0 To GridView1.RowCount - 1
            _Row = GridView1.GetDataRow(_i)
            If Not IsNothing(_Row) Then
                txtEMailBeingTested.EditValue = _Row("email")
                txtEMailBeingTested.Refresh()
                _EmailVerifier = New EmailVerifierComponent.EmailVerifier
                _EmailVerifier.MailFROM = "dvdpost@dvdpost.be"
                _EmailVerifier.DomainForHELO = "dvdpost.be"
                _EmailVerifier.Timeout = 15
                _EMailVerifierResult = _EmailVerifier.Verify(_Row("email"))
                'doevents()
                If _EMailVerifierResult.Name.IndexOf("Trial") = 0 Then Exit Sub
                If _EMailVerifierResult.Code = 1 Or _EMailVerifierResult.Code = 13 Then '1=OK, 13=SPAM Blocked<=>OK
                    txtGoodMail.EditValue += 1
                    txtGoodMail.Refresh()
                    _SQLTxt = "UPDATE customers SET is_email_valid = 1 WHERE customers_id = " & _Row("customers_id")
                Else
                    txtBadMail.EditValue += 1
                    txtBadMail.Refresh()
                    _SQLTxt = "UPDATE customers SET is_email_valid = 0 WHERE customers_id = " & _Row("customers_id")
                End If
                PlushData.clsConnection.ExecuteNonQuery(_SQLTxt)
                _EmailVerifier = Nothing
            End If
            txtEMailToProcess.EditValue -= 1
            txtEMailToProcess.Refresh()
        Next
    End Sub

    Private Sub btnFlyerAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlyerAdd.Click
        Dim _CustRow As DataRow
        Dim _i As Integer
        Dim _DS As New DataSet
        Dim _SQLTxt As String
        Dim _strValidFrom As String = Year(txtFlyerFrom.EditValue).ToString & "-" & Month(txtFlyerFrom.EditValue).ToString & "-" & Day(txtFlyerFrom.EditValue).ToString & " 00:00:00 "
        Dim _strValidTo As String = Year(txtFlyerTo.EditValue).ToString & "-" & Month(txtFlyerTo.EditValue).ToString & "-" & Day(txtFlyerTo.EditValue).ToString & " 00:00:00 "
        _DS.Tables.Add("customers_add2ship")
        For _i = 0 To GridView1.RowCount - 1
            _CustRow = GridView1.GetDataRow(_i)
            PlushData.clsConnection.FillDataSet(_DS.Tables("customers_add2ship"), "select * from customers_add2ship where customers_id = " & _
                       _CustRow("customers_id") & " AND code = '" & txtFlyerCode.Text & "'")
            If _DS.Tables("customers_add2ship").Rows.Count > 0 Then 'Already Exist - Update if Necessary
                Select Case CInt(rdgFlyer.EditValue)
                    Case 0 'Replace - Re-OPen if necessarry
                        _SQLTxt = "UPDATE customers_add2ship set " & _
                                  " valid_from = '" & _strValidFrom & "', " & _
                                  " valid_to = '" & _strValidTo & "', " & _
                                  " nbr_to_ship = " & txtFlyerNbrOfShipping.EditValue & ", " & _
                                  " " & _
                                  " closed = 0 " & _
                                  " where customers_id = " & _CustRow("customers_id") & " AND code = '" & txtFlyerCode.Text
                        PlushData.clsConnection.ExecuteNonQuery(_SQLTxt)
                    Case 1 'Increment - Re-Open
                        _SQLTxt = "UPDATE customers_add2ship set " & _
                                  " valid_from = '" & _strValidFrom & "', " & _
                                  " valid_to = '" & _strValidTo & "', " & _
                                  " nbr_to_ship = nbr_to_ship + " & txtFlyerNbrOfShipping.EditValue & ", " & _
                                  " " & _
                                  " closed = 0 " & _
                                  " where customers_id = " & _CustRow("customers_id") & " AND code = '" & txtFlyerCode.Text
                        PlushData.clsConnection.ExecuteNonQuery(_SQLTxt)
                    Case 2 'Leave Un-Changed

                End Select
            Else 'Does not Already Exist - Create It
                Dim _CreateDate As String = Year(Now()).ToString & "-" & Month(Now()).ToString & "-" & Day(Now()).ToString & " 00:00:00"
                _SQLTxt = "INSERT INTO customers_add2ship values( Null, " & _CustRow("customers_id") & ", '" & txtFlyerDesc.Text & "',  " & _
                          "'" & _CreateDate & "', " & txtFlyerNbrOfShipping.EditValue & ", 0, 0, '" & _strValidFrom & "', '" & _strValidTo & "', " & _
                          "'" & txtFlyerCode.Text & "')"
                PlushData.clsConnection.ExecuteNonQuery(_SQLTxt)
            End If
        Next
    End Sub
End Class
