<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParrainage
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
        Me.GridParrainage = New DevExpress.XtraGrid.GridControl
        Me.GridViewParrainage = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridParrainage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewParrainage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridParrainage
        '
        Me.GridParrainage.EmbeddedNavigator.Name = ""
        Me.GridParrainage.FormsUseDefaultLookAndFeel = False
        Me.GridParrainage.Location = New System.Drawing.Point(12, 36)
        Me.GridParrainage.MainView = Me.GridViewParrainage
        Me.GridParrainage.Name = "GridParrainage"
        Me.GridParrainage.Size = New System.Drawing.Size(732, 200)
        Me.GridParrainage.TabIndex = 4
        Me.GridParrainage.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewParrainage})
        '
        'GridViewParrainage
        '
        Me.GridViewParrainage.GridControl = Me.GridParrainage
        Me.GridViewParrainage.Name = "GridViewParrainage"
        '
        'frmParrainage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 266)
        Me.Controls.Add(Me.GridParrainage)
        Me.Name = "frmParrainage"
        Me.Text = "FrmParrainage"
        Me.Controls.SetChildIndex(Me.GridParrainage, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridParrainage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewParrainage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridParrainage As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewParrainage As DevExpress.XtraGrid.Views.Grid.GridView
End Class
