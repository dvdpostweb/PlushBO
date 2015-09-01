Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization
Imports System.Xml
Imports System.Xml.Schema

Namespace BizzLib
    <Serializable, DesignerCategory("code"), DebuggerStepThrough, ToolboxItem(True)> _
    Public Class dsExcelImport
        Inherits DataSet
        ' Methods
        Public Sub New()
            Dim list As ArrayList = dsExcelImport.__ENCList
            SyncLock list
                dsExcelImport.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.InitClass
            Dim handler As CollectionChangeEventHandler = New CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
            AddHandler Me.Tables.CollectionChanged, handler
            AddHandler Me.Relations.CollectionChanged, handler
        End Sub

        Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
            Dim list As ArrayList = dsExcelImport.__ENCList
            SyncLock list
                dsExcelImport.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Dim s As String = Conversions.ToString(info.GetValue("XmlSchema", GetType(String)))
            If (Not s Is Nothing) Then
                Dim dataSet As New DataSet
                dataSet.ReadXmlSchema(New XmlTextReader(New StringReader(s)))
                If (Not dataSet.Tables.Item("GeneralExcelImport") Is Nothing) Then
                    Me.Tables.Add(New GeneralExcelImportDataTable(dataSet.Tables.Item("GeneralExcelImport")))
                End If
                If (Not dataSet.Tables.Item("GeneralExcelImportSub") Is Nothing) Then
                    Me.Tables.Add(New GeneralExcelImportSubDataTable(dataSet.Tables.Item("GeneralExcelImportSub")))
                End If
                If (Not dataSet.Tables.Item("GeneralExcelImport1") Is Nothing) Then
                    Me.Tables.Add(New GeneralExcelImport1DataTable(dataSet.Tables.Item("GeneralExcelImport1")))
                End If
                If (Not dataSet.Tables.Item("GeneralExcelImportTemplate") Is Nothing) Then
                    Me.Tables.Add(New GeneralExcelImportTemplateDataTable(dataSet.Tables.Item("GeneralExcelImportTemplate")))
                End If
                Me.DataSetName = dataSet.DataSetName
                Me.Prefix = dataSet.Prefix
                Me.Namespace = dataSet.Namespace
                Me.Locale = dataSet.Locale
                Me.CaseSensitive = dataSet.CaseSensitive
                Me.EnforceConstraints = dataSet.EnforceConstraints
                Me.Merge(dataSet, False, MissingSchemaAction.Add)
                Me.InitVars
            Else
                Me.InitClass
            End If
            Me.GetSerializationData(info, context)
            Dim handler As CollectionChangeEventHandler = New CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
            AddHandler Me.Tables.CollectionChanged, handler
            AddHandler Me.Relations.CollectionChanged, handler
        End Sub

        Public Overrides Function Clone() As DataSet
            Dim import As dsExcelImport = DirectCast(MyBase.Clone, dsExcelImport)
            import.InitVars
            Return import
        End Function

        Protected Overrides Function GetSchemaSerializable() As XmlSchema
            Dim w As New MemoryStream
            Me.WriteXmlSchema(New XmlTextWriter(w, Nothing))
            w.Position = 0
            Return XmlSchema.Read(New XmlTextReader(w), Nothing)
        End Function

        Private Sub InitClass()
            Me.DataSetName = "dsExcelImport"
            Me.Prefix = ""
            Me.Namespace = "http://tempuri.org/dsExcelImport.xsd"
            Me.Locale = New CultureInfo("en-US")
            Me.CaseSensitive = False
            Me.EnforceConstraints = True
            Me.tableGeneralExcelImport = New GeneralExcelImportDataTable
            Me.Tables.Add(Me.tableGeneralExcelImport)
            Me.tableGeneralExcelImportSub = New GeneralExcelImportSubDataTable
            Me.Tables.Add(Me.tableGeneralExcelImportSub)
            Me.tableGeneralExcelImport1 = New GeneralExcelImport1DataTable
            Me.Tables.Add(Me.tableGeneralExcelImport1)
            Me.tableGeneralExcelImportTemplate = New GeneralExcelImportTemplateDataTable
            Me.Tables.Add(Me.tableGeneralExcelImportTemplate)
        End Sub

        Friend Sub InitVars()
            Me.tableGeneralExcelImport = DirectCast(Me.Tables.Item("GeneralExcelImport"), GeneralExcelImportDataTable)
            If (Not Me.tableGeneralExcelImport Is Nothing) Then
                Me.tableGeneralExcelImport.InitVars
            End If
            Me.tableGeneralExcelImportSub = DirectCast(Me.Tables.Item("GeneralExcelImportSub"), GeneralExcelImportSubDataTable)
            If (Not Me.tableGeneralExcelImportSub Is Nothing) Then
                Me.tableGeneralExcelImportSub.InitVars
            End If
            Me.tableGeneralExcelImport1 = DirectCast(Me.Tables.Item("GeneralExcelImport1"), GeneralExcelImport1DataTable)
            If (Not Me.tableGeneralExcelImport1 Is Nothing) Then
                Me.tableGeneralExcelImport1.InitVars
            End If
            Me.tableGeneralExcelImportTemplate = DirectCast(Me.Tables.Item("GeneralExcelImportTemplate"), GeneralExcelImportTemplateDataTable)
            If (Not Me.tableGeneralExcelImportTemplate Is Nothing) Then
                Me.tableGeneralExcelImportTemplate.InitVars
            End If
        End Sub

        Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
            Me.Reset
            Dim dataSet As New DataSet
            dataSet.ReadXml(reader)
            If (Not dataSet.Tables.Item("GeneralExcelImport") Is Nothing) Then
                Me.Tables.Add(New GeneralExcelImportDataTable(dataSet.Tables.Item("GeneralExcelImport")))
            End If
            If (Not dataSet.Tables.Item("GeneralExcelImportSub") Is Nothing) Then
                Me.Tables.Add(New GeneralExcelImportSubDataTable(dataSet.Tables.Item("GeneralExcelImportSub")))
            End If
            If (Not dataSet.Tables.Item("GeneralExcelImport1") Is Nothing) Then
                Me.Tables.Add(New GeneralExcelImport1DataTable(dataSet.Tables.Item("GeneralExcelImport1")))
            End If
            If (Not dataSet.Tables.Item("GeneralExcelImportTemplate") Is Nothing) Then
                Me.Tables.Add(New GeneralExcelImportTemplateDataTable(dataSet.Tables.Item("GeneralExcelImportTemplate")))
            End If
            Me.DataSetName = dataSet.DataSetName
            Me.Prefix = dataSet.Prefix
            Me.Namespace = dataSet.Namespace
            Me.Locale = dataSet.Locale
            Me.CaseSensitive = dataSet.CaseSensitive
            Me.EnforceConstraints = dataSet.EnforceConstraints
            Me.Merge(dataSet, False, MissingSchemaAction.Add)
            Me.InitVars
        End Sub

        Private Sub SchemaChanged(ByVal sender As Object, ByVal e As CollectionChangeEventArgs)
            If (e.Action = CollectionChangeAction.Remove) Then
                Me.InitVars
            End If
        End Sub

        Private Function ShouldSerializeGeneralExcelImport() As Boolean
            Return False
        End Function

        Private Function ShouldSerializeGeneralExcelImport1() As Boolean
            Return False
        End Function

        Private Function ShouldSerializeGeneralExcelImportSub() As Boolean
            Return False
        End Function

        Private Function ShouldSerializeGeneralExcelImportTemplate() As Boolean
            Return False
        End Function

        Protected Overrides Function ShouldSerializeRelations() As Boolean
            Return False
        End Function

        Protected Overrides Function ShouldSerializeTables() As Boolean
            Return False
        End Function


        ' Properties
        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property GeneralExcelImport As GeneralExcelImportDataTable
            Get
                Return Me.tableGeneralExcelImport
            End Get
        End Property

        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property GeneralExcelImport1 As GeneralExcelImport1DataTable
            Get
                Return Me.tableGeneralExcelImport1
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property GeneralExcelImportSub As GeneralExcelImportSubDataTable
            Get
                Return Me.tableGeneralExcelImportSub
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property GeneralExcelImportTemplate As GeneralExcelImportTemplateDataTable
            Get
                Return Me.tableGeneralExcelImportTemplate
            End Get
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        Private tableGeneralExcelImport As GeneralExcelImportDataTable
        Private tableGeneralExcelImport1 As GeneralExcelImport1DataTable
        Private tableGeneralExcelImportSub As GeneralExcelImportSubDataTable
        Private tableGeneralExcelImportTemplate As GeneralExcelImportTemplateDataTable

        ' Nested Types
        <DebuggerStepThrough, DefaultMember("Item")> _
        Public Class GeneralExcelImport1DataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event GeneralExcelImport1RowChanged As GeneralExcelImport1RowChangeEventHandler
            Public Event GeneralExcelImport1RowChanging As GeneralExcelImport1RowChangeEventHandler
            Public Event GeneralExcelImport1RowDeleted As GeneralExcelImport1RowChangeEventHandler
            Public Event GeneralExcelImport1RowDeleting As GeneralExcelImport1RowChangeEventHandler

            ' Methods
            Friend Sub New()
                MyBase.New("GeneralExcelImport1")
                Dim list As ArrayList = GeneralExcelImport1DataTable.__ENCList
                SyncLock list
                    GeneralExcelImport1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitClass
            End Sub

            Friend Sub New(ByVal table As DataTable)
                MyBase.New(table.TableName)
                Dim list As ArrayList = GeneralExcelImport1DataTable.__ENCList
                SyncLock list
                    GeneralExcelImport1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
                Me.DisplayExpression = table.DisplayExpression
            End Sub

            Public Sub AddGeneralExcelImport1Row(ByVal row As GeneralExcelImport1Row)
                Me.Rows.Add(row)
            End Sub

            Public Function AddGeneralExcelImport1Row(ByVal ExcelImportID As Integer, ByVal ImportType As String, ByVal Name As String, ByVal Description As String, ByVal ExcelFileName As String, ByVal SheetName As String, ByVal FirstLineIsColName As Boolean, ByVal FromRow As Integer, ByVal ToRow As Integer) As GeneralExcelImport1Row
                Dim row As GeneralExcelImport1Row = DirectCast(Me.NewRow, GeneralExcelImport1Row)
                row.ItemArray = New Object() { ExcelImportID, ImportType, Name, Description, ExcelFileName, SheetName, FirstLineIsColName, FromRow, ToRow }
                Me.Rows.Add(row)
                Return row
            End Function

            Public Overrides Function Clone() As DataTable
                Dim table As GeneralExcelImport1DataTable = DirectCast(MyBase.Clone, GeneralExcelImport1DataTable)
                table.InitVars
                Return table
            End Function

            Protected Overrides Function CreateInstance() As DataTable
                Return New GeneralExcelImport1DataTable
            End Function

            Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            Protected Overrides Function GetRowType() As Type
                Return GetType(GeneralExcelImport1Row)
            End Function

            Private Sub InitClass()
                Me.columnExcelImportID = New DataColumn("ExcelImportID", GetType(Integer), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnExcelImportID)
                Me.columnImportType = New DataColumn("ImportType", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnImportType)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnName)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnDescription)
                Me.columnExcelFileName = New DataColumn("ExcelFileName", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnExcelFileName)
                Me.columnSheetName = New DataColumn("SheetName", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnSheetName)
                Me.columnFirstLineIsColName = New DataColumn("FirstLineIsColName", GetType(Boolean), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnFirstLineIsColName)
                Me.columnFromRow = New DataColumn("FromRow", GetType(Integer), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnFromRow)
                Me.columnToRow = New DataColumn("ToRow", GetType(Integer), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnToRow)
                Me.columnExcelImportID.AllowDBNull = False
            End Sub

            Friend Sub InitVars()
                Me.columnExcelImportID = Me.Columns.Item("ExcelImportID")
                Me.columnImportType = Me.Columns.Item("ImportType")
                Me.columnName = Me.Columns.Item("Name")
                Me.columnDescription = Me.Columns.Item("Description")
                Me.columnExcelFileName = Me.Columns.Item("ExcelFileName")
                Me.columnSheetName = Me.Columns.Item("SheetName")
                Me.columnFirstLineIsColName = Me.Columns.Item("FirstLineIsColName")
                Me.columnFromRow = Me.Columns.Item("FromRow")
                Me.columnToRow = Me.Columns.Item("ToRow")
            End Sub

            Public Function NewGeneralExcelImport1Row() As GeneralExcelImport1Row
                Return DirectCast(Me.NewRow, GeneralExcelImport1Row)
            End Function

            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New GeneralExcelImport1Row(builder)
            End Function

            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.GeneralExcelImport1RowChangedEvent Is Nothing) Then
                    Dim handler As GeneralExcelImport1RowChangeEventHandler = Me.GeneralExcelImport1RowChangedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New GeneralExcelImport1RowChangeEvent(DirectCast(e.Row, GeneralExcelImport1Row), e.Action))
                    End If
                End If
            End Sub

            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.GeneralExcelImport1RowChangingEvent Is Nothing) Then
                    Dim handler As GeneralExcelImport1RowChangeEventHandler = Me.GeneralExcelImport1RowChangingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New GeneralExcelImport1RowChangeEvent(DirectCast(e.Row, GeneralExcelImport1Row), e.Action))
                    End If
                End If
            End Sub

            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.GeneralExcelImport1RowDeletedEvent Is Nothing) Then
                    Dim handler As GeneralExcelImport1RowChangeEventHandler = Me.GeneralExcelImport1RowDeletedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New GeneralExcelImport1RowChangeEvent(DirectCast(e.Row, GeneralExcelImport1Row), e.Action))
                    End If
                End If
            End Sub

            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.GeneralExcelImport1RowDeletingEvent Is Nothing) Then
                    Dim handler As GeneralExcelImport1RowChangeEventHandler = Me.GeneralExcelImport1RowDeletingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New GeneralExcelImport1RowChangeEvent(DirectCast(e.Row, GeneralExcelImport1Row), e.Action))
                    End If
                End If
            End Sub

            Public Sub RemoveGeneralExcelImport1Row(ByVal row As GeneralExcelImport1Row)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            Friend ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            Friend ReadOnly Property ExcelFileNameColumn As DataColumn
                Get
                    Return Me.columnExcelFileName
                End Get
            End Property

            Friend ReadOnly Property ExcelImportIDColumn As DataColumn
                Get
                    Return Me.columnExcelImportID
                End Get
            End Property

            Friend ReadOnly Property FirstLineIsColNameColumn As DataColumn
                Get
                    Return Me.columnFirstLineIsColName
                End Get
            End Property

            Friend ReadOnly Property FromRowColumn As DataColumn
                Get
                    Return Me.columnFromRow
                End Get
            End Property

            Friend ReadOnly Property ImportTypeColumn As DataColumn
                Get
                    Return Me.columnImportType
                End Get
            End Property

            Public ReadOnly Default Property Item(ByVal index As Integer) As GeneralExcelImport1Row
                Get
                    Return DirectCast(Me.Rows.Item(index), GeneralExcelImport1Row)
                End Get
            End Property

            Friend ReadOnly Property NameColumn As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property

            Friend ReadOnly Property SheetNameColumn As DataColumn
                Get
                    Return Me.columnSheetName
                End Get
            End Property

            Friend ReadOnly Property ToRowColumn As DataColumn
                Get
                    Return Me.columnToRow
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnDescription As DataColumn
            Private columnExcelFileName As DataColumn
            Private columnExcelImportID As DataColumn
            Private columnFirstLineIsColName As DataColumn
            Private columnFromRow As DataColumn
            Private columnImportType As DataColumn
            Private columnName As DataColumn
            Private columnSheetName As DataColumn
            Private columnToRow As DataColumn
        End Class

        <DebuggerStepThrough> _
        Public Class GeneralExcelImport1Row
            Inherits DataRow
            ' Methods
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableGeneralExcelImport1 = DirectCast(Me.Table, GeneralExcelImport1DataTable)
            End Sub

            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImport1.DescriptionColumn)
            End Function

            Public Function IsExcelFileNameNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImport1.ExcelFileNameColumn)
            End Function

            Public Function IsFirstLineIsColNameNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImport1.FirstLineIsColNameColumn)
            End Function

            Public Function IsFromRowNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImport1.FromRowColumn)
            End Function

            Public Function IsImportTypeNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImport1.ImportTypeColumn)
            End Function

            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImport1.NameColumn)
            End Function

            Public Function IsSheetNameNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImport1.SheetNameColumn)
            End Function

            Public Function IsToRowNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImport1.ToRowColumn)
            End Function

            Public Sub SetDescriptionNull()
                Me.Item(Me.tableGeneralExcelImport1.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetExcelFileNameNull()
                Me.Item(Me.tableGeneralExcelImport1.ExcelFileNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetFirstLineIsColNameNull()
                Me.Item(Me.tableGeneralExcelImport1.FirstLineIsColNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetFromRowNull()
                Me.Item(Me.tableGeneralExcelImport1.FromRowColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetImportTypeNull()
                Me.Item(Me.tableGeneralExcelImport1.ImportTypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetNameNull()
                Me.Item(Me.tableGeneralExcelImport1.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetSheetNameNull()
                Me.Item(Me.tableGeneralExcelImport1.SheetNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetToRowNull()
                Me.Item(Me.tableGeneralExcelImport1.ToRowColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralExcelImport1.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImport1.DescriptionColumn) = Value
                End Set
            End Property

            Public Property ExcelFileName As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralExcelImport1.ExcelFileNameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImport1.ExcelFileNameColumn) = Value
                End Set
            End Property

            Public Property ExcelImportID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tableGeneralExcelImport1.ExcelImportIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralExcelImport1.ExcelImportIDColumn) = Value
                End Set
            End Property

            Public Property FirstLineIsColName As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tableGeneralExcelImport1.FirstLineIsColNameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tableGeneralExcelImport1.FirstLineIsColNameColumn) = Value
                End Set
            End Property

            Public Property FromRow As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralExcelImport1.FromRowColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralExcelImport1.FromRowColumn) = Value
                End Set
            End Property

            Public Property ImportType As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralExcelImport1.ImportTypeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImport1.ImportTypeColumn) = Value
                End Set
            End Property

            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralExcelImport1.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImport1.NameColumn) = Value
                End Set
            End Property

            Public Property SheetName As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralExcelImport1.SheetNameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImport1.SheetNameColumn) = Value
                End Set
            End Property

            Public Property ToRow As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralExcelImport1.ToRowColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralExcelImport1.ToRowColumn) = Value
                End Set
            End Property


            ' Fields
            Private tableGeneralExcelImport1 As GeneralExcelImport1DataTable
        End Class

        <DebuggerStepThrough> _
        Public Class GeneralExcelImport1RowChangeEvent
            Inherits EventArgs
            ' Methods
            Public Sub New(ByVal row As GeneralExcelImport1Row, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            Public ReadOnly Property Row As GeneralExcelImport1Row
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As GeneralExcelImport1Row
        End Class

        Public Delegate Sub GeneralExcelImport1RowChangeEventHandler(ByVal sender As Object, ByVal e As GeneralExcelImport1RowChangeEvent)

        <DebuggerStepThrough, DefaultMember("Item")> _
        Public Class GeneralExcelImportDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event GeneralExcelImportRowChanged As GeneralExcelImportRowChangeEventHandler
            Public Event GeneralExcelImportRowChanging As GeneralExcelImportRowChangeEventHandler
            Public Event GeneralExcelImportRowDeleted As GeneralExcelImportRowChangeEventHandler
            Public Event GeneralExcelImportRowDeleting As GeneralExcelImportRowChangeEventHandler

            ' Methods
            Friend Sub New()
                MyBase.New("GeneralExcelImport")
                Dim list As ArrayList = GeneralExcelImportDataTable.__ENCList
                SyncLock list
                    GeneralExcelImportDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitClass
            End Sub

            Friend Sub New(ByVal table As DataTable)
                MyBase.New(table.TableName)
                Dim list As ArrayList = GeneralExcelImportDataTable.__ENCList
                SyncLock list
                    GeneralExcelImportDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
                Me.DisplayExpression = table.DisplayExpression
            End Sub

            Public Sub AddGeneralExcelImportRow(ByVal row As GeneralExcelImportRow)
                Me.Rows.Add(row)
            End Sub

            Public Function AddGeneralExcelImportRow(ByVal ExcelImportID As Integer, ByVal ImportType As String, ByVal Name As String, ByVal Description As String, ByVal ExcelFileName As String, ByVal SheetName As String, ByVal FirstLineIsColName As Boolean, ByVal FromRow As Integer, ByVal ToRow As Integer) As GeneralExcelImportRow
                Dim row As GeneralExcelImportRow = DirectCast(Me.NewRow, GeneralExcelImportRow)
                row.ItemArray = New Object() { ExcelImportID, ImportType, Name, Description, ExcelFileName, SheetName, FirstLineIsColName, FromRow, ToRow }
                Me.Rows.Add(row)
                Return row
            End Function

            Public Overrides Function Clone() As DataTable
                Dim table As GeneralExcelImportDataTable = DirectCast(MyBase.Clone, GeneralExcelImportDataTable)
                table.InitVars
                Return table
            End Function

            Protected Overrides Function CreateInstance() As DataTable
                Return New GeneralExcelImportDataTable
            End Function

            Public Function FindByExcelImportID(ByVal ExcelImportID As Integer) As GeneralExcelImportRow
                Return DirectCast(Me.Rows.Find(New Object() { ExcelImportID }), GeneralExcelImportRow)
            End Function

            Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            Protected Overrides Function GetRowType() As Type
                Return GetType(GeneralExcelImportRow)
            End Function

            Private Sub InitClass()
                Me.columnExcelImportID = New DataColumn("ExcelImportID", GetType(Integer), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnExcelImportID)
                Me.columnImportType = New DataColumn("ImportType", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnImportType)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnName)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnDescription)
                Me.columnExcelFileName = New DataColumn("ExcelFileName", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnExcelFileName)
                Me.columnSheetName = New DataColumn("SheetName", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnSheetName)
                Me.columnFirstLineIsColName = New DataColumn("FirstLineIsColName", GetType(Boolean), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnFirstLineIsColName)
                Me.columnFromRow = New DataColumn("FromRow", GetType(Integer), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnFromRow)
                Me.columnToRow = New DataColumn("ToRow", GetType(Integer), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnToRow)
                Me.Constraints.Add(New UniqueConstraint("dsExcelImportKey1", New DataColumn() { Me.columnExcelImportID }, True))
                Me.columnExcelImportID.AllowDBNull = False
                Me.columnExcelImportID.Unique = True
            End Sub

            Friend Sub InitVars()
                Me.columnExcelImportID = Me.Columns.Item("ExcelImportID")
                Me.columnImportType = Me.Columns.Item("ImportType")
                Me.columnName = Me.Columns.Item("Name")
                Me.columnDescription = Me.Columns.Item("Description")
                Me.columnExcelFileName = Me.Columns.Item("ExcelFileName")
                Me.columnSheetName = Me.Columns.Item("SheetName")
                Me.columnFirstLineIsColName = Me.Columns.Item("FirstLineIsColName")
                Me.columnFromRow = Me.Columns.Item("FromRow")
                Me.columnToRow = Me.Columns.Item("ToRow")
            End Sub

            Public Function NewGeneralExcelImportRow() As GeneralExcelImportRow
                Return DirectCast(Me.NewRow, GeneralExcelImportRow)
            End Function

            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New GeneralExcelImportRow(builder)
            End Function

            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.GeneralExcelImportRowChangedEvent Is Nothing) Then
                    Dim generalExcelImportRowChangedEvent As GeneralExcelImportRowChangeEventHandler = Me.GeneralExcelImportRowChangedEvent
                    If (Not generalExcelImportRowChangedEvent Is Nothing) Then
                        generalExcelImportRowChangedEvent.Invoke(Me, New GeneralExcelImportRowChangeEvent(DirectCast(e.Row, GeneralExcelImportRow), e.Action))
                    End If
                End If
            End Sub

            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.GeneralExcelImportRowChangingEvent Is Nothing) Then
                    Dim generalExcelImportRowChangingEvent As GeneralExcelImportRowChangeEventHandler = Me.GeneralExcelImportRowChangingEvent
                    If (Not generalExcelImportRowChangingEvent Is Nothing) Then
                        generalExcelImportRowChangingEvent.Invoke(Me, New GeneralExcelImportRowChangeEvent(DirectCast(e.Row, GeneralExcelImportRow), e.Action))
                    End If
                End If
            End Sub

            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.GeneralExcelImportRowDeletedEvent Is Nothing) Then
                    Dim generalExcelImportRowDeletedEvent As GeneralExcelImportRowChangeEventHandler = Me.GeneralExcelImportRowDeletedEvent
                    If (Not generalExcelImportRowDeletedEvent Is Nothing) Then
                        generalExcelImportRowDeletedEvent.Invoke(Me, New GeneralExcelImportRowChangeEvent(DirectCast(e.Row, GeneralExcelImportRow), e.Action))
                    End If
                End If
            End Sub

            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.GeneralExcelImportRowDeletingEvent Is Nothing) Then
                    Dim generalExcelImportRowDeletingEvent As GeneralExcelImportRowChangeEventHandler = Me.GeneralExcelImportRowDeletingEvent
                    If (Not generalExcelImportRowDeletingEvent Is Nothing) Then
                        generalExcelImportRowDeletingEvent.Invoke(Me, New GeneralExcelImportRowChangeEvent(DirectCast(e.Row, GeneralExcelImportRow), e.Action))
                    End If
                End If
            End Sub

            Public Sub RemoveGeneralExcelImportRow(ByVal row As GeneralExcelImportRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            Friend ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            Friend ReadOnly Property ExcelFileNameColumn As DataColumn
                Get
                    Return Me.columnExcelFileName
                End Get
            End Property

            Friend ReadOnly Property ExcelImportIDColumn As DataColumn
                Get
                    Return Me.columnExcelImportID
                End Get
            End Property

            Friend ReadOnly Property FirstLineIsColNameColumn As DataColumn
                Get
                    Return Me.columnFirstLineIsColName
                End Get
            End Property

            Friend ReadOnly Property FromRowColumn As DataColumn
                Get
                    Return Me.columnFromRow
                End Get
            End Property

            Friend ReadOnly Property ImportTypeColumn As DataColumn
                Get
                    Return Me.columnImportType
                End Get
            End Property

            Public ReadOnly Default Property Item(ByVal index As Integer) As GeneralExcelImportRow
                Get
                    Return DirectCast(Me.Rows.Item(index), GeneralExcelImportRow)
                End Get
            End Property

            Friend ReadOnly Property NameColumn As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property

            Friend ReadOnly Property SheetNameColumn As DataColumn
                Get
                    Return Me.columnSheetName
                End Get
            End Property

            Friend ReadOnly Property ToRowColumn As DataColumn
                Get
                    Return Me.columnToRow
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnDescription As DataColumn
            Private columnExcelFileName As DataColumn
            Private columnExcelImportID As DataColumn
            Private columnFirstLineIsColName As DataColumn
            Private columnFromRow As DataColumn
            Private columnImportType As DataColumn
            Private columnName As DataColumn
            Private columnSheetName As DataColumn
            Private columnToRow As DataColumn
        End Class

        <DebuggerStepThrough> _
        Public Class GeneralExcelImportRow
            Inherits DataRow
            ' Methods
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableGeneralExcelImport = DirectCast(Me.Table, GeneralExcelImportDataTable)
            End Sub

            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImport.DescriptionColumn)
            End Function

            Public Function IsExcelFileNameNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImport.ExcelFileNameColumn)
            End Function

            Public Function IsFirstLineIsColNameNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImport.FirstLineIsColNameColumn)
            End Function

            Public Function IsFromRowNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImport.FromRowColumn)
            End Function

            Public Function IsImportTypeNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImport.ImportTypeColumn)
            End Function

            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImport.NameColumn)
            End Function

            Public Function IsSheetNameNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImport.SheetNameColumn)
            End Function

            Public Function IsToRowNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImport.ToRowColumn)
            End Function

            Public Sub SetDescriptionNull()
                Me.Item(Me.tableGeneralExcelImport.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetExcelFileNameNull()
                Me.Item(Me.tableGeneralExcelImport.ExcelFileNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetFirstLineIsColNameNull()
                Me.Item(Me.tableGeneralExcelImport.FirstLineIsColNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetFromRowNull()
                Me.Item(Me.tableGeneralExcelImport.FromRowColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetImportTypeNull()
                Me.Item(Me.tableGeneralExcelImport.ImportTypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetNameNull()
                Me.Item(Me.tableGeneralExcelImport.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetSheetNameNull()
                Me.Item(Me.tableGeneralExcelImport.SheetNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetToRowNull()
                Me.Item(Me.tableGeneralExcelImport.ToRowColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralExcelImport.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImport.DescriptionColumn) = Value
                End Set
            End Property

            Public Property ExcelFileName As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralExcelImport.ExcelFileNameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImport.ExcelFileNameColumn) = Value
                End Set
            End Property

            Public Property ExcelImportID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tableGeneralExcelImport.ExcelImportIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralExcelImport.ExcelImportIDColumn) = Value
                End Set
            End Property

            Public Property FirstLineIsColName As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tableGeneralExcelImport.FirstLineIsColNameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tableGeneralExcelImport.FirstLineIsColNameColumn) = Value
                End Set
            End Property

            Public Property FromRow As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralExcelImport.FromRowColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralExcelImport.FromRowColumn) = Value
                End Set
            End Property

            Public Property ImportType As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralExcelImport.ImportTypeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImport.ImportTypeColumn) = Value
                End Set
            End Property

            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralExcelImport.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImport.NameColumn) = Value
                End Set
            End Property

            Public Property SheetName As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralExcelImport.SheetNameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImport.SheetNameColumn) = Value
                End Set
            End Property

            Public Property ToRow As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralExcelImport.ToRowColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralExcelImport.ToRowColumn) = Value
                End Set
            End Property


            ' Fields
            Private tableGeneralExcelImport As GeneralExcelImportDataTable
        End Class

        <DebuggerStepThrough> _
        Public Class GeneralExcelImportRowChangeEvent
            Inherits EventArgs
            ' Methods
            Public Sub New(ByVal row As GeneralExcelImportRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            Public ReadOnly Property Row As GeneralExcelImportRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As GeneralExcelImportRow
        End Class

        Public Delegate Sub GeneralExcelImportRowChangeEventHandler(ByVal sender As Object, ByVal e As GeneralExcelImportRowChangeEvent)

        <DefaultMember("Item"), DebuggerStepThrough> _
        Public Class GeneralExcelImportSubDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event GeneralExcelImportSubRowChanged As GeneralExcelImportSubRowChangeEventHandler
            Public Event GeneralExcelImportSubRowChanging As GeneralExcelImportSubRowChangeEventHandler
            Public Event GeneralExcelImportSubRowDeleted As GeneralExcelImportSubRowChangeEventHandler
            Public Event GeneralExcelImportSubRowDeleting As GeneralExcelImportSubRowChangeEventHandler

            ' Methods
            Friend Sub New()
                MyBase.New("GeneralExcelImportSub")
                Dim list As ArrayList = GeneralExcelImportSubDataTable.__ENCList
                SyncLock list
                    GeneralExcelImportSubDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitClass
            End Sub

            Friend Sub New(ByVal table As DataTable)
                MyBase.New(table.TableName)
                Dim list As ArrayList = GeneralExcelImportSubDataTable.__ENCList
                SyncLock list
                    GeneralExcelImportSubDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
                Me.DisplayExpression = table.DisplayExpression
            End Sub

            Public Sub AddGeneralExcelImportSubRow(ByVal row As GeneralExcelImportSubRow)
                Me.Rows.Add(row)
            End Sub

            Public Function AddGeneralExcelImportSubRow(ByVal ExcelImportID As Integer, ByVal FieldName As String, ByVal FieldType As String, ByVal DefaultValue As String, ByVal ExcelColName As String, ByVal ExcelCol As Integer, ByVal ImportField As Boolean) As GeneralExcelImportSubRow
                Dim row As GeneralExcelImportSubRow = DirectCast(Me.NewRow, GeneralExcelImportSubRow)
                row.ItemArray = New Object() { ExcelImportID, FieldName, FieldType, DefaultValue, ExcelColName, ExcelCol, ImportField }
                Me.Rows.Add(row)
                Return row
            End Function

            Public Overrides Function Clone() As DataTable
                Dim table As GeneralExcelImportSubDataTable = DirectCast(MyBase.Clone, GeneralExcelImportSubDataTable)
                table.InitVars
                Return table
            End Function

            Protected Overrides Function CreateInstance() As DataTable
                Return New GeneralExcelImportSubDataTable
            End Function

            Public Function FindByExcelImportIDFieldName(ByVal ExcelImportID As Integer, ByVal FieldName As String) As GeneralExcelImportSubRow
                Return DirectCast(Me.Rows.Find(New Object() { ExcelImportID, FieldName }), GeneralExcelImportSubRow)
            End Function

            Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            Protected Overrides Function GetRowType() As Type
                Return GetType(GeneralExcelImportSubRow)
            End Function

            Private Sub InitClass()
                Me.columnExcelImportID = New DataColumn("ExcelImportID", GetType(Integer), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnExcelImportID)
                Me.columnFieldName = New DataColumn("FieldName", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnFieldName)
                Me.columnFieldType = New DataColumn("FieldType", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnFieldType)
                Me.columnDefaultValue = New DataColumn("DefaultValue", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnDefaultValue)
                Me.columnExcelColName = New DataColumn("ExcelColName", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnExcelColName)
                Me.columnExcelCol = New DataColumn("ExcelCol", GetType(Integer), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnExcelCol)
                Me.columnImportField = New DataColumn("ImportField", GetType(Boolean), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnImportField)
                Me.Constraints.Add(New UniqueConstraint("dsExcelImportKey3", New DataColumn() { Me.columnExcelImportID, Me.columnFieldName }, True))
                Me.columnExcelImportID.AllowDBNull = False
                Me.columnFieldName.AllowDBNull = False
            End Sub

            Friend Sub InitVars()
                Me.columnExcelImportID = Me.Columns.Item("ExcelImportID")
                Me.columnFieldName = Me.Columns.Item("FieldName")
                Me.columnFieldType = Me.Columns.Item("FieldType")
                Me.columnDefaultValue = Me.Columns.Item("DefaultValue")
                Me.columnExcelColName = Me.Columns.Item("ExcelColName")
                Me.columnExcelCol = Me.Columns.Item("ExcelCol")
                Me.columnImportField = Me.Columns.Item("ImportField")
            End Sub

            Public Function NewGeneralExcelImportSubRow() As GeneralExcelImportSubRow
                Return DirectCast(Me.NewRow, GeneralExcelImportSubRow)
            End Function

            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New GeneralExcelImportSubRow(builder)
            End Function

            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.GeneralExcelImportSubRowChangedEvent Is Nothing) Then
                    Dim generalExcelImportSubRowChangedEvent As GeneralExcelImportSubRowChangeEventHandler = Me.GeneralExcelImportSubRowChangedEvent
                    If (Not generalExcelImportSubRowChangedEvent Is Nothing) Then
                        generalExcelImportSubRowChangedEvent.Invoke(Me, New GeneralExcelImportSubRowChangeEvent(DirectCast(e.Row, GeneralExcelImportSubRow), e.Action))
                    End If
                End If
            End Sub

            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.GeneralExcelImportSubRowChangingEvent Is Nothing) Then
                    Dim generalExcelImportSubRowChangingEvent As GeneralExcelImportSubRowChangeEventHandler = Me.GeneralExcelImportSubRowChangingEvent
                    If (Not generalExcelImportSubRowChangingEvent Is Nothing) Then
                        generalExcelImportSubRowChangingEvent.Invoke(Me, New GeneralExcelImportSubRowChangeEvent(DirectCast(e.Row, GeneralExcelImportSubRow), e.Action))
                    End If
                End If
            End Sub

            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.GeneralExcelImportSubRowDeletedEvent Is Nothing) Then
                    Dim generalExcelImportSubRowDeletedEvent As GeneralExcelImportSubRowChangeEventHandler = Me.GeneralExcelImportSubRowDeletedEvent
                    If (Not generalExcelImportSubRowDeletedEvent Is Nothing) Then
                        generalExcelImportSubRowDeletedEvent.Invoke(Me, New GeneralExcelImportSubRowChangeEvent(DirectCast(e.Row, GeneralExcelImportSubRow), e.Action))
                    End If
                End If
            End Sub

            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.GeneralExcelImportSubRowDeletingEvent Is Nothing) Then
                    Dim generalExcelImportSubRowDeletingEvent As GeneralExcelImportSubRowChangeEventHandler = Me.GeneralExcelImportSubRowDeletingEvent
                    If (Not generalExcelImportSubRowDeletingEvent Is Nothing) Then
                        generalExcelImportSubRowDeletingEvent.Invoke(Me, New GeneralExcelImportSubRowChangeEvent(DirectCast(e.Row, GeneralExcelImportSubRow), e.Action))
                    End If
                End If
            End Sub

            Public Sub RemoveGeneralExcelImportSubRow(ByVal row As GeneralExcelImportSubRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            Friend ReadOnly Property DefaultValueColumn As DataColumn
                Get
                    Return Me.columnDefaultValue
                End Get
            End Property

            Friend ReadOnly Property ExcelColColumn As DataColumn
                Get
                    Return Me.columnExcelCol
                End Get
            End Property

            Friend ReadOnly Property ExcelColNameColumn As DataColumn
                Get
                    Return Me.columnExcelColName
                End Get
            End Property

            Friend ReadOnly Property ExcelImportIDColumn As DataColumn
                Get
                    Return Me.columnExcelImportID
                End Get
            End Property

            Friend ReadOnly Property FieldNameColumn As DataColumn
                Get
                    Return Me.columnFieldName
                End Get
            End Property

            Friend ReadOnly Property FieldTypeColumn As DataColumn
                Get
                    Return Me.columnFieldType
                End Get
            End Property

            Friend ReadOnly Property ImportFieldColumn As DataColumn
                Get
                    Return Me.columnImportField
                End Get
            End Property

            Public ReadOnly Default Property Item(ByVal index As Integer) As GeneralExcelImportSubRow
                Get
                    Return DirectCast(Me.Rows.Item(index), GeneralExcelImportSubRow)
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnDefaultValue As DataColumn
            Private columnExcelCol As DataColumn
            Private columnExcelColName As DataColumn
            Private columnExcelImportID As DataColumn
            Private columnFieldName As DataColumn
            Private columnFieldType As DataColumn
            Private columnImportField As DataColumn
        End Class

        <DebuggerStepThrough> _
        Public Class GeneralExcelImportSubRow
            Inherits DataRow
            ' Methods
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableGeneralExcelImportSub = DirectCast(Me.Table, GeneralExcelImportSubDataTable)
            End Sub

            Public Function IsDefaultValueNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImportSub.DefaultValueColumn)
            End Function

            Public Function IsExcelColNameNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImportSub.ExcelColNameColumn)
            End Function

            Public Function IsExcelColNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImportSub.ExcelColColumn)
            End Function

            Public Function IsFieldTypeNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImportSub.FieldTypeColumn)
            End Function

            Public Function IsImportFieldNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImportSub.ImportFieldColumn)
            End Function

            Public Sub SetDefaultValueNull()
                Me.Item(Me.tableGeneralExcelImportSub.DefaultValueColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetExcelColNameNull()
                Me.Item(Me.tableGeneralExcelImportSub.ExcelColNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetExcelColNull()
                Me.Item(Me.tableGeneralExcelImportSub.ExcelColColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetFieldTypeNull()
                Me.Item(Me.tableGeneralExcelImportSub.FieldTypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetImportFieldNull()
                Me.Item(Me.tableGeneralExcelImportSub.ImportFieldColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            Public Property DefaultValue As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralExcelImportSub.DefaultValueColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImportSub.DefaultValueColumn) = Value
                End Set
            End Property

            Public Property ExcelCol As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralExcelImportSub.ExcelColColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralExcelImportSub.ExcelColColumn) = Value
                End Set
            End Property

            Public Property ExcelColName As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralExcelImportSub.ExcelColNameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImportSub.ExcelColNameColumn) = Value
                End Set
            End Property

            Public Property ExcelImportID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tableGeneralExcelImportSub.ExcelImportIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralExcelImportSub.ExcelImportIDColumn) = Value
                End Set
            End Property

            Public Property FieldName As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tableGeneralExcelImportSub.FieldNameColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImportSub.FieldNameColumn) = Value
                End Set
            End Property

            Public Property FieldType As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralExcelImportSub.FieldTypeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImportSub.FieldTypeColumn) = Value
                End Set
            End Property

            Public Property ImportField As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tableGeneralExcelImportSub.ImportFieldColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tableGeneralExcelImportSub.ImportFieldColumn) = Value
                End Set
            End Property


            ' Fields
            Private tableGeneralExcelImportSub As GeneralExcelImportSubDataTable
        End Class

        <DebuggerStepThrough> _
        Public Class GeneralExcelImportSubRowChangeEvent
            Inherits EventArgs
            ' Methods
            Public Sub New(ByVal row As GeneralExcelImportSubRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            Public ReadOnly Property Row As GeneralExcelImportSubRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As GeneralExcelImportSubRow
        End Class

        Public Delegate Sub GeneralExcelImportSubRowChangeEventHandler(ByVal sender As Object, ByVal e As GeneralExcelImportSubRowChangeEvent)

        <DebuggerStepThrough, DefaultMember("Item")> _
        Public Class GeneralExcelImportTemplateDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event GeneralExcelImportTemplateRowChanged As GeneralExcelImportTemplateRowChangeEventHandler
            Public Event GeneralExcelImportTemplateRowChanging As GeneralExcelImportTemplateRowChangeEventHandler
            Public Event GeneralExcelImportTemplateRowDeleted As GeneralExcelImportTemplateRowChangeEventHandler
            Public Event GeneralExcelImportTemplateRowDeleting As GeneralExcelImportTemplateRowChangeEventHandler

            ' Methods
            Friend Sub New()
                MyBase.New("GeneralExcelImportTemplate")
                Dim list As ArrayList = GeneralExcelImportTemplateDataTable.__ENCList
                SyncLock list
                    GeneralExcelImportTemplateDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitClass
            End Sub

            Friend Sub New(ByVal table As DataTable)
                MyBase.New(table.TableName)
                Dim list As ArrayList = GeneralExcelImportTemplateDataTable.__ENCList
                SyncLock list
                    GeneralExcelImportTemplateDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
                Me.DisplayExpression = table.DisplayExpression
            End Sub

            Public Sub AddGeneralExcelImportTemplateRow(ByVal row As GeneralExcelImportTemplateRow)
                Me.Rows.Add(row)
            End Sub

            Public Function AddGeneralExcelImportTemplateRow(ByVal ImportType As String, ByVal Fieldname As String, ByVal FieldType As String, ByVal DefaultValue As String, ByVal ImportField As Boolean) As GeneralExcelImportTemplateRow
                Dim row As GeneralExcelImportTemplateRow = DirectCast(Me.NewRow, GeneralExcelImportTemplateRow)
                row.ItemArray = New Object() { ImportType, Fieldname, FieldType, DefaultValue, ImportField }
                Me.Rows.Add(row)
                Return row
            End Function

            Public Overrides Function Clone() As DataTable
                Dim table As GeneralExcelImportTemplateDataTable = DirectCast(MyBase.Clone, GeneralExcelImportTemplateDataTable)
                table.InitVars
                Return table
            End Function

            Protected Overrides Function CreateInstance() As DataTable
                Return New GeneralExcelImportTemplateDataTable
            End Function

            Public Function FindByImportTypeFieldname(ByVal ImportType As String, ByVal Fieldname As String) As GeneralExcelImportTemplateRow
                Return DirectCast(Me.Rows.Find(New Object() { ImportType, Fieldname }), GeneralExcelImportTemplateRow)
            End Function

            Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            Protected Overrides Function GetRowType() As Type
                Return GetType(GeneralExcelImportTemplateRow)
            End Function

            Private Sub InitClass()
                Me.columnImportType = New DataColumn("ImportType", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnImportType)
                Me.columnFieldname = New DataColumn("Fieldname", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnFieldname)
                Me.columnFieldType = New DataColumn("FieldType", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnFieldType)
                Me.columnDefaultValue = New DataColumn("DefaultValue", GetType(String), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnDefaultValue)
                Me.columnImportField = New DataColumn("ImportField", GetType(Boolean), Nothing, MappingType.Element)
                Me.Columns.Add(Me.columnImportField)
                Me.Constraints.Add(New UniqueConstraint("dsExcelImportKey2", New DataColumn() { Me.columnImportType, Me.columnFieldname }, True))
                Me.columnImportType.AllowDBNull = False
                Me.columnFieldname.AllowDBNull = False
            End Sub

            Friend Sub InitVars()
                Me.columnImportType = Me.Columns.Item("ImportType")
                Me.columnFieldname = Me.Columns.Item("Fieldname")
                Me.columnFieldType = Me.Columns.Item("FieldType")
                Me.columnDefaultValue = Me.Columns.Item("DefaultValue")
                Me.columnImportField = Me.Columns.Item("ImportField")
            End Sub

            Public Function NewGeneralExcelImportTemplateRow() As GeneralExcelImportTemplateRow
                Return DirectCast(Me.NewRow, GeneralExcelImportTemplateRow)
            End Function

            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New GeneralExcelImportTemplateRow(builder)
            End Function

            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.GeneralExcelImportTemplateRowChangedEvent Is Nothing) Then
                    Dim generalExcelImportTemplateRowChangedEvent As GeneralExcelImportTemplateRowChangeEventHandler = Me.GeneralExcelImportTemplateRowChangedEvent
                    If (Not generalExcelImportTemplateRowChangedEvent Is Nothing) Then
                        generalExcelImportTemplateRowChangedEvent.Invoke(Me, New GeneralExcelImportTemplateRowChangeEvent(DirectCast(e.Row, GeneralExcelImportTemplateRow), e.Action))
                    End If
                End If
            End Sub

            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.GeneralExcelImportTemplateRowChangingEvent Is Nothing) Then
                    Dim generalExcelImportTemplateRowChangingEvent As GeneralExcelImportTemplateRowChangeEventHandler = Me.GeneralExcelImportTemplateRowChangingEvent
                    If (Not generalExcelImportTemplateRowChangingEvent Is Nothing) Then
                        generalExcelImportTemplateRowChangingEvent.Invoke(Me, New GeneralExcelImportTemplateRowChangeEvent(DirectCast(e.Row, GeneralExcelImportTemplateRow), e.Action))
                    End If
                End If
            End Sub

            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.GeneralExcelImportTemplateRowDeletedEvent Is Nothing) Then
                    Dim generalExcelImportTemplateRowDeletedEvent As GeneralExcelImportTemplateRowChangeEventHandler = Me.GeneralExcelImportTemplateRowDeletedEvent
                    If (Not generalExcelImportTemplateRowDeletedEvent Is Nothing) Then
                        generalExcelImportTemplateRowDeletedEvent.Invoke(Me, New GeneralExcelImportTemplateRowChangeEvent(DirectCast(e.Row, GeneralExcelImportTemplateRow), e.Action))
                    End If
                End If
            End Sub

            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.GeneralExcelImportTemplateRowDeletingEvent Is Nothing) Then
                    Dim generalExcelImportTemplateRowDeletingEvent As GeneralExcelImportTemplateRowChangeEventHandler = Me.GeneralExcelImportTemplateRowDeletingEvent
                    If (Not generalExcelImportTemplateRowDeletingEvent Is Nothing) Then
                        generalExcelImportTemplateRowDeletingEvent.Invoke(Me, New GeneralExcelImportTemplateRowChangeEvent(DirectCast(e.Row, GeneralExcelImportTemplateRow), e.Action))
                    End If
                End If
            End Sub

            Public Sub RemoveGeneralExcelImportTemplateRow(ByVal row As GeneralExcelImportTemplateRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            Friend ReadOnly Property DefaultValueColumn As DataColumn
                Get
                    Return Me.columnDefaultValue
                End Get
            End Property

            Friend ReadOnly Property FieldnameColumn As DataColumn
                Get
                    Return Me.columnFieldname
                End Get
            End Property

            Friend ReadOnly Property FieldTypeColumn As DataColumn
                Get
                    Return Me.columnFieldType
                End Get
            End Property

            Friend ReadOnly Property ImportFieldColumn As DataColumn
                Get
                    Return Me.columnImportField
                End Get
            End Property

            Friend ReadOnly Property ImportTypeColumn As DataColumn
                Get
                    Return Me.columnImportType
                End Get
            End Property

            Public ReadOnly Default Property Item(ByVal index As Integer) As GeneralExcelImportTemplateRow
                Get
                    Return DirectCast(Me.Rows.Item(index), GeneralExcelImportTemplateRow)
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnDefaultValue As DataColumn
            Private columnFieldname As DataColumn
            Private columnFieldType As DataColumn
            Private columnImportField As DataColumn
            Private columnImportType As DataColumn
        End Class

        <DebuggerStepThrough> _
        Public Class GeneralExcelImportTemplateRow
            Inherits DataRow
            ' Methods
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableGeneralExcelImportTemplate = DirectCast(Me.Table, GeneralExcelImportTemplateDataTable)
            End Sub

            Public Function IsDefaultValueNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImportTemplate.DefaultValueColumn)
            End Function

            Public Function IsFieldTypeNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImportTemplate.FieldTypeColumn)
            End Function

            Public Function IsImportFieldNull() As Boolean
                Return Me.IsNull(Me.tableGeneralExcelImportTemplate.ImportFieldColumn)
            End Function

            Public Sub SetDefaultValueNull()
                Me.Item(Me.tableGeneralExcelImportTemplate.DefaultValueColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetFieldTypeNull()
                Me.Item(Me.tableGeneralExcelImportTemplate.FieldTypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            Public Sub SetImportFieldNull()
                Me.Item(Me.tableGeneralExcelImportTemplate.ImportFieldColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            Public Property DefaultValue As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralExcelImportTemplate.DefaultValueColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImportTemplate.DefaultValueColumn) = Value
                End Set
            End Property

            Public Property Fieldname As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tableGeneralExcelImportTemplate.FieldnameColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImportTemplate.FieldnameColumn) = Value
                End Set
            End Property

            Public Property FieldType As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralExcelImportTemplate.FieldTypeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImportTemplate.FieldTypeColumn) = Value
                End Set
            End Property

            Public Property ImportField As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tableGeneralExcelImportTemplate.ImportFieldColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tableGeneralExcelImportTemplate.ImportFieldColumn) = Value
                End Set
            End Property

            Public Property ImportType As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tableGeneralExcelImportTemplate.ImportTypeColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralExcelImportTemplate.ImportTypeColumn) = Value
                End Set
            End Property


            ' Fields
            Private tableGeneralExcelImportTemplate As GeneralExcelImportTemplateDataTable
        End Class

        <DebuggerStepThrough> _
        Public Class GeneralExcelImportTemplateRowChangeEvent
            Inherits EventArgs
            ' Methods
            Public Sub New(ByVal row As GeneralExcelImportTemplateRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            Public ReadOnly Property Row As GeneralExcelImportTemplateRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As GeneralExcelImportTemplateRow
        End Class

        Public Delegate Sub GeneralExcelImportTemplateRowChangeEventHandler(ByVal sender As Object, ByVal e As GeneralExcelImportTemplateRowChangeEvent)
    End Class
End Namespace

