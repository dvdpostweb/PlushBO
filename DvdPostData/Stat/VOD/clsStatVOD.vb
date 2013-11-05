Public Class clsStatVOD


    Public Shared Function GetSelectTopWatcheVOD(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " select cnt.imdb_id,p.products_id, p.products_title, cnt.watched, " & _
                " (select studio_name from studio s where s.studio_id = sp.studio_id) as studio, " & _
                " sp.expire_at " & _
                " from ( select t.imdb_id, count(*) watched from tokens t where date(t.created_at) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(t.created_at) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' group by imdb_id ) cnt " & _
                " join streaming_products sp on cnt.imdb_id = sp.imdb_id " & _
                " join products p on cnt.imdb_id = p.imdb_id where sp.status <> 'deleted' " & _
                " group by cnt.imdb_id order by cnt.watched desc"
        Return sql
    End Function
End Class
