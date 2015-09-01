Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class ucChart
        Inherits XtraUserControl
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.ucChart_Load)
            Dim list As ArrayList = ucChart.__ENCList
            SyncLock list
                ucChart.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.InitializeComponent
        End Sub

        Private Sub btnArea_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ChartControl1.get_Series.get_Item(0).ChangeView(9)
        End Sub

        Private Sub btnBar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ChartControl1.get_Series.get_Item(0).ChangeView(0)
        End Sub

        Private Sub btnPie_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ChartControl1.get_Series.get_Item(0).ChangeView(3)
        End Sub

        Private Sub chkShowLabel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.ChartControl1.get_Series.get_Item(0).get_Label.set_Visible(Me.chkShowLabel.get_Checked)
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Public Sub Initialize(ByVal CurrentSessionInfo As clsSessionInfo)
            Me.mvarSessionInfo = CurrentSessionInfo
            Me.mvarBKGlobal = New clsGlobal(CurrentSessionInfo)
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ResourceManager(GetType(ucChart))
            Dim diagram As New XYDiagram
            Dim series As New Series
            Dim series2 As New Series
            Me.DockManager1 = New DockManager
            Me.OpenFileDialog1 = New OpenFileDialog
            Me.mvarDS = New dsAnalyze
            Me.BarManager1 = New BarManager(Me.components)
            Me.Bar1 = New Bar
            Me.btnExport = New BarButtonItem
            Me.btnPrint = New BarButtonItem
            Me.btnNew = New BarButtonItem
            Me.btnSave = New BarButtonItem
            Me.btnEdit = New BarButtonItem
            Me.btnLoad = New BarButtonItem
            Me.btnDelete = New BarButtonItem
            Me.btnBiggerCaps = New BarButtonItem
            Me.btnSmallerCaps = New BarButtonItem
            Me.btnSendToUSer = New BarButtonItem
            Me.btnMakeCommon = New BarButtonItem
            Me.btnStyleCondition = New BarButtonItem
            Me.barDockControlTop = New BarDockControl
            Me.barDockControlBottom = New BarDockControl
            Me.barDockControlLeft = New BarDockControl
            Me.barDockControlRight = New BarDockControl
            Me.SaveFileDialog1 = New SaveFileDialog
            Me.PanelControl1 = New PanelControl
            Me.PanelControl2 = New PanelControl
            Me.cmbYFields = New ComboBoxEdit
            Me.PanelControl3 = New PanelControl
            Me.ChartControl1 = New ChartControl
            Me.PanelControl4 = New PanelControl
            Me.btnArea = New SimpleButton
            Me.btnPie = New SimpleButton
            Me.btnBar = New SimpleButton
            Me.btnLines = New SimpleButton
            Me.SplitterControl1 = New SplitterControl
            Me.SplitterControl2 = New SplitterControl
            Me.chkShowLabel = New CheckEdit
            Me.DockManager1.BeginInit
            Me.mvarDS.BeginInit
            Me.BarManager1.BeginInit
            Me.PanelControl1.BeginInit
            Me.PanelControl2.BeginInit
            Me.PanelControl2.SuspendLayout
            Me.cmbYFields.get_Properties.BeginInit
            Me.PanelControl3.BeginInit
            Me.PanelControl3.SuspendLayout
            Me.ChartControl1.BeginInit
            diagram.BeginInit
            series.BeginInit
            series2.BeginInit
            Me.PanelControl4.BeginInit
            Me.PanelControl4.SuspendLayout
            Me.chkShowLabel.get_Properties.BeginInit
            Me.SuspendLayout
            Me.DockManager1.set_Form(Me)
            Me.DockManager1.get_TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar" })
            Me.mvarDS.DataSetName = "dsAnalyze"
            Me.mvarDS.Locale = New CultureInfo("en-US")
            Me.BarManager1.get_Bars.AddRange(New Bar() { Me.Bar1 })
            Me.BarManager1.get_DockControls.Add(Me.barDockControlTop)
            Me.BarManager1.get_DockControls.Add(Me.barDockControlBottom)
            Me.BarManager1.get_DockControls.Add(Me.barDockControlLeft)
            Me.BarManager1.get_DockControls.Add(Me.barDockControlRight)
            Me.BarManager1.set_DockManager(Me.DockManager1)
            Me.BarManager1.set_Form(Me)
            Me.BarManager1.get_Items.AddRange(New BarItem() { Me.btnExport, Me.btnPrint, Me.btnSave, Me.btnEdit, Me.btnLoad, Me.btnDelete, Me.btnBiggerCaps, Me.btnSmallerCaps, Me.btnSendToUSer, Me.btnMakeCommon, Me.btnNew, Me.btnStyleCondition })
            Me.BarManager1.set_MaxItemId(14)
            Me.Bar1.set_BarName("AnalizeBar")
            Me.Bar1.set_DockCol(0)
            Me.Bar1.set_DockRow(0)
            Me.Bar1.set_DockStyle(2)
            Dim point As New Point(&H37, &H7F)
            Me.Bar1.set_FloatLocation(point)
            Dim size As New Size(100, 100)
            Me.Bar1.set_FloatSize(size)
            Me.Bar1.get_LinksPersistInfo.AddRange(New LinkPersistInfo() { New LinkPersistInfo(Me.btnExport), New LinkPersistInfo(Me.btnPrint), New LinkPersistInfo(Me.btnNew), New LinkPersistInfo(Me.btnSave), New LinkPersistInfo(Me.btnEdit), New LinkPersistInfo(Me.btnLoad), New LinkPersistInfo(Me.btnDelete), New LinkPersistInfo(Me.btnBiggerCaps), New LinkPersistInfo(Me.btnSmallerCaps), New LinkPersistInfo(Me.btnSendToUSer), New LinkPersistInfo(Me.btnMakeCommon), New LinkPersistInfo(0, False, Me.btnStyleCondition, False) })
            Me.Bar1.set_Offset(1)
            Me.Bar1.set_Text("Analize")
            Me.btnExport.set_Caption("Export")
            Me.btnExport.set_Glyph(DirectCast(manager.GetObject("btnExport.Glyph"), Image))
            Me.btnExport.set_Hint("Export")
            Me.btnExport.set_Id(0)
            Me.btnExport.set_Name("btnExport")
            Me.btnPrint.set_Caption("Print")
            Me.btnPrint.set_Glyph(DirectCast(manager.GetObject("btnPrint.Glyph"), Image))
            Me.btnPrint.set_Hint("Print")
            Me.btnPrint.set_Id(1)
            Me.btnPrint.set_Name("btnPrint")
            Me.btnNew.set_Caption("New")
            Me.btnNew.set_Glyph(DirectCast(manager.GetObject("btnNew.Glyph"), Image))
            Me.btnNew.set_Hint("Save as new Analyze")
            Me.btnNew.set_Id(11)
            Me.btnNew.set_Name("btnNew")
            Me.btnSave.set_Caption("Save")
            Me.btnSave.set_Glyph(DirectCast(manager.GetObject("btnSave.Glyph"), Image))
            Me.btnSave.set_Hint("Save")
            Me.btnSave.set_Id(2)
            Me.btnSave.set_Name("btnSave")
            Me.btnEdit.set_Caption("Rename")
            Me.btnEdit.set_Glyph(DirectCast(manager.GetObject("btnEdit.Glyph"), Image))
            Me.btnEdit.set_Hint("Edit Analyze Name / description")
            Me.btnEdit.set_Id(10)
            Me.btnEdit.set_Name("btnEdit")
            Me.btnLoad.set_Caption("Load")
            Me.btnLoad.set_Glyph(DirectCast(manager.GetObject("btnLoad.Glyph"), Image))
            Me.btnLoad.set_Hint("Load")
            Me.btnLoad.set_Id(4)
            Me.btnLoad.set_Name("btnLoad")
            Me.btnDelete.set_Caption("Delete")
            Me.btnDelete.set_Glyph(DirectCast(manager.GetObject("btnDelete.Glyph"), Image))
            Me.btnDelete.set_Hint("Delete")
            Me.btnDelete.set_Id(5)
            Me.btnDelete.set_Name("btnDelete")
            Me.btnBiggerCaps.set_Caption("Bigger")
            Me.btnBiggerCaps.set_Glyph(DirectCast(manager.GetObject("btnBiggerCaps.Glyph"), Image))
            Me.btnBiggerCaps.set_Hint("Bigger Caps")
            Me.btnBiggerCaps.set_Id(7)
            Me.btnBiggerCaps.set_Name("btnBiggerCaps")
            Me.btnSmallerCaps.set_Caption("Smaller")
            Me.btnSmallerCaps.set_Description("Smaller Caps")
            Me.btnSmallerCaps.set_Glyph(DirectCast(manager.GetObject("btnSmallerCaps.Glyph"), Image))
            Me.btnSmallerCaps.set_Hint("Smaller Caps")
            Me.btnSmallerCaps.set_Id(6)
            Me.btnSmallerCaps.set_Name("btnSmallerCaps")
            Me.btnSendToUSer.set_Caption("ToUSer")
            Me.btnSendToUSer.set_Glyph(DirectCast(manager.GetObject("btnSendToUSer.Glyph"), Image))
            Me.btnSendToUSer.set_Hint("Send this analyze to another user")
            Me.btnSendToUSer.set_Id(8)
            Me.btnSendToUSer.set_Name("btnSendToUSer")
            Me.btnMakeCommon.set_Caption("ToCommon")
            Me.btnMakeCommon.set_Glyph(DirectCast(manager.GetObject("btnMakeCommon.Glyph"), Image))
            Me.btnMakeCommon.set_Hint("Make this analyze common to all users")
            Me.btnMakeCommon.set_Id(9)
            Me.btnMakeCommon.set_Name("btnMakeCommon")
            Me.btnStyleCondition.set_Caption("StyleCondition")
            Me.btnStyleCondition.set_Glyph(DirectCast(manager.GetObject("btnStyleCondition.Glyph"), Image))
            Me.btnStyleCondition.set_Id(13)
            Me.btnStyleCondition.set_Name("btnStyleCondition")
            Me.PanelControl1.Dock = DockStyle.Bottom
            point = New Point(0, 480)
            Me.PanelControl1.Location = point
            Me.PanelControl1.Name = "PanelControl1"
            size = New Size(&H390, &H38)
            Me.PanelControl1.Size = size
            Me.PanelControl1.TabIndex = 4
            Me.PanelControl1.set_Text("PanelControl1")
            Me.PanelControl2.Controls.Add(Me.cmbYFields)
            Me.PanelControl2.Dock = DockStyle.Left
            point = New Point(0, &H2A)
            Me.PanelControl2.Location = point
            Me.PanelControl2.Name = "PanelControl2"
            size = New Size(&H88, &H1B6)
            Me.PanelControl2.Size = size
            Me.PanelControl2.TabIndex = 5
            Me.PanelControl2.set_Text("PanelControl2")
            point = New Point(&H18, &H20)
            Me.cmbYFields.Location = point
            Me.cmbYFields.Name = "cmbYFields"
            Me.cmbYFields.get_Properties.get_Buttons.AddRange(New EditorButton() { New EditorButton(-5) })
            Me.cmbYFields.get_Properties.set_ReadOnly(True)
            Me.cmbYFields.TabIndex = 1
            Me.PanelControl3.Controls.Add(Me.ChartControl1)
            Me.PanelControl3.Dock = DockStyle.Fill
            point = New Point(&H88, &H2A)
            Me.PanelControl3.Location = point
            Me.PanelControl3.Name = "PanelControl3"
            size = New Size(&H288, &H1B6)
            Me.PanelControl3.Size = size
            Me.PanelControl3.TabIndex = 6
            Me.PanelControl3.set_Text("PanelControl3")
            Me.ChartControl1.set_Diagram(diagram)
            Me.ChartControl1.Dock = DockStyle.Fill
            point = New Point(2, 2)
            Me.ChartControl1.Location = point
            Me.ChartControl1.Name = "ChartControl1"
            series.set_PointOptionsTypeName("PointOptions")
            series.set_Name("Series 1")
            series2.set_PointOptionsTypeName("PointOptions")
            series2.set_Name("Series 2")
            Me.ChartControl1.get_Series.AddRange(New Series() { series, series2 })
            Me.ChartControl1.get_SeriesTemplate.set_PointOptionsTypeName("PointOptions")
            size = New Size(&H284, &H1B2)
            Me.ChartControl1.Size = size
            Me.ChartControl1.TabIndex = 0
            Me.PanelControl4.Controls.Add(Me.chkShowLabel)
            Me.PanelControl4.Controls.Add(Me.btnArea)
            Me.PanelControl4.Controls.Add(Me.btnPie)
            Me.PanelControl4.Controls.Add(Me.btnBar)
            Me.PanelControl4.Controls.Add(Me.btnLines)
            Me.PanelControl4.Dock = DockStyle.Right
            point = New Point(&H310, &H2A)
            Me.PanelControl4.Location = point
            Me.PanelControl4.Name = "PanelControl4"
            size = New Size(&H80, &H1B6)
            Me.PanelControl4.Size = size
            Me.PanelControl4.TabIndex = 7
            Me.PanelControl4.set_Text("PanelControl4")
            point = New Point(&H48, &H48)
            Me.btnArea.Location = point
            Me.btnArea.Name = "btnArea"
            size = New Size(&H30, &H30)
            Me.btnArea.Size = size
            Me.btnArea.TabIndex = 7
            Me.btnArea.set_Text("Area")
            point = New Point(&H10, &H48)
            Me.btnPie.Location = point
            Me.btnPie.Name = "btnPie"
            size = New Size(&H30, &H30)
            Me.btnPie.Size = size
            Me.btnPie.TabIndex = 6
            Me.btnPie.set_Text("Pie")
            point = New Point(&H48, &H10)
            Me.btnBar.Location = point
            Me.btnBar.Name = "btnBar"
            size = New Size(&H30, &H30)
            Me.btnBar.Size = size
            Me.btnBar.TabIndex = 5
            Me.btnBar.set_Text("Bars")
            point = New Point(&H10, &H10)
            Me.btnLines.Location = point
            Me.btnLines.Name = "btnLines"
            size = New Size(&H30, &H30)
            Me.btnLines.Size = size
            Me.btnLines.TabIndex = 4
            Me.btnLines.set_Text("Lines")
            point = New Point(&H88, &H2A)
            Me.SplitterControl1.Location = point
            Me.SplitterControl1.Name = "SplitterControl1"
            size = New Size(6, &H1B6)
            Me.SplitterControl1.Size = size
            Me.SplitterControl1.TabIndex = 8
            Me.SplitterControl1.TabStop = False
            Me.SplitterControl2.Dock = DockStyle.Right
            point = New Point(&H30A, &H2A)
            Me.SplitterControl2.Location = point
            Me.SplitterControl2.Name = "SplitterControl2"
            size = New Size(6, &H1B6)
            Me.SplitterControl2.Size = size
            Me.SplitterControl2.TabIndex = 9
            Me.SplitterControl2.TabStop = False
            point = New Point(&H18, &H128)
            Me.chkShowLabel.Location = point
            Me.chkShowLabel.Name = "chkShowLabel"
            Me.chkShowLabel.get_Properties.set_Caption("Show Labels")
            size = New Size(80, &H13)
            Me.chkShowLabel.Size = size
            Me.chkShowLabel.TabIndex = 8
            Me.Controls.Add(Me.SplitterControl2)
            Me.Controls.Add(Me.SplitterControl1)
            Me.Controls.Add(Me.PanelControl3)
            Me.Controls.Add(Me.PanelControl4)
            Me.Controls.Add(Me.PanelControl2)
            Me.Controls.Add(Me.PanelControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "ucChart"
            size = New Size(&H390, &H218)
            Me.Size = size
            Me.DockManager1.EndInit
            Me.mvarDS.EndInit
            Me.BarManager1.EndInit
            Me.PanelControl1.EndInit
            Me.PanelControl2.EndInit
            Me.PanelControl2.ResumeLayout(False)
            Me.cmbYFields.get_Properties.EndInit
            Me.PanelControl3.EndInit
            Me.PanelControl3.ResumeLayout(False)
            diagram.EndInit
            series.EndInit
            series2.EndInit
            Me.ChartControl1.EndInit
            Me.PanelControl4.EndInit
            Me.PanelControl4.ResumeLayout(False)
            Me.chkShowLabel.get_Properties.EndInit
            Me.ResumeLayout(False)
        End Sub

        Public Sub LoadFieldList()
            Dim enumerator As IEnumerator
            Me.cmbYFields.get_Properties.get_Items.Clear
            Try 
                enumerator = Me.DS.Tables.Item(Me.TableName).Columns.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As DataColumn = DirectCast(enumerator.Current, DataColumn)
                    Me.cmbYFields.get_Properties.get_Items.Add(current.ColumnName)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator,IDisposable).Dispose
                End If
            End Try
        End Sub

        Public Sub SetDataSource(ByVal vDS As DataSet, ByVal vTableName As String)
            Me.TableName = vTableName
            Me.DS = vDS
            Me.ChartControl1.get_Series.Clear
            Me.ChartControl1.set_DataSource(Me.DS.Tables.Item(Me.TableName))
            Me.ChartControl1.get_Series.Add("Serie1", 6)
            Me.LoadFieldList
        End Sub

        Public Sub SetXYAxis(ByVal XFieldName As String, ByVal YFieldName As String)
            Dim diagram As XYDiagram = Me.ChartControl1.get_Diagram
            Me.ChartControl1.get_Series.get_Item(0).set_ArgumentDataMember(XFieldName)
            Me.ChartControl1.get_Series.get_Item(0).get_ValueDataMembers.Clear
            Me.ChartControl1.get_Series.get_Item(0).get_ValueDataMembers.AddRange(New String() { YFieldName })
        End Sub

        Private Sub ucChart_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.MenuID = Conversions.ToInteger(Me.ParentForm.Tag)
            If Information.IsNothing(Me.SessionInfo) Then
            End If
        End Sub


        ' Properties
        Public Overridable Property Bar1 As Bar
            Get
                Return Me._Bar1
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._Bar1 = WithEventsValue
            End Set
        End Property

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

        Public Property BKGlobal As clsGlobal
            Get
                Return Me.mvarBKGlobal
            End Get
            Set(ByVal Value As clsGlobal)
                Me.mvarBKGlobal = Value
            End Set
        End Property

        Friend Overridable Property btnArea As SimpleButton
            Get
                Return Me._btnArea
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                If (Not Me._btnArea Is Nothing) Then
                    RemoveHandler Me._btnArea.Click, New EventHandler(AddressOf Me.btnArea_Click)
                End If
                Me._btnArea = WithEventsValue
                If (Not Me._btnArea Is Nothing) Then
                    AddHandler Me._btnArea.Click, New EventHandler(AddressOf Me.btnArea_Click)
                End If
            End Set
        End Property

        Friend Overridable Property btnBar As SimpleButton
            Get
                Return Me._btnBar
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                If (Not Me._btnBar Is Nothing) Then
                    RemoveHandler Me._btnBar.Click, New EventHandler(AddressOf Me.btnBar_Click)
                End If
                Me._btnBar = WithEventsValue
                If (Not Me._btnBar Is Nothing) Then
                    AddHandler Me._btnBar.Click, New EventHandler(AddressOf Me.btnBar_Click)
                End If
            End Set
        End Property

        Friend Overridable Property btnBiggerCaps As BarButtonItem
            Get
                Return Me._btnBiggerCaps
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnBiggerCaps = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnDelete As BarButtonItem
            Get
                Return Me._btnDelete
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnDelete = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnEdit As BarButtonItem
            Get
                Return Me._btnEdit
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnEdit = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnExport As BarButtonItem
            Get
                Return Me._btnExport
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnExport = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnLines As SimpleButton
            Get
                Return Me._btnLines
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                Me._btnLines = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnLoad As BarButtonItem
            Get
                Return Me._btnLoad
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnLoad = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnMakeCommon As BarButtonItem
            Get
                Return Me._btnMakeCommon
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnMakeCommon = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnNew As BarButtonItem
            Get
                Return Me._btnNew
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnNew = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnPie As SimpleButton
            Get
                Return Me._btnPie
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                If (Not Me._btnPie Is Nothing) Then
                    RemoveHandler Me._btnPie.Click, New EventHandler(AddressOf Me.btnPie_Click)
                End If
                Me._btnPie = WithEventsValue
                If (Not Me._btnPie Is Nothing) Then
                    AddHandler Me._btnPie.Click, New EventHandler(AddressOf Me.btnPie_Click)
                End If
            End Set
        End Property

        Friend Overridable Property btnPrint As BarButtonItem
            Get
                Return Me._btnPrint
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnPrint = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnSave As BarButtonItem
            Get
                Return Me._btnSave
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnSave = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnSendToUSer As BarButtonItem
            Get
                Return Me._btnSendToUSer
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnSendToUSer = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnSmallerCaps As BarButtonItem
            Get
                Return Me._btnSmallerCaps
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnSmallerCaps = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnStyleCondition As BarButtonItem
            Get
                Return Me._btnStyleCondition
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._btnStyleCondition = WithEventsValue
            End Set
        End Property

        Public Overridable Property ChartControl1 As ChartControl
            Get
                Return Me._ChartControl1
            End Get
            Set(ByVal WithEventsValue As ChartControl)
                Me._ChartControl1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property chkShowLabel As CheckEdit
            Get
                Return Me._chkShowLabel
            End Get
            Set(ByVal WithEventsValue As CheckEdit)
                If (Not Me._chkShowLabel Is Nothing) Then
                    Me._chkShowLabel.remove_CheckedChanged(New EventHandler(AddressOf Me.chkShowLabel_CheckedChanged))
                End If
                Me._chkShowLabel = WithEventsValue
                If (Not Me._chkShowLabel Is Nothing) Then
                    Me._chkShowLabel.add_CheckedChanged(New EventHandler(AddressOf Me.chkShowLabel_CheckedChanged))
                End If
            End Set
        End Property

        Friend Overridable Property cmbYFields As ComboBoxEdit
            Get
                Return Me._cmbYFields
            End Get
            Set(ByVal WithEventsValue As ComboBoxEdit)
                Me._cmbYFields = WithEventsValue
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

        Friend Overridable Property mvarDS As dsAnalyze
            Get
                Return Me._mvarDS
            End Get
            Set(ByVal WithEventsValue As dsAnalyze)
                Me._mvarDS = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OpenFileDialog1 As OpenFileDialog
            Get
                Return Me._OpenFileDialog1
            End Get
            Set(ByVal WithEventsValue As OpenFileDialog)
                Me._OpenFileDialog1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PanelControl1 As PanelControl
            Get
                Return Me._PanelControl1
            End Get
            Set(ByVal WithEventsValue As PanelControl)
                Me._PanelControl1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PanelControl2 As PanelControl
            Get
                Return Me._PanelControl2
            End Get
            Set(ByVal WithEventsValue As PanelControl)
                Me._PanelControl2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PanelControl3 As PanelControl
            Get
                Return Me._PanelControl3
            End Get
            Set(ByVal WithEventsValue As PanelControl)
                Me._PanelControl3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PanelControl4 As PanelControl
            Get
                Return Me._PanelControl4
            End Get
            Set(ByVal WithEventsValue As PanelControl)
                Me._PanelControl4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SaveFileDialog1 As SaveFileDialog
            Get
                Return Me._SaveFileDialog1
            End Get
            Set(ByVal WithEventsValue As SaveFileDialog)
                Me._SaveFileDialog1 = WithEventsValue
            End Set
        End Property

        Public Property SessionInfo As clsSessionInfo
            Get
                Return Me.mvarSessionInfo
            End Get
            Set(ByVal Value As clsSessionInfo)
                Me.mvarSessionInfo = Value
                Me.mvarBKGlobal = New clsGlobal(Me.mvarSessionInfo)
            End Set
        End Property

        Friend Overridable Property SplitterControl1 As SplitterControl
            Get
                Return Me._SplitterControl1
            End Get
            Set(ByVal WithEventsValue As SplitterControl)
                Me._SplitterControl1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SplitterControl2 As SplitterControl
            Get
                Return Me._SplitterControl2
            End Get
            Set(ByVal WithEventsValue As SplitterControl)
                Me._SplitterControl2 = WithEventsValue
            End Set
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        <AccessedThroughProperty("Bar1")> _
        Private _Bar1 As Bar
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
        <AccessedThroughProperty("btnArea")> _
        Private _btnArea As SimpleButton
        <AccessedThroughProperty("btnBar")> _
        Private _btnBar As SimpleButton
        <AccessedThroughProperty("btnBiggerCaps")> _
        Private _btnBiggerCaps As BarButtonItem
        <AccessedThroughProperty("btnDelete")> _
        Private _btnDelete As BarButtonItem
        <AccessedThroughProperty("btnEdit")> _
        Private _btnEdit As BarButtonItem
        <AccessedThroughProperty("btnExport")> _
        Private _btnExport As BarButtonItem
        <AccessedThroughProperty("btnLines")> _
        Private _btnLines As SimpleButton
        <AccessedThroughProperty("btnLoad")> _
        Private _btnLoad As BarButtonItem
        <AccessedThroughProperty("btnMakeCommon")> _
        Private _btnMakeCommon As BarButtonItem
        <AccessedThroughProperty("btnNew")> _
        Private _btnNew As BarButtonItem
        <AccessedThroughProperty("btnPie")> _
        Private _btnPie As SimpleButton
        <AccessedThroughProperty("btnPrint")> _
        Private _btnPrint As BarButtonItem
        <AccessedThroughProperty("btnSave")> _
        Private _btnSave As BarButtonItem
        <AccessedThroughProperty("btnSendToUSer")> _
        Private _btnSendToUSer As BarButtonItem
        <AccessedThroughProperty("btnSmallerCaps")> _
        Private _btnSmallerCaps As BarButtonItem
        <AccessedThroughProperty("btnStyleCondition")> _
        Private _btnStyleCondition As BarButtonItem
        <AccessedThroughProperty("ChartControl1")> _
        Private _ChartControl1 As ChartControl
        <AccessedThroughProperty("chkShowLabel")> _
        Private _chkShowLabel As CheckEdit
        <AccessedThroughProperty("cmbYFields")> _
        Private _cmbYFields As ComboBoxEdit
        <AccessedThroughProperty("DockManager1")> _
        Private _DockManager1 As DockManager
        <AccessedThroughProperty("mvarDS")> _
        Private _mvarDS As dsAnalyze
        <AccessedThroughProperty("OpenFileDialog1")> _
        Private _OpenFileDialog1 As OpenFileDialog
        <AccessedThroughProperty("PanelControl1")> _
        Private _PanelControl1 As PanelControl
        <AccessedThroughProperty("PanelControl2")> _
        Private _PanelControl2 As PanelControl
        <AccessedThroughProperty("PanelControl3")> _
        Private _PanelControl3 As PanelControl
        <AccessedThroughProperty("PanelControl4")> _
        Private _PanelControl4 As PanelControl
        <AccessedThroughProperty("SaveFileDialog1")> _
        Private _SaveFileDialog1 As SaveFileDialog
        <AccessedThroughProperty("SplitterControl1")> _
        Private _SplitterControl1 As SplitterControl
        <AccessedThroughProperty("SplitterControl2")> _
        Private _SplitterControl2 As SplitterControl
        Private components As IContainer
        Public DS As DataSet
        Public MenuID As Integer
        Private mvarBKGlobal As clsGlobal
        Private mvarSessionInfo As clsSessionInfo
        Public TableName As String
    End Class
End Namespace

