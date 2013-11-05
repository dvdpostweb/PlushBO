Public Class frmDVD_Maint
    Inherits BizzLib.frmGeneral_Maintenance

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
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabMain As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabFR As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabNL As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabEN As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabLanguages As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabTheme As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblProductID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtModel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblModel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtyNow As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblQtyNow As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateAdded As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateAdded As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateAvailable As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtYear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblYear As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRunTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblRunTime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCountry As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbCountry As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbStudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPublic As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPublic As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbPictureFormat As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPictureFormat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbRating As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblRating As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDirector As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblDirector As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpSeries As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblSeries As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbSerie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtSerieNbr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSerieNbr As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkSerieAboProcess As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grpImage As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents grpActors As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnActorsMaint As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tabMain = New DevExpress.XtraTab.XtraTabPage
        Me.grpSeries = New DevExpress.XtraEditors.GroupControl
        Me.grpMain = New DevExpress.XtraEditors.GroupControl
        Me.cmbDirector = New DevExpress.XtraEditors.LookUpEdit
        Me.lblDirector = New DevExpress.XtraEditors.LabelControl
        Me.cmbRating = New DevExpress.XtraEditors.LookUpEdit
        Me.lblRating = New DevExpress.XtraEditors.LabelControl
        Me.cmbPictureFormat = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPictureFormat = New DevExpress.XtraEditors.LabelControl
        Me.txtPublic = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPublic = New DevExpress.XtraEditors.LabelControl
        Me.cmbStudio = New DevExpress.XtraEditors.LookUpEdit
        Me.lblStudio = New DevExpress.XtraEditors.LabelControl
        Me.cmbCountry = New DevExpress.XtraEditors.LookUpEdit
        Me.lblCountry = New DevExpress.XtraEditors.LabelControl
        Me.txtRunTime = New DevExpress.XtraEditors.TextEdit
        Me.lblRunTime = New DevExpress.XtraEditors.LabelControl
        Me.txtYear = New DevExpress.XtraEditors.TextEdit
        Me.lblYear = New DevExpress.XtraEditors.LabelControl
        Me.txtDateAvailable = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtDateAdded = New DevExpress.XtraEditors.DateEdit
        Me.lblDateAdded = New DevExpress.XtraEditors.LabelControl
        Me.txtQtyNow = New DevExpress.XtraEditors.TextEdit
        Me.lblQtyNow = New DevExpress.XtraEditors.LabelControl
        Me.txtQty = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl
        Me.txtModel = New DevExpress.XtraEditors.TextEdit
        Me.lblModel = New DevExpress.XtraEditors.LabelControl
        Me.txtProductID = New DevExpress.XtraEditors.TextEdit
        Me.lblProductID = New DevExpress.XtraEditors.LabelControl
        Me.tabFR = New DevExpress.XtraTab.XtraTabPage
        Me.tabNL = New DevExpress.XtraTab.XtraTabPage
        Me.tabEN = New DevExpress.XtraTab.XtraTabPage
        Me.tabTheme = New DevExpress.XtraTab.XtraTabPage
        Me.tabLanguages = New DevExpress.XtraTab.XtraTabPage
        Me.lblSeries = New DevExpress.XtraEditors.LabelControl
        Me.cmbSerie = New DevExpress.XtraEditors.LookUpEdit
        Me.txtSerieNbr = New DevExpress.XtraEditors.TextEdit
        Me.lblSerieNbr = New DevExpress.XtraEditors.LabelControl
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl
        Me.cmbStatus = New DevExpress.XtraEditors.LookUpEdit
        Me.chkSerieAboProcess = New DevExpress.XtraEditors.CheckEdit
        Me.grpImage = New DevExpress.XtraEditors.GroupControl
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.grpActors = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnActorsMaint = New DevExpress.XtraEditors.SimpleButton
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabMain.SuspendLayout()
        CType(Me.grpSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSeries.SuspendLayout()
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        CType(Me.cmbDirector.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPictureFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPublic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRunTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateAvailable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateAdded.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtyNow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieNbr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSerieAboProcess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpImage.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpActors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpActors.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 424)
        Me.StatusBar1.Name = "StatusBar1"
        '
        'PrintSystem1
        '
        Me.PrintSystem1.ExportOptions.XlsNativeFormat = True
        '
        'Misc_Bar2
        '
        Me.Misc_Bar2.DockCol = 4
        '
        'Misc_Bar
        '
        Me.Misc_Bar.DockCol = 5
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 57)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabMain
        Me.XtraTabControl1.Size = New System.Drawing.Size(1056, 389)
        Me.XtraTabControl1.TabIndex = 35
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabMain, Me.tabFR, Me.tabNL, Me.tabEN, Me.tabTheme, Me.tabLanguages})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.grpActors)
        Me.tabMain.Controls.Add(Me.grpImage)
        Me.tabMain.Controls.Add(Me.grpSeries)
        Me.tabMain.Controls.Add(Me.grpMain)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Size = New System.Drawing.Size(1047, 358)
        Me.tabMain.Text = "General Info"
        '
        'grpSeries
        '
        Me.grpSeries.Controls.Add(Me.chkSerieAboProcess)
        Me.grpSeries.Controls.Add(Me.txtSerieNbr)
        Me.grpSeries.Controls.Add(Me.lblSerieNbr)
        Me.grpSeries.Controls.Add(Me.cmbSerie)
        Me.grpSeries.Controls.Add(Me.lblSeries)
        Me.grpSeries.Location = New System.Drawing.Point(464, 8)
        Me.grpSeries.Name = "grpSeries"
        Me.grpSeries.Size = New System.Drawing.Size(264, 96)
        Me.grpSeries.TabIndex = 1
        Me.grpSeries.Text = "Series Info"
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.cmbStatus)
        Me.grpMain.Controls.Add(Me.lblStatus)
        Me.grpMain.Controls.Add(Me.cmbDirector)
        Me.grpMain.Controls.Add(Me.lblDirector)
        Me.grpMain.Controls.Add(Me.cmbRating)
        Me.grpMain.Controls.Add(Me.lblRating)
        Me.grpMain.Controls.Add(Me.cmbPictureFormat)
        Me.grpMain.Controls.Add(Me.lblPictureFormat)
        Me.grpMain.Controls.Add(Me.txtPublic)
        Me.grpMain.Controls.Add(Me.lblPublic)
        Me.grpMain.Controls.Add(Me.cmbStudio)
        Me.grpMain.Controls.Add(Me.lblStudio)
        Me.grpMain.Controls.Add(Me.cmbCountry)
        Me.grpMain.Controls.Add(Me.lblCountry)
        Me.grpMain.Controls.Add(Me.txtRunTime)
        Me.grpMain.Controls.Add(Me.lblRunTime)
        Me.grpMain.Controls.Add(Me.txtYear)
        Me.grpMain.Controls.Add(Me.lblYear)
        Me.grpMain.Controls.Add(Me.txtDateAvailable)
        Me.grpMain.Controls.Add(Me.LabelControl2)
        Me.grpMain.Controls.Add(Me.txtDateAdded)
        Me.grpMain.Controls.Add(Me.lblDateAdded)
        Me.grpMain.Controls.Add(Me.txtQtyNow)
        Me.grpMain.Controls.Add(Me.lblQtyNow)
        Me.grpMain.Controls.Add(Me.txtQty)
        Me.grpMain.Controls.Add(Me.LabelControl1)
        Me.grpMain.Controls.Add(Me.txtTitle)
        Me.grpMain.Controls.Add(Me.lblTitle)
        Me.grpMain.Controls.Add(Me.txtModel)
        Me.grpMain.Controls.Add(Me.lblModel)
        Me.grpMain.Controls.Add(Me.txtProductID)
        Me.grpMain.Controls.Add(Me.lblProductID)
        Me.grpMain.Location = New System.Drawing.Point(16, 8)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(440, 304)
        Me.grpMain.TabIndex = 0
        Me.grpMain.Text = "General Info"
        '
        'cmbDirector
        '
        Me.cmbDirector.Location = New System.Drawing.Point(328, 216)
        Me.cmbDirector.Name = "cmbDirector"
        '
        'cmbDirector.Properties
        '
        Me.cmbDirector.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDirector.Properties.NullText = ""
        Me.cmbDirector.Size = New System.Drawing.Size(104, 20)
        Me.cmbDirector.TabIndex = 29
        '
        'lblDirector
        '
        Me.lblDirector.Location = New System.Drawing.Point(240, 216)
        Me.lblDirector.Name = "lblDirector"
        Me.lblDirector.Size = New System.Drawing.Size(88, 20)
        Me.lblDirector.TabIndex = 28
        Me.lblDirector.Text = "Director"
        '
        'cmbRating
        '
        Me.cmbRating.Location = New System.Drawing.Point(104, 216)
        Me.cmbRating.Name = "cmbRating"
        '
        'cmbRating.Properties
        '
        Me.cmbRating.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRating.Properties.NullText = ""
        Me.cmbRating.TabIndex = 27
        '
        'lblRating
        '
        Me.lblRating.Location = New System.Drawing.Point(16, 216)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(88, 20)
        Me.lblRating.TabIndex = 26
        Me.lblRating.Text = "Rating"
        '
        'cmbPictureFormat
        '
        Me.cmbPictureFormat.Location = New System.Drawing.Point(328, 192)
        Me.cmbPictureFormat.Name = "cmbPictureFormat"
        '
        'cmbPictureFormat.Properties
        '
        Me.cmbPictureFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPictureFormat.Properties.NullText = ""
        Me.cmbPictureFormat.Size = New System.Drawing.Size(104, 20)
        Me.cmbPictureFormat.TabIndex = 25
        '
        'lblPictureFormat
        '
        Me.lblPictureFormat.Location = New System.Drawing.Point(240, 192)
        Me.lblPictureFormat.Name = "lblPictureFormat"
        Me.lblPictureFormat.Size = New System.Drawing.Size(88, 20)
        Me.lblPictureFormat.TabIndex = 24
        Me.lblPictureFormat.Text = "Picture Format"
        '
        'txtPublic
        '
        Me.txtPublic.Location = New System.Drawing.Point(104, 192)
        Me.txtPublic.Name = "txtPublic"
        '
        'txtPublic.Properties
        '
        Me.txtPublic.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPublic.Properties.NullText = ""
        Me.txtPublic.TabIndex = 23
        '
        'lblPublic
        '
        Me.lblPublic.Location = New System.Drawing.Point(16, 192)
        Me.lblPublic.Name = "lblPublic"
        Me.lblPublic.Size = New System.Drawing.Size(88, 20)
        Me.lblPublic.TabIndex = 22
        Me.lblPublic.Text = "Public"
        '
        'cmbStudio
        '
        Me.cmbStudio.Location = New System.Drawing.Point(328, 168)
        Me.cmbStudio.Name = "cmbStudio"
        '
        'cmbStudio.Properties
        '
        Me.cmbStudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStudio.Properties.NullText = ""
        Me.cmbStudio.Size = New System.Drawing.Size(104, 20)
        Me.cmbStudio.TabIndex = 21
        '
        'lblStudio
        '
        Me.lblStudio.Location = New System.Drawing.Point(240, 168)
        Me.lblStudio.Name = "lblStudio"
        Me.lblStudio.Size = New System.Drawing.Size(88, 20)
        Me.lblStudio.TabIndex = 20
        Me.lblStudio.Text = "Studio"
        '
        'cmbCountry
        '
        Me.cmbCountry.Location = New System.Drawing.Point(104, 168)
        Me.cmbCountry.Name = "cmbCountry"
        '
        'cmbCountry.Properties
        '
        Me.cmbCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCountry.Properties.NullText = ""
        Me.cmbCountry.TabIndex = 19
        '
        'lblCountry
        '
        Me.lblCountry.Location = New System.Drawing.Point(16, 168)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(88, 20)
        Me.lblCountry.TabIndex = 18
        Me.lblCountry.Text = "Country"
        '
        'txtRunTime
        '
        Me.txtRunTime.Location = New System.Drawing.Point(328, 144)
        Me.txtRunTime.Name = "txtRunTime"
        Me.txtRunTime.Size = New System.Drawing.Size(104, 20)
        Me.txtRunTime.TabIndex = 17
        '
        'lblRunTime
        '
        Me.lblRunTime.Location = New System.Drawing.Point(240, 144)
        Me.lblRunTime.Name = "lblRunTime"
        Me.lblRunTime.Size = New System.Drawing.Size(88, 20)
        Me.lblRunTime.TabIndex = 16
        Me.lblRunTime.Text = "Run Time"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(104, 144)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.TabIndex = 15
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(16, 144)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(88, 20)
        Me.lblYear.TabIndex = 14
        Me.lblYear.Text = "Year"
        '
        'txtDateAvailable
        '
        Me.txtDateAvailable.EditValue = Nothing
        Me.txtDateAvailable.Location = New System.Drawing.Point(328, 120)
        Me.txtDateAvailable.Name = "txtDateAvailable"
        '
        'txtDateAvailable.Properties
        '
        Me.txtDateAvailable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateAvailable.Size = New System.Drawing.Size(104, 20)
        Me.txtDateAvailable.TabIndex = 13
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(240, 120)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(88, 20)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "Date Available"
        '
        'txtDateAdded
        '
        Me.txtDateAdded.EditValue = Nothing
        Me.txtDateAdded.Location = New System.Drawing.Point(104, 120)
        Me.txtDateAdded.Name = "txtDateAdded"
        '
        'txtDateAdded.Properties
        '
        Me.txtDateAdded.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateAdded.TabIndex = 11
        '
        'lblDateAdded
        '
        Me.lblDateAdded.Location = New System.Drawing.Point(16, 120)
        Me.lblDateAdded.Name = "lblDateAdded"
        Me.lblDateAdded.Size = New System.Drawing.Size(88, 20)
        Me.lblDateAdded.TabIndex = 10
        Me.lblDateAdded.Text = "Date Added"
        '
        'txtQtyNow
        '
        Me.txtQtyNow.Location = New System.Drawing.Point(328, 96)
        Me.txtQtyNow.Name = "txtQtyNow"
        Me.txtQtyNow.Size = New System.Drawing.Size(104, 20)
        Me.txtQtyNow.TabIndex = 9
        '
        'lblQtyNow
        '
        Me.lblQtyNow.Location = New System.Drawing.Point(240, 96)
        Me.lblQtyNow.Name = "lblQtyNow"
        Me.lblQtyNow.Size = New System.Drawing.Size(88, 20)
        Me.lblQtyNow.TabIndex = 8
        Me.lblQtyNow.Text = "Qty Now"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(104, 96)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 96)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 20)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Qty"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(104, 72)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(328, 20)
        Me.txtTitle.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(16, 72)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(88, 20)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Title"
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(104, 48)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(328, 20)
        Me.txtModel.TabIndex = 3
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(16, 48)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(88, 20)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Model"
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(104, 24)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.TabIndex = 1
        '
        'lblProductID
        '
        Me.lblProductID.Location = New System.Drawing.Point(16, 24)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(88, 20)
        Me.lblProductID.TabIndex = 0
        Me.lblProductID.Text = "Product ID"
        '
        'tabFR
        '
        Me.tabFR.Name = "tabFR"
        Me.tabFR.Size = New System.Drawing.Size(1047, 358)
        Me.tabFR.Text = "FR"
        '
        'tabNL
        '
        Me.tabNL.Name = "tabNL"
        Me.tabNL.Size = New System.Drawing.Size(1047, 358)
        Me.tabNL.Text = "NL"
        '
        'tabEN
        '
        Me.tabEN.Name = "tabEN"
        Me.tabEN.Size = New System.Drawing.Size(1047, 358)
        Me.tabEN.Text = "EN"
        '
        'tabTheme
        '
        Me.tabTheme.Name = "tabTheme"
        Me.tabTheme.Size = New System.Drawing.Size(1047, 358)
        Me.tabTheme.Text = "Themes and Categories"
        '
        'tabLanguages
        '
        Me.tabLanguages.Name = "tabLanguages"
        Me.tabLanguages.Size = New System.Drawing.Size(1047, 358)
        Me.tabLanguages.Text = "Languages"
        '
        'lblSeries
        '
        Me.lblSeries.Location = New System.Drawing.Point(8, 24)
        Me.lblSeries.Name = "lblSeries"
        Me.lblSeries.Size = New System.Drawing.Size(88, 20)
        Me.lblSeries.TabIndex = 12
        Me.lblSeries.Text = "Serie"
        '
        'cmbSerie
        '
        Me.cmbSerie.Location = New System.Drawing.Point(96, 24)
        Me.cmbSerie.Name = "cmbSerie"
        '
        'cmbSerie.Properties
        '
        Me.cmbSerie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSerie.Properties.NullText = ""
        Me.cmbSerie.Size = New System.Drawing.Size(160, 20)
        Me.cmbSerie.TabIndex = 28
        '
        'txtSerieNbr
        '
        Me.txtSerieNbr.Location = New System.Drawing.Point(96, 48)
        Me.txtSerieNbr.Name = "txtSerieNbr"
        Me.txtSerieNbr.TabIndex = 30
        '
        'lblSerieNbr
        '
        Me.lblSerieNbr.Location = New System.Drawing.Point(8, 48)
        Me.lblSerieNbr.Name = "lblSerieNbr"
        Me.lblSerieNbr.Size = New System.Drawing.Size(88, 20)
        Me.lblSerieNbr.TabIndex = 29
        Me.lblSerieNbr.Text = "Serie Nbr"
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(240, 24)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(88, 20)
        Me.lblStatus.TabIndex = 30
        Me.lblStatus.Text = "Status"
        '
        'cmbStatus
        '
        Me.cmbStatus.Location = New System.Drawing.Point(328, 24)
        Me.cmbStatus.Name = "cmbStatus"
        '
        'cmbStatus.Properties
        '
        Me.cmbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStatus.Properties.NullText = ""
        Me.cmbStatus.Size = New System.Drawing.Size(104, 20)
        Me.cmbStatus.TabIndex = 31
        '
        'chkSerieAboProcess
        '
        Me.chkSerieAboProcess.Location = New System.Drawing.Point(8, 72)
        Me.chkSerieAboProcess.Name = "chkSerieAboProcess"
        '
        'chkSerieAboProcess.Properties
        '
        Me.chkSerieAboProcess.Properties.Caption = "Serie for ABO Process"
        Me.chkSerieAboProcess.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkSerieAboProcess.Size = New System.Drawing.Size(184, 19)
        Me.chkSerieAboProcess.TabIndex = 31
        '
        'grpImage
        '
        Me.grpImage.Controls.Add(Me.PictureEdit1)
        Me.grpImage.Controls.Add(Me.TextEdit1)
        Me.grpImage.Location = New System.Drawing.Point(464, 112)
        Me.grpImage.Name = "grpImage"
        Me.grpImage.Size = New System.Drawing.Size(264, 200)
        Me.grpImage.TabIndex = 2
        Me.grpImage.Text = "Small Image"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(8, 24)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(248, 20)
        Me.TextEdit1.TabIndex = 4
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(88, 56)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 136)
        Me.PictureEdit1.TabIndex = 5
        '
        'grpActors
        '
        Me.grpActors.Controls.Add(Me.GridControl1)
        Me.grpActors.Controls.Add(Me.PanelControl1)
        Me.grpActors.Location = New System.Drawing.Point(736, 8)
        Me.grpActors.Name = "grpActors"
        Me.grpActors.Size = New System.Drawing.Size(200, 304)
        Me.grpActors.TabIndex = 3
        Me.grpActors.Text = "Actors"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(196, 242)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnActorsMaint)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(2, 262)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(196, 40)
        Me.PanelControl1.TabIndex = 1
        Me.PanelControl1.Text = "PanelControl1"
        '
        'btnActorsMaint
        '
        Me.btnActorsMaint.Location = New System.Drawing.Point(48, 8)
        Me.btnActorsMaint.Name = "btnActorsMaint"
        Me.btnActorsMaint.Size = New System.Drawing.Size(96, 23)
        Me.btnActorsMaint.TabIndex = 0
        Me.btnActorsMaint.Text = "Manage Actors"
        '
        'frmDVD_Maint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1056, 446)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmDVD_Maint"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabMain.ResumeLayout(False)
        CType(Me.grpSeries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSeries.ResumeLayout(False)
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        CType(Me.cmbDirector.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPictureFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPublic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRunTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateAvailable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateAdded.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtyNow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieNbr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSerieAboProcess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpImage.ResumeLayout(False)
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpActors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpActors.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
