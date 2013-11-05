Module [Global]


    Public Const LowDate As Date = #1/1/1900#
    'Need to be First because other Proprieties us this Connection
    'Friend OleDBConn As New OleDb.OleDbConnection '("Integrated Security=SSPI;User ID=BizzKeys;Packet Size=4096;PassWord=BizzKeys;Data Source='BIZZKEYS-DELL';Tag with column collation when possible=False;Initial Catalog=BizzKeys;Use Procedure for Prepare=1;Auto Translate=True;Persist Security Info=False;Provider='SQLOLEDB.1';Workstation ID='BIZZKEYS-DELL';Use Encryption for Data=False")
    'Friend SQLDBConn As New SqlClient.SqlConnection '("workstation id='BIZZKEYS-DELL';packet size=4096;user id=CashIBA;integrated security=SSPI;data source='BIZZKEYS-DELL';persist security info=False;initial catalog=CashIBA")
    'Friend MySQLDBConn As New MySql.Data.MySqlClient.MySqlConnection
    'Friend UsedConnection As String = ""
    'Friend DBName As String = ""
    'Friend DBConnString As String = ""
    Friend SessionInfo As BizzLib.clsSessionInfo
    Friend BKCombo As BizzLib.clsCombo
    Friend BKGlobal As BizzLib.clsGlobal
    'Friend myBKGlobal As BizzlibNew.BizzLibNew.clsGlobal
    Friend MenuForm As Form

    Public MenuTreeSQLTxt As String = " SELECT systemmenutree.ParentID, systemmenu_1.MenuID, systemmenu_1.MenuLabel, systemmenu_1.MenuForm, " & _
            "          systemmenu_1.MenuIcon, systemmenu_1.MenuIconExpanded, systemmenutree.Sequence, systemmenu_1.MenuStartID,  " & _
            "          systemmenu_1.MenuStartCode, systemmenu_1.MenuStartCode2, systemmenu_1.BrowseTableName, systemmenu_1.BrowseIDField,  " & _
            "          systemmenu_1.BrowseNameField, systemmenu_1.BrowseToMaintMenuID, systemmenu_1.BrowseWhereClause,  " & _
            "          systemmenu_1.BrowseOrderByClause, 0 AS AccessAllowed " & _
            " FROM         systemmenu systemmenu_1 RIGHT OUTER JOIN " & _
            "          systemmenutree ON systemmenu_1.MenuID = systemmenutree.MenuID LEFT OUTER JOIN " & _
            "         systemmenu ON systemmenutree.ParentID = systemmenu.MenuID " & _
            " ORDER BY systemmenutree.Sequence "


#Region "User Associated Data"
    Public Sub DeleteUserLinkedTables(ByVal UserID As Integer)
        DeleteUserPreferdMenu(UserID)
        DeleteUserRoles(UserID)
        DeleteUserFilters(UserID)
        DeleteUserBrowseViews(UserID)
        ' DeleteUserDefaultSets(UserID)
        DeleteUserReports(UserID)
    End Sub
    Public Function DeleteUserPreferdMenu(ByVal UserID As Integer) As Integer
        Dim _DeletedRows As Integer = -1
        Dim _SQLTxt As String
        Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)

        _SQLTxt = "DELETE FROM securityusermenu WHERE UserID = " & UserID
        Try
            _DeletedRows = _Cls1.ExecuteNonQuery(_SQLTxt)
        Catch exDelete As System.Exception
            'Add your error handling code here.
            Throw exDelete
        End Try
        Return _DeletedRows
    End Function
    Public Function DeleteUserRoles(ByVal UserID As Integer) As Integer
        Dim _DeletedRows As Integer = -1
        Dim _SQLTxt As String
        Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)

        _SQLTxt = "DELETE FROM securityuser_role WHERE UserID = " & UserID

        Try
            _DeletedRows = _Cls1.ExecuteNonQuery(_SQLTxt)
        Catch exDelete As System.Exception
            'Add your error handling code here.
            Throw exDelete
        End Try
        Return _DeletedRows
    End Function
    Public Function DeleteUserFilters(ByVal UserID As Integer) As Integer
        Dim _DeletedRows As Integer = -1
        Dim _SQLTxt As String
        Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)

        'WARNING : CASCADE DELETE IS SETUP FOR THIS TABLE IN DATABASE DEFINITION
        '          SO ASSOCIATED GENERAL FILTER SUB WILL ALSO BE DELETED
        _SQLTxt = "DELETE FROM generalfilter WHERE UserID = " & UserID & " AND FilterID > 0"
        '_SQLTxt1 = "DELETE FROM generalfiltersub WHERE FilterID > 0 AND (" & _
        '          " SELECT UserID From generalfilter WHERE generalfilter.FilterID = generalfiltersub.FilterID ) = " & UserID
        Try
            '    _DeletedRows = _cls1.ExecuteNonQuery(_SQLTxt1)
            _DeletedRows = _Cls1.ExecuteNonQuery(_SQLTxt)
        Catch exDelete As System.Exception
            'Add your error handling code here.
            Throw exDelete
        End Try
        Return _DeletedRows
    End Function
    Public Function DeleteUserBrowseViews(ByVal UserID As Integer) As Integer
        Dim _DeletedRows As Integer = -1
        Dim _SQLTxt As String
        Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)

        'WARNING : CASCADE DELETE IS SETUP FOR THIS TABLE IN DATABASE DEFINITION
        '          SO ASSOCIATED GENERAL FILTER SUB WILL ALSO BE DELETED
        _SQLTxt = "DELETE FROM generalbrowseview WHERE UserID = " & UserID & " AND BrowseViewID > 0"
        Try
            _DeletedRows = _Cls1.ExecuteNonQuery(_SQLTxt)
        Catch exDelete As System.Exception
            'Add your error handling code here.
            Throw exDelete
        End Try
        Return _DeletedRows
    End Function
    'Public Function DeleteUserDefaultSets(ByVal UserID As Integer) As Integer
    '    Dim _DeletedRows As Integer = -1
    '    Dim _SQLTxt As String
    '    Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)

    '    'WARNING : CASCADE DELETE IS SETUP FOR THIS TABLE IN DATABASE DEFINITION
    '    '          SO ASSOCIATED GENERAL FILTER SUB WILL ALSO BE DELETED
    '    _SQLTxt = "DELETE FROM generaldefaultset WHERE UserID = " & UserID & " AND DefaultSetID > 0 and TemplateCriteria <> 1 "
    '    Try
    '        _DeletedRows = _Cls1.ExecuteNonQuery(_SQLTxt)
    '    Catch exDelete As System.Exception
    '        'Add your error handling code here.
    '        Throw exDelete
    '    End Try
    '    Return _DeletedRows
    'End Function
    Public Function DeleteUserReports(ByVal UserID As Integer) As Integer
        Dim _DeletedRows As Integer = -1
        Dim _SQLTxt As String
        Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)

        'WARNING : CASCADE DELETE IS SETUP FOR THIS TABLE IN DATABASE DEFINITION
        '          SO ASSOCIATED GENERAL FILTER SUB WILL ALSO BE DELETED
        _SQLTxt = "DELETE FROM generalreport WHERE UserID = " & UserID & " AND ReportID > 0 "
        Try
            _DeletedRows = _Cls1.ExecuteNonQuery(_SQLTxt)
        Catch exDelete As System.Exception
            'Add your error handling code here.
            Throw exDelete
        End Try
        Return _DeletedRows
    End Function

#End Region

#Region "Menu Associated Data"
    Public Sub DeleteMenuLinkedTables(ByVal MenuID As Integer)
        DeleteMenuSub(MenuID)
        DeleteMenuTree(MenuID)
        DeleteMenuTranslation(MenuID)
        DeleteMenuUser(MenuID)
        DeleteMenuRole(MenuID)
    End Sub
    Public Function DeleteMenuSub(ByVal MenuID As Integer) As Integer
        Dim _DeletedRows, _DeletedRows1 As Integer
        Dim _SQLTxt As String
        Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
        _DeletedRows = -1
        _DeletedRows1 = -1
        _SQLTxt = "DELETE FROM systemmenusub WHERE MenuID = " & MenuID
        Try
            _DeletedRows = _Cls1.ExecuteNonQuery(_SQLTxt)
        Catch exDelete As System.Exception
            'Add your error handling code here.
            Throw exDelete
        End Try

        _SQLTxt = "DELETE FROM systemmenusub WHERE SubMenuID = " & MenuID
        Try
            _DeletedRows1 = _Cls1.ExecuteNonQuery(_SQLTxt)
        Catch exDelete As System.Exception
            'Add your error handling code here.
            Throw exDelete
        End Try

        Return _DeletedRows + _DeletedRows1
    End Function
    Public Function DeleteMenuTree(ByVal MenuID As Integer) As Integer
        Dim _DeletedRows, _DeletedRows1 As Integer
        Dim _SQLTxt As String
        Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
        _DeletedRows = -1
        _DeletedRows1 = -1
        _SQLTxt = "DELETE FROM systemmenutree WHERE ParentID = " & MenuID

        Try
            _DeletedRows = _Cls1.ExecuteNonQuery(_SQLTxt)
        Catch exDelete As System.Exception
            'Add your error handling code here.
            Throw exDelete
        End Try

        _SQLTxt = "DELETE FROM systemmenutree WHERE MenuID = " & MenuID
        Try
            _DeletedRows1 = _Cls1.ExecuteNonQuery(_SQLTxt)
        Catch exDelete As System.Exception
            'Add your error handling code here.
            Throw exDelete
        End Try

        Return _DeletedRows + _DeletedRows1
    End Function
    Public Function DeleteMenuTranslation(ByVal MenuID As Integer) As Integer
        Dim _DeletedRows As Integer = -1
        Dim _SQLTxt As String
        Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)

        _SQLTxt = "DELETE FROM systemmenutranslation WHERE MenuID = " & MenuID
        Try
            _DeletedRows = _Cls1.ExecuteNonQuery(_SQLTxt)
        Catch exDelete As System.Exception
            'Add your error handling code here.
            Throw exDelete
        End Try
        Return _DeletedRows
    End Function
    Public Function DeleteMenuUser(ByVal MenuID As Integer) As Integer
        Dim _DeletedRows As Integer = -1
        Dim _SQLTxt As String
        Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)

        _SQLTxt = "DELETE FROM securityusermenu WHERE MenuID = " & MenuID
        Try
            _DeletedRows = _Cls1.ExecuteNonQuery(_SQLTxt)
        Catch exDelete As System.Exception
            'Add your error handling code here.
            Throw exDelete
        End Try
        Return _DeletedRows
    End Function
    Public Function DeleteMenuRole(ByVal MenuID As Integer) As Integer
        Dim _DeletedRows As Integer = -1
        Dim _SQLTxt As String
        Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)

        _SQLTxt = "DELETE FROM securitymenu_role WHERE MenuID = " & MenuID
        Try
            _DeletedRows = _Cls1.ExecuteNonQuery(_SQLTxt)
        Catch exDelete As System.Exception
            'Add your error handling code here.
            Throw exDelete
        End Try
        Return _DeletedRows
    End Function
#End Region

    'Public Sub OleDBConnInitialize()
    '    Dim _XML As New Xml.XmlDocument
    '    Dim _DBConnString As String
    '    'If UsedConnection & "" = "" Or _
    '    '(IsNothing(SQLDBConn) And UsedConnection & "" = "SQL") Or _
    '    '(IsNothing(OleDBConn) And UsedConnection & "" = "OLEDB") Or _
    '    '(IsNothing(MySQLDBConn) And UsedConnection & "" = "MySQL") _
    '    _XML.Load(Application.StartupPath & "\BizzKeys.ini")
    '    UsedConnection = Trim(_XML.DocumentElement("USEDConnection").InnerText)
    '    DBName = Trim(_XML.DocumentElement("DBName").InnerText)
    '    DBConnString = Trim(_XML.DocumentElement("DBConnString").InnerText)
    '    ChangeDBConnection(UsedConnection, DBConnString)
    '    'ChangeDBConnection("OLEDB", _XML.DocumentElement("OLEDBConnectionString").InnerText)
    '    'ChangeDBConnection("SQL", _XML.DocumentElement("SQLConnectionString").InnerText)
    '    'ChangeDBConnection("MySQL", _XML.DocumentElement("MySQLConnectionString").InnerText)
    '    'ChangeDBConnection("ORA", _XML.DocumentElement("OLEDBConnectionString").InnerText)
    'End Sub
    'Public Sub ChangeDBConnection(ByVal ConnectionType As String, ByVal ConnectionString As String)
    '    Select Case ConnectionType
    '        Case "SQL"
    '            SQLDBConn = New SqlClient.SqlConnection(ConnectionString)
    '        Case "OLEDB"
    '            OleDBConn = New OleDb.OleDbConnection(ConnectionString)
    '        Case "MySQL"
    '            MySQLDBConn = New MySql.Data.MySqlClient.MySqlConnection(ConnectionString)
    '        Case "Oracle"

    '    End Select
    'End Sub

    Public Sub CreateSuperUser()
        Dim _objDataSet As New DataSet
        ' Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
        Dim _Row As DataRow
        'Dim _Bld As OleDb.OleDbCommandBuilder
        Dim _TableName As String
        '*************** Currency EUR SETUP ************************************
        _TableName = "systemcurrency"
        _objDataSet.Tables.Add(_TableName)
        Try
            PlushData.clsConnection.FillDataSet(_objDataSet.Tables(_TableName), "SELECT * FROM systemcurrency WHERE CurrCode = 'EUR'")
        Catch eFillDataSet As System.Exception
            Throw eFillDataSet
        End Try
        If _objDataSet.Tables(_TableName).Rows.Count = 0 Then
            _Row = _objDataSet.Tables(_TableName).NewRow
            _Row("CurrCode") = "EUR"
            _Row("Description") = "EURO"
            _Row("RndFact") = 2
            _objDataSet.Tables(_TableName).Rows.Add(_Row)
        Else
            _Row = _objDataSet.Tables(_TableName).Rows(0)
        End If
        '''    _Cls1.UpdateDataSource(_objDataSet.Tables(_TableName))

        '*************** Holding SETUP ************************************
        _TableName = "generalholding"
        _objDataSet.Tables.Add(_TableName)
        Try
            PlushData.clsConnection.FillDataSet(_objDataSet.Tables(_TableName), "SELECT * FROM generalholding WHERE HoldingID = 0")
        Catch eFillDataSet As System.Exception
            Throw eFillDataSet
        End Try
        If _objDataSet.Tables(_TableName).Rows.Count = 0 Then
            _Row = _objDataSet.Tables(_TableName).NewRow
            _Row("HoldingID") = 0
            _Row("Name") = "BaseHolding"
            _Row("CurrCode") = "EUR"
            _objDataSet.Tables(_TableName).Rows.Add(_Row)
        Else
            _Row = _objDataSet.Tables(_TableName).Rows(0)
            _Row("Name") = "BaseHolding"
            _Row("CurrCode") = "EUR"
        End If
        ''' _Cls1.UpdateDataSource(_objDataSet.Tables(_TableName))

        '*************** Address SETUP ************************************
        '_TableName = "GeneralAddress"
        '_objDataSet.Tables.Add(_TableName)
        'Try
        '    dvdpostdata.clsconnection.FillDataSet(_objDataSet.Tables(_TableName), "SELECT * FROM GeneralAddress WHERE AddrID = 0")
        'Catch eFillDataSet As System.Exception
        '    Throw eFillDataSet
        'End Try
        'If _objDataSet.Tables(_TableName).Rows.Count = 0 Then
        '    _Row = _objDataSet.Tables(_TableName).NewRow
        '    _Row("AddrID") = 0
        'Else
        '    _Row = _objDataSet.Tables(_TableName).Rows(0)
        'End If
        '_Cls1.UpdateDataSource(_objDataSet.Tables(_TableName))

        '*************** Entity SETUP ************************************
        _TableName = "generalentity"
        _objDataSet.Tables.Add(_TableName)
        Try
            PlushData.clsConnection.FillDataSet(_objDataSet.Tables(_TableName), "SELECT * FROM generalentity WHERE EntityID = 0")
        Catch eFillDataSet As System.Exception
            Throw eFillDataSet
        End Try
        If _objDataSet.Tables(_TableName).Rows.Count = 0 Then
            _Row = _objDataSet.Tables(_TableName).NewRow
            _Row("EntityID") = 0
            _Row("Name") = "BaseEntity"
            _Row("CurrCode") = "EUR"
            _Row("HoldingID") = 0
            _Row("AddrID") = 0
            _objDataSet.Tables(_TableName).Rows.Add(_Row)
        Else
            _Row = _objDataSet.Tables(_TableName).Rows(0)
            _Row("Name") = "BaseEntity"
            _Row("CurrCode") = "EUR"
            _Row("HoldingID") = 0
            _Row("AddrID") = 0
        End If
        ''' _Cls1.UpdateDataSource(_objDataSet.Tables(_TableName))

        '*************** ROLE SETUP ************************************
        _TableName = "securityrole"
        _objDataSet.Tables.Add(_TableName)
        Try
            PlushData.clsConnection.FillDataSet(_objDataSet.Tables(_TableName), "SELECT * FROM securityrole WHERE RoleID = 0")
        Catch eFillDataSet As System.Exception
            Throw eFillDataSet
        End Try
        If _objDataSet.Tables(_TableName).Rows.Count = 0 Then
            _Row = _objDataSet.Tables(_TableName).NewRow
            _Row("RoleID") = 0
            _Row("Name") = "BaseRole"
            _Row("EntityID") = 0
            _Row("CanModifyGlobalViews") = 1
            _objDataSet.Tables(_TableName).Rows.Add(_Row)
        Else
            _Row = _objDataSet.Tables(_TableName).Rows(0)
            _Row("Name") = "BaseRole"
            _Row("CanModifyGlobalViews") = 1
            _Row("EntityID") = 0
        End If
        ''' _Cls1.UpdateDataSource(_objDataSet.Tables(_TableName))

        '*************** USER SETUP ************************************
        _TableName = "securityuser"
        _objDataSet.Tables.Add(_TableName)
        Try
            PlushData.clsConnection.FillDataSet(_objDataSet.Tables(_TableName), "SELECT * FROM securityuser WHERE UserID = 0")
        Catch eFillDataSet As System.Exception
            Throw eFillDataSet
        End Try
        If _objDataSet.Tables(_TableName).Rows.Count = 0 Then
            _Row = _objDataSet.Tables(_TableName).NewRow
            _Row("UserID") = 0
            _Row("FullName") = "BaseUser"
            _Row("Login") = "BK"
            _Row("PassWord") = "BK"
            _Row("Lang") = "EN"
            _Row("DefaultRoleID") = 0
            _Row("BannerVisible") = 1
            _Row("ShortCutID") = 0
            _Row("ShowInTaskBar") = 0
            _Row("AutoHideMenu") = 0
            _objDataSet.Tables(_TableName).Rows.Add(_Row)
        Else
            _Row = _objDataSet.Tables(_TableName).Rows(0)
            _Row("FullName") = "BaseUser"
            _Row("Login") = "BK"
            _Row("PassWord") = "BK"
            _Row("Lang") = "EN"
            _Row("DefaultRoleID") = 0
            _Row("BannerVisible") = 1
            _Row("ShortCutID") = 0
            _Row("ShowInTaskBar") = 0
            _Row("AutoHideMenu") = 0
        End If
        ''' _Cls1.UpdateDataSource(_objDataSet.Tables(_TableName))

    End Sub
    Public Delegate Sub ContectMenuClick_EventHandler(ByVal Sender As Object, ByVal OwnerForm As Form)

End Module
