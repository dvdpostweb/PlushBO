Public Class ClsBankTransfer
    'Public Shared Function matching() As Boolean
    '    Dim sql As String
    '    Dim dt As DataTable

    '    Dim row As DataRow
    '    Dim id As Integer
    '    Dim amount As String

    '    Dim id_movement As Integer
    '    Dim cpt_find_recovery As Integer
    '    Dim cpt_find_coda As Integer
    '    Dim customers_id As Integer
    '    Dim last_status As DvdPostData.PaymentOfflineData.StepPayment

    '    Try
    '        DvdPostData.clsConnection.CreateTransaction(False)

    '        sql = DvdPostData.clsBatchBankTransfert.getMatchingNoRecovery()
    '        dt = DvdPostData.clsConnection.FillDataSet(sql)

    '        For Each row In dt.Rows

    '            id = row("id")
    '            amount = PlushTools.ClsPrice.FormatPrice(row("amount"))
    '            customers_id = row("customers_id")
    '            id_movement = row("account_movements_id")
    '            last_status = row("payment_status")

    '            sql = DvdPostData.ClsMatching.getUpdateBankAccountMovements(id_movement, DvdPostData.ClsMatching.matching_type.BANKTRANSFER)
    '            cpt_find_coda = DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '            sql = DvdPostData.ClsPayment.GetUpdateClosePayment(id, DvdPostData.PaymentOfflineData.StepPayment.PAID, last_status, id_movement)
    '            cpt_find_recovery = DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '            If cpt_find_coda <> cpt_find_recovery Then
    '                Throw New Exception("Error Matching payment_ID = " & id & " Coda_id = " & id_movement)
    '            End If

    '        Next
    '        Dim cpt_insert As Integer
    '        ' change status Printed -> create recovery 
    '        sql = DvdPostData.clsBatchBankTransfert.UpdateCustomersInRecoveryStep(DvdPostData.clsBatchBankTransfert.DAYRECOUVREMENT)
    '        cpt_insert = DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '        DvdPostData.clsConnection.CommitTransaction(True)

    '        Return True
    '    Catch ex As Exception
    '        DvdPostData.clsConnection.CommitTransaction(False)
    '        MsgBox(ex.Message)
    '        Return False
    '    End Try

    'End Function
    Public Shared Sub print(Optional ByVal customer_id As Integer = 0)

        Dim chooseSql As String
        Dim dt As DataTable
        Dim chooseSqlADULTSVOD As String
        Dim dtADULTSVOD As DataTable
        'strDatePrint = GetDatePrint()

        chooseSql = PlushData.clsBatchBankTransfert.GetDataPaymentCustomer(PlushData.clsBatchBankTransfert.LIMIT_DAYPAID, customer_id)
        dt = PlushData.clsConnection.FillDataSet(chooseSql)

        Dim clscompta As PlushBuziness.clsCompta = New PlushBuziness.clsCompta()
        clscompta.sendLetter(dt, PlushData.PaymentOfflineData.TypeSend.LETTER_BANKTRANSFER)
        changeStatus(dt)
        'adult svod
        chooseSqlADULTSVOD = PlushData.clsBatchBankTransfert.GetDataADULTSVODPaymentCustomer(PlushData.clsBatchBankTransfert.LIMIT_DAYPAID, customer_id)
        dtADULTSVOD = PlushData.clsConnection.FillDataSet(chooseSqlADULTSVOD)

        clscompta.sendLetter(dtADULTSVOD, PlushData.PaymentOfflineData.TypeSend.LETTER_BANKTRANSFER_ADULTSVOD)
        changeStatus(dtADULTSVOD)

        chooseSql = PlushData.clsBatchBankTransfert.UpdateCustomersInRecoveryStep(PlushData.clsBatchBankTransfert.LIMIT_DAYPAID)
        PlushData.clsConnection.ExecuteNonQuery(chooseSql)

    End Sub

    Private Shared Sub changeStatus(ByVal dt As DataTable)
        Dim list_id As String = ""
        Dim sql As String
        Dim cpt_result As Integer
        Dim cpt As Integer
        If clsMsgError.MsgBox("Are you sur to change status print ? ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            cpt = dt.Rows.Count
            Try
                For Each dr As DataRow In dt.Rows
                    If list_id = "" Then
                        list_id = list_id + dr("id").ToString()
                    Else
                        list_id = list_id + "," & dr("id").ToString()
                    End If
                Next

                sql = PlushData.clsBatchBankTransfert.UpdateStatusBankTransfert(list_id, PlushData.PaymentOfflineData.StepPayment.PRINTED)
                cpt_result = PlushData.clsConnection.ExecuteNonQuery(sql)
                clsMsgError.MsgBox(cpt_result & "/" & cpt & " customers update status " & PlushData.PaymentOfflineData.StepPayment.PRINTED)

            Catch ex As Exception
                clsMsgError.MsgBox("ERROR changed status", MsgBoxStyle.Critical)
            End Try

        End If

    End Sub
End Class
