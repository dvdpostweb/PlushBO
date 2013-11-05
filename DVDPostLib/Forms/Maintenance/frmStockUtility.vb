Imports System.Windows.Forms.Application
Public Class frmStockUtility
    Inherits BizzLib.frmBKForm

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
    Friend WithEvents btnReCalcQtyNow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFromID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCopyDVD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtToDVDID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFROMDVDID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCopyDirectors As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtToDirectorID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFromDirectorID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCopyActors As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTOActorID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFromActorID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage

    Friend WithEvents txtTotDVD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotDVDOut As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotDVDIn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotDVDInOK As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnActifOUT As DevExpress.XtraEditors.SimpleButton

    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPivotDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnMiscInNotOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIDBeeingProcessed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToBoxID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFromBoxID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSetAvailability As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSetToPassif As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReNumberBoxes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLongTimeCust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoadOrdersActifPassif As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoadLongTime As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotDVDOutOK As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustLang1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFromProdID1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtToProdID1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtWLToProcess As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtProductsID_1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnLoadNbrRotation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDVDID_1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToProducts_ID_1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFromProducts_ID_1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnClearBoxes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTableProcessed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnTransferProductID As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip9 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem9 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem9 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip10 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem10 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem10 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.btnReCalcQtyNow = New DevExpress.XtraEditors.SimpleButton
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtToID = New DevExpress.XtraEditors.TextEdit
        Me.txtFromID = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.btnSetAvailability = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.txtIDBeeingProcessed = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.btnCopyDVD = New DevExpress.XtraEditors.SimpleButton
        Me.txtToDVDID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtFROMDVDID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.btnCopyDirectors = New DevExpress.XtraEditors.SimpleButton
        Me.txtToDirectorID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtFromDirectorID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.btnCopyActors = New DevExpress.XtraEditors.SimpleButton
        Me.txtTOActorID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtFromActorID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotDVDOutOK = New DevExpress.XtraEditors.TextEdit
        Me.btnLoadLongTime = New DevExpress.XtraEditors.SimpleButton
        Me.btnLongTimeCust = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotP = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotA = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotM = New DevExpress.XtraEditors.TextEdit
        Me.btnMiscInNotOK = New DevExpress.XtraEditors.SimpleButton
        Me.txtPivotDate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.btnSetToPassif = New DevExpress.XtraEditors.SimpleButton
        Me.btnActifOUT = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotDVDInOK = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotDVDIn = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotDVDOut = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotDVD = New DevExpress.XtraEditors.TextEdit
        Me.btnLoadOrdersActifPassif = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.btnClearBoxes = New DevExpress.XtraEditors.SimpleButton
        Me.btnReNumberBoxes = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.txtToBoxID = New DevExpress.XtraEditors.TextEdit
        Me.txtFromBoxID = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage
        Me.btnTransferProductID = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.txtWLToProcess = New DevExpress.XtraEditors.TextEdit
        Me.txtToProdID1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.txtFromProdID1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustLang1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl
        Me.txtTableProcessed = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
        Me.txtToProducts_ID_1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
        Me.txtFromProducts_ID_1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.txtDVDID_1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.txtProductsID_1 = New DevExpress.XtraEditors.TextEdit
        Me.btnLoadNbrRotation = New DevExpress.XtraEditors.SimpleButton
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtToID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtIDBeeingProcessed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtToDVDID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFROMDVDID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDirectorID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDirectorID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTOActorID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromActorID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.txtTotDVDOutOK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPivotDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPivotDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotDVDInOK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotDVDIn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotDVDOut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotDVD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtToBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.txtWLToProcess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToProdID1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromProdID1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustLang1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.txtTableProcessed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToProducts_ID_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromProducts_ID_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDID_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductsID_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReCalcQtyNow
        '
        Me.btnReCalcQtyNow.Location = New System.Drawing.Point(288, 24)
        Me.btnReCalcQtyNow.Name = "btnReCalcQtyNow"
        Me.btnReCalcQtyNow.Size = New System.Drawing.Size(264, 23)
        ToolTipTitleItem6.Text = "Re-Calc Products Qty Now"
        ToolTipItem6.LeftIndent = 6
        ToolTipItem6.Text = "For Each Product" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Count How Many DVD (products_dvd) with " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             Statu" & _
            "s = 1 (OK) " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             InOut = 1 (In stock)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Place th" & _
            "e Result in products.products_quantity"
        SuperToolTip6.Items.Add(ToolTipTitleItem6)
        SuperToolTip6.Items.Add(ToolTipItem6)
        Me.btnReCalcQtyNow.SuperTip = SuperToolTip6
        Me.btnReCalcQtyNow.TabIndex = 4
        Me.btnReCalcQtyNow.Text = "Re-Calc Products Qty NOW"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(16, 168)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(528, 18)
        Me.ProgressBarControl1.TabIndex = 5
        Me.ProgressBarControl1.Visible = False
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(16, 144)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1.Size = New System.Drawing.Size(100, 20)
        Me.SpinEdit1.TabIndex = 6
        Me.SpinEdit1.Visible = False
        '
        'GroupControl1
        '
        Me.GroupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtToID)
        Me.GroupControl1.Controls.Add(Me.txtFromID)
        Me.GroupControl1.Location = New System.Drawing.Point(16, 24)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(264, 80)
        Me.GroupControl1.TabIndex = 24
        Me.GroupControl1.Text = "Products Range / Type"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(136, 32)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "To ID "
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "From ID "
        '
        'txtToID
        '
        Me.txtToID.EditValue = "99999999"
        Me.txtToID.Location = New System.Drawing.Point(136, 48)
        Me.txtToID.Name = "txtToID"
        Me.txtToID.Size = New System.Drawing.Size(100, 20)
        Me.txtToID.TabIndex = 1
        '
        'txtFromID
        '
        Me.txtFromID.EditValue = "0"
        Me.txtFromID.Location = New System.Drawing.Point(16, 48)
        Me.txtFromID.Name = "txtFromID"
        Me.txtFromID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFromID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFromID.Size = New System.Drawing.Size(100, 20)
        Me.txtFromID.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 30)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1040, 344)
        Me.XtraTabControl1.TabIndex = 25
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6})
        Me.XtraTabControl1.Text = "Recalc Qty Now"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.btnSetAvailability)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl18)
        Me.XtraTabPage1.Controls.Add(Me.txtIDBeeingProcessed)
        Me.XtraTabPage1.Controls.Add(Me.btnReCalcQtyNow)
        Me.XtraTabPage1.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage1.Controls.Add(Me.ProgressBarControl1)
        Me.XtraTabPage1.Controls.Add(Me.SpinEdit1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1031, 313)
        Me.XtraTabPage1.Text = "Re-Calc Qty Now"
        '
        'btnSetAvailability
        '
        Me.btnSetAvailability.Location = New System.Drawing.Point(288, 48)
        Me.btnSetAvailability.Name = "btnSetAvailability"
        Me.btnSetAvailability.Size = New System.Drawing.Size(264, 23)
        ToolTipTitleItem8.Text = "Set products_availability"
        ToolTipItem8.LeftIndent = 6
        ToolTipItem8.Text = "For Each Product" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Count How Many DVD (products_dvd) with " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             Statu" & _
            "s = 1 (OK) " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   If Count = 0 then products_availability = 0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   If Count > 0 th" & _
            "en products_availability = 1 "
        SuperToolTip8.Items.Add(ToolTipTitleItem8)
        SuperToolTip8.Items.Add(ToolTipItem8)
        Me.btnSetAvailability.SuperTip = SuperToolTip8
        Me.btnSetAvailability.TabIndex = 27
        Me.btnSetAvailability.Text = "Set Availability"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(128, 144)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl18.TabIndex = 26
        Me.LabelControl18.Text = "ID Beeing Processed"
        '
        'txtIDBeeingProcessed
        '
        Me.txtIDBeeingProcessed.EditValue = "0"
        Me.txtIDBeeingProcessed.Location = New System.Drawing.Point(240, 144)
        Me.txtIDBeeingProcessed.Name = "txtIDBeeingProcessed"
        Me.txtIDBeeingProcessed.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIDBeeingProcessed.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIDBeeingProcessed.Size = New System.Drawing.Size(100, 20)
        Me.txtIDBeeingProcessed.TabIndex = 25
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.btnCopyDVD)
        Me.XtraTabPage2.Controls.Add(Me.txtToDVDID)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Controls.Add(Me.txtFROMDVDID)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage2.Controls.Add(Me.btnCopyDirectors)
        Me.XtraTabPage2.Controls.Add(Me.txtToDirectorID)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage2.Controls.Add(Me.txtFromDirectorID)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage2.Controls.Add(Me.btnCopyActors)
        Me.XtraTabPage2.Controls.Add(Me.txtTOActorID)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.txtFromActorID)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.TextEdit1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageVisible = False
        Me.XtraTabPage2.Size = New System.Drawing.Size(1031, 313)
        Me.XtraTabPage2.Text = "FROm Test To PROD"
        '
        'btnCopyDVD
        '
        Me.btnCopyDVD.Location = New System.Drawing.Point(600, 104)
        Me.btnCopyDVD.Name = "btnCopyDVD"
        Me.btnCopyDVD.Size = New System.Drawing.Size(104, 23)
        Me.btnCopyDVD.TabIndex = 16
        Me.btnCopyDVD.Text = "Copy DVDs"
        '
        'txtToDVDID
        '
        Me.txtToDVDID.Location = New System.Drawing.Point(600, 72)
        Me.txtToDVDID.Name = "txtToDVDID"
        Me.txtToDVDID.Size = New System.Drawing.Size(100, 20)
        Me.txtToDVDID.TabIndex = 15
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(512, 72)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "To DVD ID"
        '
        'txtFROMDVDID
        '
        Me.txtFROMDVDID.Location = New System.Drawing.Point(600, 48)
        Me.txtFROMDVDID.Name = "txtFROMDVDID"
        Me.txtFROMDVDID.Size = New System.Drawing.Size(100, 20)
        Me.txtFROMDVDID.TabIndex = 13
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(512, 48)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl9.TabIndex = 12
        Me.LabelControl9.Text = "From DVD ID"
        '
        'btnCopyDirectors
        '
        Me.btnCopyDirectors.Location = New System.Drawing.Point(336, 104)
        Me.btnCopyDirectors.Name = "btnCopyDirectors"
        Me.btnCopyDirectors.Size = New System.Drawing.Size(104, 23)
        Me.btnCopyDirectors.TabIndex = 11
        Me.btnCopyDirectors.Text = "Copy Directors"
        '
        'txtToDirectorID
        '
        Me.txtToDirectorID.Location = New System.Drawing.Point(336, 72)
        Me.txtToDirectorID.Name = "txtToDirectorID"
        Me.txtToDirectorID.Size = New System.Drawing.Size(100, 20)
        Me.txtToDirectorID.TabIndex = 10
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(248, 72)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl6.TabIndex = 9
        Me.LabelControl6.Text = "To Directors"
        '
        'txtFromDirectorID
        '
        Me.txtFromDirectorID.Location = New System.Drawing.Point(336, 48)
        Me.txtFromDirectorID.Name = "txtFromDirectorID"
        Me.txtFromDirectorID.Size = New System.Drawing.Size(100, 20)
        Me.txtFromDirectorID.TabIndex = 8
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(248, 48)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl7.TabIndex = 7
        Me.LabelControl7.Text = "From Directors"
        '
        'btnCopyActors
        '
        Me.btnCopyActors.Location = New System.Drawing.Point(104, 104)
        Me.btnCopyActors.Name = "btnCopyActors"
        Me.btnCopyActors.Size = New System.Drawing.Size(104, 23)
        Me.btnCopyActors.TabIndex = 6
        Me.btnCopyActors.Text = "Copy ACTORS"
        '
        'txtTOActorID
        '
        Me.txtTOActorID.Location = New System.Drawing.Point(104, 72)
        Me.txtTOActorID.Name = "txtTOActorID"
        Me.txtTOActorID.Size = New System.Drawing.Size(100, 20)
        Me.txtTOActorID.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(16, 72)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "To Actors"
        '
        'txtFromActorID
        '
        Me.txtFromActorID.Location = New System.Drawing.Point(104, 48)
        Me.txtFromActorID.Name = "txtFromActorID"
        Me.txtFromActorID.Size = New System.Drawing.Size(100, 20)
        Me.txtFromActorID.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(16, 48)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl4.TabIndex = 2
        Me.LabelControl4.Text = "From Actors"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 16)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "TEST Conn."
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = "Server=192.168.0.204;Uid=root;Pwd=(:melissa:);Database=dvdpost_be_test;Port=3306"
        Me.TextEdit1.Enabled = False
        Me.TextEdit1.Location = New System.Drawing.Point(104, 16)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(896, 20)
        Me.TextEdit1.TabIndex = 0
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.LabelControl21)
        Me.XtraTabPage3.Controls.Add(Me.txtTotDVDOutOK)
        Me.XtraTabPage3.Controls.Add(Me.btnLoadLongTime)
        Me.XtraTabPage3.Controls.Add(Me.btnLongTimeCust)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl15)
        Me.XtraTabPage3.Controls.Add(Me.txtTotP)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl16)
        Me.XtraTabPage3.Controls.Add(Me.txtTotA)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl17)
        Me.XtraTabPage3.Controls.Add(Me.txtTotM)
        Me.XtraTabPage3.Controls.Add(Me.btnMiscInNotOK)
        Me.XtraTabPage3.Controls.Add(Me.txtPivotDate)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl14)
        Me.XtraTabPage3.Controls.Add(Me.btnSetToPassif)
        Me.XtraTabPage3.Controls.Add(Me.btnActifOUT)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl13)
        Me.XtraTabPage3.Controls.Add(Me.txtTotDVDInOK)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage3.Controls.Add(Me.txtTotDVDIn)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage3.Controls.Add(Me.txtTotDVDOut)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage3.Controls.Add(Me.txtTotDVD)
        Me.XtraTabPage3.Controls.Add(Me.btnLoadOrdersActifPassif)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1031, 313)
        Me.XtraTabPage3.Text = "Stock Actif / Passif - LongTime@Customers"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(16, 176)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(161, 13)
        Me.LabelControl21.TabIndex = 32
        Me.LabelControl21.Text = "Nbr Tot de DVDs OUT / Status OK"
        '
        'txtTotDVDOutOK
        '
        Me.txtTotDVDOutOK.EditValue = ""
        Me.txtTotDVDOutOK.Location = New System.Drawing.Point(192, 176)
        Me.txtTotDVDOutOK.Name = "txtTotDVDOutOK"
        Me.txtTotDVDOutOK.Properties.ReadOnly = True
        Me.txtTotDVDOutOK.Size = New System.Drawing.Size(100, 20)
        Me.txtTotDVDOutOK.TabIndex = 31
        '
        'btnLoadLongTime
        '
        Me.btnLoadLongTime.Location = New System.Drawing.Point(8, 64)
        Me.btnLoadLongTime.Name = "btnLoadLongTime"
        Me.btnLoadLongTime.Size = New System.Drawing.Size(120, 23)
        Me.btnLoadLongTime.TabIndex = 30
        Me.btnLoadLongTime.Text = "LoadLongTime"
        '
        'btnLongTimeCust
        '
        Me.btnLongTimeCust.Location = New System.Drawing.Point(136, 64)
        Me.btnLongTimeCust.Name = "btnLongTimeCust"
        Me.btnLongTimeCust.Size = New System.Drawing.Size(416, 23)
        ToolTipTitleItem7.Text = "Set LongTime@Cust "
        ToolTipItem7.LeftIndent = 6
        ToolTipItem7.Text = "If DVD is more than 1 Month at Customer then set DVD_Status = 17 = LongTime@Custo" & _
            "mer"
        SuperToolTip7.Items.Add(ToolTipTitleItem7)
        SuperToolTip7.Items.Add(ToolTipItem7)
        Me.btnLongTimeCust.SuperTip = SuperToolTip7
        Me.btnLongTimeCust.TabIndex = 29
        Me.btnLongTimeCust.Text = "Set Long Time @ Customer"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(328, 176)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl15.TabIndex = 19
        Me.LabelControl15.Text = "Nbr of P"
        '
        'txtTotP
        '
        Me.txtTotP.EditValue = ""
        Me.txtTotP.Location = New System.Drawing.Point(408, 176)
        Me.txtTotP.Name = "txtTotP"
        Me.txtTotP.Properties.ReadOnly = True
        Me.txtTotP.Size = New System.Drawing.Size(100, 20)
        Me.txtTotP.TabIndex = 18
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(328, 152)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl16.TabIndex = 17
        Me.LabelControl16.Text = "Nbr of A"
        '
        'txtTotA
        '
        Me.txtTotA.EditValue = ""
        Me.txtTotA.Location = New System.Drawing.Point(408, 152)
        Me.txtTotA.Name = "txtTotA"
        Me.txtTotA.Properties.ReadOnly = True
        Me.txtTotA.Size = New System.Drawing.Size(100, 20)
        Me.txtTotA.TabIndex = 16
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(328, 128)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl17.TabIndex = 15
        Me.LabelControl17.Text = "Nbr of M"
        '
        'txtTotM
        '
        Me.txtTotM.EditValue = ""
        Me.txtTotM.Location = New System.Drawing.Point(408, 128)
        Me.txtTotM.Name = "txtTotM"
        Me.txtTotM.Properties.ReadOnly = True
        Me.txtTotM.Size = New System.Drawing.Size(100, 20)
        Me.txtTotM.TabIndex = 14
        '
        'btnMiscInNotOK
        '
        Me.btnMiscInNotOK.Location = New System.Drawing.Point(272, 40)
        Me.btnMiscInNotOK.Name = "btnMiscInNotOK"
        Me.btnMiscInNotOK.Size = New System.Drawing.Size(152, 23)
        Me.btnMiscInNotOK.TabIndex = 13
        Me.btnMiscInNotOK.Text = "Set DVD IN Not OK  to Misc"
        '
        'txtPivotDate
        '
        Me.txtPivotDate.EditValue = Nothing
        Me.txtPivotDate.Location = New System.Drawing.Point(128, 16)
        Me.txtPivotDate.Name = "txtPivotDate"
        Me.txtPivotDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPivotDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtPivotDate.Size = New System.Drawing.Size(100, 20)
        Me.txtPivotDate.TabIndex = 12
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(16, 16)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl14.TabIndex = 11
        Me.LabelControl14.Text = "IF not Ordered Since : "
        '
        'btnSetToPassif
        '
        Me.btnSetToPassif.Location = New System.Drawing.Point(432, 40)
        Me.btnSetToPassif.Name = "btnSetToPassif"
        Me.btnSetToPassif.Size = New System.Drawing.Size(120, 23)
        Me.btnSetToPassif.TabIndex = 10
        Me.btnSetToPassif.Text = "Set DVD to Passif "
        '
        'btnActifOUT
        '
        Me.btnActifOUT.Location = New System.Drawing.Point(136, 40)
        Me.btnActifOUT.Name = "btnActifOUT"
        Me.btnActifOUT.Size = New System.Drawing.Size(120, 23)
        Me.btnActifOUT.TabIndex = 9
        Me.btnActifOUT.Text = "Set DVD Out to Actif"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(16, 200)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(159, 13)
        Me.LabelControl13.TabIndex = 8
        Me.LabelControl13.Text = "Nbr Total de DVDs IN / Status OK"
        '
        'txtTotDVDInOK
        '
        Me.txtTotDVDInOK.EditValue = ""
        Me.txtTotDVDInOK.Location = New System.Drawing.Point(192, 200)
        Me.txtTotDVDInOK.Name = "txtTotDVDInOK"
        Me.txtTotDVDInOK.Properties.ReadOnly = True
        Me.txtTotDVDInOK.Size = New System.Drawing.Size(100, 20)
        Me.txtTotDVDInOK.TabIndex = 7
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(16, 152)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl12.TabIndex = 6
        Me.LabelControl12.Text = "Nbr Total de DVDs IN"
        '
        'txtTotDVDIn
        '
        Me.txtTotDVDIn.EditValue = ""
        Me.txtTotDVDIn.Location = New System.Drawing.Point(192, 152)
        Me.txtTotDVDIn.Name = "txtTotDVDIn"
        Me.txtTotDVDIn.Properties.ReadOnly = True
        Me.txtTotDVDIn.Size = New System.Drawing.Size(100, 20)
        Me.txtTotDVDIn.TabIndex = 5
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(16, 128)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl11.TabIndex = 4
        Me.LabelControl11.Text = "Nbr Total de DVDs OUT"
        '
        'txtTotDVDOut
        '
        Me.txtTotDVDOut.EditValue = ""
        Me.txtTotDVDOut.Location = New System.Drawing.Point(192, 128)
        Me.txtTotDVDOut.Name = "txtTotDVDOut"
        Me.txtTotDVDOut.Properties.ReadOnly = True
        Me.txtTotDVDOut.Size = New System.Drawing.Size(100, 20)
        Me.txtTotDVDOut.TabIndex = 3
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(16, 104)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl10.TabIndex = 2
        Me.LabelControl10.Text = "Nbr Total de DVDs"
        '
        'txtTotDVD
        '
        Me.txtTotDVD.EditValue = ""
        Me.txtTotDVD.Location = New System.Drawing.Point(192, 104)
        Me.txtTotDVD.Name = "txtTotDVD"
        Me.txtTotDVD.Properties.ReadOnly = True
        Me.txtTotDVD.Size = New System.Drawing.Size(100, 20)
        Me.txtTotDVD.TabIndex = 1
        '
        'btnLoadOrdersActifPassif
        '
        Me.btnLoadOrdersActifPassif.Location = New System.Drawing.Point(8, 40)
        Me.btnLoadOrdersActifPassif.Name = "btnLoadOrdersActifPassif"
        Me.btnLoadOrdersActifPassif.Size = New System.Drawing.Size(120, 23)
        Me.btnLoadOrdersActifPassif.TabIndex = 0
        Me.btnLoadOrdersActifPassif.Text = "Load"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.btnClearBoxes)
        Me.XtraTabPage4.Controls.Add(Me.btnReNumberBoxes)
        Me.XtraTabPage4.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1031, 313)
        Me.XtraTabPage4.Text = "Re-Number / CLear Boxes"
        '
        'btnClearBoxes
        '
        Me.btnClearBoxes.Location = New System.Drawing.Point(16, 133)
        Me.btnClearBoxes.Name = "btnClearBoxes"
        Me.btnClearBoxes.Size = New System.Drawing.Size(264, 23)
        ToolTipTitleItem9.Text = "Re-Calc Products Qty Now"
        ToolTipItem9.LeftIndent = 6
        ToolTipItem9.Text = "For Each Product" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Count How Many DVD (products_dvd) with " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             Statu" & _
            "s = 1 (OK) " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             InOut = 1 (In stock)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Place th" & _
            "e Result in products.products_quantity"
        SuperToolTip9.Items.Add(ToolTipTitleItem9)
        SuperToolTip9.Items.Add(ToolTipItem9)
        Me.btnClearBoxes.SuperTip = SuperToolTip9
        Me.btnClearBoxes.TabIndex = 27
        Me.btnClearBoxes.Text = "Clear Boxes"
        '
        'btnReNumberBoxes
        '
        Me.btnReNumberBoxes.Location = New System.Drawing.Point(16, 104)
        Me.btnReNumberBoxes.Name = "btnReNumberBoxes"
        Me.btnReNumberBoxes.Size = New System.Drawing.Size(264, 23)
        ToolTipTitleItem10.Text = "Re-Calc Products Qty Now"
        ToolTipItem10.LeftIndent = 6
        ToolTipItem10.Text = "For Each Product" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Count How Many DVD (products_dvd) with " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             Statu" & _
            "s = 1 (OK) " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             InOut = 1 (In stock)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Place th" & _
            "e Result in products.products_quantity"
        SuperToolTip10.Items.Add(ToolTipTitleItem10)
        SuperToolTip10.Items.Add(ToolTipItem10)
        Me.btnReNumberBoxes.SuperTip = SuperToolTip10
        Me.btnReNumberBoxes.TabIndex = 25
        Me.btnReNumberBoxes.Text = "Re-Numbre DVDs in Boxes"
        '
        'GroupControl2
        '
        Me.GroupControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl2.Controls.Add(Me.LabelControl19)
        Me.GroupControl2.Controls.Add(Me.LabelControl20)
        Me.GroupControl2.Controls.Add(Me.txtToBoxID)
        Me.GroupControl2.Controls.Add(Me.txtFromBoxID)
        Me.GroupControl2.Location = New System.Drawing.Point(16, 16)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(264, 80)
        Me.GroupControl2.TabIndex = 26
        Me.GroupControl2.Text = "Box Range"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(136, 32)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl19.TabIndex = 3
        Me.LabelControl19.Text = "To Box ID "
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(16, 32)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl20.TabIndex = 2
        Me.LabelControl20.Text = "From Box ID "
        '
        'txtToBoxID
        '
        Me.txtToBoxID.EditValue = "99999999"
        Me.txtToBoxID.Location = New System.Drawing.Point(136, 48)
        Me.txtToBoxID.Name = "txtToBoxID"
        Me.txtToBoxID.Size = New System.Drawing.Size(100, 20)
        Me.txtToBoxID.TabIndex = 1
        '
        'txtFromBoxID
        '
        Me.txtFromBoxID.EditValue = "0"
        Me.txtFromBoxID.Location = New System.Drawing.Point(16, 48)
        Me.txtFromBoxID.Name = "txtFromBoxID"
        Me.txtFromBoxID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFromBoxID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFromBoxID.Size = New System.Drawing.Size(100, 20)
        Me.txtFromBoxID.TabIndex = 0
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.btnTransferProductID)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl25)
        Me.XtraTabPage5.Controls.Add(Me.txtWLToProcess)
        Me.XtraTabPage5.Controls.Add(Me.txtToProdID1)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl24)
        Me.XtraTabPage5.Controls.Add(Me.txtFromProdID1)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl23)
        Me.XtraTabPage5.Controls.Add(Me.txtCustLang1)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl22)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(1031, 313)
        Me.XtraTabPage5.Text = "Transfer ProductID"
        '
        'btnTransferProductID
        '
        Me.btnTransferProductID.Location = New System.Drawing.Point(128, 96)
        Me.btnTransferProductID.Name = "btnTransferProductID"
        Me.btnTransferProductID.Size = New System.Drawing.Size(75, 23)
        Me.btnTransferProductID.TabIndex = 29
        Me.btnTransferProductID.Text = "GO"
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(16, 128)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl25.TabIndex = 28
        Me.LabelControl25.Text = "WL To Process"
        '
        'txtWLToProcess
        '
        Me.txtWLToProcess.EditValue = "0"
        Me.txtWLToProcess.Location = New System.Drawing.Point(128, 128)
        Me.txtWLToProcess.Name = "txtWLToProcess"
        Me.txtWLToProcess.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtWLToProcess.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtWLToProcess.Size = New System.Drawing.Size(100, 20)
        Me.txtWLToProcess.TabIndex = 27
        '
        'txtToProdID1
        '
        Me.txtToProdID1.Location = New System.Drawing.Point(320, 40)
        Me.txtToProdID1.Name = "txtToProdID1"
        Me.txtToProdID1.Size = New System.Drawing.Size(100, 20)
        Me.txtToProdID1.TabIndex = 6
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(248, 43)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl24.TabIndex = 5
        Me.LabelControl24.Text = "To Product ID"
        '
        'txtFromProdID1
        '
        Me.txtFromProdID1.Location = New System.Drawing.Point(128, 40)
        Me.txtFromProdID1.Name = "txtFromProdID1"
        Me.txtFromProdID1.Size = New System.Drawing.Size(100, 20)
        Me.txtFromProdID1.TabIndex = 4
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(16, 43)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl23.TabIndex = 3
        Me.LabelControl23.Text = "From Product ID"
        '
        'txtCustLang1
        '
        Me.txtCustLang1.Location = New System.Drawing.Point(128, 16)
        Me.txtCustLang1.Name = "txtCustLang1"
        Me.txtCustLang1.Size = New System.Drawing.Size(100, 20)
        Me.txtCustLang1.TabIndex = 2
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(16, 19)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl22.TabIndex = 1
        Me.LabelControl22.Text = "Customer Language"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.LabelControl30)
        Me.XtraTabPage6.Controls.Add(Me.txtTableProcessed)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl29)
        Me.XtraTabPage6.Controls.Add(Me.txtToProducts_ID_1)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl28)
        Me.XtraTabPage6.Controls.Add(Me.txtFromProducts_ID_1)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl27)
        Me.XtraTabPage6.Controls.Add(Me.txtDVDID_1)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl26)
        Me.XtraTabPage6.Controls.Add(Me.txtProductsID_1)
        Me.XtraTabPage6.Controls.Add(Me.btnLoadNbrRotation)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(1031, 313)
        Me.XtraTabPage6.Text = "Load Nbr of Rotations"
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(76, 18)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl30.TabIndex = 10
        Me.LabelControl30.Text = "Table Processed"
        '
        'txtTableProcessed
        '
        Me.txtTableProcessed.EditValue = "orders_products_2006_07"
        Me.txtTableProcessed.Location = New System.Drawing.Point(154, 15)
        Me.txtTableProcessed.Name = "txtTableProcessed"
        Me.txtTableProcessed.Size = New System.Drawing.Size(305, 20)
        Me.txtTableProcessed.TabIndex = 9
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(272, 44)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl29.TabIndex = 8
        Me.LabelControl29.Text = "Products_ID"
        '
        'txtToProducts_ID_1
        '
        Me.txtToProducts_ID_1.Location = New System.Drawing.Point(350, 41)
        Me.txtToProducts_ID_1.Name = "txtToProducts_ID_1"
        Me.txtToProducts_ID_1.Size = New System.Drawing.Size(109, 20)
        Me.txtToProducts_ID_1.TabIndex = 7
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(76, 44)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl28.TabIndex = 6
        Me.LabelControl28.Text = "Products_ID"
        '
        'txtFromProducts_ID_1
        '
        Me.txtFromProducts_ID_1.Location = New System.Drawing.Point(154, 41)
        Me.txtFromProducts_ID_1.Name = "txtFromProducts_ID_1"
        Me.txtFromProducts_ID_1.Size = New System.Drawing.Size(109, 20)
        Me.txtFromProducts_ID_1.TabIndex = 5
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(76, 125)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl27.TabIndex = 4
        Me.LabelControl27.Text = "DVD_ID"
        '
        'txtDVDID_1
        '
        Me.txtDVDID_1.Location = New System.Drawing.Point(154, 122)
        Me.txtDVDID_1.Name = "txtDVDID_1"
        Me.txtDVDID_1.Size = New System.Drawing.Size(109, 20)
        Me.txtDVDID_1.TabIndex = 3
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(76, 99)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl26.TabIndex = 2
        Me.LabelControl26.Text = "Products_ID"
        '
        'txtProductsID_1
        '
        Me.txtProductsID_1.Location = New System.Drawing.Point(154, 96)
        Me.txtProductsID_1.Name = "txtProductsID_1"
        Me.txtProductsID_1.Size = New System.Drawing.Size(109, 20)
        Me.txtProductsID_1.TabIndex = 1
        '
        'btnLoadNbrRotation
        '
        Me.btnLoadNbrRotation.Location = New System.Drawing.Point(154, 67)
        Me.btnLoadNbrRotation.Name = "btnLoadNbrRotation"
        Me.btnLoadNbrRotation.Size = New System.Drawing.Size(109, 23)
        Me.btnLoadNbrRotation.TabIndex = 0
        Me.btnLoadNbrRotation.Text = "Set Nbr of Rotation"
        '
        'frmStockUtility
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 374)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmStockUtility"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtToID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtIDBeeingProcessed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtToDVDID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFROMDVDID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDirectorID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDirectorID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTOActorID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromActorID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.txtTotDVDOutOK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPivotDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPivotDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotDVDInOK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotDVDIn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotDVDOut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotDVD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtToBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        Me.XtraTabPage5.PerformLayout()
        CType(Me.txtWLToProcess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToProdID1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromProdID1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustLang1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        Me.XtraTabPage6.PerformLayout()
        CType(Me.txtTableProcessed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToProducts_ID_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromProducts_ID_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDID_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductsID_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Private Sub frmStockUtility_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPivotDate.EditValue = DateAdd(DateInterval.Month, -3, Now)
    End Sub
    Private Sub btnReCalcQtyNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReCalcQtyNow.Click

        Dim _DS As New DataSet
        _DS.Tables.Add("products")
        Dim _FromID, _ToID As Integer
        If IsNumeric(txtFromID.EditValue) Then
            _FromID = txtFromID.EditValue
        Else
            _FromID = 0
        End If
        If IsNumeric(txtToID.EditValue) Then
            _ToID = txtToID.EditValue
        Else
            _ToID = 9999999
        End If

        Dim _PSQLTxt As String = "SELECT products_id, products_quantity, products_dvd_quantity FROM products " & _
                     " WHERE products_type <> 'ABO'  and products_id >= " & _FromID & " AND products_id <= " & _ToID
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("products"), _PSQLTxt)
        ProgressBarControl1.Visible = True
        ProgressBarControl1.Properties.Minimum = 1
        ProgressBarControl1.Properties.Maximum = _DS.Tables("products").Rows.Count
        ProgressBarControl1.EditValue = 1
        SpinEdit1.Value = 0
        SpinEdit1.Visible = True
        Dim _i As Integer = 1
        Dim _row As DataRow
        Dim _SQLTxt As String = ""
        Dim _NewQtyNow As Integer
        Dim _CorrInt As Integer = 0

        For Each _row In _DS.Tables("products").Rows
            _i += 1
            ProgressBarControl1.EditValue += 1
            txtIDBeeingProcessed.EditValue = _row("products_id")
            _SQLTxt = "SELECT count(*) from products_dvd where products_id = " & _row("products_id") & _
             " AND products_dvd_status = 1 and `inout` = 1 "
            _NewQtyNow = BKGlobal.ExecuteCount(_SQLTxt)
            If _row("products_quantity") <> _NewQtyNow Then
                _CorrInt += 1
                SpinEdit1.Value += 1
            End If
            _row.BeginEdit()
            _row("products_quantity") = _NewQtyNow
            _row.EndEdit()
            If _i Mod 100 Then
                BKGlobal.Cls1.UpdateDataSource(_DS.Tables("products"), _PSQLTxt)
                ProgressBarControl1.Refresh()
                SpinEdit1.Refresh()
            End If
            DoEvents()
        Next
        BKGlobal.Cls1.UpdateDataSource(_DS.Tables("products"), _PSQLTxt)
        MsgBox("Done, Corrected : " & _CorrInt.ToString & " Products.", MsgBoxStyle.Information)
        ProgressBarControl1.Visible = False
        SpinEdit1.Visible = False
    End Sub
    Private Sub btnCopyDVD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyDVD.Click
        Dim sSQL As String
        Dim _i As Integer
        Dim _result As Integer

        If Not IsNumeric(txtFROMDVDID.EditValue) Or Not IsNumeric(txtToDVDID.EditValue) Then
            MsgBox("FROM and TO DVD_ID must be a number", MsgBoxStyle.Critical)
            Exit Sub
        End If

        For _i = txtFROMDVDID.EditValue To txtToDVDID.EditValue
            sSQL = "INSERT INTO `dvdpost_be_prod`.`products` SELECT * FROM `dvdpost_be_test`.`products` where `dvdpost_be_test`.`products`.products_id = " & _i
            _result = DvdPostData.clsConnection.ExecuteNonQuery(sSQL)
            If _result = 0 Then
                sSQL = "DELETE FROM `dvdpost_be_prod`.`products` where `dvdpost_be_prod`.`products`.products_id = " & _i
                _result = DvdPostData.clsConnection.ExecuteNonQuery(sSQL)
                sSQL = "INSERT INTO `dvdpost_be_prod`.`products` SELECT * FROM `dvdpost_be_test`.`products` where `dvdpost_be_test`.`products`.products_id = " & _i
                _result = DvdPostData.clsConnection.ExecuteNonQuery(sSQL)
            End If

        Next

        sSQL = "INSERT INTO `dvdpost_be_prod`.`products_description` SELECT pd.* FROM `dvdpost_be_test`.`products_description` pd where pd.products_id >= " & txtFROMDVDID.EditValue & " AND pd.products_id <= " & txtToDVDID.EditValue
        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)

        sSQL = "INSERT INTO `dvdpost_be_prod`.`products_to_actors` SELECT pa.* FROM `dvdpost_be_test`.`products_to_actors` pa where  pa.products_id >= " & txtFROMDVDID.EditValue & " AND pa.products_id <= " & txtToDVDID.EditValue
        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)

        sSQL = "INSERT INTO `dvdpost_be_prod`.`products_to_categories` SELECT pc.* FROM `dvdpost_be_test`.`products_to_categories` pc  where  pc.products_id >= " & txtFROMDVDID.EditValue & " AND pc.products_id <= " & txtToDVDID.EditValue
        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)

        sSQL = "INSERT INTO `dvdpost_be_prod`.`products_to_themes` SELECT pt.* FROM `dvdpost_be_test`.`products_to_themes` pt where pt.products_id >= " & txtFROMDVDID.EditValue & " AND pt.products_id <= " & txtToDVDID.EditValue
        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)

        sSQL = "INSERT INTO `dvdpost_be_prod`.`products_to_soundtracks` SELECT ps.* FROM `dvdpost_be_test`.`products_to_soundtracks` ps where ps.products_id >= " & txtFROMDVDID.EditValue & " AND ps.products_id <= " & txtToDVDID.EditValue
        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)

        sSQL = "INSERT INTO `dvdpost_be_prod`.`products_to_undertitles` SELECT pu.* FROM `dvdpost_be_test`.`products_to_undertitles` pu  where pu.products_id >= " & txtFROMDVDID.EditValue & " AND pu.products_id <= " & txtToDVDID.EditValue
        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)

        sSQL = "INSERT INTO `dvdpost_be_prod`.`products_to_languages` SELECT pl.* FROM `dvdpost_be_test`.`products_to_languages` pl  where pl.products_id >= " & txtFROMDVDID.EditValue & " AND pl.products_id <= " & txtToDVDID.EditValue
        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)

        'RALPH
        'MyConnection.Open()
        ''BEN001 sSQL = "INSERT INTO `dvdpost_be_prod`.`products_dvd` SELECT * FROM `dvdpost_be_test`.`products_dvd` where `dvdpost_be_test`.`products_dvd`.products_id >" & maxprod
        'sSQL = "INSERT INTO `dvdpost_be_prod`.`products_dvd` SELECT * FROM `dvdpost_be_test`.`products_dvd` pd left join `dvdpost_be_test`.products p on (pd.products_id = p.products_id) where p.products_type = 'DVD_NORM' and pd.products_id >" & maxprod 'BEN001
        'mycommand = MyConnection.createcommand
        'mycommand.CommandText = sSQL
        'mycommand.ExecuteNonQuery()
        'mycommand.Dispose()
        'MyConnection.close()

    End Sub
    Private Sub btnCopyActors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyActors.Click
        Dim sSQL As String
        sSQL = "INSERT INTO `dvdpost_be_prod`.`actors` SELECT * FROM `dvdpost_be_test`.`actors` where `dvdpost_be_test`.`actors`.actors_id >= " & txtFromActorID.EditValue & " AND `dvdpost_be_test`.`actors`.actors_id <= " & txtTOActorID.EditValue
        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)
    End Sub
    Private Sub btnCopyDirectors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyDirectors.Click
        Dim sSQL As String
        sSQL = "INSERT INTO `dvdpost_be_prod`.`directors` SELECT * FROM `dvdpost_be_test`.`directors` where `dvdpost_be_test`.`directors`.directors_id >= " & txtFromDirectorID.EditValue & " AND `dvdpost_be_test`.`directors`.directors_id <= " & txtToDirectorID.EditValue
        DvdPostData.clsConnection.ExecuteNonQuery(sSQL)
    End Sub
#Region "Actif/Passif"
    Dim _DS_A_P As New DataSet

    Private Sub btnLoad1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadOrdersActifPassif.Click
        Dim _SQLTxt As String
        _DS_A_P = New DataSet
        _DS_A_P.Tables.Add("orders")
        _DS_A_P.Tables.Add("products_dvd")
        txtTotDVD.EditValue = BKGlobal.ExecuteCount("select count(*) as cnt from products_dvd")
        txtTotDVDOut.EditValue = BKGlobal.ExecuteCount("select count(*) as cnt from products_dvd where `inout` = 0 ")
        txtTotDVDIn.EditValue = BKGlobal.ExecuteCount("select count(*) as cnt from products_dvd where `inout` = 1 ")
        txtTotDVDInOK.EditValue = BKGlobal.ExecuteCount("select count(*) as cnt from products_dvd where `inout` = 1 and products_dvd_status = 1 ")
        txtTotDVDOutOK.EditValue = BKGlobal.ExecuteCount("select count(*) as cnt from products_dvd where `inout` = 0 and products_dvd_status = 1 ")
        txtTotM.EditValue = BKGlobal.ExecuteCount("select count(*) as cnt from products_dvd where stock_type = 'M'")
        txtTotA.EditValue = BKGlobal.ExecuteCount("select count(*) as cnt from products_dvd where stock_type = 'A'")
        txtTotP.EditValue = BKGlobal.ExecuteCount("select count(*) as cnt from products_dvd where stock_type = 'P'")
        DoEvents()
        _SQLTxt = " select op.orders_id, op.products_id, products_dvd from " & _
                    " orders_products op  " & _
                    " left join orders o on o.orders_id = op.orders_id " & _
                    " where date_purchased > '" & Year(txtPivotDate.EditValue) & "-" & Month(txtPivotDate.EditValue) & _
                    "-" & Day(txtPivotDate.EditValue) & "' " & _
                    " group by op.products_id, products_dvd "
        DvdPostData.clsConnection.FillDataSet(_DS_A_P.Tables("orders"), _SQLTxt)
        _SQLTxt = " SELECT products_id, products_dvdid , stock_type from products_dvd where `inout` = 1 and products_dvd_status = 1"
        DvdPostData.clsConnection.FillDataSet(_DS_A_P.Tables("products_dvd"), _SQLTxt)
    End Sub
    Private Sub btnActifOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActifOUT.Click
        Dim _SQLTxt As String
        _SQLTxt = "UPDATE products_dvd set stock_type = 'A' where ``inout`` = 0"
        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
    End Sub
    Private Sub btnMiscInNotOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiscInNotOK.Click
        Dim _SQLTxt As String
        _SQLTxt = "UPDATE products_dvd set stock_type = 'M' where ``inout`` = 1 and products_dvd_status <> 1 "
        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
    End Sub
    Private Sub btnSetToPassif_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetToPassif.Click
        Dim _row As DataRow
        Dim _orders_row() As DataRowView
        Dim _view As DataView
        Dim _SQLTXt As String
        Dim _Sock_Type As String
        Dim _Nbr_A As Integer = 0
        Dim _Nbr_P As Integer = 0
        Dim _Nbr_Of_Orders As Integer = 0
        _view = New DataView(_DS_A_P.Tables("orders"), "", "products_id, products_dvd", DataViewRowState.CurrentRows)
        txtTotDVDInOK.EditValue = _DS_A_P.Tables("products_dvd").Rows.Count
        For Each _row In _DS_A_P.Tables("products_dvd").Rows
            _orders_row = _view.FindRows(New Object() {_row("products_id"), _row("products_dvdid")})
            _Nbr_Of_Orders = BKGlobal.ExecuteCount(" select count(*) " & _
                    " FROM orders_products op  " & _
                    " where op.products_id = " & _row("products_id"))

            If _orders_row.GetLength(0) = 0 Then
                If _Nbr_Of_Orders = 0 Then
                    _Sock_Type = "A"
                    _Nbr_A += 1
                Else
                    _Sock_Type = "P"
                    _Nbr_P += 1
                End If
            Else
                _Sock_Type = "A"
                _Nbr_A += 1
            End If
            _SQLTXt = "Update products_dvd set stock_type = '" & _Sock_Type & "' where products_id = " & _row("products_id") & _
             " AND products_dvdid = " & _row("products_dvdid")
            DvdPostData.clsConnection.ExecuteNonQuery(_SQLTXt)
            txtTotDVDInOK.EditValue -= 1
            DoEvents()
        Next
        txtTotDVDInOK.EditValue = _DS_A_P.Tables("products_dvd").Rows.Count
        DoEvents()
        MsgBox("Process Complete" & vbCrLf & "Nbr of A = " & _Nbr_A.ToString & vbCrLf & "Nbr of P = " & _Nbr_P.ToString, MsgBoxStyle.Information)
    End Sub

#End Region
    Private Sub btnReNumberBoxes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReNumberBoxes.Click
        Dim _Boxid As Integer = 0
        Dim _i As Integer
        Dim _row As DataRowView
        Dim objDS As New dsProducts
        'Dim _view As New DataView(objDS.Tables("products_dvd_stock_1"), "", "pibox_id", DataViewRowState.CurrentRows)
        Dim _SQLTxt As String
        Dim StartBoxID As Integer = txtFromBoxID.EditValue
        Dim EndBoxID As Integer = txtToBoxID.EditValue

        For _Boxid = StartBoxID To EndBoxID Step 1
            _SQLTxt = "SELECT PD.products_id, PD.products_dvdid, PD.products_dvd_status, PD.box_id, PD.pibox_id, " & _
                                    " P.products_model as products_model, PD.`inout` " & _
                                    " FROM products_dvd PD " & _
                                    " Left join products P on P.products_id = PD.products_id " & _
                                    " where `inout` >= 1 and PD.box_id = '" & _Boxid & "' Order by pibox_id "
            objDS.Tables("products_dvd_stock_1").Clear()
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_dvd_stock_1"), _SQLTxt)
            _i = 0
            For Each _row In objDS.Tables("products_dvd_stock_1").Rows
                _i += 1
                _row("pibox_id") = _i
                _SQLTxt = "UPDATE products_dvd set pibox_id = " & _i & " where products_id = " & _row("products_id") & _
                          " AND products_dvdid = " & _row("products_dvdid")
                DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
            Next
        Next
    End Sub
    Private Sub btnSetAvailability_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetAvailability.Click
        Dim _DS As New DataSet
        _DS.Tables.Add("products")
        Dim _FromID, _ToID As Integer
        If IsNumeric(txtFromID.EditValue) Then
            _FromID = txtFromID.EditValue
        Else
            _FromID = 0
        End If
        If IsNumeric(txtToID.EditValue) Then
            _ToID = txtToID.EditValue
        Else
            _ToID = 9999999
        End If

        Dim _PSQLTxt As String = "SELECT products_id, products_availability, products_dvd_quantity FROM products " & _
                     " WHERE products_type <> 'ABO'  and products_id >= " & _FromID & " AND products_id <= " & _ToID
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("products"), _PSQLTxt)
        ProgressBarControl1.Visible = True
        ProgressBarControl1.Properties.Minimum = 1
        ProgressBarControl1.Properties.Maximum = _DS.Tables("products").Rows.Count
        ProgressBarControl1.EditValue = 1
        SpinEdit1.Value = 0
        SpinEdit1.Visible = True
        Dim _i As Integer = 1
        Dim _row As DataRow
        Dim _SQLTxt As String = ""
        Dim _NewQtyNow As Integer
        Dim _CorrInt As Integer = 0
        Dim _CorrInt1 As Integer = 0
        For Each _row In _DS.Tables("products").Rows
            _i += 1
            ProgressBarControl1.EditValue += 1
            txtIDBeeingProcessed.EditValue = _row("products_id")
            _SQLTxt = "SELECT count(*) from products_dvd where products_id = " & _row("products_id") & _
             " AND products_dvd_status = 1  "
            _NewQtyNow = BKGlobal.ExecuteCount(_SQLTxt)

            SpinEdit1.Value += 1
            If _NewQtyNow > 0 Then
                _CorrInt += 1
                _row.BeginEdit()
                _row("products_availability") = 1
                _row.EndEdit()
            Else
                '_CorrInt += 1
                'SpinEdit1.Value += 1
                _CorrInt1 += 1
                _row.BeginEdit()
                _row("products_availability") = 0
                _row.EndEdit()
            End If
            If _i Mod 100 Then
                BKGlobal.Cls1.UpdateDataSource(_DS.Tables("products"), _PSQLTxt)
                ProgressBarControl1.Refresh()
                SpinEdit1.Refresh()
            End If
            DoEvents()
        Next
        BKGlobal.Cls1.UpdateDataSource(_DS.Tables("products"), _PSQLTxt)
        MsgBox("Done, Set : " & _CorrInt.ToString & " to Availables and " & _CorrInt1.ToString & " To UNAvailableProducts.", MsgBoxStyle.Information)
        ProgressBarControl1.Visible = False
        SpinEdit1.Visible = False
    End Sub
    Private Sub btnLongTimeCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLongTimeCust.Click
        Dim _row As DataRow
        Dim _orders_row() As DataRowView
        Dim _view As DataView
        Dim _Nbr_A As Integer = 0
        Dim _Nbr_P As Integer = 0
        Dim _Nbr_Of_Orders As Integer = 0
        Dim _DSProducts As New dsProducts
        _view = New DataView(_DS_A_P.Tables("orders"), "", "products_id, products_dvd", DataViewRowState.CurrentRows)
        txtTotDVDOutOK.EditValue = _DS_A_P.Tables("products_dvd").Rows.Count
        For Each _row In _DS_A_P.Tables("products_dvd").Rows
            _orders_row = _view.FindRows(New Object() {_row("products_id"), _row("products_dvdid")})
            If _orders_row.GetLength(0) = 0 Then
                'Do not Change Status
            Else
                'DVD was Expedieted Before the Pivot Date and not returned.
                'Set the Status to Long Time @ Customer = 17
                Dim objProductDVD As New clsProduct_DVD(SessionInfo, _DSProducts, _row("products_id"), _row("products_dvdid"))
                objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.LONGTIME_CUSTOMER, _
                                                     "Stock_Utility Long time @ Cust", _
                                                     DvdPostData.ClsProducts_dvd_state.state.STOCK)
                _Nbr_A += 1
            End If
            txtTotDVDOutOK.EditValue -= 1
            DoEvents()
        Next
        txtTotDVDInOK.EditValue = _DS_A_P.Tables("products_dvd").Rows.Count
        DoEvents()
        MsgBox("Process Complete" & vbCrLf & "Nbr of LongTime@Customer = " & _Nbr_A.ToString, MsgBoxStyle.Information)

    End Sub
    Private Sub btnLoadLongTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadLongTime.Click
        Dim _SQLTxt As String
        _DS_A_P = New DataSet
        _DS_A_P.Tables.Add("orders")
        _DS_A_P.Tables.Add("products_dvd")
        txtTotDVD.EditValue = BKGlobal.ExecuteCount("select count(*) as cnt from products_dvd")
        txtTotDVDOut.EditValue = BKGlobal.ExecuteCount("select count(*) as cnt from products_dvd where `inout` = 0 ")
        txtTotDVDIn.EditValue = BKGlobal.ExecuteCount("select count(*) as cnt from products_dvd where `inout` = 1 ")
        txtTotDVDInOK.EditValue = BKGlobal.ExecuteCount("select count(*) as cnt from products_dvd where `inout` = 1 and products_dvd_status = 1 ")
        txtTotDVDOutOK.EditValue = BKGlobal.ExecuteCount("select count(*) as cnt from products_dvd where `inout` = 0 and products_dvd_status = 1 ")
        DoEvents()
        'Load Orders with Status Expedited
        _SQLTxt = " select op.orders_id, op.products_id, products_dvd from " & _
            " orders_products op  " & _
            " left join orders o on o.orders_id = op.orders_id " & _
            " where date_purchased < '" & Year(txtPivotDate.EditValue) & "-" & Month(txtPivotDate.EditValue) & _
            "-" & Day(txtPivotDate.EditValue) & "' and orders_products_status = 1 " & _
            " group by op.products_id, products_dvd "
        DvdPostData.clsConnection.FillDataSet(_DS_A_P.Tables("orders"), _SQLTxt)
        _SQLTxt = " SELECT products_id, products_dvdid , stock_type, products_dvd_status from products_dvd where `inout` = 0 and products_dvd_status = 1"
        DvdPostData.clsConnection.FillDataSet(_DS_A_P.Tables("products_dvd"), _SQLTxt)
    End Sub

    Private Sub UpdateSoundtracks(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _ds As New DataSet
        _ds.Tables.Add("products_to_soundtracks")
        _ds.Tables.Add("products_soundtracks")
        DvdPostData.clsConnection.FillDataSet(_ds.Tables("products_to_soundtracks"), "SELECT * from products_to_soundtracks")
        Dim _row As DataRow
        Dim _newID As Integer
        Dim _oldID As Integer
        Dim _Exist As Boolean = False
        For Each _row In _ds.Tables("products_to_soundtracks").Rows
            _oldID = _row("products_soundtracks_id")
            If _oldID > 6 Then
                Select Case _oldID '_row("products_soundtracks_id")
                    Case 7
                        _newID = 1
                    Case 8
                        _newID = 2
                    Case 9
                        _newID = 3
                    Case 10
                        _newID = 4
                    Case 11
                        _newID = 5
                    Case 12
                        _newID = 6
                    Case 13
                        _newID = 1
                    Case 14
                        _newID = 2
                    Case 15
                        _newID = 3
                    Case 16
                        _newID = 4
                    Case 17
                        _newID = 5
                    Case 18
                        _newID = 6
                End Select
                _Exist = BKGlobal.ExecuteExists("SELECT count(*) FROM products_to_soundtracks where products_id = " & _row("products_id") & " AND products_soundtracks_id = " & _newID)
                If _Exist = True Then
                    'Delete Current
                    DvdPostData.clsConnection.ExecuteNonQuery("DELETE FROM products_to_soundtracks  WHERE products_id = " & _row("products_id") & " AND products_soundtracks_id = " & _oldID)
                Else
                    'Update Current
                    DvdPostData.clsConnection.ExecuteNonQuery("UPDATE products_to_soundtracks set products_soundtracks_id = " & _newID & " WHERE products_id = " & _row("products_id") & " AND products_soundtracks_id = " & _oldID)
                End If
            End If
        Next
    End Sub

    Private Sub btnTransferProductID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferProductID.Click
        Dim sSQL2 As String = "SELECT w.wl_id, w.customers_id, w.product_id, c.customers_language from wishlist w,  customers c where w.customers_id = c.customers_id and c.customers_language  = '" & txtCustLang1.EditValue & "' and w.product_id = '" & txtFromProdID1.EditValue & "' "
        Dim _DS As New DataSet
        _DS.Tables.Add("TmpTable")
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("TmpTable"), sSQL2)
        Dim _row As DataRow
        Dim i, j As Integer
        Dim ssql3 As String = ""
        Dim _Exist As Boolean = False
        txtWLToProcess.EditValue = _DS.Tables("TmpTable").Rows.Count
        DoEvents()
        For Each _row In _DS.Tables("TmpTable").Rows
            txtWLToProcess.EditValue -= 1
            DoEvents()
            _Exist = BKGlobal.ExecuteExists("select count(*) as cnt from wishlist w " & _
                   " where product_id = " & txtToProdID1.EditValue & " and w.customers_id = " & _row("customers_id"))
            Try
                If _Exist Then
                    ssql3 = "delete from  wishlist where wl_id   = '" & _row("wl_id") & "' and product_id = '" & txtFromProdID1.EditValue & "'  "
                    DvdPostData.clsConnection.ExecuteNonQuery(ssql3)
                    j = j + 1
                Else
                    ssql3 = "update wishlist  set product_id = '" & txtToProdID1.EditValue & "' where wl_id   = '" & _row("wl_id") & "' and product_id = '" & txtFromProdID1.EditValue & "'  "
                    DvdPostData.clsConnection.ExecuteNonQuery(ssql3)
                    i = i + 1
                End If
            Catch ex As Exception
                DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, ex)
            End Try
        Next
        MsgBox(i & " entries Done; " & j & " deleted because double ", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub btnLoadNbrRotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadNbrRotation.Click
        Dim _ds As New DataSet
        _ds.Tables.Add("products_dvd")
        _ds.Tables.Add("tmp1")
        Dim _OrderTableName As String = txtTableProcessed.Text
        DvdPostData.clsConnection.FillDataSet(_ds.Tables("products_dvd"), "SELECT products_id, products_dvdid, nbr_rotation from products_dvd " & _
                  " WHERE products_id >= " & txtFromProducts_ID_1.EditValue & " AND products_id <= " & txtToProducts_ID_1.EditValue)
        Dim _row As DataRow
        Dim _nbr_of_rotation As Integer
        For Each _row In _ds.Tables("products_dvd").Rows
            txtProductsID_1.EditValue = _row("products_id")
            txtDVDID_1.EditValue = _row("products_dvdid")
            'txtProductsID_1.Refresh()
            'txtDVDID_1.Refresh()
            _nbr_of_rotation = BKGlobal.ExecuteCount("Select count(*) from " & _OrderTableName & " where products_id = " & _row("products_id") & _
                                                     " AND products_dvd = " & _row("products_dvdid"))
            DvdPostData.clsConnection.ExecuteNonQuery("UPDATE products_dvd set nbr_rotation = nbr_rotation + " & _nbr_of_rotation & _
                                            " , nbr_rotation_since_last_check = nbr_rotation_since_last_check + " & _nbr_of_rotation & _
                                           " WHERE products_id = " & _row("products_id") & _
                                           " AND products_dvdid = " & _row("products_dvdid"))
            DoEvents()
        Next
    End Sub

    Private Sub btnClearBoxes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearBoxes.Click
        Dim TableName As String = "products_dvd_stock_1"
        Dim _SQLTxt As String
        Dim _row As DataRow
        Dim _DS As New dsProducts
        Dim objProductDVD As clsProduct_DVD
        Dim _BoxID As Integer
        For _BoxID = txtFromBoxID.EditValue To txtToBoxID.EditValue
            _SQLTxt = "SELECT PD.products_id, PD.products_dvdid, PD.products_dvd_status, PD.box_id, PD.pibox_id, " & _
                        " P.products_model as products_model, PD.`inout` FROM products_dvd PD " & _
                        " Left join products P on P.products_id = PD.products_id " & _
                        " where PD.`inout` >= 1 and PD.box_id = '" & _BoxID & "' Order by pibox_id "
            _DS.Tables(TableName).Clear()
            DvdPostData.clsConnection.FillDataSet(_DS.Tables(TableName), _SQLTxt)
            For Each _row In _DS.Tables(TableName).Rows
                objProductDVD = New clsProduct_DVD(SessionInfo, _DS, _row("products_id"), _row("products_dvdid"))

                objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.BIZARREMENT_PERDU, _
                                                     "Stock-Utilities - Clearing a Multi-Boxes", _
                                                     DvdPostData.ClsProducts_dvd_state.state.STOCK)

            Next
        Next
    End Sub
End Class
