Imports DevExpress.XtraGrid.Views.Grid
Imports PlushData
Public Class frmPaymentOffLineSummary
    Inherits BizzLib.frmGeneral_Browse

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
    Friend WithEvents chkdetails As DevExpress.XtraEditors.CheckEdit

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentOffLineSummary))
        Me.chkdetails = New DevExpress.XtraEditors.CheckEdit
        Me.Panel1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.TabChart.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkdetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        resources.ApplyResources(Me.StatusBar1, "StatusBar1")
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.SelectedTabPage = Me.TabResult
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        '
        'TabParameters
        '
        resources.ApplyResources(Me.TabParameters, "TabParameters")
        '
        'TabResult
        '
        resources.ApplyResources(Me.TabResult, "TabResult")
        '
        'TabAnalyse
        '
        resources.ApplyResources(Me.TabAnalyse, "TabAnalyse")
        '
        'UcPivotGrid1
        '
        resources.ApplyResources(Me.UcPivotGrid1, "UcPivotGrid1")
        '
        'UcChart1
        '
        resources.ApplyResources(Me.UcChart1, "UcChart1")
        '
        'TabChart
        '
        resources.ApplyResources(Me.TabChart, "TabChart")
        '
        'chkdetails
        '
        resources.ApplyResources(Me.chkdetails, "chkdetails")
        Me.chkdetails.Name = "chkdetails"
        Me.chkdetails.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.chkdetails.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.chkdetails.Properties.Appearance.Options.UseBackColor = True
        Me.chkdetails.Properties.Appearance.Options.UseForeColor = True
        Me.chkdetails.Properties.Caption = resources.GetString("chkdetails.Properties.Caption")
        '
        'frmPaymentOffLineSummary
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.chkdetails)
        Me.Name = "frmPaymentOffLineSummary"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.Controls.SetChildIndex(Me.chkdetails, 0)
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabChart.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkdetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _OffLinePay As PlushBuziness.clsOffLinePayments
    Dim WithEvents _grid1 As DevExpress.XtraGrid.GridControl = Grid1
    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New PlushBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip



        objDS = New dsCompta
        TabParameters.PageVisible = False
        CanNew = False
        CanEdit = False
        MyBase.TableName = "Offline_Payment_Recovery_Flow"
        '  MyBase.IDField = "status_id"
        '  MyBase.NameField = "status_id"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = True
        MyBase.StartUp()


        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser1.Caption = "Process Transitions"
        btnUser2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser2.Caption = "Mail"
        btnUser3.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser3.Caption = "Mail2"
        btnUser4.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser4.Caption = "Letter 1"
        btnUser5.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser5.Caption = "Letter Avocat"


        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If CurrentDefaultSetID <> 0 Then
            BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
        End If

        TabControl1.SelectedTabPage = TabResult


        _OffLinePay = New PlushBuziness.clsOffLinePayments()

        '_OffLinePay.ApplyAllTransitions()
        '   DVDPostBuziness.clsOffLinePayments.matchingOffline()
        LoadDataSet()

    End Sub

    Private Sub Grid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _grid1.DoubleClick

        Dim parameter As PlushBuziness.clsSingleton = PlushBuziness.clsSingleton.Instance()

        If GridView1 Is Nothing Or GridView1.SelectedRowsCount = 0 Then
            Return
        End If
        Dim row As System.Data.DataRow
        row = GridView1.GetDataRow(GridView1.GetSelectedRows()(0))
        Dim stepOffline As Integer = row(1)
        If stepOffline >= 0 Then
            parameter.TypeStepPaymentOffline = stepOffline
            parameter.StrTypeStepPaymentOffline = row(2)
            parameter.isSummary = Not chkdetails.Checked
            BKGlobal.StartMenuForm(PlushBuziness.clsOffLinePayments.IdFormStep.FRM_STEP, Me.ParentForm)

        End If
    End Sub

    ''Private Sub txtLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimit.TextChanged
    '    _Limit = "limit 0, " & txtLimit.Text
    'End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub

    Public Overrides Sub LoadDataSet()
        ' Dim _SQLTxt As String
        'Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue)
        'Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue)

        objDS.Tables(TableName).Clear()

        PlushData.clsConnection.FillDataSet(objDS.Tables(TableName), PlushData.PaymentOfflineData.GetSummary(PlushBuziness.clsOffLinePayments.CLASS_STATUS))


        Grid1.DataSource = objDS.Tables(TableName)
        TabControl1.SelectedTabPage = TabResult
    End Sub
    Public Sub ProcessTransition(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick

        _OffLinePay.ApplyAllTransitions()
        LoadDataSet()
    End Sub
    Public Sub TO_Mail(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser2.ItemClick
        '_OffLinePay.SendMail(PaymentOfflineData.StepPayment.MAIL_TO_SEND, PlushBuziness.clsMail.Mail.MAIL_RECOVERY)
        'LoadDataSet()
    End Sub
    Public Sub TO_Mail2(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser3.ItemClick
        '_OffLinePay.SendMail(PaymentOfflineData.StepPayment.MAIL2_TO_SEND, PlushBuziness.clsMail.Mail.MAIL2_RECOVERY)
        'LoadDataSet()
    End Sub
    Public Sub TO_Letter(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser4.ItemClick
        '_OffLinePay.sendLetter(PaymentOfflineData.TypeSend.LETTER, PaymentOfflineData.StepPayment.LETTER_TO_SEND)
        'LoadDataSet()
    End Sub
    Public Sub TO_LetterAvocat(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser5.ItemClick
        _OffLinePay.sendLetter(PaymentOfflineData.TypeSend.LETTER_AVOCAT, PaymentOfflineData.StepPayment.LETTER_AVOCAT_TO_SEND)
        LoadDataSet()
    End Sub
End Class
