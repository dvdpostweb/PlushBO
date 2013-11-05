Imports BizzLib.clsGlobal.ObjectState
Imports System.Collections.Generic

Public Class frmDiscountCode

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim KeyDataSet As String = "BizzLib.dsGeneral" 'The Dataset used 
    'Public _CurrentDiscountID As Integer
    'Dim MainData As clsMarketing.clsDiscountCode
    ''
    Dim _discountCode As String
    Dim _discountType As Integer
    Dim _discountValue As Integer
    Dim _discountLimit As Integer
    Dim _discountCommitment As Integer
    Dim _commentDiscount As String
    Dim _discountTextFr As String
    Dim _discountTextNl As String
    Dim _discountTextEn As String
    Dim _bannerDiscount As String
    Dim _footerDiscount As String
    Dim _landingPage As Integer
    Dim _landingPagePhp As String
    Dim _groupId As Integer
    Dim _discountAboValiditytoType As Integer
    Dim _discountAboValiditytoValue As Integer
    Dim _iscountNbrMonthBeforeReuse As Integer
    Dim _discountRecurringNbrOfMonth As Integer
    Dim _discountValidityTo As String
    Dim _aboDvdCredit As Integer
    Dim _nextDiscount As Integer
    Dim _listingProductsAllowed As String
    Dim _gotoStep As Integer
    Dim _aboAutoStopNextReconduction As Integer
    Dim _payable As Integer
    Dim _credit0AutoReconduct As Integer
    Dim _bypassDiscountuse As Integer
    Dim _FreeUpgradeAllowed As Integer
    Dim _discountStatus As Integer

    Dim _shoppingdiscountCode As String
    Dim _shoppingDiscountType As Integer
    Dim _shoppingDiscountValue As Integer
    Dim _shoppingDiscountTextFR As String
    Dim _shoppingDiscountTextNl As String
    Dim _shoppingDiscountTextEn As String
    Dim _shoppingDiscountValidityTo As String
    Dim _shoppingDiscountStatus As Integer




    Public Sub Local_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim menuStrip As New dvdpostbuziness.contextMenu()
        GridControl1.ContextMenuStrip = menuStrip


        GridViewDiscount.OptionsView.ColumnAutoWidth = False
        GridViewShoppingDiscount.OptionsView.ColumnAutoWidth = False
        btnShoppingSave.Enabled = False
        btnSaveDiscount.Enabled = False

        Try
            objDS.EnforceConstraints = False
            MyBase.btnQuickSearch.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MyBase.BarManager1.HideToolBarsPopup()

            'SetUp of Variables
            KeyFieldName = "discount_code_id"
            IDField = "discount_code_id"
            TableName = "discount_code"
            MainDataSet = objDS
            'MyBase.RaiseEventForReportDesigner = False
            'HelpProvider1.HelpNamespace = ".\Help\" & SessionInfo.UserLang & "\BizzKeys.chm"
            'Attempt to load the dataset.
            LoadBKComboMaint()


            DefaultSet_Bar.Visible = False
            Filter_Bar.Visible = False
            Misc_Bar2.Visible = False
            Main_Bar.Visible = False
            Nav_Bar.Visible = False
            Report_Bar.Visible = False


        Catch eLoad As System.Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Discount, eLoad)
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try

        TabControl1.SelectedTab = tabSearch




    End Sub

    'Private Sub UndoChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuUndo.Click, MyBase.EventUndoChanges

    Public Sub LoadBKComboMaint()
        Try

            'cmbGroup_Partner.Properties.DataSource = DvdPostData.clsConnection.FillDataSet(DvdPostData.clsActivationCode.GetActivationGroup())
            cmbGroup_Partner.Properties.DataSource = GetListCmb(DvdPostData.clsActivationCode.GetActivationGroup(), "activation_group_name", "activation_group_id")

            'BKCombo.GetCombo(objDS, "products", "products_id", DvdPostData.clsActivationCode.GetProducts(DvdPostData.clsActivationCode.productsTypeAbo)) '"SELECT products_id, products_title FROM products where products_type = 'ABO' ")
            'cmbProductsAllowed.Properties.DataSource = DvdPostData.clsConnection.FillDataSet(DvdPostData.clsActivationCode.GetProducts(DvdPostData.clsActivationCode.productsTypeAbo))


            'txtValidityTo_Type.Properties.DataSource = DvdPostData.clsConnection.FillDataSet(DvdPostData.clsActivationCode.GetDiscountAboValidityType())
            txtValidityTo_Type.Properties.DataSource = GetListCmb(DvdPostData.clsActivationCode.GetDiscountAboValidityType(), "discount_abo_validityto_type_name", "discount_abo_validityto_type_id")


            'cmbDiscount_Type.Properties.DataSource = DvdPostData.clsConnection.FillDataSet(DvdPostData.clsActivationCode.GetDiscountType())
            cmbDiscount_Type.Properties.DataSource = GetListCmb(DvdPostData.clsActivationCode.GetDiscountType(), "discount_explained", "discount_type")

            'txtNextDiscountCode.Properties.DataSource = DvdPostData.clsConnection.FillDataSet(DvdPostData.clsActivationCode.GetDiscountCode())
            txtNextDiscountCode.Properties.DataSource = GetListCmb(DvdPostData.clsActivationCode.GetDiscountCode(), "discount_code", "discount_code_id")

            'cmbShoppingDiscountType.Properties.DataSource = DvdPostData.clsConnection.FillDataSet(DvdPostData.clsActivationCode.GetDiscountType())
            cmbShoppingDiscountType.Properties.DataSource = GetListCmb(DvdPostData.clsActivationCode.GetDiscountType(), "discount_explained", "discount_type")

            'cmbGroupIDsearch.Properties.DataSource = DvdPostData.clsConnection.FillDataSet(DvdPostData.clsActivationCode.GetActivationGroup)
            cmbGroupIDsearch.Properties.DataSource = GetListCmb(DvdPostData.clsActivationCode.GetActivationGroup(), "activation_group_name", "activation_group_id")

        Catch ex As Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, ex)
            Throw ex
        End Try
    End Sub

    Private Function GetListCmb(ByVal sql As String, ByVal displayMember As String, ByVal value As String) As List(Of DVDPostBuziness.clsKeyCombo)
        Dim listCmb As New List(Of DVDPostBuziness.clsKeyCombo)
        Dim dt As DataTable
        Dim dr As DataRow

        dt = DvdPostData.clsConnection.FillDataSet(sql)

        listCmb.Add(New DVDPostBuziness.clsKeyCombo("", 0))
        For Each dr In dt.Rows
            listCmb.Add(New DVDPostBuziness.clsKeyCombo(dr(displayMember), dr(value)))
        Next
        'cmbGroupIDsearch.Properties.DataSource = _listGroupId
        'cmbGroup_Partner.Properties.DataSource = _listGroupId

        Return listCmb
    End Function


    Private Sub EnablingEditFields(ByVal Enabling As Boolean)
        'ToBeChecked ***
        'txtAutoStopNextReconduction.Enabled = Enabling
        txtBanner.Enabled = Enabling
        txtComment.Enabled = Enabling
        'txtCommitment.Enabled = Enabling
        'txtCreditDVD.Enabled = Enabling
        'txtCreditZero_AutoReconduction.Enabled = Enabling
        txtDiscount_Code.Enabled = Enabling
        'txtDiscount_ID.Enabled = Enabling
        'txtDiscount_Value.Enabled = Enabling
        'txtDiscountUse.Enabled = Enabling
        'txtFooter.Enabled = Enabling
        'txtFreeUpgradeAllowed.Enabled = Enabling
        'txtGotToStep.Enabled = Enabling
        'txtLandingPage.Enabled = Enabling
        txtLandingPagePHP.Enabled = Enabling
        ''txtLimit.Enabled = Enabling
        'txtLitingProductsAllowed.Enabled = Enabling
        ''txtNbrOfMonth_Before_Reuse.Enabled = Enabling
        'txtNbrofRecurringMonth.Enabled = Enabling
        txtNextDiscountCode.Enabled = Enabling
        'txtPayable.Enabled = Enabling
        'txtStatus.Enabled = Enabling
        txtText_EN.Enabled = Enabling
        txtText_Fr.Enabled = Enabling
        txtText_NL.Enabled = Enabling
        txtFooter.Enabled = Enabling
        'txtValidity_TO.Enabled = Enabling
        txtValidityTo_Type.Enabled = Enabling
        'txtValidityTo_Value.Enabled = Enabling
        cmbGroup_Partner.Enabled = Enabling
        cmbDiscount_Type.Enabled = Enabling




        txtValidityTo.Enabled = Enabling
        txtNbrRecuring2.Enabled = Enabling
        txtNbrMonthReuse.Enabled = Enabling
        txtCommitment2.Enabled = Enabling
        txtCreditDVD2.Enabled = Enabling
        txtDiscountValue2.Enabled = Enabling
        txtLimit2.Enabled = Enabling
        txtValidityTo_Value2.Enabled = Enabling
        txtGotToStep2.Enabled = Enabling
        txtLitingProductsAllowed2.Enabled = Enabling


        CheckByPassDiscountUse.Enabled = Enabling
        CheckCAutoStop.Enabled = Enabling
        CheckCreditZero_AutoReconduction.Enabled = Enabling
        CheckDiscountStatus.Enabled = Enabling
        CheckFreeUpgradeAllowed.Enabled = Enabling
        CheckLandingPage.Enabled = Enabling
        CheckPayable.Enabled = Enabling
        CheckPayable.Enabled = Enabling
    End Sub


    Private Sub loadTextBoxInfo(ByVal dr As DataRow)

        txtDiscount_Code.EditValue = clsMarketing.clsDiscountCode.GetDiscountCode(dr) 'dr("discount_code")
        cmbDiscount_Type.EditValue = clsMarketing.clsDiscountCode.GetDiscountType(dr) 'dr("discount_type")
        txtDiscountValue2.EditValue = clsMarketing.clsDiscountCode.GetDiscountValue(dr) 'dr("discount_value")
        txtLimit2.EditValue = clsMarketing.clsDiscountCode.GetDiscountLimit(dr) 'dr("discount_limit")
        txtCommitment2.EditValue = clsMarketing.clsDiscountCode.GetDiscountCommitment(dr) 'dr("discount_commitment")
        txtComment.EditValue = clsMarketing.clsDiscountCode.GetCommentDiscount(dr) 'dr("comment")
        txtText_Fr.EditValue = clsMarketing.clsDiscountCode.GetDiscountTxtFr(dr)
        txtText_NL.EditValue = clsMarketing.clsDiscountCode.GetDiscountTxtNl(dr) 'dr("discount_text_nl")
        txtText_EN.EditValue = clsMarketing.clsDiscountCode.GetDiscountTxtEn(dr) 'dr("discount_text_en")
        txtBanner.EditValue = clsMarketing.clsDiscountCode.GetBanner(dr) 'dr("banner")
        txtFooter.EditValue = clsMarketing.clsDiscountCode.GetFooter(dr) 'dr("Footer")
        CheckLandingPage.EditValue = clsMarketing.clsDiscountCode.GetLandingPage(dr) 'dr("landing_page")
        txtLandingPagePHP.EditValue = clsMarketing.clsDiscountCode.GetLandingPagePhp(dr)
        cmbGroup_Partner.EditValue = clsMarketing.clsDiscountCode.GetGroupId(dr) 'dr("group_id")
        txtValidityTo_Type.EditValue = clsMarketing.clsDiscountCode.GetDiscountValitdityType(dr) 'dr("discount_abo_validityto_type")
        txtValidityTo_Value2.EditValue = clsMarketing.clsDiscountCode.GetDiscountValidityValue(dr) ' dr("discount_abo_validityto_value")
        txtNbrMonthReuse.EditValue = clsMarketing.clsDiscountCode.GetNbrMonthBeforeReuse(dr) 'dr("discount_nbr_month_before_reuse")
        txtNbrRecuring2.EditValue = clsMarketing.clsDiscountCode.GetRecurringNbrOfMonth(dr) '("discount_recurring_nbr_of_month")
        txtValidityTo.EditValue = clsMarketing.clsDiscountCode.GetValidityTo(dr) 'dr("discount_validityto")
        txtCreditDVD2.EditValue = clsMarketing.clsDiscountCode.GetDvdCredit(dr) 'dr("abo_dvd_credit")
        txtNextDiscountCode.EditValue = clsMarketing.clsDiscountCode.GetNextDiscount(dr) 'dr("next_discount")
        txtLitingProductsAllowed2.EditValue = clsMarketing.clsDiscountCode.GetListingProductsAllowed(dr) 'dr("listing_products_allowed")
        'cmbProductsAllowed.EditValue = clsMarketing.clsDiscountCode.GetListingProductsAllowed(dr) 'dr("listing_products_allowed")
        txtGotToStep2.EditValue = clsMarketing.clsDiscountCode.GetGotoSep(dr) 'dr("goto_step")
        CheckCAutoStop.EditValue = clsMarketing.clsDiscountCode.GetAutoStop(dr) 'dr("abo_auto_stop_next_reconduction")
        CheckPayable.EditValue = clsMarketing.clsDiscountCode.GetPayable(dr) 'dr("payable")
        CheckCreditZero_AutoReconduction.EditValue = clsMarketing.clsDiscountCode.GetCredit0AutoReconduction(dr) 'dr("credit0_auto_reconduct")
        CheckByPassDiscountUse.EditValue = clsMarketing.clsDiscountCode.GetBypassDiscountUse(dr) 'dr("bypass_discountuse")
        CheckFreeUpgradeAllowed.EditValue = clsMarketing.clsDiscountCode.GetFreeUpGradeAllowed(dr) 'dr("free_upgrade_allowed")
        CheckDiscountStatus.EditValue = clsMarketing.clsDiscountCode.GetDiscountStatus(dr) 'dr("discount_status")


    End Sub


    Private Sub loadVarToUpdate()
        _discountCode = txtDiscount_Code.Text.Trim
        _discountType = cmbDiscount_Type.EditValue()
        _discountValue = txtDiscountValue2.EditValue
        _discountLimit = txtLimit2.EditValue
        _discountCommitment = txtCommitment2.EditValue
        _commentDiscount = txtComment.EditValue
        _discountTextFr = txtText_Fr.Text.Trim
        _discountTextNl = txtText_NL.Text.Trim
        _discountTextEn = txtText_EN.Text.Trim
        _bannerDiscount = txtBanner.Text.Trim
        _footerDiscount = txtFooter.Text.Trim
        _landingPage = CheckLandingPage.EditValue
        _landingPagePhp = txtLandingPagePHP.EditValue
        _groupId = cmbGroup_Partner.EditValue
        _discountAboValiditytoType = txtValidityTo_Type.EditValue
        _discountAboValiditytoValue = txtValidityTo_Value2.EditValue
        _iscountNbrMonthBeforeReuse = txtNbrMonthReuse.EditValue
        _discountRecurringNbrOfMonth = txtNbrRecuring2.EditValue
        _discountValidityTo = txtValidityTo.EditValue
        _aboDvdCredit = txtCreditDVD2.EditValue
        _nextDiscount = txtNextDiscountCode.EditValue
        _listingProductsAllowed = txtLitingProductsAllowed2.EditValue
        ' _listingProductsAllowed = cmbProductsAllowed.EditValue
        _gotoStep = txtGotToStep2.EditValue
        _aboAutoStopNextReconduction = CheckCAutoStop.EditValue
        _payable = CheckPayable.EditValue
        _credit0AutoReconduct = CheckCreditZero_AutoReconduction.EditValue
        _bypassDiscountuse = CheckByPassDiscountUse.EditValue
        _FreeUpgradeAllowed = CheckFreeUpgradeAllowed.EditValue
        _discountStatus = CheckDiscountStatus.EditValue

    End Sub



    Private Function UpdateDiscount(ByVal discount_code As String) As Boolean
        Dim ok As Boolean
        Dim cnt As Integer
        ok = DvdPostData.clsConnection.ExecuteScalar(DvdPostData.clsActivationCode.GetExistNewDiscount(discount_code))
        If ok Then


            Dim sql As String
            sql = DvdPostData.clsActivationCode.updateDiscountCode(_discountCode, _discountType, _
                                                                   _discountValue, _discountLimit, _discountCommitment, _
                                                                   _discountStatus, _discountTextFr, _discountTextNl, _discountTextEn, _
                                                                   _discountAboValiditytoType, _discountAboValiditytoValue, _commentDiscount, _iscountNbrMonthBeforeReuse, _
                                                                   _discountRecurringNbrOfMonth, _bypassDiscountuse, _discountValidityTo, _payable, _aboDvdCredit, _
                                                                   _nextDiscount, _credit0AutoReconduct, _landingPage, _landingPagePhp, _listingProductsAllowed, _
                                                                   _aboAutoStopNextReconduction, _gotoStep, _bannerDiscount, _footerDiscount, _FreeUpgradeAllowed, _groupId)
            DvdPostData.clsConnection.CreateTransaction(True)
            cnt = DvdPostData.clsConnection.ExecuteNonQuery(sql)
            DvdPostData.clsConnection.ExecuteBulkQuery(DvdPostData.clsMsgError.processType.Discount, cnt)
            Return ok
        Else
            Return ok
        End If

    End Function






    Private Sub GridViewDiscount_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewDiscount.DoubleClick
        loaDInfoDiscountMaint()
    End Sub
    Private Function GetInfoDiscount(ByVal discount_id As Integer) As DataRow

        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsActivationCode.GetDiscountSearch(discount_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt.Rows(0)
    End Function


    Public Sub loaDInfoDiscountMaint()
        Me.TabControl1.SelectTab(Me.tabDiscount)
        Dim discount_code_id As Integer
        'Dim discountID As Integer
        If GridViewDiscount.RowCount > 0 Then
            Dim dr As DataRow
            discount_code_id = Me.GridViewDiscount.GetDataRow(Me.GridViewDiscount.FocusedRowHandle)("discount_code_id")
            dr = GetInfoDiscount(discount_code_id)
            loadTextBoxInfo(dr)
        End If
    End Sub




    Private Sub loadDiscountExpiration() 'by gauthier
        Dim dt As DataTable
        Dim sqlDiscountExp As String = DvdPostData.clsActivationCode.GetDiscountExpiration()
        dt = DvdPostData.clsConnection.FillDataSet(sqlDiscountExp)
        GridControl1.MainView = GridViewDiscount
        GridControl1.DataSource = dt
        AddHandler GridViewDiscount.RowStyle, AddressOf GridView1_RowStyle

        TabControl1.SelectedTab = tabResult
    End Sub

    Private Sub loadAllDiscount()
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsActivationCode.GetDiscountCodeDesc()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridControl1.MainView = GridViewDiscount
        GridControl1.DataSource = dt

    End Sub

    Private Sub GridView1_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) 'Handles GridView1.RowStyle 'by gauthier
        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender
        If (e.RowHandle >= 0) Then
            Dim validitytoString As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("discount_validityto")).ToString

            If validitytoString <> "" Then
                Dim validityToDate As Date = CType(validitytoString, Date)
                If validityToDate >= Date.Now Then
                    e.Appearance.BackColor = Drawing.Color.LightGreen 'System.Drawing.Color.FromArgb(255, 204, 204)
                    'Drawing.Color.LightGreen ' color rvb 255r 156g 90b
                    e.Appearance.BackColor2 = Drawing.Color.SeaShell
                End If

                If validityToDate < Date.Now Then
                    e.Appearance.BackColor = Drawing.Color.LightSalmon 'System.Drawing.Color.FromArgb(204, 153, 204)
                    'Drawing.Color.LightSalmon ' color rvb 229r 227g 102b
                    e.Appearance.BackColor2 = Drawing.Color.SeaShell
                End If

            End If
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        search()
    End Sub

    Public Sub search()
        Dim discountCode As String
        Dim groupPartnerId As String
        Dim discountId As String
        Dim dt As DataTable
        Dim sqlDiscount As String
        Dim validityFrom As String
        Dim validityTo As String

        Dim param As DVDPostBuziness.clsSingleton
        param = DVDPostBuziness.clsSingleton.Instance()

        If param.Activation_Discount_id = Nothing Then
            discountId = txtDiscountIdSearch.Text.Trim
        Else
            discountId = param.Activation_Discount_id
            param.Activation_Discount_id = Nothing
        End If

        discountCode = txtDiscountCodeSearch.Text.Trim
        groupPartnerId = cmbGroupIDsearch.EditValue
        validityFrom = txtFromDate.EditValue
        validityTo = txtToDate.EditValue


        sqlDiscount = DvdPostData.clsActivationCode.GetDiscountSearch(discountId, discountCode, groupPartnerId, validityFrom, validityTo)

        GridControl1.MainView = GridViewDiscount
        dt = DvdPostData.clsConnection.FillDataSet(sqlDiscount)
        GridControl1.DataSource = dt



        TabControl1.SelectedTab = tabResult
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        search()
    End Sub


    Private Sub btnDiscountExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiscountExp.Click
        loadDiscountExpiration()
    End Sub

    Private Sub btnLoadAllDisc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadAllDisc.Click
        loadAllDiscount()
        TabControl1.SelectedTab = tabResult
    End Sub


    Private Sub btnEditDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditDiscount.Click
        EnablingEditFields(True)
        btnEditDiscount.Enabled = False
        btnUndoDiscount.Enabled = True
        btnSaveDiscount.Enabled = True
        btnNewDiscount.Enabled = False
    End Sub

    Private Sub btnUndoDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndoDiscount.Click
        EnablingEditFields(False)
        loaDInfoDiscountMaint()
        btnEditDiscount.Enabled = True
        btnUndoDiscount.Enabled = True
        btnSaveDiscount.Enabled = False
        btnNewDiscount.Enabled = True
    End Sub

    Private Sub btnSaveDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDiscount.Click
        If txtDiscount_Code.Enabled = True Then
            If txtText_Fr.EditValue = "" Or txtText_NL.EditValue = "" Or txtText_EN.EditValue = "" Then



                MsgBox("text fr , nl ,en can not be empty ")
            Else
                Try

                    Dim Exist As Boolean
                    'Dim sql As String
                    'Dim discountId As Integer

                    loadVarToUpdate()
                    'discountId = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("discount_code_id")
                    Exist = UpdateDiscount(_discountCode)

                    If Exist Then
                        MsgBox(" update ok ")
                    Else
                        insertNewCode()
                        MsgBox("new discount_code: " & _discountCode & " created")
                    End If
                Catch ex As Exception
                    DVDPostBuziness.clsMsgError.MsgBox(ex.Message)
                    DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Discount, ex)
                End Try


                EnablingEditFields(False)
                loadAllDiscount()
            End If
        End If

        btnEditDiscount.Enabled = True
        btnUndoDiscount.Enabled = True
        btnSaveDiscount.Enabled = False
        btnNewDiscount.Enabled = True
    End Sub

    Private Sub btnNewDiscount_clickByVal(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewDiscount.Click
        EnablingEditFields(True)
        txtDiscount_Code.EditValue = DvdPostData.clsActivationCode.NEWDISCOUNT


        btnEditDiscount.Enabled = False
        btnUndoDiscount.Enabled = True
        btnSaveDiscount.Enabled = True
        btnNewDiscount.Enabled = False
    End Sub


    Private Sub insertNewCode()
        Dim sql As String
        Dim cnt As Integer

        sql = DvdPostData.clsActivationCode.insertDiscount(_discountCode, _discountType, _
                                                                   _discountValue, _discountLimit, _discountCommitment, _
                                                                   _discountStatus, _discountTextFr, _discountTextNl, _discountTextEn, _
                                                                   _discountAboValiditytoType, _discountAboValiditytoValue, _commentDiscount, _iscountNbrMonthBeforeReuse, _
                                                                   _discountRecurringNbrOfMonth, _bypassDiscountuse, _discountValidityTo, _payable, _aboDvdCredit, _
                                                                   _nextDiscount, _credit0AutoReconduct, _landingPage, _landingPagePhp, _listingProductsAllowed, _
                                                                   _aboAutoStopNextReconduction, _gotoStep, _bannerDiscount, _footerDiscount, _FreeUpgradeAllowed, _groupId)
        DvdPostData.clsConnection.CreateTransaction(True)
        cnt = DvdPostData.clsConnection.ExecuteNonQuery(sql)
        DvdPostData.clsConnection.ExecuteBulkQuery(DvdPostData.clsMsgError.processType.Feesharing, cnt)

    End Sub












    Private Function GetShoppingDiscount(Optional ByVal shopping_discount_id As Integer = 0) As DataTable
        Dim dt As DataTable
        Dim sql As String

        sql = DvdPostData.clsActivationCode.GetshoppingDIscount(shopping_discount_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)


        Return dt
    End Function

    Private Sub loadGridViewShopping()

        GridControl1.MainView = GridViewShoppingDiscount
        GridControl1.DataSource = GetShoppingDiscount()
        GridViewShoppingDiscount.PopulateColumns()
    End Sub

    Private Sub btnViewShoppingDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewShoppingDiscount.Click
        loadGridViewShopping()
        TabControl1.SelectedTab = tabResult
    End Sub


    Private Sub GridViewShoppingDiscount_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewShoppingDiscount.DoubleClick
        loadInfoshoppingDiscount()

    End Sub

    Private Sub loadInfoshoppingDiscount()
        Dim shopping_discount_id As Integer
        Dim dt As DataTable

        If GridViewShoppingDiscount.RowCount > 0 Then
            shopping_discount_id = GridViewShoppingDiscount.GetDataRow(GridViewShoppingDiscount.FocusedRowHandle())("shopping_discount_id")
            dt = GetShoppingDiscount(shopping_discount_id)
            loadTextBoxShoppingDiscount(dt)
            TabControl1.SelectedTab = TabShoppingDiscount
        End If
    End Sub

    Private Sub loadTextBoxShoppingDiscount(ByVal dt As DataTable)
        Dim dr As DataRow

        dr = dt.Rows(0)
        txtShoppingDiscount.EditValue = clsMarketing.clsDiscountCode.GetDiscountCode(dr)
        cmbShoppingDiscountType.EditValue = clsMarketing.clsDiscountCode.GetDiscountType(dr)
        SpinShoppingDiscountValue.EditValue = clsMarketing.clsDiscountCode.GetDiscountValue(dr)
        txtShoppingDiscountEn.EditValue = clsMarketing.clsDiscountCode.GetDiscountTxtEn(dr)
        txtShoppingDiscountFr.EditValue = clsMarketing.clsDiscountCode.GetDiscountTxtFr(dr)
        txtShoppingDiscountNl.EditValue = clsMarketing.clsDiscountCode.GetDiscountTxtNl(dr)
        CheckShoppingDiscountStatus.EditValue = clsMarketing.clsDiscountCode.GetDiscountStatus(dr)
        dateShoppingDiscountValidityTo.EditValue = clsMarketing.clsDiscountCode.GetShoppingDiscountValidityTo(dr)

    End Sub


    Private Sub loadVarShoppingDiscount()

        _shoppingdiscountCode = txtShoppingDiscount.Text.Trim
        _shoppingDiscountType = cmbShoppingDiscountType.EditValue
        _shoppingDiscountValue = SpinShoppingDiscountValue.EditValue
        _shoppingDiscountTextFR = txtShoppingDiscountFr.EditValue
        _shoppingDiscountTextNl = txtShoppingDiscountNl.EditValue
        _shoppingDiscountTextEn = txtShoppingDiscountEn.EditValue
        _shoppingDiscountValidityTo = dateShoppingDiscountValidityTo.EditValue
        _shoppingDiscountStatus = CheckShoppingDiscountStatus.EditValue

    End Sub


    Private Function updatedShoppingDiscount(ByVal shopping_discount_code As String) As Boolean
        Dim ok As Boolean
        Dim cnt As Integer
        ok = DvdPostData.clsConnection.ExecuteScalar(DvdPostData.clsActivationCode.GetExistShoppingDiscount(shopping_discount_code))
        If ok Then


            Dim sql As String
            sql = DvdPostData.clsActivationCode.updateShoppingDiscount(shopping_discount_code, _shoppingDiscountType, _
                                                                                 _shoppingDiscountValue, _shoppingDiscountStatus, _
                                                                                 _shoppingDiscountTextFR, _shoppingDiscountTextNl, _shoppingDiscountTextEn, _
                                                                                 _shoppingDiscountValidityTo)

            DvdPostData.clsConnection.CreateTransaction(True)
            cnt = DvdPostData.clsConnection.ExecuteNonQuery(sql)
            DvdPostData.clsConnection.ExecuteBulkQuery(DvdPostData.clsMsgError.processType.Discount, cnt)
            Return ok
        Else
            Return False
        End If


    End Function

    Private Sub insertNewShoppingDiscount()
        Dim sql As String
        Dim cnt As Integer
        sql = DvdPostData.clsActivationCode.insertShoppingDiscount(_shoppingdiscountCode, _shoppingDiscountType, _
                                                                                 _shoppingDiscountValue, _shoppingDiscountStatus, _
                                                                                 _shoppingDiscountTextFR, _shoppingDiscountTextNl, _shoppingDiscountTextEn, _
                                                                                 _shoppingDiscountValidityTo)
        DvdPostData.clsConnection.CreateTransaction(True)
        cnt = DvdPostData.clsConnection.ExecuteNonQuery(sql)
        DvdPostData.clsConnection.ExecuteBulkQuery(DvdPostData.clsMsgError.processType.Discount, cnt)

    End Sub

    Private Sub enablingShoppingDiscountfields(ByVal enabling As Boolean)
        txtShoppingDiscount.Enabled = enabling
        cmbShoppingDiscountType.Enabled = enabling
        SpinShoppingDiscountValue.Enabled = enabling
        txtShoppingDiscountEn.Enabled = enabling
        txtShoppingDiscountFr.Enabled = enabling
        txtShoppingDiscountNl.Enabled = enabling
        CheckShoppingDiscountStatus.Enabled = enabling
        dateShoppingDiscountValidityTo.Enabled = enabling
    End Sub


    Private Sub btnShoppingSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShoppingSave.Click
        If txtShoppingDiscount.Enabled = True Then
            If txtShoppingDiscountEn.EditValue = "" Or txtShoppingDiscountFr.EditValue = "" Or txtShoppingDiscountNl.EditValue = "" Then
                MsgBox("text fr , nl ,en can not be empty ")
            Else

                Try
                    Dim Exist As Boolean
                    'Dim sql As String
                    'Dim discountId As Integer

                    loadVarShoppingDiscount()
                    'discountId = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("discount_code_id")
                    Exist = updatedShoppingDiscount(_shoppingdiscountCode)

                    If Exist Then
                        MsgBox(" update ok ")
                    Else
                        insertNewShoppingDiscount()
                        MsgBox("new shopping_discount_code: " & _shoppingdiscountCode & " created")
                    End If
                Catch ex As Exception
                    DVDPostBuziness.clsMsgError.MsgBox(ex.Message)
                    DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Discount, ex)
                End Try
                '
                'loaDInfoMaint()
                enablingShoppingDiscountfields(False)

                loadGridViewShopping()
            End If
        End If

        btnShoppingEdit.Enabled = True
        btnShoppingSave.Enabled = False
        btnShoppingNew.Enabled = True
        btnShoppingUndo.Enabled = True
    End Sub



    Private Sub btnShoppingNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShoppingNew.Click
        txtShoppingDiscount.EditValue = DvdPostData.clsActivationCode.NEWDISCOUNT
        enablingShoppingDiscountfields(True)

        btnShoppingEdit.Enabled = False
        btnShoppingSave.Enabled = True
        btnShoppingNew.Enabled = False
        btnShoppingUndo.Enabled = True

    End Sub

    Private Sub btnShoppingEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShoppingEdit.Click
        enablingShoppingDiscountfields(True)

        btnShoppingEdit.Enabled = False
        btnShoppingSave.Enabled = True
        btnShoppingNew.Enabled = False
        btnShoppingUndo.Enabled = True
    End Sub

    Private Sub btnShoppingUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShoppingUndo.Click
        loadInfoshoppingDiscount()
        enablingShoppingDiscountfields(False)

        btnShoppingEdit.Enabled = True
        btnShoppingSave.Enabled = False
        btnShoppingNew.Enabled = True
        btnShoppingUndo.Enabled = True

    End Sub


End Class
