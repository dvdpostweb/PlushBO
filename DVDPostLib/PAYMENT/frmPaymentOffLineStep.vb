Public Class frmPaymentOffLineStep
    Inherits BizzLib.frmBKForm

    Dim _parameters As PlushBuziness.clsSingleton
    Dim _OffLinePay As PlushBuziness.clsOffLinePayments
    Dim _ListActionUser() As DevExpress.XtraBars.BarButtonItem = {btnUser1, btnUser2, btnUser3, btnUser4, btnUser5}

    Dim WithEvents _ExportExcel As DevExpress.XtraBars.BarButtonItem = MainBtns_btnExcel
    Dim WithEvents _Print As DevExpress.XtraBars.BarButtonItem = btnPrint

    Dim WithEvents _user1 As DevExpress.XtraBars.BarButtonItem = btnUser1
    Dim WithEvents _user2 As DevExpress.XtraBars.BarButtonItem = btnUser2
    Dim WithEvents _user3 As DevExpress.XtraBars.BarButtonItem = btnUser3
    Dim WithEvents _user4 As DevExpress.XtraBars.BarButtonItem = btnUser4
    Dim WithEvents _user5 As DevExpress.XtraBars.BarButtonItem = btnUser5


    Private Sub DisplayControl()
        Me.Misc_Bar.Visible = True
        MainBtns_btnBestFit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MainBtns_btnBigger.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MainBtns_btnSmaller.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnExportXML.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnImportXML.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

    End Sub

    Private Sub Print_click(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _Print.ItemClick
        PlushBuziness.clsExport.Print(GridPaymentDetail)
    End Sub
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '  Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        DisplayControl()
        Dim menuStrip As New PlushBuziness.contextMenu()
        GridPaymentDetail.ContextMenuStrip = menuStrip
        _parameters = PlushBuziness.clsSingleton.Instance()


        _OffLinePay = New PlushBuziness.clsOffLinePayments()
        loadAction(_OffLinePay.GetStep(_parameters.TypeStepPaymentOffline))
        loadDataset(_parameters.isSummary)

    End Sub

    Private Sub loadAction(ByVal listAction As String())

        If listAction Is Nothing Then Return
        For index As Integer = 0 To listAction.Length - 1
            _ListActionUser(index).Caption = listAction(index)
            _ListActionUser(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Next


    End Sub

    Private Sub loadDataset(ByVal isSummary As Boolean)
        Dim dt As DataTable
        Dim sql As String = ""
        If _parameters.TypeStepPaymentOffline = PlushData.PaymentOfflineData.StepPayment.ALL_RECOVERY Then
            sql = PlushData.PaymentOfflineData.GetStepPaymentALL()
        Else
            If isSummary Then
                sql = PlushData.PaymentOfflineData.GetStepPaymentSummary(_parameters.TypeStepPaymentOffline)
            Else
                sql = PlushData.PaymentOfflineData.GetStepPayment(_parameters.TypeStepPaymentOffline)
            End If

        End If

        dt = PlushData.clsConnection.FillDataSet(sql)
        GridPaymentDetail.DataSource = dt
        GridViewPaymentDetail.BestFitColumns()
        clsDevExpress.AddHyperlinkDynamic(GridPaymentDetail)
        '   GridViewPaymentDetail.ExpandAllGroups()

        '    dt.TableName = TableName
        '    objDS.Tables.Add(dt)
        '    'Grid1.DataSource = objDS.Tables(TableName).DefaultView
        '    Grid1.DataSource = dt.DefaultView
        '    TabControl1.SelectedTabPage = TabResult
    End Sub

    Public Sub btnUser1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _user1.ItemClick

        _OffLinePay.ExecuteStep(GridViewPaymentDetail, _user1.Caption)
        ' loadDataset()
    End Sub

    Private Sub btnUser2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _user2.ItemClick

        _OffLinePay.ExecuteStep(GridViewPaymentDetail, _user2.Caption)
        ' loadDataset()
    End Sub

    Private Sub btnUser3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _user3.ItemClick

        _OffLinePay.ExecuteStep(GridViewPaymentDetail, _user3.Caption)
        '  loadDataset()
    End Sub

    Private Sub btnUser4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _user4.ItemClick

        _OffLinePay.ExecuteStep(GridViewPaymentDetail, _user4.Caption)
        ' loadDataset()
    End Sub

    Private Sub btnUser5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _user5.ItemClick

        _OffLinePay.ExecuteStep(GridViewPaymentDetail, _user5.Caption)
        '  loadDataset()
    End Sub

    Private Sub btnexcel_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _ExportExcel.ItemClick
        SFDExportExcel.DefaultExt = "xls"
        SFDExportExcel.Filter = "Excel(*.xls)|*.xls"

        If SFDExportExcel.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GridPaymentDetail.ExportToXls(SFDExportExcel.FileName)
        End If


        '  loadDataset()
    End Sub


    Public Sub gridviewPaymentDetail_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewPaymentDetail.DoubleClick
        If GridViewPaymentDetail.FocusedRowHandle < 0 Then
            Exit Sub
        End If
        Dim customers_id As Integer = GridViewPaymentDetail.GetDataRow(GridViewPaymentDetail.FocusedRowHandle)("customers_id")
        ClsCustomers.openFrmCustMaint(customers_id, Me.ParentForm, SessionInfo)

        'Dim _frm As New frmCustomers_Maint(SessionInfo)
        '_frm.MdiParent = Me.ParentForm
        '_frm.Text = "Cust. Maint"
        '_frm.Show()
        '_frm.txtQuickSearch.EditValue = GridView1.GetDataRow(GridView1.FocusedRowHandle)("customers_id")
        '_frm._CurrentCustomerID = _frm.txtQuickSearch.EditValue
        '_frm.LoadCustomerInfo()
        '_frm.XtraTabControl1.SelectedTabPage = _frm.tabMain
    End Sub
End Class