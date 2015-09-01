Imports DevExpress.XtraEditors
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class frmDialogSelectXMLFile
        Inherits frmBKForm
        ' Methods
        Public Sub New()
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            Dim list As ArrayList = frmDialogSelectXMLFile.__ENCList
            SyncLock list
                frmDialogSelectXMLFile.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.mvarBoolSave = True
            Me.InitializeComponent
        End Sub

        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            MyBase.New(CurrentSessionInfo)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            Dim list As ArrayList = frmDialogSelectXMLFile.__ENCList
            SyncLock list
                frmDialogSelectXMLFile.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.mvarBoolSave = True
            Me.InitializeComponent
        End Sub

        Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.mvarBoolSave Then
                Me.SaveFileDialog1.ShowDialog
                Me.txtFileName.Text = Me.SaveFileDialog1.FileName
            Else
                Me.OpenFileDialog1.ShowDialog
                Me.txtFileName.Text = Me.OpenFileDialog1.FileName
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
            Try 
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                MessageBox.Show(exception.Message)
                ProjectData.ClearProjectError
            End Try
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ResourceManager(GetType(frmDialogSelectXMLFile))
            Me.HelpProvider1 = New HelpProvider
            Me.txtFileName = New TextBox
            Me.ToolTip1 = New ToolTip(Me.components)
            Me.StatusBar1 = New StatusBar
            Me.StatusBarPanel1 = New StatusBarPanel
            Me.StatusBarPanel2 = New StatusBarPanel
            Me.lblFileName = New Label
            Me.btnOK1 = New SimpleButton
            Me.btnCancel = New SimpleButton
            Me.btnBrowse = New SimpleButton
            Me.SaveFileDialog1 = New SaveFileDialog
            Me.OpenFileDialog1 = New OpenFileDialog
            Me.cmbViewListRepos.BeginInit
            Me.txtQuickSearchRepos.BeginInit
            Me.cmbReportListRepos.BeginInit
            Me.cmbFilterListRepos.BeginInit
            Me.BarManager1.BeginInit
            Me.cmbDefaultListRepos.BeginInit
            Me.StatusBarPanel1.BeginInit
            Me.StatusBarPanel2.BeginInit
            Me.SuspendLayout
            Me.View_Bar.set_DockCol(2)
            Me.QuickSearch_Bar.set_DockCol(8)
            Me.Main_Bar.set_DockCol(4)
            Me.Filter_Bar.set_DockCol(7)
            Me.DefaultSet_Bar.set_DockCol(6)
            Me.Misc_Bar2.set_DockCol(3)
            Me.Misc_Bar.set_DockCol(5)
            Me.HelpProvider1.SetHelpString(Me.txtFileName, "Account Code")
            Dim point As New Point(&H60, &H10)
            Me.txtFileName.Location = point
            Me.txtFileName.Name = "txtFileName"
            Me.HelpProvider1.SetShowHelp(Me.txtFileName, True)
            Dim size As New Size(&H128, 20)
            Me.txtFileName.Size = size
            Me.txtFileName.TabIndex = 8
            Me.txtFileName.Text = ""
            point = New Point(0, &H58)
            Me.StatusBar1.Location = point
            Me.StatusBar1.Name = "StatusBar1"
            Me.StatusBar1.Panels.AddRange(New StatusBarPanel() { Me.StatusBarPanel1, Me.StatusBarPanel2 })
            Me.StatusBar1.ShowPanels = True
            size = New Size(520, &H16)
            Me.StatusBar1.Size = size
            Me.StatusBar1.TabIndex = &H21
            Me.StatusBarPanel1.AutoSize = StatusBarPanelAutoSize.Spring
            Me.StatusBarPanel1.Width = &H1DA
            Me.StatusBarPanel2.ToolTipText = "Filter Notification"
            Me.StatusBarPanel2.Width = 30
            point = New Point(8, &H10)
            Me.lblFileName.Location = point
            Me.lblFileName.Name = "lblFileName"
            size = New Size(80, &H17)
            Me.lblFileName.Size = size
            Me.lblFileName.TabIndex = 3
            Me.lblFileName.Text = "Excel File :"
            point = New Point(&H160, &H30)
            Me.btnOK1.Location = point
            Me.btnOK1.Name = "btnOK1"
            Me.btnOK1.TabIndex = &H22
            Me.btnOK1.set_Text("OK")
            Me.btnCancel.set_DialogResult(DialogResult.Cancel)
            point = New Point(&H1B0, &H30)
            Me.btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = &H23
            Me.btnCancel.set_Text("Cancel")
            point = New Point(&H1B0, &H10)
            Me.btnBrowse.Location = point
            Me.btnBrowse.Name = "btnBrowse"
            Me.btnBrowse.TabIndex = &H24
            Me.btnBrowse.set_Text("Browse ...")
            Me.SaveFileDialog1.Filter = "XML Files|*.xml|All files|*.*"
            Me.OpenFileDialog1.Filter = "XML Files|*.xml|All files|*.*"
            Me.AcceptButton = Me.btnOK1
            size = New Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Size(520, 110)
            Me.ClientSize = size
            Me.Controls.Add(Me.txtFileName)
            Me.Controls.Add(Me.btnBrowse)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnOK1)
            Me.Controls.Add(Me.StatusBar1)
            Me.Controls.Add(Me.lblFileName)
            Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
            Me.HelpButton = True
            Me.HelpProvider1.SetHelpKeyword(Me, "Filter")
            Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmDialogSelectXMLFile"
            Me.HelpProvider1.SetShowHelp(Me, True)
            Me.ShowInTaskbar = False
            Me.Text = "Excel File Selector"
            Me.Controls.SetChildIndex(Me.lblFileName, 0)
            Me.Controls.SetChildIndex(Me.StatusBar1, 0)
            Me.Controls.SetChildIndex(Me.btnOK1, 0)
            Me.Controls.SetChildIndex(Me.btnCancel, 0)
            Me.Controls.SetChildIndex(Me.btnBrowse, 0)
            Me.Controls.SetChildIndex(Me.txtFileName, 0)
            Me.cmbViewListRepos.EndInit
            Me.txtQuickSearchRepos.EndInit
            Me.cmbReportListRepos.EndInit
            Me.cmbFilterListRepos.EndInit
            Me.BarManager1.EndInit
            Me.cmbDefaultListRepos.EndInit
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

        Friend Overridable Property HelpProvider1 As HelpProvider
            Get
                Return Me._HelpProvider1
            End Get
            Set(ByVal WithEventsValue As HelpProvider)
                Me._HelpProvider1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblFileName As Label
            Get
                Return Me._lblFileName
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblFileName = WithEventsValue
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

        Friend Overridable Property SaveFileDialog1 As SaveFileDialog
            Get
                Return Me._SaveFileDialog1
            End Get
            Set(ByVal WithEventsValue As SaveFileDialog)
                Me._SaveFileDialog1 = WithEventsValue
            End Set
        End Property

        Public ReadOnly Property SelectedFileName As String
            Get
                Return Me.txtFileName.Text
            End Get
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

        Public Overridable Property txtFileName As TextBox
            Get
                Return Me._txtFileName
            End Get
            Set(ByVal WithEventsValue As TextBox)
                Me._txtFileName = WithEventsValue
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
        <AccessedThroughProperty("HelpProvider1")> _
        Private _HelpProvider1 As HelpProvider
        <AccessedThroughProperty("lblFileName")> _
        Private _lblFileName As Label
        <AccessedThroughProperty("OpenFileDialog1")> _
        Private _OpenFileDialog1 As OpenFileDialog
        <AccessedThroughProperty("SaveFileDialog1")> _
        Private _SaveFileDialog1 As SaveFileDialog
        <AccessedThroughProperty("StatusBar1")> _
        Private _StatusBar1 As StatusBar
        <AccessedThroughProperty("StatusBarPanel1")> _
        Private _StatusBarPanel1 As StatusBarPanel
        <AccessedThroughProperty("StatusBarPanel2")> _
        Private _StatusBarPanel2 As StatusBarPanel
        <AccessedThroughProperty("ToolTip1")> _
        Private _ToolTip1 As ToolTip
        <AccessedThroughProperty("txtFileName")> _
        Private _txtFileName As TextBox
        Private components As IContainer
        Public mvarBoolSave As Boolean
    End Class
End Namespace

