
Public Class frmAbo_Browse
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkABOCreateDate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPreviousAvtion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkWishListSize As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPreviousDiscount As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LMailId As System.Windows.Forms.Label
    Friend WithEvents txtActionList As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblActionID As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TBMailId As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbo_Browse))
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLimit = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lblActionID = New DevExpress.XtraEditors.MemoEdit
        Me.txtActionList = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TBMailId = New System.Windows.Forms.TextBox
        Me.LMailId = New System.Windows.Forms.Label
        Me.chkPreviousDiscount = New DevExpress.XtraEditors.CheckEdit
        Me.chkWishListSize = New DevExpress.XtraEditors.CheckEdit
        Me.chkPreviousAvtion = New DevExpress.XtraEditors.CheckEdit
        Me.chkABOCreateDate = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
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
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.lblActionID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPreviousDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkWishListSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPreviousAvtion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkABOCreateDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabParameters.Controls.Add(Me.Label6)
        Me.TabParameters.Controls.Add(Me.txtLimit)
        Me.TabParameters.Controls.Add(Me.ProgressBar1)
        Me.TabParameters.Controls.Add(Me.GroupControl1)
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
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.lblActionID)
        Me.GroupControl1.Controls.Add(Me.txtActionList)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.TBMailId)
        Me.GroupControl1.Controls.Add(Me.LMailId)
        Me.GroupControl1.Controls.Add(Me.chkPreviousDiscount)
        Me.GroupControl1.Controls.Add(Me.chkWishListSize)
        Me.GroupControl1.Controls.Add(Me.chkPreviousAvtion)
        Me.GroupControl1.Controls.Add(Me.chkABOCreateDate)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtToDate)
        Me.GroupControl1.Controls.Add(Me.txtFromDate)
        Me.GroupControl1.Name = "GroupControl1"
        Me.HelpProvider1.SetShowHelp(Me.GroupControl1, CType(resources.GetObject("GroupControl1.ShowHelp"), Boolean))
        '
        'lblActionID
        '
        resources.ApplyResources(Me.lblActionID, "lblActionID")
        Me.lblActionID.Name = "lblActionID"
        Me.lblActionID.Properties.ReadOnly = True
        '
        'txtActionList
        '
        resources.ApplyResources(Me.txtActionList, "txtActionList")
        Me.txtActionList.Name = "txtActionList"
        Me.HelpProvider1.SetShowHelp(Me.txtActionList, CType(resources.GetObject("txtActionList.ShowHelp"), Boolean))
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        Me.HelpProvider1.SetShowHelp(Me.Label1, CType(resources.GetObject("Label1.ShowHelp"), Boolean))
        '
        'TBMailId
        '
        resources.ApplyResources(Me.TBMailId, "TBMailId")
        Me.TBMailId.Name = "TBMailId"
        Me.HelpProvider1.SetShowHelp(Me.TBMailId, CType(resources.GetObject("TBMailId.ShowHelp"), Boolean))
        '
        'LMailId
        '
        resources.ApplyResources(Me.LMailId, "LMailId")
        Me.LMailId.Name = "LMailId"
        Me.HelpProvider1.SetShowHelp(Me.LMailId, CType(resources.GetObject("LMailId.ShowHelp"), Boolean))
        '
        'chkPreviousDiscount
        '
        resources.ApplyResources(Me.chkPreviousDiscount, "chkPreviousDiscount")
        Me.chkPreviousDiscount.Name = "chkPreviousDiscount"
        Me.chkPreviousDiscount.Properties.Caption = resources.GetString("chkPreviousDiscount.Properties.Caption")
        Me.chkPreviousDiscount.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.HelpProvider1.SetShowHelp(Me.chkPreviousDiscount, CType(resources.GetObject("chkPreviousDiscount.ShowHelp"), Boolean))
        '
        'chkWishListSize
        '
        resources.ApplyResources(Me.chkWishListSize, "chkWishListSize")
        Me.chkWishListSize.Name = "chkWishListSize"
        Me.chkWishListSize.Properties.Caption = resources.GetString("chkWishListSize.Properties.Caption")
        Me.chkWishListSize.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.HelpProvider1.SetShowHelp(Me.chkWishListSize, CType(resources.GetObject("chkWishListSize.ShowHelp"), Boolean))
        '
        'chkPreviousAvtion
        '
        resources.ApplyResources(Me.chkPreviousAvtion, "chkPreviousAvtion")
        Me.chkPreviousAvtion.Name = "chkPreviousAvtion"
        Me.chkPreviousAvtion.Properties.Caption = resources.GetString("chkPreviousAvtion.Properties.Caption")
        Me.chkPreviousAvtion.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.HelpProvider1.SetShowHelp(Me.chkPreviousAvtion, CType(resources.GetObject("chkPreviousAvtion.ShowHelp"), Boolean))
        '
        'chkABOCreateDate
        '
        resources.ApplyResources(Me.chkABOCreateDate, "chkABOCreateDate")
        Me.chkABOCreateDate.Name = "chkABOCreateDate"
        Me.chkABOCreateDate.Properties.Caption = resources.GetString("chkABOCreateDate.Properties.Caption")
        Me.chkABOCreateDate.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.HelpProvider1.SetShowHelp(Me.chkABOCreateDate, CType(resources.GetObject("chkABOCreateDate.ShowHelp"), Boolean))
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
        'lbl1
        '
        resources.ApplyResources(Me.lbl1, "lbl1")
        Me.lbl1.Name = "lbl1"
        Me.HelpProvider1.SetShowHelp(Me.lbl1, CType(resources.GetObject("lbl1.ShowHelp"), Boolean))
        '
        'frmAbo_Browse
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmAbo_Browse"
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
        CType(Me.lblActionID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPreviousDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkWishListSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPreviousAvtion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkABOCreateDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        Me.Misc_Bar.Visible = True
        objDS = New dsAboRent
        TabParameters.PageVisible = True
        LoadActionID()
        CanNew = False
        CanEdit = False
        MyBase.TableName = "Abo_View1"
        MyBase.IDField = "abo_id"
        MyBase.NameField = "abo_id"
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
    Private Sub txtLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimit.TextChanged
        _Limit = "limit 0, " & txtLimit.Text
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub

    Public Overrides Sub LoadDataSet()

        Dim _SQLTxt As String
        Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue) & " 00:00:00"
        Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue) & " 23:59:59"
        'Clear Table
        objDS.Tables(TableName).Clear()
        objDS.EnforceConstraints = False
        _SQLTxt = _
            "SELECT " & _
            " a.`abo_id`, a.`customerid`, a.`Action`, a.`code_id`, if(a.`Date`= '0000-00-00', Null, a.Date) as abo_date , a.`product_id`, a.`payment_method`, a.`privilege_notified`, a.`comment`, a.`site`, " & _
            " c.`customers_id`, c.`customers_gender`, c.`customers_firstname`, c.`customers_lastname`,ad.`entry_street_address`,ad.`entry_postcode`,ad.`entry_city`, if(c.`customers_dob` = '0000-00-00', Null, c.`customers_dob`) as customers_dob, c.`customers_email_address`, " & _
            " c.`customers_default_address_id`, c.`customers_telephone`, c.`customers_telephone_evening`, c.`customers_fax`, c.`customers_password`, " & _
            " c.`customers_newsletter`, c.`customers_newsletterpartner`, c.`customers_privilege`, c.`customers_privilege_balance`, c.`customers_garantie`, " & _
            " c.`sponsoring_code`, c.`sponsored_code`, c.`customers_abo`, c.`customers_abo_suspended`, c.`customers_abo_type`, c.`flagminiat1995`, " & _
            " c.`customers_abo_method`, c.`customers_abo_dvd_norm`, c.`customers_abo_dvd_adult`, c.`customers_abo_dvd_home_norm`, " & _
            " c.`customers_abo_dvd_home_adult`, c.`throttling`, c.customers_language, " & _
            " if(c.`customers_abo_validityto` = '0000-00-00', Null, c.`customers_abo_validityto`) as customers_abo_validityto, " & _
            " c.`customers_abo_rank`, c.`customers_abo_start_rentthismonth`, c.`customers_abo_dvd_credit`, c.`customers_abo_multishipment`, if(c.`customers_abo_discount_recurring_to_date` = '0000-00-00', Null, c.`customers_abo_discount_recurring_to_date`) as customers_abo_discount_recurring_to_date, " & _
            " c.`abotested`, c.`customers_abo_status`, c.`customers_abo_payment_method`, c.`domiciliation_status`, c.`domiciliation_debiter_name`, c.`domiciliation_number`, c.`domiciliation_account_number`, c.`adult_pwd`, c.`ogone_card_type`, c.`ogone_card_no`, c.`ogone_exp_date`, c.`ogone_owner`, c.`ogone_cc_expiration_status`, c.`offline_payment_status`, c.`comment`, c.`vip`, c.`black_listed`, c.`red_listed`, c.`sm_eligible`, c.`customers_enquiry_id`, if(c.`date_first_delivery` = '0000-00-00', Null, c.`date_first_delivery`) as date_first_delivery, " & _
            " if(c.`mail_wl_adult_not_sufficient` = '0000-00-00', Null, c.`mail_wl_adult_not_sufficient`) as mail_wl_adult_not_sufficient, if(c.`mail_wl_norm_not_sufficient` = '0000-00-00', Null, c.`mail_wl_norm_not_sufficient`) as mail_wl_norm_not_sufficient, c.`mgm_points`, c.`wishlist_kind`, " & _
            " p.`products_id`, p.`products_quantity`, p.`products_model`, p.`imdb_id`, p.`products_title`, p.`products_image`, p.`products_price`, " & _
            " if(p.`products_date_added` = '0000-00-00', Null, p.`products_date_added`) as products_date_added , if(p.`products_last_modified` = '0000-00-00', Null, p.`products_last_modified`) as products_last_modified, if(p.`products_date_available` = '0000-00-00', Null, p.`products_date_available`) as products_date_available, p.`products_weight`, p.`products_status`, p.`products_tax_class_id`, p.`manufacturers_id`, p.`products_ordered`, p.`products_public`, p.`products_runtime`, p.`products_year`, p.`products_countries_id`, p.`products_picture_format`, p.`products_rating`, p.`products_directors_id`, p.`products_regional_code`, p.`products_studio`, p.`products_barcode`, p.`products_dvd_quantity`, p.`products_language_fr`, p.`products_undertitle_nl`, p.`in_the_bags`, p.`in_the_bags_next`, p.`in_cinema_now`, p.`products_dvdpostchoice`, p.`products_other_language`, p.`products_french`, p.`products_next`, p.`products_tiscali_hp_fr`, p.`products_tiscali_hp_nl`, p.`products_series_id`, p.`products_series_number`, p.`products_series_aboprocess_id`, p.`products_series_aboprocess_number`, p.`cinebel_id`, p.`cinebel_trailer`, p.`feesharing`, " & _
            " if(p.`feesharing_end` = '0000-00-00', Null, p.`feesharing_end`) as feesharing_end, p.`feesharing_upfront_fee`, p.`feesharing_upfront_fee_recoverable`, p.`feesharing_turn_price`, p.`feesharing_turn_price_after3month`, p.`feesharing_buy_option_price`, p.`feesharing_expected_nbr_turns`, p.`products_desire`, p.`products_desire_weighted`, p.`products_availability`, p.`quantity_to_sale`, p.`products_sale_price`, " & _
            " if(p.`products_sale_date` = '0000-00-00', Null, p.`products_sale_date`) as products_sale_date, p.`products_type` , aa.id, aa.name, " & _
            " ac.activation_code, ac.comment as activation_cmt , " & _
            " dc.discount_code, dc.discount_text_en as discount_cmt1, dc.comment as discount_cmt2 , ag.activation_group_name , ac.campaign " & _
            " FROM `abo`  a left join abo_action aa on aa.id = a.action " & _
            " left join customers c on c.customers_id = a.customerid " & _
            " left join products p on p.products_id = a.product_id " & _
            " left join address_book ad on ad.customers_id=a.customerid" & _
            " left join activation_code ac on ac.activation_id = a.code_id AND a.action = 8 " & _
            " left join discount_code dc on dc.discount_code_id = a.code_id AND a.action = 6 " & _
            " left join activation_group ag on ac.activation_group = ag.activation_group_id " & _
            " where a.date >= '" & _DateFromTxt & "' and a.date <= '" & _DateToTxt & "' " & _
            " AND a.`Action` in (" & txtActionList.Text & ") and ad.address_book_id = c.customers_default_address_id"


        lbl1.Text = "Loading ABO Actions"
        DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)
        LoadAboCreationDate()
        LoadWishListSize()
        LoadPreviousAction()
        LoadPreviousDiscount()
        LoadMail()

        Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView


        TabControl1.SelectedTabPage = TabResult
    End Sub

    Public Sub LoadAboCreationDate()
        Dim _row As DataRow
        Dim _Curr_CustID As Integer = -1
        Dim _SQLTxt As String
        Dim _DS As New DataSet
        Dim _TxtTmp As String
        _DS.Tables.Add("abo")
        If chkABOCreateDate.Checked = True Then
            lbl1.Text = "Loading ABO Creation Date"
            lbl1.Refresh()
            ProgressBar1.Properties.Minimum = 1
            ProgressBar1.Properties.Maximum = objDS.Tables(TableName).Rows.Count
            ProgressBar1.EditValue = 1
            For Each _row In objDS.Tables(TableName).Rows
                ProgressBar1.EditValue += 1
                ProgressBar1.Refresh()
                'If _Curr_CustID <> _row("customers_id") Then
                If Not IsDBNull(_row("customers_id")) Then
                    _Curr_CustID = _row("customers_id")
                    _DS.Tables("abo").Clear()
                    _SQLTxt = "SELECT ´Date´ as CreationDate from abo where action in (1,5,6,8,9,10) and customerid = " & _row("customers_id") & _
                           "  and date < '" & Year(_row("abo_date")) & "-" & Month(_row("abo_date")) & "-" & Day(_row("abo_date")) & _
                           " " & Hour(_row("abo_date")) & ":" & Minute(_row("abo_date")) & ":" & Second(_row("abo_date")) & "' " & _
                           " order by Date desc limit 1"
                    _TxtTmp = BKGlobal.ExecuteFindFieldValue("CreationDate", _SQLTxt)
                    If IsDate(_TxtTmp) Then
                        _row("Abo_Creation_Date") = CDate(_TxtTmp)
                    Else
                        _row("Abo_Creation_Date") = _row("abo_date")
                    End If
                    'End If

                End If
            Next
        End If
    End Sub
    Public Sub LoadWishListSize()
        Dim _row As DataRow
        Dim _Curr_CustID As Integer = -1
        Dim _SQLTxt As String
        Dim _DS As New DataSet
        Dim _WishListSize As Integer
        _DS.Tables.Add("wl")
        If chkWishListSize.Checked = True Then
            lbl1.Text = "Loading ABO Wishlist Size"
            lbl1.Refresh()
            ProgressBar1.Properties.Minimum = 1
            ProgressBar1.Properties.Maximum = objDS.Tables(TableName).Rows.Count
            ProgressBar1.EditValue = 1
            For Each _row In objDS.Tables(TableName).Rows
                ProgressBar1.EditValue += 1
                ProgressBar1.Refresh()
                If Not IsDBNull(_row("customers_id")) Then
                    If _Curr_CustID <> _row("customers_id") Then
                        _Curr_CustID = _row("customers_id")
                        _DS.Tables("wl").Clear()
                        _SQLTxt = "SELECT count(*) as wl_count from wishlist where customers_id = " & _row("customers_id")
                        _WishListSize = CInt(BKGlobal.ExecuteFindFieldValue("wl_count", _SQLTxt))
                    End If
                    _row("WishList_Size") = _WishListSize
                End If
            Next
        End If
    End Sub
    Public Sub LoadPreviousAction()
        Dim _row As DataRow
        Dim _Curr_CustID As Integer = -1
        Dim _SQLTxt As String
        Dim _DS As New DataSet
        Dim _previous_action_id As Integer
        Dim _previous_action_name As String
        Dim _previous_action_activation_id As Integer
        Dim _previous_action_activation_group_id As Integer
        Dim _previous_action_activation_group_name As String
        Dim _previous_action_activation_type As String
        Dim _previous_action_date As DateTime

        _DS.Tables.Add("abo")
        If chkPreviousAvtion.Checked = True Then
            lbl1.Text = "Loading Previous ABO Action"
            lbl1.Refresh()
            ProgressBar1.Properties.Minimum = 1
            ProgressBar1.Properties.Maximum = objDS.Tables(TableName).Rows.Count
            ProgressBar1.EditValue = 1
            For Each _row In objDS.Tables(TableName).Rows
                ProgressBar1.EditValue += 1
                ProgressBar1.Refresh()
                If Not IsDBNull(_row("customers_id")) Then
                    'If _Curr_CustID <> _row("customers_id") Then
                    '_Curr_CustID = _row("customers_id")
                    _DS.Tables("abo").Clear()
                    _SQLTxt = "SELECT abo.`Date` as abo_date, abo.`action` as action_id , a.name as action_name, " & _
                         " ac.activation_id, ac.activation_group, ag.activation_group_name, " & _
                         " dc.discount_code_id, dc.discount_code " & _
                         " FROM abo " & _
                         " LEFT JOIN abo_action a on a.id = abo.action" & _
                         " LEFT JOIN activation_code ac on ac.activation_id = abo.code_id and abo.action = 8 " & _
                         " LEFT JOIN activation_group ag on ag.activation_group_id = ac.activation_group " & _
                         " LEFT JOIN discount_code dc on dc.discount_code_id = abo.code_id and abo.action = 6 " & _
                         " where customerid = " & _row("customers_id") & _
                         "  and `Date` < '" & Year(_row("abo_date")) & "-" & Month(_row("abo_date")) & "-" & Day(_row("abo_date")) & _
                         " " & Hour(_row("abo_date")) & ":" & Minute(_row("abo_date")) & ":" & Second(_row("abo_date")) & "' " & _
                         " AND abo.`Action` in (" & txtActionList.Text & ") " & _
                         " order by date desc limit 1 "
                    DvdPostData.clsConnection.FillDataSet(_DS.Tables("abo"), _SQLTxt)
                    If _DS.Tables("abo").Rows.Count = 1 Then
                        _previous_action_id = _DS.Tables("abo").Rows(0)("action_id")
                        _previous_action_name = _DS.Tables("abo").Rows(0)("action_name") & ""
                        _previous_action_date = _DS.Tables("abo").Rows(0)("abo_date") & ""
                        Select Case CInt(_DS.Tables("abo").Rows(0)("action_id"))
                            Case 6 'From Discount
                                _previous_action_activation_id = CInt("0" & _DS.Tables("abo").Rows(0)("discount_code_id"))
                                _previous_action_activation_group_id = CInt("0" & _DS.Tables("abo").Rows(0)("discount_code_id"))
                                _previous_action_activation_group_name = _DS.Tables("abo").Rows(0)("discount_code") & ""
                                _previous_action_activation_type = "D"
                            Case 8 'From Activation
                                _previous_action_activation_id = CInt("0" & _DS.Tables("abo").Rows(0)("activation_id"))
                                _previous_action_activation_group_id = CInt("0" & _DS.Tables("abo").Rows(0)("activation_group"))
                                _previous_action_activation_group_name = _DS.Tables("abo").Rows(0)("activation_group_name") & ""
                                _previous_action_activation_type = "A"
                            Case Else
                                _previous_action_activation_id = 0
                                _previous_action_activation_group_id = 0
                                _previous_action_activation_group_name = ""
                                _previous_action_activation_type = ""
                        End Select
                    Else
                        _previous_action_id = 0
                        _previous_action_name = ""
                        _previous_action_activation_id = 0
                        _previous_action_activation_group_id = 0
                        _previous_action_activation_group_name = ""
                        _previous_action_activation_type = ""
                        _previous_action_date = Nothing
                    End If
                    'End If
                    _row("Previous_Action_ID") = _previous_action_id
                    _row("Previous_Action_Name") = _previous_action_name
                    _row("Previous_Action_Activation_Type") = _previous_action_activation_type
                    _row("Previous_Action_Activation_ID") = _previous_action_activation_id
                    _row("Previous_Action_Activation_group_id") = _previous_action_activation_group_id
                    _row("Previous_Action_Activation_group_name") = _previous_action_activation_group_name
                    _row("Previous_Action_date") = _previous_action_date
                End If
            Next
        End If
    End Sub

    Public Sub LoadPreviousDiscount()
        Dim _row As DataRow
        Dim _Curr_CustID As Integer = -1
        Dim _SQLTxt As String
        Dim _DS As New DataSet
        Dim _previous_Discount_id As Integer
        Dim _previous_Discount_name As String
        _DS.Tables.Add("Discount_use")

        If chkPreviousDiscount.Checked = True Then
            lbl1.Text = "Loading Previous ABO Discount"
            lbl1.Refresh()
            ProgressBar1.Properties.Minimum = 1
            ProgressBar1.Properties.Maximum = objDS.Tables(TableName).Rows.Count
            ProgressBar1.EditValue = 1
            For Each _row In objDS.Tables(TableName).Rows
                ProgressBar1.EditValue += 1
                ProgressBar1.Refresh()
                If Not IsDBNull(_row("customers_id")) Then
                    'If _Curr_CustID <> _row("customers_id") Then
                    '_Curr_CustID = _row("customers_id")
                    _DS.Tables("Discount_use").Clear()
                    _SQLTxt = "SELECT d.discount_code_ID as discount_code_ID, d.discount_code as discount_name from discount_use du" & _
                         " inner join discount_code d on du.discount_code_ID = d.discount_code_ID" & _
                         " where du.customers_id = " & _row("customers_id") & _
                         "  and discount_use_date < '" & Year(_row("abo_date")) & "-" & Month(_row("abo_date")) & "-" & Day(_row("abo_date")) & _
                         " " & Hour(_row("abo_date")) & ":" & Minute(_row("abo_date")) & ":" & Second(_row("abo_date")) & _
                         "' order by discount_use_date desc limit 1 "

                    If IsDBNull(_row("customers_id")) Then
                        MsgBox(_row("abo_id") & "-" & _row("customers_firstname") & "-" & _row("customers_lastname") & "-" & _row("customers_email_address") & "-" & _SQLTxt)
                    End If

                    DvdPostData.clsConnection.FillDataSet(_DS.Tables("Discount_use"), _SQLTxt)
                    If _DS.Tables("Discount_use").Rows.Count = 1 Then
                        _previous_Discount_id = _DS.Tables("Discount_use").Rows(0)("discount_code_ID")
                        _previous_Discount_name = _DS.Tables("Discount_use").Rows(0)("discount_name")
                    Else
                        _previous_Discount_id = 0
                        _previous_Discount_name = ""
                    End If
                    'End If
                    _row("Previous_Discount_ID") = _previous_Discount_id
                    _row("Previous_Discount_Name") = _previous_Discount_name
                End If
            Next
        End If
    End Sub

    Public Sub LoadMail()

        Dim _row As DataRow
        Dim _Curr_CustID As Integer = -1
        Dim _SQLTxt As String
        Dim _DS As New DataSet
        _DS.Tables.Add("MailSent")

        If TBMailId.Text <> "" Then
            lbl1.Text = "Loading Mail Sent"
            lbl1.Refresh()
            ProgressBar1.Properties.Minimum = 1
            ProgressBar1.Properties.Maximum = objDS.Tables(TableName).Rows.Count
            ProgressBar1.EditValue = 1
            For Each _row In objDS.Tables(TableName).Rows
                ProgressBar1.EditValue += 1
                ProgressBar1.Refresh()
                If Not IsDBNull(_row("customers_id")) Then
                    'If _Curr_CustID <> _row("customers_id") Then
                    '_Curr_CustID = _row("customers_id")
                    _DS.Tables("MailSent").Clear()
                    _SQLTxt = "SELECT * from mail_messages_sent_history where customers_id = " & _row("customers_id") & " and mail_messages_id in (" & TBMailId.Text & ")"
                    DvdPostData.clsConnection.FillDataSet(_DS.Tables("MailSent"), _SQLTxt)
                    If _DS.Tables("MailSent").Rows.Count > 0 Then
                        _row("Mail_Sent") = 1
                    Else
                        _row("Mail_Sent") = 0
                    End If
                End If
            Next
        End If
    End Sub

    Public Sub LoadActionID()
        Dim _DS As New DataSet
        _DS.Tables.Add("abo_action")
        Dim _SQLTXt As String = "SELECT * FROM abo_action"
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("abo_action"), _SQLTXt)
        Dim _Row As DataRow
        lblActionID.Text = ""
        For Each _Row In _DS.Tables("abo_action").Rows
            lblActionID.Text = lblActionID.Text & _Row("id").ToString & " - " & _Row("name") & vbCrLf
        Next

    End Sub


    Private Sub UcPivotGrid1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPivotGrid1.Load

    End Sub
End Class
