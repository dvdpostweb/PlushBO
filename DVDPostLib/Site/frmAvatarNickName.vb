Imports System.IO
Imports System.Collections.Generic
Public Class frmAvatarNickName
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
    Friend WithEvents XtraTabControlAvatarNickName As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabResult As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabDetail As DevExpress.XtraTab.XtraTabPage



    Friend WithEvents lblSelected As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkSelected As DevExpress.XtraEditors.CheckEdit

    Friend WithEvents ContextMenu1 As PlushBuziness.contextMenu
    Friend WithEvents GridAvatarNickName As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewAvatarNickName As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNickNameActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNickNameActual As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemChkStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEditLanguage As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEditThemeEvent As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GBAvatar As System.Windows.Forms.GroupBox
    Friend WithEvents GBNickName As System.Windows.Forms.GroupBox
    Friend WithEvents txtNickNamePending As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNickNamePending As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAvatarPending As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAvatarActual As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnNickNameCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNickNameValid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAvatarCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAvatarValid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imgAvatarPending As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblCustomer_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents imgAvatarActual As DevExpress.XtraEditors.PictureEdit




    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAvatarNickName))
        Me.tabResult = New DevExpress.XtraTab.XtraTabPage
        Me.GridAvatarNickName = New DevExpress.XtraGrid.GridControl
        Me.GridViewAvatarNickName = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemChkStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemLookUpEditLanguage = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEditThemeEvent = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.chkSelected = New DevExpress.XtraEditors.CheckEdit
        Me.lblSelected = New DevExpress.XtraEditors.LabelControl
        Me.ContextMenu1 = New PlushBuziness.contextMenu
        Me.XtraTabControlAvatarNickName = New DevExpress.XtraTab.XtraTabControl
        Me.tabDetail = New DevExpress.XtraTab.XtraTabPage
        Me.GBAvatar = New System.Windows.Forms.GroupBox
        Me.imgAvatarActual = New DevExpress.XtraEditors.PictureEdit
        Me.GBNickName = New System.Windows.Forms.GroupBox
        Me.txtNickNamePending = New DevExpress.XtraEditors.TextEdit
        Me.lblNickNamePending = New DevExpress.XtraEditors.LabelControl
        Me.txtNickNameActual = New DevExpress.XtraEditors.TextEdit
        Me.lblNickNameActual = New DevExpress.XtraEditors.LabelControl
        Me.btnNickNameValid = New DevExpress.XtraEditors.SimpleButton
        Me.btnNickNameCancel = New DevExpress.XtraEditors.SimpleButton
        Me.lblAvatarActual = New DevExpress.XtraEditors.LabelControl
        Me.lblAvatarPending = New DevExpress.XtraEditors.LabelControl
        Me.imgAvatarPending = New DevExpress.XtraEditors.PictureEdit
        Me.btnAvatarCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnAvatarValid = New DevExpress.XtraEditors.SimpleButton
        Me.lblCustomer_id = New DevExpress.XtraEditors.LabelControl
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabResult.SuspendLayout()
        CType(Me.GridAvatarNickName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewAvatarNickName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemChkStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEditLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEditThemeEvent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControlAvatarNickName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControlAvatarNickName.SuspendLayout()
        Me.tabDetail.SuspendLayout()
        Me.GBAvatar.SuspendLayout()
        CType(Me.imgAvatarActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBNickName.SuspendLayout()
        CType(Me.txtNickNamePending.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNickNameActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAvatarPending.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabResult
        '
        Me.tabResult.Controls.Add(Me.GridAvatarNickName)
        Me.tabResult.Name = "tabResult"
        resources.ApplyResources(Me.tabResult, "tabResult")
        '
        'GridAvatarNickName
        '
        resources.ApplyResources(Me.GridAvatarNickName, "GridAvatarNickName")
        Me.GridAvatarNickName.EmbeddedNavigator.Name = ""
        Me.GridAvatarNickName.FormsUseDefaultLookAndFeel = False
        Me.GridAvatarNickName.MainView = Me.GridViewAvatarNickName
        Me.GridAvatarNickName.Name = "GridAvatarNickName"
        Me.GridAvatarNickName.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemChkStatus, Me.RepositoryItemLookUpEditLanguage, Me.RepositoryItemLookUpEditThemeEvent})
        Me.GridAvatarNickName.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewAvatarNickName})
        '
        'GridViewAvatarNickName
        '
        Me.GridViewAvatarNickName.GridControl = Me.GridAvatarNickName
        Me.GridViewAvatarNickName.Name = "GridViewAvatarNickName"
        Me.GridViewAvatarNickName.OptionsView.ShowFooter = True
        '
        'RepositoryItemChkStatus
        '
        resources.ApplyResources(Me.RepositoryItemChkStatus, "RepositoryItemChkStatus")
        Me.RepositoryItemChkStatus.Name = "RepositoryItemChkStatus"
        '
        'RepositoryItemLookUpEditLanguage
        '
        resources.ApplyResources(Me.RepositoryItemLookUpEditLanguage, "RepositoryItemLookUpEditLanguage")
        Me.RepositoryItemLookUpEditLanguage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEditLanguage.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemLookUpEditLanguage.Name = "RepositoryItemLookUpEditLanguage"
        '
        'RepositoryItemLookUpEditThemeEvent
        '
        resources.ApplyResources(Me.RepositoryItemLookUpEditThemeEvent, "RepositoryItemLookUpEditThemeEvent")
        Me.RepositoryItemLookUpEditThemeEvent.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEditThemeEvent.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemLookUpEditThemeEvent.Name = "RepositoryItemLookUpEditThemeEvent"
        '
        'chkSelected
        '
        resources.ApplyResources(Me.chkSelected, "chkSelected")
        Me.chkSelected.Name = "chkSelected"
        Me.chkSelected.Properties.Caption = resources.GetString("chkSelected.Properties.Caption")
        '
        'lblSelected
        '
        resources.ApplyResources(Me.lblSelected, "lblSelected")
        Me.lblSelected.Name = "lblSelected"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.Name = "ContextMenu1"
        resources.ApplyResources(Me.ContextMenu1, "ContextMenu1")
        '
        'XtraTabControlAvatarNickName
        '
        resources.ApplyResources(Me.XtraTabControlAvatarNickName, "XtraTabControlAvatarNickName")
        Me.XtraTabControlAvatarNickName.Name = "XtraTabControlAvatarNickName"
        Me.XtraTabControlAvatarNickName.SelectedTabPage = Me.tabResult
        Me.XtraTabControlAvatarNickName.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabResult, Me.tabDetail})
        '
        'tabDetail
        '
        Me.tabDetail.Controls.Add(Me.lblCustomer_id)
        Me.tabDetail.Controls.Add(Me.GBAvatar)
        Me.tabDetail.Controls.Add(Me.GBNickName)
        Me.tabDetail.Name = "tabDetail"
        resources.ApplyResources(Me.tabDetail, "tabDetail")
        '
        'GBAvatar
        '
        Me.GBAvatar.Controls.Add(Me.btnAvatarCancel)
        Me.GBAvatar.Controls.Add(Me.btnAvatarValid)
        Me.GBAvatar.Controls.Add(Me.imgAvatarPending)
        Me.GBAvatar.Controls.Add(Me.lblAvatarPending)
        Me.GBAvatar.Controls.Add(Me.lblAvatarActual)
        Me.GBAvatar.Controls.Add(Me.imgAvatarActual)
        resources.ApplyResources(Me.GBAvatar, "GBAvatar")
        Me.GBAvatar.Name = "GBAvatar"
        Me.GBAvatar.TabStop = False
        '
        'imgAvatarActual
        '
        resources.ApplyResources(Me.imgAvatarActual, "imgAvatarActual")
        Me.imgAvatarActual.Name = "imgAvatarActual"
        Me.imgAvatarActual.Properties.ShowMenu = False
        '
        'GBNickName
        '
        Me.GBNickName.Controls.Add(Me.btnNickNameCancel)
        Me.GBNickName.Controls.Add(Me.btnNickNameValid)
        Me.GBNickName.Controls.Add(Me.txtNickNamePending)
        Me.GBNickName.Controls.Add(Me.lblNickNamePending)
        Me.GBNickName.Controls.Add(Me.txtNickNameActual)
        Me.GBNickName.Controls.Add(Me.lblNickNameActual)
        resources.ApplyResources(Me.GBNickName, "GBNickName")
        Me.GBNickName.Name = "GBNickName"
        Me.GBNickName.TabStop = False
        '
        'txtNickNamePending
        '
        Me.txtNickNamePending.AllowDrop = True
        resources.ApplyResources(Me.txtNickNamePending, "txtNickNamePending")
        Me.txtNickNamePending.Name = "txtNickNamePending"
        '
        'lblNickNamePending
        '
        resources.ApplyResources(Me.lblNickNamePending, "lblNickNamePending")
        Me.lblNickNamePending.Name = "lblNickNamePending"
        '
        'txtNickNameActual
        '
        Me.txtNickNameActual.AllowDrop = True
        resources.ApplyResources(Me.txtNickNameActual, "txtNickNameActual")
        Me.txtNickNameActual.Name = "txtNickNameActual"
        '
        'lblNickNameActual
        '
        resources.ApplyResources(Me.lblNickNameActual, "lblNickNameActual")
        Me.lblNickNameActual.Name = "lblNickNameActual"
        '
        'btnNickNameValid
        '
        resources.ApplyResources(Me.btnNickNameValid, "btnNickNameValid")
        Me.btnNickNameValid.Name = "btnNickNameValid"
        '
        'btnNickNameCancel
        '
        resources.ApplyResources(Me.btnNickNameCancel, "btnNickNameCancel")
        Me.btnNickNameCancel.Name = "btnNickNameCancel"
        '
        'lblAvatarActual
        '
        resources.ApplyResources(Me.lblAvatarActual, "lblAvatarActual")
        Me.lblAvatarActual.Name = "lblAvatarActual"
        '
        'lblAvatarPending
        '
        resources.ApplyResources(Me.lblAvatarPending, "lblAvatarPending")
        Me.lblAvatarPending.Name = "lblAvatarPending"
        '
        'imgAvatarPending
        '
        resources.ApplyResources(Me.imgAvatarPending, "imgAvatarPending")
        Me.imgAvatarPending.Name = "imgAvatarPending"
        Me.imgAvatarPending.Properties.ShowMenu = False
        '
        'btnAvatarCancel
        '
        resources.ApplyResources(Me.btnAvatarCancel, "btnAvatarCancel")
        Me.btnAvatarCancel.Name = "btnAvatarCancel"
        '
        'btnAvatarValid
        '
        resources.ApplyResources(Me.btnAvatarValid, "btnAvatarValid")
        Me.btnAvatarValid.Name = "btnAvatarValid"
        '
        'lblCustomer_id
        '
        resources.ApplyResources(Me.lblCustomer_id, "lblCustomer_id")
        Me.lblCustomer_id.Name = "lblCustomer_id"
        '
        'frmtest
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.XtraTabControlAvatarNickName)
        Me.Name = "frmtest"
        Me.Controls.SetChildIndex(Me.XtraTabControlAvatarNickName, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabResult.ResumeLayout(False)
        CType(Me.GridAvatarNickName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewAvatarNickName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemChkStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEditLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEditThemeEvent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControlAvatarNickName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControlAvatarNickName.ResumeLayout(False)
        Me.tabDetail.ResumeLayout(False)
        Me.tabDetail.PerformLayout()
        Me.GBAvatar.ResumeLayout(False)
        Me.GBAvatar.PerformLayout()
        CType(Me.imgAvatarActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBNickName.ResumeLayout(False)
        Me.GBNickName.PerformLayout()
        CType(Me.txtNickNamePending.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNickNameActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAvatarPending.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim CurrentCodeType As String
    Dim _enableField As Boolean
    Dim _sql As String
    Dim _dt As DataTable



    Public Sub this_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        GridViewAvatarNickName.OptionsView.ColumnAutoWidth = False
        GridViewAvatarNickName.OptionsBehavior.Editable = False

        XtraTabControlAvatarNickName.SelectedTabPage = tabResult
        ' Misc_Bar.Visible = True

        Dim menuStrip As New PlushBuziness.contextMenu()
        GridAvatarNickName.ContextMenuStrip = menuStrip


        search()



    End Sub


    Public Sub search()

        _sql = PlushData.clsAvatarNickName.GetSearchPending()
        _dt = PlushData.clsConnection.FillDataSet(_sql)
        GridAvatarNickName.DataSource = _dt
        btnNickNameValid.Enabled = True
        btnNickNameCancel.Enabled = True
        btnAvatarValid.Enabled = True
        btnAvatarCancel.Enabled = True


    End Sub


    Private Sub GridAvatarPicture_doubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridAvatarNickName.DoubleClick
        loadInfo()

        XtraTabControlAvatarNickName.SelectedTabPage = tabDetail
    End Sub

    Private Sub loadInfo()
        Dim currentRow As DataRow

        If GridViewAvatarNickName.RowCount > 0 Then
            currentRow = GridViewAvatarNickName.GetDataRow(GridViewAvatarNickName.FocusedRowHandle())

            lblCustomer_id.Text = currentRow("customer_id")
            If currentRow("nickname_pending") IsNot DBNull.Value Then
                txtNickNameActual.Text = currentRow("nickname")
                txtNickNamePending.Text = currentRow("nickname_pending")
                GBNickName.Visible = True
            Else
                GBNickName.Visible = False
            End If

            If currentRow("avatar_pending") IsNot DBNull.Value Then
                RefreshPicture(imgAvatarActual, currentRow("avatar"))
                RefreshPicture(imgAvatarPending, currentRow("avatar_pending"))
                GBAvatar.Visible = True
            Else
                GBAvatar.Visible = False
            End If
        End If
    End Sub



#Region "Picture"

    Private Sub RefreshPicture(ByVal img As DevExpress.XtraEditors.PictureEdit, ByVal stream As Object)

        If stream IsNot DBNull.Value Then
            Dim myCallback As New Drawing.Image.GetThumbnailImageAbort(AddressOf thumbnailCallback)
            'img.Image = New Drawing.Bitmap(filePicture.FullName)
            Dim tbyte() As Byte = stream
            Dim mstream As MemoryStream = New MemoryStream(tbyte)
            img.Image = New System.Drawing.Bitmap(mstream)

            'img.Image = System.Drawing.Image.FromFile(filePicture.FullName)
            'this method used for reduce picture if too large 
            img.Image = img.Image.GetThumbnailImage(img.Width, img.Height, myCallback, IntPtr.Zero)
        Else
            img.Image = Nothing
        End If
    End Sub


    Private Function thumbnailCallback() As Boolean
        Return False
    End Function
#End Region


    Private Sub btnValidateNickname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNickNameValid.Click
        Dim sql As String
        sql = PlushData.clsAvatarNickName.getUpdateValidNickname(lblCustomer_id.Text)
        PlushData.clsConnection.ExecuteNonQuery(sql)
        btnNickNameValid.Enabled = False
        btnNickNameCancel.Enabled = False

    End Sub

    Private Sub btnCancelNickName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNickNameCancel.Click
        Dim sql As String
        sql = PlushData.clsAvatarNickName.getUpdateCancelNickName(lblCustomer_id.Text)
        PlushData.clsConnection.ExecuteNonQuery(sql)
        btnNickNameValid.Enabled = False
        btnNickNameCancel.Enabled = False
    End Sub

    Private Sub btnValidPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvatarValid.Click
        Dim sql As String
        sql = PlushData.clsAvatarNickName.getUpdateValidAvatar(lblCustomer_id.Text)
        PlushData.clsConnection.ExecuteNonQuery(sql)
        btnAvatarValid.Enabled = False
        btnAvatarCancel.Enabled = False
    End Sub

    Private Sub btnCancelPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvatarCancel.Click
        Dim sql As String
        sql = PlushData.clsAvatarNickName.getUpdateCancelAvatar(lblCustomer_id.Text)
        PlushData.clsConnection.ExecuteNonQuery(sql)
        btnAvatarValid.Enabled = False
        btnAvatarCancel.Enabled = False
    End Sub

    Private Sub XtraTabControlTheme_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControlAvatarNickName.SelectedPageChanged
        If XtraTabControlAvatarNickName.SelectedTabPage Is tabResult Then
            search()
        End If
    End Sub
End Class



