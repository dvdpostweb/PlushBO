Public Class frmDiagFindProductID
    Inherits BizzLib.frmBKForm
    'System.Windows.Forms.Form

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
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbProductID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitleSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnOK1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents objds As DVDPostLib.dsProducts
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.cmbProductID = New DevExpress.XtraEditors.LookUpEdit
        Me.objds = New DVDPostLib.dsProducts
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleSearch = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.btnOK1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancel1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(408, 40)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search"
        '
        'cmbProductID
        '
        Me.cmbProductID.Location = New System.Drawing.Point(96, 88)
        Me.cmbProductID.Name = "cmbProductID"
        Me.cmbProductID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProductID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_id", "products_id", 75, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_name", "products_name", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_model", "products_model", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbProductID.Properties.DataSource = Me.objds.products_description1
        Me.cmbProductID.Properties.DisplayMember = "products_id"
        Me.cmbProductID.Properties.NullText = ""
        Me.cmbProductID.Properties.PopupWidth = 500
        Me.cmbProductID.Properties.ValueMember = "products_id"
        Me.cmbProductID.Size = New System.Drawing.Size(100, 20)
        Me.cmbProductID.TabIndex = 13
        '
        'objds
        '
        Me.objds.DataSetName = "dsProducts"
        Me.objds.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 88)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "Product ID"
        '
        'txtTitleSearch
        '
        Me.txtTitleSearch.Location = New System.Drawing.Point(96, 40)
        Me.txtTitleSearch.Name = "txtTitleSearch"
        Me.txtTitleSearch.Size = New System.Drawing.Size(304, 20)
        Me.txtTitleSearch.TabIndex = 11
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 40)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Title Like"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(96, 112)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Properties.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(304, 20)
        Me.txtTitle.TabIndex = 14
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 112)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "Title"
        '
        'btnOK1
        '
        Me.btnOK1.Location = New System.Drawing.Point(408, 112)
        Me.btnOK1.Name = "btnOK1"
        Me.btnOK1.Size = New System.Drawing.Size(75, 23)
        Me.btnOK1.TabIndex = 18
        Me.btnOK1.Text = "&Ok"
        '
        'btnCancel1
        '
        Me.btnCancel1.Location = New System.Drawing.Point(488, 112)
        Me.btnCancel1.Name = "btnCancel1"
        Me.btnCancel1.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel1.TabIndex = 19
        Me.btnCancel1.Text = "&Cancel"
        '
        'frmDiagFindProductID
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(570, 144)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel1)
        Me.Controls.Add(Me.btnOK1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cmbProductID)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtTitleSearch)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.LabelControl3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDiagFindProductID"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Product ID"
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.txtTitle, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.txtTitleSearch, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.cmbProductID, 0)
        Me.Controls.SetChildIndex(Me.btnSearch, 0)
        Me.Controls.SetChildIndex(Me.btnOK1, 0)
        Me.Controls.SetChildIndex(Me.btnCancel1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Products_ID As Integer

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'Dim _SQLTxt As String = "SELECT products_id, products_title, products_model FROM products where products_title like '%" & txtTitleSearch.EditValue & "%' "
        'objDS.Tables("products").Clear()
        ' DvdPostData.clsConnection.FillDataSet(objDS.Tables("products"), _SQLTxt)
        'cmbProductID.Focus()
        'cmbProductID.ShowPopup()
        Dim _SQLTxt As String = "SELECT PD.products_id, PD.language_id, PD.products_name , P.products_model as products_model FROM products_description PD " & _
                                " Left join products P on P.products_id = PD.products_id " & _
                                " where products_name like '%" & txtTitleSearch.EditValue & "%'  "
        objDS.Tables("products_description1").Clear()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_description1"), _SQLTxt)
        cmbProductID.Focus()
        cmbProductID.ShowPopup()
    End Sub
    Private Sub cmbProductID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductID.EditValueChanged
        RefreshDVDInfo()
    End Sub
    Private Sub RefreshDVDInfo()
        Dim _PRow As DataRow
        Dim _SQLTxt As String
        '_row = objDS.Tables("products_description1").Rows.Find(New Object() {cmbProductID.EditValue})
        Products_ID = cmbProductID.EditValue
        _SQLTxt = "SELECT products_id, products_title, products_model, products_quantity, quantity_to_sale, " & _
                  " products_sale_price, if (products_sale_date = '0000-00-00', Null, products_sale_date) as products_sale_date " & _
                  " FROM products where products_id = " & cmbProductID.EditValue
        objDS.Tables("products_combo").Clear()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_combo"), _SQLTxt)
        If objDS.Tables("products_combo").Rows.Count = 1 Then
            _PRow = objDS.Tables("products_combo").Rows(0)
        Else
            _PRow = Nothing
        End If
        If Not IsNothing(_PRow) Then
            txtTitle.EditValue = _PRow("products_title")
        End If
        _SQLTxt = "SELECT products_id, products_dvdid, products_dvd_status, cover_box_id, `inout`, nbr_rotation_in_feesharing, box_id, pibox_id, last_adminby, " & _
                  " if (dvd_buy_date = '0000-00-00', Null, dvd_buy_date) as dvd_buy_date, " & _
                  " if (date_lastrented = '0000-00-00', Null, date_lastrented) as date_lastrented, " & _
                  " if (last_admindate = '0000-00-00', Null, last_admindate) as last_admindate " & _
                  " FROM products_dvd where products_id = " & cmbProductID.EditValue & _
                  " ORDER BY products_dvd_status, products_dvdid "  ' & " AND ( cover_box_id is null or cover_box_id = '' )"

        objDS.Tables("products_dvd").Clear()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_dvd"), _SQLTxt)
    End Sub

    Private Sub btnOK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub btnCancel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel1.Click
        Me.Hide()
    End Sub

    Private Sub frmDiagFindProductID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
