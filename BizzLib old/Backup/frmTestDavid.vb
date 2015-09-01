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
    Public Class frmTestDavid

        Friend Overridable Property barDockControlBottom() As BarDockControl
            Get
                Return Me._barDockControlBottom
            End Get
            Set(ByVal WithEventsValue As BarDockControl)
                Me._barDockControlBottom = WithEventsValue
            End Set
        End Property

        Friend Overridable Property barDockControlLeft() As BarDockControl
            Get
                Return Me._barDockControlLeft
            End Get
            Set(ByVal WithEventsValue As BarDockControl)
                Me._barDockControlLeft = WithEventsValue
            End Set
        End Property

        Friend Overridable Property barDockControlRight() As BarDockControl
            Get
                Return Me._barDockControlRight
            End Get
            Set(ByVal WithEventsValue As BarDockControl)
                Me._barDockControlRight = WithEventsValue
            End Set
        End Property

        Friend Overridable Property barDockControlTop() As BarDockControl
            Get
                Return Me._barDockControlTop
            End Get
            Set(ByVal WithEventsValue As BarDockControl)
                Me._barDockControlTop = WithEventsValue
            End Set
        End Property

        Public Overridable Property BarManager1() As BarManager
            Get
                Return Me._BarManager1
            End Get
            Set(ByVal WithEventsValue As BarManager)
                Me._BarManager1 = WithEventsValue
            End Set
        End Property

          Public Overridable Property btnAttachements() As BarButtonItem
            Get
                Return Me._btnAttachements
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnAttachements Is Nothing) Then
                    ' RemoveHandler Me._btnAttachements.ItemClick, New ItemClickEventHandler(AddressOf Me.btnAttachements_ItemClick)
                End If
                Me._btnAttachements = WithEventsValue
                If (Not Me._btnAttachements Is Nothing) Then
                    ' AddHandler Me._btnAttachements.ItemClick, New ItemClickEventHandler(AddressOf Me.btnAttachements_ItemClick)
                End If
            End Set
        End Property

        Public Overridable Property btnComments() As BarButtonItem
            Get
                Return Me._btnComments
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnComments Is Nothing) Then
                    'Me._btnComments.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnComments_ItemClick, IntPtr)))
                End If
                Me._btnComments = WithEventsValue
                If (Not Me._btnComments Is Nothing) Then
                    'Me._btnComments.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnComments_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnCopyDefault() As BarButtonItem
            Get
                Return Me._btnCopyDefault
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnCopyDefault Is Nothing) Then
                    'Me._btnCopyDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnCopyDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnCopyDefault_ItemClick, IntPtr)))
                End If
                Me._btnCopyDefault = WithEventsValue
                If (Not Me._btnCopyDefault Is Nothing) Then
                    'Me._btnCopyDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnCopyDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnCopyDefault_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnCopyFilter() As BarButtonItem
            Get
                Return Me._btnCopyFilter
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnCopyFilter Is Nothing) Then
                    ' Me._btnCopyFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnCopyFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnCopyFilter_ItemClick, IntPtr)))
                End If
                Me._btnCopyFilter = WithEventsValue
                If (Not Me._btnCopyFilter Is Nothing) Then
                    ' Me._btnCopyFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnCopyFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnCopyFilter_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnCopyReport() As BarButtonItem
            Get
                Return Me._btnCopyReport
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnCopyReport Is Nothing) Then
                    ' Me._btnCopyReport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnCopyReport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnCopyReport_ItemClick, IntPtr)))
                End If
                Me._btnCopyReport = WithEventsValue
                If (Not Me._btnCopyReport Is Nothing) Then
                    ' Me._btnCopyReport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnCopyReport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnCopyReport_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnCopyView() As BarButtonItem
            Get
                Return Me._btnCopyView
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnCopyView Is Nothing) Then
                    ' Me._btnCopyView.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._btnCopyView = WithEventsValue
                If (Not Me._btnCopyView Is Nothing) Then
                    '  Me._btnCopyView.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnDefault() As BarButtonItem
            Get
                Return Me._btnDefault
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnDefault Is Nothing) Then
                    ' Me._btnDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDefault_ItemClick, IntPtr)))
                End If
                Me._btnDefault = WithEventsValue
                If (Not Me._btnDefault Is Nothing) Then
                    ' Me._btnDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDefault_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnDefaultDetail() As BarSubItem
            Get
                Return Me._btnDefaultDetail
            End Get
            Set(ByVal WithEventsValue As BarSubItem)
                Me._btnDefaultDetail = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnDelete() As BarButtonItem
            Get
                Return Me._btnDelete
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnDelete Is Nothing) Then
                    '  Me._btnDelete.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnDelete.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDelete_ItemClick, IntPtr)))
                End If
                Me._btnDelete = WithEventsValue
                If (Not Me._btnDelete Is Nothing) Then
                    '  Me._btnDelete.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnDelete.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDelete_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnDeleteDefault() As BarButtonItem
            Get
                Return Me._btnDeleteDefault
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnDeleteDefault Is Nothing) Then
                    '  Me._btnDeleteDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnDeleteDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDeleteDefault_ItemClick, IntPtr)))
                End If
                Me._btnDeleteDefault = WithEventsValue
                If (Not Me._btnDeleteDefault Is Nothing) Then
                    '  Me._btnDeleteDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnDeleteDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDeleteDefault_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnDeleteFilter() As BarButtonItem
            Get
                Return Me._btnDeleteFilter
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnDeleteFilter Is Nothing) Then
                    '  Me._btnDeleteFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnDeleteFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDeleteFilter_ItemClick, IntPtr)))
                End If
                Me._btnDeleteFilter = WithEventsValue
                If (Not Me._btnDeleteFilter Is Nothing) Then
                    '  Me._btnDeleteFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnDeleteFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDeleteFilter_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnDeleteReport() As BarButtonItem
            Get
                Return Me._btnDeleteReport
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnDeleteReport Is Nothing) Then
                    ' Me._btnDeleteReport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnDeleteReport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDeleteReport_ItemClick, IntPtr)))
                End If
                Me._btnDeleteReport = WithEventsValue
                If (Not Me._btnDeleteReport Is Nothing) Then
                    '  Me._btnDeleteReport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnDeleteReport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDeleteReport_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnDeleteView() As BarButtonItem
            Get
                Return Me._btnDeleteView
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnDeleteView Is Nothing) Then
                    '  Me._btnDeleteView.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._btnDeleteView = WithEventsValue
                If (Not Me._btnDeleteView Is Nothing) Then
                    ' Me._btnDeleteView.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnDesignReport() As BarButtonItem
            Get
                Return Me._btnDesignReport
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnDesignReport Is Nothing) Then
                    '  Me._btnDesignReport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnDesignReport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDesignReport_ItemClick, IntPtr)))
                End If
                Me._btnDesignReport = WithEventsValue
                If (Not Me._btnDesignReport Is Nothing) Then
                    '  Me._btnDesignReport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnDesignReport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDesignReport_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnEdit() As BarButtonItem
            Get
                Return Me._btnEdit
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnEdit Is Nothing) Then
                    '  Me._btnEdit.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnEdit.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEdit_ItemClick, IntPtr)))
                End If
                Me._btnEdit = WithEventsValue
                If (Not Me._btnEdit Is Nothing) Then
                    '  Me._btnEdit.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnEdit.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEdit_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnEditDefault() As BarButtonItem
            Get
                Return Me._btnEditDefault
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnEditDefault Is Nothing) Then
                    ' Me._btnEditDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnEditDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEditDefault_ItemClick, IntPtr)))
                End If
                Me._btnEditDefault = WithEventsValue
                If (Not Me._btnEditDefault Is Nothing) Then
                    '  Me._btnEditDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnEditDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEditDefault_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnEditFilter() As BarButtonItem
            Get
                Return Me._btnEditFilter
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnEditFilter Is Nothing) Then
                    '   Me._btnEditFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnEditFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEditFilter_ItemClick, IntPtr)))
                End If
                Me._btnEditFilter = WithEventsValue
                If (Not Me._btnEditFilter Is Nothing) Then
                    '  Me._btnEditFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnEditFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEditFilter_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnEditReportInfo() As BarButtonItem
            Get
                Return Me._btnEditReportInfo
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnEditReportInfo Is Nothing) Then
                    ' Me._btnEditReportInfo.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnEditReportInfo.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEditReportInfo_ItemClick, IntPtr)))
                End If
                Me._btnEditReportInfo = WithEventsValue
                If (Not Me._btnEditReportInfo Is Nothing) Then
                    ' Me._btnEditReportInfo.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnEditReportInfo.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEditReportInfo_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnEditView() As BarButtonItem
            Get
                Return Me._btnEditView
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnEditView Is Nothing) Then
                    '  Me._btnEditView.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._btnEditView = WithEventsValue
                If (Not Me._btnEditView Is Nothing) Then
                    '  Me._btnEditView.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnExportXML() As BarButtonItem
            Get
                Return Me._btnExportXML
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnExportXML Is Nothing) Then
                    '   Me._btnExportXML.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnExportXML_ItemClick, IntPtr)))
                End If
                Me._btnExportXML = WithEventsValue
                If (Not Me._btnExportXML Is Nothing) Then
                    '    Me._btnExportXML.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnExportXML_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnFilter() As BarButtonItem
            Get
                Return Me._btnFilter
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnFilter Is Nothing) Then
                    '   Me._btnFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnFilter_ItemClick, IntPtr)))
                End If
                Me._btnFilter = WithEventsValue
                If (Not Me._btnFilter Is Nothing) Then
                    '  Me._btnFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnFilter_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnFilterDetail() As BarSubItem
            Get
                Return Me._btnFilterDetail
            End Get
            Set(ByVal WithEventsValue As BarSubItem)
                Me._btnFilterDetail = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnFirst() As BarButtonItem
            Get
                Return Me._btnFirst
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnFirst Is Nothing) Then
                    ' Me._btnFirst.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnFirst_ItemClick, IntPtr)))
                End If
                Me._btnFirst = WithEventsValue
                If (Not Me._btnFirst Is Nothing) Then
                    '  Me._btnFirst.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnFirst_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnImportXML() As BarButtonItem
            Get
                Return Me._btnImportXML
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnImportXML Is Nothing) Then
                    '  Me._btnImportXML.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnImportXML_ItemClick, IntPtr)))
                End If
                Me._btnImportXML = WithEventsValue
                If (Not Me._btnImportXML Is Nothing) Then
                    ' Me._btnImportXML.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnImportXML_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnLast() As BarButtonItem
            Get
                Return Me._btnLast
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnLast Is Nothing) Then
                    '   Me._btnLast.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnLast_ItemClick, IntPtr)))
                End If
                Me._btnLast = WithEventsValue
                If (Not Me._btnLast Is Nothing) Then
                    '  Me._btnLast.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnLast_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnMakeDefaultCommon() As BarButtonItem
            Get
                Return Me._btnMakeDefaultCommon
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnMakeDefaultCommon Is Nothing) Then
                    ' Me._btnMakeDefaultCommon.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnMakeDefaultCommon.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnMakeDefaultCommon_ItemClick, IntPtr)))
                End If
                Me._btnMakeDefaultCommon = WithEventsValue
                If (Not Me._btnMakeDefaultCommon Is Nothing) Then
                    ' Me._btnMakeDefaultCommon.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnMakeDefaultCommon.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnMakeDefaultCommon_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnMakeFilterCommon() As BarButtonItem
            Get
                Return Me._btnMakeFilterCommon
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnMakeFilterCommon Is Nothing) Then
                    '  Me._btnMakeFilterCommon.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '   Me._btnMakeFilterCommon.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnMakeFilterCommon_ItemClick, IntPtr)))
                End If
                Me._btnMakeFilterCommon = WithEventsValue
                If (Not Me._btnMakeFilterCommon Is Nothing) Then
                    '   Me._btnMakeFilterCommon.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnMakeFilterCommon.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnMakeFilterCommon_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnMakeReportCommon() As BarButtonItem
            Get
                Return Me._btnMakeReportCommon
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnMakeReportCommon Is Nothing) Then
                    '   Me._btnMakeReportCommon.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnMakeReportCommon.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnMakeReportCommon_ItemClick, IntPtr)))
                End If
                Me._btnMakeReportCommon = WithEventsValue
                If (Not Me._btnMakeReportCommon Is Nothing) Then
                    '   Me._btnMakeReportCommon.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnMakeReportCommon.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnMakeReportCommon_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnMakeViewCommon() As BarButtonItem
            Get
                Return Me._btnMakeViewCommon
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnMakeViewCommon Is Nothing) Then
                    '  Me._btnMakeViewCommon.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._btnMakeViewCommon = WithEventsValue
                If (Not Me._btnMakeViewCommon Is Nothing) Then
                    '  Me._btnMakeViewCommon.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnNew() As BarButtonItem
            Get
                Return Me._btnNew
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnNew Is Nothing) Then
                    '  Me._btnNew.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnNew.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNew_ItemClick, IntPtr)))
                End If
                Me._btnNew = WithEventsValue
                If (Not Me._btnNew Is Nothing) Then
                    '    Me._btnNew.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '   Me._btnNew.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNew_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnNewDefault() As BarButtonItem
            Get
                Return Me._btnNewDefault
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnNewDefault Is Nothing) Then
                    ' Me._btnNewDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnNewDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNewDefault_ItemClick, IntPtr)))
                End If
                Me._btnNewDefault = WithEventsValue
                If (Not Me._btnNewDefault Is Nothing) Then
                    ' Me._btnNewDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnNewDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNewDefault_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnNewFilter() As BarButtonItem
            Get
                Return Me._btnNewFilter
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnNewFilter Is Nothing) Then
                    ' Me._btnNewFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnNewFilter.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNewFilter_ItemClick, IntPtr)))
                End If
                Me._btnNewFilter = WithEventsValue
                If (Not Me._btnNewFilter Is Nothing) Then
                    ' Me._btnNewFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnNewFilter.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNewFilter_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnNewReport() As BarButtonItem
            Get
                Return Me._btnNewReport
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnNewReport Is Nothing) Then
                    '  Me._btnNewReport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnNewReport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNewReport_ItemClick, IntPtr)))
                End If
                Me._btnNewReport = WithEventsValue
                If (Not Me._btnNewReport Is Nothing) Then
                    ' Me._btnNewReport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnNewReport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNewReport_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnNewView() As BarButtonItem
            Get
                Return Me._btnNewView
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnNewView Is Nothing) Then
                    ' Me._btnNewView.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._btnNewView = WithEventsValue
                If (Not Me._btnNewView Is Nothing) Then
                    ' Me._btnNewView.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnNext() As BarButtonItem
            Get
                Return Me._btnNext
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnNext Is Nothing) Then
                    '  Me._btnNext.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNext_ItemClick, IntPtr)))
                End If
                Me._btnNext = WithEventsValue
                If (Not Me._btnNext Is Nothing) Then
                    '  Me._btnNext.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNext_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnOK() As BarButtonItem
            Get
                Return Me._btnOK
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnOK = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnPrevious() As BarButtonItem
            Get
                Return Me._btnPrevious
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnPrevious Is Nothing) Then
                    '  Me._btnPrevious.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnPrevious_ItemClick, IntPtr)))
                End If
                Me._btnPrevious = WithEventsValue
                If (Not Me._btnPrevious Is Nothing) Then
                    '  Me._btnPrevious.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnPrevious_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnPrint() As BarButtonItem
            Get
                Return Me._btnPrint
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnPrint Is Nothing) Then
                    '  Me._btnPrint.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnPrint.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnPrint_ItemClick, IntPtr)))
                End If
                Me._btnPrint = WithEventsValue
                If (Not Me._btnPrint Is Nothing) Then
                    '  Me._btnPrint.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnPrint.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnPrint_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnQuickSearch() As BarButtonItem
            Get
                Return Me._btnQuickSearch
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnQuickSearch Is Nothing) Then
                    '   Me._btnQuickSearch.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '   Me._btnQuickSearch.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnQuickSearch_ItemClick, IntPtr)))
                End If
                Me._btnQuickSearch = WithEventsValue
                If (Not Me._btnQuickSearch Is Nothing) Then
                    '  Me._btnQuickSearch.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnQuickSearch.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnQuickSearch_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnReportDetail() As BarSubItem
            Get
                Return Me._btnReportDetail
            End Get
            Set(ByVal WithEventsValue As BarSubItem)
                Me._btnReportDetail = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnSave() As BarButtonItem
            Get
                Return Me._btnSave
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSave Is Nothing) Then
                    '   Me._btnSave.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '   Me._btnSave.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSave_ItemClick, IntPtr)))
                End If
                Me._btnSave = WithEventsValue
                If (Not Me._btnSave Is Nothing) Then
                    '   Me._btnSave.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '   Me._btnSave.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSave_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnSaveDefault() As BarButtonItem
            Get
                Return Me._btnSaveDefault
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSaveDefault Is Nothing) Then
                    '  Me._btnSaveDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnSaveDefault.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSaveDefault_ItemClick, IntPtr)))
                End If
                Me._btnSaveDefault = WithEventsValue
                If (Not Me._btnSaveDefault Is Nothing) Then
                    '  Me._btnSaveDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnSaveDefault.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSaveDefault_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnSaveView() As BarButtonItem
            Get
                Return Me._btnSaveView
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSaveView Is Nothing) Then
                    '   Me._btnSaveView.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._btnSaveView = WithEventsValue
                If (Not Me._btnSaveView Is Nothing) Then
                    '   Me._btnSaveView.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnSendDefaultUser() As BarButtonItem
            Get
                Return Me._btnSendDefaultUser
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSendDefaultUser Is Nothing) Then
                    '  Me._btnSendDefaultUser.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnSendDefaultUser.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSendDefaultUser_ItemClick, IntPtr)))
                End If
                Me._btnSendDefaultUser = WithEventsValue
                If (Not Me._btnSendDefaultUser Is Nothing) Then
                    '   Me._btnSendDefaultUser.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnSendDefaultUser.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSendDefaultUser_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnSendFilterUSer() As BarButtonItem
            Get
                Return Me._btnSendFilterUSer
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSendFilterUSer Is Nothing) Then
                    '  Me._btnSendFilterUSer.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnSendFilterUSer.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSendFilterUSer_ItemClick, IntPtr)))
                End If
                Me._btnSendFilterUSer = WithEventsValue
                If (Not Me._btnSendFilterUSer Is Nothing) Then
                    '  Me._btnSendFilterUSer.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    '  Me._btnSendFilterUSer.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSendFilterUSer_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnSendReportUser() As BarButtonItem
            Get
                Return Me._btnSendReportUser
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSendReportUser Is Nothing) Then
                    ' Me._btnSendReportUser.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnSendReportUser.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSendReportUser_ItemClick, IntPtr)))
                End If
                Me._btnSendReportUser = WithEventsValue
                If (Not Me._btnSendReportUser Is Nothing) Then
                    '  Me._btnSendReportUser.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                    ' Me._btnSendReportUser.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSendReportUser_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnSendViewUser() As BarButtonItem
            Get
                Return Me._btnSendViewUser
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSendViewUser Is Nothing) Then
                    '  Me._btnSendViewUser.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._btnSendViewUser = WithEventsValue
                If (Not Me._btnSendViewUser Is Nothing) Then
                    '  Me._btnSendViewUser.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnTranslation() As BarButtonItem
            Get
                Return Me._btnTranslation
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnTranslation Is Nothing) Then
                    ' Me._btnTranslation.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnTranslation_ItemClick, IntPtr)))
                End If
                Me._btnTranslation = WithEventsValue
                If (Not Me._btnTranslation Is Nothing) Then
                    ' Me._btnTranslation.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnTranslation_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnUndo() As BarButtonItem
            Get
                Return Me._btnUndo
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnUndo Is Nothing) Then
                    '  Me._btnUndo.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnUndo_ItemClick, IntPtr)))
                End If
                Me._btnUndo = WithEventsValue
                If (Not Me._btnUndo Is Nothing) Then
                    '  Me._btnUndo.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnUndo_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnUser1() As BarButtonItem
            Get
                Return Me._btnUser1
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnUser1 = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnUser2() As BarButtonItem
            Get
                Return Me._btnUser2
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnUser2 = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnUser3() As BarButtonItem
            Get
                Return Me._btnUser3
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnUser3 = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnUser4() As BarButtonItem
            Get
                Return Me._btnUser4
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnUser4 = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnUser5() As BarButtonItem
            Get
                Return Me._btnUser5
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnUser5 = WithEventsValue
            End Set
        End Property

        Public Overridable Property btnView() As BarButtonItem
            Get
                Return Me._btnView
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnView Is Nothing) Then
                    '  Me._btnView.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._btnView = WithEventsValue
                If (Not Me._btnView Is Nothing) Then
                    '  Me._btnView.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property btnViewDetail() As BarSubItem
            Get
                Return Me._btnViewDetail
            End Get
            Set(ByVal WithEventsValue As BarSubItem)
                Me._btnViewDetail = WithEventsValue
            End Set
        End Property

        Public Overridable Property cmbDefaultList() As BarEditItem
            Get
                Return Me._cmbDefaultList
            End Get
            Set(ByVal WithEventsValue As BarEditItem)
                Me._cmbDefaultList = WithEventsValue
            End Set
        End Property

        Public Overridable Property cmbDefaultListRepos() As RepositoryItemLookUpEdit
            Get
                Return Me._cmbDefaultListRepos
            End Get
            Set(ByVal WithEventsValue As RepositoryItemLookUpEdit)
                If (Not Me._cmbDefaultListRepos Is Nothing) Then
                    '  Me._cmbDefaultListRepos.remove_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbRepos_ButtonClick, IntPtr)))
                End If
                Me._cmbDefaultListRepos = WithEventsValue
                If (Not Me._cmbDefaultListRepos Is Nothing) Then
                    '  Me._cmbDefaultListRepos.add_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbRepos_ButtonClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property cmbFilterList() As BarEditItem
            Get
                Return Me._cmbFilterList
            End Get
            Set(ByVal WithEventsValue As BarEditItem)
                Me._cmbFilterList = WithEventsValue
            End Set
        End Property

        Public Overridable Property cmbFilterListRepos() As RepositoryItemLookUpEdit
            Get
                Return Me._cmbFilterListRepos
            End Get
            Set(ByVal WithEventsValue As RepositoryItemLookUpEdit)
                If (Not Me._cmbFilterListRepos Is Nothing) Then
                    '  Me._cmbFilterListRepos.remove_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbRepos_ButtonClick, IntPtr)))
                End If
                Me._cmbFilterListRepos = WithEventsValue
                If (Not Me._cmbFilterListRepos Is Nothing) Then
                    ' Me._cmbFilterListRepos.add_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbRepos_ButtonClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property cmbReportList() As BarEditItem
            Get
                Return Me._cmbReportList
            End Get
            Set(ByVal WithEventsValue As BarEditItem)
                Me._cmbReportList = WithEventsValue
            End Set
        End Property

        Public Overridable Property cmbReportListRepos() As RepositoryItemLookUpEdit
            Get
                Return Me._cmbReportListRepos
            End Get
            Set(ByVal WithEventsValue As RepositoryItemLookUpEdit)
                If (Not Me._cmbReportListRepos Is Nothing) Then
                    '  Me._cmbReportListRepos.remove_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbRepos_ButtonClick, IntPtr)))
                End If
                Me._cmbReportListRepos = WithEventsValue
                If (Not Me._cmbReportListRepos Is Nothing) Then
                    '  Me._cmbReportListRepos.add_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbRepos_ButtonClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property cmbViewList() As BarEditItem
            Get
                Return Me._cmbViewList
            End Get
            Set(ByVal WithEventsValue As BarEditItem)
                Me._cmbViewList = WithEventsValue
            End Set
        End Property

        Public Overridable Property cmbViewListRepos() As RepositoryItemLookUpEdit
            Get
                Return Me._cmbViewListRepos
            End Get
            Set(ByVal WithEventsValue As RepositoryItemLookUpEdit)
                If (Not Me._cmbViewListRepos Is Nothing) Then
                    '  Me._cmbViewListRepos.remove_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbRepos_ButtonClick, IntPtr)))
                End If
                Me._cmbViewListRepos = WithEventsValue
                If (Not Me._cmbViewListRepos Is Nothing) Then
                    '  Me._cmbViewListRepos.add_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbRepos_ButtonClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property DefaultSet_Bar() As Bar
            Get
                Return Me._DefaultSet_Bar
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._DefaultSet_Bar = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DockManager1() As DockManager
            Get
                Return Me._DockManager1
            End Get
            Set(ByVal WithEventsValue As DockManager)
                Me._DockManager1 = WithEventsValue
            End Set
        End Property

        Public Overridable Property Filter_Bar() As Bar
            Get
                Return Me._Filter_Bar
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._Filter_Bar = WithEventsValue
            End Set
        End Property

        Public Overridable Property Main_Bar() As Bar
            Get
                Return Me._Main_Bar
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._Main_Bar = WithEventsValue
            End Set
        End Property

        Public Overridable Property MainBtns_btnBestFit() As BarButtonItem
            Get
                Return Me._MainBtns_btnBestFit
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._MainBtns_btnBestFit Is Nothing) Then
                    '  Me._MainBtns_btnBestFit.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._MainBtns_btnBestFit = WithEventsValue
                If (Not Me._MainBtns_btnBestFit Is Nothing) Then
                    '   Me._MainBtns_btnBestFit.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property MainBtns_btnBigger() As BarButtonItem
            Get
                Return Me._MainBtns_btnBigger
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._MainBtns_btnBigger Is Nothing) Then
                    ' Me._MainBtns_btnBigger.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._MainBtns_btnBigger = WithEventsValue
                If (Not Me._MainBtns_btnBigger Is Nothing) Then
                    '  Me._MainBtns_btnBigger.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property MainBtns_btnExcel() As BarButtonItem
            Get
                Return Me._MainBtns_btnExcel
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._MainBtns_btnExcel Is Nothing) Then
                    '  Me._MainBtns_btnExcel.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._MainBtns_btnExcel = WithEventsValue
                If (Not Me._MainBtns_btnExcel Is Nothing) Then
                    '  Me._MainBtns_btnExcel.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property MainBtns_btnSmaller() As BarButtonItem
            Get
                Return Me._MainBtns_btnSmaller
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._MainBtns_btnSmaller Is Nothing) Then
                    '  Me._MainBtns_btnSmaller.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
                Me._MainBtns_btnSmaller = WithEventsValue
                If (Not Me._MainBtns_btnSmaller Is Nothing) Then
                    ' Me._MainBtns_btnSmaller.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.Btn_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property Misc_Bar() As Bar
            Get
                Return Me._Misc_Bar
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._Misc_Bar = WithEventsValue
            End Set
        End Property

        Public Overridable Property Misc_Bar2() As Bar
            Get
                Return Me._Misc_Bar2
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._Misc_Bar2 = WithEventsValue
            End Set
        End Property

        Public Overridable Property Nav_Bar() As Bar
            Get
                Return Me._Nav_Bar
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._Nav_Bar = WithEventsValue
            End Set
        End Property

        Public Overridable Property QuickSearch_Bar() As Bar
            Get
                Return Me._QuickSearch_Bar
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._QuickSearch_Bar = WithEventsValue
            End Set
        End Property

        Public Overridable Property Report_Bar() As Bar
            Get
                Return Me._Report_Bar
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._Report_Bar = WithEventsValue
            End Set
        End Property

        Public Property SessionInfo() As clsSessionInfo
            Get
                Return Me.mvarSessionInfo
            End Get
            Set(ByVal Value As clsSessionInfo)
                Me.mvarSessionInfo = Value
            End Set
        End Property

        Public Overridable Property txtQuickSearch() As BarEditItem
            Get
                Return Me._txtQuickSearch
            End Get
            Set(ByVal WithEventsValue As BarEditItem)
                Me._txtQuickSearch = WithEventsValue
            End Set
        End Property

        Public Overridable Property txtQuickSearchRepos() As RepositoryItemTextEdit
            Get
                Return Me._txtQuickSearchRepos
            End Get
            Set(ByVal WithEventsValue As RepositoryItemTextEdit)
                Me._txtQuickSearchRepos = WithEventsValue
            End Set
        End Property

        Public Overridable Property View_Bar() As Bar
            Get
                Return Me._View_Bar
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._View_Bar = WithEventsValue
            End Set
        End Property

    End Class
End Namespace
