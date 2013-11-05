'Imports System.Web.Mail
Imports System.Net.Mail
Public Class frmEMail_IN_OUT
    Inherits BizzLib.frmBKForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnSendIN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents grpIN As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCpt_inError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCpt_inSend As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSendOUT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpOUT As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblCpt_outSend As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCpt_OutError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSendErrorIN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSendErrorOut As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnSendIN = New DevExpress.XtraEditors.SimpleButton
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.grpIN = New DevExpress.XtraEditors.GroupControl
        Me.btnSendErrorIN = New DevExpress.XtraEditors.SimpleButton
        Me.lblCpt_inError = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.lblCpt_inSend = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnSendOUT = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.grpOUT = New DevExpress.XtraEditors.GroupControl
        Me.btnSendErrorOut = New DevExpress.XtraEditors.SimpleButton
        Me.lblCpt_OutError = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.lblCpt_outSend = New DevExpress.XtraEditors.LabelControl
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpIN.SuspendLayout()
        CType(Me.grpOUT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOUT.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSendIN
        '
        Me.btnSendIN.Location = New System.Drawing.Point(16, 94)
        Me.btnSendIN.Name = "btnSendIN"
        Me.btnSendIN.Size = New System.Drawing.Size(75, 23)
        Me.btnSendIN.TabIndex = 4
        Me.btnSendIN.Text = "SEND"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(24, 186)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(472, 18)
        Me.ProgressBarControl1.TabIndex = 6
        '
        'grpIN
        '
        Me.grpIN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpIN.Controls.Add(Me.btnSendErrorIN)
        Me.grpIN.Controls.Add(Me.lblCpt_inError)
        Me.grpIN.Controls.Add(Me.LabelControl3)
        Me.grpIN.Controls.Add(Me.lblCpt_inSend)
        Me.grpIN.Controls.Add(Me.LabelControl1)
        Me.grpIN.Controls.Add(Me.btnSendIN)
        Me.grpIN.Location = New System.Drawing.Point(24, 40)
        Me.grpIN.Name = "grpIN"
        Me.grpIN.Size = New System.Drawing.Size(232, 127)
        Me.grpIN.TabIndex = 7
        Me.grpIN.Text = "E-Mails Process IN"
        '
        'btnSendErrorIN
        '
        Me.btnSendErrorIN.Location = New System.Drawing.Point(119, 94)
        Me.btnSendErrorIN.Name = "btnSendErrorIN"
        Me.btnSendErrorIN.Size = New System.Drawing.Size(75, 23)
        Me.btnSendErrorIN.TabIndex = 17
        Me.btnSendErrorIN.Text = "SEND ERROR"
        '
        'lblCpt_inError
        '
        Me.lblCpt_inError.Location = New System.Drawing.Point(103, 60)
        Me.lblCpt_inError.Name = "lblCpt_inError"
        Me.lblCpt_inError.Size = New System.Drawing.Size(6, 13)
        Me.lblCpt_inError.TabIndex = 16
        Me.lblCpt_inError.Text = "0"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 60)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "Error Send"
        '
        'lblCpt_inSend
        '
        Me.lblCpt_inSend.Location = New System.Drawing.Point(103, 32)
        Me.lblCpt_inSend.Name = "lblCpt_inSend"
        Me.lblCpt_inSend.Size = New System.Drawing.Size(6, 13)
        Me.lblCpt_inSend.TabIndex = 14
        Me.lblCpt_inSend.Text = "0"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "To Send"
        '
        'btnSendOUT
        '
        Me.btnSendOUT.Location = New System.Drawing.Point(16, 94)
        Me.btnSendOUT.Name = "btnSendOUT"
        Me.btnSendOUT.Size = New System.Drawing.Size(75, 23)
        Me.btnSendOUT.TabIndex = 4
        Me.btnSendOUT.Text = "SEND"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(16, 32)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl6.TabIndex = 12
        Me.LabelControl6.Text = "To Send"
        '
        'grpOUT
        '
        Me.grpOUT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpOUT.Controls.Add(Me.btnSendErrorOut)
        Me.grpOUT.Controls.Add(Me.lblCpt_OutError)
        Me.grpOUT.Controls.Add(Me.LabelControl5)
        Me.grpOUT.Controls.Add(Me.lblCpt_outSend)
        Me.grpOUT.Controls.Add(Me.LabelControl6)
        Me.grpOUT.Controls.Add(Me.btnSendOUT)
        Me.grpOUT.Location = New System.Drawing.Point(264, 40)
        Me.grpOUT.Name = "grpOUT"
        Me.grpOUT.Size = New System.Drawing.Size(232, 127)
        Me.grpOUT.TabIndex = 8
        Me.grpOUT.Text = "E-Mails Process OUT"
        '
        'btnSendErrorOut
        '
        Me.btnSendErrorOut.Location = New System.Drawing.Point(116, 94)
        Me.btnSendErrorOut.Name = "btnSendErrorOut"
        Me.btnSendErrorOut.Size = New System.Drawing.Size(75, 23)
        Me.btnSendErrorOut.TabIndex = 19
        Me.btnSendErrorOut.Text = "SEND ERROR"
        '
        'lblCpt_OutError
        '
        Me.lblCpt_OutError.Location = New System.Drawing.Point(103, 60)
        Me.lblCpt_OutError.Name = "lblCpt_OutError"
        Me.lblCpt_OutError.Size = New System.Drawing.Size(6, 13)
        Me.lblCpt_OutError.TabIndex = 18
        Me.lblCpt_OutError.Text = "0"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(16, 60)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl5.TabIndex = 17
        Me.LabelControl5.Text = "Error Send"
        '
        'lblCpt_outSend
        '
        Me.lblCpt_outSend.Location = New System.Drawing.Point(103, 32)
        Me.lblCpt_outSend.Name = "lblCpt_outSend"
        Me.lblCpt_outSend.Size = New System.Drawing.Size(6, 13)
        Me.lblCpt_outSend.TabIndex = 13
        Me.lblCpt_outSend.Text = "0"
        '
        'frmEMail_IN_OUT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 382)
        Me.Controls.Add(Me.grpOUT)
        Me.Controls.Add(Me.grpIN)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Name = "frmEMail_IN_OUT"
        Me.Controls.SetChildIndex(Me.ProgressBarControl1, 0)
        Me.Controls.SetChildIndex(Me.grpIN, 0)
        Me.Controls.SetChildIndex(Me.grpOUT, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpIN.ResumeLayout(False)
        Me.grpIN.PerformLayout()
        CType(Me.grpOUT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOUT.ResumeLayout(False)
        Me.grpOUT.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

  
    Public Sub frmEMail_IN_OUT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim cpt As Integer

        sql = DvdPostData.clsOdersStatusHistory.GetCptOrdersHistory(True)
        cpt = DvdPostData.clsConnection.ExecuteScalar(sql)
        lblCpt_inSend.Text = cpt


        btnSendIN.Enabled = cpt > 0


        sql = DvdPostData.clsOdersStatusHistory.GetCptOrdersHistory(False)
        cpt = DvdPostData.clsConnection.ExecuteScalar(sql)
        lblCpt_outSend.Text = cpt

        btnSendOUT.Enabled = cpt > 0


        sql = DvdPostData.clsOdersStatusHistory.GetCptOrdersHistory(True, True)
        cpt = DvdPostData.clsConnection.ExecuteScalar(sql)
        lblCpt_inError.Text = cpt

        btnSendErrorIN.Enabled = cpt > 0

        sql = DvdPostData.clsOdersStatusHistory.GetCptOrdersHistory(False, True)
        cpt = DvdPostData.clsConnection.ExecuteScalar(sql)
        lblCpt_OutError.Text = cpt

        btnSendErrorOut.Enabled = cpt > 0


    End Sub
    Public Sub btnSendIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendIN.Click
        'SendMail("In")
        SendMail(True)
    End Sub
    Public Sub btnSendOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendOUT.Click
        '  SendMail("Out")
        SendMail(False)
    End Sub
    Public Sub SendMail(ByVal isIn As Boolean, Optional ByVal isError As Boolean = False)
        Dim sql As String
        Dim dt As DataTable
        Dim mail_id As Integer
        Dim ok As Boolean
        Dim orders_id As Integer
        Dim cpt_error As Integer = 0

        sql = DvdPostData.clsOdersStatusHistory.GetListOrderHistory(isIn, isError)

        dt = DvdPostData.clsConnection.FillDataSet(sql)
        If dt.Rows.Count = 0 Then
            MsgBox("List Empty", MsgBoxStyle.Information)
            Return
        End If
        Dim ctrl_send As DevExpress.XtraEditors.LabelControl
        Dim ctrl_error As DevExpress.XtraEditors.LabelControl

        If isIn Then
            mail_id = DVDPostBuziness.clsMail.Mail.MAIL_IN
            ctrl_send = lblCpt_inSend
            ctrl_error = lblCpt_inError
        Else
            mail_id = DVDPostBuziness.clsMail.Mail.MAIL_OUT
            ctrl_send = lblCpt_outSend
            ctrl_error = lblCpt_OutError
        End If

        ProgressBarControl1.Properties.Maximum = dt.Rows.Count
        ProgressBarControl1.Properties.Minimum = 0


        For Each dr As DataRow In dt.Rows
            orders_id = dr("orders_id")
            ok = DVDPostBuziness.clsMail.SendMail(dr, mail_id)
            If Not ok Then
                cpt_error += 1
            Else
                sql = DvdPostData.clsOdersStatusHistory.UpdateNotified(orders_id, ok)
                DvdPostData.clsConnection.ExecuteNonQuery(sql)
            End If
         
            ProgressBarControl1.EditValue += 1
            ProgressBarControl1.Refresh()
        Next
        ctrl_send.Text = 0
        ctrl_error.Text = Integer.Parse(ctrl_error.Text) + cpt_error
        ProgressBarControl1.EditValue = 0
        MsgBox("Process Complete", MsgBoxStyle.Information)

    End Sub

    Private Sub btnErrorIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendErrorIN.Click
        SendMail(True, True)
    End Sub

    Private Sub btnErrorOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendErrorOut.Click
        SendMail(False, True)
    End Sub
End Class

