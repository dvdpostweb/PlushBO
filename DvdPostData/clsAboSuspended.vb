



Public Class clsAboSuspended

    Public Enum aboSupendedAction
        SUSPENDED = 1
        SET_BACK_TO_NORM = 2
    End Enum

    Public Enum aboSupendedReason
        HOLIDAY = 1
        UNPAID = 2
        SLOW_DOWN = 3
    End Enum

    Public Enum customersAboSuspended
        SUSPENDED_FOR_HOLIDAY = 1
        UNSUSPENDED = 0
        SUSPENDED = 2
    End Enum

    Public Const Holidays As String = "HOLIDAYS"
    Public Const Payment As String = "PAYMENT"

    'Public Function GetUpdateCutomersAboSuspended(ByVal customers_id As Integer)
    '    Dim sql As String
    '    sql = "select * from customers_abo_suspended where customers_id = " & customers_id
    '    Return sql
    'End Function

    '----------------------------------------
    ''old table suspended History
    '----------------------------------------
    'Public Shared Function GetInsertAboSuspendedHistory(ByVal customers_id As Integer, ByVal action As aboSupendedAction, ByVal reason As aboSupendedReason) As String
    '    Dim sql As String
    '    sql = "INSERT INTO abo_suspended_history (customers_id , date , action , reason, comment) VALUES (" & customers_id & ", now()," & action & " , " & reason & ", '" & DvdPostData.clsSession.user_id & "' )"
    '    Return sql
    'End Function


    'Public Shared Function GetInsertAboSuspendedHoliday(ByVal customers_id As Integer, ByVal date_end As String) As String
    '    Dim sql As String
    '    date_end = PlushTools.ClsDate.formatDate(date_end)
    '    sql = "INSERT INTO abo_suspended_holiday (customers_id , date_asked , weeks , date_end) VALUES (" & customers_id & ", now(), TIMESTAMPDIFF(WEEk , now(), '" & date_end & "'),  '" & date_end & "')"
    '    Return sql
    'End Function


    'Public Shared Function GetDateEndHoliday(ByVal customers_id As Integer)
    '    Dim sql As String
    '    sql = "select date_end from abo_suspended_holiday ash " & _
    '           "join customers c on c.customers_id = ash.customers_id " & _
    '           "where  ash.customers_id = " & customers_id & " and c.customers_abo_suspended = " & customersAboSuspended.SUSPENDED_FOR_HOLIDAY & " and  date_end >= now() order by abo_suspended_holiday_id desc limit 1 "
    '    Return sql
    'End Function
    ' Public Function GetHolidaySetBack() As String

    ' End Function


    'Public Shared Function GetLastValidityTo(ByVal customers_id As Integer) As String
    '    Dim sql As String
    '    sql = "select date_add(Date , interval 1 MONTH) from abo where customerid = " & customers_id & " oders by id desc limit 1 "
    '    Return sql
    'End Function




    'Public Shared Function InsertComeBackholiday() As String
    '    Dim sql As String
    '    sql = " INSERT INTO abo_suspended_history (customers_id , date , action , reason, comment)  " & _
    '          " select customers_id , now() , " & aboSupendedAction.SET_BACK_TO_NORM & "  , " & aboSupendedReason.HOLIDAY & " , '" & DvdPostData.clsSession.user_id & "' from customers where customers_abo_suspended = " & DvdPostData.ClsCustomersData.Suspended.HOLLIDAY & "  and customers_abo_validityto < now()and customers_abo = " & DvdPostData.ClsCustomersData.abo.VALID
    '    Return sql
    'End Function

    'Public Shared Function updateCustomersSetBackholidays() As String
    '    Dim sql As String
    '    sql = " update customers  set customers_abo_suspended = " & DvdPostData.ClsCustomersData.Suspended.OK & _
    '          " where customers_abo_suspended = " & DvdPostData.ClsCustomersData.Suspended.HOLLIDAY & "  and customers_abo_validityto <= now()and customers_abo = " & DvdPostData.ClsCustomersData.abo.VALID
    '    Return sql
    'End Function



    '----------------------------------------
    ''new  table suspended History
    '----------------------------------------
    Public Shared Function GetInsertAboSuspendedHistory(ByVal customer_id As Integer, ByVal status As String, ByVal date_end As String) As String
        Dim sql As String
        If date_end <> "" Then
            date_end = " '" & PlushTools.ClsDate.formatDate(date_end) & "' "
        Else
            date_end = "DEFAULTVALUE(date_end)"
        End If
        sql = "INSERT INTO suspensions(customer_id , status , date_added , date_end , last_modified , user_modified) VALUES (" & customer_id & ", '" & status & "',  now()," & date_end & "  , now(), " & PlushData.clsSession.user_id & " )"
        Return sql
    End Function


    Public Shared Function GetUpdateAboSuspendedHistory(ByVal id As Integer, Optional ByVal date_end As String = "") As String
        Dim sql As String


        If date_end <> "" Then
            date_end = " '" & PlushTools.ClsDate.formatDate(date_end) & "' "
        Else
            date_end = "now()"
        End If



        sql = " update suspensions set date_end = " & date_end & " , last_modified = now() , user_modified = " & PlushData.clsSession.user_id & " where id = " & id
        Return sql
    End Function


    Public Shared Function GetIdAboSuspendedHistory(ByVal customers_id As String, ByVal status As String, Optional ByVal date_end As String = "") As String
        Dim sql As String
        sql = " select max(id) from suspensions where status = '" & status & "' and customer_id = " & customers_id
        If date_end <> "" Then
            date_end = " and date(date_end) = '" & PlushTools.ClsDate.formatDate(date_end) & "' "

        Else
            date_end = " and date_end is NULL "
        End If
        sql = sql & date_end

        Return sql
    End Function


    Public Shared Function GetDateEndHoliday(ByVal customers_id As String) As String
        Dim sql As String
        sql = " select date_end from suspensions ash join customers c on c.customers_id = ash.customer_id " & _
              " where ash.customer_id = " & customers_id & " and status = '" & Holidays & "' and c.customers_abo_suspended = " & PlushData.ClsCustomersData.Suspended.HOLIDAY & _
              " order by id desc limit 1"
        Return sql
    End Function

    Public Shared Function GetSelectMustUnsuspended() As String
        Dim sql As String

        sql = " select * from suspensions  ash join " & _
              " (select c.customers_id from  customers c left join (select p.customers_id,count(*) from payment p " & _
              "                                             where p.payment_status in (" & PaymentOfflineData.GetListRecoverySuspended() & ")" & _
              "                                             group by p.customers_id" & _
              "                                            ) payment_offline on payment_offline.customers_id = c.customers_id" & _
              " left join (select p.customers_id,count(*) cpt from payment p  where p.payment_status not in (" & PaymentOfflineData.GetListClose() & ") group by p.customers_id) qty_paid on qty_paid.customers_id = c.customers_id " & _
              " where c.customers_abo_suspended = " & ClsCustomersData.Suspended.RECONDUCTION & " and c.customers_abo = " & ClsCustomersData.abo.VALID & " and (payment_offline.customers_id is null and (qty_paid.cpt is null or qty_paid.cpt < 2))) xx " & _
              " on xx.customers_id = ash.customer_id " & _
              " where ash.date_end is NULL and ash.status = '" & Payment & "' "

        Return sql
    End Function

    Public Shared Function GetUpdateUnsuspended() As String
        Dim sql As String

        sql = " update suspensions  ash join " & _
              " (select c.customers_id from  customers c left join (select p.customers_id,count(*) from payment p " & _
              "                                             where p.payment_status in (" & PaymentOfflineData.GetListRecoverySuspended() & ")" & _
              "                                             group by p.customers_id" & _
              "                                            ) payment_offline on payment_offline.customers_id = c.customers_id" & _
              " left join (select p.customers_id,count(*) cpt from payment p  where p.payment_status not in (" & PaymentOfflineData.GetListClose() & ") group by p.customers_id) qty_paid on qty_paid.customers_id = c.customers_id " & _
              " where c.customers_abo_suspended = " & ClsCustomersData.Suspended.RECONDUCTION & " and c.customers_abo = " & ClsCustomersData.abo.VALID & " and (payment_offline.customers_id is null and (qty_paid.cpt is null or qty_paid.cpt < 2))) xx " & _
              " on xx.customers_id = ash.customer_id " & _
              " set ash.date_end = now() , last_modified = now() , user_modified = " & PlushData.clsSession.user_id & _
              " where ash.date_end is NULL and ash.status = '" & Payment & "' "

        Return sql
    End Function


    Public Shared Function GetInsertSuspended() As String
        Dim sql As String

        sql = " insert into suspensions (customer_id , status , date_added , last_modified , user_modified) " & _
              " select c.customers_id , '" & Payment & "' , now() ,now() , " & PlushData.clsSession.user_id & "  from  customers c left join (select p.customers_id,count(*) cpt from payment p " & _
              "                                             where p.payment_status in (" & PaymentOfflineData.GetListRecoverySuspended() & ")" & _
              "                                             group by p.customers_id" & _
              "                                            ) payment_offline on payment_offline.customers_id = c.customers_id" & _
              " join (select p.customers_id,count(*) cpt from payment p  where p.payment_status not in (" & PaymentOfflineData.GetListClose() & ") group by p.customers_id) qty_paid on qty_paid.customers_id = c.customers_id " & _
              " where c.customers_abo_suspended = " & ClsCustomersData.Suspended.OK & " and c.customers_abo = " & ClsCustomersData.abo.VALID & " and (payment_offline.cpt > 0 or qty_paid.cpt >= 2) "
        Return sql
    End Function


    Public Shared Function GetUnsuspendCustomersSetBackholidays() As String
        Dim sql As String
        sql = " select * from customers c " & _
              "        join suspensions s on  s.customer_id = c.customers_id  " & _
              "        join (select max(id) as id from suspensions s " & _
              "               where  s.status = '" & Holidays & "'  group by s.customer_id " & _
              "             ) xx on xx.id = s.id " & _
              " where date(s.date_end) <=  date(now()) and customers_abo_suspended = " & ClsCustomersData.Suspended.HOLIDAY
        Return sql
    End Function

    Public Shared Function updateUnsuspendCustomersSetBackholidays() As String
        Dim sql As String
        sql = " update customers c " & _
              "        join suspensions s on  s.customer_id = c.customers_id  " & _
              "        join (select max(id) as id from suspensions s " & _
              "               where  s.status = '" & Holidays & "'  group by s.customer_id " & _
              "             ) xx on xx.id = s.id " & _
              " set c.customers_abo_suspended = " & ClsCustomersData.Suspended.OK & ",s.last_modified = now() " & _
              " where date(s.date_end) <=  date(now()) and customers_abo_suspended = " & ClsCustomersData.Suspended.HOLIDAY
        Return sql
    End Function

    Public Shared Function GetSuspendedHistory(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = " select * from suspensions where customer_id = " & customers_id & " order by id desc  "
        Return sql
    End Function


    Public Shared Function GetUpdateValidityToForHoliday(ByVal customers_id As Integer, ByVal intervalDays As Integer) As String
        Dim sql As String
        sql = "update customers set customers_abo_validityto = DATE_ADD(customers_abo_validityto, INTERVAL " & intervalDays & " DAY) where customers_id = " & customers_id & " and customers_abo = " & PlushData.ClsCustomersData.abo.VALID
        Return sql
    End Function





End Class
