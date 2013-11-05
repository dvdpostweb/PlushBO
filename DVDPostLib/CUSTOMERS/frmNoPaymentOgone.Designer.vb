<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoPaymentOgone
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
        Me.GridNoPaymentOgone = New DevExpress.XtraGrid.GridControl
        Me.GridViewNoPaymentOgone = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridNoPaymentOgone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewNoPaymentOgone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridNoPaymentOgone
        '
        Me.GridNoPaymentOgone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GridNoPaymentOgone.EmbeddedNavigator.Name = ""
        Me.GridNoPaymentOgone.FormsUseDefaultLookAndFeel = False
        Me.GridNoPaymentOgone.Location = New System.Drawing.Point(0, 49)
        Me.GridNoPaymentOgone.MainView = Me.GridViewNoPaymentOgone
        Me.GridNoPaymentOgone.Name = "GridNoPaymentOgone"
        Me.GridNoPaymentOgone.Size = New System.Drawing.Size(447, 384)
        Me.GridNoPaymentOgone.TabIndex = 0
        Me.GridNoPaymentOgone.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewNoPaymentOgone})
        '
        'GridViewNoPaymentOgone
        '
        Me.GridViewNoPaymentOgone.GridControl = Me.GridNoPaymentOgone
        Me.GridViewNoPaymentOgone.Name = "GridViewNoPaymentOgone"
        Me.GridViewNoPaymentOgone.OptionsView.ShowFooter = True
        '
        'frmNoPaymentOgone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 445)
        Me.Controls.Add(Me.GridNoPaymentOgone)
        Me.Name = "frmNoPaymentOgone"
        Me.Text = "frmPlainte"
        Me.Controls.SetChildIndex(Me.GridNoPaymentOgone, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridNoPaymentOgone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewNoPaymentOgone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridNoPaymentOgone As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewNoPaymentOgone As DevExpress.XtraGrid.Views.Grid.GridView
End Class
