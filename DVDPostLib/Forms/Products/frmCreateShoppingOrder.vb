Public Class frmCreateShoppingOrder

    Private Sub btnShoppingOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShoppingOrder.Click
        Dim _SQLTxt As String
        Dim _Res As Integer
        If txtCustomerID.EditValue & "" = "" Then
            MsgBox("Customer ID cannot be blank", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txtProductID.EditValue & "" = "" Then
            MsgBox("Product ID cannot be blank", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txtQty.EditValue < 1 Then
            MsgBox("Qty must be greater than 0", MsgBoxStyle.Critical)
            Exit Sub
        End If
        _SQLTxt = "insert into shopping_orders values(Null, " & txtCustomerID.EditValue & _
                  ", now(), " & txtProductID.EditValue & " , " & txtQty.EditValue & ",1,0, '" & txtPrice.EditValue & "',0, '" & txtProductType.Text & "', '" & cmbState.Text & "')"
        _Res = DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        If _Res <> 1 Then
            MsgBox("La commande n'a pas été crée. Il y a eu un probleme!")
        Else
            'Decrease Qty To Sale 
            _SQLTxt = "update products set quantity_to_sale = quantity_to_sale - " & txtQty.EditValue & _
              " WHERE products_id = " & txtProductID.EditValue
            DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
            MsgBox("La commande a été crée.")
        End If
    End Sub

    Private Sub txtCustomerID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomerID.EditValueChanged
        If txtCustomerID.EditValue & "" = "" Then
            Exit Sub
        End If
        txtCustomerName.EditValue = BKGlobal.ExecuteFindFieldValue("customers_lastname", "SELECT customers_lastname from customers where customers_id = " & txtCustomerID.EditValue)
    End Sub

    Private Sub txtProductID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProductID.EditValueChanged
        If txtProductID.EditValue & "" = "" Then
            Exit Sub
        End If
        txtProductModel.EditValue = BKGlobal.ExecuteFindFieldValue("products_model", "SELECT products_model from products where products_id = " & txtProductID.EditValue)
        txtProductType.EditValue = BKGlobal.ExecuteFindFieldValue("products_type", "SELECT products_type from products where products_id = " & txtProductID.EditValue)
    End Sub
End Class
