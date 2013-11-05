<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatCustomerCritique
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
        Me.btnBestQualityCustomers = New DevExpress.XtraEditors.SimpleButton
        Me.btnBestQualityDVDPOST = New DevExpress.XtraEditors.SimpleButton
        Me.btnBestRating = New DevExpress.XtraEditors.SimpleButton
        Me.BtnBestCritique = New DevExpress.XtraEditors.SimpleButton
        Me.GCBestCustomerWeek = New DevExpress.XtraEditors.GroupControl
        Me.btnBestQualityCustomersWeek = New DevExpress.XtraEditors.SimpleButton
        Me.btnBestQualityDvdpostWeek = New DevExpress.XtraEditors.SimpleButton
        Me.btnBestRatingWeek = New DevExpress.XtraEditors.SimpleButton
        Me.btnBestCritiqueWeek = New DevExpress.XtraEditors.SimpleButton
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
        Me.GCBestLife.Controls.Add(Me.btnBestQualityCustomers)
        Me.GCBestLife.Controls.Add(Me.btnBestQualityDVDPOST)
        Me.GCBestLife.Controls.Add(Me.btnBestRating)
        Me.GCBestLife.Controls.Add(Me.BtnBestCritique)
        Me.GCBestLife.Location = New System.Drawing.Point(31, 30)
        Me.GCBestLife.Margin = New System.Windows.Forms.Padding(4)
        Me.GCBestLife.Name = "GCBestLife"
        Me.GCBestLife.Size = New System.Drawing.Size(579, 174)
        Me.GCBestLife.TabIndex = 38
        Me.GCBestLife.Text = "best customers "
        '
        'btnBestQualityCustomers
        '
        Me.btnBestQualityCustomers.Location = New System.Drawing.Point(276, 102)
        Me.btnBestQualityCustomers.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBestQualityCustomers.Name = "btnBestQualityCustomers"
        Me.HelpProvider1.SetShowHelp(Me.btnBestQualityCustomers, False)
        Me.btnBestQualityCustomers.Size = New System.Drawing.Size(244, 57)
        Me.btnBestQualityCustomers.TabIndex = 41
        Me.btnBestQualityCustomers.Text = "Best quality of customers"
        '
        'btnBestQualityDVDPOST
        '
        Me.btnBestQualityDVDPOST.Location = New System.Drawing.Point(6, 102)
        Me.btnBestQualityDVDPOST.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBestQualityDVDPOST.Name = "btnBestQualityDVDPOST"
        Me.HelpProvider1.SetShowHelp(Me.btnBestQualityDVDPOST, False)
        Me.btnBestQualityDVDPOST.Size = New System.Drawing.Size(244, 57)
        Me.btnBestQualityDVDPOST.TabIndex = 40
        Me.btnBestQualityDVDPOST.Text = "Best quality of dvdpost"
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
        Me.btnBestRating.ToolTip = "trier par ordre du plus grand nombre de rating"
        '
        'BtnBestCritique
        '
        Me.BtnBestCritique.Location = New System.Drawing.Point(6, 26)
        Me.BtnBestCritique.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBestCritique.Name = "BtnBestCritique"
        Me.HelpProvider1.SetShowHelp(Me.BtnBestCritique, False)
        Me.BtnBestCritique.Size = New System.Drawing.Size(244, 57)
        Me.BtnBestCritique.TabIndex = 38
        Me.BtnBestCritique.Text = "Best # critique"
        Me.BtnBestCritique.ToolTip = "trier par ordre du plus grand nombre de critique"
        '
        'GCBestCustomerWeek
        '
        Me.GCBestCustomerWeek.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCBestCustomerWeek.Controls.Add(Me.btnBestQualityCustomersWeek)
        Me.GCBestCustomerWeek.Controls.Add(Me.btnBestQualityDvdpostWeek)
        Me.GCBestCustomerWeek.Controls.Add(Me.btnBestRatingWeek)
        Me.GCBestCustomerWeek.Controls.Add(Me.btnBestCritiqueWeek)
        Me.GCBestCustomerWeek.Location = New System.Drawing.Point(31, 225)
        Me.GCBestCustomerWeek.Margin = New System.Windows.Forms.Padding(4)
        Me.GCBestCustomerWeek.Name = "GCBestCustomerWeek"
        Me.GCBestCustomerWeek.Size = New System.Drawing.Size(579, 174)
        Me.GCBestCustomerWeek.TabIndex = 42
        Me.GCBestCustomerWeek.Text = "best customers week"
        '
        'btnBestQualityCustomersWeek
        '
        Me.btnBestQualityCustomersWeek.Location = New System.Drawing.Point(276, 102)
        Me.btnBestQualityCustomersWeek.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBestQualityCustomersWeek.Name = "btnBestQualityCustomersWeek"
        Me.HelpProvider1.SetShowHelp(Me.btnBestQualityCustomersWeek, False)
        Me.btnBestQualityCustomersWeek.Size = New System.Drawing.Size(244, 57)
        Me.btnBestQualityCustomersWeek.TabIndex = 41
        Me.btnBestQualityCustomersWeek.Text = "Best quality of customers"
        '
        'btnBestQualityDvdpostWeek
        '
        Me.btnBestQualityDvdpostWeek.Location = New System.Drawing.Point(6, 102)
        Me.btnBestQualityDvdpostWeek.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBestQualityDvdpostWeek.Name = "btnBestQualityDvdpostWeek"
        Me.HelpProvider1.SetShowHelp(Me.btnBestQualityDvdpostWeek, False)
        Me.btnBestQualityDvdpostWeek.Size = New System.Drawing.Size(244, 57)
        Me.btnBestQualityDvdpostWeek.TabIndex = 40
        Me.btnBestQualityDvdpostWeek.Text = "Best quality of dvdpost"
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
        Me.btnBestRatingWeek.ToolTip = "trier par ordre du plus grand nombre de rating"
        '
        'btnBestCritiqueWeek
        '
        Me.btnBestCritiqueWeek.Location = New System.Drawing.Point(6, 26)
        Me.btnBestCritiqueWeek.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBestCritiqueWeek.Name = "btnBestCritiqueWeek"
        Me.HelpProvider1.SetShowHelp(Me.btnBestCritiqueWeek, False)
        Me.btnBestCritiqueWeek.Size = New System.Drawing.Size(244, 57)
        Me.btnBestCritiqueWeek.TabIndex = 38
        Me.btnBestCritiqueWeek.Text = "Best # critique"
        Me.btnBestCritiqueWeek.ToolTip = "trier par ordre du plus grand nombre de critique"
        '
        'frmStatCritique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1472, 578)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmStatCritique"
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
    Friend WithEvents BtnBestCritique As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBestRating As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBestQualityDVDPOST As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBestQualityCustomers As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCBestCustomerWeek As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnBestQualityCustomersWeek As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBestQualityDvdpostWeek As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBestRatingWeek As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBestCritiqueWeek As DevExpress.XtraEditors.SimpleButton
End Class
