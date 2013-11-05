<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentOffLineStep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentOffLineStep))
        Me.GridPaymentDetail = New DevExpress.XtraGrid.GridControl
        Me.GridViewPaymentDetail = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SFDExportExcel = New System.Windows.Forms.SaveFileDialog
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPaymentDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPaymentDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPaymentDetail
        '
        Me.GridPaymentDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPaymentDetail.EmbeddedNavigator.Name = ""
        Me.GridPaymentDetail.FormsUseDefaultLookAndFeel = False
        Me.GridPaymentDetail.Location = New System.Drawing.Point(0, 30)
        Me.GridPaymentDetail.MainView = Me.GridViewPaymentDetail
        Me.GridPaymentDetail.Name = "GridPaymentDetail"
        Me.GridPaymentDetail.Size = New System.Drawing.Size(1160, 450)
        Me.GridPaymentDetail.TabIndex = 4
        Me.GridPaymentDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPaymentDetail})
        '
        'GridViewPaymentDetail
        '
        Me.GridViewPaymentDetail.GridControl = Me.GridPaymentDetail
        Me.GridViewPaymentDetail.Name = "GridViewPaymentDetail"
        Me.GridViewPaymentDetail.OptionsBehavior.Editable = False
        Me.GridViewPaymentDetail.OptionsView.ColumnAutoWidth = False
        Me.GridViewPaymentDetail.OptionsView.ShowFooter = True
        Me.GridViewPaymentDetail.OptionsView.ShowGroupedColumns = True
        '
        'frmPaymentOffLineStep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 480)
        Me.Controls.Add(Me.GridPaymentDetail)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPaymentOffLineStep"
        Me.Text = "Form1"
        Me.Controls.SetChildIndex(Me.GridPaymentDetail, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPaymentDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPaymentDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridPaymentDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPaymentDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SFDExportExcel As System.Windows.Forms.SaveFileDialog
End Class
