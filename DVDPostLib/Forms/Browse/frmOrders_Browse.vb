Public Class frmOrders_Browse
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
    Friend WithEvents chkLanguages As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSubTitles As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrders_Browse))
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLimit = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.lbl1 = New System.Windows.Forms.Label
        Me.chkSubTitles = New DevExpress.XtraEditors.CheckEdit
        Me.chkLanguages = New DevExpress.XtraEditors.CheckEdit
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtDateTo = New DevExpress.XtraEditors.DateEdit
        Me.txtDateFrom = New DevExpress.XtraEditors.DateEdit
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
        CType(Me.chkSubTitles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLanguages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtDateTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabParameters.Controls.Add(Me.GroupControl1)
        Me.TabParameters.Controls.Add(Me.GroupControl2)
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
        'chkSubTitles
        '
        resources.ApplyResources(Me.chkSubTitles, "chkSubTitles")
        Me.chkSubTitles.Name = "chkSubTitles"
        Me.chkSubTitles.Properties.Caption = resources.GetString("chkSubTitles.Properties.Caption")
        Me.chkSubTitles.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.HelpProvider1.SetShowHelp(Me.chkSubTitles, CType(resources.GetObject("chkSubTitles.ShowHelp"), Boolean))
        '
        'chkLanguages
        '
        resources.ApplyResources(Me.chkLanguages, "chkLanguages")
        Me.chkLanguages.Name = "chkLanguages"
        Me.chkLanguages.Properties.Caption = resources.GetString("chkLanguages.Properties.Caption")
        Me.chkLanguages.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.HelpProvider1.SetShowHelp(Me.chkLanguages, CType(resources.GetObject("chkLanguages.ShowHelp"), Boolean))
        '
        'GroupControl2
        '
        resources.ApplyResources(Me.GroupControl2, "GroupControl2")
        Me.GroupControl2.Controls.Add(Me.chkSubTitles)
        Me.GroupControl2.Controls.Add(Me.chkLanguages)
        Me.GroupControl2.Name = "GroupControl2"
        Me.HelpProvider1.SetShowHelp(Me.GroupControl2, CType(resources.GetObject("GroupControl2.ShowHelp"), Boolean))
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
        'frmOrders_Browse
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmOrders_Browse"
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
        CType(Me.chkSubTitles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLanguages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtDateTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip


        txtDateFrom.EditValue = Today
        txtDateFrom.EditValue = CDate(txtDateFrom.EditValue).AddDays(-7)
        objDS = New dsPur_Sls
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "View_Orders_Ana"
        MyBase.IDField = "Products_ID"
        MyBase.NameField = "Products_Model"
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

        'Updating Feesharing_end = 0000-00-00 00:00:00 to 1801-01-01 00:00:00
        _SQLTxt = "Update products Set Feesharing_end = NULL where Feesharing_End = '0000-00-00 00:00:00'"
        lbl1.Text = "updating : " & DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        _SQLTxt = "Update products Set Products_Sale_Date = NULL where Products_Sale_Date = '0000-00-00 00:00:00'"
        lbl1.Text = "updating : " & DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)

        'Products
        _SQLTxt = " SELECT     p.*, op.orders_products_id, op.orders_id, op.products_model AS op_products_model, op.products_name, op.products_price AS op_products_price,  " & _
                  "    op.final_price, op.products_tax, op.products_quantity AS op_products_qty, op.products_dvd, op.orders_products_status, o.customers_id,  " & _
                  "    o.customers_name, o.customers_street_address, o.customers_suburb, o.customers_city, o.customers_postcode, o.customers_state,  " & _
                  "    o.customers_country, o.customers_telephone, o.customers_email_address, o.customers_address_format_id, o.delivery_name,  " & _
                  "    o.delivery_street_address, o.delivery_suburb, o.delivery_city, o.delivery_postcode, o.delivery_state, o.delivery_country,  " & _
                  "    o.delivery_address_format_id, o.payment_method, o.cc_type, o.cc_owner, o.cc_number, o.cc_expires, o.last_modified, o.date_purchased,  " & _
                  "    o.orders_status, o.orders_date_finished, o.comments, o.currency, o.currency_value, o.site, o.secured_mail, o.multishipment_sm,  " & _
                  "    studio.studio_name, c.customers_language as customers_lang_id,pa.qty_credit,pa.qty_at_home,if(ch.quantity_paid < 0,1,0) paidCust " & _
            " FROM         orders o " & _
            " LEFT JOIN credit_history ch on o.orders_id = ch.orders_id " & _
            " LEFT OUTER JOIN customers c ON o.customers_id = c.customers_id " & _
            " LEFT OUTER JOIN products_abo pa ON c.customers_abo_type = pa.products_id " & _
            " LEFT OUTER JOIN orders_products op ON o.orders_id = op.orders_id " & _
            " left OUTER JOIN  products p ON op.products_id = p.products_id " & _
            " LEFT OUTER JOIN  studio ON p.products_studio = studio.studio_id " & _
            " WHERE o.orders_status <> 9  " & _
            " AND o.date_purchased >= '" & txtDateFrom.DateTime.Year & "-" & txtDateFrom.DateTime.Month & "-" & txtDateFrom.DateTime.Day & " 00:00:00' " & _
            " AND o.date_purchased <= '" & txtDateTo.DateTime.Year & "-" & txtDateTo.DateTime.Month & "-" & txtDateTo.DateTime.Day & " 23:59:59' " & _
            " AND p.products_id > 50 "

        'SELECT *
        'FROM Orders_Products OP
        'LEFT JOIN PRODUCTS P ON P.Products_ID = OP.Products_ID
        'LEFT JOIN Orders O on O.Orders_ID = OP.Orders_ID
        'WHERE OP.Products_ID > 50
        'Limit 0, 500


        BKFilter.ApplyFilter(_SQLTxt, IsFiltered, CurrentFilterID, " ", StatusBar1.Panels(1))
        DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)

        'Dim dt As DataTable
        'dt = DvdPostData.clsConnection.FillDataSet(_SQLTxt)

        'Grid1.DataSource = dt

        'UcPivotGrid1.PivotGrid1.DataSource = dt

        MergeProductInfo()

        Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = objDS.Tables(TableName).DefaultView '_View 
        TabControl1.SelectedTabPage = TabResult
    End Sub
    Public Sub MergeProductInfo()
        Dim _row As DataRow
        Dim _view As DataView
        Dim _row2 As DataRowView
        Dim _SqlTxt As String
        Dim _tmpDS As New dsPur_Sls
        If chkLanguages.Checked = False And chkSubTitles.Checked = False Then Exit Sub
        lbl1.Text = "Merging DVD Info"
        lbl1.Refresh()
        ProgressBar1.Properties.Minimum = 0
        ProgressBar1.Properties.Maximum = objDS.Tables(TableName).Rows.Count
        ProgressBar1.EditValue = 0
        If chkSubTitles.Checked Then
            _SqlTxt = "SELECT p.products_id, undertitles_id, language_id, undertitles_description as description " & _
                      " FROM products_to_undertitles p left join products_undertitles u " & _
                      "on p.products_undertitles_id = u.undertitles_id WHERe u.language_id = 3"
            DvdPostData.clsConnection.FillDataSet(_tmpDS.Tables("products_undertitles_View1"), _SqlTxt)
        End If
        If chkLanguages.Checked Then
            _SqlTxt = "SELECT p.products_id, languages_id, languagenav_id, languages_description as description " & _
                    " FROM products_to_languages p " & _
                    "left join products_languages l on p.products_languages_id = l.languages_id " & _
                    "WHERe l.languagenav_id = 3"
            DvdPostData.clsConnection.FillDataSet(_tmpDS.Tables("products_languages_View1"), _SqlTxt)
        End If
        For Each _row In objDS.Tables(TableName).Rows
            ProgressBar1.EditValue += 1
            ProgressBar1.Refresh()
            '_row2 = _tmpDS.Tables("products_undertitles_View1").Rows.Find(New Object() {_row("Product_ID")})
            'Adding SubTitles Info
            If chkSubTitles.Checked Then
                _view = New DataView(_tmpDS.Tables("products_undertitles_View1"), "Products_Id = " & _row("Products_ID"), "", DataViewRowState.CurrentRows)
                For Each _row2 In _view
                    _row.BeginEdit()
                    _row("SubTitles") += _row2("Description") + " , "
                    _row.EndEdit()
                Next
            End If
            'Adding Languages Info
            If chkLanguages.Checked Then
                _view = New DataView(_tmpDS.Tables("products_languages_View1"), "Products_Id = " & _row("Products_ID"), "", DataViewRowState.CurrentRows)
                For Each _row2 In _view
                    _row.BeginEdit()
                    _row("Languages") += _row2("Description") + " , "
                    _row.EndEdit()
                Next
            End If
        Next
        ProgressBar1.EditValue = 0
    End Sub

    Private Sub txtLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimit.TextChanged
        _Limit = "limit 0, " & txtLimit.Text
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub
End Class
