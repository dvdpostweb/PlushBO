Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Collections.Generic

Public Class ClsBatchDomiciliation


    ' utiliser pour gerer la progress bar
    Public Event initMapping_Event(ByVal cpt As Integer)
    Public Event stepMapping_event(ByVal index As Integer)
    Public Event init_event()


    Public Shared Function GetMatchingDomiciliation() As DataTable
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.ClsBatchDomiciliation.getMatchingDomiciliation(DvdPostData.ClsBatchDomiciliation.GetListDomPaid)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function
    Public Shared Function InsertDomiciliationPayment(ByVal drReconduction As DataRow, ByVal strcommunication As String) As Boolean
        Dim abo_id As Integer
        Dim customers_id As Integer
        Dim price As String
        Dim strDomNumber As String
        Dim sql As String
       

        Try
            Dim clsCust As ClsCustomers = New ClsCustomers()

            abo_id = clsCust.GetCustomersLastAbo(drReconduction)
            customers_id = clsCust.GetCustomersId(drReconduction)

            sql = DvdPostData.ClsCustomersData.GetLastAboid(customers_id)
            abo_id = DvdPostData.clsConnection.ExecuteScalar(sql)

            price = clsCust.GetCustomersAmount(drReconduction)
            If price = "0" Then Return True
            strDomNumber = clsCust.getCustomersDomiciliationNumber(drReconduction)
            
            sql = DvdPostData.ClsBatchDomiciliation.CreatedomiciliationPayment(abo_id, customers_id, price, strDomNumber, strcommunication)
            DvdPostData.clsConnection.ExecuteNonQuery(sql)
            'sql = DvdPostData.PaymentOfflineData.InsertPaymentOfflineRequest(DvdPostData.PaymentOfflineData.StepPaymentOffline.CREATED, _
            '                                                               price, _
            '                                                               clsCompta.DVDPOST_ACCOUNT_DEXIA, _
            '                                                               customers_id, _
            '                                                               DvdPostData.ClsCustomersData.Payment_Method.DOMICILIATION.ToString(), _
            '                                                               String.Empty, _
            '                                                               strcommunication)
            'DvdPostData.clsConnection.ExecuteNonQuery(sql)
            'sql = DvdPostData.ClsBatchDomiciliation.getUpdateReasonPkValue(customers_id, price)
            'DvdPostData.clsConnection.ExecuteNonQuery(sql)

            Return True
        Catch ex As Exception
            clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Reconduction, ex)
        End Try

    End Function

    Public Function CreateBatchFile(ByVal dtCustomers As DataTable) As String
        Dim flux_80 As String
        Dim clsdom As ClsDom80_128 = New ClsDom80_128()

        flux_80 = clsdom.GenerateFile(dtCustomers)
        Return flux_80
    End Function

    Public Function CreatePathFile(ByVal tBatch As String, ByVal country As String) As String
        Return ClsDom80_128.CreatePathFile(tBatch, country)
    End Function

    Private Sub InitProgressBar(ByVal cpt As Integer)

        RaiseEvent initMapping_Event(cpt)
    End Sub
    Private Sub StepProgressBar(ByVal index As Integer)
        RaiseEvent stepMapping_event(index)
    End Sub

    Private Sub init()
        RaiseEvent init_event()
    End Sub

    Public Function ImportCoda(ByVal pathfile As String) As Boolean
        Dim clsImportCoda As clsCoda2 = New clsCoda2()
        Return clsImportCoda.AnalyseFile(pathfile)

    End Function
End Class
