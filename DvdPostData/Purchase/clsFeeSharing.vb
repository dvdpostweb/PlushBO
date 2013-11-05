Public Class clsFeeSharing

    Public Const UPFRONTFEE_VALUE_UNIVERSAL_GLOBAL_DATA As Integer = 2
    Public Const UPFRONTFEE_VALUE_MOVIEMAX As Integer = 4

    Public Const TURN_PRICE As Integer = 1

    Public Enum feeSharingStudio
        UNIVERSAL_GLOBAL_DATA = 1
        MOVIEMAX = 7
    End Enum


#Region "fee sharing global data"

    Public Shared Function GetProductsGlobalData() As String
        Dim sql As String
        sql = "select products_id , feesharing_end , products_title from products where feesharing = " & feeSharingStudio.UNIVERSAL_GLOBAL_DATA
        Return sql
    End Function



    Public Shared Function getOrdersInFeeSharing() As String
        Dim sql As String
      
        sql = "select op.orders_products_id , o.orders_status,op.products_id,op.products_dvd,p.products_language_fr,p.products_undertitle_nl,o.date_purchased,o.delivery_postcode, pd.products_name from products p " & _
              "join orders_products op on p.products_id = op.products_id and op.feesharing =0 " & _
              "join orders o on o.orders_id = op.orders_id  " & _
              "left join products_description pd on p.products_id = pd.products_id and pd.language_id = 2 " & _
              "where p.feesharing = " & feeSharingStudio.UNIVERSAL_GLOBAL_DATA & " and p.feesharing_end > Now()"
        Return sql

    End Function

    Public Shared Function getInsertFeeSharing(ByVal str As String, ByVal totalFee As Integer) As String
        Dim sql As String
        sql = "insert into feesharing (feesharing_partner , feesharing_date , feesahring_output , feesahring_varprice) values ('warner' , now(), '" & str & "', '" & totalFee & "' )"
        Return sql
    End Function

    Public Shared Function updateOdersProductsFee(ByVal orders_products_id As String, ByVal feeSharingStudio As feeSharingStudio) As String
        Dim sql As String
        sql = "update orders_products set feesharing = " & feeSharingStudio & " where orders_products_id = " & orders_products_id
        Return sql
    End Function

#End Region

#Region "fee sharing moviemax"
    Public Shared Function getFeeSharingMovieMaxProccess(ByVal dStart As DateTime, ByVal dEnd As DateTime) As String
        Dim sql As String
        Dim datestart As String = PlushTools.ClsDate.formatDate(dStart)
        Dim dateEnd As String = PlushTools.ClsDate.formatDate(dEnd)
        sql = " select op.products_dvd , o.date_purchased , p.products_date_available,op.orders_products_id  , tmp.* from products p " & _
              " join orders_products op on p.products_id = op.products_id and op.feesharing =0 " & _
              " join orders o on o.orders_id = op.orders_id  " & _
              " left join (select * from feesharing_moviemax_input fmi left join  feesharing_moviemax_leverancier fml on fmi.maatschappij = fml.id) tmp  on tmp.products_id = p.products_id " & _
              " where o.date_purchased >= '" & datestart & "' and o.date_purchased <= '" & dateEnd & "'  and o.date_purchased <  p.feesharing_end  and p.feesharing = " & feeSharingStudio.MOVIEMAX
        Return sql
    End Function


    Public Shared Function getInsertValue(ByVal date_purchased As Date, ByVal strtime As Integer, ByVal titelnr As Integer, ByVal rate As String, ByVal product_id As Integer) As String
        Dim sql As String
        Dim datePurchased As String = PlushTools.ClsDate.formatDate(date_purchased)

        sql = " insert into feesharing_moviemax_output ( field1 ,field2 ,date ,time , titlenr , field6 , field7 ,field8 , field9) values " & _
        " ('0001', '0374', '" & datePurchased & "'  " & _
        ", '" & strtime & "', '" & titelnr & "', '" & _
        rate & "', '1', '374" & titelnr & product_id & "', 'D')"
        Return sql
    End Function

    Public Shared Function GetMovieMaxOutPut(ByVal dStart As DateTime)
        Dim sql As String
        Dim datestart As String = PlushTools.ClsDate.formatDate(dStart)
        sql = "SELECT * FROM feesharing_moviemax_output where date >= '" & datestart & "'"
        Return sql
    End Function

    Public Shared Function GetMovieMaxPartner() As String
        Dim sql As String = "select * from feesharing_moviemax_leverancier "
        Return sql
    End Function

    Public Shared Function insertMovieMax(ByVal products_id As Integer, ByVal titeNr As Integer, ByVal maatschappij As Integer) As String
        Dim sql As String = "insert into feesharing_moviemax_input (products_id, titelnr, maatschappij) values (" & products_id & " , " & titeNr & " ,  " & maatschappij & " ) "
        Return sql
    End Function

    Public Shared Function moviemaxExist(ByVal products_id As Integer) As String
        Dim sql As String = "select count(*) from feesharing_moviemax_input where products_id = " & products_id
        Return sql
    End Function

    Public Shared Function GetMovieMaxInput(ByVal products_id As Integer) As String
        Dim sql As String
        sql = "select * from feesharing_moviemax_input where products_id = " & products_id
        Return sql
    End Function

    Public Shared Function updateMovieMaxInput(ByVal products_id As Integer, ByVal titelnr As Integer, ByVal maatschappij As Integer)
        Dim sql As String
        sql = "update feesharing_moviemax_input set titelnr =  " & titelnr & " , maatschappij = " & maatschappij & " where products_id = " & products_id
        return sql
    End Function

    Public Shared Function getFeesharingMoviemax() As String
        Dim sql As String = "select  p.products_id ,  p.products_title ,fmi.titelnr, fml.leverancier,fml.percentage  from feesharing_moviemax_input fmi " & _
                            " join  feesharing_moviemax_leverancier fml on fmi.maatschappij = fml.id " & _
                            " join products p on fmi.products_id = p.products_id " & _
                            " where p.feesharing = " & feeSharingStudio.MOVIEMAX
        Return sql
    End Function

#End Region





End Class
