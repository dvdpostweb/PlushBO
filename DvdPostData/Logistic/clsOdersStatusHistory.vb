Public Class clsOdersStatusHistory

    'Public Enum orderStatus
    '    ORDERS_STATUS_READY_FOR_EXPEDITION = 1
    '    ORDERS_STATUS_EXPEDITED = 2
    '    ORDERS_STATUS_RETURNED = 3
    '    ORDERS_STATUS_LOST = 6
    '    ORDERS_STATUS_CANCELLED = 9
    '    ORDERS_STATUS_DELAYED = 12
    '    ORDERS_STATUS_TRANSIT_KIALA = 15
    '    ORDERS_STATUS_ERROR = 99
    '    ORDERS_STATUS_broken = 13
    '    ORDERS_STATUS_DAMAGED = 16
    'End Enum
    Public Enum OrderStatusNew
        READY_FOR_EXPEDITION = 1
        EXPEDITED = 2
        RETURNED = 3
        CHECK = 4
        DELAYED_GO = 5
        DELAYED_BACK = 6
        BROKEN_CHARGE = 7
        INTERCHANGE = 8
        COMPLAINT_INADMISSIBLE = 9
        LOST_BY_POST = 10
        TEMPORARY_INTERCHANGE = 11
        TMP


    End Enum
    'Public Enum OrderStatus
    '    ORDERS_STATUS_READY_FOR_EXPEDITION = 1
    '    ORDERS_STATUS_EXPEDITED = 2
    '    ORDERS_STATUS_RETURNED = 3
    '    ORDERS_STATUS_LOST = 6
    '    ORDERS_STATUS_CANCELLED = 9
    '    ORDERS_STATUS_DELAYED = 12
    '    ORDERS_STATUS_TRANSIT_KIALA = 15
    '    ORDERS_STATUS_ERROR = 99
    '    ORDERS_STATUS_BROKEN = 13
    '    ORDERS_STATUS_DAMAGED = 16
    '    ORDERS_STATUS_DELAYED_GO = 17
    '    ORDERS_STATUS_DELAYED_BACK = 18
    '    ORDERS_STATUS_ALREADYBOX
    '    ORDERS_STATUS_NOORDER
    '    ORDERS_STATUS_CUSTSERV
    '    ORDERS_STATUS_BADLABEL
    '    ORDERS_STATUS_CHECK

    'End Enum

    Public Enum OrderProductStatus
        ORDERS_PRODUCTS_STATUS_DAMAGED = 6
        ORDERS_PRODUCTS_STATUS_BROKEN = 4
        ORDERS_PRODUCTS_STATUS_EXPEDITED = 1
        ORDERS_PRODUCTS_STATUS_RETURNED = 2
        ORDERS_PRODUCTS_STATUS_LOST = 3
        ORDERS_PRODUCTS_STATUS_DELAYED = 5
        ORDERS_PRODUCTS_STATUS_CANCELLED = 9
        ORDERS_PRODUCTS_STATUS_TRANSIT_KIALA = 10
        ORDERS_PRODUCTS_STATUS_ERROR = 99
        ORDERS_PRODUCTS_STATUS_DELAYED_GO = 17
        ORDERS_PRODUCTS_DELAYED_BACK = 18
    End Enum

    Public Enum languages
        FR = 1
        NL = 2
        EN = 3
    End Enum
    Public Shared Function getSelectSearchCustomers_id(ByVal products_id As Integer, ByVal products_dvd_id As Integer) As String
        Dim sql As String
        sql = " select o.orders_id,o.customers_id from orders o join orders_products op on o.orders_id = op.orders_id " & _
              " where op.products_id = " & products_id & " and op.products_dvd = " & products_dvd_id & _
              " and o.orders_status = " & OrderStatusNew.EXPEDITED
        Return sql
    End Function
    Public Shared Function getUpdateStatusOrderHistory(ByVal orders_id As String, ByVal Newstatus As OrderStatusNew, ByVal Oldstatus As OrderStatusNew) As String

        Dim sql As String

        sql = "insert into orders_status_history  (orders_id, new_value, old_value, date_added, customer_notified ) values (" & orders_id & ", " & _
            Newstatus & ", " & Oldstatus & ", now(), 0)"

        Return sql
    End Function
    Public Shared Function getUpdateStatusOrder(ByVal orders_id As String, ByVal status As OrderStatusNew, ByVal products_id As Integer, ByVal products_dvd_id As Integer) As String
        Dim sql As String
        sql = " update orders o join orders_products op on o.orders_id = op.orders_id " & _
              " set orders_status = " & status & ", op.products_id = " & products_id & _
              ",op.products_dvd = " & products_dvd_id & ",last_modified = now() where o.orders_id = " & orders_id
        Return sql

    End Function
    Public Shared Function getUpdateStatusOrder(ByVal orders_id As String, ByVal status As OrderStatusNew) As String
        Dim sql As String
        sql = "update orders set orders_status = " & status & ",last_modified = now() where orders_id = " & orders_id
        Return sql

    End Function
    Public Shared Function GetSelectStatusOrder() As String
        Dim sql As String
        sql = " select id,name from orders_status_new where id in (" & _
              OrderStatusNew.BROKEN_CHARGE & "," & OrderStatusNew.CHECK & _
              "," & OrderStatusNew.INTERCHANGE & "," & OrderStatusNew.DELAYED_BACK & _
              "," & OrderStatusNew.DELAYED_GO & ")"

        Return sql
    End Function
    Public Shared Function GetCptEnveloppeToDay() As String
        Dim sql As String
        ' if cpt = 1,2 alors c'est 1 enveloppe 
        ' if cpt = 3,4 alors c'est 2 enveloppes
        ' if cpt = 5,6 alors c'est 3 enveloppes

        sql = " select sum(cpt_dvd*ceiling(cpt/2)) tot from " & _
                " (  " & _
                "    select cpt,count(*) cpt_dvd from " & _
                "    ( " & _
                "       select o.customers_id,count(*) cpt " & _
                "       from orders o " & _
                "       join orders_products op on o.orders_id = op.orders_id " & _
                "       where date(date_purchased) = date(now()) and not op.pick_boxid in (1,2) and op.pick_boxid is not null and o.orders_status = 2 " & _
                "       group by o.customers_id " & _
                "   ) xx " & _
                " group by cpt " & _
                " ) xxx "
        Return sql
    End Function
    Public Shared Function GetDvdDelayed(ByVal date_added As String, ByVal date_end As String) As String
        Dim sql As String
        sql = "select o.* , tmp2.date_added ,(nv.orders_status_name) as orders_history_new_value , (ov.orders_status_name) as orders_history_old_value , (os.orders_status_name ) as current_orders_status , pd.* ,pdesc.* ,pds.products_dvd_status_name from orders o join" & _
              "(select *  from orders_status_history osh join " & _
              "(select max(orders_status_history_id) id  from orders_status_history  group by orders_id ) tmp1 " & _
              "on tmp1.id  = osh.orders_status_history_id where osh.date_added between '" & date_added & "' and '" & date_end & "') tmp2 " & _
              "on o.orders_id = tmp2.orders_id " & _
              " join orders_products op on op.orders_id = o.orders_id " & _
              " join products_dvd pd on op.products_id = pd.products_id and op.products_dvd = pd.products_dvdid " & _
              " join products_dvd_status pds on pds.products_dvd_status_id = pd.products_dvd_status " & _
              " join products_description pdesc on pdesc.products_id = pd.products_id and pdesc.language_id = " & languages.FR & _
              " join orders_status nv on nv.orders_status_id = tmp2.new_value and nv.language_id = " & languages.FR & _
              " join orders_status ov on ov.orders_status_id = tmp2.old_value and ov.language_id = " & languages.FR & _
              " join orders_status os on os.orders_status_id = o.orders_status and os.language_id = " & languages.FR & _
              " where o.orders_status = '" & OrderStatusNew.DELAYED_BACK & "' and tmp2.date_added between '" & date_added & "' and '" & date_end & "' " & _
              " order by  tmp2.date_added desc "
        Return sql
    End Function

    Public Shared Function GetOrdersByCustomers(ByVal customers_id As String) As String
        Dim sql As String
        sql = "SELECT  o.orders_id, o.customers_id,o.customers_name,o.date_purchased, osn.name orders_status, o.orders_date_finished, " & _
                      " o.last_modified, op.orders_products_id, op.products_id, op.products_model, " & _
                      " op.products_name,op.products_dvd,o.orders_type,o.user_modified,o.orders_status orders_status_id " & _
                      " FROM orders o " & _
                      " Join orders_products op ON o.orders_id = op.orders_id " & _
                      " Join orders_status_new osn on osn.id = o.orders_status " & _
                      " Where o.customers_id = " & customers_id & " order by o.orders_id desc "

        Return sql
    End Function
    Public Shared Function getSelectOrderOneMonthDelay() As String
        Dim sql As String
        sql = "select o.orders_id,o.last_modified,o.customers_id,o.orders_status from orders o " & _
        " where date_add(o.last_modified,interval 1 month) <= date(now()) " & _
        " and o.orders_status in (" & OrderStatusNew.DELAYED_BACK & "," & OrderStatusNew.DELAYED_GO & ")" & _
        " order by o.last_modified "
        Return sql
    End Function

    Public Shared Function getSelectOrderTwoWeekCheck() As String
        Dim sql As String
        sql = "select o.orders_id,o.last_modified,o.customers_id,o.orders_status from orders o " & _
        " where date_add(o.last_modified,interval 2 week) <= date(now()) and o.orders_status = " & OrderStatusNew.CHECK & _
        " order by o.last_modified "
        Return sql
    End Function

    Public Shared Function GetselectOrderComplaint_Inadmissible() As String
        Dim sql As String
        sql = "select o.orders_id,o.date_purchased,o.customers_id,o.orders_status from orders o where o.orders_status = " & OrderStatusNew.COMPLAINT_INADMISSIBLE & _
        " order by o.date_purchased desc "
        Return sql
    End Function
    Public Shared Function GetOrderHistory(ByVal orders_id As Integer)
        Dim sql As String
        sql = "select * ,(osn.name) new_status ,(oso.name) old_status  from orders_status_history osh " & _
            " left join orders_status_new osn on osn.id = osh.new_value " & _
            " left join orders_status_new oso on oso.id = osh.old_value " & _
            " where osh.orders_id = " & orders_id & " order by osh.orders_status_history_id desc "
        Return sql
    End Function
    Public Shared Function GetCptOrdersHistory(ByVal isIn As Boolean, Optional ByVal Iserror As Boolean = False) As String
        Dim sql As String

        Dim status As Integer
        Dim notified_error As Integer
        If isIn Then
            status = OrderStatusNew.RETURNED
        Else
            status = OrderStatusNew.EXPEDITED

        End If

        If Not Iserror Then
            notified_error = 0
        Else
            notified_error = -1
        End If

        sql = " select count(*) from (select osh.* from orders_status_history osh join (select orders_id,max(orders_status_history_id) orders_status_history_id from orders_status_history osh group by orders_id)xx  on xx.orders_status_history_id = osh.orders_status_history_id) osh " & _
              " join orders o on o.orders_id = osh.orders_id " & _
              " join customers c on o.customers_id = c.customers_id " & _
              " where osh.new_value = " & status & " and osh.customer_notified= " & notified_error

        Return sql
    End Function
    ''' <summary>
    '''  if problem with sent mail use for send the out mail
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetListOrderHistoryOUTTEST() As String
        Dim sql As String
        sql = "select p.products_id products_id,osh.*,o.*,c.*,pd.products_image_big products_image,pd.products_name,p.*" & _
"from mail_messages_sent_history mmsh " & _
"join orders o on o.customers_id = mmsh.customers_id " & _
"join orders_status_history osh on o.orders_id = osh.orders_id and date(mmsh.date) = date(osh.date_added) " & _
"join customers c on o.customers_id = c.customers_id " & _
"join orders_products op on op.orders_id = o.orders_id " & _
"join products p on op.products_id = p.products_id " & _
"join products_description pd on p.products_id = pd.products_id and pd.language_id = c.customers_language " & _
"where mail_messages_id in (100) and mail_opened = 0 and date(date) >= '2010-08-02' and date(date) < date(now())  and osh.new_value = 2 order by 1 desc "

        Return sql
    End Function
    ''' <summary>
    ''' if problem with sent mail use for send the IN mail
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetListOrderHistoryINTEST() As String
        Dim sql As String
        sql = "select p.products_id products_id,osh.*,o.*,c.*,pd.products_image_big products_image,pd.products_name,p.*" & _
"from mail_messages_sent_history mmsh " & _
"join orders o on o.customers_id = mmsh.customers_id " & _
"join orders_status_history osh on o.orders_id = osh.orders_id and date(mmsh.date) = date(osh.date_added) " & _
"join customers c on o.customers_id = c.customers_id " & _
"join orders_products op on op.orders_id = o.orders_id " & _
"join products p on op.products_id = p.products_id " & _
"join products_description pd on p.products_id = pd.products_id and pd.language_id = c.customers_language " & _
"where mail_messages_id in (99) and mail_opened = 0 and date(date) >= '2010-08-02' and date(date) < date(now())  and osh.new_value = 3 order by 1 desc "

        Return sql
    End Function
    Public Shared Function GetListSummaryErrorOrderHistory() As String

        Dim sql As String
        sql = "select distinct c.customers_id,c.customers_firstname,c.customers_lastname,c.customers_email_address,p.products_id,pd.products_name " & _
      " from orders_status_history osh " & _
      " join orders o on osh.orders_id = o.orders_id " & _
      " left join customers c on o.customers_id = c.customers_id " & _
      " join orders_products op on op.orders_id = o.orders_id " & _
      " join products p on op.products_id = p.products_id " & _
      " join products_description pd on p.products_id = pd.products_id and pd.language_id = c.customers_language " & _
      " where osh.customer_notified= -1"

        Return sql
    End Function
    Public Shared Function GetListOrderHistory(ByVal isIn As Boolean, Optional ByVal Iserror As Boolean = False) As String

        Dim sql As String
        Dim status As Integer
        Dim notified_error As Integer
        If isIn Then
            status = OrderStatusNew.RETURNED
        Else
            status = OrderStatusNew.EXPEDITED

        End If

        If Not Iserror Then
            notified_error = 0
        Else
            notified_error = -1
        End If

        sql = "select c.*,p.products_id products_id,osh.*,o.*,date(o.date_purchased) date_sent,pd.products_image_big products_image,pd.products_name,p.* " & _
        " from (select osh.* from orders_status_history osh join (select orders_id,max(orders_status_history_id) orders_status_history_id from orders_status_history osh group by orders_id)xx  on xx.orders_status_history_id = osh.orders_status_history_id) osh " & _
        " join orders o on osh.orders_id = o.orders_id " & _
        " join customers c on o.customers_id = c.customers_id " & _
        " join orders_products op on op.orders_id = o.orders_id " & _
        " join products p on op.products_id = p.products_id " & _
        " join products_description pd on p.products_id = pd.products_id and pd.language_id = c.customers_language " & _
        " where osh.new_value = " & status & " and osh.customer_notified= " & notified_error

        Return sql
    End Function
    Public Shared Function getCptOrdersNotReturned(ByVal products_id As Integer, ByVal dvd_id As Integer) As String
        Dim sql As String

        sql = " select count(*) from orders o " & _
                " join orders_products op on op.orders_id = o.orders_id " & _
                " where o.orders_status not in (" & OrderStatusNew.RETURNED & "," & OrderStatusNew.TEMPORARY_INTERCHANGE & ")" & _
                " and op.products_id = " & products_id & " and op.products_dvd = " & dvd_id & " and o.date_purchased <= " & GetDateAboprocess()
        Return sql

    End Function
    Public Shared Function GetLastOrdersOpened(ByVal products_id As Integer, ByVal dvd_id As Integer) As String
        ' without manually attribution after aboprocess run
        ' o.date_purchased <= " & GetDateAboprocess() & " and

        Dim sql As String
        sql = "select op.orders_id,o.orders_status, op.orders_products_status,pd.products_dvd_status, op.products_dvd, o.customers_id, o.date_purchased " & _
         " from (select max(o.orders_id) orders_id from orders o " & _
         "       join orders_products op on o.orders_id = op.orders_id " & _
         "       where op.products_id = " & products_id & " and op.products_dvd = " & dvd_id & " and o.orders_status not in (" & OrderStatusNew.RETURNED & "," & OrderStatusNew.COMPLAINT_INADMISSIBLE & ")) last_order " & _
         " join orders o on last_order.orders_id = o.orders_id " & _
         " join orders_products op on op.orders_id = o.orders_id " & _
         " join products_dvd pd on pd.products_id = " & products_id & " and pd.products_dvdid = " & dvd_id


        Return sql
    End Function

    Public Shared Function GetLastOrders(ByVal products_id As Integer, ByVal dvd_id As Integer) As String
        Dim sql As String
        sql = " select ' ' multishipment_sm,1 customers_abo_multishipment,o.customers_id,op.products_id,op.products_dvd dvd_id, lang.name as lang_name,o.delivery_name,o.delivery_street_address,o.delivery_city, o.delivery_postcode, o.delivery_country," & _
                " op.pick_group, op.pick_boxid,pd.box_id,op.orders_id,o.orders_status, op.orders_products_status,pd.products_dvd_status, op.products_dvd, c.customers_id, date_purchased " & _
                " from (select max(o.orders_id) orders_id from orders_products op join orders o on op.orders_id = o.orders_id where o.orders_status <> " & OrderStatusNew.TEMPORARY_INTERCHANGE & " and op.products_id = " & products_id & " and op.products_dvd = " & dvd_id & ") last_order " & _
                " join orders o on last_order.orders_id = o.orders_id " & _
                " join orders_products op on op.orders_id = o.orders_id " & _
                " join products_dvd pd on pd.products_id = " & products_id & " and pd.products_dvdid = " & dvd_id & _
                " join customers c on c.customers_id = o.customers_id " & _
                " join languages lang on lang.languages_id = c.customers_language "

        Return sql
    End Function
    Public Shared Function UpdateNotified(ByVal orders_id As Integer, ByVal ok As Boolean) As String
        Dim sql As String
        Dim status As Integer
        If ok Then
            status = 1
        Else
            status = -1
        End If
        sql = " update orders_status_history set customer_notified  = " & status & " where orders_id = " & orders_id
        Return sql
    End Function
    Private Shared Function GetDateAboprocess() As String
        Dim sql As String

        Dim dt As DataTable

        sql = PlushData.AboProcessData.GetDateTimeRunAboprocess()
        dt = PlushData.clsConnection.FillDataSet(sql)

        If dt.Rows.Count > 0 AndAlso dt.Rows(0)("date_end") IsNot DBNull.Value Then
            Return "'" & PlushTools.ClsDate.formatDateTimeDB(dt.Rows(0)("date_end")) & "'"
        Else
            Return "concat(date(now()), ' 11:00:00')"
        End If


    End Function
    Public Shared Function GetOrdersAssignPickGroup(ByVal Minbox_id As Integer, ByVal Maxbox_id As Integer) As String
        Dim sql As String
        sql = " SELECT o.orders_id, o.customers_id, o.delivery_country, op.products_id, op.products_dvd as dvd_id, pd.box_id, " & _
                  " pd.pibox_id, c.customers_language as language_id, op.pick_group, op.pick_boxid, concat(' ',o.date_purchased,' ') date_purchased,o.orders_type " & _
                  " FROM orders o " & _
                  " LEFT JOIN orders_products op on op.orders_id = o.orders_id " & _
                  " LEFT JOIN products_dvd pd on pd.products_id = op.products_id and pd.products_dvdid= op.products_dvd " & _
                  " LEFT JOIN customers c on c.customers_id = o.customers_id" & _
                  " WHERE pd.box_id >= " & Minbox_id & " and pd.box_id <= " & Maxbox_id & " and o.date_purchased <= " & GetDateAboprocess() & " and o.orders_status = " & OrderStatusNew.READY_FOR_EXPEDITION & " ORDER BY o.customers_id "
        Return sql
    End Function


    Public Shared Function GetOrdersAssignPickGroup() As String
        Dim sql As String
        sql = " SELECT p.products_series_id,p.products_title,pd2.qtyStock,o.orders_id, o.customers_id, trim(upper(o.delivery_country)) delivery_country, op.products_id, op.products_dvd as dvd_id, pd.box_id, " & _
                  " pd.pibox_id, c.customers_language as language_id, op.pick_group, op.pick_boxid,date(o.date_purchased) date ,concat(' ',o.date_purchased,' ') date_purchased,o.orders_type " & _
                  " FROM orders o " & _
                  " JOIN orders_products op on op.orders_id = o.orders_id " & _
                  " JOIN products_dvd pd on pd.products_id = op.products_id and pd.products_dvdid= op.products_dvd " & _
                  " JOIN customers c on c.customers_id = o.customers_id" & _
                  " join products p on p.products_id = op.products_id " & _
                  " join (select products_id,count(*) qtyStock from products_dvd where products_dvd_status = 1 group by products_id) pd2 " & _
                  " on p.products_id = pd2.products_id " & _
                  " WHERE o.date_purchased <= " & GetDateAboprocess() & " and o.orders_status = " & OrderStatusNew.READY_FOR_EXPEDITION & " ORDER BY pd.box_id,pd.pibox_id"
        Return sql
    End Function

    Public Shared Function getUpdateOrdersPickGroup(ByVal pick_group As String, ByVal pick_box_id As Integer, ByVal orders_id As Integer) As String
        Dim sql As String

        sql = "update orders_products set pick_group = '" & pick_group & "' , pick_boxid = " & pick_box_id & _
                  " WHERE orders_id = " & orders_id
        Return sql

    End Function

    Public Shared Function getUpdateCreditLostMoreMonth() As String
        Dim sql As String
        sql = " select xx.* from " & _
              " ( select (day(now()) - day(date_purchased)) D ,o.* " & _
              " from orders o " & _
              " where orders_status = 2 and date(date_purchased) < date(now()) " & _
              " ) xx " & _
              " join customers c on xx.customers_id = c.customers_id " & _
              " join products_abo pa on c.customers_next_abo_type = pa.products_id " & _
              " where D = 0 and pa.qty_dvd_max < 0"

        Return sql
    End Function

    Public Shared Function GetInsertCustomersRotation() As String
        Dim sql As String

        sql = "insert customers_rotations " & _
              " select customers_id,date(now()),sum(datediff(last_modified,date_purchased))/count(*) average  from orders o " & _
              " where date(date_purchased) >= date_sub(now(),interval 1 month) and o.orders_status = 3 " & _
              " group by customers_id "
        Return sql
    End Function
End Class
