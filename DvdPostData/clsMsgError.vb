Public Class clsMsgError

    Enum processType
        Abo_Process
        Reconduction
        Matching
        Import_Payment
        Cancel
        Email
        Report
        Dom70
        SignaletiqueCustomer
        Feesharing
        Stock
        Paid
        Batch
        Discount
        Phone_History
        Suspensions
        Vod
        WebService
        Logistic
        LOGIN
        BO
    End Enum

    Public Shared Function InsertLogMsg(ByVal Type As processType, ByVal msgError As String, Optional ByVal customers_id As String = Nothing) As String
        Dim sql As String
        Dim msg As String

        msg = msgError.Replace("'", "''")
        If customers_id Is Nothing Then
            customers_id = "null"
        End If

        sql = "insert log_msgerror (customers_id,processtype,msgerror,user_modified) values "
        sql = sql & "(" & customers_id & ",'" & PlushTools.clsEnum.getNameStrEnum(Type) & "','" & msg & "'," & clsSession.user_id & ")"
        Return sql

    End Function

End Class
