<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiscountCode
    Inherits BizzLib.frmGeneral_Maintenance

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiscountCode))
        Me.GridViewShoppingDiscount = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridViewDiscount = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.discount_code_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.discount_code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.discount_validityto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.discount_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.discount_value = New DevExpress.XtraGrid.Columns.GridColumn
        Me.discount_limit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.discount_commitment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.discount_text_fr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.discount_text_nl = New DevExpress.XtraGrid.Columns.GridColumn
        Me.discount_text_en = New DevExpress.XtraGrid.Columns.GridColumn
        Me.discount_abo_validityto_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.discount_abo_validityto_value = New DevExpress.XtraGrid.Columns.GridColumn
        Me.comment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.discount_nbr_month_before_reuse = New DevExpress.XtraGrid.Columns.GridColumn
        Me.discount_recurring_nbr_of_month = New DevExpress.XtraGrid.Columns.GridColumn
        Me.abo_dvd_credit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.next_discount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.listing_products_allowed = New DevExpress.XtraGrid.Columns.GridColumn
        Me.goto_step = New DevExpress.XtraGrid.Columns.GridColumn
        Me.banner = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Footer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_group_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.shopping_discount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.droselia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.objDS = New PlushLib.dsMarketting
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabSearch = New System.Windows.Forms.TabPage
        Me.btnNewDiscountCode = New DevExpress.XtraEditors.SimpleButton
        Me.btnViewShoppingDiscount = New DevExpress.XtraEditors.SimpleButton
        Me.btnDiscountExp = New DevExpress.XtraEditors.SimpleButton
        Me.btnLoadAllDisc = New DevExpress.XtraEditors.SimpleButton
        Me.GroupSearch = New DevExpress.XtraEditors.GroupControl
        Me.btnXls = New DevExpress.XtraEditors.SimpleButton
        Me.cmbGroupIDsearch = New DevExpress.XtraEditors.LookUpEdit
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.lblDateValidityto = New DevExpress.XtraEditors.LabelControl
        Me.lblPartner = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.txtDiscountCodeSearch = New DevExpress.XtraEditors.TextEdit
        Me.lblDateValidityfrom = New DevExpress.XtraEditors.LabelControl
        Me.lblSearchDiscount = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.lblSearch = New DevExpress.XtraEditors.LabelControl
        Me.txtDiscountIdSearch = New DevExpress.XtraEditors.TextEdit
        Me.tabResult = New System.Windows.Forms.TabPage
        Me.tabDiscount = New System.Windows.Forms.TabPage
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.txtTVODFreeCredits = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.cmbDiscountAction = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckDebitCard = New DevExpress.XtraEditors.CheckEdit
        Me.CheckCreditCard = New DevExpress.XtraEditors.CheckEdit
        Me.CheckPaypal = New DevExpress.XtraEditors.CheckEdit
        Me.cmbNextAboType = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.cmbAboType = New DevExpress.XtraEditors.LookUpEdit
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaveDiscount = New DevExpress.XtraEditors.SimpleButton
        Me.btnEditDiscount = New DevExpress.XtraEditors.SimpleButton
        Me.btnNewDiscount = New DevExpress.XtraEditors.SimpleButton
        Me.txtGotToStep2 = New DevExpress.XtraEditors.SpinEdit
        Me.CheckDiscountStatus = New DevExpress.XtraEditors.CheckEdit
        Me.txtCommitment2 = New DevExpress.XtraEditors.SpinEdit
        Me.CheckFreeUpgradeAllowed = New DevExpress.XtraEditors.CheckEdit
        Me.txtValidityTo_Value2 = New DevExpress.XtraEditors.SpinEdit
        Me.CheckByPassDiscountUse = New DevExpress.XtraEditors.CheckEdit
        Me.CheckCreditZero_AutoReconduction = New DevExpress.XtraEditors.CheckEdit
        Me.CheckPayable = New DevExpress.XtraEditors.CheckEdit
        Me.CheckCAutoStop = New DevExpress.XtraEditors.CheckEdit
        Me.txtLimit2 = New DevExpress.XtraEditors.SpinEdit
        Me.txtDiscountValue2 = New DevExpress.XtraEditors.SpinEdit
        Me.txtNbrMonthReuse = New DevExpress.XtraEditors.SpinEdit
        Me.txtNbrRecuring2 = New DevExpress.XtraEditors.SpinEdit
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.CheckLandingPage = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtText_EN = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtText_NL = New DevExpress.XtraEditors.TextEdit
        Me.txtText_Fr = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
        Me.txtFooter = New DevExpress.XtraEditors.TextEdit
        Me.txtBanner = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.txtLandingPagePHP = New DevExpress.XtraEditors.TextEdit
        Me.txtValidityTo = New DevExpress.XtraEditors.DateEdit
        Me.txtNextDiscountCode = New DevExpress.XtraEditors.LookUpEdit
        Me.txtValidityTo_Type = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbDiscount_Type = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbGroup_Partner = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.lblAboType = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.txtComment = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtDiscount_Code = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.TabShoppingDiscount = New System.Windows.Forms.TabPage
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.CheckShoppingDiscountStatus = New DevExpress.XtraEditors.CheckEdit
        Me.btnShoppingUndo = New DevExpress.XtraEditors.SimpleButton
        Me.btnShoppingSave = New DevExpress.XtraEditors.SimpleButton
        Me.btnShoppingEdit = New DevExpress.XtraEditors.SimpleButton
        Me.btnShoppingNew = New DevExpress.XtraEditors.SimpleButton
        Me.SpinShoppingDiscountValue = New DevExpress.XtraEditors.SpinEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtShoppingDiscountEn = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.txtShoppingDiscountNl = New DevExpress.XtraEditors.TextEdit
        Me.txtShoppingDiscountFr = New DevExpress.XtraEditors.TextEdit
        Me.dateShoppingDiscountValidityTo = New DevExpress.XtraEditors.DateEdit
        Me.cmbShoppingDiscountType = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl
        Me.txtShoppingDiscount = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewShoppingDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabSearch.SuspendLayout()
        CType(Me.GroupSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupSearch.SuspendLayout()
        CType(Me.cmbGroupIDsearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscountCodeSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscountIdSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabResult.SuspendLayout()
        Me.tabDiscount.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTVODFreeCredits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDiscountAction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CheckDebitCard.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckCreditCard.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckPaypal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNextAboType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAboType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGotToStep2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckDiscountStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCommitment2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckFreeUpgradeAllowed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValidityTo_Value2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckByPassDiscountUse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckCreditZero_AutoReconduction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckPayable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckCAutoStop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLimit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscountValue2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNbrMonthReuse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNbrRecuring2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.CheckLandingPage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtText_EN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtText_NL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtText_Fr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFooter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBanner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLandingPagePHP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValidityTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValidityTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNextDiscountCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValidityTo_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDiscount_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGroup_Partner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabShoppingDiscount.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.CheckShoppingDiscountStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinShoppingDiscountValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtShoppingDiscountEn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShoppingDiscountNl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShoppingDiscountFr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateShoppingDiscountValidityTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateShoppingDiscountValidityTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbShoppingDiscountType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShoppingDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 686)
        Me.StatusBar1.Size = New System.Drawing.Size(1172, 22)
        '
        'GridViewShoppingDiscount
        '
        Me.GridViewShoppingDiscount.GridControl = Me.GridControl1
        Me.GridViewShoppingDiscount.Name = "GridViewShoppingDiscount"
        Me.GridViewShoppingDiscount.OptionsBehavior.Editable = False
        Me.GridViewShoppingDiscount.OptionsView.ShowFooter = True
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Enabled = False
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Enabled = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.FormsUseDefaultLookAndFeel = False
        GridLevelNode1.LevelTemplate = Me.GridViewShoppingDiscount
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(3, 3)
        Me.GridControl1.MainView = Me.GridViewDiscount
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1158, 585)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDiscount, Me.GridViewShoppingDiscount})
        '
        'GridViewDiscount
        '
        Me.GridViewDiscount.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.discount_code_id, Me.discount_code, Me.discount_validityto, Me.discount_type, Me.discount_value, Me.discount_limit, Me.discount_commitment, Me.discount_text_fr, Me.discount_text_nl, Me.discount_text_en, Me.discount_abo_validityto_type, Me.discount_abo_validityto_value, Me.comment, Me.discount_nbr_month_before_reuse, Me.discount_recurring_nbr_of_month, Me.abo_dvd_credit, Me.next_discount, Me.listing_products_allowed, Me.goto_step, Me.banner, Me.Footer, Me.activation_group_name, Me.shopping_discount, Me.droselia})
        Me.GridViewDiscount.GridControl = Me.GridControl1
        Me.GridViewDiscount.Name = "GridViewDiscount"
        Me.GridViewDiscount.OptionsBehavior.Editable = False
        Me.GridViewDiscount.OptionsView.ShowFooter = True
        '
        'discount_code_id
        '
        Me.discount_code_id.Caption = "discount_code_id"
        Me.discount_code_id.FieldName = "discount_code_id"
        Me.discount_code_id.Name = "discount_code_id"
        Me.discount_code_id.OptionsColumn.FixedWidth = True
        Me.discount_code_id.Visible = True
        Me.discount_code_id.VisibleIndex = 0
        Me.discount_code_id.Width = 102
        '
        'discount_code
        '
        Me.discount_code.Caption = "discount_code"
        Me.discount_code.FieldName = "discount_code"
        Me.discount_code.Name = "discount_code"
        Me.discount_code.OptionsColumn.FixedWidth = True
        Me.discount_code.Visible = True
        Me.discount_code.VisibleIndex = 1
        Me.discount_code.Width = 181
        '
        'discount_validityto
        '
        Me.discount_validityto.Caption = "discount_validityto"
        Me.discount_validityto.DisplayFormat.FormatString = "d"
        Me.discount_validityto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.discount_validityto.FieldName = "discount_validityto"
        Me.discount_validityto.Name = "discount_validityto"
        Me.discount_validityto.OptionsColumn.FixedWidth = True
        Me.discount_validityto.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.discount_validityto.Visible = True
        Me.discount_validityto.VisibleIndex = 3
        Me.discount_validityto.Width = 122
        '
        'discount_type
        '
        Me.discount_type.Caption = "discount_type"
        Me.discount_type.FieldName = "discount_type"
        Me.discount_type.Name = "discount_type"
        Me.discount_type.OptionsColumn.FixedWidth = True
        Me.discount_type.Width = 111
        '
        'discount_value
        '
        Me.discount_value.Caption = "discount_value"
        Me.discount_value.FieldName = "discount_value"
        Me.discount_value.Name = "discount_value"
        Me.discount_value.OptionsColumn.FixedWidth = True
        Me.discount_value.Width = 107
        '
        'discount_limit
        '
        Me.discount_limit.Caption = "discount_limit"
        Me.discount_limit.FieldName = "discount_limit"
        Me.discount_limit.Name = "discount_limit"
        Me.discount_limit.OptionsColumn.FixedWidth = True
        Me.discount_limit.Visible = True
        Me.discount_limit.VisibleIndex = 4
        Me.discount_limit.Width = 100
        '
        'discount_commitment
        '
        Me.discount_commitment.Caption = "discount_commitment"
        Me.discount_commitment.FieldName = "discount_commitment"
        Me.discount_commitment.Name = "discount_commitment"
        Me.discount_commitment.OptionsColumn.FixedWidth = True
        Me.discount_commitment.Width = 136
        '
        'discount_text_fr
        '
        Me.discount_text_fr.Caption = "discount_text_fr"
        Me.discount_text_fr.FieldName = "discount_text_fr"
        Me.discount_text_fr.Name = "discount_text_fr"
        Me.discount_text_fr.OptionsColumn.FixedWidth = True
        Me.discount_text_fr.Visible = True
        Me.discount_text_fr.VisibleIndex = 5
        Me.discount_text_fr.Width = 124
        '
        'discount_text_nl
        '
        Me.discount_text_nl.Caption = "discount_text_nl"
        Me.discount_text_nl.FieldName = "discount_text_nl"
        Me.discount_text_nl.Name = "discount_text_nl"
        Me.discount_text_nl.OptionsColumn.FixedWidth = True
        Me.discount_text_nl.Visible = True
        Me.discount_text_nl.VisibleIndex = 6
        Me.discount_text_nl.Width = 131
        '
        'discount_text_en
        '
        Me.discount_text_en.Caption = "discount_text_en"
        Me.discount_text_en.FieldName = "discount_text_en"
        Me.discount_text_en.Name = "discount_text_en"
        Me.discount_text_en.OptionsColumn.FixedWidth = True
        Me.discount_text_en.Visible = True
        Me.discount_text_en.VisibleIndex = 7
        Me.discount_text_en.Width = 89
        '
        'discount_abo_validityto_type
        '
        Me.discount_abo_validityto_type.Caption = "discount_abo_validityto_type"
        Me.discount_abo_validityto_type.FieldName = "discount_abo_validityto_type"
        Me.discount_abo_validityto_type.Name = "discount_abo_validityto_type"
        Me.discount_abo_validityto_type.OptionsColumn.FixedWidth = True
        Me.discount_abo_validityto_type.Width = 55
        '
        'discount_abo_validityto_value
        '
        Me.discount_abo_validityto_value.Caption = "discount_abo_validityto_value"
        Me.discount_abo_validityto_value.FieldName = "discount_abo_validityto_value"
        Me.discount_abo_validityto_value.Name = "discount_abo_validityto_value"
        Me.discount_abo_validityto_value.OptionsColumn.FixedWidth = True
        Me.discount_abo_validityto_value.Width = 59
        '
        'comment
        '
        Me.comment.Caption = "comment"
        Me.comment.FieldName = "comment"
        Me.comment.Name = "comment"
        Me.comment.OptionsColumn.FixedWidth = True
        Me.comment.Width = 21
        '
        'discount_nbr_month_before_reuse
        '
        Me.discount_nbr_month_before_reuse.Caption = "discount_nbr_month_before_reuse"
        Me.discount_nbr_month_before_reuse.FieldName = "discount_nbr_month_before_reuse"
        Me.discount_nbr_month_before_reuse.Name = "discount_nbr_month_before_reuse"
        Me.discount_nbr_month_before_reuse.OptionsColumn.FixedWidth = True
        '
        'discount_recurring_nbr_of_month
        '
        Me.discount_recurring_nbr_of_month.Caption = "discount_recurring_nbr_of_month"
        Me.discount_recurring_nbr_of_month.FieldName = "discount_recurring_nbr_of_month"
        Me.discount_recurring_nbr_of_month.Name = "discount_recurring_nbr_of_month"
        Me.discount_recurring_nbr_of_month.OptionsColumn.FixedWidth = True
        Me.discount_recurring_nbr_of_month.Width = 76
        '
        'abo_dvd_credit
        '
        Me.abo_dvd_credit.Caption = "abo_dvd_credit"
        Me.abo_dvd_credit.FieldName = "abo_dvd_credit"
        Me.abo_dvd_credit.Name = "abo_dvd_credit"
        Me.abo_dvd_credit.OptionsColumn.FixedWidth = True
        Me.abo_dvd_credit.Width = 37
        '
        'next_discount
        '
        Me.next_discount.Caption = "next_discount"
        Me.next_discount.FieldName = "next_discount"
        Me.next_discount.Name = "next_discount"
        Me.next_discount.OptionsColumn.FixedWidth = True
        Me.next_discount.Width = 45
        '
        'listing_products_allowed
        '
        Me.listing_products_allowed.Caption = "listing_products_allowed"
        Me.listing_products_allowed.FieldName = "listing_products_allowed"
        Me.listing_products_allowed.Name = "listing_products_allowed"
        Me.listing_products_allowed.OptionsColumn.FixedWidth = True
        Me.listing_products_allowed.Width = 68
        '
        'goto_step
        '
        Me.goto_step.Caption = "goto_step"
        Me.goto_step.FieldName = "goto_step"
        Me.goto_step.Name = "goto_step"
        Me.goto_step.OptionsColumn.FixedWidth = True
        Me.goto_step.Width = 27
        '
        'banner
        '
        Me.banner.Caption = "banner"
        Me.banner.FieldName = "banner"
        Me.banner.Name = "banner"
        Me.banner.OptionsColumn.FixedWidth = True
        Me.banner.Width = 20
        '
        'Footer
        '
        Me.Footer.Caption = "Footer"
        Me.Footer.FieldName = "Footer"
        Me.Footer.Name = "Footer"
        Me.Footer.OptionsColumn.FixedWidth = True
        Me.Footer.Width = 21
        '
        'activation_group_name
        '
        Me.activation_group_name.Caption = "partner_name"
        Me.activation_group_name.FieldName = "activation_group_name"
        Me.activation_group_name.Name = "activation_group_name"
        Me.activation_group_name.OptionsColumn.FixedWidth = True
        Me.activation_group_name.Visible = True
        Me.activation_group_name.VisibleIndex = 2
        Me.activation_group_name.Width = 165
        '
        'shopping_discount
        '
        Me.shopping_discount.Caption = "shopping_discount"
        Me.shopping_discount.FieldName = "shopping_discount"
        Me.shopping_discount.Name = "shopping_discount"
        Me.shopping_discount.OptionsColumn.FixedWidth = True
        Me.shopping_discount.Width = 67
        '
        'droselia
        '
        Me.droselia.Caption = "droselia"
        Me.droselia.FieldName = "droselia"
        Me.droselia.Name = "droselia"
        Me.droselia.OptionsColumn.FixedWidth = True
        Me.droselia.Width = 133
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsMarketting"
        Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabSearch)
        Me.TabControl1.Controls.Add(Me.tabResult)
        Me.TabControl1.Controls.Add(Me.tabDiscount)
        Me.TabControl1.Controls.Add(Me.TabShoppingDiscount)
        Me.TabControl1.Location = New System.Drawing.Point(0, 63)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1172, 617)
        Me.TabControl1.TabIndex = 36
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.btnNewDiscountCode)
        Me.tabSearch.Controls.Add(Me.btnViewShoppingDiscount)
        Me.tabSearch.Controls.Add(Me.btnDiscountExp)
        Me.tabSearch.Controls.Add(Me.btnLoadAllDisc)
        Me.tabSearch.Controls.Add(Me.GroupSearch)
        Me.tabSearch.Location = New System.Drawing.Point(4, 22)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.Size = New System.Drawing.Size(1164, 591)
        Me.tabSearch.TabIndex = 2
        Me.tabSearch.Text = "Search"
        Me.tabSearch.UseVisualStyleBackColor = True
        '
        'btnNewDiscountCode
        '
        Me.btnNewDiscountCode.Location = New System.Drawing.Point(389, 202)
        Me.btnNewDiscountCode.Name = "btnNewDiscountCode"
        Me.HelpProvider1.SetShowHelp(Me.btnNewDiscountCode, True)
        Me.btnNewDiscountCode.Size = New System.Drawing.Size(227, 23)
        Me.btnNewDiscountCode.TabIndex = 44
        Me.btnNewDiscountCode.Text = "New discount code"
        '
        'btnViewShoppingDiscount
        '
        Me.btnViewShoppingDiscount.Location = New System.Drawing.Point(389, 146)
        Me.btnViewShoppingDiscount.Name = "btnViewShoppingDiscount"
        Me.HelpProvider1.SetShowHelp(Me.btnViewShoppingDiscount, True)
        Me.btnViewShoppingDiscount.Size = New System.Drawing.Size(227, 23)
        Me.btnViewShoppingDiscount.TabIndex = 43
        Me.btnViewShoppingDiscount.Text = "Show Shopping Discount"
        Me.btnViewShoppingDiscount.Visible = False
        '
        'btnDiscountExp
        '
        Me.btnDiscountExp.Location = New System.Drawing.Point(389, 47)
        Me.btnDiscountExp.Name = "btnDiscountExp"
        Me.HelpProvider1.SetShowHelp(Me.btnDiscountExp, True)
        Me.btnDiscountExp.Size = New System.Drawing.Size(227, 23)
        Me.btnDiscountExp.TabIndex = 42
        Me.btnDiscountExp.Text = "Show Discount Expiration"
        '
        'btnLoadAllDisc
        '
        Me.btnLoadAllDisc.Location = New System.Drawing.Point(389, 96)
        Me.btnLoadAllDisc.Name = "btnLoadAllDisc"
        Me.HelpProvider1.SetShowHelp(Me.btnLoadAllDisc, True)
        Me.btnLoadAllDisc.Size = New System.Drawing.Size(227, 23)
        Me.btnLoadAllDisc.TabIndex = 37
        Me.btnLoadAllDisc.Text = "Show All Discount Code"
        '
        'GroupSearch
        '
        Me.GroupSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupSearch.Controls.Add(Me.btnXls)
        Me.GroupSearch.Controls.Add(Me.cmbGroupIDsearch)
        Me.GroupSearch.Controls.Add(Me.txtFromDate)
        Me.GroupSearch.Controls.Add(Me.lblDateValidityto)
        Me.GroupSearch.Controls.Add(Me.lblPartner)
        Me.GroupSearch.Controls.Add(Me.txtToDate)
        Me.GroupSearch.Controls.Add(Me.txtDiscountCodeSearch)
        Me.GroupSearch.Controls.Add(Me.lblDateValidityfrom)
        Me.GroupSearch.Controls.Add(Me.lblSearchDiscount)
        Me.GroupSearch.Controls.Add(Me.btnSearch)
        Me.GroupSearch.Controls.Add(Me.lblSearch)
        Me.GroupSearch.Controls.Add(Me.txtDiscountIdSearch)
        Me.GroupSearch.Location = New System.Drawing.Point(8, 13)
        Me.GroupSearch.Name = "GroupSearch"
        Me.HelpProvider1.SetShowHelp(Me.GroupSearch, True)
        Me.GroupSearch.Size = New System.Drawing.Size(321, 272)
        Me.GroupSearch.TabIndex = 39
        Me.GroupSearch.Text = "Search"
        '
        'btnXls
        '
        Me.btnXls.Image = CType(resources.GetObject("btnXls.Image"), System.Drawing.Image)
        Me.btnXls.Location = New System.Drawing.Point(58, 229)
        Me.btnXls.Name = "btnXls"
        Me.HelpProvider1.SetShowHelp(Me.btnXls, True)
        Me.btnXls.Size = New System.Drawing.Size(68, 23)
        Me.btnXls.TabIndex = 52
        Me.btnXls.Visible = False
        '
        'cmbGroupIDsearch
        '
        Me.cmbGroupIDsearch.Location = New System.Drawing.Point(155, 98)
        Me.cmbGroupIDsearch.Name = "cmbGroupIDsearch"
        Me.cmbGroupIDsearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbGroupIDsearch.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 114, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 119, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbGroupIDsearch.Properties.DisplayMember = "DisplayMember"
        Me.cmbGroupIDsearch.Properties.NullText = ""
        Me.cmbGroupIDsearch.Properties.ValueMember = "Value"
        Me.cmbGroupIDsearch.Size = New System.Drawing.Size(161, 20)
        Me.cmbGroupIDsearch.TabIndex = 40
        '
        'txtFromDate
        '
        Me.txtFromDate.EditValue = Nothing
        Me.txtFromDate.Location = New System.Drawing.Point(155, 136)
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtFromDate, False)
        Me.txtFromDate.Size = New System.Drawing.Size(100, 20)
        Me.txtFromDate.TabIndex = 12
        '
        'lblDateValidityto
        '
        Me.lblDateValidityto.Location = New System.Drawing.Point(4, 177)
        Me.lblDateValidityto.Name = "lblDateValidityto"
        Me.HelpProvider1.SetShowHelp(Me.lblDateValidityto, False)
        Me.lblDateValidityto.Size = New System.Drawing.Size(38, 13)
        Me.lblDateValidityto.TabIndex = 15
        Me.lblDateValidityto.Text = "To Date"
        '
        'lblPartner
        '
        Me.lblPartner.Location = New System.Drawing.Point(5, 101)
        Me.lblPartner.Name = "lblPartner"
        Me.HelpProvider1.SetShowHelp(Me.lblPartner, False)
        Me.lblPartner.Size = New System.Drawing.Size(65, 13)
        Me.lblPartner.TabIndex = 39
        Me.lblPartner.Text = "Partner name"
        '
        'txtToDate
        '
        Me.txtToDate.EditValue = Nothing
        Me.txtToDate.Location = New System.Drawing.Point(155, 170)
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtToDate, False)
        Me.txtToDate.Size = New System.Drawing.Size(100, 20)
        Me.txtToDate.TabIndex = 13
        '
        'txtDiscountCodeSearch
        '
        Me.txtDiscountCodeSearch.Location = New System.Drawing.Point(155, 64)
        Me.txtDiscountCodeSearch.Name = "txtDiscountCodeSearch"
        Me.HelpProvider1.SetShowHelp(Me.txtDiscountCodeSearch, False)
        Me.txtDiscountCodeSearch.Size = New System.Drawing.Size(161, 20)
        Me.txtDiscountCodeSearch.TabIndex = 0
        '
        'lblDateValidityfrom
        '
        Me.lblDateValidityfrom.Location = New System.Drawing.Point(4, 143)
        Me.lblDateValidityfrom.Name = "lblDateValidityfrom"
        Me.HelpProvider1.SetShowHelp(Me.lblDateValidityfrom, False)
        Me.lblDateValidityfrom.Size = New System.Drawing.Size(50, 13)
        Me.lblDateValidityfrom.TabIndex = 14
        Me.lblDateValidityfrom.Text = "From Date"
        '
        'lblSearchDiscount
        '
        Me.lblSearchDiscount.Location = New System.Drawing.Point(5, 67)
        Me.lblSearchDiscount.Name = "lblSearchDiscount"
        Me.HelpProvider1.SetShowHelp(Me.lblSearchDiscount, False)
        Me.lblSearchDiscount.Size = New System.Drawing.Size(103, 13)
        Me.lblSearchDiscount.TabIndex = 37
        Me.lblSearchDiscount.Text = "Part of Discount code"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(241, 229)
        Me.btnSearch.Name = "btnSearch"
        Me.HelpProvider1.SetShowHelp(Me.btnSearch, True)
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 35
        Me.btnSearch.Text = "Search"
        '
        'lblSearch
        '
        Me.lblSearch.Location = New System.Drawing.Point(5, 34)
        Me.lblSearch.Name = "lblSearch"
        Me.HelpProvider1.SetShowHelp(Me.lblSearch, False)
        Me.lblSearch.Size = New System.Drawing.Size(13, 13)
        Me.lblSearch.TabIndex = 36
        Me.lblSearch.Text = "Id "
        '
        'txtDiscountIdSearch
        '
        Me.txtDiscountIdSearch.EditValue = ""
        Me.txtDiscountIdSearch.Location = New System.Drawing.Point(155, 31)
        Me.txtDiscountIdSearch.Name = "txtDiscountIdSearch"
        Me.HelpProvider1.SetShowHelp(Me.txtDiscountIdSearch, False)
        Me.txtDiscountIdSearch.Size = New System.Drawing.Size(161, 20)
        Me.txtDiscountIdSearch.TabIndex = 34
        '
        'tabResult
        '
        Me.tabResult.AutoScroll = True
        Me.tabResult.Controls.Add(Me.GridControl1)
        Me.tabResult.Location = New System.Drawing.Point(4, 22)
        Me.tabResult.Name = "tabResult"
        Me.tabResult.Padding = New System.Windows.Forms.Padding(3)
        Me.tabResult.Size = New System.Drawing.Size(1164, 591)
        Me.tabResult.TabIndex = 0
        Me.tabResult.Text = "Result"
        Me.tabResult.UseVisualStyleBackColor = True
        '
        'tabDiscount
        '
        Me.tabDiscount.Controls.Add(Me.PanelControl1)
        Me.tabDiscount.Location = New System.Drawing.Point(4, 22)
        Me.tabDiscount.Name = "tabDiscount"
        Me.tabDiscount.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDiscount.Size = New System.Drawing.Size(1164, 591)
        Me.tabDiscount.TabIndex = 1
        Me.tabDiscount.Text = "Discount Code"
        Me.tabDiscount.UseVisualStyleBackColor = True
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl1.Controls.Add(Me.txtTVODFreeCredits)
        Me.PanelControl1.Controls.Add(Me.LabelControl19)
        Me.PanelControl1.Controls.Add(Me.cmbDiscountAction)
        Me.PanelControl1.Controls.Add(Me.LabelControl21)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.cmbNextAboType)
        Me.PanelControl1.Controls.Add(Me.LabelControl18)
        Me.PanelControl1.Controls.Add(Me.cmbAboType)
        Me.PanelControl1.Controls.Add(Me.btnCancel)
        Me.PanelControl1.Controls.Add(Me.btnSaveDiscount)
        Me.PanelControl1.Controls.Add(Me.btnEditDiscount)
        Me.PanelControl1.Controls.Add(Me.btnNewDiscount)
        Me.PanelControl1.Controls.Add(Me.txtGotToStep2)
        Me.PanelControl1.Controls.Add(Me.CheckDiscountStatus)
        Me.PanelControl1.Controls.Add(Me.txtCommitment2)
        Me.PanelControl1.Controls.Add(Me.CheckFreeUpgradeAllowed)
        Me.PanelControl1.Controls.Add(Me.txtValidityTo_Value2)
        Me.PanelControl1.Controls.Add(Me.CheckByPassDiscountUse)
        Me.PanelControl1.Controls.Add(Me.CheckCreditZero_AutoReconduction)
        Me.PanelControl1.Controls.Add(Me.CheckPayable)
        Me.PanelControl1.Controls.Add(Me.CheckCAutoStop)
        Me.PanelControl1.Controls.Add(Me.txtLimit2)
        Me.PanelControl1.Controls.Add(Me.txtDiscountValue2)
        Me.PanelControl1.Controls.Add(Me.txtNbrMonthReuse)
        Me.PanelControl1.Controls.Add(Me.txtNbrRecuring2)
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Controls.Add(Me.txtValidityTo)
        Me.PanelControl1.Controls.Add(Me.txtNextDiscountCode)
        Me.PanelControl1.Controls.Add(Me.txtValidityTo_Type)
        Me.PanelControl1.Controls.Add(Me.cmbDiscount_Type)
        Me.PanelControl1.Controls.Add(Me.cmbGroup_Partner)
        Me.PanelControl1.Controls.Add(Me.LabelControl30)
        Me.PanelControl1.Controls.Add(Me.LabelControl27)
        Me.PanelControl1.Controls.Add(Me.lblAboType)
        Me.PanelControl1.Controls.Add(Me.LabelControl20)
        Me.PanelControl1.Controls.Add(Me.LabelControl17)
        Me.PanelControl1.Controls.Add(Me.LabelControl15)
        Me.PanelControl1.Controls.Add(Me.LabelControl14)
        Me.PanelControl1.Controls.Add(Me.txtComment)
        Me.PanelControl1.Controls.Add(Me.LabelControl13)
        Me.PanelControl1.Controls.Add(Me.LabelControl12)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtDiscount_Code)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1158, 585)
        Me.PanelControl1.TabIndex = 37
        '
        'txtTVODFreeCredits
        '
        Me.txtTVODFreeCredits.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTVODFreeCredits.Enabled = False
        Me.txtTVODFreeCredits.Location = New System.Drawing.Point(681, 285)
        Me.txtTVODFreeCredits.Name = "txtTVODFreeCredits"
        Me.txtTVODFreeCredits.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtTVODFreeCredits.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtTVODFreeCredits, True)
        Me.txtTVODFreeCredits.Size = New System.Drawing.Size(100, 20)
        Me.txtTVODFreeCredits.TabIndex = 92
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(532, 288)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl19.TabIndex = 91
        Me.LabelControl19.Text = "TVOD free credits"
        '
        'cmbDiscountAction
        '
        Me.cmbDiscountAction.AllowDrop = True
        Me.cmbDiscountAction.Enabled = False
        Me.cmbDiscountAction.Location = New System.Drawing.Point(938, 188)
        Me.cmbDiscountAction.Name = "cmbDiscountAction"
        Me.cmbDiscountAction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDiscountAction.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 87, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 98, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbDiscountAction.Properties.DisplayMember = "DisplayMember"
        Me.cmbDiscountAction.Properties.NullText = ""
        Me.cmbDiscountAction.Properties.ValueMember = "Value"
        Me.cmbDiscountAction.Size = New System.Drawing.Size(154, 20)
        Me.cmbDiscountAction.TabIndex = 90
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(844, 192)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl21.TabIndex = 89
        Me.LabelControl21.Text = "Discount action"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckDebitCard)
        Me.GroupBox1.Controls.Add(Me.CheckCreditCard)
        Me.GroupBox1.Controls.Add(Me.CheckPaypal)
        Me.GroupBox1.Location = New System.Drawing.Point(835, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 106)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment methods"
        '
        'CheckDebitCard
        '
        Me.CheckDebitCard.EditValue = 0
        Me.CheckDebitCard.Enabled = False
        Me.CheckDebitCard.Location = New System.Drawing.Point(16, 72)
        Me.CheckDebitCard.Name = "CheckDebitCard"
        Me.CheckDebitCard.Properties.Caption = "Debit Card"
        Me.CheckDebitCard.Properties.ValueChecked = 1
        Me.CheckDebitCard.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.CheckDebitCard, True)
        Me.CheckDebitCard.Size = New System.Drawing.Size(150, 19)
        Me.CheckDebitCard.TabIndex = 90
        '
        'CheckCreditCard
        '
        Me.CheckCreditCard.EditValue = 0
        Me.CheckCreditCard.Enabled = False
        Me.CheckCreditCard.Location = New System.Drawing.Point(16, 47)
        Me.CheckCreditCard.Name = "CheckCreditCard"
        Me.CheckCreditCard.Properties.Caption = "Credit Card "
        Me.CheckCreditCard.Properties.ValueChecked = 1
        Me.CheckCreditCard.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.CheckCreditCard, True)
        Me.CheckCreditCard.Size = New System.Drawing.Size(150, 19)
        Me.CheckCreditCard.TabIndex = 89
        '
        'CheckPaypal
        '
        Me.CheckPaypal.EditValue = 0
        Me.CheckPaypal.Enabled = False
        Me.CheckPaypal.Location = New System.Drawing.Point(16, 22)
        Me.CheckPaypal.Name = "CheckPaypal"
        Me.CheckPaypal.Properties.Caption = "PayPal"
        Me.CheckPaypal.Properties.ValueChecked = 1
        Me.CheckPaypal.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.CheckPaypal, True)
        Me.CheckPaypal.Size = New System.Drawing.Size(150, 19)
        Me.CheckPaypal.TabIndex = 88
        '
        'cmbNextAboType
        '
        Me.cmbNextAboType.AllowDrop = True
        Me.cmbNextAboType.Enabled = False
        Me.cmbNextAboType.Location = New System.Drawing.Point(374, 192)
        Me.cmbNextAboType.Name = "cmbNextAboType"
        Me.cmbNextAboType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNextAboType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 87, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 98, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbNextAboType.Properties.DisplayMember = "DisplayMember"
        Me.cmbNextAboType.Properties.DropDownRows = 15
        Me.cmbNextAboType.Properties.NullText = ""
        Me.cmbNextAboType.Properties.ValueMember = "Value"
        Me.cmbNextAboType.Size = New System.Drawing.Size(100, 20)
        Me.cmbNextAboType.TabIndex = 82
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(234, 192)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl18.TabIndex = 81
        Me.LabelControl18.Text = "Next Abo Type"
        '
        'cmbAboType
        '
        Me.cmbAboType.AllowDrop = True
        Me.cmbAboType.Enabled = False
        Me.cmbAboType.Location = New System.Drawing.Point(374, 161)
        Me.cmbAboType.Name = "cmbAboType"
        Me.cmbAboType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAboType.Properties.DisplayMember = "DisplayMember"
        Me.cmbAboType.Properties.DropDownRows = 15
        Me.cmbAboType.Properties.NullText = ""
        Me.cmbAboType.Properties.ValueMember = "Value"
        Me.cmbAboType.Size = New System.Drawing.Size(100, 20)
        Me.cmbAboType.TabIndex = 80
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(297, 18)
        Me.btnCancel.Name = "btnCancel"
        Me.HelpProvider1.SetShowHelp(Me.btnCancel, True)
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 79
        Me.btnCancel.Text = "Cancel"
        '
        'btnSaveDiscount
        '
        Me.btnSaveDiscount.Location = New System.Drawing.Point(201, 18)
        Me.btnSaveDiscount.Name = "btnSaveDiscount"
        Me.HelpProvider1.SetShowHelp(Me.btnSaveDiscount, True)
        Me.btnSaveDiscount.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveDiscount.TabIndex = 78
        Me.btnSaveDiscount.Text = "Save"
        '
        'btnEditDiscount
        '
        Me.btnEditDiscount.Location = New System.Drawing.Point(106, 18)
        Me.btnEditDiscount.Name = "btnEditDiscount"
        Me.HelpProvider1.SetShowHelp(Me.btnEditDiscount, True)
        Me.btnEditDiscount.Size = New System.Drawing.Size(75, 23)
        Me.btnEditDiscount.TabIndex = 77
        Me.btnEditDiscount.Text = "Edit"
        '
        'btnNewDiscount
        '
        Me.btnNewDiscount.Location = New System.Drawing.Point(13, 18)
        Me.btnNewDiscount.Name = "btnNewDiscount"
        Me.HelpProvider1.SetShowHelp(Me.btnNewDiscount, True)
        Me.btnNewDiscount.Size = New System.Drawing.Size(75, 23)
        Me.btnNewDiscount.TabIndex = 76
        Me.btnNewDiscount.Text = "New"
        '
        'txtGotToStep2
        '
        Me.txtGotToStep2.EditValue = New Decimal(New Integer() {31, 0, 0, 0})
        Me.txtGotToStep2.Enabled = False
        Me.txtGotToStep2.Location = New System.Drawing.Point(692, 99)
        Me.txtGotToStep2.Name = "txtGotToStep2"
        Me.txtGotToStep2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtGotToStep2.Properties.MaxLength = 3
        Me.txtGotToStep2.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtGotToStep2, True)
        Me.txtGotToStep2.Size = New System.Drawing.Size(100, 20)
        Me.txtGotToStep2.TabIndex = 74
        '
        'CheckDiscountStatus
        '
        Me.CheckDiscountStatus.EditValue = 1
        Me.CheckDiscountStatus.Enabled = False
        Me.CheckDiscountStatus.Location = New System.Drawing.Point(791, 388)
        Me.CheckDiscountStatus.Name = "CheckDiscountStatus"
        Me.CheckDiscountStatus.Properties.Caption = "DiscountStatus"
        Me.CheckDiscountStatus.Properties.ValueChecked = 1
        Me.CheckDiscountStatus.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.CheckDiscountStatus, True)
        Me.CheckDiscountStatus.Size = New System.Drawing.Size(150, 19)
        Me.CheckDiscountStatus.TabIndex = 73
        Me.CheckDiscountStatus.Visible = False
        '
        'txtCommitment2
        '
        Me.txtCommitment2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCommitment2.Enabled = False
        Me.txtCommitment2.Location = New System.Drawing.Point(681, 259)
        Me.txtCommitment2.Name = "txtCommitment2"
        Me.txtCommitment2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtCommitment2, True)
        Me.txtCommitment2.Size = New System.Drawing.Size(100, 20)
        Me.txtCommitment2.TabIndex = 72
        Me.txtCommitment2.Visible = False
        '
        'CheckFreeUpgradeAllowed
        '
        Me.CheckFreeUpgradeAllowed.EditValue = 0
        Me.CheckFreeUpgradeAllowed.Enabled = False
        Me.CheckFreeUpgradeAllowed.Location = New System.Drawing.Point(791, 419)
        Me.CheckFreeUpgradeAllowed.Name = "CheckFreeUpgradeAllowed"
        Me.CheckFreeUpgradeAllowed.Properties.Caption = "FreeUpgradeAllowed"
        Me.CheckFreeUpgradeAllowed.Properties.ValueChecked = 1
        Me.CheckFreeUpgradeAllowed.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.CheckFreeUpgradeAllowed, True)
        Me.CheckFreeUpgradeAllowed.Size = New System.Drawing.Size(150, 19)
        Me.CheckFreeUpgradeAllowed.TabIndex = 71
        Me.CheckFreeUpgradeAllowed.Visible = False
        '
        'txtValidityTo_Value2
        '
        Me.txtValidityTo_Value2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValidityTo_Value2.Enabled = False
        Me.txtValidityTo_Value2.Location = New System.Drawing.Point(374, 99)
        Me.txtValidityTo_Value2.Name = "txtValidityTo_Value2"
        Me.txtValidityTo_Value2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtValidityTo_Value2.Properties.Mask.EditMask = "n0"
        Me.txtValidityTo_Value2.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtValidityTo_Value2, True)
        Me.txtValidityTo_Value2.Size = New System.Drawing.Size(100, 20)
        Me.txtValidityTo_Value2.TabIndex = 70
        '
        'CheckByPassDiscountUse
        '
        Me.CheckByPassDiscountUse.EditValue = 0
        Me.CheckByPassDiscountUse.Enabled = False
        Me.CheckByPassDiscountUse.Location = New System.Drawing.Point(791, 363)
        Me.CheckByPassDiscountUse.Name = "CheckByPassDiscountUse"
        Me.CheckByPassDiscountUse.Properties.Caption = "ByPass Discount Use"
        Me.CheckByPassDiscountUse.Properties.ValueChecked = 1
        Me.CheckByPassDiscountUse.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.CheckByPassDiscountUse, True)
        Me.CheckByPassDiscountUse.Size = New System.Drawing.Size(150, 19)
        Me.CheckByPassDiscountUse.TabIndex = 69
        Me.CheckByPassDiscountUse.Visible = False
        '
        'CheckCreditZero_AutoReconduction
        '
        Me.CheckCreditZero_AutoReconduction.EditValue = 0
        Me.CheckCreditZero_AutoReconduction.Enabled = False
        Me.CheckCreditZero_AutoReconduction.Location = New System.Drawing.Point(791, 444)
        Me.CheckCreditZero_AutoReconduction.Name = "CheckCreditZero_AutoReconduction"
        Me.CheckCreditZero_AutoReconduction.Properties.Caption = "CreditZero_AutoReconduction"
        Me.CheckCreditZero_AutoReconduction.Properties.ValueChecked = 1
        Me.CheckCreditZero_AutoReconduction.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.CheckCreditZero_AutoReconduction, True)
        Me.CheckCreditZero_AutoReconduction.Size = New System.Drawing.Size(150, 19)
        Me.CheckCreditZero_AutoReconduction.TabIndex = 68
        Me.CheckCreditZero_AutoReconduction.Visible = False
        '
        'CheckPayable
        '
        Me.CheckPayable.EditValue = 0
        Me.CheckPayable.Enabled = False
        Me.CheckPayable.Location = New System.Drawing.Point(791, 470)
        Me.CheckPayable.Name = "CheckPayable"
        Me.CheckPayable.Properties.Caption = "Payable"
        Me.CheckPayable.Properties.ValueChecked = 1
        Me.CheckPayable.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.CheckPayable, True)
        Me.CheckPayable.Size = New System.Drawing.Size(150, 19)
        Me.CheckPayable.TabIndex = 67
        Me.CheckPayable.Visible = False
        '
        'CheckCAutoStop
        '
        Me.CheckCAutoStop.EditValue = 0
        Me.CheckCAutoStop.Enabled = False
        Me.CheckCAutoStop.Location = New System.Drawing.Point(529, 193)
        Me.CheckCAutoStop.Name = "CheckCAutoStop"
        Me.CheckCAutoStop.Properties.Caption = "AutoStop "
        Me.CheckCAutoStop.Properties.ValueChecked = 1
        Me.CheckCAutoStop.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.CheckCAutoStop, True)
        Me.CheckCAutoStop.Size = New System.Drawing.Size(150, 19)
        Me.CheckCAutoStop.TabIndex = 66
        '
        'txtLimit2
        '
        Me.txtLimit2.EditValue = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.txtLimit2.Enabled = False
        Me.txtLimit2.Location = New System.Drawing.Point(155, 233)
        Me.txtLimit2.Name = "txtLimit2"
        Me.txtLimit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtLimit2, True)
        Me.txtLimit2.Size = New System.Drawing.Size(100, 20)
        Me.txtLimit2.TabIndex = 64
        '
        'txtDiscountValue2
        '
        Me.txtDiscountValue2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDiscountValue2.Enabled = False
        Me.txtDiscountValue2.Location = New System.Drawing.Point(113, 130)
        Me.txtDiscountValue2.Name = "txtDiscountValue2"
        Me.txtDiscountValue2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDiscountValue2.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtDiscountValue2, True)
        Me.txtDiscountValue2.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountValue2.TabIndex = 63
        '
        'txtNbrMonthReuse
        '
        Me.txtNbrMonthReuse.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNbrMonthReuse.Enabled = False
        Me.txtNbrMonthReuse.Location = New System.Drawing.Point(681, 233)
        Me.txtNbrMonthReuse.Name = "txtNbrMonthReuse"
        Me.txtNbrMonthReuse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtNbrMonthReuse, True)
        Me.txtNbrMonthReuse.Size = New System.Drawing.Size(100, 20)
        Me.txtNbrMonthReuse.TabIndex = 62
        '
        'txtNbrRecuring2
        '
        Me.txtNbrRecuring2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNbrRecuring2.Enabled = False
        Me.txtNbrRecuring2.Location = New System.Drawing.Point(692, 161)
        Me.txtNbrRecuring2.Name = "txtNbrRecuring2"
        Me.txtNbrRecuring2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtNbrRecuring2.Properties.MaxValue = New Decimal(New Integer() {12, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtNbrRecuring2, True)
        Me.txtNbrRecuring2.Size = New System.Drawing.Size(100, 20)
        Me.txtNbrRecuring2.TabIndex = 61
        '
        'GroupControl2
        '
        Me.GroupControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl2.Controls.Add(Me.CheckLandingPage)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.txtText_EN)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.txtText_NL)
        Me.GroupControl2.Controls.Add(Me.txtText_Fr)
        Me.GroupControl2.Controls.Add(Me.LabelControl28)
        Me.GroupControl2.Controls.Add(Me.txtFooter)
        Me.GroupControl2.Controls.Add(Me.txtBanner)
        Me.GroupControl2.Controls.Add(Me.LabelControl29)
        Me.GroupControl2.Controls.Add(Me.LabelControl23)
        Me.GroupControl2.Controls.Add(Me.txtLandingPagePHP)
        Me.GroupControl2.Location = New System.Drawing.Point(36, 333)
        Me.GroupControl2.Name = "GroupControl2"
        Me.HelpProvider1.SetShowHelp(Me.GroupControl2, True)
        Me.GroupControl2.Size = New System.Drawing.Size(549, 250)
        Me.GroupControl2.TabIndex = 60
        Me.GroupControl2.Text = "Web Site Info"
        '
        'CheckLandingPage
        '
        Me.CheckLandingPage.EditValue = 0
        Me.CheckLandingPage.Enabled = False
        Me.CheckLandingPage.Location = New System.Drawing.Point(34, 189)
        Me.CheckLandingPage.Name = "CheckLandingPage"
        Me.CheckLandingPage.Properties.Caption = "Landing Page"
        Me.CheckLandingPage.Properties.ValueChecked = 1
        Me.CheckLandingPage.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.CheckLandingPage, True)
        Me.CheckLandingPage.Size = New System.Drawing.Size(95, 19)
        Me.CheckLandingPage.TabIndex = 72
        Me.CheckLandingPage.Visible = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(14, 32)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl10.TabIndex = 18
        Me.LabelControl10.Text = "Text FR"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(14, 84)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "Text EN"
        '
        'txtText_EN
        '
        Me.txtText_EN.Enabled = False
        Me.txtText_EN.Location = New System.Drawing.Point(138, 81)
        Me.txtText_EN.Name = "txtText_EN"
        Me.txtText_EN.Size = New System.Drawing.Size(371, 20)
        Me.txtText_EN.TabIndex = 24
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(14, 58)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl9.TabIndex = 16
        Me.LabelControl9.Text = "Text NL"
        '
        'txtText_NL
        '
        Me.txtText_NL.Enabled = False
        Me.txtText_NL.Location = New System.Drawing.Point(138, 55)
        Me.txtText_NL.Name = "txtText_NL"
        Me.txtText_NL.Size = New System.Drawing.Size(371, 20)
        Me.txtText_NL.TabIndex = 23
        '
        'txtText_Fr
        '
        Me.txtText_Fr.Enabled = False
        Me.txtText_Fr.Location = New System.Drawing.Point(138, 29)
        Me.txtText_Fr.Name = "txtText_Fr"
        Me.txtText_Fr.Size = New System.Drawing.Size(371, 20)
        Me.txtText_Fr.TabIndex = 22
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(14, 127)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl28.TabIndex = 54
        Me.LabelControl28.Text = "Banner"
        Me.LabelControl28.Visible = False
        '
        'txtFooter
        '
        Me.txtFooter.Enabled = False
        Me.txtFooter.Location = New System.Drawing.Point(138, 150)
        Me.txtFooter.Name = "txtFooter"
        Me.txtFooter.Size = New System.Drawing.Size(371, 20)
        Me.txtFooter.TabIndex = 27
        Me.txtFooter.Visible = False
        '
        'txtBanner
        '
        Me.txtBanner.Enabled = False
        Me.txtBanner.Location = New System.Drawing.Point(138, 124)
        Me.txtBanner.Name = "txtBanner"
        Me.txtBanner.Size = New System.Drawing.Size(371, 20)
        Me.txtBanner.TabIndex = 26
        Me.txtBanner.Visible = False
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(14, 153)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl29.TabIndex = 56
        Me.LabelControl29.Text = "Footer"
        Me.LabelControl29.Visible = False
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(14, 217)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl23.TabIndex = 44
        Me.LabelControl23.Text = "Landing Page PHP"
        Me.LabelControl23.Visible = False
        '
        'txtLandingPagePHP
        '
        Me.txtLandingPagePHP.Enabled = False
        Me.txtLandingPagePHP.Location = New System.Drawing.Point(138, 214)
        Me.txtLandingPagePHP.Name = "txtLandingPagePHP"
        Me.txtLandingPagePHP.Size = New System.Drawing.Size(371, 20)
        Me.txtLandingPagePHP.TabIndex = 29
        Me.txtLandingPagePHP.Visible = False
        '
        'txtValidityTo
        '
        Me.txtValidityTo.EditValue = Nothing
        Me.txtValidityTo.Enabled = False
        Me.txtValidityTo.Location = New System.Drawing.Point(692, 130)
        Me.txtValidityTo.Name = "txtValidityTo"
        Me.txtValidityTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtValidityTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtValidityTo, False)
        Me.txtValidityTo.Size = New System.Drawing.Size(100, 20)
        Me.txtValidityTo.TabIndex = 59
        '
        'txtNextDiscountCode
        '
        Me.txtNextDiscountCode.Enabled = False
        Me.txtNextDiscountCode.Location = New System.Drawing.Point(374, 130)
        Me.txtNextDiscountCode.Name = "txtNextDiscountCode"
        Me.txtNextDiscountCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNextDiscountCode.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 175, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 180, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.txtNextDiscountCode.Properties.DisplayMember = "DisplayMember"
        Me.txtNextDiscountCode.Properties.NullText = ""
        Me.txtNextDiscountCode.Properties.ValueMember = "Value"
        Me.txtNextDiscountCode.Size = New System.Drawing.Size(100, 20)
        Me.txtNextDiscountCode.TabIndex = 16
        '
        'txtValidityTo_Type
        '
        Me.txtValidityTo_Type.Enabled = False
        Me.txtValidityTo_Type.Location = New System.Drawing.Point(374, 68)
        Me.txtValidityTo_Type.Name = "txtValidityTo_Type"
        Me.txtValidityTo_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtValidityTo_Type.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 175, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 180, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.txtValidityTo_Type.Properties.DisplayMember = "DisplayMember"
        Me.txtValidityTo_Type.Properties.NullText = ""
        Me.txtValidityTo_Type.Properties.ValueMember = "Value"
        Me.txtValidityTo_Type.Size = New System.Drawing.Size(100, 20)
        Me.txtValidityTo_Type.TabIndex = 8
        '
        'cmbDiscount_Type
        '
        Me.cmbDiscount_Type.Enabled = False
        Me.cmbDiscount_Type.Location = New System.Drawing.Point(113, 99)
        Me.cmbDiscount_Type.Name = "cmbDiscount_Type"
        Me.cmbDiscount_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDiscount_Type.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 87, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 98, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbDiscount_Type.Properties.DisplayMember = "DisplayMember"
        Me.cmbDiscount_Type.Properties.NullText = ""
        Me.cmbDiscount_Type.Properties.ValueMember = "Value"
        Me.cmbDiscount_Type.Size = New System.Drawing.Size(100, 20)
        Me.cmbDiscount_Type.TabIndex = 3
        '
        'cmbGroup_Partner
        '
        Me.cmbGroup_Partner.Enabled = False
        Me.cmbGroup_Partner.Location = New System.Drawing.Point(692, 68)
        Me.cmbGroup_Partner.Name = "cmbGroup_Partner"
        Me.cmbGroup_Partner.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbGroup_Partner.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 114, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 119, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbGroup_Partner.Properties.DisplayMember = "DisplayMember"
        Me.cmbGroup_Partner.Properties.NullText = ""
        Me.cmbGroup_Partner.Properties.ValueMember = "Value"
        Me.cmbGroup_Partner.Size = New System.Drawing.Size(100, 20)
        Me.cmbGroup_Partner.TabIndex = 1
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(531, 68)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl30.TabIndex = 58
        Me.LabelControl30.Text = "Partner"
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(531, 99)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl27.TabIndex = 52
        Me.LabelControl27.Text = "Step website"
        '
        'lblAboType
        '
        Me.lblAboType.Location = New System.Drawing.Point(234, 161)
        Me.lblAboType.Name = "lblAboType"
        Me.lblAboType.Size = New System.Drawing.Size(46, 13)
        Me.lblAboType.TabIndex = 46
        Me.lblAboType.Text = "Abo Type"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(234, 130)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl20.TabIndex = 38
        Me.LabelControl20.Text = "Next Discount Code"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(531, 130)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(106, 13)
        Me.LabelControl17.TabIndex = 32
        Me.LabelControl17.Text = "date limit validity code"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(531, 161)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(149, 13)
        Me.LabelControl15.TabIndex = 28
        Me.LabelControl15.Text = "Recuring discount code(month)"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(531, 239)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(136, 13)
        Me.LabelControl14.TabIndex = 26
        Me.LabelControl14.Text = "Nbr of Month before Re-Use"
        '
        'txtComment
        '
        Me.txtComment.Enabled = False
        Me.txtComment.Location = New System.Drawing.Point(155, 259)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(361, 20)
        Me.txtComment.TabIndex = 25
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(5, 262)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl13.TabIndex = 24
        Me.LabelControl13.Text = "Comment"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(234, 99)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl12.TabIndex = 22
        Me.LabelControl12.Text = "value of duration code"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(234, 68)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl11.TabIndex = 20
        Me.LabelControl11.Text = "type of duration code"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(532, 262)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Commitment"
        Me.LabelControl6.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(5, 236)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(134, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "limited number of code used"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 130)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Value of reduction"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 99)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Type of reduction"
        '
        'txtDiscount_Code
        '
        Me.txtDiscount_Code.Enabled = False
        Me.txtDiscount_Code.Location = New System.Drawing.Point(113, 68)
        Me.txtDiscount_Code.Name = "txtDiscount_Code"
        Me.txtDiscount_Code.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscount_Code.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 68)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Discount Code"
        '
        'TabShoppingDiscount
        '
        Me.TabShoppingDiscount.Controls.Add(Me.PanelControl2)
        Me.TabShoppingDiscount.Location = New System.Drawing.Point(4, 22)
        Me.TabShoppingDiscount.Name = "TabShoppingDiscount"
        Me.TabShoppingDiscount.Size = New System.Drawing.Size(1164, 591)
        Me.TabShoppingDiscount.TabIndex = 3
        Me.TabShoppingDiscount.Text = "Shopping Discount"
        Me.TabShoppingDiscount.UseVisualStyleBackColor = True
        '
        'PanelControl2
        '
        Me.PanelControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl2.Controls.Add(Me.CheckShoppingDiscountStatus)
        Me.PanelControl2.Controls.Add(Me.btnShoppingUndo)
        Me.PanelControl2.Controls.Add(Me.btnShoppingSave)
        Me.PanelControl2.Controls.Add(Me.btnShoppingEdit)
        Me.PanelControl2.Controls.Add(Me.btnShoppingNew)
        Me.PanelControl2.Controls.Add(Me.SpinShoppingDiscountValue)
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Controls.Add(Me.dateShoppingDiscountValidityTo)
        Me.PanelControl2.Controls.Add(Me.cmbShoppingDiscountType)
        Me.PanelControl2.Controls.Add(Me.LabelControl34)
        Me.PanelControl2.Controls.Add(Me.LabelControl42)
        Me.PanelControl2.Controls.Add(Me.LabelControl43)
        Me.PanelControl2.Controls.Add(Me.txtShoppingDiscount)
        Me.PanelControl2.Controls.Add(Me.LabelControl44)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1164, 591)
        Me.PanelControl2.TabIndex = 38
        '
        'CheckShoppingDiscountStatus
        '
        Me.CheckShoppingDiscountStatus.EditValue = 0
        Me.CheckShoppingDiscountStatus.Enabled = False
        Me.CheckShoppingDiscountStatus.Location = New System.Drawing.Point(25, 371)
        Me.CheckShoppingDiscountStatus.Name = "CheckShoppingDiscountStatus"
        Me.CheckShoppingDiscountStatus.Properties.Caption = "DiscountStatus"
        Me.CheckShoppingDiscountStatus.Properties.ValueChecked = 1
        Me.CheckShoppingDiscountStatus.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.CheckShoppingDiscountStatus, True)
        Me.CheckShoppingDiscountStatus.Size = New System.Drawing.Size(150, 19)
        Me.CheckShoppingDiscountStatus.TabIndex = 80
        '
        'btnShoppingUndo
        '
        Me.btnShoppingUndo.Location = New System.Drawing.Point(297, 18)
        Me.btnShoppingUndo.Name = "btnShoppingUndo"
        Me.HelpProvider1.SetShowHelp(Me.btnShoppingUndo, True)
        Me.btnShoppingUndo.Size = New System.Drawing.Size(75, 23)
        Me.btnShoppingUndo.TabIndex = 79
        Me.btnShoppingUndo.Text = "Undo"
        '
        'btnShoppingSave
        '
        Me.btnShoppingSave.Location = New System.Drawing.Point(201, 18)
        Me.btnShoppingSave.Name = "btnShoppingSave"
        Me.HelpProvider1.SetShowHelp(Me.btnShoppingSave, True)
        Me.btnShoppingSave.Size = New System.Drawing.Size(75, 23)
        Me.btnShoppingSave.TabIndex = 78
        Me.btnShoppingSave.Text = "Save"
        '
        'btnShoppingEdit
        '
        Me.btnShoppingEdit.Location = New System.Drawing.Point(106, 18)
        Me.btnShoppingEdit.Name = "btnShoppingEdit"
        Me.HelpProvider1.SetShowHelp(Me.btnShoppingEdit, True)
        Me.btnShoppingEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnShoppingEdit.TabIndex = 77
        Me.btnShoppingEdit.Text = "Edit"
        '
        'btnShoppingNew
        '
        Me.btnShoppingNew.Location = New System.Drawing.Point(13, 18)
        Me.btnShoppingNew.Name = "btnShoppingNew"
        Me.HelpProvider1.SetShowHelp(Me.btnShoppingNew, True)
        Me.btnShoppingNew.Size = New System.Drawing.Size(75, 23)
        Me.btnShoppingNew.TabIndex = 76
        Me.btnShoppingNew.Text = "New"
        '
        'SpinShoppingDiscountValue
        '
        Me.SpinShoppingDiscountValue.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinShoppingDiscountValue.Enabled = False
        Me.SpinShoppingDiscountValue.Location = New System.Drawing.Point(151, 149)
        Me.SpinShoppingDiscountValue.Name = "SpinShoppingDiscountValue"
        Me.SpinShoppingDiscountValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.SpinShoppingDiscountValue, True)
        Me.SpinShoppingDiscountValue.Size = New System.Drawing.Size(100, 20)
        Me.SpinShoppingDiscountValue.TabIndex = 63
        '
        'GroupControl1
        '
        Me.GroupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txtShoppingDiscountEn)
        Me.GroupControl1.Controls.Add(Me.LabelControl16)
        Me.GroupControl1.Controls.Add(Me.txtShoppingDiscountNl)
        Me.GroupControl1.Controls.Add(Me.txtShoppingDiscountFr)
        Me.GroupControl1.Location = New System.Drawing.Point(27, 229)
        Me.GroupControl1.Name = "GroupControl1"
        Me.HelpProvider1.SetShowHelp(Me.GroupControl1, True)
        Me.GroupControl1.Size = New System.Drawing.Size(549, 120)
        Me.GroupControl1.TabIndex = 60
        Me.GroupControl1.Text = "Web Site Info"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl1.TabIndex = 18
        Me.LabelControl1.Text = "Text FR"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(14, 84)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl7.TabIndex = 14
        Me.LabelControl7.Text = "Text EN"
        '
        'txtShoppingDiscountEn
        '
        Me.txtShoppingDiscountEn.Enabled = False
        Me.txtShoppingDiscountEn.Location = New System.Drawing.Point(138, 81)
        Me.txtShoppingDiscountEn.Name = "txtShoppingDiscountEn"
        Me.txtShoppingDiscountEn.Size = New System.Drawing.Size(371, 20)
        Me.txtShoppingDiscountEn.TabIndex = 24
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(14, 58)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl16.TabIndex = 16
        Me.LabelControl16.Text = "Text NL"
        '
        'txtShoppingDiscountNl
        '
        Me.txtShoppingDiscountNl.Enabled = False
        Me.txtShoppingDiscountNl.Location = New System.Drawing.Point(138, 55)
        Me.txtShoppingDiscountNl.Name = "txtShoppingDiscountNl"
        Me.txtShoppingDiscountNl.Size = New System.Drawing.Size(371, 20)
        Me.txtShoppingDiscountNl.TabIndex = 23
        '
        'txtShoppingDiscountFr
        '
        Me.txtShoppingDiscountFr.Enabled = False
        Me.txtShoppingDiscountFr.Location = New System.Drawing.Point(138, 29)
        Me.txtShoppingDiscountFr.Name = "txtShoppingDiscountFr"
        Me.txtShoppingDiscountFr.Size = New System.Drawing.Size(371, 20)
        Me.txtShoppingDiscountFr.TabIndex = 22
        '
        'dateShoppingDiscountValidityTo
        '
        Me.dateShoppingDiscountValidityTo.EditValue = Nothing
        Me.dateShoppingDiscountValidityTo.Enabled = False
        Me.dateShoppingDiscountValidityTo.Location = New System.Drawing.Point(151, 184)
        Me.dateShoppingDiscountValidityTo.Name = "dateShoppingDiscountValidityTo"
        Me.dateShoppingDiscountValidityTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateShoppingDiscountValidityTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.dateShoppingDiscountValidityTo, False)
        Me.dateShoppingDiscountValidityTo.Size = New System.Drawing.Size(100, 20)
        Me.dateShoppingDiscountValidityTo.TabIndex = 59
        '
        'cmbShoppingDiscountType
        '
        Me.cmbShoppingDiscountType.Enabled = False
        Me.cmbShoppingDiscountType.Location = New System.Drawing.Point(151, 114)
        Me.cmbShoppingDiscountType.Name = "cmbShoppingDiscountType"
        Me.cmbShoppingDiscountType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbShoppingDiscountType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 87, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 98, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbShoppingDiscountType.Properties.DisplayMember = "DisplayMember"
        Me.cmbShoppingDiscountType.Properties.NullText = ""
        Me.cmbShoppingDiscountType.Properties.ValueMember = "Value"
        Me.cmbShoppingDiscountType.Size = New System.Drawing.Size(100, 20)
        Me.cmbShoppingDiscountType.TabIndex = 3
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(28, 187)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl34.TabIndex = 32
        Me.LabelControl34.Text = "Discount Validity To"
        '
        'LabelControl42
        '
        Me.LabelControl42.Location = New System.Drawing.Point(27, 152)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl42.TabIndex = 6
        Me.LabelControl42.Text = "Value"
        '
        'LabelControl43
        '
        Me.LabelControl43.Location = New System.Drawing.Point(27, 117)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl43.TabIndex = 4
        Me.LabelControl43.Text = "Type"
        '
        'txtShoppingDiscount
        '
        Me.txtShoppingDiscount.Enabled = False
        Me.txtShoppingDiscount.Location = New System.Drawing.Point(151, 81)
        Me.txtShoppingDiscount.Name = "txtShoppingDiscount"
        Me.txtShoppingDiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtShoppingDiscount.TabIndex = 2
        '
        'LabelControl44
        '
        Me.LabelControl44.Location = New System.Drawing.Point(27, 84)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl44.TabIndex = 2
        Me.LabelControl44.Text = "Discount Code"
        '
        'frmDiscountCode
        '
        Me.ClientSize = New System.Drawing.Size(1172, 708)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmDiscountCode"
        Me.Text = "Discount Code"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewShoppingDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabSearch.ResumeLayout(False)
        CType(Me.GroupSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupSearch.ResumeLayout(False)
        Me.GroupSearch.PerformLayout()
        CType(Me.cmbGroupIDsearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscountCodeSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscountIdSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabResult.ResumeLayout(False)
        Me.tabDiscount.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtTVODFreeCredits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDiscountAction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CheckDebitCard.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckCreditCard.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckPaypal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNextAboType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAboType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGotToStep2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckDiscountStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCommitment2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckFreeUpgradeAllowed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValidityTo_Value2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckByPassDiscountUse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckCreditZero_AutoReconduction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckPayable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckCAutoStop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLimit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscountValue2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNbrMonthReuse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNbrRecuring2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.CheckLandingPage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtText_EN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtText_NL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtText_Fr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFooter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBanner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLandingPagePHP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValidityTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValidityTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNextDiscountCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValidityTo_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDiscount_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGroup_Partner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabShoppingDiscount.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.CheckShoppingDiscountStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinShoppingDiscountValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtShoppingDiscountEn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShoppingDiscountNl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShoppingDiscountFr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateShoppingDiscountValidityTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateShoppingDiscountValidityTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbShoppingDiscountType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShoppingDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents objDS As PlushLib.dsMarketting
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabResult As System.Windows.Forms.TabPage
    Friend WithEvents tabDiscount As System.Windows.Forms.TabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtNextDiscountCode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtValidityTo_Type As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbDiscount_Type As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbGroup_Partner As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFooter As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBanner As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAboType As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLandingPagePHP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtText_Fr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtText_NL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtText_EN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDiscount_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewDiscount As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents discount_code_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents discount_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents discount_validityto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabSearch As System.Windows.Forms.TabPage
    Friend WithEvents GroupSearch As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblPartner As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDiscountCodeSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSearchDiscount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblSearch As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDiscountIdSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbGroupIDsearch As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblDateValidityto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblDateValidityfrom As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDiscountExp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoadAllDisc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtValidityTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNbrRecuring2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtNbrMonthReuse As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtDiscountValue2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtLimit2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CheckCreditZero_AutoReconduction As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckPayable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckCAutoStop As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckByPassDiscountUse As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckFreeUpgradeAllowed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtValidityTo_Value2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CheckLandingPage As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckDiscountStatus As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCommitment2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtGotToStep2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents discount_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents discount_value As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents discount_limit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents discount_commitment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents discount_text_fr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents discount_text_nl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents discount_text_en As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents discount_abo_validityto_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents discount_abo_validityto_value As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents comment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents discount_nbr_month_before_reuse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents discount_recurring_nbr_of_month As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents abo_dvd_credit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents next_discount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents listing_products_allowed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents goto_step As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents banner As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Footer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_group_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shopping_discount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents droselia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveDiscount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditDiscount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNewDiscount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TabShoppingDiscount As System.Windows.Forms.TabPage
    Friend WithEvents GridViewShoppingDiscount As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnViewShoppingDiscount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnShoppingUndo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnShoppingSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnShoppingEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnShoppingNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SpinShoppingDiscountValue As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtShoppingDiscountEn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtShoppingDiscountNl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtShoppingDiscountFr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dateShoppingDiscountValidityTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbShoppingDiscountType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtShoppingDiscount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckShoppingDiscountStatus As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbAboType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbNextAboType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnNewDiscountCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXls As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckDebitCard As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckCreditCard As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckPaypal As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbDiscountAction As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTVODFreeCredits As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl

End Class
