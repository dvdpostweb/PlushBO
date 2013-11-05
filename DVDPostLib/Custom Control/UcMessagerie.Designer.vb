<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcMessagerie
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
        Me.pnlTicketHistory = New DevExpress.XtraEditors.PanelControl
        Me.GCNewTicket = New DevExpress.XtraEditors.GroupControl
        Me.btnCancelTicket = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaveTicket = New DevExpress.XtraEditors.SimpleButton
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit
        Me.lblCategorie = New DevExpress.XtraEditors.LabelControl
        Me.cmbCategorieTicket = New DevExpress.XtraEditors.LookUpEdit
        Me.btnNewTicket = New DevExpress.XtraEditors.SimpleButton
        Me.BtnSend = New DevExpress.XtraEditors.SimpleButton
        Me.btnReply = New DevExpress.XtraEditors.SimpleButton
        Me.gridTicketHistory = New DevExpress.XtraGrid.GridControl
        Me.GridViewTicketHistory = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDateTicketHistory = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMessageTicketHistory = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCategorieTicketHistory = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCpt_MsgTicket_History = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCptMsgUnread = New DevExpress.XtraGrid.Columns.GridColumn
        Me.scrollMessageTicket = New DevExpress.XtraEditors.XtraScrollableControl
        CType(Me.pnlTicketHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTicketHistory.SuspendLayout()
        CType(Me.GCNewTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCNewTicket.SuspendLayout()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCategorieTicket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridTicketHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTicketHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTicketHistory
        '
        Me.pnlTicketHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.pnlTicketHistory.Controls.Add(Me.GCNewTicket)
        Me.pnlTicketHistory.Controls.Add(Me.btnNewTicket)
        Me.pnlTicketHistory.Controls.Add(Me.BtnSend)
        Me.pnlTicketHistory.Controls.Add(Me.btnReply)
        Me.pnlTicketHistory.Controls.Add(Me.gridTicketHistory)
        Me.pnlTicketHistory.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTicketHistory.Location = New System.Drawing.Point(0, 0)
        Me.pnlTicketHistory.Name = "pnlTicketHistory"
        Me.pnlTicketHistory.Size = New System.Drawing.Size(479, 612)
        Me.pnlTicketHistory.TabIndex = 1
        '
        'GCNewTicket
        '
        Me.GCNewTicket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCNewTicket.Controls.Add(Me.btnCancelTicket)
        Me.GCNewTicket.Controls.Add(Me.btnSaveTicket)
        Me.GCNewTicket.Controls.Add(Me.lblTitle)
        Me.GCNewTicket.Controls.Add(Me.txtTitle)
        Me.GCNewTicket.Controls.Add(Me.lblCategorie)
        Me.GCNewTicket.Controls.Add(Me.cmbCategorieTicket)
        Me.GCNewTicket.Location = New System.Drawing.Point(5, 42)
        Me.GCNewTicket.Name = "GCNewTicket"
        Me.GCNewTicket.Size = New System.Drawing.Size(469, 100)
        Me.GCNewTicket.TabIndex = 4
        Me.GCNewTicket.Text = "New Ticket"
        '
        'btnCancelTicket
        '
        Me.btnCancelTicket.Location = New System.Drawing.Point(350, 65)
        Me.btnCancelTicket.Name = "btnCancelTicket"
        Me.btnCancelTicket.Size = New System.Drawing.Size(114, 33)
        Me.btnCancelTicket.TabIndex = 6
        Me.btnCancelTicket.Text = "cancel"
        '
        'btnSaveTicket
        '
        Me.btnSaveTicket.Location = New System.Drawing.Point(350, 26)
        Me.btnSaveTicket.Name = "btnSaveTicket"
        Me.btnSaveTicket.Size = New System.Drawing.Size(114, 33)
        Me.btnSaveTicket.TabIndex = 5
        Me.btnSaveTicket.Text = "save"
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(5, 72)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(23, 16)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "titre"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(89, 65)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(145, 22)
        Me.txtTitle.TabIndex = 2
        '
        'lblCategorie
        '
        Me.lblCategorie.Location = New System.Drawing.Point(5, 40)
        Me.lblCategorie.Name = "lblCategorie"
        Me.lblCategorie.Size = New System.Drawing.Size(53, 16)
        Me.lblCategorie.TabIndex = 1
        Me.lblCategorie.Text = "categorie"
        '
        'cmbCategorieTicket
        '
        Me.cmbCategorieTicket.Location = New System.Drawing.Point(89, 37)
        Me.cmbCategorieTicket.Name = "cmbCategorieTicket"
        Me.cmbCategorieTicket.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCategorieTicket.Properties.NullText = ""
        Me.cmbCategorieTicket.Size = New System.Drawing.Size(145, 22)
        Me.cmbCategorieTicket.TabIndex = 0
        '
        'btnNewTicket
        '
        Me.btnNewTicket.Location = New System.Drawing.Point(5, 3)
        Me.btnNewTicket.Name = "btnNewTicket"
        Me.btnNewTicket.Size = New System.Drawing.Size(114, 33)
        Me.btnNewTicket.TabIndex = 3
        Me.btnNewTicket.Text = "new"
        '
        'BtnSend
        '
        Me.BtnSend.Location = New System.Drawing.Point(125, 3)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(114, 33)
        Me.BtnSend.TabIndex = 2
        Me.BtnSend.Text = "send"
        '
        'btnReply
        '
        Me.btnReply.Location = New System.Drawing.Point(245, 3)
        Me.btnReply.Name = "btnReply"
        Me.btnReply.Size = New System.Drawing.Size(114, 33)
        Me.btnReply.TabIndex = 1
        Me.btnReply.Text = "reply"
        '
        'gridTicketHistory
        '
        Me.gridTicketHistory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gridTicketHistory.EmbeddedNavigator.Name = ""
        Me.gridTicketHistory.FormsUseDefaultLookAndFeel = False
        Me.gridTicketHistory.Location = New System.Drawing.Point(2, 144)
        Me.gridTicketHistory.MainView = Me.GridViewTicketHistory
        Me.gridTicketHistory.Name = "gridTicketHistory"
        Me.gridTicketHistory.Size = New System.Drawing.Size(475, 466)
        Me.gridTicketHistory.TabIndex = 0
        Me.gridTicketHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTicketHistory})
        '
        'GridViewTicketHistory
        '
        Me.GridViewTicketHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDateTicketHistory, Me.colMessageTicketHistory, Me.colCategorieTicketHistory, Me.colCpt_MsgTicket_History, Me.colCptMsgUnread})
        Me.GridViewTicketHistory.GridControl = Me.gridTicketHistory
        Me.GridViewTicketHistory.Name = "GridViewTicketHistory"
        Me.GridViewTicketHistory.OptionsView.ShowFooter = True
        '
        'colDateTicketHistory
        '
        Me.colDateTicketHistory.Caption = "Date"
        Me.colDateTicketHistory.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.colDateTicketHistory.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDateTicketHistory.FieldName = "created_at"
        Me.colDateTicketHistory.Name = "colDateTicketHistory"
        Me.colDateTicketHistory.OptionsColumn.AllowEdit = False
        Me.colDateTicketHistory.Visible = True
        Me.colDateTicketHistory.VisibleIndex = 0
        Me.colDateTicketHistory.Width = 89
        '
        'colMessageTicketHistory
        '
        Me.colMessageTicketHistory.Caption = "titre"
        Me.colMessageTicketHistory.FieldName = "title"
        Me.colMessageTicketHistory.Name = "colMessageTicketHistory"
        Me.colMessageTicketHistory.OptionsColumn.AllowEdit = False
        Me.colMessageTicketHistory.Visible = True
        Me.colMessageTicketHistory.VisibleIndex = 1
        Me.colMessageTicketHistory.Width = 77
        '
        'colCategorieTicketHistory
        '
        Me.colCategorieTicketHistory.Caption = "categorie"
        Me.colCategorieTicketHistory.FieldName = "category_name"
        Me.colCategorieTicketHistory.Name = "colCategorieTicketHistory"
        Me.colCategorieTicketHistory.OptionsColumn.AllowEdit = False
        Me.colCategorieTicketHistory.Visible = True
        Me.colCategorieTicketHistory.VisibleIndex = 2
        Me.colCategorieTicketHistory.Width = 72
        '
        'colCpt_MsgTicket_History
        '
        Me.colCpt_MsgTicket_History.Caption = "Nb messages"
        Me.colCpt_MsgTicket_History.FieldName = "cpt_msg"
        Me.colCpt_MsgTicket_History.Name = "colCpt_MsgTicket_History"
        Me.colCpt_MsgTicket_History.Visible = True
        Me.colCpt_MsgTicket_History.VisibleIndex = 3
        Me.colCpt_MsgTicket_History.Width = 97
        '
        'colCptMsgUnread
        '
        Me.colCptMsgUnread.Caption = "non lu"
        Me.colCptMsgUnread.FieldName = "cpt_msg_unread"
        Me.colCptMsgUnread.Name = "colCptMsgUnread"
        Me.colCptMsgUnread.Visible = True
        Me.colCptMsgUnread.VisibleIndex = 4
        Me.colCptMsgUnread.Width = 119
        '
        'scrollMessageTicket
        '
        Me.scrollMessageTicket.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scrollMessageTicket.Appearance.BackColor = System.Drawing.Color.AliceBlue
        Me.scrollMessageTicket.Appearance.Options.UseBackColor = True
        Me.scrollMessageTicket.Location = New System.Drawing.Point(485, 0)
        Me.scrollMessageTicket.Name = "scrollMessageTicket"
        Me.scrollMessageTicket.Size = New System.Drawing.Size(576, 612)
        Me.scrollMessageTicket.TabIndex = 2
        '
        'UcMessagerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.scrollMessageTicket)
        Me.Controls.Add(Me.pnlTicketHistory)
        Me.Name = "UcMessagerie"
        Me.Size = New System.Drawing.Size(1061, 612)
        CType(Me.pnlTicketHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTicketHistory.ResumeLayout(False)
        CType(Me.GCNewTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCNewTicket.ResumeLayout(False)
        Me.GCNewTicket.PerformLayout()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCategorieTicket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridTicketHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTicketHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTicketHistory As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnNewTicket As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReply As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridTicketHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTicketHistory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDateTicketHistory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMessageTicketHistory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategorieTicketHistory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCpt_MsgTicket_History As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCptMsgUnread As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents scrollMessageTicket As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents GCNewTicket As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblCategorie As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbCategorieTicket As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnCancelTicket As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveTicket As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit

End Class
