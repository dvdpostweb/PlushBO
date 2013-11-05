Imports System.Collections.Generic

Public Class frmProductsThemes
    Inherits BizzLib.frmBKForm

    Private _sql As String
    Private _dt As DataTable


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Dim menuStrip As New PlushBuziness.contextMenu()
        gridListedProducts.ContextMenuStrip = menuStrip


        ' Add any initialization after the InitializeComponent() call.

    End Sub
#Region "Load Data"


    Private Sub LoadData(ByVal id As Integer)


        _sql = PlushData.clsProductsThemes.getSelectProductsTheme(id)
        _dt = PlushData.clsConnection.FillDataSet(_sql)
        Dim dv As DataView

        dv = _dt.DefaultView()
        dv.Sort = "order"
        gridListedProducts.DataSource = dv

    End Sub
    Private Sub loadTheme()
        Dim sql As String
        Dim dt As DataTable
        If cmbLanguage.EditValue Is Nothing Or cmbKind.EditValue Is Nothing Then Return
        sql = PlushData.clsProductsThemes.getSelectThemesCategories(cmbLanguage.EditValue, cmbKind.EditValue)
        dt = PlushData.clsConnection.FillDataSet(sql)

        cmbThemeTop.Properties.ValueMember = "id"
        cmbThemeTop.Properties.DisplayMember = "name"
        cmbThemeTop.Properties.DataSource = dt

    End Sub
    Private Sub loadLanguage()
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.ClsVod.GetLanguage()
        dt = PlushData.clsConnection.FillDataSet(sql)

        cmbLanguage.Properties.ValueMember = "id"
        cmbLanguage.Properties.DisplayMember = "code"
        cmbLanguage.Properties.DataSource = dt

    End Sub
    Private Sub loadKind()
        Dim lstKind As List(Of PlushBuziness.clsKeyComboEnum)
        Dim sql As String

        sql = PlushData.clsThemeTop.GetEnumMysqlKind()
        lstKind = PlushBuziness.ClsCombo.GetListEnum(sql)

        lstKind.Add(New PlushBuziness.clsKeyComboEnum("", ""))
        cmbKind.Properties.ValueMember = "Value"
        cmbKind.Properties.DisplayMember = "DisplayMember"
        cmbKind.Properties.DataSource = lstKind



    End Sub

#End Region

    Private Sub frmProductsThemes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadLanguage()
        loadKind()

    End Sub

    Private Sub saveData()
        Me.BindingContext(_dt.DefaultView).EndCurrentEdit()
        _dt.Columns.Remove("products_name")
        PlushData.clsConnection.UpdateDataTableInDB(_dt, _sql)
        LoadData(cmbThemeTop.EditValue)
    End Sub


    Private Sub gridViewListedProducts_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridViewListedProducts.CellValueChanged
        ' saveData()
    End Sub

    Private Sub gridViewListedProducts_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gridViewListedProducts.ValidateRow
        'saveData()
    End Sub

    Private Sub cmbLanguage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLanguage.EditValueChanged
        loadTheme()
    End Sub

    Private Sub cmbKind_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKind.EditValueChanged
        loadTheme()
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        LoadData(cmbThemeTop.EditValue)
    End Sub
#Region "Search Product Maintenance"
    Public Sub SearchProducts()
        Dim _SQLTxt As String
        Dim searchTitle As String = String.Empty
        Dim searchImdb As String = String.Empty
        Dim searchProduct As String = String.Empty
        Dim dt As DataTable

        If Not txtSearchProduct_id.EditValue Is Nothing AndAlso txtSearchProduct_id.EditValue <> "" Then
            searchProduct = " and P.products_id = " & txtSearchProduct_id.Text.Trim
        End If

        If Not txtTitleSearch.EditValue Is Nothing AndAlso txtTitleSearch.EditValue <> "" Then
            searchTitle = " and products_name like '%" & txtTitleSearch.Text.Trim & "%'"
        End If

        If Not txtSearchImdb_id.EditValue Is Nothing AndAlso txtSearchImdb_id.EditValue <> "" Then
            searchImdb = " and imdb_id = " & txtSearchImdb_id.Text.Trim
        End If

        _SQLTxt = " SELECT PD.products_id, PD.products_name , P.products_model as products_model " & _
                  " FROM ( select PD.products_id, PD.products_name from products_description PD where PD.language_id = 1 group by PD.products_id) PD" & _
                  " left join  products P on P.products_id = PD.products_id  " & _
                  " where 1 = 1" & searchTitle & searchImdb & searchProduct
        dt = PlushData.clsConnection.FillDataSet(_SQLTxt)
        GridProductsDVD.DataSource = dt
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchProducts()
    End Sub

#End Region
    Private Sub MoveUpDown(ByVal indexCurrent As Integer, ByVal IndexCompare As Integer)

        Dim drCurrent As DataRow
        Dim drCompare As DataRow
        drCurrent = gridViewListedProducts.GetDataRow(indexCurrent)
        drCompare = gridViewListedProducts.GetDataRow(IndexCompare)

        drCurrent("order") = indexCurrent + 1
        drCompare("order") = IndexCompare + 1

        PlushBuziness.clsProductsThemes.SwitchOrder(drCurrent, drCompare)

    End Sub

    Private Sub BtnOrderUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOrderUp.Click

        Dim idCurrent As Integer = gridViewListedProducts.FocusedRowHandle
        If idCurrent > 0 Then
            MoveUpDown(idCurrent, idCurrent - 1)
            Me.BindingContext(_dt).Position = idCurrent - 1
            gridListedProducts.RefreshDataSource()
        End If
    End Sub

    Private Sub BtnOrderDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOrderDown.Click
        Dim idCurrent As Integer = gridViewListedProducts.FocusedRowHandle
        If idCurrent < gridViewListedProducts.RowCount - 1 Then
            MoveUpDown(idCurrent, idCurrent + 1)
            Me.BindingContext(_dt).Position = idCurrent + 1
            gridListedProducts.RefreshDataSource()
        End If
    End Sub

    Private Sub RemoveProduct(ByVal idcurrent As Integer)
        Dim drCurrent As DataRow
        drCurrent = gridViewListedProducts.GetDataRow(idcurrent)
        PlushBuziness.clsProductsThemes.DeleteProduct(drCurrent("id"))
        LoadData(cmbThemeTop.EditValue)
    End Sub

    Private Sub AddProduct(ByVal IndexProduct As Integer)

        Dim drProduct As DataRow


        Dim product_id As Integer
        Dim list_product_id As Integer
        Dim order As Integer


        If IndexProduct >= 0 Then
            drProduct = GridViewProductsDVD.GetDataRow(IndexProduct)
            product_id = drProduct("products_id")
            list_product_id = cmbThemeTop.EditValue
            order = gridViewListedProducts.RowCount
            PlushBuziness.clsProductsThemes.InsertProduct(list_product_id, product_id, order)
            LoadData(cmbThemeTop.EditValue)
        End If
    End Sub

    Private Sub BtnRemoveProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveProduct.Click

        Dim idCurrent As Integer = gridViewListedProducts.FocusedRowHandle
        RemoveProduct(idCurrent)

    End Sub

    Private Sub BtnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddProduct.Click
        Dim indexProduct As Integer = GridViewProductsDVD.FocusedRowHandle
        AddProduct(indexProduct)
    End Sub
End Class