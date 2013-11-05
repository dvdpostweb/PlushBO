<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessagerie
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
        Me.GridMessagerie = New DevExpress.XtraGrid.GridControl
        Me.GridViewMessagerie = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridMessagerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMessagerie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridMessagerie
        '
        Me.GridMessagerie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMessagerie.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridMessagerie.EmbeddedNavigator.Name = ""
        Me.GridMessagerie.FormsUseDefaultLookAndFeel = False
        Me.GridMessagerie.Location = New System.Drawing.Point(0, 35)
        Me.GridMessagerie.MainView = Me.GridViewMessagerie
        Me.GridMessagerie.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridMessagerie.Name = "GridMessagerie"
        Me.GridMessagerie.Size = New System.Drawing.Size(1547, 700)
        Me.GridMessagerie.TabIndex = 4
        Me.GridMessagerie.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewMessagerie})
        '
        'GridViewMessagerie
        '
        Me.GridViewMessagerie.GridControl = Me.GridMessagerie
        Me.GridViewMessagerie.Name = "GridViewMessagerie"
        Me.GridViewMessagerie.OptionsBehavior.Editable = False
        Me.GridViewMessagerie.OptionsView.ShowFooter = True
        '
        'frmMessagerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1547, 735)
        Me.Controls.Add(Me.GridMessagerie)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMessagerie"
        Me.Text = "FrmAboType"
        Me.Controls.SetChildIndex(Me.GridMessagerie, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridMessagerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMessagerie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridMessagerie As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewMessagerie As DevExpress.XtraGrid.Views.Grid.GridView
End Class
