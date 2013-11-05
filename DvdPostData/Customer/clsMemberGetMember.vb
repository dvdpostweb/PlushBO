Public Class clsMemberGetMember


    Public Const MGMPOINT As Integer = 200
    Public Const MAIL_FROM_SPONSOR As String = "DVDPostFriends@dvdpost.be"
    Public Const MAIL_FROM_SPONSOR_NAME As String = "DVDPost Friends"


    Public Enum PointsHistoryAction
        ADD = 1
        REDEEM = 2
        DELETE = 3
    End Enum

    Public Enum PointsHistorySubAction
        POINT_GIVEN_TO_FATHER = 1
        POINT_GIVEN_TO_SON = 2
        POINT_GIVEN_TO_FATHER_RECONDUCTION = 3
        POINT_MANUAL_ALLOCATION = 4

    End Enum

    Public Enum SponsorshipType
        SPONSOR = 1
        GODSON = 2
    End Enum

    Public Enum GiftSent
        SENT = 1
        NOT_SENT = 0
    End Enum
    Public Shared Function GetUpdateNbCard(ByVal customers_id As Integer, ByVal nb_card As Integer) As String
        Dim sql As String
        sql = " update additional_card  set number = " & nb_card & ",modify_at = now() " & _
              " where status = 'create' and customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetUpdateSendFlag(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = " update additional_card  set status = 'send',modify_at = now() " & _
              " where status = 'create' and customers_id = " & customers_id
        Return sql
    End Function
    Public Shared Function GetListCustToOrderCard(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = "select ac.customers_id,sum(ac.number) cpt_card ,ac.campaign,ac.status " & _
        " from additional_card ac  " & _
        " where status = 'create' and customers_id = " & customers_id & _
        "  group by customers_id,campaign,status "
        Return sql
    End Function

    Public Shared Function GetListCustToOrderCard() As String
        Dim sql As String

        sql = "select c.*,card.cpt_card,card.campaign from (select customers_id,sum(number) cpt_card ,ac.campaign,ac.status from additional_card ac " & _
                                            " where status = 'create' group by customers_id,campaign,status) card  " & _
        " join customers c on card.customers_id = c.customers_id " & _
        " where c.customers_abo = " & ClsCustomersData.abo.VALID
        Return sql
    End Function


    Public Shared Function getFatherId(ByVal email As String) As String
        Dim sql As String
        sql = "SELECT customers_id FROM mem_get_mem where email = '" & email & "' order by mem_get_mem_id desc limit 1"
        Return sql
    End Function
    Public Shared Function updateAddPointCustomers(ByVal customers_id As Integer, ByVal point As Integer) As String
        Dim sql As String
        sql = "update customers set mgm_points = mgm_points + " & point & "  where customers_id = " & customers_id
        Return sql
    End Function

    Public Shared Function updateCustomersMgm(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "update customers set mgm_points = " & MGMPOINT & "  where customers_id = " & customers_id
        Return sql
    End Function


    Public Shared Function insertCustomersPointHist(ByVal customers_id As Integer, ByVal pointsHistoryAction As PointsHistoryAction, ByVal pointsHistorySubAction As PointsHistorySubAction, ByVal mgmPoints As Integer) As String
        Dim sql As String
        sql = "insert into  customers_points_history (customers_id, date, action, sub_action, points ) values ('" & customers_id & "' , now(), " & pointsHistoryAction & "  , " & pointsHistorySubAction & " , " & mgmPoints & ") "
        Return sql
    End Function


    Public Shared Function getCustomers(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "select * from customers where customers_id =" & customers_id
        Return sql
    End Function

    'Public Shared Function insertMgmUsed(ByVal fatherId As Integer, ByVal fatherAboType As Integer, ByVal sonId As Integer, ByVal sonAboType As Integer) As String
    '    Dim sql As String
    '    sql = "insert into mem_get_mem_used  (date, father_id, father_abo_type, son_id , son_abo_type , points,expected_points ) values (now(), '" & fatherId & "', '" & fatherAboType & "' , '" & sonId & "', '" & sonAboType & "' ,DEFAULT(points), " & MGMPOINT & " )"
    '    Return sql
    'End Function

    Public Shared Function GetSponsorUsed(ByVal customers_id As Integer, ByVal sponsorShipType As SponsorshipType) As String
        Dim sql As String
        Dim joinSql As String = ""
        sql = "select mgmu.*,c.customers_id, c.customers_firstname , c.customers_lastname from mem_get_mem_used mgmu "


        If sponsorShipType = sponsorShipType.SPONSOR Then
            joinSql = "join customers c on c.customers_id = mgmu.son_id  where  father_id = " & customers_id
        End If


        If sponsorShipType = sponsorShipType.GODSON Then
            joinSql = "join customers c on c.customers_id = mgmu.father_id  where son_id = " & customers_id
        End If


        Return sql + joinSql

    End Function


    Public Shared Function GetMgmGift(ByVal customers_id As Integer)
        Dim sql As String
        sql = "SELECT * ,  mgmg.points as customers_points , mgmh.points as gift_points  FROM mem_get_mem_gift_history mgmh join " & _
              " mem_get_mem_gift mgmg on mgmg.mem_get_mem_gift_id = mgmh.gift_id where customers_id = " & customers_id
        Return sql
    End Function


    Public Shared Function GetCustomersPointsHistory(ByVal customers_id As Integer)
        Dim sql As String
        sql = "select cph.*, cpha.action_name , cphsa.sub_action_name from customers_points_history cph " & _
              "join customers_points_history_action cpha on cph.action = cpha.action_id " & _
              "join customers_points_history_sub_action cphsa on cph.sub_action = cphsa.sub_action_id " & _
              "where customers_id = " & customers_id
        Return sql
    End Function

    Public Shared Function GetCustomersWithGift() As String
        Dim sql As String
        sql = "select * from mem_get_mem_gift_history mgmh join customers c on c.customers_id = mgmh.customers_id where customers_abo = 1 and gift_sent = " & GiftSent.NOT_SENT
        Return sql
    End Function

    Public Shared Function GetRowFather(ByVal son_id As Integer) As String
        Dim sql As String
        sql = "SELECT * FROM mem_get_mem_used m where points=0 and son_id=" & son_id
        Return sql
    End Function

    Public Shared Function updatePointSon(ByVal son_id As Integer, ByVal point As Integer) As String
        Dim sql As String
        sql = "update mem_get_mem_used m set points = " & point & " where points=0 and son_id=" & son_id
        Return sql
    End Function


    Public Shared Function getGodsonAndSponsorInfo(ByVal son_id As Integer, Optional ByVal point As Integer = 0) As String '(ByVal GodSonEmail As String, Optional ByVal point As Integer = 0) As String
        Dim sql As String
       
        sql = " select sponsor.customers_gender," & clsMassEmail.CapitalizeSql("sponsor.customers_firstname", "sponsor.customers_lastname") & " as godfather_name,sponsor.customers_language , sponsor.customers_id ,sponsor.customers_email_address, sponsor.mgm_points + " & point & " as godfather_point ," & _
              " godson.customers_id as godson_id ," & clsMassEmail.CapitalizeSql("godson.customers_firstname", "godson.customers_lastname") & " as son_name,godson.customers_email_address as godson_email_address ,godson.mgm_points as godson_mgm_points " & _
              " from mem_get_mem_used mgmu " & _
              " join customers sponsor on sponsor.customers_id = mgmu.father_id " & _
              " join customers godson on godson.customers_id = mgmu.son_id  " & _
              " where mgmu.son_id = " & son_id & " limit 1 "


        Return sql
    End Function

    Public Shared Function GetCodeLinkCustomers(ByVal customers_id As Integer) As String

        Dim sql As String

        sql = "select customers_id,activation_id,activation_code,campaign from activation_code_properties acp " & _
                " join activation_code_actions aca on acp.activation_code_actions_id = aca.id " & _
                " join activation_code ac on ac.activation_id = aca.activation_code_id " & _
                " where value = " & customers_id
        Return sql
    End Function
End Class
