Imports DevExpress.XtraEditors
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class frmDialogNewReport
        Inherits frmBKForm
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            Dim list As ArrayList = frmDialogNewReport.__ENCList
            SyncLock list
                frmDialogNewReport.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.InitializeComponent
        End Sub

        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            MyBase.New(CurrentSessionInfo)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            Dim list As ArrayList = frmDialogNewReport.__ENCList
            SyncLock list
                frmDialogNewReport.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.InitializeComponent
        End Sub

        Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.FolderBrowserDialog1.ShowDialog(Me) = DialogResult.OK) Then
                Me.txtReportPath.Text = Me.FolderBrowserDialog1.SelectedPath
            End If
        End Sub

        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.DialogResult = DialogResult.Cancel
            Me.Hide
        End Sub

        Private Sub btnOK1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.DialogResult = DialogResult.OK
            Me.Hide
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub frm_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
        End Sub

        Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.HelpProvider1.HelpNamespace = (Me.SessionInfo.ApplDir & "\Help\BizzKeys.chm")
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ResourceManager(GetType(frmDialogNewReport))
            Me.HelpProvider1 = New HelpProvider
            Me.txtName = New TextBox
            Me.txtDescription = New TextBox
            Me.txtReportPath = New TextBox
            Me.ToolTip1 = New ToolTip(Me.components)
            Me.StatusBar1 = New StatusBar
            Me.StatusBarPanel1 = New StatusBarPanel
            Me.StatusBarPanel2 = New StatusBarPanel
            Me.lblName = New Label
            Me.btnOK1 = New SimpleButton
            Me.btnCancel = New SimpleButton
            Me.lblDescription = New Label
            Me.lblReportPath = New Label
            Me.btnBrowse = New SimpleButton
            Me.FolderBrowserDialog1 = New FolderBrowserDialog
            Me.StatusBarPanel1.BeginInit
            Me.StatusBarPanel2.BeginInit
            Me.SuspendLayout
            Me.HelpProvider1.SetHelpString(Me.txtName, "Account Code")
            Dim point As New Point(&H60, &H10)
            Me.txtName.Location = point
            Me.txtName.Name = "txtName"
            Me.HelpProvider1.SetShowHelp(Me.txtName, True)
            Dim size As New Size(320, 20)
            Me.txtName.Size = size
            Me.txtName.TabIndex = 0
            Me.txtName.Text = ""
            Me.HelpProvider1.SetHelpString(Me.txtDescription, "Account Code")
            point = New Point(&H60, 40)
            Me.txtDescription.Location = point
            Me.txtDescription.Name = "txtDescription"
            Me.HelpProvider1.SetShowHelp(Me.txtDescription, True)
            size = New Size(320, 20)
            Me.txtDescription.Size = size
            Me.txtDescription.TabIndex = 1
            Me.txtDescription.Text = ""
            Me.HelpProvider1.SetHelpString(Me.txtReportPath, "Account Code")
            point = New Point(&H60, &H40)
            Me.txtReportPath.Location = point
            Me.txtReportPath.Name = "txtReportPath"
            Me.HelpProvider1.SetShowHelp(Me.txtReportPath, True)
            size = New Size(&H128, 20)
            Me.txtReportPath.Size = size
            Me.txtReportPath.TabIndex = 2
            Me.txtReportPath.Text = ""
            point = New Point(0, &H88)
            Me.StatusBar1.Location = point
            Me.StatusBar1.Name = "StatusBar1"
            Me.StatusBar1.Panels.AddRange(New StatusBarPanel() { Me.StatusBarPanel1, Me.StatusBarPanel2 })
            Me.StatusBar1.ShowPanels = True
            size = New Size(&H1A8, &H16)
            Me.StatusBar1.Size = size
            Me.StatusBar1.TabIndex = &H21
            Me.StatusBarPanel1.AutoSize = StatusBarPanelAutoSize.Spring
            Me.StatusBarPanel1.Width = &H17A
            Me.StatusBarPanel2.ToolTipText = "Filter Notification"
            Me.StatusBarPanel2.Width = 30
            point = New Point(8, &H10)
            Me.lblName.Location = point
            Me.lblName.Name = "lblName"
            size = New Size(80, &H17)
            Me.lblName.Size = size
            Me.lblName.TabIndex = 3
            Me.lblName.Text = "Name"
            point = New Point(&H108, &H60)
            Me.btnOK1.Location = point
            Me.btnOK1.Name = "btnOK1"
            Me.btnOK1.TabIndex = 4
            Me.btnOK1.set_Text("OK")
            Me.btnCancel.set_DialogResult(DialogResult.Cancel)
            point = New Point(&H158, &H60)
            Me.btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 5
            Me.btnCancel.set_Text("Cancel")
            point = New Point(8, 40)
            Me.lblDescription.Location = point
            Me.lblDescription.Name = "lblDescription"
            size = New Size(80, &H17)
            Me.lblDescription.Size = size
            Me.lblDescription.TabIndex = &H24
            Me.lblDescription.Text = "Description"
            point = New Point(8, &H40)
            Me.lblReportPath.Location = point
            Me.lblReportPath.Name = "lblReportPath"
            size = New Size(80, &H17)
            Me.lblReportPath.Size = size
            Me.lblReportPath.TabIndex = &H26
            Me.lblReportPath.Text = "Path"
            point = New Point(&H188, &H40)
            Me.btnBrowse.Location = point
            Me.btnBrowse.Name = "btnBrowse"
            size = New Size(&H18, &H17)
            Me.btnBrowse.Size = size
            Me.btnBrowse.TabIndex = 3
            Me.btnBrowse.set_Text("...")
            Me.AcceptButton = Me.btnOK1
            size = New Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Size(&H1A8, &H9E)
            Me.ClientSize = size
            Me.Controls.Add(Me.btnBrowse)
            Me.Controls.Add(Me.txtReportPath)
            Me.Controls.Add(Me.txtDescription)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.lblReportPath)
            Me.Controls.Add(Me.lblDescription)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnOK1)
            Me.Controls.Add(Me.StatusBar1)
            Me.Controls.Add(Me.lblName)
            Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
            Me.HelpButton = True
            Me.HelpProvider1.SetHelpKeyword(Me, "Filter")
            Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmDialogNewReport"
            Me.HelpProvider1.SetShowHelp(Me, True)
            Me.ShowInTaskbar = False
            Me.Text = "Please type a Name, Description and Path for the New Report"
            Me.StatusBarPanel1.EndInit
            Me.StatusBarPanel2.EndInit
            Me.ResumeLayout(False)
        End Sub


        ' Properties
        Friend Overridable Property btnBrowse As SimpleButton
            Get
                Return Me._btnBrowse
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                If (Not Me._btnBrowse Is Nothing) Then
                    RemoveHandler Me._btnBrowse.Click, New EventHandler(AddressOf Me.btnBrowse_Click)
                End If
                Me._btnBrowse = WithEventsValue
                If (Not Me._btnBrowse Is Nothing) Then
                    AddHandler Me._btnBrowse.Click, New EventHandler(AddressOf Me.btnBrowse_Click)
                End If
            End Set
        End Property

        Friend Overridable Property btnCancel As SimpleButton
            Get
                Return Me._btnCancel
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                If (Not Me._btnCancel Is Nothing) Then
                    RemoveHandler Me._btnCancel.Click, New EventHandler(AddressOf Me.btnCancel_Click)
                End If
                Me._btnCancel = WithEventsValue
                If (Not Me._btnCancel Is Nothing) Then
                    AddHandler Me._btnCancel.Click, New EventHandler(AddressOf Me.btnCancel_Click)
                End If
            End Set
        End Property

        Friend Overridable Property btnOK1 As SimpleButton
            Get
                Return Me._btnOK1
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                If (Not Me._btnOK1 Is Nothing) Then
                    RemoveHandler Me._btnOK1.Click, New EventHandler(AddressOf Me.btnOK1_Click)
                End If
                Me._btnOK1 = WithEventsValue
                If (Not Me._btnOK1 Is Nothing) Then
                    AddHandler Me._btnOK1.Click, New EventHandler(AddressOf Me.btnOK1_Click)
                End If
            End Set
        End Property

        Friend Overridable Property FolderBrowserDialog1 As FolderBrowserDialog
            Get
                Return Me._FolderBrowserDialog1
            End Get
            Set(ByVal WithEventsValue As FolderBrowserDialog)
                Me._FolderBrowserDialog1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property HelpProvider1 As HelpProvider
            Get
                Return Me._HelpProvider1
            End Get
            Set(ByVal WithEventsValue As HelpProvider)
                Me._HelpProvider1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblDescription As Label
            Get
                Return Me._lblDescription
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblDescription = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblName As Label
            Get
                Return Me._lblName
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblName = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblReportPath As Label
            Get
                Return Me._lblReportPath
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblReportPath = WithEventsValue
            End Set
        End Property

        Public Property ReportDesc As String
            Get
                Return Me.txtDescription.Text
            End Get
            Set(ByVal Value As String)
                Me.txtDescription.Text = Value
            End Set
        End Property

        Public Property ReportName As String
            Get
                Return Me.txtName.Text
            End Get
            Set(ByVal Value As String)
                Me.txtName.Text = Value
            End Set
        End Property

        Public Property ReportPath As String
            Get
                Return Me.txtReportPath.Text
            End Get
            Set(ByVal Value As String)
                Me.txtReportPath.Text = Value
            End Set
        End Property

        Friend Overridable Property StatusBar1 As StatusBar
            Get
                Return Me._StatusBar1
            End Get
            Set(ByVal WithEventsValue As StatusBar)
                Me._StatusBar1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property StatusBarPanel1 As StatusBarPanel
            Get
                Return Me._StatusBarPanel1
            End Get
            Set(ByVal WithEventsValue As StatusBarPanel)
                Me._StatusBarPanel1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property StatusBarPanel2 As StatusBarPanel
            Get
                Return Me._StatusBarPanel2
            End Get
            Set(ByVal WithEventsValue As StatusBarPanel)
                Me._StatusBarPanel2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ToolTip1 As ToolTip
            Get
                Return Me._ToolTip1
            End Get
            Set(ByVal WithEventsValue As ToolTip)
                Me._ToolTip1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtDescription As TextBox
            Get
                Return Me._txtDescription
            End Get
            Set(ByVal WithEventsValue As TextBox)
                Me._txtDescription = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtName As TextBox
            Get
                Return Me._txtName
            End Get
            Set(ByVal WithEventsValue As TextBox)
                Me._txtName = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtReportPath As TextBox
            Get
                Return Me._txtReportPath
            End Get
            Set(ByVal WithEventsValue As TextBox)
                Me._txtReportPath = WithEventsValue
            End Set
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        <AccessedThroughProperty("btnBrowse")> _
        Private _btnBrowse As SimpleButton
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As SimpleButton
        <AccessedThroughProperty("btnOK1")> _
        Private _btnOK1 As SimpleButton
        <AccessedThroughProperty("FolderBrowserDialog1")> _
        Private _FolderBrowserDialog1 As FolderBrowserDialog
        <AccessedThroughProperty("HelpProvider1")> _
        Private _HelpProvider1 As HelpProvider
        <AccessedThroughProperty("lblDescription")> _
        Private _lblDescription As Label
        <AccessedThroughProperty("lblName")> _
        Private _lblName As Label
        <AccessedThroughProperty("lblReportPath")> _
        Private _lblReportPath As Label
        <AccessedThroughProperty("StatusBar1")> _
        Private _StatusBar1 As StatusBar
        <AccessedThroughProperty("StatusBarPanel1")> _
        Private _StatusBarPanel1 As StatusBarPanel
        <AccessedThroughProperty("StatusBarPanel2")> _
        Private _StatusBarPanel2 As StatusBarPanel
        <AccessedThroughProperty("ToolTip1")> _
        Private _ToolTip1 As ToolTip
        <AccessedThroughProperty("txtDescription")> _
        Private _txtDescription As TextBox
        <AccessedThroughProperty("txtName")> _
        Private _txtName As TextBox
        <AccessedThroughProperty("txtReportPath")> _
        Private _txtReportPath As TextBox
        Private components As IContainer
    End Class
End Namespace

