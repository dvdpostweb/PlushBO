Public Class frmDiscount_Browse
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiscount_Browse))
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
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'frmDiscount_Browse
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmDiscount_Browse"
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
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objDS = New dsPur_Sls
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "View_Discount_Ana1"
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

        '_SQLTxt = " SELECT d.discount_code_id , d.discount_code, d.discount_type, d.discount_value, d.discount_limit, d.discount_commitment,  " & _
        '"                      d.discount_status, d.discount_text_fr, d.discount_text_nl, d.discount_text_en, d.discount_abo_validityto_type, d.discount_abo_validityto_value,  " & _
        '"                      d.comment, d.discount_nbr_month_before_reuse, d.discount_recurring_nbr_of_month, d.bypass_discountuse, IF(d.discount_validityto = '0000-00-00', NULL, d.discount_validityto) as discount_validityto , d.payable   FROM discount_code d"

        _SQLTxt = _
        "SELECT     du.discount_use_id, if(du.discount_use_date = '0000-00-00', NULL, du.discount_use_date) as discount_use_date, du.customers_id, dt.discount_explained, c.customers_gender, c.customers_firstname,  " & _
        "                      c.customers_lastname, if(c.customers_dob = '0000-00-00', Null, c.customers_dob) as customers_dob, c.customers_email_address, c.customers_default_address_id, c.customers_telephone,  " & _
        "                      c.customers_telephone_evening, c.customers_fax, c.customers_password, c.customers_newsletter, c.customers_newsletterpartner,  " & _
        "                      c.customers_privilege, c.customers_privilege_balance, c.customers_garantie, c.sponsoring_code, c.sponsored_code, c.customers_abo,  " & _
        "                      c.customers_abo_suspended, c.customers_abo_type, c.flagminiat1995, c.customers_abo_method, c.customers_abo_dvd_norm,  " & _
        "                      c.customers_abo_dvd_adult, c.customers_abo_dvd_home_norm, c.customers_abo_dvd_home_adult, c.throttling, if(c.customers_abo_validityto = '0000-00-00', Null, c.customers_abo_validityto) as customers_abo_validityto,  " & _
        "                      c.customers_abo_rank, c.customers_abo_start_rentthismonth, c.customers_abo_dvd_credit, c.customers_abo_multishipment,  " & _
        "                      if (c.customers_abo_discount_recurring_to_date = '0000-00-00', Null, c.customers_abo_discount_recurring_to_date) as customers_abo_discount_recurring_to_date, c.abotested, c.customers_abo_status, c.customers_abo_payment_method, c.domiciliation_status,  " & _
        "                      c.domiciliation_debiter_name, c.domiciliation_number, c.domiciliation_account_number, c.adult_pwd, c.ogone_card_type, c.ogone_card_no,  " & _
        "                      c.ogone_exp_date, c.ogone_owner, c.ogone_cc_expiration_status, c.offline_payment_status, c.comment AS Expr1, c.vip, c.black_listed, c.red_listed, " & _
        "                      c.sm_eligible, c.customers_enquiry_id, If (c.date_first_delivery = '0000-00-00', Null, c.date_first_delivery) as date_first_delivery, if ( c.mail_wl_adult_not_sufficient = '0000-00-00', Null, c.mail_wl_adult_not_sufficient) as mail_wl_adult_not_sufficient, " & _
        "                      if ( c.mail_wl_norm_not_sufficient = '0000-00-00', Null, c.mail_wl_norm_not_sufficient) as mail_wl_norm_not_sufficient , c.mgm_points,  " & _
        "                      c.wishlist_kind, d.discount_code_id AS Expr2, d.discount_code, d.discount_type, d.discount_value, d.discount_limit, d.discount_commitment,  " & _
        "                      d.discount_status, d.discount_text_fr, d.discount_text_nl, d.discount_text_en, d.discount_abo_validityto_type, d.discount_abo_validityto_value,  " & _
        "                      d.comment, d.discount_nbr_month_before_reuse, d.discount_recurring_nbr_of_month, d.bypass_discountuse, IF(d.discount_validityto = '0000-00-00', NULL, d.discount_validityto) as discount_validityto, d.payable " & _
        " FROM         discount_code d LEFT OUTER JOIN " & _
        "                      discount_use du ON d.discount_code_id = du.discount_code_id LEFT OUTER JOIN " & _
        "                      discount_type dt ON d.discount_type = dt.discount_type LEFT OUTER JOIN " & _
        "                      customers c ON c.customers_id = du.customers_id " & _Limit

        BKFilter.ApplyFilter(_SQLTxt, IsFiltered, CurrentFilterID, " ", StatusBar1.Panels(1))
        DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)


        'Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        'Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = objDS.Tables(TableName).DefaultView '_View 
        TabControl1.SelectedTabPage = TabResult
    End Sub

    Private Sub txtLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimit.TextChanged
        _Limit = "limit 0, " & txtLimit.Text
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub
End Class
