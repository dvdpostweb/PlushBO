Public Class ClsMatching


    Enum matching_type
        NOMATCHED = 0
        MANUALY = 1
        DOMICILIATION = 2
        BANKTRANSFER = 3
        RECOVERY = 4
        NOPAYMENT = 5

    End Enum

    Public Shared Function GetMatchingByall() As String

        Dim sql As String

        sql = GetMatchingByLastNameByfirstName()
        sql = sql + " union "
        'sql = sql + GetMatchingByCommunicationStructureInEntireData(customers_id)
        'sql = sql + " union "
        sql = sql + GetMatchingByCommunicationStructureInStructuredComm12()

        Return sql
    End Function

    Public Shared Function GetMatchingByall(ByVal customers_id As Integer) As String

        Dim sql As String

        sql = GetMatchingByLastNameByfirstName(customers_id, False)
        sql = sql + " union "
        sql = sql + GetMatchingByIdMatching(customers_id)
        sql = sql + " union "
        sql = sql + GetMatchingByCommunicationStructureInStructuredComm12(customers_id)
        sql = sql + " union "
        sql = sql + GetMatchingByCustomersId(customers_id)

        Return sql
    End Function
    Public Shared Function GetTypeMatching() As String
        Dim sql As String
        sql = "select * from type_matchings "
        Return sql
    End Function

    Public Shared Function GetMatchingByCustomersId(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = " select bam.* " & _
        " from bank_account_movements bam " & _
        " where bam.customers_id = " & customers_id

        Return sql

    End Function
    Public Shared Function GetMatchingByAccountMovementPayment(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = " select bam.* " & _
        " from bank_account_movements bam join payment p " & _
        " on p.account_movements_id = p.account_movements_id " & _
        " where p.customers_id = " & customers_id & " and bam.debit = 0 "
        Return sql

    End Function

    Public Shared Function GetMatchingByCommunicationStructureInStructuredComm12() As String
        Dim sql As String


        sql = " select bam.account_movements_id,p.customers_id " & _
                " from bank_account_movements bam join payment p " & _
                " on trim(bam.structuredComm12) = trim(p.communication) " & _
                " where bam.debit = 0 and bam.ismatching = 0 and bam.date_coda_created = date(now())"


        Return sql

    End Function
    Public Shared Function GetMatchingByIdMatching(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = " select bam.* " & _
                " from bank_account_movements bam join payment p " & _
                " on bam.account_movements_id = p.account_movements_id " & _
                " where p.customers_id = " & customers_id & " and  not p.account_movements_id is null "

        Return sql

    End Function


    Public Shared Function GetMatchingByLastNameByfirstName() As String
        Dim sql As String
        Dim strAbo As String = ""
        Dim strOpenPayment As String = ""
        
            strOpenPayment = " and bam.ismatching = 0"


        sql = " select bam.account_movements_id,c.customers_id " & _
        " from bank_account_movements bam join customers c " & _
        " on bam.CounterpartDetails like concat('%',c.customers_lastname,'%')" & _
        " and bam.CounterpartDetails like concat('%',c.customers_firstname,'%') " & _
        " where bam.debit = 0 and bam.structuredComm12 is null and bam.ismatching = 0 and bam.date_coda_created = date(now()) and customers_abo = 1"

        Return sql

    End Function


    Public Shared Function GetMatchingByLastNameByfirstName(ByVal customers_id As Integer, Optional ByVal aboActif As Boolean = True) As String
        Dim sql As String
        Dim strAbo As String = ""

        If aboActif Then
            strAbo = " and c.customers_abo = " & ClsCustomersData.abo.VALID
        End If


        sql = " select bam.* " & _
        " from bank_account_movements bam join customers c " & _
        " on bam.EntireData like concat('%',c.customers_lastname,'%')" & _
        " and bam.EntireData like concat('%',c.customers_firstname,'%') " & _
        " where c.customers_id = " & customers_id & strAbo & " and bam.debit = 0 "

        Return sql

    End Function

    Public Shared Function GetMatchingByCommunicationStructureInStructuredComm12(ByVal customers_id As Integer) As String
        Dim sql As String
        Dim strOpenPayment As String = ""

        sql = " select bam.* " & _
        " from bank_account_movements bam join payment p " & _
        " on bam.structuredComm12 like concat('%',p.communication,'%')" & _
        " where p.customers_id = " & customers_id & " and bam.debit = 0 "


        Return sql

    End Function

    Public Shared Function GetMatchingByCommunicationStructureInEntireData(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = " select bam.* " & _
        " from bank_account_movements bam join payment p " & _
        " on bam.EntireData like concat('%',p.communication,'%')" & _
        " where p.customers_id = " & customers_id & " and bam.debit = 0 "


        Return sql

    End Function


    Public Shared Function getSelectMatchingCommunicationStructure() As String
        Dim sql As String
        ' payment 
        sql = " select bam.account_movements_id,p.payment_status,p.id,p.customers_id from bank_account_movements bam " & _
              " inner join payment p on bam.structuredComm12 = p.communication " & _
              " where p.communication <> 0 and bam.ismatching = " & matching_type.NOMATCHED & _
              " and abs(cast(bam.amount as decimal(10,2)) - cast(p.amount as decimal(10,2))) <= 1 and bam.debit = 0 " & _
              " and  bam.date_coda_created = date(now()) and p.payment_status in (" & PaymentOfflineData.GetListOpen() & ")"

        Return sql
    End Function

    Public Shared Function getUpdatePaymentOffline(ByVal id As Integer, ByVal account_movements_id As Integer, ByVal status_paid As Integer) As String
        Dim sql As String
        ' payment 
        sql = " update payment p " & _
                " set p.account_movements_id = " & account_movements_id & _
                " , p.payment_status = " & status_paid & ", p.last_modified = now(),p.user_modified = " & clsSession.user_id & _
                " where p.id = " & id

        Return sql
    End Function
    Public Shared Function getUpdateBankAccountMovementsCustomersId(ByVal id As Integer, ByVal customers_id As Integer) As String
        Dim sql As String
        ' payment 
        sql = " update bank_account_movements bam "
        sql = sql & " set bam.customers_id = " & customers_id & ",bam.last_modified = now(),bam.user_modified = " & clsSession.user_id
        sql = sql & " where bam.account_movements_id = " & id

        Return sql
    End Function

    Public Shared Function getUpdateBankAccountMovementsNoPayment(ByVal id As Integer) As String
        Dim sql As String
        ' payment 
        sql = " update bank_account_movements bam "
        sql = sql & " set bam.ismatching = " & matching_type.NOPAYMENT & ",bam.last_modified = now(),bam.user_modified = " & clsSession.user_id
        sql = sql & " where bam.account_movements_id = " & id

        Return sql
    End Function
    ''' <summary>
    '''  customers_id is string but it's possible the field is null 
    ''' and with integer impossible used null
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="matching"></param>
    ''' <param name="customers_id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getUpdateBankAccountMovements(ByVal id As Integer, ByVal matching As matching_type, ByVal customers_id As String) As String
        Dim sql As String
        ' payment 
        sql = " update bank_account_movements bam "
        sql = sql & " set bam.customers_id = " & customers_id & ",bam.ismatching = " & matching & ",bam.last_modified = now(),bam.user_modified = " & clsSession.user_id
        sql = sql & " where bam.account_movements_id = " & id

        Return sql
    End Function

    Public Shared Function getMatchingOfflineRequestCommunicationStructure(ByVal status_paid As Integer) As String
        Dim sql As String
        ' payment 
        sql = " update bank_account_movements bam "
        sql = sql & " inner join payment p on bam.EntireData like concat('%',p.communication,'%') "
        sql = sql & " set p.account_movements_id = bam.account_movements_id,  bam.ismatching = " & matching_type.DOMICILIATION & ",bam.last_modified = now(),bam.user_modified = " & clsSession.user_id
        sql = sql & " , p.payment_status = " & status_paid & ", p.last_modified = now(),p.user_modified = " & clsSession.user_id
        sql = sql & " where bam.ismatching = " & matching_type.NOMATCHED & " and cast(bam.amount as decimal(10,2)) >= cast(p.amount as decimal(10,2)) and bam.debit = 0 and  bam.date_coda_created = date(now()) "

        Return sql
    End Function

    Public Shared Function getBankAccountMovementsDetails(ByVal id As Integer)
        Dim sql As String

        sql = "select * from bank_account_movements " & _
        " where account_movements_id = " & id

        Return sql
    End Function

    Public Shared Function getBankAccountMovementsDetails(ByVal date_start As String, ByVal date_end As String, Optional ByVal isOpenPayment As Boolean = False)
        Dim sql As String

        sql = "select * from bank_account_movements " & _
        " where date_coda_created >= date('" & date_start & "') " & _
        " and date_coda_created <= date('" & date_end & "') and debit = 0 "

        If isOpenPayment Then
            sql = sql + " and ismatching = " & ClsMatching.matching_type.NOMATCHED
        End If

        Return sql
    End Function





    'Public Shared Function GetDataPaymentDomiciliation(ByVal customers_id As Integer, Optional ByVal isOpenPayment As Boolean = True) As String
    '    Dim Sql As String

    '    Dim type_payment As String
    '    Dim list_openPayment As String
    '    ' payment 
    '    If isOpenPayment Then
    '        list_openPayment = " and dp.payment_status in (" & DvdPostData.ClsBatchDomiciliation.GetListUnpaid() & ")"
    '    Else
    '        list_openPayment = ""
    '    End If
    '    type_payment = PlushTools.clsEnum.getNameStrEnum(ClsCustomersData.Payment_Method.DOMICILIATION)

    '    Sql = "SELECT '" & type_payment & "' type_payment," & _
    '        " d.id id ,dp.amount,dp.domiciliation_payment_date date_added,dp.last_modified,dp.communication as communication,p.communication as communication_recovery, " & _
    '        " dp.customers_id,dps.name payment_status,p.id id_recovery,ps.name status_recovery,p.account_movements_id id_matching" & _
    '        " FROM customers c " & _
    '        " join payment p on c.customers_id = p.customers_id " & _
    '        " join payment_status dps on dps.id = p.payment_status " & _
    '        " where c.customers_id = " & customers_id & list_openPayment

    '    Return Sql

    'End Function

    'Public Shared Function GetDataPaymentOgone(ByVal customers_id As Integer, Optional ByVal isOpenPayment As Boolean = True) As String
    '    Dim Sql As String

    '    Dim type_payment As String
    '    ' payment 
    '    Dim list_openPayment As String

    '    If isOpenPayment Then
    '        list_openPayment = " and op.payment_status in (" & ClsBatchOgone.GetListUnpaid() & ")"
    '    Else
    '        list_openPayment = ""
    '    End If

    '    type_payment = PlushTools.clsEnum.getNameStrEnum(ClsCustomersData.Payment_Method.OGONE)

    '    Sql = "SELECT '" & type_payment & "' type_payment," & _
    '        " p.id id ,p.amount,p.date_added,p.last_modified,p.communication as communication " & _
    '        " p.customers_id,ops.name status,p.id id_recovery,ps.name status_recovery,p.account_movements_id id_matching" & _
    '        " FROM customers c " & _
    '        " join payment p on c.customers_id = p.customers_id " & _
    '        " join payment_status ops on ops.id = p.payment_status " & _
    '        " where c.customers_id = " & customers_id & list_openPayment

    '    Return Sql

    'End Function


    Public Shared Function GetDataPayment(ByVal customers_id As Integer, Optional ByVal isOpenPayment As Boolean = True, Optional ByVal matching_id As Integer = -1) As String
        Dim Sql As String
        ' payment 

        Dim list_openPayment As String
        Dim strmatching As String = ""
        Dim strcustomers As String = ""

        If isOpenPayment Then
            list_openPayment = " and p.payment_status in (" & PaymentOfflineData.GetListOpen() & ")"
        Else
            list_openPayment = ""
        End If

        If matching_id > -1 Then
            strmatching = " and p.account_movements_id = " & matching_id & ""
        End If

        If customers_id > -1 Then
            strcustomers = " and c.customers_id = " & customers_id
        End If


        Sql = "SELECT customers_abo_payment_method_name type_payment," & _
            " p.id ,cast(p.amount as decimal(10,2)) amount,p.date_added,p.last_modified,p.communication, " & _
            " p.customers_id,p.id id_recovery,ps.name payment_status,p.payment_status payment_status_id,p.account_movements_id id_matching,p.last_status_id,last_status.name last_status, p.date_closed,p.abo_id" & _
            " FROM customers c " & _
            " join payment p on p.customers_id = c.customers_id " & _
            " join payment_status ps on p.payment_status = ps.id " & _
            " left join customers_abo_payment_method capm on capm.customers_abo_payment_method_id = p.payment_method " & _
            " left join payment_status last_status on p.last_status_id = last_status.id " & _
            " where  1 " & strcustomers & list_openPayment & strmatching & _
            " order by p.date_added desc"

        Return Sql

    End Function

    Public Shared Function ReOpenPayment(ByVal id_bankAccountMovement As Integer, ByVal id_payment As Integer, ByVal last_status As String) As String

        Dim sqlRecovery As String
        Dim sqlBankAccountMovement As String

        If last_status = "" Then
            last_status = "null"
        End If
        sqlRecovery = " update payment p " & _
                     " set p.account_movements_id = null" & _
                     ", p.payment_status = " & last_status & _
                     ", p.last_modified = now()" & _
                     ", p.user_modified = " & clsSession.user_id & _
                     ", p.last_status_id = null " & _
                     ", p.date_closed = null " & _
                     " where p.id = " & id_payment


        sqlBankAccountMovement = "update bank_account_movements bam " & _
                                 " set bam.ismatching = " & matching_type.NOMATCHED & ", " & _
                                 " bam.last_modified = now()," & _
                                 " bam.user_modified = " & clsSession.user_id & _
                                 " where account_movements_id = " & id_bankAccountMovement

        Return sqlRecovery & ";" & sqlBankAccountMovement


    End Function
    Public Shared Function ClosePayment(ByVal id_bankAccountMovement As Integer, _
                                       ByVal id_payment As Integer, _
                                       ByVal last_status As PaymentOfflineData.StepPayment, _
                                       ByVal customers_id As Integer) As String

        Return ClosePayment(id_bankAccountMovement, id_payment, last_status, customers_id, PaymentOfflineData.StepPayment.PAID, matching_type.MANUALY)
    End Function

    Public Shared Function ClosePayment(ByVal id_bankAccountMovement As Integer, _
                                        ByVal id_payment As Integer, _
                                        ByVal last_status As PaymentOfflineData.StepPayment, _
                                        ByVal customers_id As Integer, _
                                        ByVal Closed_status As PaymentOfflineData.StepPayment, _
                                        ByVal vmatching_type As matching_type) As String

        Dim sqlRecovery As String
        Dim sqlBankAccountMovement As String
        ' Dim statusPaidRecovery As String

        '  statusPaidRecovery = PlushTools.clsEnum.getValueEnum(PaymentOfflineData.StepPayment.PAID)
        sqlRecovery = PlushData.ClsPayment.GetUpdateClosePayment(id_payment, Closed_status, last_status, id_bankAccountMovement)
        'sqlRecovery = " update payment p " & _
        '             " set p.account_movements_id = " & id_bankAccountMovement & _
        '             ", p.payment_status = " & Closed_status & _
        '             ", p.last_modified = now()" & _
        '             ", p.user_modified = " & clsSession.user_id & _
        '             ", p.last_status_id = " & last_status & _
        '             ", p.date_closed = now() " & _
        '             " where p.id = " & id_payment


        sqlBankAccountMovement = "update bank_account_movements bam " & _
                                 " set bam.ismatching = " & vmatching_type & _
                                 " ,bam.last_modified = now()" & _
                                 " ,bam.user_modified = " & clsSession.user_id & _
                                 " ,bam.customers_id = " & customers_id & _
                                 " where account_movements_id = " & id_bankAccountMovement

        Return sqlRecovery & ";" & sqlBankAccountMovement


    End Function
    'Public Shared Function ClosePaymentBankTransfer(ByVal id_bankAccountMovement As Integer, ByVal id_payment As Integer, ByVal type_payment As String, ByVal amountRemaining As String) As String

    '    Dim sql As String
    '    Dim sqlBankTransfer As String

    '    Dim statusPaidBankTransfer As String
    '    Dim SqlamountRemaining As String = ""
    '    If amountRemaining <> "0" Then
    '        SqlamountRemaining = "bm.amount_remaining = " & amountRemaining & ","
    '    End If

    '    statusPaidBankTransfer = PlushTools.clsEnum.getValueEnum(PaymentOfflineData.StepPayment.PAID)
    '    type_payment = PlushTools.clsEnum.getNameStrEnum(ClsCustomersData.Payment_Method.BANK_TRANSFER)

    '    sqlBankTransfer = " update bank_transfert bm " & _
    '                        " set " & SqlamountRemaining & "bm.account_movements_id = " & id_bankAccountMovement & "," & _
    '                        " bm.payment_status = " & statusPaidBankTransfer & " ," & _
    '                        " bm.last_modified = now()," & _
    '                        " bm.user_modified = " & clsSession.user_id & _
    '                        " where bm.id = " & id_payment



    '    sql = sqlBankTransfer + ";" + ClosePaymentForAllPayment(id_bankAccountMovement, id_payment, type_payment)
    '    Return sql
    'End Function

    'Public Shared Function ClosePaymentOgone(ByVal id_bankAccountMovement As Integer, ByVal id_payment As Integer, ByVal type_payment As String, ByVal amountRemaining As String) As String

    '    Dim sql As String
    '    Dim sqlOgone As String

    '    Dim statusPaidOgone As String

    '    Dim SqlamountRemaining As String = ""
    '    If amountRemaining <> "0" Then
    '        SqlamountRemaining = "p.amount_remaining = " & amountRemaining & ","
    '    End If
    '    statusPaidOgone = PlushTools.clsEnum.getValueEnum(PaymentOfflineData.StepPayment.PAID)

    '    sqlOgone = " update payment p " & _
    '                        " set " & SqlamountRemaining & " p.account_movements_id = " & id_bankAccountMovement & "," & _
    '                        " p.payment_status = " & statusPaidOgone & " ," & _
    '                        " p.last_modified = now()" & _
    '                        " where p.id = " & id_payment


    '    sql = sqlOgone + ";" + ClosePaymentForAllPayment(id_bankAccountMovement, id_payment, type_payment)

    '    Return sql
    'End Function


    'Public Shared Function ClosePaymentDomiciliation(ByVal id_bankAccountMovement As Integer, ByVal id_payment As Integer, ByVal type_payment As String, ByVal amountRemaining As String) As String

    '    Dim sql As String
    '    Dim sqldomiciliation As String

    '    Dim statusPaidDomiciliation As String
    '    Dim SqlamountRemaining As String = ""
    '    If amountRemaining <> "0" Then
    '        SqlamountRemaining = "dp.amount_remaining = " & amountRemaining & ","
    '    End If

    '    statusPaidDomiciliation = PlushTools.clsEnum.getValueEnum(PaymentOfflineData.StepPayment.PAID)

    '    sqldomiciliation = " update payment p " & _
    '                        " set " & SqlamountRemaining & " p.account_movements_id = " & id_bankAccountMovement & "," & _
    '                        " p.payment_status = " & ClsCustomersData.Payment_Method.DOMICILIATION & " ," & _
    '                        " p.last_modified = now()" & _
    '                        " where p.id = " & id_payment


    '    sql = sqldomiciliation + ";" + ClosePaymentForAllPayment(id_bankAccountMovement, id_payment, type_payment)

    '    Return sql
    'End Function

    ' ogone -> payment 
    'update ogone_payment op join payment p on p.reason_pk_name = 'OGONE' and p.reason_pk_value = op.ogone_id
    'set p.payment_status = 19,p.last_modified = now()
    'where p.payment_status not in (19,20,21) and op.ogone_payment_status not in (1,10,4)


    ' dom -> payment
    'select * from domiciliation_payment op join payment p on p.reason_pk_name = 'DOMICILIATION' and p.reason_pk_value = op.domiciliation_id
    ' where p.payment_status not in (19,20,21) and op.payment_status in (5,13,1);

    ' bank_transfer -> payment     
    '    update bank_transfert op join payment p on p.reason_pk_name = 'BANK_TRANSFER' and p.reason_pk_value = op.id
    'set p.payment_status = 19,p.last_modified = now()
    'where p.payment_status not in (19,20,21) and op.status in ('PAYED', 'ERROR');
End Class
