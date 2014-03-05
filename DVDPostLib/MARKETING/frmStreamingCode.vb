Imports System.IO
Imports System.Collections.Generic
Public Class frmStreamingCode
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
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtyToGenerate As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnGenerate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrefix As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DS As PlushLib.dsMarketting
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblSearch As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSearchID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSearchName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupSearch As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtStreamingCodeSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkOnlyUsed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabResult2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridStreamingCode As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewStreamingCode As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents streaming_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_group_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtActivationGroupIDSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblActivationGroupID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnEx As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStreamingCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStreamingCodeID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCreationDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnNewActivation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveDiscount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditActivation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNewDiscount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXls As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents white_label As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents used_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents created_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents expiration_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtActivationGroupID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExpirationDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtused_at As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExpiredTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents mailid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMailID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtemail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents chkWhiteLabel As DevExpress.XtraEditors.CheckEdit

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStreamingCode))
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.btnGenerate = New DevExpress.XtraEditors.SimpleButton
        Me.DS = New PlushLib.dsMarketting
        Me.txtQtyToGenerate = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtPrefix = New DevExpress.XtraEditors.TextEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.GroupSearch = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtExpiredTo = New DevExpress.XtraEditors.DateEdit
        Me.btnXls = New DevExpress.XtraEditors.SimpleButton
        Me.btnNewActivation = New DevExpress.XtraEditors.SimpleButton
        Me.btnEx = New DevExpress.XtraEditors.SimpleButton
        Me.lblActivationGroupID = New DevExpress.XtraEditors.LabelControl
        Me.chkOnlyUsed = New DevExpress.XtraEditors.CheckEdit
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.txtActivationGroupIDSearch = New DevExpress.XtraEditors.TextEdit
        Me.txtStreamingCodeSearch = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.lblSearchName = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.lblSearch = New DevExpress.XtraEditors.LabelControl
        Me.txtSearchID = New DevExpress.XtraEditors.TextEdit
        Me.tabResult2 = New DevExpress.XtraTab.XtraTabPage
        Me.GridStreamingCode = New DevExpress.XtraGrid.GridControl
        Me.GridViewStreamingCode = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.streaming_code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_group_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.white_label = New DevExpress.XtraGrid.Columns.GridColumn
        Me.used_at = New DevExpress.XtraGrid.Columns.GridColumn
        Me.created_at = New DevExpress.XtraGrid.Columns.GridColumn
        Me.expiration_at = New DevExpress.XtraGrid.Columns.GridColumn
        Me.mailid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.txtStreamingCode = New DevExpress.XtraEditors.TextEdit
        Me.txtStreamingCodeID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.txtCreationDate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaveDiscount = New DevExpress.XtraEditors.SimpleButton
        Me.btnEditActivation = New DevExpress.XtraEditors.SimpleButton
        Me.btnNewDiscount = New DevExpress.XtraEditors.SimpleButton
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtExpirationDate = New DevExpress.XtraEditors.DateEdit
        Me.txtActivationGroupID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtused_at = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.chkWhiteLabel = New DevExpress.XtraEditors.CheckEdit
        Me.txtemail = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtMailID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
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
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtyToGenerate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrefix.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.tabSearch.SuspendLayout()
        CType(Me.GroupSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupSearch.SuspendLayout()
        CType(Me.txtExpiredTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExpiredTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOnlyUsed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivationGroupIDSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStreamingCodeSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearchID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabResult2.SuspendLayout()
        CType(Me.GridStreamingCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewStreamingCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStreamingCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStreamingCodeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreationDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreationDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExpirationDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExpirationDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivationGroupID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtused_at.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkWhiteLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtemail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMailID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSearch, Me.tabResult2})
        Me.TabControl1.Controls.SetChildIndex(Me.TabChart, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabAnalyse, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.tabResult2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabParameters, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabResult, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.tabSearch, 0)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.txtMailID)
        Me.TabParameters.Controls.Add(Me.LabelControl6)
        Me.TabParameters.Controls.Add(Me.txtemail)
        Me.TabParameters.Controls.Add(Me.LabelControl5)
        Me.TabParameters.Controls.Add(Me.chkWhiteLabel)
        Me.TabParameters.Controls.Add(Me.txtused_at)
        Me.TabParameters.Controls.Add(Me.LabelControl3)
        Me.TabParameters.Controls.Add(Me.txtActivationGroupID)
        Me.TabParameters.Controls.Add(Me.LabelControl2)
        Me.TabParameters.Controls.Add(Me.LabelControl1)
        Me.TabParameters.Controls.Add(Me.txtExpirationDate)
        Me.TabParameters.Controls.Add(Me.btnCancel)
        Me.TabParameters.Controls.Add(Me.btnSaveDiscount)
        Me.TabParameters.Controls.Add(Me.btnEditActivation)
        Me.TabParameters.Controls.Add(Me.btnNewDiscount)
        Me.TabParameters.Controls.Add(Me.LabelControl26)
        Me.TabParameters.Controls.Add(Me.txtCreationDate)
        Me.TabParameters.Controls.Add(Me.LabelControl25)
        Me.TabParameters.Controls.Add(Me.txtStreamingCodeID)
        Me.TabParameters.Controls.Add(Me.txtStreamingCode)
        Me.TabParameters.Controls.Add(Me.LabelControl19)
        Me.TabParameters.Controls.Add(Me.GroupControl1)
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
        'btnViewDetail
        '
        Me.btnViewDetail.Glyph = CType(resources.GetObject("btnViewDetail.Glyph"), System.Drawing.Image)
        '
        'Grid1
        '
        resources.ApplyResources(Me.Grid1, "Grid1")
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.FormsUseDefaultLookAndFeel = False
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.HelpProvider1.SetShowHelp(Me.Grid1, CType(resources.GetObject("Grid1.ShowHelp"), Boolean))
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        resources.ApplyResources(Me.GridView1, "GridView1")
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowBands = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'btnGenerate
        '
        resources.ApplyResources(Me.btnGenerate, "btnGenerate")
        Me.btnGenerate.Name = "btnGenerate"
        '
        'DS
        '
        Me.DS.DataSetName = "dsMarketting"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtQtyToGenerate
        '
        resources.ApplyResources(Me.txtQtyToGenerate, "txtQtyToGenerate")
        Me.txtQtyToGenerate.Name = "txtQtyToGenerate"
        Me.txtQtyToGenerate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtQtyToGenerate.Properties.MaxLength = 1000000
        Me.txtQtyToGenerate.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtQtyToGenerate, CType(resources.GetObject("txtQtyToGenerate.ShowHelp"), Boolean))
        '
        'LabelControl7
        '
        resources.ApplyResources(Me.LabelControl7, "LabelControl7")
        Me.LabelControl7.Name = "LabelControl7"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl7, CType(resources.GetObject("LabelControl7.ShowHelp"), Boolean))
        '
        'LabelControl9
        '
        resources.ApplyResources(Me.LabelControl9, "LabelControl9")
        Me.LabelControl9.Name = "LabelControl9"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl9, CType(resources.GetObject("LabelControl9.ShowHelp"), Boolean))
        '
        'txtPrefix
        '
        resources.ApplyResources(Me.txtPrefix, "txtPrefix")
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Properties.MaxLength = 5
        Me.HelpProvider1.SetShowHelp(Me.txtPrefix, CType(resources.GetObject("txtPrefix.ShowHelp"), Boolean))
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.txtQtyToGenerate)
        Me.GroupControl1.Controls.Add(Me.btnGenerate)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txtPrefix)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Name = "GroupControl1"
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.GroupSearch)
        Me.tabSearch.Name = "tabSearch"
        resources.ApplyResources(Me.tabSearch, "tabSearch")
        '
        'GroupSearch
        '
        resources.ApplyResources(Me.GroupSearch, "GroupSearch")
        Me.GroupSearch.Controls.Add(Me.LabelControl4)
        Me.GroupSearch.Controls.Add(Me.txtExpiredTo)
        Me.GroupSearch.Controls.Add(Me.btnXls)
        Me.GroupSearch.Controls.Add(Me.btnNewActivation)
        Me.GroupSearch.Controls.Add(Me.btnEx)
        Me.GroupSearch.Controls.Add(Me.lblActivationGroupID)
        Me.GroupSearch.Controls.Add(Me.chkOnlyUsed)
        Me.GroupSearch.Controls.Add(Me.txtFromDate)
        Me.GroupSearch.Controls.Add(Me.txtActivationGroupIDSearch)
        Me.GroupSearch.Controls.Add(Me.txtStreamingCodeSearch)
        Me.GroupSearch.Controls.Add(Me.LabelControl16)
        Me.GroupSearch.Controls.Add(Me.lblSearchName)
        Me.GroupSearch.Controls.Add(Me.txtToDate)
        Me.GroupSearch.Controls.Add(Me.btnSearch)
        Me.GroupSearch.Controls.Add(Me.LabelControl17)
        Me.GroupSearch.Controls.Add(Me.lblSearch)
        Me.GroupSearch.Controls.Add(Me.txtSearchID)
        Me.GroupSearch.Name = "GroupSearch"
        Me.HelpProvider1.SetShowHelp(Me.GroupSearch, CType(resources.GetObject("GroupSearch.ShowHelp"), Boolean))
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl4, CType(resources.GetObject("LabelControl4.ShowHelp"), Boolean))
        '
        'txtExpiredTo
        '
        Me.txtExpiredTo.EditValue = Nothing
        resources.ApplyResources(Me.txtExpiredTo, "txtExpiredTo")
        Me.txtExpiredTo.Name = "txtExpiredTo"
        Me.txtExpiredTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtExpiredTo.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtExpiredTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtExpiredTo, CType(resources.GetObject("txtExpiredTo.ShowHelp"), Boolean))
        '
        'btnXls
        '
        Me.btnXls.Image = CType(resources.GetObject("btnXls.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.btnXls, "btnXls")
        Me.btnXls.Name = "btnXls"
        Me.HelpProvider1.SetShowHelp(Me.btnXls, CType(resources.GetObject("btnXls.ShowHelp"), Boolean))
        '
        'btnNewActivation
        '
        resources.ApplyResources(Me.btnNewActivation, "btnNewActivation")
        Me.btnNewActivation.Name = "btnNewActivation"
        Me.HelpProvider1.SetShowHelp(Me.btnNewActivation, CType(resources.GetObject("btnNewActivation.ShowHelp"), Boolean))
        '
        'btnEx
        '
        resources.ApplyResources(Me.btnEx, "btnEx")
        Me.btnEx.Name = "btnEx"
        Me.HelpProvider1.SetShowHelp(Me.btnEx, CType(resources.GetObject("btnEx.ShowHelp"), Boolean))
        '
        'lblActivationGroupID
        '
        resources.ApplyResources(Me.lblActivationGroupID, "lblActivationGroupID")
        Me.lblActivationGroupID.Name = "lblActivationGroupID"
        Me.HelpProvider1.SetShowHelp(Me.lblActivationGroupID, CType(resources.GetObject("lblActivationGroupID.ShowHelp"), Boolean))
        '
        'chkOnlyUsed
        '
        resources.ApplyResources(Me.chkOnlyUsed, "chkOnlyUsed")
        Me.chkOnlyUsed.Name = "chkOnlyUsed"
        Me.chkOnlyUsed.Properties.Caption = resources.GetString("chkOnlyUsed.Properties.Caption")
        Me.chkOnlyUsed.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.HelpProvider1.SetShowHelp(Me.chkOnlyUsed, CType(resources.GetObject("chkOnlyUsed.ShowHelp"), Boolean))
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
        'txtActivationGroupIDSearch
        '
        resources.ApplyResources(Me.txtActivationGroupIDSearch, "txtActivationGroupIDSearch")
        Me.txtActivationGroupIDSearch.Name = "txtActivationGroupIDSearch"
        Me.txtActivationGroupIDSearch.Properties.Mask.EditMask = resources.GetString("txtActivationGroupIDSearch.Properties.Mask.EditMask")
        Me.txtActivationGroupIDSearch.Properties.Mask.MaskType = CType(resources.GetObject("txtActivationGroupIDSearch.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.HelpProvider1.SetShowHelp(Me.txtActivationGroupIDSearch, CType(resources.GetObject("txtActivationGroupIDSearch.ShowHelp"), Boolean))
        '
        'txtStreamingCodeSearch
        '
        resources.ApplyResources(Me.txtStreamingCodeSearch, "txtStreamingCodeSearch")
        Me.txtStreamingCodeSearch.Name = "txtStreamingCodeSearch"
        Me.HelpProvider1.SetShowHelp(Me.txtStreamingCodeSearch, CType(resources.GetObject("txtStreamingCodeSearch.ShowHelp"), Boolean))
        '
        'LabelControl16
        '
        resources.ApplyResources(Me.LabelControl16, "LabelControl16")
        Me.LabelControl16.Name = "LabelControl16"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl16, CType(resources.GetObject("LabelControl16.ShowHelp"), Boolean))
        '
        'lblSearchName
        '
        resources.ApplyResources(Me.lblSearchName, "lblSearchName")
        Me.lblSearchName.Name = "lblSearchName"
        Me.HelpProvider1.SetShowHelp(Me.lblSearchName, CType(resources.GetObject("lblSearchName.ShowHelp"), Boolean))
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
        'btnSearch
        '
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.Name = "btnSearch"
        Me.HelpProvider1.SetShowHelp(Me.btnSearch, CType(resources.GetObject("btnSearch.ShowHelp"), Boolean))
        '
        'LabelControl17
        '
        resources.ApplyResources(Me.LabelControl17, "LabelControl17")
        Me.LabelControl17.Name = "LabelControl17"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl17, CType(resources.GetObject("LabelControl17.ShowHelp"), Boolean))
        '
        'lblSearch
        '
        resources.ApplyResources(Me.lblSearch, "lblSearch")
        Me.lblSearch.Name = "lblSearch"
        Me.HelpProvider1.SetShowHelp(Me.lblSearch, CType(resources.GetObject("lblSearch.ShowHelp"), Boolean))
        '
        'txtSearchID
        '
        resources.ApplyResources(Me.txtSearchID, "txtSearchID")
        Me.txtSearchID.Name = "txtSearchID"
        Me.txtSearchID.Properties.Mask.EditMask = resources.GetString("txtSearchID.Properties.Mask.EditMask")
        Me.txtSearchID.Properties.Mask.MaskType = CType(resources.GetObject("txtSearchID.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.HelpProvider1.SetShowHelp(Me.txtSearchID, CType(resources.GetObject("txtSearchID.ShowHelp"), Boolean))
        '
        'tabResult2
        '
        Me.tabResult2.Controls.Add(Me.GridStreamingCode)
        Me.tabResult2.Name = "tabResult2"
        resources.ApplyResources(Me.tabResult2, "tabResult2")
        '
        'GridStreamingCode
        '
        resources.ApplyResources(Me.GridStreamingCode, "GridStreamingCode")
        Me.GridStreamingCode.EmbeddedNavigator.Name = ""
        Me.GridStreamingCode.FormsUseDefaultLookAndFeel = False
        Me.GridStreamingCode.MainView = Me.GridViewStreamingCode
        Me.GridStreamingCode.Name = "GridStreamingCode"
        Me.GridStreamingCode.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewStreamingCode})
        '
        'GridViewStreamingCode
        '
        Me.GridViewStreamingCode.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID, Me.streaming_code, Me.activation_group_id, Me.white_label, Me.used_at, Me.created_at, Me.expiration_at, Me.mailid, Me.colEmail})
        Me.GridViewStreamingCode.CustomizationFormBounds = New System.Drawing.Rectangle(1374, 598, 216, 178)
        Me.GridViewStreamingCode.GridControl = Me.GridStreamingCode
        Me.GridViewStreamingCode.Name = "GridViewStreamingCode"
        Me.GridViewStreamingCode.OptionsView.ShowFooter = True
        '
        'ID
        '
        resources.ApplyResources(Me.ID, "ID")
        Me.ID.FieldName = "id"
        Me.ID.Name = "ID"
        Me.ID.OptionsColumn.ReadOnly = True
        '
        'streaming_code
        '
        resources.ApplyResources(Me.streaming_code, "streaming_code")
        Me.streaming_code.FieldName = "name"
        Me.streaming_code.Name = "streaming_code"
        Me.streaming_code.OptionsColumn.ReadOnly = True
        '
        'activation_group_id
        '
        resources.ApplyResources(Me.activation_group_id, "activation_group_id")
        Me.activation_group_id.FieldName = "activation_group_id"
        Me.activation_group_id.Name = "activation_group_id"
        '
        'white_label
        '
        resources.ApplyResources(Me.white_label, "white_label")
        Me.white_label.FieldName = "white_label"
        Me.white_label.Name = "white_label"
        '
        'used_at
        '
        resources.ApplyResources(Me.used_at, "used_at")
        Me.used_at.FieldName = "used_at"
        Me.used_at.Name = "used_at"
        '
        'created_at
        '
        resources.ApplyResources(Me.created_at, "created_at")
        Me.created_at.FieldName = "created_at"
        Me.created_at.Name = "created_at"
        '
        'expiration_at
        '
        resources.ApplyResources(Me.expiration_at, "expiration_at")
        Me.expiration_at.FieldName = "expiration_at"
        Me.expiration_at.Name = "expiration_at"
        '
        'mailid
        '
        resources.ApplyResources(Me.mailid, "mailid")
        Me.mailid.FieldName = "mail_id"
        Me.mailid.Name = "mailid"
        '
        'colEmail
        '
        resources.ApplyResources(Me.colEmail, "colEmail")
        Me.colEmail.FieldName = "email"
        Me.colEmail.Name = "colEmail"
        '
        'LabelControl19
        '
        resources.ApplyResources(Me.LabelControl19, "LabelControl19")
        Me.LabelControl19.Name = "LabelControl19"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl19, CType(resources.GetObject("LabelControl19.ShowHelp"), Boolean))
        '
        'txtStreamingCode
        '
        resources.ApplyResources(Me.txtStreamingCode, "txtStreamingCode")
        Me.txtStreamingCode.Name = "txtStreamingCode"
        Me.HelpProvider1.SetShowHelp(Me.txtStreamingCode, CType(resources.GetObject("txtStreamingCode.ShowHelp"), Boolean))
        '
        'txtStreamingCodeID
        '
        resources.ApplyResources(Me.txtStreamingCodeID, "txtStreamingCodeID")
        Me.txtStreamingCodeID.Name = "txtStreamingCodeID"
        Me.HelpProvider1.SetShowHelp(Me.txtStreamingCodeID, CType(resources.GetObject("txtStreamingCodeID.ShowHelp"), Boolean))
        '
        'LabelControl25
        '
        resources.ApplyResources(Me.LabelControl25, "LabelControl25")
        Me.LabelControl25.Name = "LabelControl25"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl25, CType(resources.GetObject("LabelControl25.ShowHelp"), Boolean))
        '
        'txtCreationDate
        '
        resources.ApplyResources(Me.txtCreationDate, "txtCreationDate")
        Me.txtCreationDate.Name = "txtCreationDate"
        Me.txtCreationDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtCreationDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtCreationDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtCreationDate, CType(resources.GetObject("txtCreationDate.ShowHelp"), Boolean))
        '
        'LabelControl26
        '
        resources.ApplyResources(Me.LabelControl26, "LabelControl26")
        Me.LabelControl26.Name = "LabelControl26"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl26, CType(resources.GetObject("LabelControl26.ShowHelp"), Boolean))
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        Me.HelpProvider1.SetShowHelp(Me.btnCancel, CType(resources.GetObject("btnCancel.ShowHelp"), Boolean))
        '
        'btnSaveDiscount
        '
        resources.ApplyResources(Me.btnSaveDiscount, "btnSaveDiscount")
        Me.btnSaveDiscount.Name = "btnSaveDiscount"
        Me.HelpProvider1.SetShowHelp(Me.btnSaveDiscount, CType(resources.GetObject("btnSaveDiscount.ShowHelp"), Boolean))
        '
        'btnEditActivation
        '
        resources.ApplyResources(Me.btnEditActivation, "btnEditActivation")
        Me.btnEditActivation.Name = "btnEditActivation"
        Me.HelpProvider1.SetShowHelp(Me.btnEditActivation, CType(resources.GetObject("btnEditActivation.ShowHelp"), Boolean))
        '
        'btnNewDiscount
        '
        resources.ApplyResources(Me.btnNewDiscount, "btnNewDiscount")
        Me.btnNewDiscount.Name = "btnNewDiscount"
        Me.HelpProvider1.SetShowHelp(Me.btnNewDiscount, CType(resources.GetObject("btnNewDiscount.ShowHelp"), Boolean))
        '
        'BarManager2
        '
        Me.BarManager2.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {CType(resources.GetObject("BarManager2.Categories"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager2.Categories1"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager2.Categories2"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager2.Categories3"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager2.Categories4"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager2.Categories5"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager2.Categories6"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager2.Categories7"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager2.Categories8"), DevExpress.XtraBars.BarManagerCategory)})
        Me.BarManager2.Form = Me
        Me.BarManager2.MaxItemId = 73
        Me.BarManager2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbViewListRepos, Me.txtQuickSearchRepos, Me.cmbReportListRepos, Me.cmbFilterListRepos, Me.cmbDefaultListRepos})
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, CType(resources.GetObject("LabelControl1.ShowHelp"), Boolean))
        '
        'txtExpirationDate
        '
        resources.ApplyResources(Me.txtExpirationDate, "txtExpirationDate")
        Me.txtExpirationDate.Name = "txtExpirationDate"
        Me.txtExpirationDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtExpirationDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtExpirationDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtExpirationDate, CType(resources.GetObject("txtExpirationDate.ShowHelp"), Boolean))
        '
        'txtActivationGroupID
        '
        resources.ApplyResources(Me.txtActivationGroupID, "txtActivationGroupID")
        Me.txtActivationGroupID.Name = "txtActivationGroupID"
        Me.txtActivationGroupID.Properties.Mask.EditMask = resources.GetString("txtActivationGroupID.Properties.Mask.EditMask")
        Me.txtActivationGroupID.Properties.Mask.MaskType = CType(resources.GetObject("txtActivationGroupID.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.HelpProvider1.SetShowHelp(Me.txtActivationGroupID, CType(resources.GetObject("txtActivationGroupID.ShowHelp"), Boolean))
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, CType(resources.GetObject("LabelControl2.ShowHelp"), Boolean))
        '
        'txtused_at
        '
        resources.ApplyResources(Me.txtused_at, "txtused_at")
        Me.txtused_at.Name = "txtused_at"
        Me.HelpProvider1.SetShowHelp(Me.txtused_at, CType(resources.GetObject("txtused_at.ShowHelp"), Boolean))
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl3, CType(resources.GetObject("LabelControl3.ShowHelp"), Boolean))
        '
        'chkWhiteLabel
        '
        resources.ApplyResources(Me.chkWhiteLabel, "chkWhiteLabel")
        Me.chkWhiteLabel.Name = "chkWhiteLabel"
        Me.chkWhiteLabel.Properties.Caption = resources.GetString("chkWhiteLabel.Properties.Caption")
        Me.chkWhiteLabel.Properties.ValueChecked = 1
        Me.chkWhiteLabel.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.chkWhiteLabel, CType(resources.GetObject("chkWhiteLabel.ShowHelp"), Boolean))
        '
        'txtemail
        '
        resources.ApplyResources(Me.txtemail, "txtemail")
        Me.txtemail.Name = "txtemail"
        Me.HelpProvider1.SetShowHelp(Me.txtemail, CType(resources.GetObject("txtemail.ShowHelp"), Boolean))
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl5, CType(resources.GetObject("LabelControl5.ShowHelp"), Boolean))
        '
        'txtMailID
        '
        resources.ApplyResources(Me.txtMailID, "txtMailID")
        Me.txtMailID.Name = "txtMailID"
        Me.txtMailID.Properties.Mask.EditMask = resources.GetString("txtMailID.Properties.Mask.EditMask")
        Me.txtMailID.Properties.Mask.MaskType = CType(resources.GetObject("txtMailID.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.HelpProvider1.SetShowHelp(Me.txtMailID, CType(resources.GetObject("txtMailID.ShowHelp"), Boolean))
        '
        'LabelControl6
        '
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Name = "LabelControl6"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl6, CType(resources.GetObject("LabelControl6.ShowHelp"), Boolean))
        '
        'frmStreamingCode
        '
        resources.ApplyResources(Me, "$this")
        Me.BarManager1 = Me.BarManager2
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.HelpButton = False
        Me.HelpProvider1.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me, resources.GetString("$this.HelpString"))
        Me.Name = "frmStreamingCode"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
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
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtyToGenerate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrefix.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.tabSearch.ResumeLayout(False)
        CType(Me.GroupSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupSearch.ResumeLayout(False)
        Me.GroupSearch.PerformLayout()
        CType(Me.txtExpiredTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExpiredTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOnlyUsed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivationGroupIDSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStreamingCodeSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearchID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabResult2.ResumeLayout(False)
        CType(Me.GridStreamingCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewStreamingCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStreamingCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStreamingCodeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreationDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreationDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExpirationDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExpirationDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivationGroupID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtused_at.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkWhiteLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtemail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMailID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim KeyDataSet As String = "BizzLib.dsMarketting" 'The Dataset used 
    Dim CurrentCodeType As String
    Dim param As PlushBuziness.clsSingleton
    ' Public WithEvents cmbLeverancier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    ' free_upgrade_allowed, footer, campaign, combined_action
    Dim _streamingId As Integer
    Dim _streamingCode As String
    Dim _campaignId As String
    Dim _activationGroupId As Integer
    Dim _mail_id As String
    Dim _Email As String
    Dim _streamingCodeCreatedAt As String
    Dim _streamingCodeExpiredAt As String
    Dim _streamingCodeWhiteList As Boolean
    Dim _streamingCodeUsedAt As String

    Dim _enableField As Boolean

    Enum StepForm
        EDIT
        [NEW]
        SAVE
        CANCEL
        INIT
        LOAD
    End Enum


    Private Sub ChangeStep(ByVal stepCurrent As StepForm)
        Select Case stepCurrent
            Case StepForm.CANCEL
                btnEditActivation.Enabled = True
                btnSaveDiscount.Enabled = False
                btnGenerate.Enabled = False
                btnNew.Enabled = True
                btnCancel.Enabled = False

                EnableField(False)
                btnGenerate.Enabled = False

                tabSearch.PageVisible = True
                tabResult2.PageVisible = True

            Case StepForm.EDIT
                btnEditActivation.Enabled = False
                btnSaveDiscount.Enabled = True
                btnNew.Enabled = False
                btnCancel.Enabled = True
                btnGenerate.Enabled = True

                EnableField(True)
                btnGenerate.Enabled = True
                TabParameters.PageVisible = True
                tabResult2.PageVisible = False

            Case StepForm.INIT
                btnEditActivation.Enabled = False
                btnSaveDiscount.Enabled = False
                btnNew.Enabled = True
                btnCancel.Enabled = False
                btnGenerate.Enabled = False

                EnableField(False)
                btnGenerate.Enabled = False
                tabResult2.PageVisible = False
                tabSearch.PageVisible = True
                TabParameters.PageVisible = False
                TabControl1.SelectedTabPage = tabSearch


            Case StepForm.[NEW]
                btnEditActivation.Enabled = False
                btnSaveDiscount.Enabled = True
                btnNew.Enabled = False
                btnCancel.Enabled = True
                btnGenerate.Enabled = True

                btnGenerate.Enabled = True
                EnableField(True)
                tabResult2.PageVisible = False
                TabParameters.PageVisible = True
                TabControl1.SelectedTabPage = TabParameters



            Case StepForm.SAVE
                btnEditActivation.Enabled = True
                btnSaveDiscount.Enabled = False
                btnNew.Enabled = True
                btnCancel.Enabled = False
                btnGenerate.Enabled = False

                btnGenerate.Enabled = False
                EnableField(False)
                TabParameters.PageVisible = True
                tabResult2.PageVisible = True

            Case StepForm.LOAD
                btnEditActivation.Enabled = True
                btnSaveDiscount.Enabled = False
                btnNew.Enabled = True
                btnCancel.Enabled = False
                btnGenerate.Enabled = False

                EnableField(False)
                btnGenerate.Enabled = False
                TabParameters.PageVisible = True
                TabControl1.SelectedTabPage = TabParameters

        End Select
    End Sub

    Public Sub this_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        GridViewStreamingCode.OptionsView.ColumnAutoWidth = False
        GridViewStreamingCode.OptionsBehavior.Editable = False

        TabControl1.SelectedTabPage = tabSearch
        ' Misc_Bar.Visible = True
        TabParameters.PageVisible = False
        TabAnalyse.PageVisible = False ' not used
        TabChart.PageVisible = False ' not used
        TabResult.PageVisible = False ' not used


        Dim menuStrip As New PlushBuziness.contextMenu()
        GridStreamingCode.ContextMenuStrip = menuStrip
        'LoadBKComboSet()
        ChangeStep(StepForm.INIT)


    End Sub

    'Public Sub LoadBKComboSet()

    '    cmbGroup.Properties.DataSource = GetListCmb(PlushData.clsActivationCode.GetActivationGroup, "activation_group_name", "activation_group_id") 'GetCombo(PlushData.clsActivationCode.GetActivationGroup)
    '    cmbProductsID.Properties.DataSource = GetListCmb(PlushData.clsActivationCode.GetProducts(PlushData.clsActivationCode.productsTypeAbo), "products_title", "products_id") 'GetCombo(PlushData.clsActivationCode.GetProducts(PlushData.clsActivationCode.productsTypeAbo))
    '    cmbValidType.Properties.DataSource = GetListCmb(PlushData.clsActivationCode.GetActivationValidityType, "validity_type_explained", "validity_type_id") 'GetCombo(PlushData.clsActivationCode.GetActivationValidityType)
    '    cmbNextDiscount.Properties.DataSource = GetListCmb(PlushData.clsActivationCode.GetDiscountCode(), "discount_code", "discount_code_id") 'GetCombo(PlushData.clsActivationCode.GetDiscountCode)
    '    cmbGroupSearch.Properties.DataSource = GetListCmb(PlushData.clsActivationCode.GetActivationGroup(), "activation_group_name", "activation_group_id")
    '    cmbCombinedAction.Properties.DataSource = GetListCombinedAction()
    '    cmbNextAboType.Properties.DataSource = GetListCmb(PlushData.clsActivationCode.GetProducts(PlushData.clsActivationCode.productsTypeAbo), "products_title", "products_id")
    '    loadDiscountAction()

    'End Sub

    Private Function GetListCombinedAction() As List(Of PlushBuziness.clsKeyCombo)
        Dim listCmb As New List(Of PlushBuziness.clsKeyCombo)
        listCmb.Add(New PlushBuziness.clsKeyCombo("YES", 0))
        listCmb.Add(New PlushBuziness.clsKeyCombo("NO", 1))
        Return listCmb
    End Function
    Private Function GetListCmb(ByVal sql As String, ByVal displayMember As String, ByVal value As String) As List(Of PlushBuziness.clsKeyCombo)
        Dim listCmb As New List(Of PlushBuziness.clsKeyCombo)
        Dim dt As DataTable
        Dim dr As DataRow

        dt = PlushData.clsConnection.FillDataSet(sql)

        listCmb.Add(New PlushBuziness.clsKeyCombo("", 0))
        For Each dr In dt.Rows
            listCmb.Add(New PlushBuziness.clsKeyCombo(dr(displayMember), dr(value)))
        Next

        Return listCmb
    End Function


    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim number As Integer
        Dim ok As Boolean
        number = txtQtyToGenerate.EditValue
        If txtQtyToGenerate.EditValue <= 0 Or (txtPrefix.Text & "" = "" And txtPrefix.Text.Length < 4) Then
            MsgBox("Specify a Nbr of code to generate " _
                   & " and specify a Prefix with 4 characters ", MsgBoxStyle.Critical)
        Else
            ok = CheckTextBox()
            If ok Then
                loadVarUpdateInsert()
                generateActivationCode(number)
                ChangeStep(StepForm.SAVE)
            End If

        End If
        'If txtPrefix.Text & "" = "" And txtPrefix.Text.Length < 4 Then
        '    MsgBox("Please specify a Prefix with 4 characters", MsgBoxStyle.Critical)

        '    Exit Sub
        'End If


    End Sub


    Private Function CheckTextBox() As Boolean

        Return True

    End Function


    'Private Sub loadDiscountAction()
    '    Dim listCmb As New List(Of PlushBuziness.clsKeyCombo)
    '    Dim lstdiscountaction As List(Of PlushBuziness.clsKeyComboEnum)
    '    Dim sql As String
    '    Dim dr As DataRow

    '    sql = PlushData.clsActivationCode.GetEnumMysqlDiscountAction()
    '    lstdiscountaction = PlushBuziness.ClsCombo.GetListEnum(sql)

    '    listCmb.Add(New PlushBuziness.clsKeyCombo("", 0))
    '    For i As Integer = 0 To lstdiscountaction.Count - 1
    '        listCmb.Add(New PlushBuziness.clsKeyCombo(lstdiscountaction(i).Value, i + 1))
    '    Next

    '    'cmbDiscountAction.Properties.ValueMember = "Value"
    '    'cmbDiscountAction.Properties.DisplayMember = "DisplayMember"
    '    cmbDiscountAction.Properties.DataSource = listCmb
    '    cmbDiscountAction.SelectedText = ""
    'End Sub

    Private Sub generateActivationCode(ByVal number As Integer)
        Dim tabCode As ArrayList = createData(number)
        Dim count As Integer = 0
        Dim el As String
        Dim fieldInsert As String = ""
        'Dim strline As String
        Dim sql As String

        PlushData.clsConnection.CreateTransaction(True)

        For Each el In tabCode
            count += 1

            sql = PlushData.clsStreamingCode.insertStreamingCode(el, _activationGroupId, _streamingCodeCreatedAt, _streamingCodeExpiredAt, _
                                                                    _streamingCodeUsedAt, _streamingCodeWhiteList)
            PlushData.clsConnection.ExecuteNonQuery(sql)

        Next
        PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Discount, count)

        MsgBox(count.ToString & " streaming code created")

    End Sub
    Public Function GenerateCode() As String
        Dim _Code As String

        _Code = Guid.NewGuid().ToString().GetHashCode.ToString("X")

        _Code = Replace(_Code, "0", "-")
        _Code = Replace(_Code, "O", "-")
        _Code = txtPrefix.Text.ToUpper + _Code
        _Code.ToUpper()

        Return _Code.Substring(0, _Code.Length - 2)
    End Function

    Public Function getActivationCode() As DataView
        Dim dt As DataTable
        dt = PlushData.clsConnection.FillDataSet(PlushData.clsActivationCode.GetActivationSearch(, , txtPrefix.Text)) 'GetActivationWithPrefixe(txtPrefix.Text))
        Dim view As New DataView(dt, "", "activation_code", DataViewRowState.CurrentRows)
        Return view
    End Function


    Public Function createData(ByVal maxNumber As Integer) As ArrayList

        Dim activationCode As String
        Dim tabActivationCode As New ArrayList
        Dim viewExist As DataView = getActivationCode()

        Dim dico As New System.Collections.Generic.Dictionary(Of String, String)
        For Each data As DataRowView In viewExist
            dico.Add(data.Row("activation_code").ToUpper(), "")
        Next

        Dim i As Integer

        For i = 0 To maxNumber - 1
            activationCode = GenerateCode()

            While (dico.ContainsKey((activationCode).ToUpper()) = True)
                activationCode = GenerateCode()
            End While

            tabActivationCode.Add(activationCode)
            dico.Add(activationCode.ToUpper(), "")
        Next

        Return tabActivationCode
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        search()

        TabParameters.PageVisible = False
        tabResult2.PageVisible = True
        TabControl1.SelectedTabPage = tabResult2
    End Sub

    Public Sub search()
        Dim streaming_code_id As String
        Dim streaming_code As String
        Dim streamingUse As Boolean = False
        Dim dateTo As String
        Dim dateFrom As String
        Dim dateExpirationTo As String
        Dim ActivationGroupId As String
        Dim streamingcodeUse As Boolean
        Dim dt As DataTable
        Dim sqlSearch As String

        streaming_code_id = txtSearchID.Text.Trim
        streaming_code = txtStreamingCodeSearch.Text.Trim
        dateFrom = txtFromDate.EditValue
        dateTo = txtToDate.EditValue
        dateExpirationTo = txtExpiredTo.EditValue
        ActivationGroupId = txtActivationGroupIDSearch.Text.Trim

        If chkOnlyUsed.Checked = True Then
            streamingcodeUse = True
        End If

        sqlSearch = PlushData.clsStreamingCode.GetStreamingCodeSearch(streaming_code_id, streaming_code, streamingcodeUse, dateFrom, dateTo, dateExpirationTo, ActivationGroupId)
        dt = PlushData.clsConnection.FillDataSet(sqlSearch)
        GridStreamingCode.DataSource = dt

        btnXls.Visible = dt.Rows.Count > 0


    End Sub


    Private Function GetCombo(ByVal sql As String) As DataTable
        Dim dt As DataTable
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt
    End Function



    Private Sub loadActivationExpiration()
        Dim dt As DataTable
        Dim sqlActivationExp As String = PlushData.clsActivationCode.GetActivationExpiration()
        dt = PlushData.clsConnection.FillDataSet(sqlActivationExp)
        GridStreamingCode.DataSource = dt
        TabControl1.SelectedTabPage = tabResult2
    End Sub


    Private Sub btnEx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEx.Click
        loadActivationExpiration()
        AddHandler GridViewStreamingCode.RowStyle, AddressOf GridViewActivationCode_RowStyle
    End Sub

    'change color of the row by gauthier
    Public Sub GridViewActivationCode_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs)
        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender
        If (e.RowHandle >= 0) Then
            Dim validitytoString As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("expiration_at")).ToString
            If validitytoString <> "" Then
                Dim validityToDate As Date = CType(validitytoString, Date)
                If validityToDate >= Date.Now Then
                    e.Appearance.BackColor = Drawing.Color.LightGreen
                    e.Appearance.BackColor2 = Drawing.Color.SeaShell
                End If

                If validityToDate < Date.Now Then
                    e.Appearance.BackColor = Drawing.Color.LightSalmon
                    e.Appearance.BackColor2 = Drawing.Color.SeaShell
                End If

            End If
        End If
    End Sub
    Private Sub initForm()
        Dim blank As String = String.Empty
        txtStreamingCodeID.EditValue = blank
        txtStreamingCode.EditValue = blank
        txtActivationGroupID.EditValue = blank
        txtemail.EditValue = blank
        txtMailID.EditValue = blank
        txtused_at.EditValue = blank
        chkWhiteLabel.Checked = False
        txtCreationDate.EditValue = blank
        txtExpirationDate.EditValue = blank

    End Sub


    Private Sub loadTextBoxInfo(ByVal dr As DataRow)
        txtStreamingCodeID.EditValue = clsMarketing.clsStreamingCode.GetStreamingId(dr)
        txtStreamingCode.EditValue = clsMarketing.clsStreamingCode.GetStreamingCode(dr)
        txtActivationGroupID.EditValue = clsMarketing.clsStreamingCode.GetActivationGroupId(dr)
        txtemail.EditValue = clsMarketing.clsStreamingCode.GetStrimingCodeEmail(dr)
        txtMailID.EditValue = clsMarketing.clsStreamingCode.GetStreamingCodeMailID(dr)
        txtused_at.EditValue = clsMarketing.clsStreamingCode.GetStrimingCodeUsedAt(dr)
        chkWhiteLabel.Checked = clsMarketing.clsStreamingCode.GetStrimingCodeWhiteLabel(dr)
        txtCreationDate.EditValue = clsMarketing.clsStreamingCode.GetStreamingCodeCreationAt(dr)
        txtExpirationDate.EditValue = clsMarketing.clsStreamingCode.GetStreamingCodeExpirationAt(dr)

    End Sub

    Private Sub loadVarUpdateInsert()

        If txtStreamingCodeID.EditValue IsNot String.Empty Then
            _streamingId = txtStreamingCodeID.EditValue
        End If
        _streamingCode = txtStreamingCode.EditValue

        _activationGroupId = txtActivationGroupID.EditValue

        'If txtCreationDate.EditValue = "" Then
        '    _streamingCodeCreatedAt = Nothing
        'Else
        _streamingCodeCreatedAt = txtCreationDate.EditValue
        'End If

        'If txtExpirationDate.EditValue = "" Then
        '    _streamingCodeExpiredAt = Nothing
        'Else
        _streamingCodeExpiredAt = txtExpirationDate.EditValue
        'End If

        'If txtused_at.EditValue = "" Then
        '    _streamingCodeUsedAt = Nothing
        'Else
        _streamingCodeUsedAt = txtused_at.EditValue
        'End If

        _streamingCodeWhiteList = chkWhiteLabel.Checked

        _mail_id = txtMailID.EditValue
        _Email = txtemail.EditValue


    End Sub


    Private Sub loadInfoStreamingCode(ByVal activation_id As Integer)
        Dim dt As DataTable
        Dim sql As String

        sql = PlushData.clsStreamingCode.GetStreamingCodeSearch(activation_id)
        dt = PlushData.clsConnection.FillDataSet(sql)
        loadTextBoxInfo(dt.Rows(0))
    End Sub

    Private Sub GridActivationCode_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridStreamingCode.DoubleClick
        loadInfo()
        ChangeStep(StepForm.LOAD)
    End Sub

    Private Sub loadInfo()
        Dim id As Integer
        If GridViewStreamingCode.RowCount > 0 Then
            id = GridViewStreamingCode.GetDataRow(GridViewStreamingCode.FocusedRowHandle())("id")
            loadInfoStreamingCode(id)
            TabControl1.SelectedTabPage = TabParameters
        End If
    End Sub

    'Private Sub updateActivationByCust()
    '    Dim sql As String
    '    Dim count As Integer
    '    loadVarUpdateInsert()
    '    Try


    '        PlushData.clsConnection.CreateTransaction(False)
    '        sql = PlushData.clsActivationCode.updateActivationBYCust(_customersId, _activationId, _validityToChangeCustomers)
    '        count = PlushData.clsConnection.ExecuteNonQuery(sql)

    '        If MsgBox("you go to update " & count & " activations codes ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
    '            PlushData.clsConnection.CommitTransaction(True)
    '            ChangeStep(StepForm.SAVE)
    '        Else
    '            PlushData.clsConnection.CommitTransaction(False)
    '            ChangeStep(StepForm.CANCEL)
    '        End If
    '    Catch ex As Exception
    '        PlushData.clsConnection.CommitTransaction(False)
    '        PlushBuziness.clsMsgError.MsgBox(ex.Message)
    '        PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Discount, ex, _customersId)
    '    End Try
    'End Sub



    'Private Sub btnSaveBycustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    updateActivationByCust()
    'End Sub

    Private Sub updateActivation()
        Dim sql As String
        Dim activationCodeCondition As String
        Dim count As Integer

        Try

            loadVarUpdateInsert()
            activationCodeCondition = _streamingCode.Substring(0, 3)
            PlushData.clsConnection.CreateTransaction(False)
            sql = PlushData.clsStreamingCode.updateSteamingCodeByVal(_streamingId, _streamingCode, _activationGroupId, _mail_id, _Email, _
                                                                                 _streamingCodeCreatedAt, _streamingCodeExpiredAt, _
                                                                                 _streamingCodeUsedAt, _streamingCodeWhiteList)

            count = PlushData.clsConnection.ExecuteNonQuery(sql)
            If MsgBox("you go to update " & count & " streaming codes ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                PlushData.clsConnection.CommitTransaction(True)
                ChangeStep(StepForm.SAVE)
            Else
                ChangeStep(StepForm.CANCEL)
                PlushData.clsConnection.CommitTransaction(False)
            End If


        Catch ex As Exception
            PlushData.clsConnection.CommitTransaction(False)
            PlushBuziness.clsMsgError.MsgBox(ex.Message)
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Discount, ex)
        End Try



    End Sub

    Private Function EnableField(ByVal ok As Boolean) As Boolean
        Dim enable As Boolean
        enable = ok

        txtQtyToGenerate.Enabled = enable
        txtPrefix.Enabled = enable
        '
        'txtStreamingCode.Enabled = enable
        'txtStreamingCodeID.Enabled = enable
        txtStreamingCode.Enabled = enable
        txtActivationGroupID.Enabled = enable
        txtMailID.Enabled = enable
        'txtused_at.Enabled = enable
        chkWhiteLabel.Enabled = enable
        'txtCreationDate.Enabled = enable
        txtExpirationDate.Enabled = enable

        Return ok
    End Function

    Private Sub btnEditActivation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ChangeStep(StepForm.EDIT)

    End Sub

    'Public Sub enablingField() '
    '    If _enableField Then
    '        _enableField = EnableField(False)
    '        loadInfo()
    '    Else
    '        _enableField = EnableField(True)
    '    End If
    'End Sub

    Private Sub btnNewActivation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewActivation.Click

        initForm()
        ChangeStep(StepForm.[NEW])
    End Sub

    Private Sub btnEditDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditActivation.Click
        ChangeStep(StepForm.EDIT)
    End Sub

    Private Sub btnSaveDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDiscount.Click
        Dim ok As Boolean

        ok = CheckTextBox()
        If ok Then
            '  loadVarUpdateInsert()
            updateActivation()
        End If
    End Sub


    Private Sub btnNewDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewDiscount.Click
        btnNewActivation_Click(Nothing, Nothing)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ChangeStep(StepForm.CANCEL)
    End Sub

    Private Sub btnXls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXls.Click
        PlushBuziness.clsExport.ExportXls(GridViewStreamingCode)
    End Sub

End Class



