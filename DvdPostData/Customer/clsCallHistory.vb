Public Class clsCallHistory
    Public Shared Function getLastIdInsert() As String
        Dim sql As String
        sql = " SELECT LAST_INSERT_ID() "
        Return sql
    End Function

    Public Shared Function GetSelectBranchSave() As String
        Dim sql As String
        sql = getSelectFeuille() & _
        " union " & _
        getSelectParentwithChildMultipleParent()

        Return sql
    End Function
    Public Shared Function getSelectFeuille() As String
        Dim sql As String
        sql = "select distinct ch.id id" & _
              " from calls_hierarchy ch" & _
              " left join calls_hierarchy ch2 on ch.id = ch2.parent_id" & _
              " where ch2.id is null"

        Return sql
    End Function

    Public Shared Function getSelectParentwithChildMultipleParent() As String
        Dim sql As String
        sql = " select parent_id id from calls_hierarchy ch" & _
                " join (select id,count(*) from calls_hierarchy group by id having count(*) > 1) xx" & _
                " on ch.id = xx.id"
        Return sql
    End Function
    Public Shared Function getSelectArbre() As String
        Dim sql As String
        sql = " select c.id,c.text ,cparent.id parent_id,cparent.text parent_text" & _
              " from calls_hierarchy ch " & _
              " join calls c on c.id = ch.id " & _
              " left join calls cparent on cparent.id = ch.parent_id"

        Return sql
    End Function
    Public Shared Function getSelectContact() As String
        Dim sql As String
        sql = "select * from call_contacts "
        Return sql
    End Function

    Public Shared Function getInsertHistory(ByVal customers_id As Integer, _
                                            ByVal FT As Boolean, _
                                            ByVal nb_reconduction As Integer, _
                                            ByVal contact_id As Integer, _
                                            ByVal comment As String, _
                                            ByVal start_date As DateTime, _
                                            ByVal end_date As DateTime) As String
        Dim sql As String
        sql = "insert call_histories values (null," & customers_id & "," & FT & _
              "," & PlushData.clsSession.user_id & "," & nb_reconduction & _
              "," & contact_id & ",'" & comment & "','" & PlushTools.ClsDate.formatDateTimeDB(start_date) & _
              "','" & PlushTools.ClsDate.formatDateTimeDB(end_date) & "')"

        Return sql

    End Function

    Public Shared Function getInsertValueCall(ByVal history_id As Integer, ByVal call_id As Integer) As String
        Dim sql As String
        sql = "insert call_details_histories values (" & history_id & "," & call_id & ")"
        Return sql
    End Function
    Public Shared Function getSelectCallDetailHistory(ByVal history_id As Integer) As String
        Dim sql As String
        sql = " select cdh.call_id,c.text from call_details_histories cdh " & _
              " join calls c on cdh.call_id = c.id " & _
              " where call_history_id = " & history_id & " order by call_id desc "
        Return sql
    End Function
    Public Shared Function getSelectCallHistory(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = " select ch.*,su.FullName " & _
              " from call_histories ch join securityuser su on ch.user_id = su.UserId " & _
              " where ch.customers_id = " & customers_id & " order by start_date desc "
        Return sql

    End Function

End Class
