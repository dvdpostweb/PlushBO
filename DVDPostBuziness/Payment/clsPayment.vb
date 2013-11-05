Public Class clsPayment

    Public Shared Function CreateInvoice(ByVal customers_id As Integer, _
                                    ByVal payment_method As PlushData.ClsCustomersData.Payment_Method, _
                                    ByVal payment_type As PlushData.ClsPayment.Payment_type, _
                                    ByVal communication_type As PlushData.ClsCustomersData.TypePaymentCommunication, _
                                    ByVal price As String) As String
        Dim sql As String
        Dim payment_id As Integer
        Dim communication As String

        sql = PlushData.ClsPayment.getIdLastPayment()
        payment_id = PlushData.clsConnection.ExecuteScalar(sql)
        payment_id += 1

        communication = clsCompta.CreateCommunicationStruct(payment_id, communication_type)
        sql = PlushData.ClsPayment.CreatePayment(payment_id, payment_method, customers_id, price, communication, payment_type)
        PlushData.clsConnection.ExecuteNonQuery(sql)

        Return communication

    End Function

    Public Shared Sub CancelInvoiceLongtime(ByVal customers_id As Integer)

        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.ClsPayment.GetLastPaymentByTypeJustOpenStatus(customers_id, PlushData.ClsPayment.Payment_type.LONGTIME)
        dt = PlushData.clsConnection.FillDataSet(sql)
        If dt.Rows.Count > 0 Then
            Dim dr As DataRow = dt.Rows(0)
            CancelInvoice(dr("id"))
        End If


    End Sub


    Public Shared Sub CancelInvoice(ByVal payment_id As Integer)

        Dim sql As String
        sql = PlushData.ClsPayment.GetUpdateClosePayment(payment_id, PlushData.PaymentOfflineData.StepPayment.CANCEL, PlushData.PaymentOfflineData.StepPayment.CREATE_RECOVERY)
        PlushData.clsConnection.ExecuteNonQuery(sql, True)

    End Sub



End Class
