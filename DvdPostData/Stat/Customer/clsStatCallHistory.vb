Public Class clsStatCallHistory
    Public Shared Function getSelectContactUser(ByVal dateFrom As String, ByVal dateTo As String) As String

        Dim sql As String

        sql = " select ContactUser.start_date,ContactUser.contact_id,ContactUser.fullname,ContactUser.cpt user_calls,Contact.cpt total_calls,(ContactUser.cpt / Contact.cpt ) * 100 percent_userCalls " & _
               " from ( " & _
               "   select date(ch.start_date) start_date,cc.text contact_id , count(*) cpt " & _
               "   from call_histories ch " & _
               "   join call_contacts cc on ch.contact_id = cc.id " & _
               "   where date(ch.start_date) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(ch.start_date) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
               "   group by ch.contact_id,date(ch.start_date)) Contact join " & _
               " ( " & _
               "   select date(ch.start_date) start_date,cc.text contact_id,su.fullname, count(*) cpt " & _
               "   from call_histories ch " & _
               "   join call_contacts cc on ch.contact_id = cc.id " & _
               "   join securityuser su on ch.user_id = su.userid " & _
               "   where date(ch.start_date) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(ch.start_date) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
               "   group by ch.contact_id,date(ch.start_date),su.fullname ) ContactUser on Contact.contact_id = ContactUser.contact_id and Contact.start_date = ContactUser.start_date "

        Return sql
    End Function

    Public Shared Function getSelectRetentionUser(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String

        'sql = " select totalPerUserPerDay.start_date,totalPerUserPerDay.text raison,totalPerUserPerDay.fullname, " & _
        '      " totalPerUserPerDay.ft,totalPerUserPerDay.cpt user_calls ,totalPerDay.cpt total_calls,(totalPerUserPerDay.cpt / totalPerDay.cpt) * 100 percent_calls " & _
        '      " from " & _
        '      " (select date(ch.start_date) start_date,ch.ft, count(*) cpt" & _
        '      " from call_histories ch join call_details_histories cdh on ch.id = cdh.call_history_id" & _
        '      " join securityuser su on ch.user_id = su.userid" & _
        '      " join calls c on c.id = cdh.call_id" & _
        '      " where cdh.call_id in (36,35)" & _
        '      " and date(ch.start_date) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(ch.start_date) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
        '      " group by date(ch.start_date),ch.ft) totalPerDay" & _
        '      " join" & _
        '      " ( " & _
        '      " select c.text,date(ch.start_date) start_date,su.fullname,ch.ft, count(*) cpt " & _
        '      " from call_histories ch join call_details_histories cdh on ch.id = cdh.call_history_id " & _
        '      " join securityuser su on ch.user_id = su.userid " & _
        '      " join calls c on c.id = cdh.call_id " & _
        '      " where cdh.call_id in (36,35) " & _
        '      " and date(ch.start_date) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(ch.start_date) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
        '      " group by c.text,date(ch.start_date),su.fullname,ch.ft " & _
        '      " ) totalPerUserPerDay on totalPerDay.start_date = totalPerUserPerDay.start_date and totalPerDay.ft = totalPerUserPerDay.ft "

        sql = " select c.text,date(ch.start_date) start_date,su.fullname,ch.ft, (select cc.text from call_contacts cc where cc.id = ch.contact_id) contact, ch.comment " & _
               " from call_histories ch join call_details_histories cdh on ch.id = cdh.call_history_id " & _
               " join securityuser su on ch.user_id = su.userid " & _
               " join calls c on c.id = cdh.call_id " & _
               " where cdh.call_id in (36,35) " & _
               " and date(ch.start_date) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(ch.start_date) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'"

        Return sql



    End Function

    Public Shared Function getSelectMainNode(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        'sql = " select totalPerUserPerDay.start_date,totalPerUserPerDay.text raison,totalPerUserPerDay.fullname,totalPerUserPerDay.ft,totalPerUserPerDay.cpt user_calls ,totalPerDay.cpt total_calls,(totalPerUserPerDay.cpt / totalPerDay.cpt) * 100 percent_calls " & _
        '        " from " & _
        '        " (select c.text,date(ch.start_date) start_date,ch.ft, count(distinct ch.id) cpt " & _
        '        " from call_histories ch " & _
        '        " join call_details_histories cdh on ch.id = cdh.call_history_id" & _
        '        " join securityuser su on ch.user_id = su.userid " & _
        '        " join calls c on c.id = cdh.call_id " & _
        '        " join (select id from calls_hierarchy where parent_id = 0) nodemain on cdh.call_id = nodemain.id" & _
        '        " where date(ch.start_date) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(ch.start_date) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
        '        " group by c.text,date(ch.start_date),ch.ft) totalPerDay " & _
        '        " join " & _
        '        " ( " & _
        '        " select c.text,date(ch.start_date) start_date,su.fullname,ch.ft, count(distinct ch.id) cpt " & _
        '        " from call_histories ch join call_details_histories cdh on ch.id = cdh.call_history_id " & _
        '        " join securityuser su on ch.user_id = su.userid " & _
        '        " join calls c on c.id = cdh.call_id " & _
        '        " join (select id from calls_hierarchy where parent_id = 0) nodemain on cdh.call_id = nodemain.id " & _
        '        " where date(ch.start_date) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(ch.start_date) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
        '        " group by c.text,date(ch.start_date),su.fullname,ch.ft " & _
        '        " ) totalPerUserPerDay on totalPerDay.start_date = totalPerUserPerDay.start_date and totalPerDay.ft = totalPerUserPerDay.ft and totalPerDay.text = totalPerUserPerDay.text "

        sql = " select c.text,date(ch.start_date) start_date,su.fullname,ch.ft,ch.id, (select cc.text from call_contacts cc where cc.id = ch.contact_id) contact, ch.comment " & _
              " from call_histories ch " & _
              " join call_details_histories cdh on ch.id = cdh.call_history_id " & _
              " join securityuser su on ch.user_id = su.userid " & _
              " join calls c on c.id = cdh.call_id " & _
              " join (select id from calls_hierarchy where parent_id = 0) nodemain on cdh.call_id = nodemain.id  " & _
              " where date(ch.start_date) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(ch.start_date) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'"



        Return sql

    End Function
    Public Shared Function getSelectAllValue(ByVal dateFrom As String, ByVal dateTo As String) As String
        Return getSelectAllValue(dateFrom, dateTo, 0)
    End Function


    Public Shared Function getSelectAboStop(ByVal dateFrom As String, ByVal dateTo As String) As String
        Return getSelectAllValue(dateFrom, dateTo, 1)
    End Function

    Public Shared Function getSelectAllValue(ByVal dateFrom As String, ByVal dateTo As String, ByVal parent_id As Integer) As String
        Dim sql As String


        'sql = " select xxx.*,cStopReason.text reason,cRetenu.text from " & _
        '      "( " & _
        '      " select  distinct(cdh.call_history_id) call_history_id,date(ch.start_date) start_date,su.fullname,ch.ft,cdh.call_id reason_id ,stop_cdh.call_id" & _
        '      " from call_histories ch " & _
        '      " join call_details_histories cdh on ch.id = cdh.call_history_id" & _
        '      " join securityuser su on ch.user_id = su.userid " & _
        '      " join " & _
        '      " ( " & _
        '      " select distinct(id) id from calls_hierarchy ch where ch.parent_id = " & parent_id & _
        '      " ) xx on cdh.call_id = xx.id" & _
        '      " join call_details_histories stop_cdh on stop_cdh.call_history_id = cdh.call_history_id " & _
        '      " where stop_cdh.call_id in (select distinct(ch.id) from calls_hierarchy ch " & _
        '      "                     join " & _
        '      "                     (select distinct(id) id from calls_hierarchy ch where ch.parent_id = " & parent_id & _
        '      "                     ) parent on ch.parent_id = parent.id) " & _
        '      " and date(ch.start_date) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(ch.start_date) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "'" & _
        '      " ) xxx " & _
        '      " join calls cStopReason on xxx.reason_id = cStopReason.id " & _
        '      " join calls cRetenu on xxx.call_id = cRetenu.id "

        sql = " select x.start_date,x.fullname, x.customers_id, x.catgegorie ,x.sous_categorie, x.sous_categorie2, " & _
                "  x.contact, x.comment from ( select father.start_date,su.fullname, father.customers_id, father.call_history_id, fathertext.text catgegorie , " & _
                " childtext.text sous_categorie, childtext2.text sous_categorie2, (select cc.text from call_contacts cc where cc.id = father.contact_id) contact, " & _
                "father.comment  " & _
                      " from ( " & _
                      "   select ch.id, cdh.call_history_id, ch.customers_id,cdh.call_id,ch.user_id,date(ch.start_date) start_date, ch.contact_id, ch.comment from call_histories ch  join  call_details_histories cdh on ch.id = cdh.call_history_id join ( " & _
                      "   select id from calls_hierarchy where parent_id = " & parent_id & _
                      "  ) main on cdh.call_id = main.id " & _
                      " where date(ch.start_date) >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "' and date(ch.start_date) <= '" & PlushTools.ClsDate.formatDate(dateTo) & "') father " & _
                      " left join calls_hierarchy chi2 on chi2.parent_id = father.call_id " & _
                      " left join call_details_histories child on child.call_history_id = father.id and child.call_id = chi2.id " & _
                      " left join (select call_history_id,count(*) cpt from call_details_histories group by call_history_id having count(*) = 1) father_alone on father_alone.call_history_id = father.id " & _
                      " join calls fathertext on father.call_id = fathertext.id " & _
                      " left join calls childtext on child.call_id = childtext.id " & _
                      " left join calls_hierarchy chi3 on chi3.parent_id = childtext.id" & _
                      " left join call_details_histories child2 on child2.call_history_id = father.id and child2.call_id <> childtext.id and child2.call_id <> father.call_id " & _
                      " left join calls childtext2 on child2.call_id = childtext2.id " & _
                      " join securityuser su on father.user_id = su.userid " & _
                      " where child.call_id is not null or father_alone.call_history_id is not null ) x group by x.call_history_id"


        Return sql
    End Function

End Class
