
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository

Namespace BizzLib
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmTestDavid
        Inherits DevExpress.XtraEditors.XtraForm

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
        ' Fields
        Private Shared _ENCList As ArrayList = New ArrayList

        Private _barDockControlBottom As BarDockControl

        Private _barDockControlLeft As BarDockControl

        Private _barDockControlRight As BarDockControl

        Private _barDockControlTop As BarDockControl

        Private _BarManager1 As BarManager




        Private _btnComments As BarButtonItem

        Private _btnCopyDefault As BarButtonItem

        Private _btnCopyFilter As BarButtonItem

        Private _btnCopyReport As BarButtonItem

        Private _btnCopyView As BarButtonItem

        Private _btnDefault As BarButtonItem

        Private _btnDefaultDetail As BarSubItem

        Private _btnDelete As BarButtonItem

        Private _btnDeleteDefault As BarButtonItem

        Private _btnDeleteFilter As BarButtonItem

        Private _btnDeleteReport As BarButtonItem

        Private _btnDeleteView As BarButtonItem
        Private _btnDesignReport As BarButtonItem
        Private _btnEdit As BarButtonItem
        Private _btnEditDefault As BarButtonItem
        Private _btnEditFilter As BarButtonItem
        Private _btnEditReportInfo As BarButtonItem
        Private _btnEditView As BarButtonItem
        Private _btnExportXML As BarButtonItem
        Private _btnFilter As BarButtonItem
        Private _btnFilterDetail As BarSubItem
        Private _btnFirst As BarButtonItem
        Private _btnImportXML As BarButtonItem
        Private _btnLast As BarButtonItem
        Private _btnMakeDefaultCommon As BarButtonItem
        Private _btnMakeFilterCommon As BarButtonItem
        Private _btnMakeReportCommon As BarButtonItem
        Private _btnMakeViewCommon As BarButtonItem
        Private _btnNew As BarButtonItem
        Private _btnNewDefault As BarButtonItem
        Private _btnNewFilter As BarButtonItem
        Private _btnNewReport As BarButtonItem
        Private _btnNewView As BarButtonItem
        Private _btnNext As BarButtonItem
        Private _btnOK As BarButtonItem
        Private _btnPrevious As BarButtonItem
        Private _btnPrint As BarButtonItem
        Private _btnQuickSearch As BarButtonItem
        Private _btnReportDetail As BarSubItem
        Private _btnSave As BarButtonItem
        Private _btnSaveDefault As BarButtonItem
        Private _btnSaveView As BarButtonItem
        Private _btnSendDefaultUser As BarButtonItem
        Private _btnSendFilterUSer As BarButtonItem
        Private _btnSendReportUser As BarButtonItem
        Private _btnSendViewUser As BarButtonItem
        Private _btnTranslation As BarButtonItem
        Private _btnUndo As BarButtonItem
        Private _btnUser1 As BarButtonItem
        Private _btnUser2 As BarButtonItem
        Private _btnUser3 As BarButtonItem
        Private _btnUser4 As BarButtonItem
        Private _btnUser5 As BarButtonItem
        Private _btnView As BarButtonItem
        Private _btnViewDetail As BarSubItem
        Private _cmbDefaultList As BarEditItem
        Private _cmbDefaultListRepos As RepositoryItemLookUpEdit
        Private _cmbFilterList As BarEditItem
        Private _cmbFilterListRepos As RepositoryItemLookUpEdit
        Private _cmbReportList As BarEditItem
        Private _cmbReportListRepos As RepositoryItemLookUpEdit
        Private _cmbViewList As BarEditItem
        Private _cmbViewListRepos As RepositoryItemLookUpEdit
        Private _Defaultset_Bar As Bar
        Private _DockManager1 As DockManager
        Private _Filter_Bar As Bar
        Private _Main_Bar As Bar
        Private _MainBtns_btnBestFit As BarButtonItem
        Private _MainBtns_btnBigger As BarButtonItem
        Private _MainBtns_btnExcel As BarButtonItem
        Private _MainBtns_btnSmaller As BarButtonItem
        Private _Misc_Bar As Bar
        Private _Misc_Bar2 As Bar
        Private _Nav_Bar As Bar
        Private _QuickSearch_Bar As Bar
        Private _Report_Bar As Bar

        Private _txtQuickSearch As BarEditItem

        Private _txtQuickSearchRepos As RepositoryItemTextEdit

        Private _View_Bar As Bar
        Public BKBrowseView As clsBrowseView
        Public BKCombo As clsCombo
        Public BKDefaultSet As clsDefaultSet
        Public BKFilter As clsFilter
        Public BKGlobal As clsGlobal
        Public BKReport As clsReport
        Public Cls1 As clsDataSet

        Public mvarSessionInfo As clsSessionInfo
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()

            Me.BarManager1 = New BarManager(Me.components)
            Me.Main_Bar = New Bar
            Me.btnNew = New BarButtonItem
            Me.btnEdit = New BarButtonItem
            Me.btnDelete = New BarButtonItem
            Me.btnSave = New BarButtonItem
            Me.btnUndo = New BarButtonItem
            Me.Misc_Bar = New Bar
            Me.MainBtns_btnExcel = New BarButtonItem
            Me.MainBtns_btnBigger = New BarButtonItem
            Me.MainBtns_btnSmaller = New BarButtonItem
            Me.MainBtns_btnBestFit = New BarButtonItem
            Me.btnOK = New BarButtonItem
            Me.btnUser1 = New BarButtonItem
            Me.btnUser2 = New BarButtonItem
            Me.btnUser3 = New BarButtonItem
            Me.btnUser4 = New BarButtonItem
            Me.btnUser5 = New BarButtonItem
            Me.btnExportXML = New BarButtonItem
            Me.btnImportXML = New BarButtonItem
            Me.View_Bar = New Bar
            Me.btnView = New BarButtonItem
            Me.cmbViewList = New BarEditItem
            Me.cmbViewListRepos = New RepositoryItemLookUpEdit
            Me.btnViewDetail = New BarSubItem
            Me.btnEditView = New BarButtonItem
            Me.btnNewView = New BarButtonItem
            Me.btnDeleteView = New BarButtonItem
            Me.btnSaveView = New BarButtonItem
            Me.btnMakeViewCommon = New BarButtonItem
            Me.btnSendViewUser = New BarButtonItem
            Me.btnCopyView = New BarButtonItem
            Me.QuickSearch_Bar = New Bar
            Me.txtQuickSearch = New BarEditItem
            Me.txtQuickSearchRepos = New RepositoryItemTextEdit
            Me.btnQuickSearch = New BarButtonItem
            Me.Report_Bar = New Bar
            Me.btnPrint = New BarButtonItem
            Me.cmbReportList = New BarEditItem
            Me.cmbReportListRepos = New RepositoryItemLookUpEdit
            Me.btnReportDetail = New BarSubItem
            Me.btnEditReportInfo = New BarButtonItem
            Me.btnNewReport = New BarButtonItem
            Me.btnDeleteReport = New BarButtonItem
            Me.btnDesignReport = New BarButtonItem
            Me.btnMakeReportCommon = New BarButtonItem
            Me.btnSendReportUser = New BarButtonItem
            Me.btnCopyReport = New BarButtonItem
            Me.Filter_Bar = New Bar
            Me.btnFilter = New BarButtonItem
            Me.cmbFilterList = New BarEditItem
            Me.cmbFilterListRepos = New RepositoryItemLookUpEdit
            Me.btnFilterDetail = New BarSubItem
            Me.btnEditFilter = New BarButtonItem
            Me.btnNewFilter = New BarButtonItem
            Me.btnDeleteFilter = New BarButtonItem
            Me.btnMakeFilterCommon = New BarButtonItem
            Me.btnSendFilterUSer = New BarButtonItem
            Me.btnCopyFilter = New BarButtonItem
            Me.DefaultSet_Bar = New Bar
            Me.btnDefault = New BarButtonItem
            Me.cmbDefaultList = New BarEditItem
            Me.cmbDefaultListRepos = New RepositoryItemLookUpEdit
            Me.btnDefaultDetail = New BarSubItem
            Me.btnEditDefault = New BarButtonItem
            Me.btnNewDefault = New BarButtonItem
            Me.btnDeleteDefault = New BarButtonItem
            Me.btnSaveDefault = New BarButtonItem
            Me.btnMakeDefaultCommon = New BarButtonItem
            Me.btnSendDefaultUser = New BarButtonItem
            Me.btnCopyDefault = New BarButtonItem
            Me.Misc_Bar2 = New Bar
            Me.btnTranslation = New BarButtonItem
            Me.btnComments = New BarButtonItem
            Me.btnAttachements = New BarButtonItem
            Me.Nav_Bar = New Bar
            Me.btnFirst = New BarButtonItem
            Me.btnPrevious = New BarButtonItem
            Me.btnNext = New BarButtonItem
            Me.btnLast = New BarButtonItem
            Me.barDockControlTop = New BarDockControl
            Me.barDockControlBottom = New BarDockControl
            Me.barDockControlLeft = New BarDockControl
            Me.barDockControlRight = New BarDockControl
            Me.DockManager1 = New DockManager(Me.components)
            Me.BarManager1.BeginInit()
            Me.cmbViewListRepos.BeginInit()
            Me.txtQuickSearchRepos.BeginInit()
            Me.cmbReportListRepos.BeginInit()
            Me.cmbFilterListRepos.BeginInit()
            Me.cmbDefaultListRepos.BeginInit()
            Me.DockManager1.BeginInit()
            Me.SuspendLayout()
            Me.BarManager1.Bars.AddRange(New Bar() {Me.Main_Bar, Me.Misc_Bar, Me.View_Bar, Me.QuickSearch_Bar, Me.Report_Bar, Me.Filter_Bar, Me.DefaultSet_Bar, Me.Misc_Bar2, Me.Nav_Bar})
            Dim categoryArray As BarManagerCategory() = New BarManagerCategory(9 - 1) {}
            Dim guid As New Guid("434484d9-7ac5-47e5-9412-313a111b7240")
            categoryArray(0) = New BarManagerCategory("Main", guid)
            Dim guid2 As New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            categoryArray(1) = New BarManagerCategory("Miscelaneous", guid2)
            Dim guid3 As New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            categoryArray(2) = New BarManagerCategory("Views", guid3)
            Dim guid4 As New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            categoryArray(3) = New BarManagerCategory("Filters", guid4)
            Dim guid5 As New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            categoryArray(4) = New BarManagerCategory("Reporting", guid5)
            Dim guid6 As New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            categoryArray(5) = New BarManagerCategory("Default Values", guid6)
            Dim guid7 As New Guid("2d735e09-7c7c-4ed4-b3ca-996e094a2026")
            categoryArray(6) = New BarManagerCategory("Quick Search", guid7)
            Dim guid8 As New Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")
            categoryArray(7) = New BarManagerCategory("Misc_Maintenance", guid8)
            Dim guid9 As New Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
            categoryArray(8) = New BarManagerCategory("Navigation", guid9)
            Me.BarManager1.Categories.AddRange(categoryArray)
            Me.BarManager1.DockControls.Add(Me.barDockControlTop)
            Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager1.DockControls.Add(Me.barDockControlRight)
            Me.BarManager1.Form = Me
            Me.BarManager1.Items.AddRange(New BarItem() {Me.btnNew, Me.btnDelete, Me.btnEdit, Me.btnSave, Me.MainBtns_btnExcel, Me.MainBtns_btnBigger, Me.MainBtns_btnSmaller, Me.MainBtns_btnBestFit, Me.btnViewDetail, Me.btnNewView, Me.btnEditView, Me.btnDeleteView, Me.btnMakeViewCommon, Me.btnSendViewUser, Me.btnSaveView, Me.btnCopyView, Me.btnView, Me.cmbViewList, Me.btnQuickSearch, Me.txtQuickSearch, Me.btnPrint, Me.cmbReportList, Me.btnReportDetail, Me.btnEditReportInfo, Me.btnNewReport, Me.btnDeleteReport, Me.btnDesignReport, Me.btnMakeReportCommon, Me.btnSendReportUser, Me.btnCopyReport, Me.btnFilter, Me.btnFilterDetail, Me.cmbFilterList, Me.btnEditFilter, Me.btnNewFilter, Me.btnDeleteFilter, Me.btnMakeFilterCommon, Me.btnSendFilterUSer, Me.btnCopyFilter, Me.btnOK, Me.btnDefault, Me.cmbDefaultList, Me.btnDefaultDetail, Me.btnEditDefault, Me.btnNewDefault, Me.btnDeleteDefault, Me.btnSaveDefault, Me.btnMakeDefaultCommon, Me.btnSendDefaultUser, Me.btnCopyDefault, Me.btnUser1, Me.btnUser2, Me.btnUser3, Me.btnUser4, Me.btnUser5, Me.btnTranslation, Me.btnComments, Me.btnAttachements, Me.btnFirst, Me.btnPrevious, Me.btnNext, Me.btnLast, Me.btnUndo, Me.btnExportXML, Me.btnImportXML})
            Me.BarManager1.MaxItemId = &H49
            Me.BarManager1.RepositoryItems.AddRange(New RepositoryItem() {Me.cmbViewListRepos, Me.txtQuickSearchRepos, Me.cmbReportListRepos, Me.cmbFilterListRepos, Me.cmbDefaultListRepos})
            Me.Main_Bar.BarName = "Main_Bar"
            Me.Main_Bar.DockCol = 0
            Me.Main_Bar.DockRow = 0
            Me.Main_Bar.DockStyle = 2
            Dim point As New System.Drawing.Point(&HF6, &HB9)
            Me.Main_Bar.FloatLocation = point
            Me.Main_Bar.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnNew), New LinkPersistInfo(Me.btnEdit), New LinkPersistInfo(Me.btnDelete), New LinkPersistInfo(Me.btnSave), New LinkPersistInfo(Me.btnUndo)})
            Me.Main_Bar.Offset = 7
            Me.Main_Bar.Text = "Main Bar"
            Me.Main_Bar.Visible = False
            Me.btnNew.Caption = "New"
            guid9 = New Guid("434484d9-7ac5-47e5-9412-313a111b7240")
            Me.btnNew.CategoryGuid = guid9
            Me.btnNew.Glyph = System.Drawing.Image.FromFile("btnNew.Glyph")
            Me.btnNew.Id = 0
            Me.btnNew.Name = "btnNew"
            Me.btnEdit.Caption = "Edit"
            guid9 = New Guid("434484d9-7ac5-47e5-9412-313a111b7240")
            Me.btnEdit.CategoryGuid = guid9
            Me.btnEdit.Glyph = System.Drawing.Image.FromFile("btnEdit.Glyph")
            Me.btnEdit.Id = 2
            Me.btnEdit.Name = "btnEdit"
            Me.btnDelete.Caption = "Delete"
            guid9 = New Guid("434484d9-7ac5-47e5-9412-313a111b7240")
            Me.btnDelete.CategoryGuid = guid9
            Me.btnDelete.Glyph = System.Drawing.Image.FromFile("btnDelete.Glyph")
            Me.btnDelete.Id = 1
            Me.btnDelete.Name = "btnDelete"
            Me.btnSave.Caption = "Save"
            guid9 = New Guid("434484d9-7ac5-47e5-9412-313a111b7240")
            Me.btnSave.CategoryGuid = guid9
            Me.btnSave.Glyph = System.Drawing.Image.FromFile("btnSave.Glyph")
            Me.btnSave.Id = 3
            Me.btnSave.Name = "btnSave"
            Me.btnUndo.Caption = "Undo"
            Me.btnUndo.Glyph = System.Drawing.Image.FromFile("btnUndo.Glyph")
            Me.btnUndo.Id = 70
            Me.btnUndo.Name = "btnUndo"
            Me.btnUndo.Visibility = 1
            Me.Misc_Bar.BarName = "Misc_Bar"
            Me.Misc_Bar.DockCol = 1
            Me.Misc_Bar.DockRow = 0
            Me.Misc_Bar.DockStyle = 2
            Me.Misc_Bar.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.MainBtns_btnExcel), New LinkPersistInfo(Me.MainBtns_btnBigger), New LinkPersistInfo(Me.MainBtns_btnSmaller), New LinkPersistInfo(Me.MainBtns_btnBestFit), New LinkPersistInfo(BarLinkUserDefines.PaintStyle, Me.btnOK, BarItemPaintStyle.CaptionGlyph), New LinkPersistInfo(Me.btnUser1), New LinkPersistInfo(Me.btnUser2), New LinkPersistInfo(Me.btnUser3), New LinkPersistInfo(Me.btnUser4), New LinkPersistInfo(Me.btnUser5), New LinkPersistInfo(Me.btnExportXML), New LinkPersistInfo(Me.btnImportXML)})
            Me.Misc_Bar.Offset = &HB6
            Me.Misc_Bar.Text = "Misc. Bar"
            Me.Misc_Bar.Visible = False
            Me.MainBtns_btnExcel.Caption = "Excell"
            guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            Me.MainBtns_btnExcel.CategoryGuid = guid9
            Me.MainBtns_btnExcel.Glyph = System.Drawing.Image.FromFile("MainBtns_btnExcel.Glyph")
            Me.MainBtns_btnExcel.Id = 5
            Me.MainBtns_btnExcel.Name = "MainBtns_btnExcel"
            Me.MainBtns_btnBigger.Caption = "Bigger"
            guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            Me.MainBtns_btnBigger.CategoryGuid = guid9
            Me.MainBtns_btnBigger.Glyph = System.Drawing.Image.FromFile("MainBtns_btnBigger.Glyph")
            Me.MainBtns_btnBigger.Id = 6
            Me.MainBtns_btnBigger.Name = "MainBtns_btnBigger"
            Me.MainBtns_btnSmaller.Caption = "Smaller"
            guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            Me.MainBtns_btnSmaller.CategoryGuid = guid9
            Me.MainBtns_btnSmaller.Glyph = System.Drawing.Image.FromFile("MainBtns_btnSmaller.Glyph")
            Me.MainBtns_btnSmaller.Id = 7
            Me.MainBtns_btnSmaller.Name = "MainBtns_btnSmaller"
            Me.MainBtns_btnBestFit.Caption = "BestFit"
            guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            Me.MainBtns_btnBestFit.CategoryGuid = guid9
            Me.MainBtns_btnBestFit.Glyph = System.Drawing.Image.FromFile("MainBtns_btnBestFit.Glyph")
            Me.MainBtns_btnBestFit.Id = 8
            Me.MainBtns_btnBestFit.Name = "MainBtns_btnBestFit"
            Me.btnOK.Caption = "OK"
            guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            Me.btnOK.CategoryGuid = guid9
            Me.btnOK.Glyph = System.Drawing.Image.FromFile("btnOK.Glyph")
            Me.btnOK.Id = &H2E
            Me.btnOK.ItemShortcut = New BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Visibility = 1
            Me.btnUser1.Border = 2
            Me.btnUser1.Caption = "1"
            guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            Me.btnUser1.CategoryGuid = guid9
            Me.btnUser1.Id = &H3A
            Me.btnUser1.Name = "btnUser1"
            Me.btnUser1.Visibility = 1
            Me.btnUser2.Border = 2
            Me.btnUser2.Caption = "2"
            guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            Me.btnUser2.CategoryGuid = guid9
            Me.btnUser2.Id = &H3B
            Me.btnUser2.Name = "btnUser2"
            Me.btnUser2.Visibility = 1
            Me.btnUser3.Border = 2
            Me.btnUser3.Caption = "3"
            guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            Me.btnUser3.CategoryGuid = guid9
            Me.btnUser3.Id = 60
            Me.btnUser3.Name = "btnUser3"
            Me.btnUser3.Visibility = 1
            Me.btnUser4.Border = 2
            Me.btnUser4.Caption = "4"
            guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            Me.btnUser4.CategoryGuid = guid9
            Me.btnUser4.Id = &H3D
            Me.btnUser4.Name = "btnUser4"
            Me.btnUser4.Visibility = 1
            Me.btnUser5.Border = 2
            Me.btnUser5.Caption = "5"
            guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            Me.btnUser5.CategoryGuid = guid9
            Me.btnUser5.Id = &H3E
            Me.btnUser5.Name = "btnUser5"
            Me.btnUser5.Visibility = 1
            Me.btnExportXML.Border = 1
            Me.btnExportXML.Caption = "Export"
            Me.btnExportXML.Id = &H47
            Me.btnExportXML.Name = "btnExportXML"
            Me.btnImportXML.Border = 1
            Me.btnImportXML.Caption = "Import"
            Me.btnImportXML.Id = &H48
            Me.btnImportXML.Name = "btnImportXML"
            Me.View_Bar.BarName = "View_Bar"
            Me.View_Bar.DockCol = 4
            Me.View_Bar.DockRow = 0
            Me.View_Bar.DockStyle = 2
            point = New System.Drawing.Point(&H205, &HBC)
            Me.View_Bar.FloatLocation = point
            Me.View_Bar.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnView), New LinkPersistInfo(8, Me.cmbViewList, "", False, True, True, &H85), New LinkPersistInfo(BarLinkUserDefines.PaintStyle, Me.btnViewDetail, 0)})
            Me.View_Bar.Offset = &H18B
            Me.View_Bar.Text = "View Bar"
            Me.View_Bar.Visible = False
            Me.btnView.Caption = "View"
            guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            Me.btnView.CategoryGuid = guid9
            Me.btnView.Glyph = = System.Drawing.Image.FromFile("btnView.Glyph")
            Me.btnView.Id = &H13
            Me.btnView.Name = "btnView"
            Me.cmbViewList.Caption = "ViewList"
            guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            Me.cmbViewList.CategoryGuid = guid9
            Me.cmbViewList.Edit = Me.cmbViewListRepos
            Me.cmbViewList.Id = &H15
            Me.cmbViewList.Name = "cmbViewList"
            Me.cmbViewListRepos.AutoHeight = False
            Me.cmbViewListRepos.Buttons.AddRange(New EditorButton() {New EditorButton(ButtonPredefines.Combo), New EditorButton(ButtonPredefines.Delete, "Clear")})
            Me.cmbViewListRepos.Name = "cmbViewListRepos"
            Me.cmbViewListRepos.NullText = ""
            Me.btnViewDetail.Caption = "..."
            guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            Me.btnViewDetail.CategoryGuid = guid9
            Me.btnViewDetail.Glyph = System.Drawing.Image.FromFile("btnViewDetail.Glyph")
            Me.btnViewDetail.Id = 11
            Me.btnViewDetail.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnEditView), New LinkPersistInfo(Me.btnNewView), New LinkPersistInfo(Me.btnDeleteView), New LinkPersistInfo(Me.btnSaveView), New LinkPersistInfo(Me.btnMakeViewCommon), New LinkPersistInfo(Me.btnSendViewUser), New LinkPersistInfo(Me.btnCopyView)})
            Me.btnViewDetail.Name = "btnViewDetail"
            Me.btnEditView.Caption = "Edit"
            guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            Me.btnEditView.CategoryGuid = guid9
            Me.btnEditView.Glyph = System.Drawing.Image.FromFile("btnEditView.Glyph")
            Me.btnEditView.Id = 13
            Me.btnEditView.Name = "btnEditView"
            Me.btnNewView.Caption = "New"
            guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            Me.btnNewView.CategoryGuid = guid9
            Me.btnNewView.Glyph = System.Drawing.Image.FromFile("btnNewView.Glyph")
            Me.btnNewView.Id = 12
            Me.btnNewView.Name = "btnNewView"
            Me.btnDeleteView.Caption = "Delete"
            guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            Me.btnDeleteView.CategoryGuid = guid9
            Me.btnDeleteView.Glyph = System.Drawing.Image.FromFile("btnDeleteView.Glyph")
            Me.btnDeleteView.Id = 14
            Me.btnDeleteView.Name = "btnDeleteView"
            Me.btnSaveView.Caption = "Save"
            guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            Me.btnSaveView.CategoryGuid = guid9
            Me.btnSaveView.Glyph = System.Drawing.Image.FromFile("btnSaveView.Glyph")
            Me.btnSaveView.Id = &H11
            Me.btnSaveView.Name = "btnSaveView"
            Me.btnMakeViewCommon.Caption = "Make Common"
            guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            Me.btnMakeViewCommon.CategoryGuid = guid9
            Me.btnMakeViewCommon.Glyph = System.Drawing.Image.FromFile("btnMakeViewCommon.Glyph")
            Me.btnMakeViewCommon.Id = 15
            Me.btnMakeViewCommon.Name = "btnMakeViewCommon"
            Me.btnSendViewUser.Caption = "Send to USer"
            guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            Me.btnSendViewUser.CategoryGuid = guid9
            Me.btnSendViewUser.Glyph = System.Drawing.Image.FromFile("btnSendViewUser.Glyph")
            Me.btnSendViewUser.Id = &H10
            Me.btnSendViewUser.Name = "btnSendViewUser"
            Me.btnCopyView.Caption = "Copy"
            guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            Me.btnCopyView.CategoryGuid = guid9
            Me.btnCopyView.Glyph = System.Drawing.Image.FromFile("btnCopyView.Glyph")
            Me.btnCopyView.Id = &H12
            Me.btnCopyView.Name = "btnCopyView"
            Me.QuickSearch_Bar.BarName = "QuickSearch_Bar"
            Me.QuickSearch_Bar.DockCol = 2
            Me.QuickSearch_Bar.DockRow = 0
            Me.QuickSearch_Bar.DockStyle = 2
            point = New System.Drawing.Point(&HFB, &H99)
            Me.QuickSearch_Bar.FloatLocation = point
            Me.QuickSearch_Bar.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(8, Me.txtQuickSearch, "", False, True, True, &H7A), New LinkPersistInfo(Me.btnQuickSearch)})
            Me.QuickSearch_Bar.Offset = &H1F2
            Me.QuickSearch_Bar.Text = "Quick Search Bar"
            Me.QuickSearch_Bar.Visible = False
            guid9 = New Guid("2d735e09-7c7c-4ed4-b3ca-996e094a2026")
            Me.txtQuickSearch.CategoryGuid = guid9
            Me.txtQuickSearch.Edit = Me.txtQuickSearchRepos
            Me.txtQuickSearch.Id = &H17
            Me.txtQuickSearch.Name = "txtQuickSearch"
            Me.txtQuickSearchRepos.AutoHeight = False
            Me.txtQuickSearchRepos.Name = "txtQuickSearchRepos"
            Me.btnQuickSearch.Caption = "Search"
            guid9 = New Guid("2d735e09-7c7c-4ed4-b3ca-996e094a2026")
            Me.btnQuickSearch.CategoryGuid = guid9
            Me.btnQuickSearch.Glyph = System.Drawing.Image.FromFile("btnQuickSearch.Glyph")
            Me.btnQuickSearch.Id = &H16
            Me.btnQuickSearch.Name = "btnQuickSearch"
            Me.Report_Bar.BarName = "Report_Bar"
            Me.Report_Bar.DockCol = 7
            Me.Report_Bar.DockRow = 0
            Me.Report_Bar.DockStyle = 2
            point = New System.Drawing.Point(&H1F, &HA2)
            Me.Report_Bar.FloatLocation = point
            Me.Report_Bar.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnPrint), New LinkPersistInfo(8, Me.cmbReportList, "", False, True, True, &H83), New LinkPersistInfo(Me.btnReportDetail)})
            Me.Report_Bar.Offset = &H429
            Me.Report_Bar.Text = "Report Bar"
            Me.Report_Bar.Visible = False
            Me.btnPrint.Caption = "Print"
            guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            Me.btnPrint.CategoryGuid = guid9
            Me.btnPrint.Glyph = System.Drawing.Image.FromFile("btnPrint.Glyph")
            Me.btnPrint.Id = &H18
            Me.btnPrint.Name = "btnPrint"
            Me.cmbReportList.Caption = "Report List"
            guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            Me.cmbReportList.CategoryGuid = guid9
            Me.cmbReportList.Edit = Me.cmbReportListRepos
            Me.cmbReportList.Id = &H1A
            Me.cmbReportList.Name = "cmbReportList"
            Me.cmbReportListRepos.AutoHeight = False
            Me.cmbReportListRepos.Buttons.AddRange(New EditorButton() {New EditorButton(ButtonPredefines.Combo), New EditorButton(ButtonPredefines.Delete, "Clear")})
            Me.cmbReportListRepos.Name = "cmbReportListRepos"
            Me.cmbReportListRepos.NullText = ""
            Me.btnReportDetail.Caption = "..."
            guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            Me.btnReportDetail.CategoryGuid = guid9
            Me.btnReportDetail.Id = &H1B
            Me.btnReportDetail.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnEditReportInfo), New LinkPersistInfo(Me.btnNewReport), New LinkPersistInfo(Me.btnDeleteReport), New LinkPersistInfo(Me.btnDesignReport), New LinkPersistInfo(Me.btnMakeReportCommon), New LinkPersistInfo(Me.btnSendReportUser), New LinkPersistInfo(Me.btnCopyReport)})
            Me.btnReportDetail.Name = "btnReportDetail"
            Me.btnEditReportInfo.Caption = "Edit"
            guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            Me.btnEditReportInfo.CategoryGuid = guid9
            Me.btnEditReportInfo.Glyph = System.Drawing.Image.FromFile("btnEditReportInfo.Glyph")
            Me.btnEditReportInfo.Id = &H1C
            Me.btnEditReportInfo.Name = "btnEditReportInfo"
            Me.btnNewReport.Caption = "New"
            guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            Me.btnNewReport.CategoryGuid = guid9
            Me.btnNewReport.Glyph = System.Drawing.Image.FromFile("btnNewReport.Glyph")
            Me.btnNewReport.Id = &H1D
            Me.btnNewReport.Name = "btnNewReport"
            Me.btnDeleteReport.Caption = "Delete"
            guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            Me.btnDeleteReport.CategoryGuid = guid9
            Me.btnDeleteReport.Glyph = System.Drawing.Image.FromFile("btnDeleteReport.Glyph")
            Me.btnDeleteReport.Id = 30
            Me.btnDeleteReport.Name = "btnDeleteReport"
            Me.btnDesignReport.Caption = "Design Report"
            guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            Me.btnDesignReport.CategoryGuid = guid9
            Me.btnDesignReport.Glyph = System.Drawing.Image.FromFile("btnDesignReport.Glyph")
            Me.btnDesignReport.Id = &H1F
            Me.btnDesignReport.Name = "btnDesignReport"
            Me.btnMakeReportCommon.Caption = "Make Common"
            guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            Me.btnMakeReportCommon.CategoryGuid = guid9
            Me.btnMakeReportCommon.Glyph = System.Drawing.Image.FromFile("btnMakeReportCommon.Glyph")
            Me.btnMakeReportCommon.Id = &H20
            Me.btnMakeReportCommon.Name = "btnMakeReportCommon"
            Me.btnSendReportUser.Caption = "Send to User"
            guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            Me.btnSendReportUser.CategoryGuid = guid9
            Me.btnSendReportUser.Glyph = System.Drawing.Image.FromFile("btnSendReportUser.Glyph")
            Me.btnSendReportUser.Id = &H21
            Me.btnSendReportUser.Name = "btnSendReportUser"
            Me.btnCopyReport.Caption = "Copy"
            guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            Me.btnCopyReport.CategoryGuid = guid9
            Me.btnCopyReport.Glyph = System.Drawing.Image.FromFile("btnCopyReport.Glyph")
            Me.btnCopyReport.Id = &H22
            Me.btnCopyReport.Name = "btnCopyReport"
            Me.Filter_Bar.BarName = "Filter_Bar"
            Me.Filter_Bar.DockCol = 5
            Me.Filter_Bar.DockRow = 0
            Me.Filter_Bar.DockStyle = 2
            point = New System.Drawing.Point(&H151, &HDA)
            Me.Filter_Bar.FloatLocation = point
            Me.Filter_Bar.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnFilter), New LinkPersistInfo(8, Me.cmbFilterList, "", False, True, True, &H84), New LinkPersistInfo(Me.btnFilterDetail)})
            Me.Filter_Bar.Offset = &H41D
            Me.Filter_Bar.Text = "Filter Bar"
            Me.Filter_Bar.Visible = False
            Me.btnFilter.Caption = "btnFilter"
            guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            Me.btnFilter.CategoryGuid = guid9
            Me.btnFilter.Glyph = System.Drawing.Image.FromFile("btnFilter.Glyph")
            Me.btnFilter.Id = &H23
            Me.btnFilter.Name = "btnFilter"
            Me.cmbFilterList.Caption = "cmbFilterList"
            guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            Me.cmbFilterList.CategoryGuid = guid9
            Me.cmbFilterList.Edit = Me.cmbFilterListRepos
            Me.cmbFilterList.Id = &H26
            Me.cmbFilterList.Name = "cmbFilterList"
            Me.cmbFilterListRepos.AutoHeight = False
            Me.cmbFilterListRepos.Buttons.AddRange(New EditorButton() {New EditorButton(ButtonPredefines.Combo), New EditorButton(ButtonPredefines.Delete, "Clear")})
            Me.cmbFilterListRepos.Name = "cmbFilterListRepos"
            Me.cmbFilterListRepos.NullText = ""
            Me.btnFilterDetail.Caption = "..."
            guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            Me.btnFilterDetail.CategoryGuid = guid9
            Me.btnFilterDetail.Id = &H25
            Me.btnFilterDetail.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnEditFilter), New LinkPersistInfo(Me.btnNewFilter), New LinkPersistInfo(Me.btnDeleteFilter), New LinkPersistInfo(Me.btnMakeFilterCommon), New LinkPersistInfo(Me.btnSendFilterUSer), New LinkPersistInfo(Me.btnCopyFilter)})
            Me.btnFilterDetail.Name = "btnFilterDetail"
            Me.btnEditFilter.Caption = "Edit"
            guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            Me.btnEditFilter.CategoryGuid = guid9
            Me.btnEditFilter.Glyph = System.Drawing.Image.FromFile("btnEditFilter.Glyph")
            Me.btnEditFilter.Id = &H27
            Me.btnEditFilter.Name = "btnEditFilter"
            Me.btnNewFilter.Caption = "New"
            guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            Me.btnNewFilter.CategoryGuid = guid9
            Me.btnNewFilter.Glyph = System.Drawing.Image.FromFile("btnNewFilter.Glyph")
            Me.btnNewFilter.Id = 40
            Me.btnNewFilter.Name = "btnNewFilter"
            Me.btnDeleteFilter.Caption = "Delete"
            guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            Me.btnDeleteFilter.CategoryGuid = guid9
            Me.btnDeleteFilter.Glyph = System.Drawing.Image.FromFile("btnDeleteFilter.Glyph")
            Me.btnDeleteFilter.Id = &H29
            Me.btnDeleteFilter.Name = "btnDeleteFilter"
            Me.btnMakeFilterCommon.Caption = "Make Common"
            guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            Me.btnMakeFilterCommon.CategoryGuid = guid9
            Me.btnMakeFilterCommon.Glyph = System.Drawing.Image.FromFile("btnMakeFilterCommon.Glyph")
            Me.btnMakeFilterCommon.Id = &H2B
            Me.btnMakeFilterCommon.Name = "btnMakeFilterCommon"
            Me.btnSendFilterUSer.Caption = "Send to USer"
            guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            Me.btnSendFilterUSer.CategoryGuid = guid9
            Me.btnSendFilterUSer.Glyph = System.Drawing.Image.FromFile("btnSendFilterUSer.Glyph")
            Me.btnSendFilterUSer.Id = &H2C
            Me.btnSendFilterUSer.Name = "btnSendFilterUSer"
            Me.btnCopyFilter.Caption = "Copy"
            guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            Me.btnCopyFilter.CategoryGuid = guid9
            Me.btnCopyFilter.Glyph = System.Drawing.Image.FromFile("btnCopyFilter.Glyph")
            Me.btnCopyFilter.Id = &H2D
            Me.btnCopyFilter.Name = "btnCopyFilter"
            Me.DefaultSet_Bar.BarName = "DefaultBar"
            Me.DefaultSet_Bar.DockCol = 6
            Me.DefaultSet_Bar.DockRow = 0
            Me.DefaultSet_Bar.DockStyle = 2
            point = New System.Drawing.Point(&H12A, &HE0)
            Me.DefaultSet_Bar.FloatLocation = point
            Me.DefaultSet_Bar.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnDefault), New LinkPersistInfo(8, Me.cmbDefaultList, "", False, True, True, &H84), New LinkPersistInfo(Me.btnDefaultDetail)})
            Me.DefaultSet_Bar.Offset = &H424
            Me.DefaultSet_Bar.Text = "Default Set Bar"
            Me.DefaultSet_Bar.Visible = False
            Me.btnDefault.Caption = "Default"
            guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            Me.btnDefault.CategoryGuid = guid9
            Me.btnDefault.Glyph = System.Drawing.Image.FromFile("btnDefault.Glyph")
            Me.btnDefault.Id = &H2F
            Me.btnDefault.Name = "btnDefault"
            Me.cmbDefaultList.Caption = "cmbDefaultList"
            guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            Me.cmbDefaultList.CategoryGuid = guid9
            Me.cmbDefaultList.Edit = Me.cmbDefaultListRepos
            Me.cmbDefaultList.Id = &H31
            Me.cmbDefaultList.Name = "cmbDefaultList"
            Me.cmbDefaultListRepos.AutoHeight = False
            Me.cmbDefaultListRepos.Buttons.AddRange(New EditorButton() {New EditorButton(-5), New EditorButton(2)})
            Me.cmbDefaultListRepos.Name = "cmbDefaultListRepos"
            Me.cmbDefaultListRepos.NullText = ""
            Me.btnDefaultDetail.Caption = "..."
            guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            Me.btnDefaultDetail.CategoryGuid = guid9
            Me.btnDefaultDetail.Id = 50
            Me.btnDefaultDetail.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnEditDefault), New LinkPersistInfo(Me.btnNewDefault), New LinkPersistInfo(Me.btnDeleteDefault), New LinkPersistInfo(Me.btnSaveDefault), New LinkPersistInfo(Me.btnMakeDefaultCommon), New LinkPersistInfo(Me.btnSendDefaultUser), New LinkPersistInfo(Me.btnCopyDefault)})
            Me.btnDefaultDetail.Name = "btnDefaultDetail"
            Me.btnEditDefault.Caption = "Edit"
            guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            Me.btnEditDefault.CategoryGuid = guid9
            Me.btnEditDefault.Glyph = System.Drawing.Image.FromFile("btnEditDefault.Glyph")
            Me.btnEditDefault.Id = &H33
            Me.btnEditDefault.Name = "btnEditDefault"
            Me.btnNewDefault.Caption = "New"
            guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            Me.btnNewDefault.CategoryGuid = guid9
            Me.btnNewDefault.Glyph = System.Drawing.Image.FromFile("btnNewDefault.Glyph")
            Me.btnNewDefault.Id = &H34
            Me.btnNewDefault.Name = "btnNewDefault"
            Me.btnDeleteDefault.Caption = "Delete"
            guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            Me.btnDeleteDefault.CategoryGuid = guid9
            Me.btnDeleteDefault.Glyph = System.Drawing.Image.FromFile("btnDeleteDefault.Glyph")
            Me.btnDeleteDefault.Id = &H35
            Me.btnDeleteDefault.Name = "btnDeleteDefault"
            Me.btnSaveDefault.Caption = "Save"
            guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            Me.btnSaveDefault.CategoryGuid = guid9
            Me.btnSaveDefault.Glyph = System.Drawing.Image.FromFile("btnSaveDefault.Glyph")
            Me.btnSaveDefault.Id = &H36
            Me.btnSaveDefault.Name = "btnSaveDefault"
            Me.btnMakeDefaultCommon.Caption = "Make Common"
            guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            Me.btnMakeDefaultCommon.CategoryGuid = guid9
            Me.btnMakeDefaultCommon.Glyph = System.Drawing.Image.FromFile("btnMakeDefaultCommon.Glyph")
            Me.btnMakeDefaultCommon.Id = &H37
            Me.btnMakeDefaultCommon.Name = "btnMakeDefaultCommon"
            Me.btnSendDefaultUser.Caption = "Send to USer"
            guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            Me.btnSendDefaultUser.CategoryGuid = guid9
            Me.btnSendDefaultUser.Glyph = System.Drawing.Image.FromFile("btnSendDefaultUser.Glyph")
            Me.btnSendDefaultUser.Id = &H38
            Me.btnSendDefaultUser.Name = "btnSendDefaultUser"
            Me.btnCopyDefault.Caption = "Copy"
            guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            Me.btnCopyDefault.CategoryGuid = guid9
            Me.btnCopyDefault.Glyph = System.Drawing.Image.FromFile("btnCopyDefault.Glyph")
            Me.btnCopyDefault.Id = &H39
            Me.btnCopyDefault.Name = "btnCopyDefault"
            Me.Misc_Bar2.BarName = "Misc_Bar2"
            Me.Misc_Bar2.DockCol = 8
            Me.Misc_Bar2.DockRow = 0
            Me.Misc_Bar2.DockStyle = 2
            Me.Misc_Bar2.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnTranslation), New LinkPersistInfo(Me.btnComments), New LinkPersistInfo(Me.btnAttachements)})
            Me.Misc_Bar2.Offset = &H463
            Me.Misc_Bar2.Text = "Misc_Bar2 for Maintenance Screen"
            Me.Misc_Bar2.Visible = False
            Me.btnTranslation.Caption = "Translation"
            guid9 = New Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")
            Me.btnTranslation.CategoryGuid = guid9
            Me.btnTranslation.Glyph = System.Drawing.Image.FromFile("btnTranslation.Glyph")
            Me.btnTranslation.Id = &H3F
            Me.btnTranslation.Name = "btnTranslation"
            Me.btnComments.Caption = "Comments"
            guid9 = New Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")
            Me.btnComments.CategoryGuid = guid9
            Me.btnComments.Glyph = System.Drawing.Image.FromFile("btnComments.Glyph")
            Me.btnComments.Id = &H40
            Me.btnComments.Name = "btnComments"
            Me.btnAttachements.Caption = "Attachements"
            guid9 = New Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")
            Me.btnAttachements.CategoryGuid = guid9
            Me.btnAttachements.Glyph = System.Drawing.Image.FromFile("btnAttachements.Glyph")
            Me.btnAttachements.Id = &H41
            Me.btnAttachements.Name = "btnAttachements"
            Me.Nav_Bar.BarName = "Nav_Bar"
            Me.Nav_Bar.DockCol = 3
            Me.Nav_Bar.DockRow = 0
            Me.Nav_Bar.DockStyle = 2
            Me.Nav_Bar.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnFirst), New LinkPersistInfo(Me.btnPrevious), New LinkPersistInfo(Me.btnNext), New LinkPersistInfo(Me.btnLast)})
            Me.Nav_Bar.Offset = &HAC
            Me.Nav_Bar.Text = "Nav Bar"
            Me.Nav_Bar.Visible = False
            Me.btnFirst.Caption = "First"
            guid9 = New Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
            Me.btnFirst.CategoryGuid = guid9
            Me.btnFirst.Glyph = System.Drawing.Image.FromFile("btnFirst.Glyph")
            Me.btnFirst.Id = &H42
            Me.btnFirst.Name = "btnFirst"
            Me.btnPrevious.Caption = "Previous"
            guid9 = New Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
            Me.btnPrevious.CategoryGuid = guid9
            Me.btnPrevious.Glyph = System.Drawing.Image.FromFile("btnPrevious.Glyph")
            Me.btnPrevious.Id = &H43
            Me.btnPrevious.Name = "btnPrevious"
            Me.btnNext.Caption = "Next"
            guid9 = New Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
            Me.btnNext.CategoryGuid = guid9
            Me.btnNext.Glyph = System.Drawing.Image.FromFile("btnNext.Glyph")
            Me.btnNext.Id = &H44
            Me.btnNext.Name = "btnNext"
            Me.btnLast.Caption = "Last"
            guid9 = New Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
            Me.btnLast.CategoryGuid = guid9
            Me.btnLast.Glyph = System.Drawing.Image.FromFile("btnLast.Glyph")
            Me.btnLast.Id = &H45
            Me.btnLast.Name = "btnLast"
            Me.DockManager1.Form = Me
            Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar"})
            Dim size As New System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New System.Drawing.Size(&H488, &H10A)
            Me.ClientSize = size
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frmBKForm"
            Me.Text = "frmBKForm"
            Me.BarManager1.EndInit()
            Me.cmbViewListRepos.EndInit()
            Me.txtQuickSearchRepos.EndInit()
            Me.cmbReportListRepos.EndInit()
            Me.cmbFilterListRepos.EndInit()
            Me.cmbDefaultListRepos.EndInit()
            Me.DockManager1.EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents _btnAttachements As BarButtonItem
    End Class
End Namespace