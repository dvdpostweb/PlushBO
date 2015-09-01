Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class frmBKForm
        Inherits Form
        ' Methods
        Public Sub New()
            Dim list As ArrayList = frmBKForm.__ENCList
            SyncLock list
                frmBKForm.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.InitializeComponent
        End Sub

        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            Dim list As ArrayList = frmBKForm.__ENCList
            SyncLock list
                frmBKForm.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.InitializeComponent
            Me.SetBKOjects(CurrentSessionInfo)
        End Sub

        Public Overridable Sub Btn_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnAttachements_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnComments_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnCopyDefault_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnCopyFilter_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnCopyReport_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnDefault_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnDelete_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnDeleteDefault_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnDeleteFilter_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnDeleteReport_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnDesignReport_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnEdit_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnEditDefault_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnEditFilter_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnEditReportInfo_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnExportXML_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnFilter_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnFirst_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnImportXML_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnLast_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnMakeDefaultCommon_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnMakeFilterCommon_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnMakeReportCommon_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnNew_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnNewDefault_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnNewFilter_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnNewReport_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnNext_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnPrevious_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnPrint_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnQuickSearch_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnSave_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnSaveDefault_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnSendDefaultUser_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnSendFilterUSer_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnSendReportUser_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnTranslation_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Public Overridable Sub btnUndo_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Private Sub cmbRepos_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs)
            If (e.get_Button.get_Kind Is 2) Then
                DirectCast(sender, LookUpEdit).ClosePopup
                DirectCast(sender, LookUpEdit).set_EditValue(DBNull.Value)
            End If
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub


        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ComponentResourceManager(GetType(frmBKForm))
            Me.BarManager1 = New BarManager(Me.components)

            Me.Main_Bar = New Bar
            'Me.btnNew = New BarButtonItem
            'Me.btnEdit = New BarButtonItem
            'Me.btnDelete = New BarButtonItem
            'Me.btnSave = New BarButtonItem
            'Me.btnUndo = New BarButtonItem
            'Me.Misc_Bar = New Bar
            'Me.MainBtns_btnExcel = New BarButtonItem
            'Me.MainBtns_btnBigger = New BarButtonItem
            'Me.MainBtns_btnSmaller = New BarButtonItem
            'Me.MainBtns_btnBestFit = New BarButtonItem
            'Me.btnOK = New BarButtonItem
            'Me.btnUser1 = New BarButtonItem
            'Me.btnUser2 = New BarButtonItem
            'Me.btnUser3 = New BarButtonItem
            'Me.btnUser4 = New BarButtonItem
            'Me.btnUser5 = New BarButtonItem
            'Me.btnExportXML = New BarButtonItem
            'Me.btnImportXML = New BarButtonItem
            'Me.View_Bar = New Bar
            'Me.btnView = New BarButtonItem
            'Me.cmbViewList = New BarEditItem
            'Me.cmbViewListRepos = New RepositoryItemLookUpEdit
            'Me.btnViewDetail = New BarSubItem
            'Me.btnEditView = New BarButtonItem
            'Me.btnNewView = New BarButtonItem
            'Me.btnDeleteView = New BarButtonItem
            'Me.btnSaveView = New BarButtonItem
            'Me.btnMakeViewCommon = New BarButtonItem
            'Me.btnSendViewUser = New BarButtonItem
            'Me.btnCopyView = New BarButtonItem
            'Me.QuickSearch_Bar = New Bar
            'Me.txtQuickSearch = New BarEditItem
            'Me.txtQuickSearchRepos = New RepositoryItemTextEdit
            'Me.btnQuickSearch = New BarButtonItem
            'Me.Report_Bar = New Bar
            'Me.btnPrint = New BarButtonItem
            'Me.cmbReportList = New BarEditItem
            'Me.cmbReportListRepos = New RepositoryItemLookUpEdit
            'Me.btnReportDetail = New BarSubItem
            'Me.btnEditReportInfo = New BarButtonItem
            'Me.btnNewReport = New BarButtonItem
            'Me.btnDeleteReport = New BarButtonItem
            'Me.btnDesignReport = New BarButtonItem
            'Me.btnMakeReportCommon = New BarButtonItem
            'Me.btnSendReportUser = New BarButtonItem
            'Me.btnCopyReport = New BarButtonItem
            'Me.Filter_Bar = New Bar
            'Me.btnFilter = New BarButtonItem
            'Me.cmbFilterList = New BarEditItem
            'Me.cmbFilterListRepos = New RepositoryItemLookUpEdit
            'Me.btnFilterDetail = New BarSubItem
            'Me.btnEditFilter = New BarButtonItem
            'Me.btnNewFilter = New BarButtonItem
            'Me.btnDeleteFilter = New BarButtonItem
            'Me.btnMakeFilterCommon = New BarButtonItem
            'Me.btnSendFilterUSer = New BarButtonItem
            'Me.btnCopyFilter = New BarButtonItem
            Me.DefaultSet_Bar = New Bar
            'Me.btnDefault = New BarButtonItem
            'Me.cmbDefaultList = New BarEditItem
            'Me.cmbDefaultListRepos = New RepositoryItemLookUpEdit
            'Me.btnDefaultDetail = New BarSubItem
            'Me.btnEditDefault = New BarButtonItem
            'Me.btnNewDefault = New BarButtonItem
            'Me.btnDeleteDefault = New BarButtonItem
            'Me.btnSaveDefault = New BarButtonItem
            'Me.btnMakeDefaultCommon = New BarButtonItem
            'Me.btnSendDefaultUser = New BarButtonItem
            'Me.btnCopyDefault = New BarButtonItem
            'Me.Misc_Bar2 = New Bar
            'Me.btnTranslation = New BarButtonItem
            'Me.btnComments = New BarButtonItem
            'Me.btnAttachements = New BarButtonItem
            'Me.Nav_Bar = New Bar
            'Me.btnFirst = New BarButtonItem
            'Me.btnPrevious = New BarButtonItem
            'Me.btnNext = New BarButtonItem
            'Me.btnLast = New BarButtonItem
            'Me.barDockControlTop = New BarDockControl
            'Me.barDockControlBottom = New BarDockControl
            'Me.barDockControlLeft = New BarDockControl
            'Me.barDockControlRight = New BarDockControl
            'Me.DockManager1 = New DockManager(Me.components)
            Me.BarManager1.BeginInit()
            'Me.cmbViewListRepos.BeginInit()
            'Me.txtQuickSearchRepos.BeginInit()
            'Me.cmbReportListRepos.BeginInit()
            'Me.cmbFilterListRepos.BeginInit()
            'Me.cmbDefaultListRepos.BeginInit()
            'Me.DockManager1.BeginInit()
            Me.SuspendLayout()
            Me.BarManager1.get_Bars.AddRange(New Bar() {Me.Main_Bar, Me.Misc_Bar, Me.View_Bar, Me.QuickSearch_Bar, Me.Report_Bar, Me.Filter_Bar, Me.DefaultSet_Bar, Me.Misc_Bar2, Me.Nav_Bar})
            'Dim categoryArray As BarManagerCategory() = New BarManagerCategory(9 - 1) {}
            'Dim guid As New Guid("434484d9-7ac5-47e5-9412-313a111b7240")
            'categoryArray(0) = New BarManagerCategory("Main", guid)
            'Dim guid2 As New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            'categoryArray(1) = New BarManagerCategory("Miscelaneous", guid2)
            'Dim guid3 As New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            'categoryArray(2) = New BarManagerCategory("Views", guid3)
            'Dim guid4 As New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            'categoryArray(3) = New BarManagerCategory("Filters", guid4)
            'Dim guid5 As New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            'categoryArray(4) = New BarManagerCategory("Reporting", guid5)
            'Dim guid6 As New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            'categoryArray(5) = New BarManagerCategory("Default Values", guid6)
            'Dim guid7 As New Guid("2d735e09-7c7c-4ed4-b3ca-996e094a2026")
            'categoryArray(6) = New BarManagerCategory("Quick Search", guid7)
            'Dim guid8 As New Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")
            'categoryArray(7) = New BarManagerCategory("Misc_Maintenance", guid8)
            'Dim guid9 As New Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
            'categoryArray(8) = New BarManagerCategory("Navigation", guid9)
            Me.BarManager1.get_Categories.AddRange(categoryArray)
            'Me.BarManager1.get_DockControls.Add(Me.barDockControlTop)
            'Me.BarManager1.get_DockControls.Add(Me.barDockControlBottom)
            'Me.BarManager1.get_DockControls.Add(Me.barDockControlLeft)
            'Me.BarManager1.get_DockControls.Add(Me.barDockControlRight)
            Me.BarManager1.set_Form(Me)
            'Me.BarManager1.get_Items.AddRange(New BarItem() {Me.btnNew, Me.btnDelete, Me.btnEdit, Me.btnSave, Me.MainBtns_btnExcel, Me.MainBtns_btnBigger, Me.MainBtns_btnSmaller, Me.MainBtns_btnBestFit, Me.btnViewDetail, Me.btnNewView, Me.btnEditView, Me.btnDeleteView, Me.btnMakeViewCommon, Me.btnSendViewUser, Me.btnSaveView, Me.btnCopyView, Me.btnView, Me.cmbViewList, Me.btnQuickSearch, Me.txtQuickSearch, Me.btnPrint, Me.cmbReportList, Me.btnReportDetail, Me.btnEditReportInfo, Me.btnNewReport, Me.btnDeleteReport, Me.btnDesignReport, Me.btnMakeReportCommon, Me.btnSendReportUser, Me.btnCopyReport, Me.btnFilter, Me.btnFilterDetail, Me.cmbFilterList, Me.btnEditFilter, Me.btnNewFilter, Me.btnDeleteFilter, Me.btnMakeFilterCommon, Me.btnSendFilterUSer, Me.btnCopyFilter, Me.btnOK, Me.btnDefault, Me.cmbDefaultList, Me.btnDefaultDetail, Me.btnEditDefault, Me.btnNewDefault, Me.btnDeleteDefault, Me.btnSaveDefault, Me.btnMakeDefaultCommon, Me.btnSendDefaultUser, Me.btnCopyDefault, Me.btnUser1, Me.btnUser2, Me.btnUser3, Me.btnUser4, Me.btnUser5, Me.btnTranslation, Me.btnComments, Me.btnAttachements, Me.btnFirst, Me.btnPrevious, Me.btnNext, Me.btnLast, Me.btnUndo, Me.btnExportXML, Me.btnImportXML})
            'Me.BarManager1.set_MaxItemId(&H49)
            'Me.BarManager1.get_RepositoryItems.AddRange(New RepositoryItem() {Me.cmbViewListRepos, Me.txtQuickSearchRepos, Me.cmbReportListRepos, Me.cmbFilterListRepos, Me.cmbDefaultListRepos})
            'Me.Main_Bar.set_BarName("Main_Bar")
            'Me.Main_Bar.set_DockCol(0)
            'Me.Main_Bar.set_DockRow(0)
            'Me.Main_Bar.set_DockStyle(2)
            'Dim point As New Point(&HF6, &HB9)
            'Me.Main_Bar.set_FloatLocation(point)
            'Me.Main_Bar.get_LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnNew), New LinkPersistInfo(Me.btnEdit), New LinkPersistInfo(Me.btnDelete), New LinkPersistInfo(Me.btnSave), New LinkPersistInfo(Me.btnUndo)})
            'Me.Main_Bar.set_Offset(7)
            'Me.Main_Bar.set_Text("Main Bar")
            'Me.Main_Bar.set_Visible(False)
            'Me.btnNew.set_Caption("New")
            'guid9 = New Guid("434484d9-7ac5-47e5-9412-313a111b7240")
            'Me.btnNew.set_CategoryGuid(guid9)
            'Me.btnNew.set_Glyph(DirectCast(manager.GetObject("btnNew.Glyph"), Image))
            'Me.btnNew.set_Id(0)
            'Me.btnNew.set_Name("btnNew")
            'Me.btnEdit.set_Caption("Edit")
            'guid9 = New Guid("434484d9-7ac5-47e5-9412-313a111b7240")
            'Me.btnEdit.set_CategoryGuid(guid9)
            'Me.btnEdit.set_Glyph(DirectCast(manager.GetObject("btnEdit.Glyph"), Image))
            'Me.btnEdit.set_Id(2)
            'Me.btnEdit.set_Name("btnEdit")
            'Me.btnDelete.set_Caption("Delete")
            'guid9 = New Guid("434484d9-7ac5-47e5-9412-313a111b7240")
            'Me.btnDelete.set_CategoryGuid(guid9)
            'Me.btnDelete.set_Glyph(DirectCast(manager.GetObject("btnDelete.Glyph"), Image))
            'Me.btnDelete.set_Id(1)
            'Me.btnDelete.set_Name("btnDelete")
            'Me.btnSave.set_Caption("Save")
            'guid9 = New Guid("434484d9-7ac5-47e5-9412-313a111b7240")
            'Me.btnSave.set_CategoryGuid(guid9)
            'Me.btnSave.set_Glyph(DirectCast(manager.GetObject("btnSave.Glyph"), Image))
            'Me.btnSave.set_Id(3)
            'Me.btnSave.set_Name("btnSave")
            'Me.btnUndo.set_Caption("Undo")
            'Me.btnUndo.set_Glyph(DirectCast(manager.GetObject("btnUndo.Glyph"), Image))
            'Me.btnUndo.set_Id(70)
            'Me.btnUndo.set_Name("btnUndo")
            'Me.btnUndo.set_Visibility(1)
            'Me.Misc_Bar.set_BarName("Misc_Bar")
            'Me.Misc_Bar.set_DockCol(1)
            'Me.Misc_Bar.set_DockRow(0)
            'Me.Misc_Bar.set_DockStyle(2)
            'Me.Misc_Bar.get_LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.MainBtns_btnExcel), New LinkPersistInfo(Me.MainBtns_btnBigger), New LinkPersistInfo(Me.MainBtns_btnSmaller), New LinkPersistInfo(Me.MainBtns_btnBestFit), New LinkPersistInfo(4, Me.btnOK, 3), New LinkPersistInfo(Me.btnUser1), New LinkPersistInfo(Me.btnUser2), New LinkPersistInfo(Me.btnUser3), New LinkPersistInfo(Me.btnUser4), New LinkPersistInfo(Me.btnUser5), New LinkPersistInfo(Me.btnExportXML), New LinkPersistInfo(Me.btnImportXML)})
            'Me.Misc_Bar.set_Offset(&HB6)
            'Me.Misc_Bar.set_Text("Misc. Bar")
            'Me.Misc_Bar.set_Visible(False)
            'Me.MainBtns_btnExcel.set_Caption("Excell")
            'guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            'Me.MainBtns_btnExcel.set_CategoryGuid(guid9)
            'Me.MainBtns_btnExcel.set_Glyph(DirectCast(manager.GetObject("MainBtns_btnExcel.Glyph"), Image))
            'Me.MainBtns_btnExcel.set_Id(5)
            'Me.MainBtns_btnExcel.set_Name("MainBtns_btnExcel")
            'Me.MainBtns_btnBigger.set_Caption("Bigger")
            'guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            'Me.MainBtns_btnBigger.set_CategoryGuid(guid9)
            'Me.MainBtns_btnBigger.set_Glyph(DirectCast(manager.GetObject("MainBtns_btnBigger.Glyph"), Image))
            'Me.MainBtns_btnBigger.set_Id(6)
            'Me.MainBtns_btnBigger.set_Name("MainBtns_btnBigger")
            'Me.MainBtns_btnSmaller.set_Caption("Smaller")
            'guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            'Me.MainBtns_btnSmaller.set_CategoryGuid(guid9)
            'Me.MainBtns_btnSmaller.set_Glyph(DirectCast(manager.GetObject("MainBtns_btnSmaller.Glyph"), Image))
            'Me.MainBtns_btnSmaller.set_Id(7)
            'Me.MainBtns_btnSmaller.set_Name("MainBtns_btnSmaller")
            'Me.MainBtns_btnBestFit.set_Caption("BestFit")
            'guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            'Me.MainBtns_btnBestFit.set_CategoryGuid(guid9)
            'Me.MainBtns_btnBestFit.set_Glyph(DirectCast(manager.GetObject("MainBtns_btnBestFit.Glyph"), Image))
            'Me.MainBtns_btnBestFit.set_Id(8)
            'Me.MainBtns_btnBestFit.set_Name("MainBtns_btnBestFit")
            'Me.btnOK.set_Caption("OK")
            'guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            'Me.btnOK.set_CategoryGuid(guid9)
            'Me.btnOK.set_Glyph(DirectCast(manager.GetObject("btnOK.Glyph"), Image))
            'Me.btnOK.set_Id(&H2E)
            'Me.btnOK.set_ItemShortcut(New BarShortcut((Keys.Control Or Keys.O)))
            'Me.btnOK.set_Name("btnOK")
            'Me.btnOK.set_Visibility(1)
            'Me.btnUser1.set_Border(2)
            'Me.btnUser1.set_Caption("1")
            'guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            'Me.btnUser1.set_CategoryGuid(guid9)
            'Me.btnUser1.set_Id(&H3A)
            'Me.btnUser1.set_Name("btnUser1")
            'Me.btnUser1.set_Visibility(1)
            'Me.btnUser2.set_Border(2)
            'Me.btnUser2.set_Caption("2")
            'guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            'Me.btnUser2.set_CategoryGuid(guid9)
            'Me.btnUser2.set_Id(&H3B)
            'Me.btnUser2.set_Name("btnUser2")
            'Me.btnUser2.set_Visibility(1)
            'Me.btnUser3.set_Border(2)
            'Me.btnUser3.set_Caption("3")
            'guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            'Me.btnUser3.set_CategoryGuid(guid9)
            'Me.btnUser3.set_Id(60)
            'Me.btnUser3.set_Name("btnUser3")
            'Me.btnUser3.set_Visibility(1)
            'Me.btnUser4.set_Border(2)
            'Me.btnUser4.set_Caption("4")
            'guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            'Me.btnUser4.set_CategoryGuid(guid9)
            'Me.btnUser4.set_Id(&H3D)
            'Me.btnUser4.set_Name("btnUser4")
            'Me.btnUser4.set_Visibility(1)
            'Me.btnUser5.set_Border(2)
            'Me.btnUser5.set_Caption("5")
            'guid9 = New Guid("a767b561-c256-451a-a199-6ebf84a07265")
            'Me.btnUser5.set_CategoryGuid(guid9)
            'Me.btnUser5.set_Id(&H3E)
            'Me.btnUser5.set_Name("btnUser5")
            'Me.btnUser5.set_Visibility(1)
            'Me.btnExportXML.set_Border(1)
            'Me.btnExportXML.set_Caption("Export")
            'Me.btnExportXML.set_Id(&H47)
            'Me.btnExportXML.set_Name("btnExportXML")
            'Me.btnImportXML.set_Border(1)
            'Me.btnImportXML.set_Caption("Import")
            'Me.btnImportXML.set_Id(&H48)
            'Me.btnImportXML.set_Name("btnImportXML")
            'Me.View_Bar.set_BarName("View_Bar")
            'Me.View_Bar.set_DockCol(4)
            'Me.View_Bar.set_DockRow(0)
            'Me.View_Bar.set_DockStyle(2)
            'point = New Point(&H205, &HBC)
            'Me.View_Bar.set_FloatLocation(point)
            'Me.View_Bar.get_LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnView), New LinkPersistInfo(8, Me.cmbViewList, "", False, True, True, &H85), New LinkPersistInfo(4, Me.btnViewDetail, 0)})
            'Me.View_Bar.set_Offset(&H18B)
            'Me.View_Bar.set_Text("View Bar")
            'Me.View_Bar.set_Visible(False)
            'Me.btnView.set_Caption("View")
            'guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            'Me.btnView.set_CategoryGuid(guid9)
            'Me.btnView.set_Glyph(DirectCast(manager.GetObject("btnView.Glyph"), Image))
            'Me.btnView.set_Id(&H13)
            'Me.btnView.set_Name("btnView")
            'Me.cmbViewList.set_Caption("ViewList")
            'guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            'Me.cmbViewList.set_CategoryGuid(guid9)
            'Me.cmbViewList.set_Edit(Me.cmbViewListRepos)
            'Me.cmbViewList.set_Id(&H15)
            'Me.cmbViewList.set_Name("cmbViewList")
            'Me.cmbViewListRepos.set_AutoHeight(False)
            'Me.cmbViewListRepos.get_Buttons.AddRange(New EditorButton() {New EditorButton(-5), New EditorButton(2, "Clear")})
            'Me.cmbViewListRepos.set_Name("cmbViewListRepos")
            'Me.cmbViewListRepos.set_NullText("")
            'Me.btnViewDetail.set_Caption("...")
            'guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            'Me.btnViewDetail.set_CategoryGuid(guid9)
            'Me.btnViewDetail.set_Glyph(DirectCast(manager.GetObject("btnViewDetail.Glyph"), Image))
            'Me.btnViewDetail.set_Id(11)
            'Me.btnViewDetail.get_LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnEditView), New LinkPersistInfo(Me.btnNewView), New LinkPersistInfo(Me.btnDeleteView), New LinkPersistInfo(Me.btnSaveView), New LinkPersistInfo(Me.btnMakeViewCommon), New LinkPersistInfo(Me.btnSendViewUser), New LinkPersistInfo(Me.btnCopyView)})
            'Me.btnViewDetail.set_Name("btnViewDetail")
            'Me.btnEditView.set_Caption("Edit")
            'guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            'Me.btnEditView.set_CategoryGuid(guid9)
            'Me.btnEditView.set_Glyph(DirectCast(manager.GetObject("btnEditView.Glyph"), Image))
            'Me.btnEditView.set_Id(13)
            'Me.btnEditView.set_Name("btnEditView")
            'Me.btnNewView.set_Caption("New")
            'guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            'Me.btnNewView.set_CategoryGuid(guid9)
            'Me.btnNewView.set_Glyph(DirectCast(manager.GetObject("btnNewView.Glyph"), Image))
            'Me.btnNewView.set_Id(12)
            'Me.btnNewView.set_Name("btnNewView")
            'Me.btnDeleteView.set_Caption("Delete")
            'guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            'Me.btnDeleteView.set_CategoryGuid(guid9)
            'Me.btnDeleteView.set_Glyph(DirectCast(manager.GetObject("btnDeleteView.Glyph"), Image))
            'Me.btnDeleteView.set_Id(14)
            'Me.btnDeleteView.set_Name("btnDeleteView")
            'Me.btnSaveView.set_Caption("Save")
            'guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            'Me.btnSaveView.set_CategoryGuid(guid9)
            'Me.btnSaveView.set_Glyph(DirectCast(manager.GetObject("btnSaveView.Glyph"), Image))
            'Me.btnSaveView.set_Id(&H11)
            'Me.btnSaveView.set_Name("btnSaveView")
            'Me.btnMakeViewCommon.set_Caption("Make Common")
            'guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            'Me.btnMakeViewCommon.set_CategoryGuid(guid9)
            'Me.btnMakeViewCommon.set_Glyph(DirectCast(manager.GetObject("btnMakeViewCommon.Glyph"), Image))
            'Me.btnMakeViewCommon.set_Id(15)
            'Me.btnMakeViewCommon.set_Name("btnMakeViewCommon")
            'Me.btnSendViewUser.set_Caption("Send to USer")
            'guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            'Me.btnSendViewUser.set_CategoryGuid(guid9)
            'Me.btnSendViewUser.set_Glyph(DirectCast(manager.GetObject("btnSendViewUser.Glyph"), Image))
            'Me.btnSendViewUser.set_Id(&H10)
            'Me.btnSendViewUser.set_Name("btnSendViewUser")
            'Me.btnCopyView.set_Caption("Copy")
            'guid9 = New Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
            'Me.btnCopyView.set_CategoryGuid(guid9)
            'Me.btnCopyView.set_Glyph(DirectCast(manager.GetObject("btnCopyView.Glyph"), Image))
            'Me.btnCopyView.set_Id(&H12)
            'Me.btnCopyView.set_Name("btnCopyView")
            'Me.QuickSearch_Bar.set_BarName("QuickSearch_Bar")
            'Me.QuickSearch_Bar.set_DockCol(2)
            'Me.QuickSearch_Bar.set_DockRow(0)
            'Me.QuickSearch_Bar.set_DockStyle(2)
            'point = New Point(&HFB, &H99)
            'Me.QuickSearch_Bar.set_FloatLocation(point)
            'Me.QuickSearch_Bar.get_LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(8, Me.txtQuickSearch, "", False, True, True, &H7A), New LinkPersistInfo(Me.btnQuickSearch)})
            'Me.QuickSearch_Bar.set_Offset(&H1F2)
            'Me.QuickSearch_Bar.set_Text("Quick Search Bar")
            'Me.QuickSearch_Bar.set_Visible(False)
            'guid9 = New Guid("2d735e09-7c7c-4ed4-b3ca-996e094a2026")
            'Me.txtQuickSearch.set_CategoryGuid(guid9)
            'Me.txtQuickSearch.set_Edit(Me.txtQuickSearchRepos)
            'Me.txtQuickSearch.set_Id(&H17)
            'Me.txtQuickSearch.set_Name("txtQuickSearch")
            'Me.txtQuickSearchRepos.set_AutoHeight(False)
            'Me.txtQuickSearchRepos.set_Name("txtQuickSearchRepos")
            'Me.btnQuickSearch.set_Caption("Search")
            'guid9 = New Guid("2d735e09-7c7c-4ed4-b3ca-996e094a2026")
            'Me.btnQuickSearch.set_CategoryGuid(guid9)
            'Me.btnQuickSearch.set_Glyph(DirectCast(manager.GetObject("btnQuickSearch.Glyph"), Image))
            'Me.btnQuickSearch.set_Id(&H16)
            'Me.btnQuickSearch.set_Name("btnQuickSearch")
            'Me.Report_Bar.set_BarName("Report_Bar")
            'Me.Report_Bar.set_DockCol(7)
            'Me.Report_Bar.set_DockRow(0)
            'Me.Report_Bar.set_DockStyle(2)
            'point = New Point(&H1F, &HA2)
            'Me.Report_Bar.set_FloatLocation(point)
            'Me.Report_Bar.get_LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnPrint), New LinkPersistInfo(8, Me.cmbReportList, "", False, True, True, &H83), New LinkPersistInfo(Me.btnReportDetail)})
            'Me.Report_Bar.set_Offset(&H429)
            'Me.Report_Bar.set_Text("Report Bar")
            'Me.Report_Bar.set_Visible(False)
            'Me.btnPrint.set_Caption("Print")
            'guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            'Me.btnPrint.set_CategoryGuid(guid9)
            'Me.btnPrint.set_Glyph(DirectCast(manager.GetObject("btnPrint.Glyph"), Image))
            'Me.btnPrint.set_Id(&H18)
            'Me.btnPrint.set_Name("btnPrint")
            'Me.cmbReportList.set_Caption("Report List")
            'guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            'Me.cmbReportList.set_CategoryGuid(guid9)
            'Me.cmbReportList.set_Edit(Me.cmbReportListRepos)
            'Me.cmbReportList.set_Id(&H1A)
            'Me.cmbReportList.set_Name("cmbReportList")
            'Me.cmbReportListRepos.set_AutoHeight(False)
            'Me.cmbReportListRepos.get_Buttons.AddRange(New EditorButton() {New EditorButton(-5), New EditorButton(2, "Clear")})
            'Me.cmbReportListRepos.set_Name("cmbReportListRepos")
            'Me.cmbReportListRepos.set_NullText("")
            'Me.btnReportDetail.set_Caption("...")
            'guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            'Me.btnReportDetail.set_CategoryGuid(guid9)
            'Me.btnReportDetail.set_Id(&H1B)
            'Me.btnReportDetail.get_LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnEditReportInfo), New LinkPersistInfo(Me.btnNewReport), New LinkPersistInfo(Me.btnDeleteReport), New LinkPersistInfo(Me.btnDesignReport), New LinkPersistInfo(Me.btnMakeReportCommon), New LinkPersistInfo(Me.btnSendReportUser), New LinkPersistInfo(Me.btnCopyReport)})
            'Me.btnReportDetail.set_Name("btnReportDetail")
            'Me.btnEditReportInfo.set_Caption("Edit")
            'guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            'Me.btnEditReportInfo.set_CategoryGuid(guid9)
            'Me.btnEditReportInfo.set_Glyph(DirectCast(manager.GetObject("btnEditReportInfo.Glyph"), Image))
            'Me.btnEditReportInfo.set_Id(&H1C)
            'Me.btnEditReportInfo.set_Name("btnEditReportInfo")
            'Me.btnNewReport.set_Caption("New")
            'guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            'Me.btnNewReport.set_CategoryGuid(guid9)
            'Me.btnNewReport.set_Glyph(DirectCast(manager.GetObject("btnNewReport.Glyph"), Image))
            'Me.btnNewReport.set_Id(&H1D)
            'Me.btnNewReport.set_Name("btnNewReport")
            'Me.btnDeleteReport.set_Caption("Delete")
            'guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            'Me.btnDeleteReport.set_CategoryGuid(guid9)
            'Me.btnDeleteReport.set_Glyph(DirectCast(manager.GetObject("btnDeleteReport.Glyph"), Image))
            'Me.btnDeleteReport.set_Id(30)
            'Me.btnDeleteReport.set_Name("btnDeleteReport")
            'Me.btnDesignReport.set_Caption("Design Report")
            'guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            'Me.btnDesignReport.set_CategoryGuid(guid9)
            'Me.btnDesignReport.set_Glyph(DirectCast(manager.GetObject("btnDesignReport.Glyph"), Image))
            'Me.btnDesignReport.set_Id(&H1F)
            'Me.btnDesignReport.set_Name("btnDesignReport")
            'Me.btnMakeReportCommon.set_Caption("Make Common")
            'guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            'Me.btnMakeReportCommon.set_CategoryGuid(guid9)
            'Me.btnMakeReportCommon.set_Glyph(DirectCast(manager.GetObject("btnMakeReportCommon.Glyph"), Image))
            'Me.btnMakeReportCommon.set_Id(&H20)
            'Me.btnMakeReportCommon.set_Name("btnMakeReportCommon")
            'Me.btnSendReportUser.set_Caption("Send to User")
            'guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            'Me.btnSendReportUser.set_CategoryGuid(guid9)
            'Me.btnSendReportUser.set_Glyph(DirectCast(manager.GetObject("btnSendReportUser.Glyph"), Image))
            'Me.btnSendReportUser.set_Id(&H21)
            'Me.btnSendReportUser.set_Name("btnSendReportUser")
            'Me.btnCopyReport.set_Caption("Copy")
            'guid9 = New Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
            'Me.btnCopyReport.set_CategoryGuid(guid9)
            'Me.btnCopyReport.set_Glyph(DirectCast(manager.GetObject("btnCopyReport.Glyph"), Image))
            'Me.btnCopyReport.set_Id(&H22)
            'Me.btnCopyReport.set_Name("btnCopyReport")
            'Me.Filter_Bar.set_BarName("Filter_Bar")
            'Me.Filter_Bar.set_DockCol(5)
            'Me.Filter_Bar.set_DockRow(0)
            'Me.Filter_Bar.set_DockStyle(2)
            'point = New Point(&H151, &HDA)
            'Me.Filter_Bar.set_FloatLocation(point)
            'Me.Filter_Bar.get_LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnFilter), New LinkPersistInfo(8, Me.cmbFilterList, "", False, True, True, &H84), New LinkPersistInfo(Me.btnFilterDetail)})
            'Me.Filter_Bar.set_Offset(&H41D)
            'Me.Filter_Bar.set_Text("Filter Bar")
            'Me.Filter_Bar.set_Visible(False)
            'Me.btnFilter.set_Caption("btnFilter")
            'guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            'Me.btnFilter.set_CategoryGuid(guid9)
            'Me.btnFilter.set_Glyph(DirectCast(manager.GetObject("btnFilter.Glyph"), Image))
            'Me.btnFilter.set_Id(&H23)
            'Me.btnFilter.set_Name("btnFilter")
            'Me.cmbFilterList.set_Caption("cmbFilterList")
            'guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            'Me.cmbFilterList.set_CategoryGuid(guid9)
            'Me.cmbFilterList.set_Edit(Me.cmbFilterListRepos)
            'Me.cmbFilterList.set_Id(&H26)
            'Me.cmbFilterList.set_Name("cmbFilterList")
            'Me.cmbFilterListRepos.set_AutoHeight(False)
            'Me.cmbFilterListRepos.get_Buttons.AddRange(New EditorButton() {New EditorButton(-5), New EditorButton(2, "Clear")})
            'Me.cmbFilterListRepos.set_Name("cmbFilterListRepos")
            'Me.cmbFilterListRepos.set_NullText("")
            'Me.btnFilterDetail.set_Caption("...")
            'guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            'Me.btnFilterDetail.set_CategoryGuid(guid9)
            'Me.btnFilterDetail.set_Id(&H25)
            'Me.btnFilterDetail.get_LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnEditFilter), New LinkPersistInfo(Me.btnNewFilter), New LinkPersistInfo(Me.btnDeleteFilter), New LinkPersistInfo(Me.btnMakeFilterCommon), New LinkPersistInfo(Me.btnSendFilterUSer), New LinkPersistInfo(Me.btnCopyFilter)})
            'Me.btnFilterDetail.set_Name("btnFilterDetail")
            'Me.btnEditFilter.set_Caption("Edit")
            'guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            'Me.btnEditFilter.set_CategoryGuid(guid9)
            'Me.btnEditFilter.set_Glyph(DirectCast(manager.GetObject("btnEditFilter.Glyph"), Image))
            'Me.btnEditFilter.set_Id(&H27)
            'Me.btnEditFilter.set_Name("btnEditFilter")
            'Me.btnNewFilter.set_Caption("New")
            'guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            'Me.btnNewFilter.set_CategoryGuid(guid9)
            'Me.btnNewFilter.set_Glyph(DirectCast(manager.GetObject("btnNewFilter.Glyph"), Image))
            'Me.btnNewFilter.set_Id(40)
            'Me.btnNewFilter.set_Name("btnNewFilter")
            'Me.btnDeleteFilter.set_Caption("Delete")
            'guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            'Me.btnDeleteFilter.set_CategoryGuid(guid9)
            'Me.btnDeleteFilter.set_Glyph(DirectCast(manager.GetObject("btnDeleteFilter.Glyph"), Image))
            'Me.btnDeleteFilter.set_Id(&H29)
            'Me.btnDeleteFilter.set_Name("btnDeleteFilter")
            'Me.btnMakeFilterCommon.set_Caption("Make Common")
            'guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            'Me.btnMakeFilterCommon.set_CategoryGuid(guid9)
            'Me.btnMakeFilterCommon.set_Glyph(DirectCast(manager.GetObject("btnMakeFilterCommon.Glyph"), Image))
            'Me.btnMakeFilterCommon.set_Id(&H2B)
            'Me.btnMakeFilterCommon.set_Name("btnMakeFilterCommon")
            'Me.btnSendFilterUSer.set_Caption("Send to USer")
            'guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            'Me.btnSendFilterUSer.set_CategoryGuid(guid9)
            'Me.btnSendFilterUSer.set_Glyph(DirectCast(manager.GetObject("btnSendFilterUSer.Glyph"), Image))
            'Me.btnSendFilterUSer.set_Id(&H2C)
            'Me.btnSendFilterUSer.set_Name("btnSendFilterUSer")
            'Me.btnCopyFilter.set_Caption("Copy")
            'guid9 = New Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
            'Me.btnCopyFilter.set_CategoryGuid(guid9)
            'Me.btnCopyFilter.set_Glyph(DirectCast(manager.GetObject("btnCopyFilter.Glyph"), Image))
            'Me.btnCopyFilter.set_Id(&H2D)
            'Me.btnCopyFilter.set_Name("btnCopyFilter")
            'Me.DefaultSet_Bar.set_BarName("DefaultSet_Bar")
            'Me.DefaultSet_Bar.set_DockCol(6)
            'Me.DefaultSet_Bar.set_DockRow(0)
            'Me.DefaultSet_Bar.set_DockStyle(2)
            'point = New Point(&H12A, &HE0)
            'Me.DefaultSet_Bar.set_FloatLocation(point)
            'Me.DefaultSet_Bar.get_LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnDefault), New LinkPersistInfo(8, Me.cmbDefaultList, "", False, True, True, &H84), New LinkPersistInfo(Me.btnDefaultDetail)})
            'Me.DefaultSet_Bar.set_Offset(&H424)
            'Me.DefaultSet_Bar.set_Text("Default Set Bar")
            'Me.DefaultSet_Bar.set_Visible(False)
            'Me.btnDefault.set_Caption("Default")
            'guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            'Me.btnDefault.set_CategoryGuid(guid9)
            'Me.btnDefault.set_Glyph(DirectCast(manager.GetObject("btnDefault.Glyph"), Image))
            'Me.btnDefault.set_Id(&H2F)
            'Me.btnDefault.set_Name("btnDefault")
            'Me.cmbDefaultList.set_Caption("cmbDefaultList")
            'guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            'Me.cmbDefaultList.set_CategoryGuid(guid9)
            'Me.cmbDefaultList.set_Edit(Me.cmbDefaultListRepos)
            'Me.cmbDefaultList.set_Id(&H31)
            'Me.cmbDefaultList.set_Name("cmbDefaultList")
            'Me.cmbDefaultListRepos.set_AutoHeight(False)
            'Me.cmbDefaultListRepos.get_Buttons.AddRange(New EditorButton() {New EditorButton(-5), New EditorButton(2)})
            'Me.cmbDefaultListRepos.set_Name("cmbDefaultListRepos")
            'Me.cmbDefaultListRepos.set_NullText("")
            'Me.btnDefaultDetail.set_Caption("...")
            'guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            'Me.btnDefaultDetail.set_CategoryGuid(guid9)
            'Me.btnDefaultDetail.set_Id(50)
            'Me.btnDefaultDetail.get_LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnEditDefault), New LinkPersistInfo(Me.btnNewDefault), New LinkPersistInfo(Me.btnDeleteDefault), New LinkPersistInfo(Me.btnSaveDefault), New LinkPersistInfo(Me.btnMakeDefaultCommon), New LinkPersistInfo(Me.btnSendDefaultUser), New LinkPersistInfo(Me.btnCopyDefault)})
            'Me.btnDefaultDetail.set_Name("btnDefaultDetail")
            'Me.btnEditDefault.set_Caption("Edit")
            'guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            'Me.btnEditDefault.set_CategoryGuid(guid9)
            'Me.btnEditDefault.set_Glyph(DirectCast(manager.GetObject("btnEditDefault.Glyph"), Image))
            'Me.btnEditDefault.set_Id(&H33)
            'Me.btnEditDefault.set_Name("btnEditDefault")
            'Me.btnNewDefault.set_Caption("New")
            'guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            'Me.btnNewDefault.set_CategoryGuid(guid9)
            'Me.btnNewDefault.set_Glyph(DirectCast(manager.GetObject("btnNewDefault.Glyph"), Image))
            'Me.btnNewDefault.set_Id(&H34)
            'Me.btnNewDefault.set_Name("btnNewDefault")
            'Me.btnDeleteDefault.set_Caption("Delete")
            'guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            'Me.btnDeleteDefault.set_CategoryGuid(guid9)
            'Me.btnDeleteDefault.set_Glyph(DirectCast(manager.GetObject("btnDeleteDefault.Glyph"), Image))
            'Me.btnDeleteDefault.set_Id(&H35)
            'Me.btnDeleteDefault.set_Name("btnDeleteDefault")
            'Me.btnSaveDefault.set_Caption("Save")
            'guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            'Me.btnSaveDefault.set_CategoryGuid(guid9)
            'Me.btnSaveDefault.set_Glyph(DirectCast(manager.GetObject("btnSaveDefault.Glyph"), Image))
            'Me.btnSaveDefault.set_Id(&H36)
            'Me.btnSaveDefault.set_Name("btnSaveDefault")
            'Me.btnMakeDefaultCommon.set_Caption("Make Common")
            'guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            'Me.btnMakeDefaultCommon.set_CategoryGuid(guid9)
            'Me.btnMakeDefaultCommon.set_Glyph(DirectCast(manager.GetObject("btnMakeDefaultCommon.Glyph"), Image))
            'Me.btnMakeDefaultCommon.set_Id(&H37)
            'Me.btnMakeDefaultCommon.set_Name("btnMakeDefaultCommon")
            'Me.btnSendDefaultUser.set_Caption("Send to USer")
            'guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            'Me.btnSendDefaultUser.set_CategoryGuid(guid9)
            'Me.btnSendDefaultUser.set_Glyph(DirectCast(manager.GetObject("btnSendDefaultUser.Glyph"), Image))
            'Me.btnSendDefaultUser.set_Id(&H38)
            'Me.btnSendDefaultUser.set_Name("btnSendDefaultUser")
            'Me.btnCopyDefault.set_Caption("Copy")
            'guid9 = New Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
            'Me.btnCopyDefault.set_CategoryGuid(guid9)
            'Me.btnCopyDefault.set_Glyph(DirectCast(manager.GetObject("btnCopyDefault.Glyph"), Image))
            'Me.btnCopyDefault.set_Id(&H39)
            'Me.btnCopyDefault.set_Name("btnCopyDefault")
            'Me.Misc_Bar2.set_BarName("Misc_Bar2")
            'Me.Misc_Bar2.set_DockCol(8)
            'Me.Misc_Bar2.set_DockRow(0)
            'Me.Misc_Bar2.set_DockStyle(2)
            'Me.Misc_Bar2.get_LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnTranslation), New LinkPersistInfo(Me.btnComments), New LinkPersistInfo(Me.btnAttachements)})
            'Me.Misc_Bar2.set_Offset(&H463)
            'Me.Misc_Bar2.set_Text("Misc_Bar2 for Maintenance Screen")
            'Me.Misc_Bar2.set_Visible(False)
            'Me.btnTranslation.set_Caption("Translation")
            'guid9 = New Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")
            'Me.btnTranslation.set_CategoryGuid(guid9)
            'Me.btnTranslation.set_Glyph(DirectCast(manager.GetObject("btnTranslation.Glyph"), Image))
            'Me.btnTranslation.set_Id(&H3F)
            'Me.btnTranslation.set_Name("btnTranslation")
            'Me.btnComments.set_Caption("Comments")
            'guid9 = New Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")
            'Me.btnComments.set_CategoryGuid(guid9)
            'Me.btnComments.set_Glyph(DirectCast(manager.GetObject("btnComments.Glyph"), Image))
            'Me.btnComments.set_Id(&H40)
            'Me.btnComments.set_Name("btnComments")
            'Me.btnAttachements.set_Caption("Attachements")
            'guid9 = New Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")
            'Me.btnAttachements.set_CategoryGuid(guid9)
            'Me.btnAttachements.set_Glyph(DirectCast(manager.GetObject("btnAttachements.Glyph"), Image))
            'Me.btnAttachements.set_Id(&H41)
            'Me.btnAttachements.set_Name("btnAttachements")
            'Me.Nav_Bar.set_BarName("Nav_Bar")
            'Me.Nav_Bar.set_DockCol(3)
            'Me.Nav_Bar.set_DockRow(0)
            'Me.Nav_Bar.set_DockStyle(2)
            'Me.Nav_Bar.get_LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnFirst), New LinkPersistInfo(Me.btnPrevious), New LinkPersistInfo(Me.btnNext), New LinkPersistInfo(Me.btnLast)})
            'Me.Nav_Bar.set_Offset(&HAC)
            'Me.Nav_Bar.set_Text("Nav Bar")
            'Me.Nav_Bar.set_Visible(False)
            'Me.btnFirst.set_Caption("First")
            'guid9 = New Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
            'Me.btnFirst.set_CategoryGuid(guid9)
            'Me.btnFirst.set_Glyph(DirectCast(manager.GetObject("btnFirst.Glyph"), Image))
            'Me.btnFirst.set_Id(&H42)
            'Me.btnFirst.set_Name("btnFirst")
            'Me.btnPrevious.set_Caption("Previous")
            'guid9 = New Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
            'Me.btnPrevious.set_CategoryGuid(guid9)
            'Me.btnPrevious.set_Glyph(DirectCast(manager.GetObject("btnPrevious.Glyph"), Image))
            'Me.btnPrevious.set_Id(&H43)
            'Me.btnPrevious.set_Name("btnPrevious")
            'Me.btnNext.set_Caption("Next")
            'guid9 = New Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
            'Me.btnNext.set_CategoryGuid(guid9)
            'Me.btnNext.set_Glyph(DirectCast(manager.GetObject("btnNext.Glyph"), Image))
            'Me.btnNext.set_Id(&H44)
            'Me.btnNext.set_Name("btnNext")
            'Me.btnLast.set_Caption("Last")
            'guid9 = New Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
            'Me.btnLast.set_CategoryGuid(guid9)
            'Me.btnLast.set_Glyph(DirectCast(manager.GetObject("btnLast.Glyph"), Image))
            'Me.btnLast.set_Id(&H45)
            'Me.btnLast.set_Name("btnLast")
            Me.DockManager1.set_Form(Me)
            Me.DockManager1.get_TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar"})
            Dim size As New Size(5, 13)
            Me.AutoScaleBaseSize = Size
            Size = New Size(&H488, &H10A)
            Me.ClientSize = Size
            'Me.Controls.Add(Me.barDockControlLeft)
            'Me.Controls.Add(Me.barDockControlRight)
            'Me.Controls.Add(Me.barDockControlBottom)
            'Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frmBKForm"
            Me.Text = "frmBKForm"
            'Me.BarManager1.EndInit()
            'Me.cmbViewListRepos.EndInit()
            'Me.txtQuickSearchRepos.EndInit()
            'Me.cmbReportListRepos.EndInit()
            'Me.cmbFilterListRepos.EndInit()
            'Me.cmbDefaultListRepos.EndInit()
            Me.DockManager1.EndInit()
            Me.ResumeLayout(False)
        End Sub

        Public Sub SetBKOjects(ByVal CurrentSessionInfo As clsSessionInfo)
            Me.mvarSessionInfo = CurrentSessionInfo
            Me.Cls1 = New clsDataSet(Me.SessionInfo)
            Me.BKGlobal = New clsGlobal(Me.SessionInfo)
            Me.BKFilter = New clsFilter(Me.SessionInfo)
            Me.BKBrowseView = New clsBrowseView(Me.SessionInfo)
            Me.BKDefaultSet = New clsDefaultSet(Me.SessionInfo)
            Me.BKReport = New clsReport(Me.SessionInfo)
            Me.BKCombo = New clsCombo(Me.SessionInfo)
        End Sub


        ' Properties
        Friend Overridable Property barDockControlBottom As BarDockControl
            Get
                Return Me._barDockControlBottom
            End Get
            Set(ByVal WithEventsValue As BarDockControl)
                Me._barDockControlBottom = WithEventsValue
            End Set
        End Property

        Friend Overridable Property barDockControlLeft As BarDockControl
            Get
                Return Me._barDockControlLeft
            End Get
            Set(ByVal WithEventsValue As BarDockControl)
                Me._barDockControlLeft = WithEventsValue
            End Set
        End Property

        Friend Overridable Property barDockControlRight As BarDockControl
            Get
                Return Me._barDockControlRight
            End Get
            Set(ByVal WithEventsValue As BarDockControl)
                Me._barDockControlRight = WithEventsValue
            End Set
        End Property

        Friend Overridable Property barDockControlTop As BarDockControl
            Get
                Return Me._barDockControlTop
            End Get
            Set(ByVal WithEventsValue As BarDockControl)
                Me._barDockControlTop = WithEventsValue
            End Set
        End Property

        Public Overridable Property BarManager1 As BarManager
            Get
                Return Me._BarManager1
            End Get
            Set(ByVal WithEventsValue As BarManager)
                Me._BarManager1 = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnAttachements As BarButtonItem
            Get
                Return Me._btnAttachements
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnAttachements Is Nothing) Then
                    Me._btnAttachements.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnAttachements_ItemClick, IntPtr)))
                End If
                Me._btnAttachements = WithEventsValue
                If (Not Me._btnAttachements Is Nothing) Then
                    Me._btnAttachements.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnAttachements_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnComments As BarButtonItem
            Get
                Return Me._btnComments
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnComments Is Nothing) Then
                    Me._btnComments.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnComments_ItemClick, IntPtr)))
                End If
                Me._btnComments = WithEventsValue
                If (Not Me._btnComments Is Nothing) Then
                    Me._btnComments.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnComments_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnCopyDefault As BarButtonItem
            Get
                Return Me._btnCopyDefault
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnCopyDefault Is Nothing) Then
                    Me._btnCopyDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnCopyDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnCopyDefault_ItemClick, IntPtr)))
                End If
                Me._btnCopyDefault = WithEventsValue
                If (Not Me._btnCopyDefault Is Nothing) Then
                    Me._btnCopyDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnCopyDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnCopyDefault_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnCopyFilter As BarButtonItem
            Get
                Return Me._btnCopyFilter
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnCopyFilter Is Nothing) Then
                    Me._btnCopyFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnCopyFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnCopyFilter_ItemClick, IntPtr)))
                End If
                Me._btnCopyFilter = WithEventsValue
                If (Not Me._btnCopyFilter Is Nothing) Then
                    Me._btnCopyFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnCopyFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnCopyFilter_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnCopyReport As BarButtonItem
            Get
                Return Me._btnCopyReport
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnCopyReport Is Nothing) Then
                    Me._btnCopyReport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnCopyReport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnCopyReport_ItemClick, IntPtr)))
                End If
                Me._btnCopyReport = WithEventsValue
                If (Not Me._btnCopyReport Is Nothing) Then
                    Me._btnCopyReport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnCopyReport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnCopyReport_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnCopyView As BarButtonItem
            Get
                Return Me._btnCopyView
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnCopyView Is Nothing) Then
                    Me._btnCopyView.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._btnCopyView = WithEventsValue
                If (Not Me._btnCopyView Is Nothing) Then
                    Me._btnCopyView.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnDefault As BarButtonItem
            Get
                Return Me._btnDefault
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnDefault Is Nothing) Then
                    Me._btnDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDefault_ItemClick, IntPtr)))
                End If
                Me._btnDefault = WithEventsValue
                If (Not Me._btnDefault Is Nothing) Then
                    Me._btnDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDefault_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnDefaultDetail As BarSubItem
            Get
                Return Me._btnDefaultDetail
            End Get
            Set(ByVal WithEventsValue As BarSubItem)
                Me._btnDefaultDetail = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnDelete As BarButtonItem
            Get
                Return Me._btnDelete
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnDelete Is Nothing) Then
                    Me._btnDelete.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnDelete.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDelete_ItemClick, IntPtr)))
                End If
                Me._btnDelete = WithEventsValue
                If (Not Me._btnDelete Is Nothing) Then
                    Me._btnDelete.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnDelete.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDelete_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnDeleteDefault As BarButtonItem
            Get
                Return Me._btnDeleteDefault
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnDeleteDefault Is Nothing) Then
                    Me._btnDeleteDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnDeleteDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDeleteDefault_ItemClick, IntPtr)))
                End If
                Me._btnDeleteDefault = WithEventsValue
                If (Not Me._btnDeleteDefault Is Nothing) Then
                    Me._btnDeleteDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnDeleteDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDeleteDefault_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnDeleteFilter As BarButtonItem
            Get
                Return Me._btnDeleteFilter
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnDeleteFilter Is Nothing) Then
                    Me._btnDeleteFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnDeleteFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDeleteFilter_ItemClick, IntPtr)))
                End If
                Me._btnDeleteFilter = WithEventsValue
                If (Not Me._btnDeleteFilter Is Nothing) Then
                    Me._btnDeleteFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnDeleteFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDeleteFilter_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnDeleteReport As BarButtonItem
            Get
                Return Me._btnDeleteReport
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnDeleteReport Is Nothing) Then
                    Me._btnDeleteReport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnDeleteReport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDeleteReport_ItemClick, IntPtr)))
                End If
                Me._btnDeleteReport = WithEventsValue
                If (Not Me._btnDeleteReport Is Nothing) Then
                    Me._btnDeleteReport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnDeleteReport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDeleteReport_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnDeleteView As BarButtonItem
            Get
                Return Me._btnDeleteView
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnDeleteView Is Nothing) Then
                    Me._btnDeleteView.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._btnDeleteView = WithEventsValue
                If (Not Me._btnDeleteView Is Nothing) Then
                    Me._btnDeleteView.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnDesignReport As BarButtonItem
            Get
                Return Me._btnDesignReport
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnDesignReport Is Nothing) Then
                    Me._btnDesignReport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnDesignReport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDesignReport_ItemClick, IntPtr)))
                End If
                Me._btnDesignReport = WithEventsValue
                If (Not Me._btnDesignReport Is Nothing) Then
                    Me._btnDesignReport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnDesignReport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDesignReport_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnEdit As BarButtonItem
            Get
                Return Me._btnEdit
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnEdit Is Nothing) Then
                    Me._btnEdit.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnEdit.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEdit_ItemClick, IntPtr)))
                End If
                Me._btnEdit = WithEventsValue
                If (Not Me._btnEdit Is Nothing) Then
                    Me._btnEdit.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnEdit.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEdit_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnEditDefault As BarButtonItem
            Get
                Return Me._btnEditDefault
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnEditDefault Is Nothing) Then
                    Me._btnEditDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnEditDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEditDefault_ItemClick, IntPtr)))
                End If
                Me._btnEditDefault = WithEventsValue
                If (Not Me._btnEditDefault Is Nothing) Then
                    Me._btnEditDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnEditDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEditDefault_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnEditFilter As BarButtonItem
            Get
                Return Me._btnEditFilter
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnEditFilter Is Nothing) Then
                    Me._btnEditFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnEditFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEditFilter_ItemClick, IntPtr)))
                End If
                Me._btnEditFilter = WithEventsValue
                If (Not Me._btnEditFilter Is Nothing) Then
                    Me._btnEditFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnEditFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEditFilter_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnEditReportInfo As BarButtonItem
            Get
                Return Me._btnEditReportInfo
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnEditReportInfo Is Nothing) Then
                    Me._btnEditReportInfo.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnEditReportInfo.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEditReportInfo_ItemClick, IntPtr)))
                End If
                Me._btnEditReportInfo = WithEventsValue
                If (Not Me._btnEditReportInfo Is Nothing) Then
                    Me._btnEditReportInfo.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnEditReportInfo.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEditReportInfo_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnEditView As BarButtonItem
            Get
                Return Me._btnEditView
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnEditView Is Nothing) Then
                    Me._btnEditView.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._btnEditView = WithEventsValue
                If (Not Me._btnEditView Is Nothing) Then
                    Me._btnEditView.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnExportXML As BarButtonItem
            Get
                Return Me._btnExportXML
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnExportXML Is Nothing) Then
                    Me._btnExportXML.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnExportXML_ItemClick, IntPtr)))
                End If
                Me._btnExportXML = WithEventsValue
                If (Not Me._btnExportXML Is Nothing) Then
                    Me._btnExportXML.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnExportXML_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnFilter As BarButtonItem
            Get
                Return Me._btnFilter
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnFilter Is Nothing) Then
                    Me._btnFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnFilter_ItemClick, IntPtr)))
                End If
                Me._btnFilter = WithEventsValue
                If (Not Me._btnFilter Is Nothing) Then
                    Me._btnFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnFilter_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnFilterDetail As BarSubItem
            Get
                Return Me._btnFilterDetail
            End Get
            Set(ByVal WithEventsValue As BarSubItem)
                Me._btnFilterDetail = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnFirst As BarButtonItem
            Get
                Return Me._btnFirst
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnFirst Is Nothing) Then
                    Me._btnFirst.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnFirst_ItemClick, IntPtr)))
                End If
                Me._btnFirst = WithEventsValue
                If (Not Me._btnFirst Is Nothing) Then
                    Me._btnFirst.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnFirst_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnImportXML As BarButtonItem
            Get
                Return Me._btnImportXML
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnImportXML Is Nothing) Then
                    Me._btnImportXML.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnImportXML_ItemClick, IntPtr)))
                End If
                Me._btnImportXML = WithEventsValue
                If (Not Me._btnImportXML Is Nothing) Then
                    Me._btnImportXML.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnImportXML_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnLast As BarButtonItem
            Get
                Return Me._btnLast
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnLast Is Nothing) Then
                    Me._btnLast.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnLast_ItemClick, IntPtr)))
                End If
                Me._btnLast = WithEventsValue
                If (Not Me._btnLast Is Nothing) Then
                    Me._btnLast.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnLast_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnMakeDefaultCommon As BarButtonItem
            Get
                Return Me._btnMakeDefaultCommon
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnMakeDefaultCommon Is Nothing) Then
                    Me._btnMakeDefaultCommon.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnMakeDefaultCommon.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnMakeDefaultCommon_ItemClick, IntPtr)))
                End If
                Me._btnMakeDefaultCommon = WithEventsValue
                If (Not Me._btnMakeDefaultCommon Is Nothing) Then
                    Me._btnMakeDefaultCommon.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnMakeDefaultCommon.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnMakeDefaultCommon_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnMakeFilterCommon As BarButtonItem
            Get
                Return Me._btnMakeFilterCommon
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnMakeFilterCommon Is Nothing) Then
                    Me._btnMakeFilterCommon.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnMakeFilterCommon.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnMakeFilterCommon_ItemClick, IntPtr)))
                End If
                Me._btnMakeFilterCommon = WithEventsValue
                If (Not Me._btnMakeFilterCommon Is Nothing) Then
                    Me._btnMakeFilterCommon.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnMakeFilterCommon.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnMakeFilterCommon_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnMakeReportCommon As BarButtonItem
            Get
                Return Me._btnMakeReportCommon
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnMakeReportCommon Is Nothing) Then
                    Me._btnMakeReportCommon.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnMakeReportCommon.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnMakeReportCommon_ItemClick, IntPtr)))
                End If
                Me._btnMakeReportCommon = WithEventsValue
                If (Not Me._btnMakeReportCommon Is Nothing) Then
                    Me._btnMakeReportCommon.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnMakeReportCommon.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnMakeReportCommon_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnMakeViewCommon As BarButtonItem
            Get
                Return Me._btnMakeViewCommon
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnMakeViewCommon Is Nothing) Then
                    Me._btnMakeViewCommon.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._btnMakeViewCommon = WithEventsValue
                If (Not Me._btnMakeViewCommon Is Nothing) Then
                    Me._btnMakeViewCommon.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnNew As BarButtonItem
            Get
                Return Me._btnNew
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnNew Is Nothing) Then
                    Me._btnNew.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnNew.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNew_ItemClick, IntPtr)))
                End If
                Me._btnNew = WithEventsValue
                If (Not Me._btnNew Is Nothing) Then
                    Me._btnNew.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnNew.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNew_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnNewDefault As BarButtonItem
            Get
                Return Me._btnNewDefault
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnNewDefault Is Nothing) Then
                    Me._btnNewDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnNewDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNewDefault_ItemClick, IntPtr)))
                End If
                Me._btnNewDefault = WithEventsValue
                If (Not Me._btnNewDefault Is Nothing) Then
                    Me._btnNewDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnNewDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNewDefault_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnNewFilter As BarButtonItem
            Get
                Return Me._btnNewFilter
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnNewFilter Is Nothing) Then
                    Me._btnNewFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnNewFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNewFilter_ItemClick, IntPtr)))
                End If
                Me._btnNewFilter = WithEventsValue
                If (Not Me._btnNewFilter Is Nothing) Then
                    Me._btnNewFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnNewFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNewFilter_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnNewReport As BarButtonItem
            Get
                Return Me._btnNewReport
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnNewReport Is Nothing) Then
                    Me._btnNewReport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnNewReport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNewReport_ItemClick, IntPtr)))
                End If
                Me._btnNewReport = WithEventsValue
                If (Not Me._btnNewReport Is Nothing) Then
                    Me._btnNewReport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnNewReport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNewReport_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnNewView As BarButtonItem
            Get
                Return Me._btnNewView
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnNewView Is Nothing) Then
                    Me._btnNewView.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._btnNewView = WithEventsValue
                If (Not Me._btnNewView Is Nothing) Then
                    Me._btnNewView.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnNext As BarButtonItem
            Get
                Return Me._btnNext
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnNext Is Nothing) Then
                    Me._btnNext.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNext_ItemClick, IntPtr)))
                End If
                Me._btnNext = WithEventsValue
                If (Not Me._btnNext Is Nothing) Then
                    Me._btnNext.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNext_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnOK As BarButtonItem
            Get
                Return Me._btnOK
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnOK = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnPrevious As BarButtonItem
            Get
                Return Me._btnPrevious
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnPrevious Is Nothing) Then
                    Me._btnPrevious.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnPrevious_ItemClick, IntPtr)))
                End If
                Me._btnPrevious = WithEventsValue
                If (Not Me._btnPrevious Is Nothing) Then
                    Me._btnPrevious.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnPrevious_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnPrint As BarButtonItem
            Get
                Return Me._btnPrint
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnPrint Is Nothing) Then
                    Me._btnPrint.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnPrint.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnPrint_ItemClick, IntPtr)))
                End If
                Me._btnPrint = WithEventsValue
                If (Not Me._btnPrint Is Nothing) Then
                    Me._btnPrint.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnPrint.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnPrint_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnQuickSearch As BarButtonItem
            Get
                Return Me._btnQuickSearch
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnQuickSearch Is Nothing) Then
                    Me._btnQuickSearch.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnQuickSearch.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnQuickSearch_ItemClick, IntPtr)))
                End If
                Me._btnQuickSearch = WithEventsValue
                If (Not Me._btnQuickSearch Is Nothing) Then
                    Me._btnQuickSearch.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnQuickSearch.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnQuickSearch_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnReportDetail As BarSubItem
            Get
                Return Me._btnReportDetail
            End Get
            Set(ByVal WithEventsValue As BarSubItem)
                Me._btnReportDetail = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnSave As BarButtonItem
            Get
                Return Me._btnSave
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSave Is Nothing) Then
                    Me._btnSave.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnSave.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSave_ItemClick, IntPtr)))
                End If
                Me._btnSave = WithEventsValue
                If (Not Me._btnSave Is Nothing) Then
                    Me._btnSave.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnSave.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSave_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnSaveDefault As BarButtonItem
            Get
                Return Me._btnSaveDefault
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSaveDefault Is Nothing) Then
                    Me._btnSaveDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnSaveDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSaveDefault_ItemClick, IntPtr)))
                End If
                Me._btnSaveDefault = WithEventsValue
                If (Not Me._btnSaveDefault Is Nothing) Then
                    Me._btnSaveDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnSaveDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSaveDefault_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnSaveView As BarButtonItem
            Get
                Return Me._btnSaveView
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSaveView Is Nothing) Then
                    Me._btnSaveView.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._btnSaveView = WithEventsValue
                If (Not Me._btnSaveView Is Nothing) Then
                    Me._btnSaveView.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnSendDefaultUser As BarButtonItem
            Get
                Return Me._btnSendDefaultUser
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSendDefaultUser Is Nothing) Then
                    Me._btnSendDefaultUser.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnSendDefaultUser.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSendDefaultUser_ItemClick, IntPtr)))
                End If
                Me._btnSendDefaultUser = WithEventsValue
                If (Not Me._btnSendDefaultUser Is Nothing) Then
                    Me._btnSendDefaultUser.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnSendDefaultUser.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSendDefaultUser_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnSendFilterUSer As BarButtonItem
            Get
                Return Me._btnSendFilterUSer
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSendFilterUSer Is Nothing) Then
                    Me._btnSendFilterUSer.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnSendFilterUSer.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSendFilterUSer_ItemClick, IntPtr)))
                End If
                Me._btnSendFilterUSer = WithEventsValue
                If (Not Me._btnSendFilterUSer Is Nothing) Then
                    Me._btnSendFilterUSer.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnSendFilterUSer.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSendFilterUSer_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnSendReportUser As BarButtonItem
            Get
                Return Me._btnSendReportUser
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSendReportUser Is Nothing) Then
                    Me._btnSendReportUser.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnSendReportUser.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSendReportUser_ItemClick, IntPtr)))
                End If
                Me._btnSendReportUser = WithEventsValue
                If (Not Me._btnSendReportUser Is Nothing) Then
                    Me._btnSendReportUser.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    Me._btnSendReportUser.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSendReportUser_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnSendViewUser As BarButtonItem
            Get
                Return Me._btnSendViewUser
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSendViewUser Is Nothing) Then
                    Me._btnSendViewUser.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._btnSendViewUser = WithEventsValue
                If (Not Me._btnSendViewUser Is Nothing) Then
                    Me._btnSendViewUser.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnTranslation As BarButtonItem
            Get
                Return Me._btnTranslation
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnTranslation Is Nothing) Then
                    Me._btnTranslation.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnTranslation_ItemClick, IntPtr)))
                End If
                Me._btnTranslation = WithEventsValue
                If (Not Me._btnTranslation Is Nothing) Then
                    Me._btnTranslation.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnTranslation_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnUndo As BarButtonItem
            Get
                Return Me._btnUndo
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnUndo Is Nothing) Then
                    Me._btnUndo.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnUndo_ItemClick, IntPtr)))
                End If
                Me._btnUndo = WithEventsValue
                If (Not Me._btnUndo Is Nothing) Then
                    Me._btnUndo.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnUndo_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnUser1 As BarButtonItem
            Get
                Return Me._btnUser1
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnUser1 = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnUser2 As BarButtonItem
            Get
                Return Me._btnUser2
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnUser2 = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnUser3 As BarButtonItem
            Get
                Return Me._btnUser3
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnUser3 = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnUser4 As BarButtonItem
            Get
                Return Me._btnUser4
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnUser4 = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnUser5 As BarButtonItem
            Get
                Return Me._btnUser5
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnUser5 = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnView As BarButtonItem
            Get
                Return Me._btnView
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnView Is Nothing) Then
                    Me._btnView.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._btnView = WithEventsValue
                If (Not Me._btnView Is Nothing) Then
                    Me._btnView.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnViewDetail As BarSubItem
            Get
                Return Me._btnViewDetail
            End Get
            Set(ByVal WithEventsValue As BarSubItem)
                Me._btnViewDetail = WithEventsValue
            End Set
        End Property

        Public Overridable Property cmbDefaultList As BarEditItem
            Get
                Return Me._cmbDefaultList
            End Get
            Set(ByVal WithEventsValue As BarEditItem)
                Me._cmbDefaultList = WithEventsValue
            End Set
        End Property

        Public Overridable Property cmbDefaultListRepos As RepositoryItemLookUpEdit
            Get
                Return Me._cmbDefaultListRepos
            End Get
            Set(ByVal WithEventsValue As RepositoryItemLookUpEdit)
                If (Not Me._cmbDefaultListRepos Is Nothing) Then
                    Me._cmbDefaultListRepos.remove_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbRepos_ButtonClick, IntPtr)))
                End If
                Me._cmbDefaultListRepos = WithEventsValue
                If (Not Me._cmbDefaultListRepos Is Nothing) Then
                    Me._cmbDefaultListRepos.add_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbRepos_ButtonClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property cmbFilterList As BarEditItem
            Get
                Return Me._cmbFilterList
            End Get
            Set(ByVal WithEventsValue As BarEditItem)
                Me._cmbFilterList = WithEventsValue
            End Set
        End Property

        Public Overridable Property cmbFilterListRepos As RepositoryItemLookUpEdit
            Get
                Return Me._cmbFilterListRepos
            End Get
            Set(ByVal WithEventsValue As RepositoryItemLookUpEdit)
                If (Not Me._cmbFilterListRepos Is Nothing) Then
                    Me._cmbFilterListRepos.remove_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbRepos_ButtonClick, IntPtr)))
                End If
                Me._cmbFilterListRepos = WithEventsValue
                If (Not Me._cmbFilterListRepos Is Nothing) Then
                    Me._cmbFilterListRepos.add_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbRepos_ButtonClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property cmbReportList As BarEditItem
            Get
                Return Me._cmbReportList
            End Get
            Set(ByVal WithEventsValue As BarEditItem)
                Me._cmbReportList = WithEventsValue
            End Set
        End Property

        Public Overridable Property cmbReportListRepos As RepositoryItemLookUpEdit
            Get
                Return Me._cmbReportListRepos
            End Get
            Set(ByVal WithEventsValue As RepositoryItemLookUpEdit)
                If (Not Me._cmbReportListRepos Is Nothing) Then
                    Me._cmbReportListRepos.remove_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbRepos_ButtonClick, IntPtr)))
                End If
                Me._cmbReportListRepos = WithEventsValue
                If (Not Me._cmbReportListRepos Is Nothing) Then
                    Me._cmbReportListRepos.add_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbRepos_ButtonClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property cmbViewList As BarEditItem
            Get
                Return Me._cmbViewList
            End Get
            Set(ByVal WithEventsValue As BarEditItem)
                Me._cmbViewList = WithEventsValue
            End Set
        End Property

        Public Overridable Property cmbViewListRepos As RepositoryItemLookUpEdit
            Get
                Return Me._cmbViewListRepos
            End Get
            Set(ByVal WithEventsValue As RepositoryItemLookUpEdit)
                If (Not Me._cmbViewListRepos Is Nothing) Then
                    Me._cmbViewListRepos.remove_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbRepos_ButtonClick, IntPtr)))
                End If
                Me._cmbViewListRepos = WithEventsValue
                If (Not Me._cmbViewListRepos Is Nothing) Then
                    Me._cmbViewListRepos.add_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbRepos_ButtonClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property DefaultSet_Bar As Bar
            Get
                Return Me._DefaultSet_Bar
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._DefaultSet_Bar = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DockManager1 As DockManager
            Get
                Return Me._DockManager1
            End Get
            Set(ByVal WithEventsValue As DockManager)
                Me._DockManager1 = WithEventsValue
            End Set
        End Property

        Public Overridable Property Filter_Bar As Bar
            Get
                Return Me._Filter_Bar
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._Filter_Bar = WithEventsValue
            End Set
        End Property

        Public Overridable Property Main_Bar As Bar
            Get
                Return Me._Main_Bar
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._Main_Bar = WithEventsValue
            End Set
        End Property

        Public Overridable Property MainBtns_btnBestFit As BarButtonItem
            Get
                Return Me._MainBtns_btnBestFit
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._MainBtns_btnBestFit Is Nothing) Then
                    Me._MainBtns_btnBestFit.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._MainBtns_btnBestFit = WithEventsValue
                If (Not Me._MainBtns_btnBestFit Is Nothing) Then
                    Me._MainBtns_btnBestFit.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property MainBtns_btnBigger As BarButtonItem
            Get
                Return Me._MainBtns_btnBigger
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._MainBtns_btnBigger Is Nothing) Then
                    Me._MainBtns_btnBigger.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._MainBtns_btnBigger = WithEventsValue
                If (Not Me._MainBtns_btnBigger Is Nothing) Then
                    Me._MainBtns_btnBigger.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property MainBtns_btnExcel As BarButtonItem
            Get
                Return Me._MainBtns_btnExcel
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._MainBtns_btnExcel Is Nothing) Then
                    Me._MainBtns_btnExcel.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._MainBtns_btnExcel = WithEventsValue
                If (Not Me._MainBtns_btnExcel Is Nothing) Then
                    Me._MainBtns_btnExcel.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property MainBtns_btnSmaller As BarButtonItem
            Get
                Return Me._MainBtns_btnSmaller
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._MainBtns_btnSmaller Is Nothing) Then
                    Me._MainBtns_btnSmaller.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._MainBtns_btnSmaller = WithEventsValue
                If (Not Me._MainBtns_btnSmaller Is Nothing) Then
                    Me._MainBtns_btnSmaller.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property Misc_Bar As Bar
            Get
                Return Me._Misc_Bar
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._Misc_Bar = WithEventsValue
            End Set
        End Property

        Public Overridable Property Misc_Bar2 As Bar
            Get
                Return Me._Misc_Bar2
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._Misc_Bar2 = WithEventsValue
            End Set
        End Property

        Public Overridable Property Nav_Bar As Bar
            Get
                Return Me._Nav_Bar
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._Nav_Bar = WithEventsValue
            End Set
        End Property

        Public Overridable Property QuickSearch_Bar As Bar
            Get
                Return Me._QuickSearch_Bar
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._QuickSearch_Bar = WithEventsValue
            End Set
        End Property

        Public Overridable Property Report_Bar As Bar
            Get
                Return Me._Report_Bar
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._Report_Bar = WithEventsValue
            End Set
        End Property

        Public Property SessionInfo As clsSessionInfo
            Get
                Return Me.mvarSessionInfo
            End Get
            Set(ByVal Value As clsSessionInfo)
                Me.mvarSessionInfo = Value
            End Set
        End Property

        Public Overridable Property txtQuickSearch As BarEditItem
            Get
                Return Me._txtQuickSearch
            End Get
            Set(ByVal WithEventsValue As BarEditItem)
                Me._txtQuickSearch = WithEventsValue
            End Set
        End Property

        Public Overridable Property txtQuickSearchRepos As RepositoryItemTextEdit
            Get
                Return Me._txtQuickSearchRepos
            End Get
            Set(ByVal WithEventsValue As RepositoryItemTextEdit)
                Me._txtQuickSearchRepos = WithEventsValue
            End Set
        End Property

        Public Overridable Property View_Bar As Bar
            Get
                Return Me._View_Bar
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._View_Bar = WithEventsValue
            End Set
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        <AccessedThroughProperty("barDockControlBottom")> _
        Private _barDockControlBottom As BarDockControl
        <AccessedThroughProperty("barDockControlLeft")> _
        Private _barDockControlLeft As BarDockControl
        <AccessedThroughProperty("barDockControlRight")> _
        Private _barDockControlRight As BarDockControl
        <AccessedThroughProperty("barDockControlTop")> _
        Private _barDockControlTop As BarDockControl
        <AccessedThroughProperty("BarManager1")> _
        Private _BarManager1 As BarManager
        <AccessedThroughProperty("btnAttachements")> _
        Private _btnAttachements As BarButtonItem
        <AccessedThroughProperty("btnComments")> _
        Private _btnComments As BarButtonItem
        <AccessedThroughProperty("btnCopyDefault")> _
        Private _btnCopyDefault As BarButtonItem
        <AccessedThroughProperty("btnCopyFilter")> _
        Private _btnCopyFilter As BarButtonItem
        <AccessedThroughProperty("btnCopyReport")> _
        Private _btnCopyReport As BarButtonItem
        <AccessedThroughProperty("btnCopyView")> _
        Private _btnCopyView As BarButtonItem
        <AccessedThroughProperty("btnDefault")> _
        Private _btnDefault As BarButtonItem
        <AccessedThroughProperty("btnDefaultDetail")> _
        Private _btnDefaultDetail As BarSubItem
        <AccessedThroughProperty("btnDelete")> _
        Private _btnDelete As BarButtonItem
        <AccessedThroughProperty("btnDeleteDefault")> _
        Private _btnDeleteDefault As BarButtonItem
        <AccessedThroughProperty("btnDeleteFilter")> _
        Private _btnDeleteFilter As BarButtonItem
        <AccessedThroughProperty("btnDeleteReport")> _
        Private _btnDeleteReport As BarButtonItem
        <AccessedThroughProperty("btnDeleteView")> _
        Private _btnDeleteView As BarButtonItem
        <AccessedThroughProperty("btnDesignReport")> _
        Private _btnDesignReport As BarButtonItem
        <AccessedThroughProperty("btnEdit")> _
        Private _btnEdit As BarButtonItem
        <AccessedThroughProperty("btnEditDefault")> _
        Private _btnEditDefault As BarButtonItem
        <AccessedThroughProperty("btnEditFilter")> _
        Private _btnEditFilter As BarButtonItem
        <AccessedThroughProperty("btnEditReportInfo")> _
        Private _btnEditReportInfo As BarButtonItem
        <AccessedThroughProperty("btnEditView")> _
        Private _btnEditView As BarButtonItem
        <AccessedThroughProperty("btnExportXML")> _
        Private _btnExportXML As BarButtonItem
        <AccessedThroughProperty("btnFilter")> _
        Private _btnFilter As BarButtonItem
        <AccessedThroughProperty("btnFilterDetail")> _
        Private _btnFilterDetail As BarSubItem
        <AccessedThroughProperty("btnFirst")> _
        Private _btnFirst As BarButtonItem
        <AccessedThroughProperty("btnImportXML")> _
        Private _btnImportXML As BarButtonItem
        <AccessedThroughProperty("btnLast")> _
        Private _btnLast As BarButtonItem
        <AccessedThroughProperty("btnMakeDefaultCommon")> _
        Private _btnMakeDefaultCommon As BarButtonItem
        <AccessedThroughProperty("btnMakeFilterCommon")> _
        Private _btnMakeFilterCommon As BarButtonItem
        <AccessedThroughProperty("btnMakeReportCommon")> _
        Private _btnMakeReportCommon As BarButtonItem
        <AccessedThroughProperty("btnMakeViewCommon")> _
        Private _btnMakeViewCommon As BarButtonItem
        <AccessedThroughProperty("btnNew")> _
        Private _btnNew As BarButtonItem
        <AccessedThroughProperty("btnNewDefault")> _
        Private _btnNewDefault As BarButtonItem
        <AccessedThroughProperty("btnNewFilter")> _
        Private _btnNewFilter As BarButtonItem
        <AccessedThroughProperty("btnNewReport")> _
        Private _btnNewReport As BarButtonItem
        <AccessedThroughProperty("btnNewView")> _
        Private _btnNewView As BarButtonItem
        <AccessedThroughProperty("btnNext")> _
        Private _btnNext As BarButtonItem
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As BarButtonItem
        <AccessedThroughProperty("btnPrevious")> _
        Private _btnPrevious As BarButtonItem
        <AccessedThroughProperty("btnPrint")> _
        Private _btnPrint As BarButtonItem
        <AccessedThroughProperty("btnQuickSearch")> _
        Private _btnQuickSearch As BarButtonItem
        <AccessedThroughProperty("btnReportDetail")> _
        Private _btnReportDetail As BarSubItem
        <AccessedThroughProperty("btnSave")> _
        Private _btnSave As BarButtonItem
        <AccessedThroughProperty("btnSaveDefault")> _
        Private _btnSaveDefault As BarButtonItem
        <AccessedThroughProperty("btnSaveView")> _
        Private _btnSaveView As BarButtonItem
        <AccessedThroughProperty("btnSendDefaultUser")> _
        Private _btnSendDefaultUser As BarButtonItem
        <AccessedThroughProperty("btnSendFilterUSer")> _
        Private _btnSendFilterUSer As BarButtonItem
        <AccessedThroughProperty("btnSendReportUser")> _
        Private _btnSendReportUser As BarButtonItem
        <AccessedThroughProperty("btnSendViewUser")> _
        Private _btnSendViewUser As BarButtonItem
        <AccessedThroughProperty("btnTranslation")> _
        Private _btnTranslation As BarButtonItem
        <AccessedThroughProperty("btnUndo")> _
        Private _btnUndo As BarButtonItem
        <AccessedThroughProperty("btnUser1")> _
        Private _btnUser1 As BarButtonItem
        <AccessedThroughProperty("btnUser2")> _
        Private _btnUser2 As BarButtonItem
        <AccessedThroughProperty("btnUser3")> _
        Private _btnUser3 As BarButtonItem
        <AccessedThroughProperty("btnUser4")> _
        Private _btnUser4 As BarButtonItem
        <AccessedThroughProperty("btnUser5")> _
        Private _btnUser5 As BarButtonItem
        <AccessedThroughProperty("btnView")> _
        Private _btnView As BarButtonItem
        <AccessedThroughProperty("btnViewDetail")> _
        Private _btnViewDetail As BarSubItem
        <AccessedThroughProperty("cmbDefaultList")> _
        Private _cmbDefaultList As BarEditItem
        <AccessedThroughProperty("cmbDefaultListRepos")> _
        Private _cmbDefaultListRepos As RepositoryItemLookUpEdit
        <AccessedThroughProperty("cmbFilterList")> _
        Private _cmbFilterList As BarEditItem
        <AccessedThroughProperty("cmbFilterListRepos")> _
        Private _cmbFilterListRepos As RepositoryItemLookUpEdit
        <AccessedThroughProperty("cmbReportList")> _
        Private _cmbReportList As BarEditItem
        <AccessedThroughProperty("cmbReportListRepos")> _
        Private _cmbReportListRepos As RepositoryItemLookUpEdit
        <AccessedThroughProperty("cmbViewList")> _
        Private _cmbViewList As BarEditItem
        <AccessedThroughProperty("cmbViewListRepos")> _
        Private _cmbViewListRepos As RepositoryItemLookUpEdit
        <AccessedThroughProperty("DefaultSet_Bar")> _
        Private _DefaultSet_Bar As Bar
        <AccessedThroughProperty("DockManager1")> _
        Private _DockManager1 As DockManager
        <AccessedThroughProperty("Filter_Bar")> _
        Private _Filter_Bar As Bar
        <AccessedThroughProperty("Main_Bar")> _
        Private _Main_Bar As Bar
        <AccessedThroughProperty("MainBtns_btnBestFit")> _
        Private _MainBtns_btnBestFit As BarButtonItem
        <AccessedThroughProperty("MainBtns_btnBigger")> _
        Private _MainBtns_btnBigger As BarButtonItem
        <AccessedThroughProperty("MainBtns_btnExcel")> _
        Private _MainBtns_btnExcel As BarButtonItem
        <AccessedThroughProperty("MainBtns_btnSmaller")> _
        Private _MainBtns_btnSmaller As BarButtonItem
        <AccessedThroughProperty("Misc_Bar")> _
        Private _Misc_Bar As Bar
        <AccessedThroughProperty("Misc_Bar2")> _
        Private _Misc_Bar2 As Bar
        <AccessedThroughProperty("Nav_Bar")> _
        Private _Nav_Bar As Bar
        <AccessedThroughProperty("QuickSearch_Bar")> _
        Private _QuickSearch_Bar As Bar
        <AccessedThroughProperty("Report_Bar")> _
        Private _Report_Bar As Bar
        <AccessedThroughProperty("txtQuickSearch")> _
        Private _txtQuickSearch As BarEditItem
        <AccessedThroughProperty("txtQuickSearchRepos")> _
        Private _txtQuickSearchRepos As RepositoryItemTextEdit
        <AccessedThroughProperty("View_Bar")> _
        Private _View_Bar As Bar
        Public BKBrowseView As clsBrowseView
        Public BKCombo As clsCombo
        Public BKDefaultSet As clsDefaultSet
        Public BKFilter As clsFilter
        Public BKGlobal As clsGlobal
        Public BKReport As clsReport
        Public Cls1 As clsDataSet
        Private components As IContainer
        Public mvarSessionInfo As clsSessionInfo
    End Class
End Namespace

