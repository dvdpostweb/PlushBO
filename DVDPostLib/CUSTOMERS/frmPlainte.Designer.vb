<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlainte
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
        Me.GridPlainte = New DevExpress.XtraGrid.GridControl
        Me.GridViewPlainte = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPlainte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPlainte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPlainte
        '
        Me.GridPlainte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPlainte.EmbeddedNavigator.Name = ""
        Me.GridPlainte.FormsUseDefaultLookAndFeel = False
        Me.GridPlainte.Location = New System.Drawing.Point(0, 30)
        Me.GridPlainte.MainView = Me.GridViewPlainte
        Me.GridPlainte.Name = "GridPlainte"
        Me.GridPlainte.Size = New System.Drawing.Size(735, 225)
        Me.GridPlainte.TabIndex = 0
        Me.GridPlainte.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPlainte})
        '
        'GridViewPlainte
        '
        Me.GridViewPlainte.GridControl = Me.GridPlainte
        Me.GridViewPlainte.Name = "GridViewPlainte"
        Me.GridViewPlainte.OptionsView.ShowFooter = True
        '
        'frmPlainte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 255)
        Me.Controls.Add(Me.GridPlainte)
        Me.Name = "frmPlainte"
        Me.Text = "frmPlainte"
        Me.Controls.SetChildIndex(Me.GridPlainte, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPlainte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPlainte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridPlainte As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPlainte As DevExpress.XtraGrid.Views.Grid.GridView
End Class
