Imports System.Windows.Forms.Application
Public Class frmProductsDVDTracking
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
    Friend WithEvents txtBarCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProducts_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDVD_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnFindBarCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPIBoxID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBoxID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProductModel As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtBarCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtProducts_id = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtDVD_ID = New DevExpress.XtraEditors.TextEdit
        Me.btnFindBarCode = New DevExpress.XtraEditors.SimpleButton
        Me.btnOK1 = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtPIBoxID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtBoxID = New DevExpress.XtraEditors.TextEdit
        Me.Title = New DevExpress.XtraEditors.LabelControl
        Me.txtProductModel = New DevExpress.XtraEditors.TextEdit
        Me.Panel1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabChart.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.TabResult.SuspendLayout()
        Me.TabParameters.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPIBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Name = "Panel1"
        Me.HelpProvider1.SetShowHelp(Me.Panel1, False)
        Me.Panel1.Size = New System.Drawing.Size(776, 249)
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.Name = "TabControl1"
        Me.HelpProvider1.SetShowHelp(Me.TabControl1, False)
        Me.TabControl1.Size = New System.Drawing.Size(776, 249)
        '
        'GridView1
        '
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowBands = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 302)
        Me.StatusBar1.Name = "StatusBar1"
        Me.HelpProvider1.SetShowHelp(Me.StatusBar1, False)
        Me.StatusBar1.Size = New System.Drawing.Size(776, 24)
        '
        'Grid1
        '
        '
        'Grid1.EmbeddedNavigator
        '
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.HelpProvider1.SetShowHelp(Me.Grid1, False)
        Me.Grid1.Size = New System.Drawing.Size(767, 218)
        '
        'TabChart
        '
        Me.TabChart.Name = "TabChart"
        Me.TabChart.Size = New System.Drawing.Size(1095, 415)
        '
        'UcChart1
        '
        Me.UcChart1.Name = "UcChart1"
        Me.UcChart1.Size = New System.Drawing.Size(1095, 415)
        '
        'UcPivotGrid1
        '
        Me.UcPivotGrid1.Name = "UcPivotGrid1"
        Me.UcPivotGrid1.Size = New System.Drawing.Size(767, 218)
        '
        'TabAnalyse
        '
        Me.TabAnalyse.Name = "TabAnalyse"
        Me.TabAnalyse.Size = New System.Drawing.Size(767, 218)
        '
        'TabResult
        '
        Me.TabResult.Name = "TabResult"
        Me.TabResult.Size = New System.Drawing.Size(767, 218)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.Title)
        Me.TabParameters.Controls.Add(Me.txtProductModel)
        Me.TabParameters.Controls.Add(Me.txtPIBoxID)
        Me.TabParameters.Controls.Add(Me.LabelControl3)
        Me.TabParameters.Controls.Add(Me.LabelControl4)
        Me.TabParameters.Controls.Add(Me.txtBoxID)
        Me.TabParameters.Controls.Add(Me.btnFindBarCode)
        Me.TabParameters.Controls.Add(Me.btnOK1)
        Me.TabParameters.Controls.Add(Me.txtBarCode)
        Me.TabParameters.Controls.Add(Me.txtDVD_ID)
        Me.TabParameters.Controls.Add(Me.LabelControl1)
        Me.TabParameters.Controls.Add(Me.LabelControl5)
        Me.TabParameters.Controls.Add(Me.LabelControl2)
        Me.TabParameters.Controls.Add(Me.txtProducts_id)
        Me.TabParameters.Name = "TabParameters"
        Me.TabParameters.Size = New System.Drawing.Size(767, 218)
        '
        'View_Bar
        '
        Me.View_Bar.DockCol = 0
        '
        'Main_Bar
        '
        Me.Main_Bar.DockCol = 2
        '
        'Misc_Bar2
        '
        Me.Misc_Bar2.DockCol = 1
        '
        'Nav_Bar
        '
        Me.Nav_Bar.DockCol = 3
        '
        'QuickSearch_Bar
        '
        Me.QuickSearch_Bar.DockCol = 5
        '
        'Misc_Bar
        '
        Me.Misc_Bar.DockCol = 4
        '
        'Report_Bar
        '
        Me.Report_Bar.DockCol = 0
        '
        'Filter_Bar
        '
        Me.Filter_Bar.DockCol = 2
        '
        'txtBarCode
        '
        Me.txtBarCode.Location = New System.Drawing.Point(88, 16)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(304, 20)
        Me.txtBarCode.TabIndex = 37
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(8, 16)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.TabIndex = 39
        Me.LabelControl2.Text = "BareCode"
        '
        'txtProducts_id
        '
        Me.txtProducts_id.Enabled = False
        Me.txtProducts_id.Location = New System.Drawing.Point(88, 40)
        Me.txtProducts_id.Name = "txtProducts_id"
        '
        'txtProducts_id.Properties
        '
        Me.txtProducts_id.Properties.ReadOnly = True
        Me.txtProducts_id.Size = New System.Drawing.Size(96, 20)
        Me.txtProducts_id.TabIndex = 42
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.TabIndex = 41
        Me.LabelControl1.Text = "Product ID"
        '
        'txtDVD_ID
        '
        Me.txtDVD_ID.Enabled = False
        Me.txtDVD_ID.Location = New System.Drawing.Point(296, 40)
        Me.txtDVD_ID.Name = "txtDVD_ID"
        '
        'txtDVD_ID.Properties
        '
        Me.txtDVD_ID.Properties.ReadOnly = True
        Me.txtDVD_ID.Size = New System.Drawing.Size(96, 20)
        Me.txtDVD_ID.TabIndex = 44
        '
        'btnFindBarCode
        '
        Me.btnFindBarCode.Location = New System.Drawing.Point(416, 40)
        Me.btnFindBarCode.Name = "btnFindBarCode"
        Me.btnFindBarCode.Size = New System.Drawing.Size(104, 23)
        Me.btnFindBarCode.TabIndex = 38
        Me.btnFindBarCode.Text = "Find Bar Code"
        '
        'btnOK1
        '
        Me.btnOK1.Location = New System.Drawing.Point(416, 16)
        Me.btnOK1.Name = "btnOK1"
        Me.btnOK1.Size = New System.Drawing.Size(104, 23)
        Me.btnOK1.TabIndex = 40
        Me.btnOK1.Text = "OK"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(216, 40)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.TabIndex = 43
        Me.LabelControl5.Text = "DVD ID"
        '
        'txtPIBoxID
        '
        Me.txtPIBoxID.Enabled = False
        Me.txtPIBoxID.Location = New System.Drawing.Point(296, 64)
        Me.txtPIBoxID.Name = "txtPIBoxID"
        '
        'txtPIBoxID.Properties
        '
        Me.txtPIBoxID.Properties.ReadOnly = True
        Me.txtPIBoxID.Size = New System.Drawing.Size(96, 20)
        Me.txtPIBoxID.TabIndex = 48
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 64)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.TabIndex = 45
        Me.LabelControl3.Text = "Box ID"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(216, 64)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.TabIndex = 47
        Me.LabelControl4.Text = "PIBox ID"
        '
        'txtBoxID
        '
        Me.txtBoxID.Enabled = False
        Me.txtBoxID.Location = New System.Drawing.Point(88, 64)
        Me.txtBoxID.Name = "txtBoxID"
        '
        'txtBoxID.Properties
        '
        Me.txtBoxID.Properties.ReadOnly = True
        Me.txtBoxID.Size = New System.Drawing.Size(96, 20)
        Me.txtBoxID.TabIndex = 46
        '
        'Title
        '
        Me.Title.Location = New System.Drawing.Point(8, 88)
        Me.Title.Name = "Title"
        Me.Title.TabIndex = 49
        Me.Title.Text = "Title"
        '
        'txtProductModel
        '
        Me.txtProductModel.Enabled = False
        Me.txtProductModel.Location = New System.Drawing.Point(88, 88)
        Me.txtProductModel.Name = "txtProductModel"
        '
        'txtProductModel.Properties
        '
        Me.txtProductModel.Properties.ReadOnly = True
        Me.txtProductModel.Size = New System.Drawing.Size(304, 20)
        Me.txtProductModel.TabIndex = 50
        '
        'frmProductsDVDTracking
        '
        Me.AcceptButton = Me.btnOK1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(776, 326)
        Me.Name = "frmProductsDVDTracking"
        Me.HelpProvider1.SetShowHelp(Me, False)
        Me.Text = "frmProductsDVDTracking"
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabChart.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabResult.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPIBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New dvdpostbuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        objDS = New dsProducts
        objDS.Tables.Add("OrdersLocalView")
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "OrdersLocalView"
        MyBase.IDField = "orders_id"
        MyBase.NameField = "orders_id"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = False
        MyBase.StartUp()

        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
        'btnOK
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'If CurrentDefaultSetID <> 0 Then
        '    BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
        '    'LoadDataSet()
        '    TabControl1.SelectedTabPage = TabResult
        'Else
        TabAnalyse.Visible = False
        TabChart.Visible = False
        TabControl1.SelectedTabPage = TabParameters
        'End If
    End Sub

    Private Sub btnOK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK1.Click
        BarCode_OK()
    End Sub
    Public Sub BarCode_OK()
        Dim _DS As New dsProducts
        Dim _objProductDVD As clsProduct_DVD
        _objProductDVD = New clsProduct_DVD(SessionInfo, objDS, txtBarCode.Text)
        If Not _objProductDVD.BarCode.IsBarCodeValid Then
            MsgBox("Bar Code NON Valide", MsgBoxStyle.Critical)
            txtBarCode.Enabled = True
            Exit Sub
        End If
      
        _objProductDVD.Load_One_Products_DVD_Info()
        txtProducts_id.EditValue = _objProductDVD.ProductsID
        txtDVD_ID.EditValue = _objProductDVD.DvdId
        txtProductModel.EditValue = _objProductDVD.TableOfData.Rows(0)("products_model")
        txtBoxID.EditValue = _objProductDVD.Products_dvd_row("box_id")
        txtPIBoxID.EditValue = _objProductDVD.Products_dvd_row("pibox_id")
        objDS.Tables("OrdersLocalView").Clear()
        Dim _SQL As String = "select * " & _
            " from orders_products op " & _
            " left join orders o on op.orders_id = o.orders_id " & _
            " left join orders_status as os on os.orders_status_id = o.orders_Status and os.language_id = 1 " & _
            " where op.products_id = " & _objProductDVD.ProductsID & " AND op.products_dvd = " & _objProductDVD.DvdId & _
            " ORDER BY op.orders_id DESC "
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("OrdersLocalView"), _SQL)
        Grid1.DataSource = objDS.Tables("OrdersLocalView").DefaultView
        TabControl1.SelectedTabPage = TabResult
        txtBarCode.Text = ""
        txtBarCode.Enabled = True
        txtBarCode.Focus()
        DoEvents()
    End Sub
    Private Sub btnFindBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindBarCode.Click
        Dim _productsId As Integer
        Dim _dvdId As Integer
        Dim _objProdDVD As clsProduct_DVD
        txtBarCode.Text.Trim()
        If txtBarCode.Text.IndexOf("-") <> -1 Then
            _productsId = txtBarCode.Text.Substring(0, txtBarCode.Text.IndexOf("-"))
            _dvdId = txtBarCode.Text.Substring(txtBarCode.Text.IndexOf("-") + 1)
            _objProdDVD = New clsProduct_DVD(SessionInfo, objDS, _productsId, _dvdId)
            If _objProdDVD.BarCode.IsBarCodeValid Then
                txtBarCode.EditValue = _objProdDVD.BarCode.Barcode
                txtBarCode.Refresh()
            Else

            End If
        End If
    End Sub


End Class
