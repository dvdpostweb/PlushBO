
Public Class frmOgone_Browse
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnViewStateOgone As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOgone_Browse))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.BtnViewStateOgone = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
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
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabParameters.Controls.Add(Me.GroupControl1)
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
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.BtnViewStateOgone)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtToDate)
        Me.GroupControl1.Controls.Add(Me.txtFromDate)
        Me.GroupControl1.Name = "GroupControl1"
        Me.HelpProvider1.SetShowHelp(Me.GroupControl1, CType(resources.GetObject("GroupControl1.ShowHelp"), Boolean))
        '
        'BtnViewStateOgone
        '
        resources.ApplyResources(Me.BtnViewStateOgone, "BtnViewStateOgone")
        Me.BtnViewStateOgone.Name = "BtnViewStateOgone"
        Me.HelpProvider1.SetShowHelp(Me.BtnViewStateOgone, CType(resources.GetObject("BtnViewStateOgone.ShowHelp"), Boolean))
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, CType(resources.GetObject("LabelControl2.ShowHelp"), Boolean))
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, CType(resources.GetObject("LabelControl1.ShowHelp"), Boolean))
        '
        'txtToDate
        '
        Me.txtToDate.EditValue = Nothing
        resources.ApplyResources(Me.txtToDate, "txtToDate")
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtToDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtToDate, CType(resources.GetObject("txtToDate.ShowHelp"), Boolean))
        '
        'txtFromDate
        '
        Me.txtFromDate.EditValue = Nothing
        resources.ApplyResources(Me.txtFromDate, "txtFromDate")
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtFromDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtFromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtFromDate, CType(resources.GetObject("txtFromDate.ShowHelp"), Boolean))
        '
        'frmOgone_Browse
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmOgone_Browse"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
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
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New PlushBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "xx"
        MyBase.AutoLoadData = False
        objDS = New DataSet
        objDS.Tables.Add(MyBase.TableName)
        MyBase.StartUp()

        txtFromDate.DateTime = Now().ToString(txtFromDate.Properties.EditFormat.FormatString)
        txtToDate.DateTime = Now().ToString(txtFromDate.Properties.EditFormat.FormatString)

        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
        'btnOK
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If CurrentDefaultSetID <> 0 Then
            BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
            'LoadDataSet()
            TabControl1.SelectedTabPage = TabResult
        Else
            TabControl1.SelectedTabPage = TabParameters
        End If
    End Sub


    Private Sub loadData(ByVal sql As String)

        Dim dt As DataTable
        dt = PlushData.clsConnection.FillDataSet(sql)

        Grid1.DataSource = Nothing
        Grid1.Views(0).PopulateColumns()

        Grid1.DataSource = dt
        TabControl1.SelectedTabPage = TabResult

    End Sub

    Private Sub BtnViewStateOgone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewStateOgone.Click
        Dim sql As String
        sql = PlushData.ClsStatPayment.GetStatCustomersOgone(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)
    End Sub
End Class
