<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatProductCritique
    Inherits BizzLib.frmGeneral_Browse

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
        Me.GCBestLife = New DevExpress.XtraEditors.GroupControl
        Me.btnBestRating = New DevExpress.XtraEditors.SimpleButton
        Me.BtnBestControverse = New DevExpress.XtraEditors.SimpleButton
        Me.GCBestCustomerWeek = New DevExpress.XtraEditors.GroupControl
        Me.btnBestRatingWeek = New DevExpress.XtraEditors.SimpleButton
        Me.BtnBestControverseWeek = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabParameters.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.TabChart.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCBestLife, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCBestLife.SuspendLayout()
        CType(Me.GCBestCustomerWeek, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCBestCustomerWeek.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 548)
        Me.StatusBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.StatusBar1.Size = New System.Drawing.Size(1472, 30)
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 35)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Size = New System.Drawing.Size(1472, 513)
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.SelectedTabPage = Me.TabResult
        Me.TabControl1.Size = New System.Drawing.Size(1472, 513)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.GCBestCustomerWeek)
        Me.TabParameters.Controls.Add(Me.GCBestLife)
        Me.TabParameters.Margin = New System.Windows.Forms.Padding(4)
        Me.TabParameters.Size = New System.Drawing.Size(1463, 479)
        '
        'TabResult
        '
        Me.TabResult.Margin = New System.Windows.Forms.Padding(4)
        Me.TabResult.Size = New System.Drawing.Size(1463, 479)
        '
        'TabAnalyse
        '
        Me.TabAnalyse.Margin = New System.Windows.Forms.Padding(4)
        Me.TabAnalyse.Size = New System.Drawing.Size(1463, 479)
        '
        'UcPivotGrid1
        '
        Me.UcPivotGrid1.Margin = New System.Windows.Forms.Padding(4)
        Me.UcPivotGrid1.Size = New System.Drawing.Size(1463, 479)
        '
        'UcChart1
        '
        Me.UcChart1.Margin = New System.Windows.Forms.Padding(4)
        Me.UcChart1.Size = New System.Drawing.Size(1463, 479)
        '
        'TabChart
        '
        Me.TabChart.Margin = New System.Windows.Forms.Padding(4)
        Me.TabChart.Size = New System.Drawing.Size(1463, 479)
        '
        'GCBestLife
        '
        Me.GCBestLife.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCBestLife.Controls.Add(Me.btnBestRating)
        Me.GCBestLife.Controls.Add(Me.BtnBestControverse)
        Me.GCBestLife.Location = New System.Drawing.Point(31, 30)
        Me.GCBestLife.Margin = New System.Windows.Forms.Padding(4)
        Me.GCBestLife.Name = "GCBestLife"
        Me.GCBestLife.Size = New System.Drawing.Size(579, 107)
        Me.GCBestLife.TabIndex = 38
        Me.GCBestLife.Text = "best dvd"
        '
        'btnBestRating
        '
        Me.btnBestRating.Location = New System.Drawing.Point(276, 26)
        Me.btnBestRating.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBestRating.Name = "btnBestRating"
        Me.HelpProvider1.SetShowHelp(Me.btnBestRating, False)
        Me.btnBestRating.Size = New System.Drawing.Size(244, 57)
        Me.btnBestRating.TabIndex = 39
        Me.btnBestRating.Text = "Best # rating"
        Me.btnBestRating.ToolTip = "trier par ordre du plus grand nombre de critique positive"
        '
        'BtnBestControverse
        '
        Me.BtnBestControverse.Location = New System.Drawing.Point(6, 26)
        Me.BtnBestControverse.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBestControverse.Name = "BtnBestControverse"
        Me.HelpProvider1.SetShowHelp(Me.BtnBestControverse, False)
        Me.BtnBestControverse.Size = New System.Drawing.Size(244, 57)
        Me.BtnBestControverse.TabIndex = 38
        Me.BtnBestControverse.Text = "Best # controverse"
        Me.BtnBestControverse.ToolTip = "trier par ordre de la controverse la plus importante ensuite pas nombre de rating" & _
            ""
        '
        'GCBestCustomerWeek
        '
        Me.GCBestCustomerWeek.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCBestCustomerWeek.Controls.Add(Me.btnBestRatingWeek)
        Me.GCBestCustomerWeek.Controls.Add(Me.BtnBestControverseWeek)
        Me.GCBestCustomerWeek.Location = New System.Drawing.Point(31, 163)
        Me.GCBestCustomerWeek.Margin = New System.Windows.Forms.Padding(4)
        Me.GCBestCustomerWeek.Name = "GCBestCustomerWeek"
        Me.GCBestCustomerWeek.Size = New System.Drawing.Size(579, 98)
        Me.GCBestCustomerWeek.TabIndex = 42
        Me.GCBestCustomerWeek.Text = "best DVD week"
        '
        'btnBestRatingWeek
        '
        Me.btnBestRatingWeek.Location = New System.Drawing.Point(276, 26)
        Me.btnBestRatingWeek.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBestRatingWeek.Name = "btnBestRatingWeek"
        Me.HelpProvider1.SetShowHelp(Me.btnBestRatingWeek, False)
        Me.btnBestRatingWeek.Size = New System.Drawing.Size(244, 57)
        Me.btnBestRatingWeek.TabIndex = 39
        Me.btnBestRatingWeek.Text = "Best # rating"
        Me.btnBestRatingWeek.ToolTip = "trier par ordre du plus grand nombre de critique positive"
        '
        'BtnBestControverseWeek
        '
        Me.BtnBestControverseWeek.Location = New System.Drawing.Point(6, 26)
        Me.BtnBestControverseWeek.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBestControverseWeek.Name = "BtnBestControverseWeek"
        Me.HelpProvider1.SetShowHelp(Me.BtnBestControverseWeek, False)
        Me.BtnBestControverseWeek.Size = New System.Drawing.Size(244, 57)
        Me.BtnBestControverseWeek.TabIndex = 38
        Me.BtnBestControverseWeek.Text = "Best # Controverse"
        Me.BtnBestControverseWeek.ToolTip = "trier par ordre de la controverse la plus importante ensuite pas nombre de rating" & _
            ""
        '
        'frmStatProductCritique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1472, 578)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmStatProductCritique"
        Me.HelpProvider1.SetShowHelp(Me, False)
        Me.Text = "FrmStat"
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabChart.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCBestLife, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCBestLife.ResumeLayout(False)
        CType(Me.GCBestCustomerWeek, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCBestCustomerWeek.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GCBestLife As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnBestControverse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBestRating As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCBestCustomerWeek As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnBestRatingWeek As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnBestControverseWeek As DevExpress.XtraEditors.SimpleButton
End Class
