Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Windows.Forms
Imports System.Xml

Namespace BizzLib
    <StandardModule> _
    Friend NotInheritable Class moGeneral
        ' Methods
        Public Shared Sub OleDBConnInitialize(ByVal SessionInfo As clsSessionInfo)
            Dim document As New XmlDocument
            document.Load((Application.StartupPath & "\BizzKeys.ini"))
            SessionInfo.DBConnType = Strings.Trim(document.DocumentElement.Item("USEDConnection").InnerText)
            SessionInfo.DBName = Strings.Trim(document.DocumentElement.Item("DBName").InnerText)
            SessionInfo.DBConnString = Strings.Trim(document.DocumentElement.Item("DBConnString").InnerText)
            SessionInfo.ChangeDBConnection
        End Sub

    End Class
End Namespace

