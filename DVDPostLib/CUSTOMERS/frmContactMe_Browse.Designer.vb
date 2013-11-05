<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContactMe_Browse
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
        Me.GridcallMeBrowse = New DevExpress.XtraGrid.GridControl
        Me.GridViewCallMeBrowse = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridcallMeBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCallMeBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridcallMeBrowse
        '
        Me.GridcallMeBrowse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridcallMeBrowse.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridcallMeBrowse.EmbeddedNavigator.Name = ""
        Me.GridcallMeBrowse.FormsUseDefaultLookAndFeel = False
        Me.GridcallMeBrowse.Location = New System.Drawing.Point(0, 35)
        Me.GridcallMeBrowse.MainView = Me.GridViewCallMeBrowse
        Me.GridcallMeBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.GridcallMeBrowse.Name = "GridcallMeBrowse"
        Me.GridcallMeBrowse.Size = New System.Drawing.Size(1547, 292)
        Me.GridcallMeBrowse.TabIndex = 4
        Me.GridcallMeBrowse.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCallMeBrowse})
        '
        'GridViewCallMeBrowse
        '
        Me.GridViewCallMeBrowse.ActiveFilterEnabled = False
        Me.GridViewCallMeBrowse.GridControl = Me.GridcallMeBrowse
        Me.GridViewCallMeBrowse.Name = "GridViewCallMeBrowse"
        '
        'frmContactMe_Browse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1547, 327)
        Me.Controls.Add(Me.GridcallMeBrowse)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmContactMe_Browse"
        Me.Text = "FrmCallMeBrowse"
        Me.Controls.SetChildIndex(Me.GridcallMeBrowse, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridcallMeBrowse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCallMeBrowse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridcallMeBrowse As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCallMeBrowse As DevExpress.XtraGrid.Views.Grid.GridView
End Class
