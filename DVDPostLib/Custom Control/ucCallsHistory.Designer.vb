<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCallsHistory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnlCallQuestionnaire = New DevExpress.XtraEditors.PanelControl
        Me.btnFinish = New DevExpress.XtraEditors.SimpleButton
        Me.btnSuivant = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrec = New DevExpress.XtraEditors.SimpleButton
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl
        Me.rgCallDetail = New DevExpress.XtraEditors.RadioGroup
        Me.pnlCallData = New DevExpress.XtraEditors.PanelControl
        Me.memCallComment = New DevExpress.XtraEditors.MemoEdit
        Me.lblCallComment = New DevExpress.XtraEditors.LabelControl
        Me.lblcallContact = New DevExpress.XtraEditors.LabelControl
        Me.rgContact = New DevExpress.XtraEditors.RadioGroup
        Me.txtCallEndDate = New DevExpress.XtraEditors.TextEdit
        Me.lblCallEndDate = New DevExpress.XtraEditors.LabelControl
        Me.txtCallStartDate = New DevExpress.XtraEditors.TextEdit
        Me.lblCallStartDate = New DevExpress.XtraEditors.LabelControl
        Me.txtCallReconduction = New DevExpress.XtraEditors.TextEdit
        Me.lblCallReconduction = New DevExpress.XtraEditors.LabelControl
        Me.lblCallFt = New DevExpress.XtraEditors.LabelControl
        Me.chkCallFt = New DevExpress.XtraEditors.CheckEdit
        Me.txtCallCustomers_id = New DevExpress.XtraEditors.TextEdit
        Me.lblCallCustomers_id = New DevExpress.XtraEditors.LabelControl
        Me.btnCallNew = New DevExpress.XtraEditors.SimpleButton
        Me.pnlCallHistory = New System.Windows.Forms.Panel
        Me.GridCallHistory = New DevExpress.XtraGrid.GridControl
        Me.GridViewCallHistory = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDateStart = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEndStart = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.lblCallValues = New DevExpress.XtraEditors.LabelControl
        CType(Me.pnlCallQuestionnaire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCallQuestionnaire.SuspendLayout()
        CType(Me.rgCallDetail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlCallData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCallData.SuspendLayout()
        CType(Me.memCallComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgContact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCallEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCallStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCallReconduction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCallFt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCallCustomers_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCallHistory.SuspendLayout()
        CType(Me.GridCallHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCallHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCallQuestionnaire
        '
        Me.pnlCallQuestionnaire.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.pnlCallQuestionnaire.Controls.Add(Me.btnFinish)
        Me.pnlCallQuestionnaire.Controls.Add(Me.btnSuivant)
        Me.pnlCallQuestionnaire.Controls.Add(Me.btnPrec)
        Me.pnlCallQuestionnaire.Controls.Add(Me.lblTitle)
        Me.pnlCallQuestionnaire.Controls.Add(Me.rgCallDetail)
        Me.pnlCallQuestionnaire.Location = New System.Drawing.Point(794, 46)
        Me.pnlCallQuestionnaire.Name = "pnlCallQuestionnaire"
        Me.pnlCallQuestionnaire.Size = New System.Drawing.Size(454, 491)
        Me.pnlCallQuestionnaire.TabIndex = 3
        Me.pnlCallQuestionnaire.Visible = False
        '
        'btnFinish
        '
        Me.btnFinish.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinish.Location = New System.Drawing.Point(179, 387)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(91, 37)
        Me.btnFinish.TabIndex = 40
        Me.btnFinish.Text = "FIN"
        '
        'btnSuivant
        '
        Me.btnSuivant.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSuivant.Location = New System.Drawing.Point(365, 387)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(75, 37)
        Me.btnSuivant.TabIndex = 39
        Me.btnSuivant.Text = "suivant"
        '
        'btnPrec
        '
        Me.btnPrec.Location = New System.Drawing.Point(10, 387)
        Me.btnPrec.Name = "btnPrec"
        Me.btnPrec.Size = New System.Drawing.Size(84, 37)
        Me.btnPrec.TabIndex = 38
        Me.btnPrec.Text = "prec"
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(37, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(21, 16)
        Me.lblTitle.TabIndex = 37
        Me.lblTitle.Text = "title"
        '
        'rgCallDetail
        '
        Me.rgCallDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rgCallDetail.Location = New System.Drawing.Point(10, 53)
        Me.rgCallDetail.Name = "rgCallDetail"
        Me.rgCallDetail.Size = New System.Drawing.Size(430, 328)
        Me.rgCallDetail.TabIndex = 36
        '
        'pnlCallData
        '
        Me.pnlCallData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.pnlCallData.Controls.Add(Me.memCallComment)
        Me.pnlCallData.Controls.Add(Me.lblCallComment)
        Me.pnlCallData.Controls.Add(Me.lblcallContact)
        Me.pnlCallData.Controls.Add(Me.rgContact)
        Me.pnlCallData.Controls.Add(Me.txtCallEndDate)
        Me.pnlCallData.Controls.Add(Me.lblCallEndDate)
        Me.pnlCallData.Controls.Add(Me.txtCallStartDate)
        Me.pnlCallData.Controls.Add(Me.lblCallStartDate)
        Me.pnlCallData.Controls.Add(Me.txtCallReconduction)
        Me.pnlCallData.Controls.Add(Me.lblCallReconduction)
        Me.pnlCallData.Controls.Add(Me.lblCallFt)
        Me.pnlCallData.Controls.Add(Me.chkCallFt)
        Me.pnlCallData.Controls.Add(Me.txtCallCustomers_id)
        Me.pnlCallData.Controls.Add(Me.lblCallCustomers_id)
        Me.pnlCallData.Location = New System.Drawing.Point(447, 46)
        Me.pnlCallData.Name = "pnlCallData"
        Me.pnlCallData.Size = New System.Drawing.Size(341, 496)
        Me.pnlCallData.TabIndex = 2
        Me.pnlCallData.Visible = False
        '
        'memCallComment
        '
        Me.memCallComment.Location = New System.Drawing.Point(7, 293)
        Me.memCallComment.Name = "memCallComment"
        Me.memCallComment.Size = New System.Drawing.Size(329, 198)
        Me.memCallComment.TabIndex = 38
        '
        'lblCallComment
        '
        Me.lblCallComment.Location = New System.Drawing.Point(10, 271)
        Me.lblCallComment.Name = "lblCallComment"
        Me.lblCallComment.Size = New System.Drawing.Size(53, 16)
        Me.lblCallComment.TabIndex = 37
        Me.lblCallComment.Text = "comment"
        '
        'lblcallContact
        '
        Me.lblcallContact.Location = New System.Drawing.Point(7, 183)
        Me.lblcallContact.Name = "lblcallContact"
        Me.lblcallContact.Size = New System.Drawing.Size(41, 16)
        Me.lblcallContact.TabIndex = 36
        Me.lblcallContact.Text = "contact"
        '
        'rgContact
        '
        Me.rgContact.Location = New System.Drawing.Point(110, 183)
        Me.rgContact.Name = "rgContact"
        Me.rgContact.Size = New System.Drawing.Size(145, 96)
        Me.rgContact.TabIndex = 35
        '
        'txtCallEndDate
        '
        Me.txtCallEndDate.Enabled = False
        Me.txtCallEndDate.Location = New System.Drawing.Point(110, 146)
        Me.txtCallEndDate.Name = "txtCallEndDate"
        Me.txtCallEndDate.Properties.ReadOnly = True
        Me.txtCallEndDate.Size = New System.Drawing.Size(145, 22)
        Me.txtCallEndDate.TabIndex = 34
        '
        'lblCallEndDate
        '
        Me.lblCallEndDate.Location = New System.Drawing.Point(5, 149)
        Me.lblCallEndDate.Name = "lblCallEndDate"
        Me.lblCallEndDate.Size = New System.Drawing.Size(53, 16)
        Me.lblCallEndDate.TabIndex = 33
        Me.lblCallEndDate.Text = "end_date"
        '
        'txtCallStartDate
        '
        Me.txtCallStartDate.Enabled = False
        Me.txtCallStartDate.Location = New System.Drawing.Point(110, 109)
        Me.txtCallStartDate.Name = "txtCallStartDate"
        Me.txtCallStartDate.Properties.ReadOnly = True
        Me.txtCallStartDate.Size = New System.Drawing.Size(145, 22)
        Me.txtCallStartDate.TabIndex = 32
        '
        'lblCallStartDate
        '
        Me.lblCallStartDate.Location = New System.Drawing.Point(5, 112)
        Me.lblCallStartDate.Name = "lblCallStartDate"
        Me.lblCallStartDate.Size = New System.Drawing.Size(58, 16)
        Me.lblCallStartDate.TabIndex = 31
        Me.lblCallStartDate.Text = "start_date"
        '
        'txtCallReconduction
        '
        Me.txtCallReconduction.Enabled = False
        Me.txtCallReconduction.Location = New System.Drawing.Point(110, 75)
        Me.txtCallReconduction.Name = "txtCallReconduction"
        Me.txtCallReconduction.Properties.ReadOnly = True
        Me.txtCallReconduction.Size = New System.Drawing.Size(145, 22)
        Me.txtCallReconduction.TabIndex = 30
        '
        'lblCallReconduction
        '
        Me.lblCallReconduction.Location = New System.Drawing.Point(5, 78)
        Me.lblCallReconduction.Name = "lblCallReconduction"
        Me.lblCallReconduction.Size = New System.Drawing.Size(96, 16)
        Me.lblCallReconduction.TabIndex = 29
        Me.lblCallReconduction.Text = "Nb reconduction "
        '
        'lblCallFt
        '
        Me.lblCallFt.Location = New System.Drawing.Point(7, 53)
        Me.lblCallFt.Name = "lblCallFt"
        Me.lblCallFt.Size = New System.Drawing.Size(15, 16)
        Me.lblCallFt.TabIndex = 9
        Me.lblCallFt.Text = "FT"
        '
        'chkCallFt
        '
        Me.chkCallFt.Location = New System.Drawing.Point(108, 51)
        Me.chkCallFt.Name = "chkCallFt"
        Me.chkCallFt.Properties.Caption = ""
        Me.chkCallFt.Size = New System.Drawing.Size(147, 21)
        Me.chkCallFt.TabIndex = 8
        '
        'txtCallCustomers_id
        '
        Me.txtCallCustomers_id.Enabled = False
        Me.txtCallCustomers_id.Location = New System.Drawing.Point(110, 17)
        Me.txtCallCustomers_id.Name = "txtCallCustomers_id"
        Me.txtCallCustomers_id.Properties.ReadOnly = True
        Me.txtCallCustomers_id.Size = New System.Drawing.Size(145, 22)
        Me.txtCallCustomers_id.TabIndex = 7
        '
        'lblCallCustomers_id
        '
        Me.lblCallCustomers_id.Location = New System.Drawing.Point(7, 20)
        Me.lblCallCustomers_id.Name = "lblCallCustomers_id"
        Me.lblCallCustomers_id.Size = New System.Drawing.Size(71, 16)
        Me.lblCallCustomers_id.TabIndex = 6
        Me.lblCallCustomers_id.Text = "Customer ID"
        '
        'btnCallNew
        '
        Me.btnCallNew.Location = New System.Drawing.Point(447, 3)
        Me.btnCallNew.Name = "btnCallNew"
        Me.btnCallNew.Size = New System.Drawing.Size(130, 37)
        Me.btnCallNew.TabIndex = 41
        Me.btnCallNew.Text = "Appel"
        '
        'pnlCallHistory
        '
        Me.pnlCallHistory.Controls.Add(Me.GridCallHistory)
        Me.pnlCallHistory.Location = New System.Drawing.Point(3, 3)
        Me.pnlCallHistory.Name = "pnlCallHistory"
        Me.pnlCallHistory.Size = New System.Drawing.Size(438, 539)
        Me.pnlCallHistory.TabIndex = 42
        '
        'GridCallHistory
        '
        Me.GridCallHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCallHistory.EmbeddedNavigator.Name = ""
        Me.GridCallHistory.FormsUseDefaultLookAndFeel = False
        Me.GridCallHistory.Location = New System.Drawing.Point(0, 0)
        Me.GridCallHistory.MainView = Me.GridViewCallHistory
        Me.GridCallHistory.Name = "GridCallHistory"
        Me.GridCallHistory.Size = New System.Drawing.Size(438, 539)
        Me.GridCallHistory.TabIndex = 0
        Me.GridCallHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCallHistory, Me.GridView2})
        '
        'GridViewCallHistory
        '
        Me.GridViewCallHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDateStart, Me.colEndStart, Me.colUserName, Me.colComment})
        Me.GridViewCallHistory.GridControl = Me.GridCallHistory
        Me.GridViewCallHistory.Name = "GridViewCallHistory"
        Me.GridViewCallHistory.OptionsBehavior.Editable = False
        Me.GridViewCallHistory.OptionsView.ColumnAutoWidth = False
        '
        'colDateStart
        '
        Me.colDateStart.Caption = "start"
        Me.colDateStart.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.colDateStart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDateStart.FieldName = "start_date"
        Me.colDateStart.Name = "colDateStart"
        Me.colDateStart.OptionsColumn.AllowEdit = False
        Me.colDateStart.OptionsColumn.ReadOnly = True
        Me.colDateStart.Visible = True
        Me.colDateStart.VisibleIndex = 0
        Me.colDateStart.Width = 105
        '
        'colEndStart
        '
        Me.colEndStart.Caption = "End"
        Me.colEndStart.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.colEndStart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEndStart.FieldName = "end_date"
        Me.colEndStart.Name = "colEndStart"
        Me.colEndStart.OptionsColumn.AllowEdit = False
        Me.colEndStart.OptionsColumn.ReadOnly = True
        Me.colEndStart.Visible = True
        Me.colEndStart.VisibleIndex = 3
        Me.colEndStart.Width = 104
        '
        'colUserName
        '
        Me.colUserName.Caption = "user"
        Me.colUserName.FieldName = "FullName"
        Me.colUserName.Name = "colUserName"
        Me.colUserName.OptionsColumn.AllowEdit = False
        Me.colUserName.OptionsColumn.ReadOnly = True
        Me.colUserName.Visible = True
        Me.colUserName.VisibleIndex = 2
        Me.colUserName.Width = 100
        '
        'colComment
        '
        Me.colComment.Caption = "comment"
        Me.colComment.FieldName = "comment"
        Me.colComment.Name = "colComment"
        Me.colComment.OptionsColumn.AllowEdit = False
        Me.colComment.OptionsColumn.ReadOnly = True
        Me.colComment.ToolTip = "comment"
        Me.colComment.Visible = True
        Me.colComment.VisibleIndex = 1
        Me.colComment.Width = 145
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridCallHistory
        Me.GridView2.Name = "GridView2"
        '
        'lblCallValues
        '
        Me.lblCallValues.Location = New System.Drawing.Point(674, 14)
        Me.lblCallValues.Name = "lblCallValues"
        Me.lblCallValues.Size = New System.Drawing.Size(72, 16)
        Me.lblCallValues.TabIndex = 41
        Me.lblCallValues.Text = "lblCallValues"
        '
        'ucCallsHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblCallValues)
        Me.Controls.Add(Me.pnlCallHistory)
        Me.Controls.Add(Me.btnCallNew)
        Me.Controls.Add(Me.pnlCallQuestionnaire)
        Me.Controls.Add(Me.pnlCallData)
        Me.Name = "ucCallsHistory"
        Me.Size = New System.Drawing.Size(1274, 579)
        CType(Me.pnlCallQuestionnaire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCallQuestionnaire.ResumeLayout(False)
        Me.pnlCallQuestionnaire.PerformLayout()
        CType(Me.rgCallDetail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlCallData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCallData.ResumeLayout(False)
        Me.pnlCallData.PerformLayout()
        CType(Me.memCallComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgContact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCallEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCallStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCallReconduction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCallFt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCallCustomers_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCallHistory.ResumeLayout(False)
        CType(Me.GridCallHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCallHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlCallQuestionnaire As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnFinish As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSuivant As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgCallDetail As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents pnlCallData As DevExpress.XtraEditors.PanelControl
    Friend WithEvents memCallComment As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblCallComment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblcallContact As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgContact As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtCallEndDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCallEndDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCallStartDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCallStartDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCallReconduction As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCallReconduction As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCallFt As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkCallFt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCallCustomers_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCallCustomers_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCallNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlCallHistory As System.Windows.Forms.Panel
    Friend WithEvents GridCallHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCallHistory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblCallValues As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colDateStart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndStart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComment As DevExpress.XtraGrid.Columns.GridColumn

End Class
