Public Class frmABOReconduction_Browse
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
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLimit As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtMonth As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtYear As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABOReconduction_Browse))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtMonth = New DevExpress.XtraEditors.TextEdit
        Me.txtYear = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLimit = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.lbl1 = New System.Windows.Forms.Label
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
        CType(Me.txtMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TabParameters.Controls.Add(Me.Label6)
        Me.TabParameters.Controls.Add(Me.txtLimit)
        Me.TabParameters.Controls.Add(Me.ProgressBar1)
        Me.TabParameters.Controls.Add(Me.lbl1)
        Me.TabParameters.Controls.Add(Me.txtYear)
        Me.TabParameters.Controls.Add(Me.LabelControl4)
        Me.TabParameters.Controls.Add(Me.txtMonth)
        Me.TabParameters.Controls.Add(Me.LabelControl1)
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
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, CType(resources.GetObject("LabelControl1.ShowHelp"), Boolean))
        '
        'txtMonth
        '
        resources.ApplyResources(Me.txtMonth, "txtMonth")
        Me.txtMonth.Name = "txtMonth"
        Me.HelpProvider1.SetShowHelp(Me.txtMonth, CType(resources.GetObject("txtMonth.ShowHelp"), Boolean))
        '
        'txtYear
        '
        resources.ApplyResources(Me.txtYear, "txtYear")
        Me.txtYear.Name = "txtYear"
        Me.HelpProvider1.SetShowHelp(Me.txtYear, CType(resources.GetObject("txtYear.ShowHelp"), Boolean))
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl4, CType(resources.GetObject("LabelControl4.ShowHelp"), Boolean))
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
        'frmABOReconduction_Browse
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmABOReconduction_Browse"
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
        CType(Me.txtMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "
    Dim CustView As DataView

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        objDS = New dsAboRent
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "AboReconduction_View1"
        MyBase.IDField = "abo_id"
        MyBase.NameField = "abo_id"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = False
        MyBase.StartUp()
        CustView = New DataView(objDS.Tables(TableName), "", "customers_id", DataViewRowState.CurrentRows)
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
    Private Sub txtLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimit.TextChanged
        _Limit = "limit 0, " & txtLimit.Text
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub

    Public Overrides Sub LoadDataSet()
        Dim _SQLTxt As String
        Dim _DateFromTxt As String
        Dim _DateToTxt As String
        Dim _Date As Date
        Dim _DS1 As New dsAboRent
        Dim _i As Integer = 0
        _DS1.Tables.Add("abo_tmp")

        For _i = 0 To 2
            _Date = New Date(txtYear.EditValue, txtMonth.EditValue + _i, 1)
            _DateFromTxt = _Date.Year & "-" & _Date.Month & "-" & _Date.Day
            _Date = DateAdd(DateInterval.Month, 1, _Date)
            _DateToTxt = _Date.Year & "-" & _Date.Month & "-" & _Date.Day
            _SQLTxt = "SELECT a.abo_id, a.customerid as customers_id, 1 as Month1, DAYOFMONTH(a.date) as DOfM, payment_method, op.amount as ogamount, dp.amount as domamount" & _
            " FROM `abo`  a left join ogone_payment op on op.abo_id = a.abo_id" & _
            " left join domiciliation_payment dp on dp.abo_id = a.abo_id" & _
            " where a.date >= '" & _
             _DateFromTxt & " ' and a.date <= '" & _DateToTxt & "' and action = 7 "
            '"SELECT " & _
            '" a.`abo_id`, a.`customerid`, a.`Action`, a.`code_id`, if(a.`Date`= '0000-00-00', Null, a.Date) as abo_date , a.`product_id`, a.`payment_method`, a.`privilege_notified`, a.`comment`, a.`site`, " & _
            '" c.`customers_id`, c.`customers_gender`, c.`customers_firstname`, c.`customers_lastname`, if(c.`customers_dob` = '0000-00-00', Null, c.`customers_dob`) as customers_dob, c.`customers_email_address`, " & _
            '" c.`customers_default_address_id`, c.`customers_telephone`, c.`customers_telephone_evening`, c.`customers_fax`, c.`customers_password`, " & _
            '" c.`customers_newsletter`, c.`customers_newsletterpartner`, c.`customers_privilege`, c.`customers_privilege_balance`, c.`customers_garantie`, " & _
            '" c.`sponsoring_code`, c.`sponsored_code`, c.`customers_abo`, c.`customers_abo_suspended`, c.`customers_abo_type`, c.`flagminiat1995`, " & _
            '" c.`customers_abo_method`, c.`customers_abo_dvd_norm`, c.`customers_abo_dvd_adult`, c.`customers_abo_dvd_home_norm`, " & _
            '" c.`customers_abo_dvd_home_adult`, c.`throttling`, " & _
            '" if(c.`customers_abo_validityto` = '0000-00-00', Null, c.`customers_abo_validityto`) as customers_abo_validityto, " & _
            '" c.`customers_abo_rank`, c.`customers_abo_start_rentthismonth`, c.`customers_abo_dvd_credit`, c.`customers_abo_multishipment`, if(c.`customers_abo_discount_recurring_to_date` = '0000-00-00', Null, c.`customers_abo_discount_recurring_to_date`) as customers_abo_discount_recurring_to_date, " & _
            '" c.`abotested`, c.`customers_abo_status`, c.`customers_abo_payment_method`, c.`domiciliation_status`, c.`domiciliation_debiter_name`, c.`domiciliation_number`, c.`domiciliation_account_number`, c.`adult_pwd`, c.`ogone_card_type`, c.`ogone_card_no`, c.`ogone_exp_date`, c.`ogone_owner`, c.`ogone_cc_expiration_status`, c.`offline_payment_status`, c.`comment`, c.`vip`, c.`black_listed`, c.`red_listed`, c.`sm_eligible`, c.`customers_enquiry_id`, if(c.`date_first_delivery` = '0000-00-00', Null, c.`date_first_delivery`) as date_first_delivery, " & _
            '" if(c.`mail_wl_adult_not_sufficient` = '0000-00-00', Null, c.`mail_wl_adult_not_sufficient`) as mail_wl_adult_not_sufficient, if(c.`mail_wl_norm_not_sufficient` = '0000-00-00', Null, c.`mail_wl_norm_not_sufficient`) as mail_wl_norm_not_sufficient, c.`mgm_points`, c.`wishlist_kind`, " & _
            '" p.`products_id`, p.`products_quantity`, p.`products_model`, p.`imdb_id`, p.`products_title`, p.`products_image`, p.`products_price`, " & _
            '" if(p.`products_date_added` = '0000-00-00', Null, p.`products_date_added`) as products_date_added , if(p.`products_last_modified` = '0000-00-00', Null, p.`products_last_modified`) as products_last_modified, if(p.`products_date_available` = '0000-00-00', Null, p.`products_date_available`) as products_date_available, p.`products_weight`, p.`products_status`, p.`products_tax_class_id`, p.`manufacturers_id`, p.`products_ordered`, p.`products_public`, p.`products_runtime`, p.`products_year`, p.`products_countries_id`, p.`products_picture_format`, p.`products_rating`, p.`products_directors_id`, p.`products_regional_code`, p.`products_studio`, p.`products_barcode`, p.`products_dvd_quantity`, p.`products_language_fr`, p.`products_undertitle_nl`, p.`in_the_bags`, p.`in_the_bags_next`, p.`in_cinema_now`, p.`products_dvdpostchoice`, p.`products_other_language`, p.`products_french`, p.`products_next`, p.`products_tiscali_hp_fr`, p.`products_tiscali_hp_nl`, p.`products_series_id`, p.`products_series_number`, p.`products_series_aboprocess_id`, p.`products_series_aboprocess_number`, p.`cinebel_id`, p.`cinebel_trailer`, p.`feesharing`, " & _
            '" if(p.`feesharing_end` = '0000-00-00', Null, p.`feesharing_end`) as feesharing_end, p.`feesharing_upfront_fee`, p.`feesharing_upfront_fee_recoverable`, p.`feesharing_turn_price`, p.`feesharing_turn_price_after3month`, p.`feesharing_buy_option_price`, p.`feesharing_expected_nbr_turns`, p.`products_desire`, p.`products_desire_weighted`, p.`products_availability`, p.`quantity_to_sale`, p.`products_sale_price`, " & _
            '" if(p.`products_sale_date` = '0000-00-00', Null, p.`products_sale_date`) as products_sale_date, p.`products_type` , aa.id, aa.name, " & _
            '" ac.activation_code, ac.comment as activation_cmt, " & _
            '" dc.discount_code, dc.discount_text_en as discount_cmt1, dc.comment as discount_cmt2 " & _
            '" FROM `abo`  a left join abo_action aa on aa.id = a.action " & _
            '" left join customers c on c.customers_id = a.customerid " & _
            '" left join products p on p.products_id = a.product_id " & _
            '" left join activation_code ac on ac.activation_id = a.code_id AND a.action = 8 " & _
            '" left join discount_code dc on dc.discount_code_id = a.code_id AND a.action = 6 " & _
            '" where a.date >= '" & _DateFromTxt & "' and a.date <= '" & _DateToTxt & "'"

            lbl1.Text = "Loading ABO Actions Month 1"
            _DS1.Tables("abo_tmp").Clear()
            DvdPostData.clsConnection.FillDataSet(_DS1.Tables("abo_tmp"), _SQLTxt)
            MergingABOInfo(_DS1.Tables("abo_tmp"), _i + 1)
        Next
        'Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        'Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = CustView 'objDS.Tables(TableName).DefaultView
        TabControl1.SelectedTabPage = TabResult
    End Sub

    Private Sub MergingABOInfo(ByVal V_abo_Tmp_Table As DataTable, ByVal vMonth As Integer)
        Dim _row As DataRow
        Dim _row1 As DataRowView
        Dim _i As Integer
        For Each _row In V_abo_Tmp_Table.Rows
            _i = CustView.Find(_row("customers_id"))
            If _i = -1 Then
                _row1 = CustView.AddNew 'objDS.Tables(TableName).NewRow

                _row1("abo_id") = _row("abo_id")
                _row1("customers_id") = _row("customers_id")
                _row1("Month1") = 0
                _row1("Month2") = 0
                _row1("Month3") = 0
                _row1("Month12") = 0
                _row1("Month13") = 0
                _row1("Month23") = 0
                _row1("Month123") = 0
                _row1("DOfM1") = 0
                _row1("DOfM2") = 0
                _row1("DOfM3") = 0
                _row1("Ogone") = 0
                _row1("Dom") = 0
                _row1("Amount") = 0
                _row1.EndEdit()
                'objDS.Tables(TableName).Rows.Add(_row1)
            Else
                _row1 = CustView(_i)
                'Row Exist
            End If
            'Set the columns Values
            _row1.BeginEdit()
            _row1("Month" & vMonth.ToString) = 1

            'Mike
            _row1("DOfM" & vMonth.ToString) = _row("DOfM")
            If vMonth = 1 Then
                If _row("ogamount") Is DBNull.Value Then
                    _row1("amount") = _row("domamount")
                Else
                    _row1("amount") = _row("ogamount")
                End If
                If _row("payment_method") = "ogone" Then
                    _row1("Ogone") = 1
                Else
                    _row1("Ogone") = 0
                End If
                If _row("payment_method") = "dom" Then
                    _row1("Dom") = 1
                Else
                    _row1("Dom") = 0
                End If
            End If
            'fin Mike

            If _row1("Month1") = 1 And _row1("Month2") = 1 Then
                _row1("Month12") = 1
            End If
            If _row1("Month1") = 1 And _row1("Month3") = 1 Then
                _row1("Month13") = 1
            End If
            If _row1("Month2") = 1 And _row1("Month3") = 1 Then
                _row1("Month23") = 1
            End If
            If _row1("Month1") = 1 And _row1("Month2") = 1 And _row1("Month3") = 1 Then
                _row1("Month123") = 1
            End If
            _row1.EndEdit()
        Next
    End Sub

End Class
