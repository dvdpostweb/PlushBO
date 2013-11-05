Public Class clsProductsThemes

    Public Shared Function getSelectProductsTheme(ByVal id As Integer) As String
        Dim sql As String

        sql = " select p.products_name,lp.*,te.name theme_event " & _
              " from listed_products lp" & _
              " join  products_description p on lp.product_id = p.products_id and p.language_id = 1" & _
              " join product_lists pl on pl.id = lp.product_list_id " & _
              " left join themes_events te on pl.theme_event_id = te.id " & _
              " where pl.id = " & id & _
              " order by lp.product_list_id,lp.order "
        Return sql
    End Function

    Public Shared Function getUpdateOrderProduct(ByVal id As Integer, ByVal order As Integer)
        Dim sql As String
        sql = "update listed_products lp set lp.order = " & order & ",updated_at = now()" & _
        " where id = " & id
        Return sql
    End Function

    Public Shared Function getInsertProduct(ByVal product_list_id As Integer, ByVal product_id As Integer, ByVal order As Integer)
        Dim sql As String
        sql = " insert listed_products " & _
                " values(null," & _
                product_id & "," & _
                product_list_id & "," & _
                order & "," & _
                "now(),now())"

        Return sql
    End Function

    Public Shared Function getDeleteProduct(ByVal id As Integer) As String
        Dim sql As String
        sql = " delete from listed_products " & _
              " where id = " & id

        Return sql
    End Function

    'Public Shared Function getSelectProductsTheme(Optional ByVal language_id As Integer = -1, Optional ByVal categorieTheme As String = "") As String
    '    Dim sql As String
    '    Dim strCategorieTheme As String = ""
    '    Dim strLanguage As String = ""

    '    If categorieTheme <> "" Then
    '        strCategorieTheme = " and pl.kind = '" & categorieTheme & "'"
    '    End If

    '    If language_id > -1 Then
    '        strLanguage = " and pl.language = " & language_id
    '    End If

    '    sql = " select p.products_name,lp.* from listed_products lp" & _
    '          " join  products_description p on lp.product_id = p.products_id and p.language_id = 1" & _
    '          " join product_lists pl on pl.id = lp.product_list_id " & _
    '          " where 1 " & strCategorieTheme & strLanguage & _
    '          " order by lp.product_list_id,lp.order "
    '    Return sql
    'End Function

    Public Shared Function getSelectThemesCategories(ByVal language_id As Integer, ByVal kind As String) As String
        Dim sql As String
        sql = "select name,id from product_lists where kind = '" & kind & "' and language = " & language_id
        Return sql
    End Function

    Public Shared Function GetEnumMysqlTheme() As String
        Dim sql As String

        sql = "SHOW COLUMNS FROM product_lists LIKE 'kind' "
        Return sql
    End Function

   

End Class
