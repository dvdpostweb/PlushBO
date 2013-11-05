'Imports log4net
Imports System
'Public Class EntryPoint
'    ' Application entry point.
'    Public Shared Sub start()
'        ' Uncomment the next line to enable log4net internal debugging
'        ' log4net.helpers.LogLog.InternalDebugging = true;

'        ' This will instruct log4net to look for a configuration file
'        ' called ConsoleApp.exe.config in the application base
'        ' directory (i.e. the directory containing ConsoleApp.exe)
'        log4net.Config.XmlConfigurator.Configure()

'        ' Create a logger
'        Dim log As ILog = LogManager.GetLogger(GetType(EntryPoint))

'        ' Log an info level message
'        If log.IsInfoEnabled Then log.Info("Application [ConsoleApp] Start")

'        ' Invoke shared LogEvents method on LoggingExample class
'        clsMsgError.LogEvents()

'        Console.Write("Press Enter to exit...")
'        Console.ReadLine()

'        If log.IsInfoEnabled Then log.Info("Application [ConsoleApp] Stop")

'        ' It's not possible to use shutdown hooks in the .NET Compact Framework,
'        ' so you have manually shutdown log4net to free all resoures.
'        LogManager.Shutdown()
'    End Sub
'End Class

Public Class clsMsgError

    Const MAILTO As String = "im@dvdpost.be"
    Const Subject As String = "ERROR DVDPost Bo : "
    Const Author As String = " User : "
    Const PATHLOG As String = "Path_LOG"
    'Private Shared ReadOnly log As log4net.ILog = log4net.LogManager.GetLogger(GetType(clsMsgError))

    'Public Shared Sub LogEvents()
    '    ' Log a debug message. Test if debug is enabled before
    '    ' attempting to log the message. This is not required but
    '    ' can make running without logging faster.
    '    If log.IsDebugEnabled Then log.Debug("This is a debug message")

    '    Try
    '        'Bar()
    '    Catch ex As Exception
    '        ' Log an error with an exception
    '        log.Error("Exception thrown from method Bar", ex)
    '    End Try

    '    log.Error("Hey this is an error!")

    '    Dim disposableFrame As IDisposable

    '    Try
    '        ' Push a message on to the Nested Diagnostic Context stack
    '        log4net.NDC.Push("NDC_Message")

    '        log.Warn("This should have an NDC message")

    '        ' Set a Mapped Diagnostic Context value  
    '        log4net.MDC.Set("auth", "auth-none")
    '        log.Warn("This should have an MDC message for the key 'auth'")
    '    Finally
    '        ' The NDC message is popped off the stack by using the Dispose method
    '        If (Not disposableFrame Is Nothing) Then disposableFrame.Dispose()
    '    End Try

    '    log.Warn("See the NDC has been popped of! The MDC 'auth' key is still with us.")
    'End Sub



    Public Shared Function InsertLogMsg(ByVal Type As PlushData.clsMsgError.processType, ByVal msgError As String, Optional ByVal customers_id As String = Nothing) As Boolean
        Dim sql As String
        Dim cpt As Integer
        Dim strsubject As String
        msgError = msgError + " version : " & PlushData.clsSession.Version
        strsubject = Subject & PlushTools.clsEnum.getNameStrEnum(Type) & Author & PlushData.clsSession.user_id
        sql = PlushData.clsMsgError.InsertLogMsg(Type, msgError, customers_id)
        cpt = PlushData.clsConnection.ExecuteNonQuery(sql, True)

        clsMail.SendMail(msgError, strsubject, MAILTO)
        Return cpt = 1
    End Function


    Public Shared Function InsertLogMsg(ByVal Type As PlushData.clsMsgError.processType, ByVal ex As Exception, Optional ByVal customers_id As String = Nothing) As Boolean
        Dim msgerror As String

        msgerror = ex.Message & " " & ex.StackTrace
        If Not ex.InnerException Is Nothing Then
            msgerror = msgerror & " InnerException: " & ex.InnerException.Message
        End If
        Return InsertLogMsg(Type, msgerror, customers_id)
    End Function

    Public Shared Function FileAppend(ByVal namefile As String, ByVal strmsg As String) As Boolean
        Dim path As String = ""

        Try
            namefile = namefile + "_" + DateTime.Now.ToString("dd-MM-yy") & ".txt"
            strmsg = DateTime.Now.ToString() + " " + PlushData.clsConnection.typeEnv + " " + strmsg
            path = Configuration.ConfigurationManager.AppSettings(PATHLOG)
            path = path + namefile
            PlushTools.clsFile.WriteFileAppend(path, strmsg)

            Return True
        Catch ex As Exception
            InsertLogMsg(PlushData.clsMsgError.processType.Batch, ex.Message & " " & path & " " & strmsg)
            'Microsoft.VisualBasic.MsgBox(" Error File " & ex.Message & " " & strmsg)
            Return False
        End Try

    End Function

    Public Shared Function FileAppend(ByVal strmsg As String) As Boolean
        Dim path As String = " "
        Dim namefile As String
        Try
            namefile = "Log_BO_PLUSH_" + DateTime.Now.ToString("dd-MM-yy") & ".txt"
            strmsg = DateTime.Now.ToString() + " " + PlushData.clsConnection.typeEnv + " " + strmsg
            path = Configuration.ConfigurationManager.AppSettings(PATHLOG)
            path = path + namefile
            PlushTools.clsFile.WriteFileAppend(path, strmsg)

            Return True
        Catch ex As Exception
            InsertLogMsg(PlushData.clsMsgError.processType.Batch, ex.Message & " " & path & " " & strmsg)
            'Microsoft.VisualBasic.MsgBox(" Error File " & ex.Message & " " & strmsg)
            Return False
        End Try

    End Function
    Public Shared Function MsgBox(ByVal strMsg As String) As Object
        If Not PlushData.clsSession.isBatch Then
            Return Microsoft.VisualBasic.MsgBox(strMsg)
        Else
            FileAppend(strMsg)
            Return Nothing
        End If
    End Function

    Public Shared Function MsgBox(ByVal strMsg As String, ByVal msgBoxType As MsgBoxStyle) As MsgBoxResult

        If Not PlushData.clsSession.isBatch Then
            Return Microsoft.VisualBasic.MsgBox(strMsg, msgBoxType)
        Else

            FileAppend(strMsg)
            Return MsgBoxResult.Ok
        End If
    End Function
End Class
