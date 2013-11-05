<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewDiscountCode
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
        Me.GridDiscountUse = New DevExpress.XtraGrid.GridControl
        Me.GridViewAboType = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SFDExportExcel = New System.Windows.Forms.SaveFileDialog
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDiscountUse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewAboType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridDiscountUse
        '
        Me.GridDiscountUse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDiscountUse.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridDiscountUse.EmbeddedNavigator.Name = ""
        Me.GridDiscountUse.FormsUseDefaultLookAndFeel = False
        Me.GridDiscountUse.Location = New System.Drawing.Point(0, 35)
        Me.GridDiscountUse.MainView = Me.GridViewAboType
        Me.GridDiscountUse.Margin = New System.Windows.Forms.Padding(4)
        Me.GridDiscountUse.Name = "GridDiscountUse"
        Me.GridDiscountUse.Size = New System.Drawing.Size(1547, 700)
        Me.GridDiscountUse.TabIndex = 4
        Me.GridDiscountUse.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewAboType})
        '
        'GridViewAboType
        '
        Me.GridViewAboType.GridControl = Me.GridDiscountUse
        Me.GridViewAboType.Name = "GridViewAboType"
        Me.GridViewAboType.OptionsBehavior.Editable = False
        Me.GridViewAboType.OptionsView.ShowFooter = True
        '
        'frmViewDiscountCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1547, 735)
        Me.Controls.Add(Me.GridDiscountUse)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmViewDiscountCode"
        Me.Text = "FrmAboType"
        Me.Controls.SetChildIndex(Me.GridDiscountUse, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDiscountUse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewAboType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridDiscountUse As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewAboType As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SFDExportExcel As System.Windows.Forms.SaveFileDialog
End Class
