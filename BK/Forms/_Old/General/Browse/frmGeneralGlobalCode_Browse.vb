Public Class frmgeneralglobalcode_Browse
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCodeListType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblCodeTypeDesc As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmgeneralglobalcode_Browse))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbCodeListType = New DevExpress.XtraEditors.LookUpEdit
        Me.lblCodeTypeDesc = New DevExpress.XtraEditors.TextEdit
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabParameters.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCodeListType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCodeTypeDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = CType(resources.GetObject("TabControl1.Size"), System.Drawing.Size)
        '
        'TabAnalyse
        '
        Me.TabAnalyse.Name = "TabAnalyse"
        Me.TabAnalyse.Size = CType(resources.GetObject("TabAnalyse.Size"), System.Drawing.Size)
        '
        'TabResult
        '
        Me.TabResult.Name = "TabResult"
        Me.TabResult.Size = CType(resources.GetObject("TabResult.Size"), System.Drawing.Size)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.lblCodeTypeDesc)
        Me.TabParameters.Controls.Add(Me.cmbCodeListType)
        Me.TabParameters.Controls.Add(Me.Label1)
        Me.TabParameters.Name = "TabParameters"
        Me.TabParameters.Size = CType(resources.GetObject("TabParameters.Size"), System.Drawing.Size)
        '
        'Panel1
        '
        Me.Panel1.Location = CType(resources.GetObject("Panel1.Location"), System.Drawing.Point)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = CType(resources.GetObject("Panel1.Size"), System.Drawing.Size)
        '
        'Grid1
        '
        '
        'Grid1.EmbeddedNavigator
        '
        Me.Grid1.EmbeddedNavigator.AccessibleDescription = resources.GetString("Grid1.EmbeddedNavigator.AccessibleDescription")
        Me.Grid1.EmbeddedNavigator.AccessibleName = resources.GetString("Grid1.EmbeddedNavigator.AccessibleName")
        Me.Grid1.EmbeddedNavigator.Anchor = CType(resources.GetObject("Grid1.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Grid1.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("Grid1.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.Grid1.EmbeddedNavigator.Enabled = CType(resources.GetObject("Grid1.EmbeddedNavigator.Enabled"), Boolean)
        Me.Grid1.EmbeddedNavigator.ImeMode = CType(resources.GetObject("Grid1.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.EmbeddedNavigator.Text = resources.GetString("Grid1.EmbeddedNavigator.Text")
        Me.Grid1.EmbeddedNavigator.TextLocation = CType(resources.GetObject("Grid1.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.Grid1.EmbeddedNavigator.TextStringFormat = resources.GetString("Grid1.EmbeddedNavigator.TextStringFormat")
        Me.Grid1.EmbeddedNavigator.ToolTip = resources.GetString("Grid1.EmbeddedNavigator.ToolTip")
        Me.Grid1.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("Grid1.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.Grid1.EmbeddedNavigator.ToolTipTitle = resources.GetString("Grid1.EmbeddedNavigator.ToolTipTitle")
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = CType(resources.GetObject("Grid1.Size"), System.Drawing.Size)
        '
        'GridView1
        '
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowChangeBandParent = True
        Me.GridView1.OptionsView.ShowBands = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = CType(resources.GetObject("StatusBar1.Location"), System.Drawing.Point)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = CType(resources.GetObject("StatusBar1.Size"), System.Drawing.Size)
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = resources.GetString("Label1.AccessibleDescription")
        Me.Label1.AccessibleName = resources.GetString("Label1.AccessibleName")
        Me.Label1.Anchor = CType(resources.GetObject("Label1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = CType(resources.GetObject("Label1.AutoSize"), Boolean)
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Dock = CType(resources.GetObject("Label1.Dock"), System.Windows.Forms.DockStyle)
        Me.Label1.Enabled = CType(resources.GetObject("Label1.Enabled"), Boolean)
        Me.Label1.Font = CType(resources.GetObject("Label1.Font"), System.Drawing.Font)
        Me.HelpProvider1.SetHelpKeyword(Me.Label1, resources.GetString("Label1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.Label1, CType(resources.GetObject("Label1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.Label1, resources.GetString("Label1.HelpString"))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = CType(resources.GetObject("Label1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label1.ImageIndex = CType(resources.GetObject("Label1.ImageIndex"), Integer)
        Me.Label1.ImeMode = CType(resources.GetObject("Label1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label1.Location = CType(resources.GetObject("Label1.Location"), System.Drawing.Point)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = CType(resources.GetObject("Label1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.Label1, CType(resources.GetObject("Label1.ShowHelp"), Boolean))
        Me.Label1.Size = CType(resources.GetObject("Label1.Size"), System.Drawing.Size)
        Me.Label1.TabIndex = CType(resources.GetObject("Label1.TabIndex"), Integer)
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = CType(resources.GetObject("Label1.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label1.Visible = CType(resources.GetObject("Label1.Visible"), Boolean)
        '
        'cmbCodeListType
        '
        Me.cmbCodeListType.Anchor = CType(resources.GetObject("cmbCodeListType.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmbCodeListType.BackgroundImage = CType(resources.GetObject("cmbCodeListType.BackgroundImage"), System.Drawing.Image)
        Me.cmbCodeListType.Dock = CType(resources.GetObject("cmbCodeListType.Dock"), System.Windows.Forms.DockStyle)
        Me.cmbCodeListType.EditValue = CType(resources.GetObject("cmbCodeListType.EditValue"), Object)
        Me.cmbCodeListType.Enabled = CType(resources.GetObject("cmbCodeListType.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.cmbCodeListType, resources.GetString("cmbCodeListType.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.cmbCodeListType, CType(resources.GetObject("cmbCodeListType.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.cmbCodeListType, resources.GetString("cmbCodeListType.HelpString"))
        Me.cmbCodeListType.ImeMode = CType(resources.GetObject("cmbCodeListType.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmbCodeListType.Location = CType(resources.GetObject("cmbCodeListType.Location"), System.Drawing.Point)
        Me.cmbCodeListType.Name = "cmbCodeListType"
        '
        'cmbCodeListType.Properties
        '
        Me.cmbCodeListType.Properties.AccessibleDescription = resources.GetString("cmbCodeListType.Properties.AccessibleDescription")
        Me.cmbCodeListType.Properties.AccessibleName = resources.GetString("cmbCodeListType.Properties.AccessibleName")
        Me.cmbCodeListType.Properties.AutoHeight = CType(resources.GetObject("cmbCodeListType.Properties.AutoHeight"), Boolean)
        Me.cmbCodeListType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCodeListType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeValue", "CodeValue", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeDesc", "CodeDesc", 160, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbCodeListType.Properties.DisplayMember = "CodeValue"
        Me.cmbCodeListType.Properties.Mask.AutoComplete = CType(resources.GetObject("cmbCodeListType.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.cmbCodeListType.Properties.Mask.BeepOnError = CType(resources.GetObject("cmbCodeListType.Properties.Mask.BeepOnError"), Boolean)
        Me.cmbCodeListType.Properties.Mask.EditMask = resources.GetString("cmbCodeListType.Properties.Mask.EditMask")
        Me.cmbCodeListType.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("cmbCodeListType.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.cmbCodeListType.Properties.Mask.MaskType = CType(resources.GetObject("cmbCodeListType.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.cmbCodeListType.Properties.Mask.PlaceHolder = CType(resources.GetObject("cmbCodeListType.Properties.Mask.PlaceHolder"), Char)
        Me.cmbCodeListType.Properties.Mask.SaveLiteral = CType(resources.GetObject("cmbCodeListType.Properties.Mask.SaveLiteral"), Boolean)
        Me.cmbCodeListType.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("cmbCodeListType.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.cmbCodeListType.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("cmbCodeListType.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.cmbCodeListType.Properties.NullText = resources.GetString("cmbCodeListType.Properties.NullText")
        Me.cmbCodeListType.Properties.PopupWidth = 200
        Me.cmbCodeListType.Properties.ValueMember = "CodeValue"
        Me.cmbCodeListType.RightToLeft = CType(resources.GetObject("cmbCodeListType.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.cmbCodeListType, CType(resources.GetObject("cmbCodeListType.ShowHelp"), Boolean))
        Me.cmbCodeListType.Size = CType(resources.GetObject("cmbCodeListType.Size"), System.Drawing.Size)
        Me.cmbCodeListType.TabIndex = CType(resources.GetObject("cmbCodeListType.TabIndex"), Integer)
        Me.cmbCodeListType.ToolTip = resources.GetString("cmbCodeListType.ToolTip")
        Me.cmbCodeListType.ToolTipIconType = CType(resources.GetObject("cmbCodeListType.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.cmbCodeListType.ToolTipTitle = resources.GetString("cmbCodeListType.ToolTipTitle")
        Me.cmbCodeListType.Visible = CType(resources.GetObject("cmbCodeListType.Visible"), Boolean)
        '
        'lblCodeTypeDesc
        '
        Me.lblCodeTypeDesc.Anchor = CType(resources.GetObject("lblCodeTypeDesc.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblCodeTypeDesc.BackgroundImage = CType(resources.GetObject("lblCodeTypeDesc.BackgroundImage"), System.Drawing.Image)
        Me.lblCodeTypeDesc.Dock = CType(resources.GetObject("lblCodeTypeDesc.Dock"), System.Windows.Forms.DockStyle)
        Me.lblCodeTypeDesc.EditValue = CType(resources.GetObject("lblCodeTypeDesc.EditValue"), Object)
        Me.lblCodeTypeDesc.Enabled = CType(resources.GetObject("lblCodeTypeDesc.Enabled"), Boolean)
        Me.HelpProvider1.SetHelpKeyword(Me.lblCodeTypeDesc, resources.GetString("lblCodeTypeDesc.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.lblCodeTypeDesc, CType(resources.GetObject("lblCodeTypeDesc.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.lblCodeTypeDesc, resources.GetString("lblCodeTypeDesc.HelpString"))
        Me.lblCodeTypeDesc.ImeMode = CType(resources.GetObject("lblCodeTypeDesc.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblCodeTypeDesc.Location = CType(resources.GetObject("lblCodeTypeDesc.Location"), System.Drawing.Point)
        Me.lblCodeTypeDesc.Name = "lblCodeTypeDesc"
        '
        'lblCodeTypeDesc.Properties
        '
        Me.lblCodeTypeDesc.Properties.AccessibleDescription = resources.GetString("lblCodeTypeDesc.Properties.AccessibleDescription")
        Me.lblCodeTypeDesc.Properties.AccessibleName = resources.GetString("lblCodeTypeDesc.Properties.AccessibleName")
        Me.lblCodeTypeDesc.Properties.AutoHeight = CType(resources.GetObject("lblCodeTypeDesc.Properties.AutoHeight"), Boolean)
        Me.lblCodeTypeDesc.Properties.Mask.AutoComplete = CType(resources.GetObject("lblCodeTypeDesc.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.lblCodeTypeDesc.Properties.Mask.BeepOnError = CType(resources.GetObject("lblCodeTypeDesc.Properties.Mask.BeepOnError"), Boolean)
        Me.lblCodeTypeDesc.Properties.Mask.EditMask = resources.GetString("lblCodeTypeDesc.Properties.Mask.EditMask")
        Me.lblCodeTypeDesc.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("lblCodeTypeDesc.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.lblCodeTypeDesc.Properties.Mask.MaskType = CType(resources.GetObject("lblCodeTypeDesc.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.lblCodeTypeDesc.Properties.Mask.PlaceHolder = CType(resources.GetObject("lblCodeTypeDesc.Properties.Mask.PlaceHolder"), Char)
        Me.lblCodeTypeDesc.Properties.Mask.SaveLiteral = CType(resources.GetObject("lblCodeTypeDesc.Properties.Mask.SaveLiteral"), Boolean)
        Me.lblCodeTypeDesc.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("lblCodeTypeDesc.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.lblCodeTypeDesc.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("lblCodeTypeDesc.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.lblCodeTypeDesc.Properties.NullText = resources.GetString("lblCodeTypeDesc.Properties.NullText")
        Me.lblCodeTypeDesc.RightToLeft = CType(resources.GetObject("lblCodeTypeDesc.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me.lblCodeTypeDesc, CType(resources.GetObject("lblCodeTypeDesc.ShowHelp"), Boolean))
        Me.lblCodeTypeDesc.Size = CType(resources.GetObject("lblCodeTypeDesc.Size"), System.Drawing.Size)
        Me.lblCodeTypeDesc.TabIndex = CType(resources.GetObject("lblCodeTypeDesc.TabIndex"), Integer)
        Me.lblCodeTypeDesc.ToolTip = resources.GetString("lblCodeTypeDesc.ToolTip")
        Me.lblCodeTypeDesc.ToolTipIconType = CType(resources.GetObject("lblCodeTypeDesc.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.lblCodeTypeDesc.ToolTipTitle = resources.GetString("lblCodeTypeDesc.ToolTipTitle")
        Me.lblCodeTypeDesc.Visible = CType(resources.GetObject("lblCodeTypeDesc.Visible"), Boolean)
        '
        'frmgeneralglobalcode_Browse
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.HelpButton = False
        Me.HelpProvider1.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me, resources.GetString("$this.HelpString"))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = True
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = True
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmgeneralglobalcode_Browse"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabParameters.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCodeListType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCodeTypeDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim KeyDataSet As String = "BizzLib.dsGeneral" 'The Dataset used 
    Dim CurrentCodeType As String

    Public Overrides Sub DeleteRecord(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Row As DataRow
        'Msg = 1 = Confirm Delete
        If MsgBox(BKGlobal.GetMsg(1, SessionInfo.UserLang), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If ValidateBeforeDelete() Then
                Try
                    _Row = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    'DeleteTranslations(TableName & "." & IDField, _Row(IDField))
                    'DeleteComments(SessionInfo.EntityID, _Row(NameField))
                    GridView1.DeleteRow(GridView1.FocusedRowHandle)
                    Me.UpdateDataSet()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub
    Private Function ValidateBeforeDelete() As Boolean
        Return True
    End Function
    Public Sub LoadBKComboSet()
        Try
            BKCombo.GetCombo_generalglobalcodeTypes(objDS, "generalglobalcodeType", "CodeValue")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overrides Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            objDS = New BizzLib.dsGeneral
            TableName = "generalglobalcode"
            IDField = "CodeValue"
            NameField = "CodeValue"
            LoadBKComboSet()
            cmbCodeListType.Properties.DataSource = objDS.Tables("generalglobalcodeType")
            cmbCodeListType.Properties.DisplayMember = "CodeValue"
            cmbCodeListType.Properties.ValueMember = "CodeValue"
            'If Not IsNothing(objDS.Tables("generalglobalcodeType").Rows(0)) Then
            '    If objDS.Tables("generalglobalcodeType").Rows.Count > 0 Then
            '        cmbCodeListType.EditValue = objDS.Tables("generalglobalcodeType").Rows(0)("CodeValue")
            '    End If
            'End If
            SQLTxt1 = "SELECT * FROM generalglobalcode "
            WhereClause = " WHERE CodeType = '" & CurrentCodeType & "' "
            OrderByClause = " ORDER BY " & NameField
            objDS.Tables(TableName).Columns("CodeType").DefaultValue = CurrentCodeType
            MaintenanceMenuID = -1
            CanNew = False
            CanEdit = False
            CanSave = True
            CanDelete = True
            MyBase.StartUp()
            GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            GridView1.OptionsBehavior.Editable = True
            TabParameters.PageVisible = True
            TabControl1.SelectedTabPage = TabParameters
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
    End Sub

    Private Sub cmbCodeListType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCodeListType.EditValueChanged
        CurrentCodeType = cmbCodeListType.EditValue
        WhereClause = " WHERE CodeType = '" & CurrentCodeType & "' "
        OrderByClause = " ORDER BY " & NameField
        objDS.Tables(TableName).Columns("CodeType").DefaultValue = CurrentCodeType
        If Not IsNothing(CType(cmbCodeListType.Properties.GetDataSourceRowByKeyValue(CurrentCodeType), DataRowView)) Then
            lblCodeTypeDesc.EditValue = CType(cmbCodeListType.Properties.GetDataSourceRowByKeyValue(CurrentCodeType), DataRowView)("CodeDesc") & ""
        End If
        LoadDataSet()
        objDS.Tables(TableName).Columns("CodeType").DefaultValue = CurrentCodeType
    End Sub
End Class
