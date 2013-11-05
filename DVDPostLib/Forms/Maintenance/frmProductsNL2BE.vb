Public Class frmProductsNL2BE
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
    Friend WithEvents objDS As DVDPostLib.dsProducts
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabMulti As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDVD_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBarCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPrintSelected As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colproducts_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvdid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvd_status1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbDVDStatus2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colbox_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpibox_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbar_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintLabelsMulti As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintSelected2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintLabelsMulti2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtProducts_id_nl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProducts_id_be As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Picto As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.objDS = New DVDPostLib.dsProducts
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tabMulti = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colproducts_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvdid1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvd_status1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbDVDStatus2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colbox_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpibox_id1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbar_code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnPrintSelected2 = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrintLabelsMulti2 = New DevExpress.XtraEditors.SimpleButton
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrintSelected = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrintLabelsMulti = New DevExpress.XtraEditors.SimpleButton
        Me.txtDVD_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtProducts_id_nl = New DevExpress.XtraEditors.TextEdit
        Me.txtBarCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txtProducts_id_be = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Picto = New DevExpress.XtraEditors.LabelControl
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabMulti.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDVDStatus2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducts_id_nl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducts_id_be.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuickSearch_Bar
        '
        Me.QuickSearch_Bar.DockCol = 8
        '
        'Report_Bar
        '
        Me.Report_Bar.DockCol = 6
        '
        'Filter_Bar
        '
        Me.Filter_Bar.DockCol = 7
        '
        'DefaultSet_Bar
        '
        Me.DefaultSet_Bar.DockCol = 5
        '
        'Misc_Bar2
        '
        Me.Misc_Bar2.DockCol = 2
        '
        'Nav_Bar
        '
        Me.Nav_Bar.DockCol = 1
        '
        'Main_Bar
        '
        Me.Main_Bar.DockCol = 3
        '
        'Misc_Bar
        '
        Me.Misc_Bar.DockCol = 4
        '
        'View_Bar
        '
        Me.View_Bar.DockCol = 0
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsProducts"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 26)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabMulti
        Me.XtraTabControl1.Size = New System.Drawing.Size(1040, 348)
        Me.XtraTabControl1.TabIndex = 39
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabMulti})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'tabMulti
        '
        Me.tabMulti.Controls.Add(Me.GridControl2)
        Me.tabMulti.Controls.Add(Me.PanelControl1)
        Me.tabMulti.Name = "tabMulti"
        Me.tabMulti.Size = New System.Drawing.Size(1031, 317)
        Me.tabMulti.Text = "Scan Multiple"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.objDS.products_dvd_stock_2
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'GridControl2.EmbeddedNavigator
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(0, 104)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbDVDStatus2})
        Me.GridControl2.Size = New System.Drawing.Size(1031, 213)
        Me.GridControl2.TabIndex = 33
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colproducts_id1, Me.colproducts_dvdid1, Me.colproducts_dvd_status1, Me.colbox_id1, Me.colpibox_id1, Me.colbar_code})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(867, 345, 208, 191)
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'colproducts_id1
        '
        Me.colproducts_id1.Caption = "products_id"
        Me.colproducts_id1.FieldName = "products_id"
        Me.colproducts_id1.Name = "colproducts_id1"
        Me.colproducts_id1.Visible = True
        Me.colproducts_id1.VisibleIndex = 0
        '
        'colproducts_dvdid1
        '
        Me.colproducts_dvdid1.Caption = "products_dvdid"
        Me.colproducts_dvdid1.FieldName = "products_dvdid"
        Me.colproducts_dvdid1.Name = "colproducts_dvdid1"
        Me.colproducts_dvdid1.Visible = True
        Me.colproducts_dvdid1.VisibleIndex = 1
        '
        'colproducts_dvd_status1
        '
        Me.colproducts_dvd_status1.Caption = "products_dvd_status"
        Me.colproducts_dvd_status1.ColumnEdit = Me.cmbDVDStatus2
        Me.colproducts_dvd_status1.FieldName = "products_dvd_status"
        Me.colproducts_dvd_status1.Name = "colproducts_dvd_status1"
        Me.colproducts_dvd_status1.Visible = True
        Me.colproducts_dvd_status1.VisibleIndex = 2
        '
        'cmbDVDStatus2
        '
        Me.cmbDVDStatus2.AutoHeight = False
        Me.cmbDVDStatus2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDVDStatus2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvd_status_id", "products_dvd_status_id", 135, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvd_status_name", "products_dvd_status_name", 140, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbDVDStatus2.DataSource = Me.objDS.products_dvd_status
        Me.cmbDVDStatus2.DisplayMember = "products_dvd_status_name"
        Me.cmbDVDStatus2.Name = "cmbDVDStatus2"
        Me.cmbDVDStatus2.NullText = ""
        Me.cmbDVDStatus2.ValueMember = "products_dvd_status_id"
        '
        'colbox_id1
        '
        Me.colbox_id1.Caption = "box_id"
        Me.colbox_id1.FieldName = "box_id"
        Me.colbox_id1.Name = "colbox_id1"
        '
        'colpibox_id1
        '
        Me.colpibox_id1.Caption = "pibox_id"
        Me.colpibox_id1.FieldName = "pibox_id"
        Me.colpibox_id1.Name = "colpibox_id1"
        '
        'colbar_code
        '
        Me.colbar_code.Caption = "bar_code"
        Me.colbar_code.FieldName = "bar_code"
        Me.colbar_code.Name = "colbar_code"
        Me.colbar_code.Visible = True
        Me.colbar_code.VisibleIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Picto)
        Me.PanelControl1.Controls.Add(Me.txtProducts_id_be)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.btnPrintSelected2)
        Me.PanelControl1.Controls.Add(Me.btnPrintLabelsMulti2)
        Me.PanelControl1.Controls.Add(Me.btnAdd)
        Me.PanelControl1.Controls.Add(Me.btnClear)
        Me.PanelControl1.Controls.Add(Me.btnPrintSelected)
        Me.PanelControl1.Controls.Add(Me.btnPrintLabelsMulti)
        Me.PanelControl1.Controls.Add(Me.txtDVD_ID)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.txtProducts_id_nl)
        Me.PanelControl1.Controls.Add(Me.txtBarCode)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1031, 104)
        Me.PanelControl1.TabIndex = 0
        Me.PanelControl1.Text = "PanelControl1"
        '
        'btnPrintSelected2
        '
        Me.btnPrintSelected2.Location = New System.Drawing.Point(600, 40)
        Me.btnPrintSelected2.Name = "btnPrintSelected2"
        Me.btnPrintSelected2.Size = New System.Drawing.Size(96, 23)
        Me.btnPrintSelected2.TabIndex = 41
        Me.btnPrintSelected2.Text = "Print Selected 2"
        '
        'btnPrintLabelsMulti2
        '
        Me.btnPrintLabelsMulti2.Location = New System.Drawing.Point(600, 16)
        Me.btnPrintLabelsMulti2.Name = "btnPrintLabelsMulti2"
        Me.btnPrintLabelsMulti2.Size = New System.Drawing.Size(96, 23)
        Me.btnPrintLabelsMulti2.TabIndex = 40
        Me.btnPrintLabelsMulti2.Text = "Print ALL Labels 2"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(408, 40)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 39
        Me.btnAdd.Text = "Add"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(408, 16)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.TabIndex = 38
        Me.btnClear.Text = "Clear"
        '
        'btnPrintSelected
        '
        Me.btnPrintSelected.Location = New System.Drawing.Point(496, 40)
        Me.btnPrintSelected.Name = "btnPrintSelected"
        Me.btnPrintSelected.Size = New System.Drawing.Size(96, 23)
        Me.btnPrintSelected.TabIndex = 37
        Me.btnPrintSelected.Text = "Print Selected "
        '
        'btnPrintLabelsMulti
        '
        Me.btnPrintLabelsMulti.Location = New System.Drawing.Point(496, 16)
        Me.btnPrintLabelsMulti.Name = "btnPrintLabelsMulti"
        Me.btnPrintLabelsMulti.Size = New System.Drawing.Size(96, 23)
        Me.btnPrintLabelsMulti.TabIndex = 36
        Me.btnPrintLabelsMulti.Text = "Print ALL Labels"
        '
        'txtDVD_ID
        '
        Me.txtDVD_ID.Location = New System.Drawing.Point(304, 40)
        Me.txtDVD_ID.Name = "txtDVD_ID"
        Me.txtDVD_ID.Size = New System.Drawing.Size(96, 20)
        Me.txtDVD_ID.TabIndex = 35
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(224, 40)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.TabIndex = 34
        Me.LabelControl9.Text = "DVD ID"
        '
        'txtProducts_id_nl
        '
        Me.txtProducts_id_nl.Location = New System.Drawing.Point(96, 40)
        Me.txtProducts_id_nl.Name = "txtProducts_id_nl"
        Me.txtProducts_id_nl.Size = New System.Drawing.Size(96, 20)
        Me.txtProducts_id_nl.TabIndex = 33
        '
        'txtBarCode
        '
        Me.txtBarCode.Location = New System.Drawing.Point(96, 16)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(304, 20)
        Me.txtBarCode.TabIndex = 31
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(16, 16)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.TabIndex = 32
        Me.LabelControl10.Text = "BareCode"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(16, 40)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.TabIndex = 30
        Me.LabelControl11.Text = "Product ID NL"
        '
        'txtProducts_id_be
        '
        Me.txtProducts_id_be.Location = New System.Drawing.Point(96, 64)
        Me.txtProducts_id_be.Name = "txtProducts_id_be"
        Me.txtProducts_id_be.Size = New System.Drawing.Size(96, 20)
        Me.txtProducts_id_be.TabIndex = 43
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 64)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.TabIndex = 42
        Me.LabelControl1.Text = "Product ID BE"
        '
        'Picto
        '
        Me.Picto.Location = New System.Drawing.Point(216, 64)
        Me.Picto.Name = "Picto"
        Me.Picto.Size = New System.Drawing.Size(184, 16)
        Me.Picto.TabIndex = 44
        '
        'frmProductsNL2BE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 374)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmProductsNL2BE"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabMulti.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDVDStatus2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducts_id_nl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducts_id_be.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Private Sub frmProductsNL2BE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New dvdpostbuziness.contextMenu()
        GridControl2.ContextMenuStrip = menuStrip

        DvdPostData.clsConnection.ExecuteNonQuery("UPDATE products_dvd set last_admindate = '1801-01-01' where last_admindate = '0000-00-00'")
    End Sub


#Region "Multi-Scanning"
    Public Sub BarCode_OK()
        Dim _Products_id_NL As String
        Dim _Products_id_be As Integer
        Dim _StrProducts_id_be As String
        Dim DVD_ID As Integer
        Dim _OLDRow As DataRow
        Dim _NewRow As DataRow
        Dim _DS As New dsProducts
        Dim _isFrench As Boolean
        Dim _objProd As clsProduct_DVD

        Dim cls As New clsProduct_BarCode(txtBarCode.Text)
        If cls.IsBarCodeValid Then
            _Products_id_NL = cls.ProductID
            txtProducts_id_nl.Text = _Products_id_NL
            If Not IsNumeric(txtBarCode.Text.Substring(9, 3)) Then
                MsgBox("Use  SHIFT-Lock before scanning", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            DVD_ID = cls.DVDID
            txtDVD_ID.EditValue = DVD_ID
            'Find BE Products_ID
            _StrProducts_id_be = BKGlobal.ExecuteFindFieldValue("products_id_be", "SELECT products_id_be FROM tmp_products_nl where products_id_nl = " & _Products_id_NL)
            If Not IsNumeric(_StrProducts_id_be) Then
                Picto.Text = "No BE ID"
                Picto.BackColor = System.Drawing.Color.Red
                txtProducts_id_be.Text = ""
                txtBarCode.Text = ""
                txtBarCode.Refresh()
                Exit Sub
            Else
                _Products_id_be = CInt(_StrProducts_id_be)
            End If
            _objProd = New clsProduct_DVD(SessionInfo, _DS, _Products_id_be, 0)
            _isFrench = False
            If BKGlobal.ExecuteCount("select count(*) as cnt from products_to_languages where products_id = " & _Products_id_be & " and products_languages_id = 1") > 0 Then
                _isFrench = True
            End If
            If BKGlobal.ExecuteCount("select count(*) as cnt from products_to_undertitles where products_id = " & _Products_id_be & " and products_undertitles_id = 1") > 0 Then
                _isFrench = True
            End If
            If _isFrench = True Then
                Picto.Text = "French ON DVD"
                Picto.BackColor = System.Drawing.Color.Red
                txtProducts_id_be.EditValue = _Products_id_be
                txtBarCode.Text = ""
                txtBarCode.Refresh()
                Exit Sub
            Else

            End If
            Picto.Text = ""
            Picto.BackColor = System.Drawing.Color.Green
            txtProducts_id_be.EditValue = _Products_id_be
            DVD_ID = _objProd.AddNewDVD(1)
            Dim _SQLTxt As String = "SELECT PD.products_id, PD.products_dvdid, PD.products_dvd_status, PD.box_id, PD.pibox_id, P.products_model as products_model FROM products_dvd PD " & _
                        " Left join products P on P.products_id = PD.products_id " & _
                        " where PD.products_id = " & CInt(_Products_id_be) & " AND PD.products_dvdid = " & CInt(DVD_ID)
            DvdPostData.clsConnection.FillDataSet(_DS.Tables("products_dvd_stock_2"), _SQLTxt)
            _OLDRow = _DS.Tables("products_dvd_stock_2").Rows(0)
            _NewRow = objDS.Tables("products_dvd_stock_2").NewRow
            _NewRow("products_id") = _OLDRow("products_id")
            _NewRow("products_dvdid") = _OLDRow("products_dvdid")
            _NewRow("bar_code") = txtBarCode.EditValue
            _NewRow("products_dvd_status") = 0
            _NewRow("box_id") = 0
            _NewRow("pibox_id") = 0
            objDS.Tables("products_dvd_stock_2").Rows.Add(_NewRow)
            txtBarCode.Text = ""
            txtBarCode.Refresh()
        End If
    End Sub
    Private Sub txtBarCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBarCode.TextChanged
        BarCode_OK()
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        objDS.Tables("products_dvd_stock_2").Clear()
    End Sub
    Private Sub btnPrintLabelsMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintLabelsMulti.Click
        Dim _row, _labelRow As DataRow
        Dim _DS As New dsProducts
        Dim _objProducts As clsProduct_DVD

        For Each _row In objDS.Tables("products_dvd_stock_2").Rows
            _objProducts = New clsProduct_DVD(SessionInfo, _DS, _row("products_id"), _row("products_dvdid"))
            '_row("bar_code") = barcode(_row("products_id"), _row("products_dvdid"))
            _labelRow = _DS.Tables("products_labels").NewRow
            _labelRow("products_id") = _row("products_id")
            _labelRow("dvd_id") = _row("products_dvdid")
            _labelRow("IDStr") = _row("products_id") & "-" & _row("products_dvdid")
            _labelRow("bar_code") = _objProducts.BarCode.Barcode '_objProducts.barcode(_row("products_id"), _row("products_dvdid"))
            _labelRow("Lang") = _objProducts.GetProductLangLabel()
            _DS.Tables("products_labels").Rows.Add(_labelRow)
        Next
        Dim _rpt As New rptDVDLabel
        _rpt.objDS = _DS
        _rpt.DataMember = ""
        _rpt.DataSource = _DS.Tables("products_labels")
        _rpt.ShowPreview()
    End Sub
    Private Sub btnPrintSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSelected.Click
        Dim _row, _labelRow As DataRow
        Dim _DS As New dsProducts
        Dim _objProducts As clsProduct_DVD
        Dim _i As Integer
        For Each _i In GridView2.GetSelectedRows
            _row = GridView2.GetDataRow(_i)
            _objProducts = New clsProduct_DVD(SessionInfo, _DS, _row("products_id"), _i)
            _row = GridView2.GetDataRow(_i)
            '_row("bar_code") = barcode(_row("products_id"), _row("products_dvdid"))
            _labelRow = _DS.Tables("products_labels").NewRow
            _labelRow("products_id") = _row("products_id")
            _labelRow("dvd_id") = _row("products_dvdid")
            _labelRow("IDStr") = _row("products_id") & "-" & _row("products_dvdid")
            _labelRow("bar_code") = _objProducts.BarCode.Barcode  '_objProducts.barcode(_row("products_id"), _row("products_dvdid"))
            _labelRow("Lang") = _objProducts.GetProductLangLabel()
            _DS.Tables("products_labels").Rows.Add(_labelRow)
        Next
        Dim _rpt As New rptDVDLabel
        _rpt.objDS = _DS
        _rpt.DataMember = ""
        _rpt.DataSource = _DS.Tables("products_labels")
        _rpt.ShowPreview()

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Product_ID As String
        Dim DVD_ID As Integer
        Dim _OLDRow As DataRow
        Dim _NewRow As DataRow
        Dim _DS As New dsProducts
        Dim _view As DataView

        Product_ID = txtProducts_id_be.EditValue
        DVD_ID = txtDVD_ID.EditValue

        _view = New DataView(objDS.Tables("products_dvd_stock_2"), "products_id = " & CInt(Product_ID) & " aND products_dvdid = " & _
              CInt(DVD_ID), "", DataViewRowState.CurrentRows)
        If _view.Count > 0 Then Exit Sub
        Dim _SQLTxt As String = "SELECT PD.products_id, PD.products_dvdid, PD.products_dvd_status, PD.box_id, PD.pibox_id, P.products_model as products_model FROM products_dvd PD " & _
                    " Left join products P on P.products_id = PD.products_id " & _
                    " where PD.products_id = " & CInt(Product_ID) & " AND PD.products_dvdid = " & CInt(DVD_ID)
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("products_dvd_stock_2"), _SQLTxt)
        If _DS.Tables("products_dvd_stock_2").Rows.Count = 0 Then
            MsgBox("Cannot find this products")
            Exit Sub
        End If
        _OLDRow = _DS.Tables("products_dvd_stock_2").Rows(0)
        _NewRow = objDS.Tables("products_dvd_stock_2").NewRow
        '_NewRow.ItemArray = _OLDRow.ItemArray
        _NewRow("products_id") = _OLDRow("products_id")
        _NewRow("products_dvdid") = _OLDRow("products_dvdid")
        _NewRow("bar_code") = txtBarCode.EditValue
        _NewRow("products_dvd_status") = 0
        _NewRow("box_id") = 0
        _NewRow("pibox_id") = 0
        objDS.Tables("products_dvd_stock_2").Rows.Add(_NewRow)

    End Sub
#End Region

    Private Sub btnPrintLabelsMulti2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintLabelsMulti2.Click
        Dim _row, _labelRow As DataRow
        Dim _DS As New dsProducts
        Dim _objProducts As clsProduct_DVD
        For Each _row In objDS.Tables("products_dvd_stock_2").Rows
            _objProducts = New clsProduct_DVD(SessionInfo, _DS, _row("products_id"), _row("products_dvdid"))
            '_row("bar_code") = barcode(_row("products_id"), _row("products_dvdid"))
            _labelRow = _DS.Tables("products_labels").NewRow
            _labelRow("products_id") = _row("products_id")
            _labelRow("dvd_id") = _row("products_dvdid")
            _labelRow("IDStr") = _row("products_id") & "-" & _row("products_dvdid")
            _labelRow("bar_code") = _objProducts.BarCode.Barcode '_objProducts.barcode(_row("products_id"), _row("products_dvdid"))
            _labelRow("Lang") = _objProducts.GetProductLangLabel()
            _DS.Tables("products_labels").Rows.Add(_labelRow)
        Next
        Dim _rpt As New rptDVDLabel2
        _rpt.objDS = _DS
        _rpt.DataMember = ""
        _rpt.DataSource = _DS.Tables("products_labels")
        _rpt.ShowPreview()
    End Sub
    Private Sub btnPrintSelected2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSelected2.Click
        Dim _row, _labelRow As DataRow
        Dim _DS As New dsProducts
        Dim _objProducts As clsProduct_DVD
        Dim _i As Integer
        For Each _i In GridView2.GetSelectedRows
            _row = GridView2.GetDataRow(_i)
            _objProducts = New clsProduct_DVD(SessionInfo, _DS, _row("products_id"), _i)
            '_row("bar_code") = barcode(_row("products_id"), _row("products_dvdid"))
            _labelRow = _DS.Tables("products_labels").NewRow
            _labelRow("products_id") = _row("products_id")
            _labelRow("dvd_id") = _row("products_dvdid")
            _labelRow("IDStr") = _row("products_id") & "-" & _row("products_dvdid")
            _labelRow("bar_code") = _objProducts.BarCode.Barcode '_objProducts.barcode(_row("products_id"), _row("products_dvdid"))
            _labelRow("Lang") = _objProducts.GetProductLangLabel()
            _DS.Tables("products_labels").Rows.Add(_labelRow)
        Next
        Dim _rpt As New rptDVDLabel2
        _rpt.objDS = _DS
        _rpt.DataMember = ""
        _rpt.DataSource = _DS.Tables("products_labels")
        _rpt.ShowPreview()
    End Sub

End Class
