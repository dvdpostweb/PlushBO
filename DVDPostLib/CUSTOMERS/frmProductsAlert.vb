Public Class frmProductsAlert
    Inherits BizzLib.frmBKForm
    Private Sub frmProductsAlert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New PlushBuziness.contextMenu()
        GridProductsAlert.ContextMenuStrip = menuStrip
        loadProductsAlert()
    End Sub


    Private Sub loadProductsAlert()
        Dim dt As DataTable
        Dim sql As String

        If CheckDelete.Checked Then
            sql = PlushData.clsProductsAlert.getProductsAlert(PlushData.clsProductsAlert.checkStatus.CHECKED)
        Else
            sql = PlushData.clsProductsAlert.getProductsAlert(PlushData.clsProductsAlert.checkStatus.NOT_CHECKED)
        End If

        dt = PlushData.clsConnection.FillDataSet(sql)
        GridProductsAlert.DataSource = dt

    End Sub

    Private Sub btnAddProductsAlert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProductsAlert.Click
        Dim products_id As Integer
        Dim products_dvdid As Integer
        Dim comment As String
        Dim sql As String
        Dim cnt As Integer
        Dim dt As DataTable
        Dim dr As DataRow



        products_id = txtProductsId.EditValue
        If txtProductsDvdId.EditValue Is String.Empty Then
            products_dvdid = 0
        Else
            products_dvdid = txtProductsDvdId.EditValue
        End If

        sql = PlushData.clsProductsAlert.getProductsAlert(products_id, products_dvdid)
        dt = PlushData.clsConnection.FillDataSet(sql)

        If dt.Rows.Count > 0 Then
            MsgBox("An alert a deja ete creer pour ce dvd !!", MsgBoxStyle.Critical)
            Return
        End If
        If memoAddComment.EditValue = "" Then
            MsgBox("Add a comment to identify the alert please!!")
            Return
        End If
        comment = replaceString(memoAddComment.EditValue)

        sql = PlushData.clsProductDvd.GetSelectWhereStatusProducts(products_id, products_dvdid)
        dt = PlushData.clsConnection.FillDataSet(sql)
        If dt.Rows.Count = 0 Then
            MsgBox("The product not exist ", MsgBoxStyle.Critical)
            Return
        End If
        dr = dt.Rows(0)
        If dr("inout") = 0 Or dr("box_id") < 0 Then
            sql = PlushData.clsProductsAlert.insertProductsAlert(products_id, products_dvdid, comment)
            cnt = PlushData.clsConnection.ExecuteNonQuery(sql)

            If cnt = 0 Then
                MsgBox("The products is not insert ", MsgBoxStyle.Critical)
            End If

            loadProductsAlert()
            EmptyField()
        Else

            MsgBox("The DVD is in Stock( box_id : " & dr("box_id") & "/" & dr("pibox_id") & " status : " & dr("products_dvd_status_name") & ") !! impossible to create alert ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Function replaceString(ByVal str As String) As String
        str = Replace(str, "'", "\'")
        str = Replace(str, "´", "\´")
        str = Replace(str, "`", "\")
        Return str
    End Function

    Private Sub DeleteAlert(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleted.Click
        Dim sql As String
        Dim cpt As Integer
        Dim alertId As Integer

        If GridViewProductsAlert.RowCount <> 0 Then
            alertId = GridViewProductsAlert.GetDataRow(GridViewProductsAlert.FocusedRowHandle)("alert_id")
            sql = PlushData.clsProductsAlert.UpdateCheckStatus(alertId, PlushData.clsProductsAlert.checkStatus.CHECKED)

            cpt = PlushData.clsConnection.ExecuteNonQuery(sql)
            If cpt <> 1 Then
                MsgBox("there are not update on the produscts_alert", MsgBoxStyle.Exclamation)
            End If

            loadProductsAlert()
            EmptyField()
        End If

    End Sub

    Private Sub GridViewProductsAlert_FocusedRowHandle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewProductsAlert.FocusedRowChanged 'grpContEmail.DoubleClick
        If GridViewProductsAlert.RowCount <> 0 Then
            MemoSeeComment.Text = GridViewProductsAlert.GetDataRow(GridViewProductsAlert.FocusedRowHandle)("alert_comment").ToString()
        Else
            EmptyField()
        End If
    End Sub

    Private Sub EmptyField()
        memoAddComment.Text = String.Empty
        MemoSeeComment.Text = String.Empty
        txtProductsDvdId.Text = String.Empty
        txtProductsId.Text = String.Empty
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        loadProductsAlert()
    End Sub
End Class