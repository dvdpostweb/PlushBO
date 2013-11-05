<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheck
    Inherits BizzLib.frmBKForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GridCheck = New DevExpress.XtraGrid.GridControl
        Me.GridViewCheck = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridCheck
        '
        Me.GridCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCheck.EmbeddedNavigator.Name = ""
        Me.GridCheck.FormsUseDefaultLookAndFeel = False
        Me.GridCheck.Location = New System.Drawing.Point(0, 30)
        Me.GridCheck.MainView = Me.GridViewCheck
        Me.GridCheck.Name = "GridCheck"
        Me.GridCheck.Size = New System.Drawing.Size(735, 225)
        Me.GridCheck.TabIndex = 0
        Me.GridCheck.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCheck})
        '
        'GridViewCheck
        '
        Me.GridViewCheck.GridControl = Me.GridCheck
        Me.GridViewCheck.Name = "GridViewCheck"
        Me.GridViewCheck.OptionsView.ShowFooter = True
        '
        'frmCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 255)
        Me.Controls.Add(Me.GridCheck)
        Me.Name = "frmCheck"
        Me.Text = "frmCheck"
        Me.Controls.SetChildIndex(Me.GridCheck, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridCheck As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCheck As DevExpress.XtraGrid.Views.Grid.GridView
End Class
