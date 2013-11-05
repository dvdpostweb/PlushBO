Public Class frmEDocCategory_Browse
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEDocCategory_Browse))
        Me.SuspendLayout()
        '
        'frmEDocCategory_Browse
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.Panel1)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmEDocCategory_Browse"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim KeyDataSet As String = "BizzLib.dsGeneral" 'The Dataset used 
    Dim CurrentCodeType As String = "EDocCategory"

    Public Overrides Sub DeleteRecord(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _answ As MsgBoxResult
        Dim _Row As DataRow
        'Msg = 1 = Confirm Delete
        If MsgBox(BKGlobal.GetMsg(1, SessionInfo.UserLang), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If ValidateBeforeDelete() Then
                Try
                    _Row = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    'DeleteTranslations(TableName & "." & IDField, _Row.Item(IDField))
                    'DeleteComments(SessionInfo.EntityID, _Row.Item(NameField))
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

    Public Overrides Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            objDS = New BizzLib.dsGeneral
            TableName = "GeneralGlobalCode"
            IDField = "CodeValue"
            NameField = "CodeValue"
            'SQLTxt1 = "SELECT CodeValue, CodeDesc FROM GeneralGlobalCode "
            WhereClause = " WHERE CodeType = '" & CurrentCodeType & "' "
            OrderByClause = " ORDER BY " & NameField
            MaintenanceMenuID = -1
            CanNew = False
            CanEdit = False
            CanSave = True
            CanDelete = True
            MyBase.StartUp()
            GridView1.OptionsView.NewItemRowPosition  = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom 
            GridView1.OptionsBehavior.Editable = True
            objDS.Tables(TableName).Columns("CodeType").DefaultValue = CurrentCodeType
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
    End Sub


End Class
