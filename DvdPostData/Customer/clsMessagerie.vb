Public Class clsMessagerie

    Public Shared Function getLastId() As String
        Dim sql As String
        sql = "select max(id) from tickets"
        Return sql
    End Function

    Public Shared Function GetHistoryTicket(ByVal customers_id As Integer) As String

        Dim sql As String

        sql = " select t.*,ct.name category_name,(select count(*) from message_tickets mt where mt.ticket_id = t.id ) cpt_msg " & _
              " ,(select count(*) from message_tickets mt where mt.ticket_id = t.id and mt.is_read = 0) cpt_msg_unread " & _
              " from tickets t left join category_tickets ct on t.category_ticket_id = ct.id " & _
              " where customer_id = " & customers_id & " order by created_at desc"
        Return sql

    End Function

    Public Shared Function GetHistoryMessage(ByVal ticket_id As Integer, ByVal language_id As Integer) As String
        Dim sql As String

        sql = "select * from message_tickets mt " & _
        " left join mail_messages mm on mm.mail_messages_id = mt.mail_id  and mm.language_id = " & language_id & _
        " left join securityuser su on su.userid = mt.user_id " & _
        " where ticket_id = " & ticket_id & " order by created_at desc "
        Return sql

    End Function
    Public Shared Function getCategorieTicket() As String
        Dim sql As String
        sql = "select id,name from category_tickets "
        Return sql
    End Function
    Public Shared Function GetCreateTicket(ByVal customers_id As Integer, ByVal title As String, ByVal category_ticket_id As String) As String
        Dim sql As String
        Dim strtitle As String
        If title Is Nothing Then
            strTitle = "null"
        Else
            strtitle = "'" & title & "'"
        End If

        sql = "insert tickets (id,customer_id,title,category_ticket_id,created_at,updated_at) " & _
        " values(null," & customers_id & "," & strtitle & "," & category_ticket_id & ",now(),now())"

        Return sql

    End Function

    Public Shared Function GetCreateMessage(ByVal ticket_id As Integer, ByVal mail_id As Integer, ByVal variables As String, ByVal IdHistoryMail As Integer) As String
        Dim sql As String

        Dim sqlmail_history_id As String

        If IdHistoryMail = -1 Then
            sqlmail_history_id = "null"
        Else
            sqlmail_history_id = IdHistoryMail
        End If
        sql = "insert message_tickets (id,user_id,mail_id,ticket_id,data,is_read,mail_history_id,created_at,updated_at) " & _
        " values(null," & PlushData.clsSession.user_id & "," & mail_id & "," & ticket_id & ",'" & variables & "',0," & sqlmail_history_id & ",now(),now())"

        Return sql

    End Function
    Public Shared Function getFlagReadMessage(ByVal ticketmessage_id As Integer, ByVal read As Boolean) As String
        Dim sql As String
        sql = "update message_tickets set is_read = " & read & ",updated_at = now() where id = " & ticketmessage_id & " and user_id is null "
        Return sql
    End Function

    Public Shared Function getFlagReadMessage(ByVal ticket_id) As String
        Dim sql As String
        sql = "update message_tickets set is_read = 1,updated_at = now() where ticket_id = " & ticket_id & " and user_id is null "
        Return sql
    End Function

    Public Shared Function getViewUnreadMessage() As String
        Dim sql As String

        sql = " select t.customer_id customers_id,c.customers_language language ,ct.name categorie ,mt.created_at " & _
              " from tickets t " & _
              " join message_tickets mt on t.id = mt.ticket_id " & _
              " join category_tickets ct on t.category_ticket_id = ct.id " & _
              " join customers c on c.customers_id = t.customer_id " & _
              " where mt.is_read = 0 and user_id is null "

        Return sql
    End Function
End Class
