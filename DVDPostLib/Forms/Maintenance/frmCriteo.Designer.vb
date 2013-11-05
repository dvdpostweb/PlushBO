<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCriteo
    Inherits BizzLib.frmBKForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tabRating = New DevExpress.XtraTab.XtraTabPage
        Me.btnGo_ExportRating = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtFileName = New DevExpress.XtraEditors.TextEdit
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.btnBrowse_Rating = New DevExpress.XtraEditors.SimpleButton
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabRating.SuspendLayout()
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 30)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabRating
        Me.XtraTabControl1.Size = New System.Drawing.Size(1160, 286)
        Me.XtraTabControl1.TabIndex = 4
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabRating})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'tabRating
        '
        Me.tabRating.Controls.Add(Me.btnBrowse_Rating)
        Me.tabRating.Controls.Add(Me.LabelControl3)
        Me.tabRating.Controls.Add(Me.txtToDate)
        Me.tabRating.Controls.Add(Me.LabelControl2)
        Me.tabRating.Controls.Add(Me.txtFromDate)
        Me.tabRating.Controls.Add(Me.txtFileName)
        Me.tabRating.Controls.Add(Me.LabelControl1)
        Me.tabRating.Controls.Add(Me.btnGo_ExportRating)
        Me.tabRating.Name = "tabRating"
        Me.tabRating.Size = New System.Drawing.Size(1151, 255)
        Me.tabRating.Text = "Rating Export"
        '
        'btnGo_ExportRating
        '
        Me.btnGo_ExportRating.Location = New System.Drawing.Point(135, 70)
        Me.btnGo_ExportRating.Name = "btnGo_ExportRating"
        Me.btnGo_ExportRating.Size = New System.Drawing.Size(75, 23)
        Me.btnGo_ExportRating.TabIndex = 0
        Me.btnGo_ExportRating.Text = "&GO"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(63, 47)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "File Name"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(135, 44)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(306, 20)
        Me.txtFileName.TabIndex = 2
        '
        'txtFromDate
        '
        Me.txtFromDate.EditValue = Nothing
        Me.txtFromDate.Location = New System.Drawing.Point(135, 18)
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtFromDate.Size = New System.Drawing.Size(100, 20)
        Me.txtFromDate.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(63, 21)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "From Date"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(269, 21)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "To Date"
        '
        'txtToDate
        '
        Me.txtToDate.EditValue = Nothing
        Me.txtToDate.Location = New System.Drawing.Point(341, 18)
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtToDate.Size = New System.Drawing.Size(100, 20)
        Me.txtToDate.TabIndex = 5
        '
        'btnBrowse_Rating
        '
        Me.btnBrowse_Rating.Location = New System.Drawing.Point(459, 41)
        Me.btnBrowse_Rating.Name = "btnBrowse_Rating"
        Me.btnBrowse_Rating.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse_Rating.TabIndex = 7
        Me.btnBrowse_Rating.Text = "Browse"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "XML Files|*.xml|All Files|*.*"
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'frmCriteo
        '
        Me.ClientSize = New System.Drawing.Size(1160, 316)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmCriteo"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabRating.ResumeLayout(False)
        Me.tabRating.PerformLayout()
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabRating As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnBrowse_Rating As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFileName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGo_ExportRating As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
