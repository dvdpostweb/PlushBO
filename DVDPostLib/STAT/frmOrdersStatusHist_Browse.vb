Public Class frmOrdersStatusHist_Browse

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
    Friend WithEvents ProgressBar1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TabPostRecl As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridPostReclamation As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPostReclamation As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DateOrderDelayedFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents current_orders_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents orders_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_dvdid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents orders_history_new_value As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents orders_history_old_value As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_street_address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_city As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_postcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_country As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_telephone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_email_address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents last_modified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents inout As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_dvd_status_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExportXls As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoadOrderDelayed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents products_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateOdersDelayedTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents date_added As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblDateFrom As System.Windows.Forms.Label
    Friend WithEvents lblDateTo As System.Windows.Forms.Label
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdersStatusHist_Browse))
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLimit = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.lbl1 = New System.Windows.Forms.Label
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtDateTo = New DevExpress.XtraEditors.DateEdit
        Me.txtDateFrom = New DevExpress.XtraEditors.DateEdit
        Me.TabPostRecl = New DevExpress.XtraTab.XtraTabPage
        Me.lblDateTo = New System.Windows.Forms.Label
        Me.lblDateFrom = New System.Windows.Forms.Label
        Me.DateOdersDelayedTo = New DevExpress.XtraEditors.DateEdit
        Me.btnExportXls = New DevExpress.XtraEditors.SimpleButton
        Me.btnLoadOrderDelayed = New DevExpress.XtraEditors.SimpleButton
        Me.DateOrderDelayedFrom = New DevExpress.XtraEditors.DateEdit
        Me.GridPostReclamation = New DevExpress.XtraGrid.GridControl
        Me.GridViewPostReclamation = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.current_orders_status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.orders_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_dvdid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.orders_history_new_value = New DevExpress.XtraGrid.Columns.GridColumn
        Me.orders_history_old_value = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_street_address = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_city = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_postcode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_country = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_telephone = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_email_address = New DevExpress.XtraGrid.Columns.GridColumn
        Me.last_modified = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.inout = New DevExpress.XtraGrid.Columns.GridColumn
        Me.products_dvd_status_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.date_added = New DevExpress.XtraGrid.Columns.GridColumn
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
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtDateTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPostRecl.SuspendLayout()
        CType(Me.DateOdersDelayedTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateOdersDelayedTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateOrderDelayedFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateOrderDelayedFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPostReclamation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPostReclamation, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabPostRecl})
        Me.TabControl1.Controls.SetChildIndex(Me.TabPostRecl, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabChart, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabAnalyse, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabResult, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabParameters, 0)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.GroupControl1)
        Me.TabParameters.Controls.Add(Me.Label6)
        Me.TabParameters.Controls.Add(Me.txtLimit)
        Me.TabParameters.Controls.Add(Me.ProgressBar1)
        Me.TabParameters.Controls.Add(Me.lbl1)
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
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.HelpProvider1.SetShowHelp(Me.ProgressBar1, CType(resources.GetObject("ProgressBar1.ShowHelp"), Boolean))
        '
        'lbl1
        '
        resources.ApplyResources(Me.lbl1, "lbl1")
        Me.lbl1.Name = "lbl1"
        Me.HelpProvider1.SetShowHelp(Me.lbl1, CType(resources.GetObject("lbl1.ShowHelp"), Boolean))
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtDateTo)
        Me.GroupControl1.Controls.Add(Me.txtDateFrom)
        Me.GroupControl1.Name = "GroupControl1"
        Me.HelpProvider1.SetShowHelp(Me.GroupControl1, CType(resources.GetObject("GroupControl1.ShowHelp"), Boolean))
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, CType(resources.GetObject("LabelControl2.ShowHelp"), Boolean))
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, CType(resources.GetObject("LabelControl1.ShowHelp"), Boolean))
        '
        'txtDateTo
        '
        Me.txtDateTo.EditValue = Nothing
        resources.ApplyResources(Me.txtDateTo, "txtDateTo")
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateTo.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtDateTo, CType(resources.GetObject("txtDateTo.ShowHelp"), Boolean))
        '
        'txtDateFrom
        '
        Me.txtDateFrom.EditValue = Nothing
        resources.ApplyResources(Me.txtDateFrom, "txtDateFrom")
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateFrom.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtDateFrom, CType(resources.GetObject("txtDateFrom.ShowHelp"), Boolean))
        '
        'TabPostRecl
        '
        Me.TabPostRecl.Controls.Add(Me.lblDateTo)
        Me.TabPostRecl.Controls.Add(Me.lblDateFrom)
        Me.TabPostRecl.Controls.Add(Me.DateOdersDelayedTo)
        Me.TabPostRecl.Controls.Add(Me.btnExportXls)
        Me.TabPostRecl.Controls.Add(Me.btnLoadOrderDelayed)
        Me.TabPostRecl.Controls.Add(Me.DateOrderDelayedFrom)
        Me.TabPostRecl.Controls.Add(Me.GridPostReclamation)
        Me.TabPostRecl.Name = "TabPostRecl"
        resources.ApplyResources(Me.TabPostRecl, "TabPostRecl")
        '
        'lblDateTo
        '
        resources.ApplyResources(Me.lblDateTo, "lblDateTo")
        Me.lblDateTo.Name = "lblDateTo"
        Me.HelpProvider1.SetShowHelp(Me.lblDateTo, CType(resources.GetObject("lblDateTo.ShowHelp"), Boolean))
        '
        'lblDateFrom
        '
        resources.ApplyResources(Me.lblDateFrom, "lblDateFrom")
        Me.lblDateFrom.Name = "lblDateFrom"
        '
        'DateOdersDelayedTo
        '
        Me.DateOdersDelayedTo.EditValue = Nothing
        resources.ApplyResources(Me.DateOdersDelayedTo, "DateOdersDelayedTo")
        Me.DateOdersDelayedTo.Name = "DateOdersDelayedTo"
        Me.DateOdersDelayedTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateOdersDelayedTo.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.DateOdersDelayedTo.Properties.DisplayFormat.FormatString = "u"
        Me.DateOdersDelayedTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateOdersDelayedTo.Properties.EditFormat.FormatString = "u"
        Me.DateOdersDelayedTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateOdersDelayedTo.Properties.Mask.EditMask = resources.GetString("DateOdersDelayedTo.Properties.Mask.EditMask")
        Me.DateOdersDelayedTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.DateOdersDelayedTo, CType(resources.GetObject("DateOdersDelayedTo.ShowHelp"), Boolean))
        '
        'btnExportXls
        '
        resources.ApplyResources(Me.btnExportXls, "btnExportXls")
        Me.btnExportXls.Name = "btnExportXls"
        '
        'btnLoadOrderDelayed
        '
        resources.ApplyResources(Me.btnLoadOrderDelayed, "btnLoadOrderDelayed")
        Me.btnLoadOrderDelayed.Name = "btnLoadOrderDelayed"
        '
        'DateOrderDelayedFrom
        '
        Me.DateOrderDelayedFrom.EditValue = Nothing
        resources.ApplyResources(Me.DateOrderDelayedFrom, "DateOrderDelayedFrom")
        Me.DateOrderDelayedFrom.Name = "DateOrderDelayedFrom"
        Me.DateOrderDelayedFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateOrderDelayedFrom.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.DateOrderDelayedFrom.Properties.DisplayFormat.FormatString = "u"
        Me.DateOrderDelayedFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateOrderDelayedFrom.Properties.EditFormat.FormatString = "u"
        Me.DateOrderDelayedFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateOrderDelayedFrom.Properties.Mask.EditMask = resources.GetString("DateOrderDelayedFrom.Properties.Mask.EditMask")
        Me.DateOrderDelayedFrom.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.DateOrderDelayedFrom, CType(resources.GetObject("DateOrderDelayedFrom.ShowHelp"), Boolean))
        '
        'GridPostReclamation
        '
        resources.ApplyResources(Me.GridPostReclamation, "GridPostReclamation")
        Me.GridPostReclamation.EmbeddedNavigator.Name = ""
        Me.GridPostReclamation.FormsUseDefaultLookAndFeel = False
        Me.GridPostReclamation.MainView = Me.GridViewPostReclamation
        Me.GridPostReclamation.Name = "GridPostReclamation"
        Me.GridPostReclamation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPostReclamation})
        '
        'GridViewPostReclamation
        '
        Me.GridViewPostReclamation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.current_orders_status, Me.orders_id, Me.products_id, Me.products_dvdid, Me.orders_history_new_value, Me.orders_history_old_value, Me.customers_id, Me.customers_name, Me.customers_street_address, Me.customers_city, Me.customers_postcode, Me.customers_country, Me.customers_telephone, Me.customers_email_address, Me.last_modified, Me.products_name, Me.inout, Me.products_dvd_status_name, Me.date_added})
        Me.GridViewPostReclamation.GridControl = Me.GridPostReclamation
        Me.GridViewPostReclamation.Name = "GridViewPostReclamation"
        Me.GridViewPostReclamation.OptionsView.ColumnAutoWidth = False
        Me.GridViewPostReclamation.OptionsView.ShowFooter = True
        '
        'current_orders_status
        '
        resources.ApplyResources(Me.current_orders_status, "current_orders_status")
        Me.current_orders_status.FieldName = "current_orders_status"
        Me.current_orders_status.Name = "current_orders_status"
        '
        'orders_id
        '
        resources.ApplyResources(Me.orders_id, "orders_id")
        Me.orders_id.FieldName = "orders_id"
        Me.orders_id.Name = "orders_id"
        '
        'products_id
        '
        resources.ApplyResources(Me.products_id, "products_id")
        Me.products_id.FieldName = "products_id1"
        Me.products_id.Name = "products_id"
        '
        'products_dvdid
        '
        resources.ApplyResources(Me.products_dvdid, "products_dvdid")
        Me.products_dvdid.FieldName = "products_dvdid"
        Me.products_dvdid.Name = "products_dvdid"
        '
        'orders_history_new_value
        '
        resources.ApplyResources(Me.orders_history_new_value, "orders_history_new_value")
        Me.orders_history_new_value.FieldName = "orders_history_new_value"
        Me.orders_history_new_value.Name = "orders_history_new_value"
        '
        'orders_history_old_value
        '
        resources.ApplyResources(Me.orders_history_old_value, "orders_history_old_value")
        Me.orders_history_old_value.FieldName = "orders_history_old_value"
        Me.orders_history_old_value.Name = "orders_history_old_value"
        '
        'customers_id
        '
        resources.ApplyResources(Me.customers_id, "customers_id")
        Me.customers_id.FieldName = "customers_id"
        Me.customers_id.Name = "customers_id"
        '
        'customers_name
        '
        resources.ApplyResources(Me.customers_name, "customers_name")
        Me.customers_name.FieldName = "customers_name"
        Me.customers_name.Name = "customers_name"
        '
        'customers_street_address
        '
        resources.ApplyResources(Me.customers_street_address, "customers_street_address")
        Me.customers_street_address.FieldName = "customers_street_address"
        Me.customers_street_address.Name = "customers_street_address"
        '
        'customers_city
        '
        resources.ApplyResources(Me.customers_city, "customers_city")
        Me.customers_city.FieldName = "customers_city"
        Me.customers_city.Name = "customers_city"
        '
        'customers_postcode
        '
        resources.ApplyResources(Me.customers_postcode, "customers_postcode")
        Me.customers_postcode.FieldName = "customers_postcode"
        Me.customers_postcode.Name = "customers_postcode"
        '
        'customers_country
        '
        resources.ApplyResources(Me.customers_country, "customers_country")
        Me.customers_country.FieldName = "customers_country"
        Me.customers_country.Name = "customers_country"
        '
        'customers_telephone
        '
        resources.ApplyResources(Me.customers_telephone, "customers_telephone")
        Me.customers_telephone.FieldName = "customers_telephone"
        Me.customers_telephone.Name = "customers_telephone"
        '
        'customers_email_address
        '
        resources.ApplyResources(Me.customers_email_address, "customers_email_address")
        Me.customers_email_address.FieldName = "customers_email_address"
        Me.customers_email_address.Name = "customers_email_address"
        '
        'last_modified
        '
        resources.ApplyResources(Me.last_modified, "last_modified")
        Me.last_modified.FieldName = "last_modified"
        Me.last_modified.Name = "last_modified"
        '
        'products_name
        '
        resources.ApplyResources(Me.products_name, "products_name")
        Me.products_name.FieldName = "products_name"
        Me.products_name.Name = "products_name"
        '
        'inout
        '
        resources.ApplyResources(Me.inout, "inout")
        Me.inout.FieldName = "inout"
        Me.inout.Name = "inout"
        '
        'products_dvd_status_name
        '
        resources.ApplyResources(Me.products_dvd_status_name, "products_dvd_status_name")
        Me.products_dvd_status_name.FieldName = "products_dvd_status_name"
        Me.products_dvd_status_name.Name = "products_dvd_status_name"
        '
        'date_added
        '
        resources.ApplyResources(Me.date_added, "date_added")
        Me.date_added.FieldName = "date_added"
        Me.date_added.Name = "date_added"
        '
        'frmOrdersStatusHist_Browse
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmOrdersStatusHist_Browse"
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
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtDateTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPostRecl.ResumeLayout(False)
        Me.TabPostRecl.PerformLayout()
        CType(Me.DateOdersDelayedTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateOdersDelayedTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateOrderDelayedFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateOrderDelayedFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPostReclamation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPostReclamation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New PlushBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip
        GridPostReclamation.ContextMenuStrip = menuStrip

        txtDateFrom.EditValue = Today
        txtDateFrom.EditValue = CDate(txtDateFrom.EditValue).AddDays(-7)
        objDS = New dsPur_Sls
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "VIEW_Orders_Status_Hist"
        MyBase.IDField = "orders_status_history_id"
        MyBase.NameField = "orders_status_name"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = False
        MyBase.StartUp()

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
        Dim _SQLTxt As String

        'Clear Table
        objDS.Tables(TableName).Clear()

        'Products
        _SQLTxt = " SELECT * " & _
            " FROM orders_status_history osh " & _
            " left join orders_status os on os.orders_status_id = osh.new_value and os.language_id = 1 " & _
            " WHERE " & _
            " osh.date_added >= '" & txtDateFrom.DateTime.Year & "-" & txtDateFrom.DateTime.Month & "-" & txtDateFrom.DateTime.Day & " 00:00:00' " & _
            " AND osh.date_added <= '" & txtDateTo.DateTime.Year & "-" & txtDateTo.DateTime.Month & "-" & txtDateTo.DateTime.Day & " 23:59:59' " & _
            "  "

        BKFilter.ApplyFilter(_SQLTxt, IsFiltered, CurrentFilterID, " ", StatusBar1.Panels(1))
        PlushData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)

        Grid1.DataSource = objDS.Tables(TableName).DefaultView '_View 
        TabControl1.SelectedTabPage = TabResult
    End Sub

    Private Sub txtLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimit.TextChanged
        _Limit = "limit 0, " & txtLimit.Text
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub

    Public Sub loadOrdersDelayed()
        Dim dtOrdersdelayed As DataTable
        Dim sqlReclamation As String
        sqlReclamation = PlushData.clsOdersStatusHistory.GetDvdDelayed(PlushTools.ClsDate.formatDate(DateOrderDelayedFrom.EditValue), PlushTools.ClsDate.formatDate(DateOdersDelayedTo.EditValue))
        dtOrdersdelayed = PlushData.clsConnection.FillDataSet(sqlReclamation)
        Me.GridPostReclamation.DataSource = dtOrdersdelayed
    End Sub

    Private Sub btnLoadOrderDelayed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadOrderDelayed.Click

        If DateOdersDelayedTo.Text = "" Or DateOrderDelayedFrom.Text = "" Then
            MsgBox("you must choose a date")
            DateOdersDelayedTo.BackColor = Drawing.Color.Blue
            DateOrderDelayedFrom.BackColor = Drawing.Color.Blue
        Else
            DateOdersDelayedTo.BackColor = Drawing.Color.White
            DateOrderDelayedFrom.BackColor = Drawing.Color.White
            loadOrdersDelayed()
        End If

    End Sub

    Private Sub btnExportXls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportXls.Click
        PlushBuziness.clsExport.ExportXls(Me.GridViewPostReclamation)
    End Sub

End Class
