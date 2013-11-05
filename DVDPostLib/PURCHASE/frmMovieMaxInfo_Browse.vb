Imports System.IO
Imports System.Collections.Generic
Public Class frmMovieMaxInfo_Browse
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
    Friend WithEvents btnProcessMovieMax As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMovieMAx As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLoadOrdersGlobalData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnGlobalDataProducts As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoadOrdersMoviemax As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDateMovieMaxTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnGlobalDataProcess As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovieMaxInfo_Browse))
        Me.btnProcessMovieMax = New DevExpress.XtraEditors.SimpleButton
        Me.btnMovieMAx = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnLoadOrdersMoviemax = New DevExpress.XtraEditors.SimpleButton
        Me.txtDateMovieMaxTo = New DevExpress.XtraEditors.DateEdit
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnGlobalDataProducts = New DevExpress.XtraEditors.SimpleButton
        Me.btnLoadOrdersGlobalData = New DevExpress.XtraEditors.SimpleButton
        Me.btnGlobalDataProcess = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDateMovieMaxTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateMovieMaxTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.TabParameters.Controls.Add(Me.GroupBox2)
        Me.TabParameters.Controls.Add(Me.GroupBox1)
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
        'btnProcessMovieMax
        '
        resources.ApplyResources(Me.btnProcessMovieMax, "btnProcessMovieMax")
        Me.btnProcessMovieMax.Name = "btnProcessMovieMax"
        Me.HelpProvider1.SetShowHelp(Me.btnProcessMovieMax, CType(resources.GetObject("btnProcessMovieMax.ShowHelp"), Boolean))
        '
        'btnMovieMAx
        '
        resources.ApplyResources(Me.btnMovieMAx, "btnMovieMAx")
        Me.btnMovieMAx.Name = "btnMovieMAx"
        Me.HelpProvider1.SetShowHelp(Me.btnMovieMAx, CType(resources.GetObject("btnMovieMAx.ShowHelp"), Boolean))
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.btnLoadOrdersMoviemax)
        Me.GroupBox1.Controls.Add(Me.txtToDate)
        Me.GroupBox1.Controls.Add(Me.btnMovieMAx)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.btnProcessMovieMax)
        Me.GroupBox1.Controls.Add(Me.txtFromDate)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'btnLoadOrdersMoviemax
        '
        resources.ApplyResources(Me.btnLoadOrdersMoviemax, "btnLoadOrdersMoviemax")
        Me.btnLoadOrdersMoviemax.Name = "btnLoadOrdersMoviemax"
        Me.HelpProvider1.SetShowHelp(Me.btnLoadOrdersMoviemax, CType(resources.GetObject("btnLoadOrdersMoviemax.ShowHelp"), Boolean))
        '
        'txtDateMovieMaxTo
        '
        Me.txtDateMovieMaxTo.EditValue = Nothing
        resources.ApplyResources(Me.txtDateMovieMaxTo, "txtDateMovieMaxTo")
        Me.txtDateMovieMaxTo.Name = "txtDateMovieMaxTo"
        Me.txtDateMovieMaxTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateMovieMaxTo.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateMovieMaxTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtDateMovieMaxTo, CType(resources.GetObject("txtDateMovieMaxTo.ShowHelp"), Boolean))
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnGlobalDataProducts)
        Me.GroupBox2.Controls.Add(Me.btnLoadOrdersGlobalData)
        Me.GroupBox2.Controls.Add(Me.btnGlobalDataProcess)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.HelpProvider1.SetShowHelp(Me.GroupBox2, CType(resources.GetObject("GroupBox2.ShowHelp"), Boolean))
        Me.GroupBox2.TabStop = False
        '
        'BtnGlobalDataProducts
        '
        resources.ApplyResources(Me.BtnGlobalDataProducts, "BtnGlobalDataProducts")
        Me.BtnGlobalDataProducts.Name = "BtnGlobalDataProducts"
        Me.HelpProvider1.SetShowHelp(Me.BtnGlobalDataProducts, CType(resources.GetObject("BtnGlobalDataProducts.ShowHelp"), Boolean))
        '
        'btnLoadOrdersGlobalData
        '
        resources.ApplyResources(Me.btnLoadOrdersGlobalData, "btnLoadOrdersGlobalData")
        Me.btnLoadOrdersGlobalData.Name = "btnLoadOrdersGlobalData"
        Me.HelpProvider1.SetShowHelp(Me.btnLoadOrdersGlobalData, CType(resources.GetObject("btnLoadOrdersGlobalData.ShowHelp"), Boolean))
        '
        'btnGlobalDataProcess
        '
        resources.ApplyResources(Me.btnGlobalDataProcess, "btnGlobalDataProcess")
        Me.btnGlobalDataProcess.Name = "btnGlobalDataProcess"
        Me.HelpProvider1.SetShowHelp(Me.btnGlobalDataProcess, CType(resources.GetObject("btnGlobalDataProcess.ShowHelp"), Boolean))
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, CType(resources.GetObject("LabelControl2.ShowHelp"), Boolean))
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
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, CType(resources.GetObject("LabelControl1.ShowHelp"), Boolean))
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
        'frmMovieMaxInfo_Browse
        '
        resources.ApplyResources(Me, "$this")
        Me.HelpButton = False
        Me.HelpProvider1.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me, resources.GetString("$this.HelpString"))
        Me.Name = "frmMovieMaxInfo_Browse"
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDateMovieMaxTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateMovieMaxTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Const FILENAMEMOVIEMAX As String = "FEE0374-"
    Const FILENAMEGLABALDATA As String = "FEESHARING"
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Public Sub this_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'btnProcessMovieMax.Visible = False
        Dim menuStrip As New PlushBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        txtFromDate.EditValue = Date.Now
        txtToDate.EditValue = Date.Now



        Try
            'objDS = New dsFeeSharing
            'TableName = "feesharing_moviemax_input"
            'IDField = "products_id"
            'NameField = "title_name"
            'SQLTxt1 = "SELECT * FROM feesharing_moviemax_input "
            'WhereClause = "  "
            'OrderByClause = " "
            'MaintenanceMenuID = -1
            'CanNew = False
            'CanEdit = True
            'CanSave = True
            'CanDelete = True
            'txtYear.EditValue = Year(Now)
            'txtMonth.EditValue = Month(Now)
            'MyBase.StartUp()
            'CreateColumns()
            ' LoadBKComboSet()
            'Creatinf Midding Info
            'CreateMissingInfo()

            'GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            'GridView1.OptionsBehavior.Editable = True
            TabParameters.PageVisible = True
            TabAnalyse.PageVisible = False
            TabChart.PageVisible = False
            TabControl1.SelectedTabPage = TabParameters
        Catch eLoad As System.Exception
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Feesharing, eLoad)
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
    End Sub

    Private Sub loadFeeSharingMovieMAx()
        Dim dt As DataTable
        Dim sql As String = PlushData.clsFeeSharing.getFeesharingMoviemax()
        dt = PlushData.clsConnection.FillDataSet(sql)
        LoadGrid(dt)
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessMovieMax.Click
        Dim cls As New PlushBuziness.feesharing()
        Dim strOuput As String
        Dim processOk As Boolean
        Dim dateFromMoviemax As Date
        Dim dateToMoviemax As Date


        dateFromMoviemax = txtFromDate.DateTime
        dateToMoviemax = txtToDate.DateTime
        Try
            SaveFileDialog1.FileName = FILENAMEMOVIEMAX & dateToMoviemax.Year & "-" & Format(dateToMoviemax.Month, "00") & ".txt"

            If (SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then


                processOk = cls.processMovieMax(dateFromMoviemax, dateToMoviemax)


                If processOk = False Then
                    ' MsgBox("MovieMax Data Info exist with TitelNr = 0")
                    Exit Sub
                End If
                strOuput = cls.BatchMovieMax(dateFromMoviemax)

                Dim okWrite As Boolean = PlushTools.clsFile.WriteFile(SaveFileDialog1.FileName, strOuput)
                If okWrite = False Then
                    MsgBox("the file is not record", MsgBoxStyle.Critical)
                Else
                    MsgBox("File MovieMax created " & SaveFileDialog1.FileName)
                End If

            End If
        Catch ex As Exception
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Feesharing, ex)
        End Try


    End Sub

    Private Sub btnGlobalDataProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGlobalDataProcess.Click

        Dim str As String
        Dim feesharing As New PlushBuziness.feesharing

        Try
            SaveFileDialog1.FileName = FILENAMEGLABALDATA & "_" & Date.Now.Year & "_" & Format(Date.Now.Month, "00") & ".txt"

            If (SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                str = feesharing.batchFeeSharing()

                If str = String.Empty Then
                    MsgBox("there are no orders In feesharing Global Data")
                    Exit Sub
                End If

                Dim okWrite As Boolean = PlushTools.clsFile.WriteFile(SaveFileDialog1.FileName, str)
                If okWrite = False Then
                    MsgBox("the file is not record", MsgBoxStyle.Critical)
                Else
                    MsgBox("File GlobalData created " & SaveFileDialog1.FileName)
                End If
            End If
        Catch ex As Exception
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Feesharing, ex)
        End Try
    End Sub

    Private Sub btnMovieMAx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMovieMAx.Click
        loadFeeSharingMovieMAx()
        'TabControl1.SelectedTabPage = TabResult
    End Sub

    Private Sub btnLoadOrdersGlobalData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadOrdersGlobalData.Click
        LoadOrdersGlobalData()
    End Sub
    Private Sub BtnGlobalDataProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGlobalDataProducts.Click
        loadProductsGlobalData()
    End Sub
    Private Sub btnLoadOrdersMoviemax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadOrdersMoviemax.Click
        loadOrdersMovieMax()
    End Sub
    Public Sub GridDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles GridView1.DoubleClick
        If GridView1.RowCount <> 0 Then
            Dim productsId As Integer
            Dim frm As New frmDVD_Maint(SessionInfo)

            Dim params As PlushBuziness.clsSingleton = Nothing
            params = PlushBuziness.clsSingleton.Instance()


            productsId = GridView1.GetDataRow(GridView1.FocusedRowHandle())("products_id")

            params.Products_dvd_id = productsId

            frm.Show(Me)
        End If
    End Sub

    Private Sub LoadGrid(ByVal dt As DataTable)
        Grid1.DataSource = Nothing
        Grid1.Views(0).PopulateColumns()
        Grid1.DataSource = dt
        TabControl1.SelectedTabPage = TabResult
    End Sub
    Private Sub LoadOrdersGlobalData()
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.clsFeeSharing.getOrdersInFeeSharing()
        dt = PlushData.clsConnection.FillDataSet(sql)
        LoadGrid(dt)
    End Sub
    Private Sub loadProductsGlobalData()
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.clsFeeSharing.GetProductsGlobalData()
        dt = PlushData.clsConnection.FillDataSet(sql)
        LoadGrid(dt)
    End Sub

    Private Sub loadOrdersMovieMax()
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsFeeSharing.getFeeSharingMovieMaxProccess(txtFromDate.EditValue, txtToDate.EditValue)
        dt = PlushData.clsConnection.FillDataSet(sql)
        LoadGrid(dt)
    End Sub


End Class
