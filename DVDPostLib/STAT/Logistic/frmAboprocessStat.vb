
Public Class frmAboprocessStat
    Inherits BizzLib.frmGeneral_Browse

    Public Type_Dvd As PlushData.clsProductDvd.Type_DVD

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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnViewClientServed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAverageRotationTime As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnWishListSize As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDvdSent As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents btnWlRankNoServed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLongtimeDvd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLongtimeProduct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProductNoDVDFound As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnWlRankServed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCustNotServed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnwhoisnotserved As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnWishListByPriorityByProduct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAboprocessStat))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnwhoisnotserved = New DevExpress.XtraEditors.SimpleButton
        Me.btnProductNoDVDFound = New DevExpress.XtraEditors.SimpleButton
        Me.btnCustNotServed = New DevExpress.XtraEditors.SimpleButton
        Me.btnWlRankServed = New DevExpress.XtraEditors.SimpleButton
        Me.btnWlRankNoServed = New DevExpress.XtraEditors.SimpleButton
        Me.BtnDvdSent = New DevExpress.XtraEditors.SimpleButton
        Me.BtnWishListSize = New DevExpress.XtraEditors.SimpleButton
        Me.BtnAverageRotationTime = New DevExpress.XtraEditors.SimpleButton
        Me.BtnViewClientServed = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.btnLongtimeDvd = New DevExpress.XtraEditors.SimpleButton
        Me.btnLongtimeProduct = New DevExpress.XtraEditors.SimpleButton
        Me.btnWishListByPriorityByProduct = New DevExpress.XtraEditors.SimpleButton
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
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        Me.TabControl1.Controls.SetChildIndex(Me.XtraTabPage1, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabChart, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabAnalyse, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabResult, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabParameters, 0)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.btnWishListByPriorityByProduct)
        Me.TabParameters.Controls.Add(Me.btnLongtimeProduct)
        Me.TabParameters.Controls.Add(Me.btnLongtimeDvd)
        Me.TabParameters.Controls.Add(Me.GroupControl1)
        resources.ApplyResources(Me.TabParameters, "TabParameters")
        '
        'TabResult
        '
        resources.ApplyResources(Me.TabResult, "TabResult")
        '
        'TabAnalyse
        '
        Me.TabAnalyse.PageVisible = False
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
        Me.TabChart.PageVisible = False
        resources.ApplyResources(Me.TabChart, "TabChart")
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.btnwhoisnotserved)
        Me.GroupControl1.Controls.Add(Me.btnProductNoDVDFound)
        Me.GroupControl1.Controls.Add(Me.btnCustNotServed)
        Me.GroupControl1.Controls.Add(Me.btnWlRankServed)
        Me.GroupControl1.Controls.Add(Me.btnWlRankNoServed)
        Me.GroupControl1.Controls.Add(Me.BtnDvdSent)
        Me.GroupControl1.Controls.Add(Me.BtnWishListSize)
        Me.GroupControl1.Controls.Add(Me.BtnAverageRotationTime)
        Me.GroupControl1.Controls.Add(Me.BtnViewClientServed)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtToDate)
        Me.GroupControl1.Controls.Add(Me.txtFromDate)
        Me.GroupControl1.Name = "GroupControl1"
        Me.HelpProvider1.SetShowHelp(Me.GroupControl1, CType(resources.GetObject("GroupControl1.ShowHelp"), Boolean))
        '
        'btnwhoisnotserved
        '
        resources.ApplyResources(Me.btnwhoisnotserved, "btnwhoisnotserved")
        Me.btnwhoisnotserved.Name = "btnwhoisnotserved"
        Me.HelpProvider1.SetShowHelp(Me.btnwhoisnotserved, CType(resources.GetObject("btnwhoisnotserved.ShowHelp"), Boolean))
        '
        'btnProductNoDVDFound
        '
        resources.ApplyResources(Me.btnProductNoDVDFound, "btnProductNoDVDFound")
        Me.btnProductNoDVDFound.Name = "btnProductNoDVDFound"
        Me.HelpProvider1.SetShowHelp(Me.btnProductNoDVDFound, CType(resources.GetObject("btnProductNoDVDFound.ShowHelp"), Boolean))
        '
        'btnCustNotServed
        '
        resources.ApplyResources(Me.btnCustNotServed, "btnCustNotServed")
        Me.btnCustNotServed.Name = "btnCustNotServed"
        Me.HelpProvider1.SetShowHelp(Me.btnCustNotServed, CType(resources.GetObject("btnCustNotServed.ShowHelp"), Boolean))
        '
        'btnWlRankServed
        '
        resources.ApplyResources(Me.btnWlRankServed, "btnWlRankServed")
        Me.btnWlRankServed.Name = "btnWlRankServed"
        Me.HelpProvider1.SetShowHelp(Me.btnWlRankServed, CType(resources.GetObject("btnWlRankServed.ShowHelp"), Boolean))
        '
        'btnWlRankNoServed
        '
        resources.ApplyResources(Me.btnWlRankNoServed, "btnWlRankNoServed")
        Me.btnWlRankNoServed.Name = "btnWlRankNoServed"
        Me.HelpProvider1.SetShowHelp(Me.btnWlRankNoServed, CType(resources.GetObject("btnWlRankNoServed.ShowHelp"), Boolean))
        '
        'BtnDvdSent
        '
        resources.ApplyResources(Me.BtnDvdSent, "BtnDvdSent")
        Me.BtnDvdSent.Name = "BtnDvdSent"
        Me.HelpProvider1.SetShowHelp(Me.BtnDvdSent, CType(resources.GetObject("BtnDvdSent.ShowHelp"), Boolean))
        '
        'BtnWishListSize
        '
        resources.ApplyResources(Me.BtnWishListSize, "BtnWishListSize")
        Me.BtnWishListSize.Name = "BtnWishListSize"
        Me.HelpProvider1.SetShowHelp(Me.BtnWishListSize, CType(resources.GetObject("BtnWishListSize.ShowHelp"), Boolean))
        '
        'BtnAverageRotationTime
        '
        resources.ApplyResources(Me.BtnAverageRotationTime, "BtnAverageRotationTime")
        Me.BtnAverageRotationTime.Name = "BtnAverageRotationTime"
        Me.HelpProvider1.SetShowHelp(Me.BtnAverageRotationTime, CType(resources.GetObject("BtnAverageRotationTime.ShowHelp"), Boolean))
        '
        'BtnViewClientServed
        '
        resources.ApplyResources(Me.BtnViewClientServed, "BtnViewClientServed")
        Me.BtnViewClientServed.Name = "BtnViewClientServed"
        Me.HelpProvider1.SetShowHelp(Me.BtnViewClientServed, CType(resources.GetObject("BtnViewClientServed.ShowHelp"), Boolean))
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
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.ChartControl1)
        Me.XtraTabPage1.Controls.Add(Me.PivotGridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.PageVisible = False
        resources.ApplyResources(Me.XtraTabPage1, "XtraTabPage1")
        '
        'ChartControl1
        '
        XyDiagram1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram1.AxisY.Range.SideMarginsEnabled = True
        Me.ChartControl1.Diagram = XyDiagram1
        resources.ApplyResources(Me.ChartControl1, "ChartControl1")
        Me.ChartControl1.Name = "ChartControl1"
        Series1.Name = "Series 1"
        Series2.Name = "Series 2"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.PivotGridControl1, "PivotGridControl1")
        Me.PivotGridControl1.Name = "PivotGridControl1"
        '
        'btnLongtimeDvd
        '
        resources.ApplyResources(Me.btnLongtimeDvd, "btnLongtimeDvd")
        Me.btnLongtimeDvd.Name = "btnLongtimeDvd"
        Me.HelpProvider1.SetShowHelp(Me.btnLongtimeDvd, CType(resources.GetObject("btnLongtimeDvd.ShowHelp"), Boolean))
        '
        'btnLongtimeProduct
        '
        resources.ApplyResources(Me.btnLongtimeProduct, "btnLongtimeProduct")
        Me.btnLongtimeProduct.Name = "btnLongtimeProduct"
        Me.HelpProvider1.SetShowHelp(Me.btnLongtimeProduct, CType(resources.GetObject("btnLongtimeProduct.ShowHelp"), Boolean))
        '
        'btnWishListByPriorityByProduct
        '
        resources.ApplyResources(Me.btnWishListByPriorityByProduct, "btnWishListByPriorityByProduct")
        Me.btnWishListByPriorityByProduct.Name = "btnWishListByPriorityByProduct"
        Me.HelpProvider1.SetShowHelp(Me.btnWishListByPriorityByProduct, CType(resources.GetObject("btnWishListByPriorityByProduct.ShowHelp"), Boolean))
        '
        'frmAboprocessStat
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmAboprocessStat"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabChart.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New PlushBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        TabParameters.PageVisible = True
        '  CanNew = False
        '  CanEdit = False
        MyBase.TableName = "xx"
        MyBase.AutoLoadData = False
        objDS = New DataSet
        objDS.Tables.Add(MyBase.TableName)
        MyBase.StartUp()



        txtFromDate.DateTime = Now().ToString(txtFromDate.Properties.EditFormat.FormatString)
        txtToDate.DateTime = Now().ToString(txtFromDate.Properties.EditFormat.FormatString)

        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)
        'CurrentDefaultSetID = cmbDefaultList.EditValue

        GridView1.OptionsView.ShowFooter = True
        'btnOK
        ' Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '  If CurrentDefaultSetID <> 0 Then
        ' BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
        'LoadDataSet()


        '  TabControl1.SelectedTabPage = TabResult
        '  Else
        TabControl1.SelectedTabPage = TabParameters
        ' End If
    End Sub
    Private Sub ManagePivotGrid(ByVal dt As DataTable)

        PivotGridControl1.DataSource = dt
        PivotGridControl1.RetrieveFields()

        For Each f As DevExpress.XtraPivotGrid.PivotGridField In PivotGridControl1.Fields
            f.Visible = False
        Next
        ChartControl1.DataSource = dt
        ChartControl1.SeriesDataMember = "Series"
        ChartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
        ChartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
        ' Format display values.
        ChartControl1.SeriesTemplate.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        ChartControl1.SeriesTemplate.PointOptions.ValueNumericOptions.Precision = 0

    End Sub

    Private Sub loadData(ByVal sql As String)

        Dim dt As DataTable
        dt = PlushData.clsConnection.FillDataSet(sql, PlushData.clsConnection.typeAccessDb.WRITE)

        Grid1.DataSource = Nothing
        Grid1.Views(0).PopulateColumns()

        Grid1.DataSource = dt

        ' ManagePivotGrid(dt)

        TabControl1.SelectedTabPage = TabResult
        clsDevExpress.AddHyperlinkDynamic(Grid1)

    End Sub

    Private Sub BtnViewClientServed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewClientServed.Click
        Dim sql As String
        sql = PlushData.clsStatLogisticAboProcess.getSelectAboProcessServed(txtFromDate.EditValue, txtToDate.EditValue, type_dvd)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)
    End Sub

    Private Sub BtnAverageRotationTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAverageRotationTime.Click
        Dim sql As String
        sql = PlushData.clsStatLogisticAboProcess.getSelectRateRotationAverage(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)
    End Sub

    Private Sub BtnWishListSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWishListSize.Click
        Dim sql As String
        sql = PlushData.clsStatLogisticAboProcess.getSelectSizeWishlistNoServed(txtFromDate.EditValue, txtToDate.EditValue, type_dvd)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)
    End Sub

    Private Sub BtnDvdSent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDvdSent.Click
        Dim sql As String
        sql = PlushData.clsStatLogisticAboProcess.getSelectedHighMediumLowDVDSent(txtFromDate.EditValue, txtToDate.EditValue, type_dvd)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)
    End Sub


    Private Sub btnWlRankNoServed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWlRankNoServed.Click
        Dim sql As String
        sql = PlushData.clsStatLogisticAboProcess.getSelectNoServedWlRank(txtFromDate.EditValue, txtToDate.EditValue, type_dvd)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)

    End Sub


    Private Sub btnLongtimeDvd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLongtimeDvd.Click
        Dim sql As String
        sql = PlushData.clsStatLogisticAboProcess.getSelectTimeElapsedPerDVD(type_dvd)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)
    End Sub

    Private Sub btnLongtimeProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLongtimeProduct.Click
        Dim sql As String
        sql = PlushData.clsStatLogisticAboProcess.getSelectTimeElapsedPerProductAvailable(type_dvd)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)
    End Sub

    Private Sub btnProductNoDVDFound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductNoDVDFound.Click
        Dim sql As String
        sql = PlushData.clsStatLogisticAboProcess.getSelectProductsNoDvdFound(txtFromDate.EditValue, txtToDate.EditValue, type_dvd)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)
    End Sub

    Private Sub btnWlRankServed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWlRankServed.Click
        Dim sql As String
        sql = PlushData.clsStatLogisticAboProcess.getSelectServedWlRank(txtFromDate.EditValue, txtToDate.EditValue, type_dvd)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)

    End Sub

    Private Sub btnCustNotServed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustNotServed.Click
        Dim sql As String
        sql = PlushData.clsStatLogisticAboProcess.getselectCustomersNoServedRecurring(txtFromDate.EditValue, txtToDate.EditValue, type_dvd)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)

    End Sub

    Private Sub btnwhoisnotserved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwhoisnotserved.Click
        Dim sql As String
        sql = PlushData.clsStatLogisticAboProcess.getSelectCustomerNothingServed(txtFromDate.EditValue, txtToDate.EditValue, type_dvd)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWishListByPriorityByProduct.Click
        Dim sql As String
        sql = PlushData.clsStatLogisticAboProcess.getSelectCountWishlistByPriorityByProduct(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)
    End Sub
End Class
