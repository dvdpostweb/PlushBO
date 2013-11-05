Module UpdateStart

    Public Declare Function GetConsoleTitle Lib "kernel32" Alias "GetConsoleTitleA" (ByVal lpConsoleTitle As String, ByVal nSize As Integer) As Integer

    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer

    Public Declare Function ShowWindow Lib "user32" Alias "ShowWindow" (ByVal hwnd As Integer, ByVal nCmdShow As Integer) As Integer

    Const SW_HIDE = 0

    Const SW_SHOWNORMAL = 1

    Const SW_NORMAL = 1

    Const SW_SHOWMINIMIZED = 2

    Sub hideConsole()

        '<VBFixedString(150)>

        Dim strTitle As String

        strTitle = Space(256)

        Dim rtnLen As Long

        rtnLen = GetConsoleTitle(strTitle, 256)

        If rtnLen > 0 Then

            strTitle = Left$(strTitle, rtnLen)

        End If

        'MsgBox(strTitle)

        Dim hwnd As Int32

        hwnd = FindWindow(vbNullString, strTitle)

        ' hide the app 

        ShowWindow(hwnd, SW_HIDE)

    End Sub

    Sub Main()

        Dim strpath As String
        hideConsole()
        strpath = Configuration.ConfigurationManager.AppSettings("pathUpdate")
        If Not CopyFilesDirectory(strpath) Then
            If MsgBox("votre version n'est pas à jour ! cela peut engendrer des soucis, Voulez quand meme executer le programme ? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start(New ProcessStartInfo("plush.exe"))
                Return
            Else
                Process.Start("connectBizkeys.bat")
            End If
        Else
            Try
                System.Diagnostics.Process.Start(New ProcessStartInfo("Plush.exe"))
            Catch ex As Exception
                Dim s As String
                If Not ex.InnerException Is Nothing Then
                    s = ex.InnerException.Message
                End If
                MsgBox(ex.Message + " " + s, "Test2")
            End Try

        End If
        ' System.Diagnostics.Process.Start(New ProcessStartInfo("dvdpost.exe"))


    End Sub

    Private Function CopyFilesDirectory(ByVal path As String) As Boolean

        'path = path + "\" & nameDestination
        Dim finfo As System.IO.FileInfo
        Try


            If System.IO.Directory.Exists(path) Then

                For Each Item As String In System.IO.Directory.GetFiles(path)
                    finfo = New System.IO.FileInfo(Item)
                    System.IO.File.Copy(Item, finfo.Name, True)
                Next

                Return True
            End If
            Return False
        Catch ex As Exception
            Dim s As String
            If Not ex.InnerException Is Nothing Then
                s = ex.InnerException.Message
            End If
            MsgBox(ex.Message + " " + s, "Test1")

            Return False
        End Try




    End Function

End Module
