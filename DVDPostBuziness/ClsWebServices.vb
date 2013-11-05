Public Class ClsWebServices

    '1   le script n existe pas
    '2   le script génère une erreur
    '3   la clôture du script provoque une erreur
    '4   la class du script n est pas correct
    '5   code activation est vide
    '6   l'action a déjà été exécutée (expiré)
    '7   code d'activation non sujet a une action particulière
    '8   code sujet a une action mais ne comporte pas le liaison
    '9   déjà présent dans la table de parrainage
    '10 email non matché (cas sans parrainage)
    '11 parrain plus abonné 

    Private Enum msgErrorParrainage
        SCRIPT_NOTEXIST = 1
        SCRIPT_ERROR = 2
        SCRIPTCLOTURE_ERROR = 3
        SCRIPT_NOCORRECT = 4
        ACTIVATION_EMPTY = 5
        ACTIVATION_USED = 6
        ACTIVATION_NOGFC = 7
        ACTIVATION_NOLINK = 8
        ACTIVATION_ALREADYEXIST = 9
        CLASSIQUE = 10
        PARRAIN_NOABO = 11


    End Enum

    Private Enum msgErrorLink
        CODE_ID_EMPTY = 1
        CODE_NO_EXIST = 2
        ALREADY_EXIST = 3
        ERROR_DB = 4
        CUSTOMER_ID_EMPTY = 5
    End Enum

    Private Enum Params
        ISITE
        ICODE
        IDAYS
        ITYPESUSPEND
        IID
        IUSERS
        IPRODUCT
        ISEND
    End Enum
    Public Enum KeyWebService
        WEBSERVICESPONSOR
        WEBSERVICELINKCARD
        WEBSERVICERECOMMENDATION
        WEBSERVICESUSPEND
        WEBSERVICEUNSUSPEND
        WEBSERVICEMOVIEDETAILS
        WEBSERVICEVOD
        WEBSERVICERECOMMANDATIONDVD

    End Enum

    Public Enum TypeSuspend
        PAYMENT
        HOLIDAYS
    End Enum

    Private Shared Function Getrespons(ByVal ReceiveStream As IO.Stream) As String
        Dim result As String = ""
        Dim encode As Text.Encoding = System.Text.Encoding.GetEncoding("ISO-8859-1")

        ' Pipe the stream to a higher level stream reader with the required encoding format.
        Dim readStream As New IO.StreamReader(ReceiveStream, encode)
        Console.WriteLine(ControlChars.Cr + "Response stream received")
        Dim read(256) As [Char]

        ' Read 256 charcters at a time    .
        Dim count As Integer = readStream.Read(read, 0, 256)
        Console.WriteLine("HTML..." + ControlChars.Lf + ControlChars.Cr)
        While count > 0

            ' Dump the 256 characters on a string and display the string onto the console.
            Dim str As New [String](read, 0, count)
            result = result + str
            count = readStream.Read(read, 0, 256)

        End While

        ' Release the resources of stream object.
        readStream.Close()

        Return result

    End Function
    'Private Shared Function getdatatable(ByVal flux As String) As DataTable

    '    Dim doc As Xml.XmlDocument = New Xml.XmlDocument()
    '    doc.LoadXml(flux)
    '    Dim xmlReader As Xml.XmlReader = New Xml.XmlNodeReader(doc)
    '    Dim ds As New DataSet
    '    Try
    '        ds.ReadXml(xmlReader)
    '        xmlReader.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    Return ds.Tables(0)


    'End Function
    Private Shared Function GetSiteEnv() As String
        Dim site As String

        If PlushData.clsSession.isEnvTest Then
            site = "test"
        Else
            site = "www.dvdpost.be"
        End If

        Return site
    End Function
    Private Shared Function CallUrl(ByVal customers_id As Integer, ByVal nb_days As Integer, ByVal suspended As TypeSuspend, ByVal typeWebService As KeyWebService) As DataTable
        Dim request As System.Net.WebRequest
        Dim respons As System.Net.WebResponse
        Dim url As String
        Dim ds As New DataSet


        Try
            url = Configuration.ConfigurationManager.AppSettings(PlushTools.clsEnum.getNameStrEnum(typeWebService))
            'url = "http://www.dvdpost.be/webservice/actions.php?customers_id=206183&activation_code=12"
            url = url.Replace(PlushTools.clsEnum.getNameStrEnum(Params.IID), customers_id)
            url = url.Replace(PlushTools.clsEnum.getNameStrEnum(Params.IDAYS), nb_days)
            url = url.Replace(PlushTools.clsEnum.getNameStrEnum(Params.ITYPESUSPEND), PlushTools.clsEnum.getNameStrEnum(suspended))
            url = url.Replace(PlushTools.clsEnum.getNameStrEnum(Params.IUSERS), PlushData.clsSession.user_id)
            url = url.Replace(PlushTools.clsEnum.getNameStrEnum(Params.ISITE), GetSiteEnv())
            Dim ourUri As New Uri(url)


            request = System.Net.HttpWebRequest.Create(url)
            respons = request.GetResponse()
            ds.ReadXml(respons.GetResponseStream())
            respons.Close()
        Catch ex As Exception
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.WebService, ex.Message, customers_id)
            Return Nothing
        End Try
        Return ds.Tables(0)
    End Function
    Private Shared Function CallUrl(ByVal customers_id As Integer, ByVal activation_code As String, ByVal typeWebService As KeyWebService) As DataTable
        Dim request As System.Net.WebRequest
        Dim respons As System.Net.WebResponse
        Dim url As String = ""
        Dim ds As New DataSet

        Try
            url = Configuration.ConfigurationManager.AppSettings(PlushTools.clsEnum.getNameStrEnum(typeWebService))
            'url = "http://www.dvdpost.be/webservice/actions.php?customers_id=206183&activation_code=12"
            url = url.Replace(PlushTools.clsEnum.getNameStrEnum(Params.IID), customers_id)
            url = url.Replace(PlushTools.clsEnum.getNameStrEnum(Params.ICODE), activation_code)
            url = url.Replace(PlushTools.clsEnum.getNameStrEnum(Params.ISITE), GetSiteEnv())
            Dim ourUri As New Uri(url)

            request = System.Net.HttpWebRequest.Create(url)
            respons = request.GetResponse()

            ds.ReadXml(respons.GetResponseStream())
            respons.Close()
        Catch ex As Exception
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Email, ex.Message + " url : " & url, customers_id)
            Return Nothing
        End Try
        Return ds.Tables(0)
    End Function
    Private Shared Function CallUrlMail(ByVal customers_id As Integer, ByVal products_id As Integer, ByVal type As String, ByVal typeWebService As KeyWebService) As String
        Dim request As System.Net.WebRequest
        Dim respons As System.Net.WebResponse
        Dim url As String = ""
        Dim result As String
        Dim ds As New DataSet

        Try
            url = Configuration.ConfigurationManager.AppSettings(PlushTools.clsEnum.getNameStrEnum(typeWebService))
            'url = "http://www.dvdpost.be/webservice/actions.php?customers_id=206183&activation_code=12"
            url = url.Replace(PlushTools.clsEnum.getNameStrEnum(Params.IID), customers_id)
            url = url.Replace(PlushTools.clsEnum.getNameStrEnum(Params.ISITE), GetSiteEnv())
            url = url.Replace(PlushTools.clsEnum.getNameStrEnum(Params.IPRODUCT), products_id)
            url = url.Replace(PlushTools.clsEnum.getNameStrEnum(Params.ISEND), type)
            Dim ourUri As New Uri(url)

            request = System.Net.HttpWebRequest.Create(url)
            respons = request.GetResponse()
            result = Getrespons(respons.GetResponseStream())
            ' ds.ReadXml(respons.GetResponseStream())
            respons.Close()
        Catch ex As Exception
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Email, ex.Message + " url : " & url, customers_id)
            Return Nothing
        End Try
        'Return ds.Tables(0)
        Return result
    End Function
    Public Shared Function CallUrlVOD(ByVal customers_id As Integer) As String
        Dim result As String = Nothing
        Dim cpt As Integer = 0

        While cpt < 10 And result Is Nothing
            result = CallUrlMail(customers_id, -1, "", KeyWebService.WEBSERVICEVOD)
            cpt += 1
            Threading.Thread.Sleep(10)
        End While

        Return result
    End Function

    Public Shared Function CallUrlMOVIEDETAIL(ByVal customers_id As Integer, ByVal products_id As Integer, ByVal send As String) As String
        Dim result As String = Nothing
        Dim cpt As Integer = 0

        While cpt < 10 And result Is Nothing
            result = CallUrlMail(customers_id, products_id, send, KeyWebService.WEBSERVICEMOVIEDETAILS)
            cpt += 1
            Threading.Thread.Sleep(10)
        End While

        Return result
    End Function


    Public Shared Function CallUrlRecommendationDVD(ByVal customers_id As Integer, ByVal products_id As String) As String
        Dim result As String = Nothing
        Dim cpt As Integer = 0

        While cpt < 10 And result Is Nothing
            result = CallUrlMail(customers_id, products_id, "", KeyWebService.WEBSERVICERECOMMANDATIONDVD)
            cpt += 1
            Threading.Thread.Sleep(10)
        End While


        Return result
    End Function

    Public Shared Function CallUrlRecommendation(ByVal customers_id As Integer) As DataTable
        Dim dt As DataTable = Nothing
        Dim cpt As Integer = 0

        While cpt < 10 And dt Is Nothing
            dt = CallUrl(customers_id, String.Empty, KeyWebService.WEBSERVICERECOMMENDATION)
            cpt += 1
            Threading.Thread.Sleep(10)
        End While


        Return dt
    End Function

    Public Shared Function CallUnSuspended(ByVal customers_id As Integer, ByVal dateReturn As DateTime, ByVal suspended As TypeSuspend) As Boolean
        Dim dt As DataTable
        Dim nb_days As Double = (dateReturn - DateTime.Now).TotalDays()
        Try
            dt = CallUrl(customers_id, nb_days, suspended, KeyWebService.WEBSERVICEUNSUSPEND)
            If dt Is Nothing Then Throw New Exception("result webservice null")
            If dt.Rows(0)("status") <> "true" Then
                'MsgBox(dt.Rows(0)("error"), MsgBoxStyle.Critical)
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            PlushBuziness.clsMsgError.MsgBox(ex.Message)
        End Try
    End Function
    Public Shared Function CallSuspended(ByVal customers_id As Integer, ByVal dateReturn As DateTime, ByVal suspended As TypeSuspend) As Boolean
        Dim dt As DataTable
        Dim nb_days As Double = (dateReturn - DateTime.Now).TotalDays()
        dt = CallUrl(customers_id, nb_days, suspended, KeyWebService.WEBSERVICESUSPEND)

        If dt.Rows(0)("status") <> "true" Then
            'MsgBox(dt.Rows(0)("error"), MsgBoxStyle.Critical)
            Return False
        Else
            Return True
        End If
    End Function
    Private Shared Function ErrorManagmentLink(ByVal customers_id As Integer, ByVal activation_code As String, ByVal dr As DataRow) As Boolean
        Dim code_error As msgErrorLink
        Dim msg As String = ""
        If dr("status") = "true" Then Return True
        code_error = dr("Error")

        Select Case code_error
            Case msgErrorLink.ERROR_DB
                msg = "Error Interne (" & PlushTools.clsEnum.getNameStrEnum(code_error) & ")"
            Case Else
                msg = PlushTools.clsEnum.getNameStrEnum(code_error)

        End Select

        MsgBox(msg, MsgBoxStyle.Critical)
        Return False

    End Function

    Private Shared Function ErrorManagmentParrain(ByVal customers_id As Integer, ByVal activation_code As String, ByVal dr As DataRow) As Boolean
        Dim code_error As msgErrorParrainage
        Dim msg As String = ""
        If dr("status") = "true" Then Return True
        code_error = dr("Error")

        Select Case code_error
            Case msgErrorParrainage.SCRIPT_ERROR, msgErrorParrainage.SCRIPT_NOCORRECT, msgErrorParrainage.SCRIPT_NOTEXIST, msgErrorParrainage.SCRIPTCLOTURE_ERROR, msgErrorParrainage.ACTIVATION_NOGFC
                msg = "Error Interne (" & PlushTools.clsEnum.getNameStrEnum(code_error) & ")"
            Case msgErrorParrainage.CLASSIQUE
                Return False
            Case Else
                msg = PlushTools.clsEnum.getNameStrEnum(code_error)

        End Select

        MsgBox(msg, MsgBoxStyle.Critical)
        Return False

    End Function
    Public Shared Function CallUrllinkCard(ByVal customers_id As Integer, ByVal activation_code As String) As Boolean
        Dim dt As DataTable

        dt = CallUrl(customers_id, activation_code, KeyWebService.WEBSERVICELINKCARD)
        Return ErrorManagmentLink(customers_id, activation_code, dt.Rows(0))
    End Function

    Public Shared Function CallUrlSponsor(ByVal customers_id As Integer, ByVal activation_code As String) As Boolean
        Dim dt As DataTable
        dt = CallUrl(customers_id, activation_code, KeyWebService.WEBSERVICESPONSOR)
        Return ErrorManagmentParrain(customers_id, activation_code, dt.Rows(0))
    End Function
End Class
