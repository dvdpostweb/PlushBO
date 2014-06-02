<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcomeCall
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
        Me.GridWelcomeCall = New DevExpress.XtraGrid.GridControl
        Me.GridViewWelcomeCall = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridWelcomeCall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewWelcomeCall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridWelcomeCall
        '
        Me.GridWelcomeCall.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridWelcomeCall.EmbeddedNavigator.Name = ""
        Me.GridWelcomeCall.FormsUseDefaultLookAndFeel = False
        Me.GridWelcomeCall.Location = New System.Drawing.Point(0, 30)
        Me.GridWelcomeCall.MainView = Me.GridViewWelcomeCall
        Me.GridWelcomeCall.Name = "GridWelcomeCall"
        Me.GridWelcomeCall.Size = New System.Drawing.Size(1160, 552)
        Me.GridWelcomeCall.TabIndex = 5
        Me.GridWelcomeCall.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewWelcomeCall})
        '
        'GridViewWelcomeCall
        '
        Me.GridViewWelcomeCall.ActiveFilterEnabled = False
        Me.GridViewWelcomeCall.GridControl = Me.GridWelcomeCall
        Me.GridViewWelcomeCall.Name = "GridViewWelcomeCall"
        '
        'frmWelcomeCall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 582)
        Me.Controls.Add(Me.GridWelcomeCall)
        Me.Name = "frmWelcomeCall"
        Me.Text = "frmWelcomeCall"
        Me.Controls.SetChildIndex(Me.GridWelcomeCall, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridWelcomeCall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewWelcomeCall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridWelcomeCall As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewWelcomeCall As DevExpress.XtraGrid.Views.Grid.GridView
End Class
