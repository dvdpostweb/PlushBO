Public Class clsFileZilla

    Private _InitNode As Xml.XmlNode
    Private _Xmldoc As Xml.XmlDocument
    Private _Root As Xml.XmlNode
    Private _fullPath As String = ""

    Const KeyFILEZILLATemplate As String = "FILEZILLATEMPLATE"

    Public Enum FormatFile
        STUDIO_ID = 0
        IMDB_ID
        LANGUAGE_AUDIO_ID
        LANGUAGE_SUBTITLE_ID
        QUALITY
    End Enum
    Public Sub save()
        If _fullPath = "" Then Return
        _Xmldoc.Save(_fullPath)
    End Sub
    Private Sub copyFileModel(ByVal pathDestination As String)


        Dim sourcePath As String = Configuration.ConfigurationManager.AppSettings(KeyFILEZILLATemplate)
        _fullPath = pathDestination & "/" & Date.Today.ToString("dd-MM-yy") & "FileZilla.xml"
        System.IO.File.Copy(sourcePath, _fullPath)

        _Xmldoc = New Xml.XmlDocument()
        _Xmldoc.Load(_fullPath)

        _Root = _Xmldoc.SelectSingleNode("/FileZilla3/Queue/Server")
        _InitNode = _Root.LastChild
        'If Not searchXMLNode Is Nothing Then
        '    searchXMLNode = searchXMLNode.SelectSingleNode("Name")
        '    _InitNode = searchXMLNode

        'End If



    End Sub

    Private Function CreateNodeValue(ByVal key As String, ByVal value As String) As Xml.XmlElement
        Dim newChildXmlElt As Xml.XmlElement

        newChildXmlElt = _Xmldoc.CreateElement(key)
        Dim text As Xml.XmlText = _Xmldoc.CreateTextNode(value)
        newChildXmlElt.AppendChild(text)

        Return newChildXmlElt

    End Function
    Public Sub InsertNodeQueue(ByVal fullpath As String, ByVal filename As String, ByVal size As String)

        If _fullPath = "" Then Return

        Dim newXmlElt As Xml.XmlElement
        Dim newChildXmlElt As Xml.XmlElement
        newXmlElt = _Xmldoc.CreateElement("File")

        newChildXmlElt = CreateNodeValue("LocalFile", fullpath)
        newXmlElt.InsertAfter(newChildXmlElt, newXmlElt.LastChild)

        newChildXmlElt = CreateNodeValue("RemoteFile", filename)
        newXmlElt.InsertAfter(newChildXmlElt, newXmlElt.LastChild)

        newChildXmlElt = CreateNodeValue("RemotePath", "1 0 5 media 11 secureflash")
        newXmlElt.InsertAfter(newChildXmlElt, newXmlElt.LastChild)


        newChildXmlElt = CreateNodeValue("Download", "0")
        newXmlElt.InsertAfter(newChildXmlElt, newXmlElt.LastChild)

        newChildXmlElt = CreateNodeValue("Size", size.ToString())
        newXmlElt.InsertAfter(newChildXmlElt, newXmlElt.LastChild)


        newChildXmlElt = CreateNodeValue("TransferMode", "0")
        newXmlElt.InsertAfter(newChildXmlElt, newXmlElt.LastChild)

        _Root.InsertAfter(newXmlElt, _InitNode)
    End Sub
    Public Sub DeleteFile()
        System.IO.File.Delete(_fullPath)
    End Sub
    Public Sub New(ByVal pathDestination As String)
        copyFileModel(pathDestination)
    End Sub
End Class
