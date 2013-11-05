Public Class clsDiscountCode

    Public Shared Function GetSelectDiscountUsed() As String
        Dim sql As String

        sql = "select * from discount_use"
        Return sql
    End Function
End Class
