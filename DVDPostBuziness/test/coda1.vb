Public Class LineHeaderImpl


    Public Function isSameFamily(ByRef line As String) As Boolean
        If line.Length <> 128 Then Return False

        Return getApplicationCode(line).Equals("05") And getLineID(line).Equals("0") And getZero1(line).Equals("0000") And getBlank1(line).Equals("  ") And getzero2(line).Equals("00000") And getBlank2(line).Equals(" ")
    End Function


    'Identification de l'enregistrement = 0 (voir annexe V)
    Public Function getLineID(ByRef line As String) As String
        Return line.Substring(0, 1)
    End Function

    'Zéros
    Public Function getZero1(ByRef line As String) As String
        Return line.Substring(1, 4)
    End Function

    'Date de création (JJMMAA) (voir commentaires, point 1)
    Public Function getDateCreated(ByRef line As String) As String
        Return line.Substring(5, 6)
    End Function

    'N° de code de l'institution financière
    Public Function getFinancialInstitutionNumber(ByRef line As String) As String
        Return line.Substring(11, 3)
    End Function

    'Code application = 05
    Public Function getApplicationCode(ByRef line As String) As String
        Return line.Substring(14, 2)
    End Function

    'Si duplicata : "D", sinon un blanc
    Public Function getDuplicata(ByRef line As String) As String
        Return line.Substring(16, 1)
    End Function

    'Blancs
    Public Function getBlank1(ByRef line As String) As String
        Return line.Substring(17, 2)
    End Function

    'Zéros
    Public Function getzero2(ByRef line As String) As String
        Return line.Substring(19, 5)
    End Function

    'N° d'immatriculation
    Public Function getImmatriculationNumber(ByRef line As String) As String
        Return line.Substring(24, 10)
    End Function

    'Nom du destinataire
    Public Function getRecipientName(ByRef line As String) As String
        Return line.Substring(34, 26)
    End Function

    'N° d'identification du destinataire - n° TVA précédé de 2 zéros pour les assujettis (009N); - sinon, n° d'immatriculation national (11N) ou zéros
    Public Function getRecipientID(ByRef line As String) As String
        Return line.Substring(60, 11)
    End Function

    'N° d'identification du titulaire du compte - n° TVA précédé de 2 zéros pour les assujettis; (009N) - sinon, n° d'immatriculation national (11N) ou zéros
    Public Function getRecipientAccountOwnerID(ByRef line As String) As String
        Return line.Substring(71, 11)
    End Function

    'Blancs
    Public Function getBlank2(ByRef line As String) As String
        Return line.Substring(82, 1)
    End Function

    'Code "application distincte" (voir annexe V)
    Public Function getDistinctApplicationCode(ByRef line As String) As String
        Return line.Substring(83, 5)
    End Function

    'Blancs
    Public Function getBlank3(ByRef line As String) As String
        Return line.Substring(88, 39)
    End Function

    'Code version = 1 (voir annexe V)
    Public Function getVersionCode(ByRef line As String) As String
        Return line.Substring(127, 1)
    End Function

End Class

Public Class LineAncienSoldeImpl

    Public Function isSameFamily(ByRef line As String) As Boolean
        Return getRecordID(line).Equals("1") And getBlank1(line).Equals(" ")
    End Function


    'Identification de l'enregistrement = 1
    Public Function getRecordID(ByRef line As String) As String
        Return line.Substring(0, 1)
    End Function

    'Blanc
    Public Function getBlank1(ByRef line As String) As String
        Return line.Substring(1, 1)
    End Function

    'N° de séquence de l'extrait de compte papier ou zéros
    Public Function getBankExtractSequenceNumber(ByRef line As String) As String
        Return line.Substring(2, 3)
    End Function

    'N° de compte
    Public Function getAccountNumber(ByRef line As String) As String
        Return line.Substring(5, 12)
    End Function

    'Codes internes ou blancs (voir commentaires, point 6)
    Public Function getInternalCodes(ByRef line As String) As String
        Return line.Substring(17, 10)
    End Function

    'Extension de l'identification du compte ou blancs (voir commentaires point 7)
    Public Function getBankExtractSequenceNumberExtension(ByRef line As String) As String
        Return line.Substring(27, 15)
    End Function

    'Signe ancien solde : 0 = crédit (+ pour le client) 1 = débit (- pour le client)
    Public Function getSoldeSign(ByRef line As String) As String
        Return line.Substring(42, 1)
    End Function

    'Ancien solde (12 pos. + 3 décimales)
    Public Function getOldSolde(ByRef line As String) As String
        Return line.Substring(43, 15)
    End Function

    'Date de l'ancien solde (JJMMAA) ou zéros
    Public Function getOldSoldeDate(ByRef line As String) As String
        Return line.Substring(58, 6)
    End Function

    'Nom du titulaire du compte
    Public Function getTitulaireName(ByRef line As String) As String
        Return line.Substring(64, 26)
    End Function

    'Libellé du compte (voir commentaires, point 8)
    Public Function getAccountLibelle(ByRef line As String) As String
        Return line.Substring(90, 35)
    End Function

    'N° de séquence de l'extrait journalier codifié ou zéros (voir commentaires, point 17)
    Public Function getDailyExtractSequenceNumber(ByRef line As String) As String
        Return line.Substring(125, 3)
    End Function

End Class

Public Class LineMessageLibreDomUnpaid0

    Public Const REMISE_TITLE As String = "    REMISE "
    Public Const DATE_PIVOT_TITLE As String = "DATE PIVOT "
    Public Const BLANKS_11X As String = "           "



    Public Function isSameFamily(ByRef line As String) As Boolean
        Return getBlank1(line).Equals(" ") And getPivotDate(line).Substring(2, 1).Equals("/") And getPivotDate(line).Substring(5, 1).Equals("/") And getRemiseTitle(line).Equals(REMISE_TITLE) And getPivotTitle(line).Equals(DATE_PIVOT_TITLE) And getRecordID(line).Equals("4") And getBlank3(line).Equals(BLANKS_11X)
    End Function

    'Identification de l'enregistrement = 4
    Public Function getRecordID(ByRef line As String) As String
        Return line.Substring(0, 1)
    End Function

    'Blanc
    Public Function getBlank1(ByRef line As String) As String
        Return line.Substring(1, 1)
    End Function

    'N° de séquence de l'enregistrement (commence par 0001 et est augmenté de 1 pour chaque enregistrement "message libre"; ce numéro recommence à 0001 s'il est placé dans un enregistrement après l'enregistrement "nouveau solde" (voir point 9.3.1)
    Public Function getRecordSequenceNumber(ByRef line As String) As String
        Return line.Substring(2, 4)
    End Function

    'N° de détail; commence par 0000 et est augmenté de 1 par enregistrement "message" se apportant au même message
    Public Function getDetailNumber(ByRef line As String) As String
        Return line.Substring(6, 4)
    End Function

    'Numéro de référence de l'institution financière ou blancs
    Public Function getBankReferenceNumber(ByRef line As String) As String
        Return line.Substring(10, 13)
    End Function

    'Extension du numéro de référence de l'institution financière ou blancs
    Public Function getBankReferenceNumberExtension(ByRef line As String) As String
        Return line.Substring(23, 8)
    End Function

    'Code structure du message 0 = non structuré 1 = structuré
    Public Function getMessageStructureCode(ByRef line As String) As String
        Return line.Substring(31, 1)
    End Function

    'Remise Title
    Public Function getRemiseTitle(ByRef line As String) As String
        Return line.Substring(32, 11)
    End Function

    'Remise Identification
    Public Function getRemiseValue(ByRef line As String) As String
        Return line.Substring(43, 13)
    End Function

    'Pivot Date Title
    Public Function getPivotTitle(ByRef line As String) As String
        Return line.Substring(56, 11)
    End Function

    'Pivot Date JJ/MM/AA
    Public Function getPivotDate(ByRef line As String) As String
        Return line.Substring(67, 10)
    End Function

    'Blank
    Public Function getBlank(ByRef line As String) As String
        Return line.Substring(77, 1)
    End Function

    'PivotID
    Public Function getPivotID(ByRef line As String) As String
        Return line.Substring(78, 5)
    End Function

    'Comments1
    Public Function getComments1(ByRef line As String) As String
        Return line.Substring(83, 29)
    End Function


    'Message d'exécution (code famille de l'opération - code opération) Blancs si aucun message d'exécution
    Public Function getExecutionMessage(ByRef line As String) As String
        Return line.Substring(112, 4)
    End Function

    'Blancs
    Public Function getBlank3(ByRef line As String) As String
        Return line.Substring(116, 11)
    End Function

    'Code lien avec enregistrement de données suivant 0 = pas d'enregistrement "information" (enregistrement 3), ni de message libre (enregistrement 4) qui suit 1 = un enregistrement "information" suit 2 = un message libre suit
    Public Function getCodeLink(ByRef line As String) As String
        Return line.Substring(127, 1)
    End Function

End Class

Public Class LineMessageLibreDomUnpaid02

    Public Const REMISE_TITLE As String = "    DE VOTRE REMISE DATE PIVOT "


    Public Function isSameFamily(ByRef line As String) As Boolean
        Return getBlank1(line).Equals(" ") And getPivotDate(line).Substring(2, 1).Equals("/") And getPivotDate(line).Substring(5, 1).Equals("/") And getRemiseTitle(line).Equals(REMISE_TITLE) And getRecordID(line).Equals("4")
    End Function

    'Identification de l'enregistrement = 4
    Public Function getRecordID(ByRef line As String) As String
        Return line.Substring(0, 1)
    End Function

    'Blanc
    Public Function getBlank1(ByRef line As String) As String
        Return line.Substring(1, 1)
    End Function

    'N° de séquence de l'enregistrement (commence par 0001 et est augmenté de 1 pour chaque enregistrement "message libre"; ce numéro recommence à 0001 s'il est placé dans un enregistrement après l'enregistrement "nouveau solde" (voir point 9.3.1)
    Public Function getRecordSequenceNumber(ByRef line As String) As String
        Return line.Substring(2, 4)
    End Function

    'N° de détail; commence par 0000 et est augmenté de 1 par enregistrement "message" se apportant au même message
    Public Function getDetailNumber(ByRef line As String) As String
        Return line.Substring(6, 4)
    End Function

    'Numéro de référence de l'institution financière ou blancs
    Public Function getBankReferenceNumber(ByRef line As String) As String
        Return line.Substring(10, 13)
    End Function

    'Extension du numéro de référence de l'institution financière ou blancs
    Public Function getBankReferenceNumberExtension(ByRef line As String) As String
        Return line.Substring(23, 8)
    End Function

    'Code structure du message 0 = non structuré 1 = structuré
    Public Function getMessageStructureCode(ByRef line As String) As String
        Return line.Substring(31, 1)
    End Function

    '32
    Public Function getRemiseTitle(ByRef line As String) As String
        Return line.substring(32, 31)
    End Function

    '63
    Public Function getPivotDate(ByRef line As String) As String
        Return line.substring(63, 10)
    End Function

    '73
    Public Function getPivotID(ByRef line As String) As String
        Return line.substring(73, 9)
    End Function

    '82
    Public Function getEnd0(ByRef line As String) As String
        Return line.substring(82, 30)
    End Function


    'Message d'exécution (code famille de l'opération - code opération) Blancs si aucun message d'exécution
    Public Function getExecutionMessage(ByRef line As String) As String
        Return line.Substring(112, 4)
    End Function

    'Blancs
    Public Function getBlank3(ByRef line As String) As String
        Return line.Substring(116, 11)
    End Function

    'Code lien avec enregistrement de données suivant 0 = pas d'enregistrement "information" (enregistrement 3), ni de message libre (enregistrement 4) qui suit 1 = un enregistrement "information" suit 2 = un message libre suit
    Public Function getCodeLink(ByRef line As String) As String
        Return line.Substring(127, 1)
    End Function

End Class

Public Class LineMessageLibreDomUnpaid1

    Public Const REFERENCE_TITLE As String = "  ref: "
    Public Const AMOUNT_TITLE As String = " MONTANT:"
    Public Const DEVISE As String = "EUR"
    Public Const BLANKS_28X As String = "                            "
    Public Const BLANKS_11X As String = "           "


    Public Function isSameFamily(ByRef line As String) As Boolean
        Return getBlank1(line).Equals(" ") And getRecordID(line).Equals("4") And getReferenceTitle(line).Equals(REFERENCE_TITLE) And getAmountTitle(line).Equals(AMOUNT_TITLE) And getDevise(line).Equals(DEVISE) And getBlank2(line).Equals(BLANKS_28X) And getBlank3(line).Equals(BLANKS_11X)
    End Function

    'Identification de l'enregistrement = 4
    Public Function getRecordID(ByRef line As String) As String
        Return line.Substring(0, 1)
    End Function

    'Blanc
    Public Function getBlank1(ByRef line As String) As String
        Return line.Substring(1, 1)
    End Function

    'N° de séquence de l'enregistrement (commence par 0001 et est augmenté de 1 pour chaque enregistrement "message libre"; ce numéro recommence à 0001 s'il est placé dans un enregistrement après l'enregistrement "nouveau solde" (voir point 9.3.1)
    Public Function getRecordSequenceNumber(ByRef line As String) As String
        Return line.Substring(2, 4)
    End Function

    'N° de détail; commence par 0000 et est augmenté de 1 par enregistrement "message" se apportant au même message
    Public Function getDetailNumber(ByRef line As String) As String
        Return line.Substring(6, 4)
    End Function

    'Numéro de référence de l'institution financière ou blancs
    Public Function getBankReferenceNumber(ByRef line As String) As String
        Return line.Substring(10, 13)
    End Function

    'Extension du numéro de référence de l'institution financière ou blancs
    Public Function getBankReferenceNumberExtension(ByRef line As String) As String
        Return line.Substring(23, 8)
    End Function

    'Code structure du message 0 = non structuré 1 = structuré
    Public Function getMessageStructureCode(ByRef line As String) As String
        Return line.Substring(31, 1)
    End Function

    'Reference title
    Public Function getReferenceTitle(ByRef line As String) As String
        Return line.Substring(32, 7)
    End Function

    'Communication structuree
    Public Function getReferenceValue(ByRef line As String) As String
        Return line.Substring(39, 14)
    End Function

    'Montant title
    Public Function getAmountTitle(ByRef line As String) As String
        Return line.Substring(53, 9)
    End Function

    'Montant
    Public Function getAmountValue(ByRef line As String) As String
        Return line.Substring(62, 19)
    End Function

    'Devise
    Public Function getDevise(ByRef line As String) As String
        Return line.Substring(81, 3)
    End Function

    'Blancs
    Public Function getBlank2(ByRef line As String) As String
        Return line.Substring(84, 28)
    End Function

    'Message d'exécution (code famille de l'opération - code opération) Blancs si aucun message d'exécution
    Public Function getExecutionMessage(ByRef line As String) As String
        Return line.Substring(112, 4)
    End Function

    'Blancs
    Public Function getBlank3(ByRef line As String) As String
        Return line.Substring(116, 11)
    End Function

    'Code lien avec enregistrement de données suivant 0 = pas d'enregistrement "information" (enregistrement 3), ni de message libre (enregistrement 4) qui suit 1 = un enregistrement "information" suit 2 = un message libre suit
    Public Function getCodeLink(ByRef line As String) As String
        Return line.Substring(127, 1)
    End Function

End Class

Public Class LineMessageLibreDomUnpaid3



    Public Const COMMUNICATION_TITLE As String = "  COMMUNICATION : "
    Public Const BLANKS_11X As String = "           "


    Public Function isSameFamily(ByRef line As String) As Boolean


        Return getBlank1(line).Equals(" ") And getRecordID(line).Equals("4") And getCommunicationTitle(line).Equals(COMMUNICATION_TITLE) And getBlank3(line).Equals(BLANKS_11X)
    End Function

    'Identification de l'enregistrement = 4
    Public Function getRecordID(ByRef line As String) As String
        Return line.Substring(0, 1)
    End Function

    'Blanc
    Public Function getBlank1(ByRef line As String) As String
        Return line.Substring(1, 1)
    End Function

    'N° de séquence de l'enregistrement (commence par 0001 et est augmenté de 1 pour chaque enregistrement "message libre"; ce numéro recommence à 0001 s'il est placé dans un enregistrement après l'enregistrement "nouveau solde" (voir point 9.3.1)
    Public Function getRecordSequenceNumber(ByRef line As String) As String
        Return line.Substring(2, 4)
    End Function

    'N° de détail; commence par 0000 et est augmenté de 1 par enregistrement "message" se apportant au même message
    Public Function getDetailNumber(ByRef line As String) As String
        Return line.Substring(6, 4)
    End Function

    'Numéro de référence de l'institution financière ou blancs
    Public Function getBankReferenceNumber(ByRef line As String) As String
        Return line.Substring(10, 13)
    End Function

    'Extension du numéro de référence de l'institution financière ou blancs
    Public Function getBankReferenceNumberExtension(ByRef line As String) As String
        Return line.Substring(23, 8)
    End Function

    'Code structure du message 0 = non structuré 1 = structuré
    Public Function getMessageStructureCode(ByRef line As String) As String
        Return line.Substring(31, 1)
    End Function

    'Communication title
    Public Function getCommunicationTitle(ByRef line As String) As String
        Return line.Substring(32, 18)
    End Function

    'Communication
    Public Function getCommunicationValue(ByRef line As String) As String
        Return line.Substring(50, 62)
    End Function

    'Message d'exécution (code famille de l'opération - code opération) Blancs si aucun message d'exécution
    Public Function getExecutionMessage(ByRef line As String) As String
        Return line.Substring(112, 4)
    End Function

    'Blancs
    Public Function getBlank3(ByRef line As String) As String
        Return line.Substring(116, 11)
    End Function

    'Code lien avec enregistrement de données suivant 0 = pas d'enregistrement "information" (enregistrement 3), ni de message libre (enregistrement 4) qui suit 1 = un enregistrement "information" suit 2 = un message libre suit
    Public Function getCodeLink(ByRef line As String) As String
        Return line.Substring(127, 1)
    End Function


End Class

Public Class versement
    Public Function versement(ByVal line As String) As String
        Return line.Substring(31, 9)
    End Function

    Public Function amount(ByVal line As String) As Integer
        Return line.Substring(42, 4)
    End Function
    Public Function communication(ByVal line As String) As String
        Return line.Substring(65, 12)
    End Function

    Public Function referenceNumberBank(ByVal line As String) As String
        Return line.Substring(10, 13)
    End Function
    Public Function communicationType(ByRef line As String) As String
        Return line.Substring(31, 1)
    End Function
End Class
