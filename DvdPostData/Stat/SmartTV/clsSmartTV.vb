Public Class clsSmartTV

    Public Shared Function GetSelectCustomersUseSmartTVApplication(ByVal dateFrom As String, ByVal dateTo As String, ByVal device As Int16) As String
        Dim sql As String
        sql = " SELECT c.customers_id, c.customers_firstname, c.customers_lastname, case when l.device = 3 then 'LG' when l.device = 4 THEN  'Samsung' WHEN  l.device = 7 then 'Philips' end device, date(created_system) as usage_date " & _
                " FROM dvdpost_smarttv.mobile_log l join dvdpost_be_prod.customers c on l.customers_id = c.customers_id " & _
                " where device = " & device & " AND date(created_system) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and  date(created_system) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
                " group by l.customers_id, usage_date " & _
                " order by c.customers_id, usage_date desc "

        Return sql
    End Function

    Public Shared Function GetSelectSmartTVWatched(ByVal dateFrom As String, ByVal dateTo As String, ByVal device As Int16) As String
        Dim sql As String
        sql = " SELECT c.customers_id, c.customers_firstname, c.customers_lastname, case when l.device = 3 then 'LG' when l.device = 4 THEN  'Samsung' WHEN  l.device = 7 THEN 'Philips' end device, date(created_system) as usage_date , parameters Imdb_idDisk_idSeason_id, count(distinct parameters) watched_vod " & _
                " FROM dvdpost_smarttv.mobile_log l join dvdpost_be_prod.customers c on l.customers_id = c.customers_id " & _
                " WHERE date(created_system) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and  date(created_system) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
                " AND (method = 'getVodTokenAndLngs 2 'or method = 'getVodTokenAndLngsNew 2 ') and device = " & device & " group by l.customers_id, usage_date, device, parameters  order by c.customers_id, usage_date desc"

        Return sql
    End Function

    Public Shared Function GetSelectSmartTVMostWatchedMovies(ByVal dateFrom As String, ByVal dateTo As String, ByVal device As Int16) As String
        Dim sql As String
        sql = " select  x.imdb_id, (select products_title from dvdpost_be_prod.products where imdb_id_serie = x.imdb_id limit 1) MovieTitle, count(x.broj) WatchedNumber " & _
                " from ( SELECT substring(parameters,1,instr(parameters,',')-1) imdb_id,  customers_id, count(distinct customers_id) broj " & _
                " FROM dvdpost_smarttv.mobile_log where method = 'getVodTokenAndLngs 2' and customers_id <> 1068898 and device = " & device & _
                " and date(created_system) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and  date(created_system) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
                " group by  parameters, customers_id order by 1 desc ) x group by x.imdb_id order by 3 desc"

        Return sql
    End Function
End Class
