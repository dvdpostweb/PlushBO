Public Class clsStatDvdSent
    Private Const DATEINVENTORY As String = "2011-02-17"
    Public Shared Function GetExcept(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " select *" & _
                " from " & _
                " ( " & _
                "  select 'orders_canceled' type_process,date(date_added) 'date',count(*) dvd" & _
                "  from orders_canceled" & _
                " where date(date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
                "  group by date(date_added)" & _
                " ) orders_canceled" & _
                " union" & _
                "  select 'bizarrement_perdu' type_process,date(date_added) 'date',count(*) dvd" & _
                "  from products_dvd_state_history" & _
                " where date(date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
                "  and status = " & clsProductDvd.DVDStatus.BIZARREMENT_PERDU & _
                "  group by date(date_added)" & _
                " union" & _
                "  select 'except' type_process,date(date_purchased) 'date',count(*) dvd" & _
                "  from orders o join orders_products op on o.orders_id = op.orders_id" & _
                " where date(date_purchased) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(date_purchased) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
                "  and orders_status = 1 and not op.pick_boxid is null" & _
                "  group by date(date_purchased)" & _
                " order by date,type_process"

        Return sql
    End Function
    Public Shared Function getDvd_Per_State(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " select date(date_added),pds.name,count(*) cpt_dvd" & _
                " from products_dvd_state_history " & _
                " join products_dvd_state pds on pds.id = type_process " & _
                " where date(date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
                " group by date(date_added),pds.name " & _
                " order by date(date_added),pds.name "
        Return sql
    End Function
    Public Shared Function getDvd_Per_State_Per_User(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " select date(date_added),su.fullname,pds.name,count(*) cpt_dvd" & _
                " from products_dvd_state_history " & _
                " join securityuser su on user_modified = userid" & _
                " join products_dvd_state pds on pds.id = type_process " & _
                " where date(date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' " & _
                " group by date(date_added),su.fullname,pds.name " & _
                " order by date(date_added),pds.name,su.fullname "
        Return sql
    End Function

    Public Shared Function getSelectStatStatusProduct(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String

        Dim strdateTo As String = ""
        Dim strdateFrom As String = ""

        If Not dateTo Is Nothing Then
            strdateTo = " and date(status_date) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' "
        End If

        If Not dateFrom Is Nothing Then
            strdateFrom = " and date(status_date) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' "
        End If

        'sql = " select products_dvd_status_name,count(*) cpt " & _
        '        " from products_dvd_status_history pdsh " & _
        '        " join (select max(status_history_id) max_id from products_dvd_status_history " & _
        '        " where 1 " & strdateFrom & strdateTo & _
        '        " group by products_id,products_dvdid) xx on pdsh.status_history_id = xx.max_id " & _
        '        " join products_dvd_status pds on pdsh.status_id = pds.products_dvd_status_id " & _
        '        " group by products_dvd_status_name "

        sql = " select products_dvd_status_name,count(*) cpt " & _
        " from products_dvd_status_history pdsh " & _
        " join (select * from products_dvd_status_history " & _
        "      where 1 " & strdateFrom & strdateTo & _
        "      ) xx on pdsh.status_history_id = xx.status_history_id " & _
        " join products_dvd_status pds on pdsh.status_id = pds.products_dvd_status_id  group by products_dvd_status_name "

        Return sql
    End Function

    Public Shared Function getSelectStateStock() As String
        Dim sql As String
        sql = "select products_dvd_status_name,pd.inout,count(*) cpt" & _
                " from products_dvd pd " & _
                " join products_dvd_status pds on pd.products_dvd_status = pds.products_dvd_status_id " & _
                " group by products_dvd_status_name,pd.inout "
        Return sql
    End Function
    Public Shared Function GetStatEnveloppe(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " select date_added,delivery_country,sum(cpt_dvd*ceiling(cpt/2)) enveloppes," & _
              " sum( " & _
              "   if ( " & _
              "       cpt mod 2 = 0,cpt_dvd * (cpt div 2), " & _
              "   if ( " & _
              "    cpt_dvd * (cpt - 2) > 0,cpt_dvd * (cpt - 2),0 " & _
              "    )/*if*/ " & _
              "   )/*if*/ " & _
              " ) /*sum*/ multi, " & _
              " sum(                      " & _
              "  if (cpt mod 2 <> 0,cpt_dvd,0) " & _
              "   ) single,sum(cpt_dvd * cpt) total_dvd from " & _
              " ( " & _
              "       select date_added,cpt,xx.delivery_country,count(*) cpt_dvd  from ( " & _
              "           select date(osh.date_added) date_added, o.customers_id,o.delivery_country,count(*) cpt " & _
              "           from orders_status_history osh " & _
              "           join orders o on osh.orders_id = o.orders_id " & _
              "               where new_value = 2 and old_value = 1 " & _
              "               and date(osh.date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(osh.date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
              "               group by date(osh.date_added), o.customers_id,o.delivery_country " & _
              "     ) xx group by date_added,delivery_country,cpt " & _
              " ) xxx group by date_added,delivery_country "

        Return sql
    End Function
    Public Shared Function getSelectProcessState(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String

        sql = " select pds.name,pdsh.date_added 'date',pdsh.products_id,pdsh.products_dvd_id,pdsh.box_id,pdsh.pibox_id, pds.name process,ss.fullname user,pdss.products_dvd_status_name status " & _
              " from products_dvd_state_history pdsh " & _
              " join securityuser ss on  pdsh.user_modified = ss.UserID " & _
              " join products_dvd_state pds on pds.id = pdsh.type_process " & _
              " join products_dvd_status pdss on pdsh.status = pdss.products_dvd_status_id " & _
              " where date(pdsh.date_added) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(pdsh.date_added) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
              " order by date(pdsh.date_added),pds.name "
        Return sql
    End Function
    Public Shared Function GetDurationBizarrementPerdu(ByVal dateFrom As String, ByVal dateTo As String) As String

        Dim sql As String

        sql = " select dd,xx.products_id,p.imdb_id_serie,p.products_series_id,p.products_title,pd.qtyStock,xx.products_dvd_id,pds.products_dvd_status_name,if (ok_d = 0,null,datediff(ok_d,dd)) 'bizz->ok(days)'" & _
              " from " & _
              " (" & _
                " select ok.products_id,ok.products_dvd_id,bizarrement_perdu.dd,ok.d,if (bizarrement_perdu.dd < ok.d ,ok.d,0) ok_d" & _
                " from " & _
                "( " & _
                "   select products_id,products_dvd_id,max(date_added) d from products_dvd_state_history where status = " & clsProductDvd.DVDStatus.DVD_STATUS_OK & " group by products_id,products_dvd_id " & _
                " ) ok " & _
                " Join " & _
                "( " & _
                "  select products_id,products_dvd_id,max(date_added)dd from products_dvd_state_history where status = " & clsProductDvd.DVDStatus.BIZARREMENT_PERDU & " group by products_id,products_dvd_id " & _
                " ) bizarrement_perdu   " & _
                " on bizarrement_perdu.products_id = ok.products_id and bizarrement_perdu.products_dvd_id = ok.products_dvd_id " & _
                " where date(bizarrement_perdu.dd) >= '" & DATEINVENTORY & "' and date(bizarrement_perdu.dd) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
                ") xx " & _
                " join products p on p.products_id = xx.products_id " & _
                " left join (select products_id,count(*) qtyStock from products_dvd where products_dvd_status = 1 group by products_id) pd " & _
                " on p.products_id = pd.products_id " & _
                " join products_dvd pdd on p.products_id = pdd.products_id and xx.products_dvd_id = pdd.products_dvdid " & _
                " join products_dvd_status pds on pds.products_dvd_status_id = pdd.products_dvd_status "



        Return sql
    End Function
End Class