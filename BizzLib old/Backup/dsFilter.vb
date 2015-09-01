Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Namespace BizzLib
    <Serializable, ToolboxItem(True), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), XmlSchemaProvider("GetTypedDataSetSchema"), DesignerCategory("code"), XmlRoot("dsFilter")> _
    Public Class dsFilter
        Inherits DataSet
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Dim list As ArrayList = dsFilter.__ENCList
            SyncLock list
                dsFilter.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me._schemaSerializationMode = SchemaSerializationMode.IncludeSchema
            Me.BeginInit
            Me.InitClass
            Dim handler As CollectionChangeEventHandler = New CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
            AddHandler MyBase.Tables.CollectionChanged, handler
            AddHandler MyBase.Relations.CollectionChanged, handler
            Me.EndInit
        End Sub

        <DebuggerNonUserCode> _
        Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
            MyBase.New(info, context, False)
            Dim list As ArrayList = dsFilter.__ENCList
            SyncLock list
                dsFilter.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me._schemaSerializationMode = SchemaSerializationMode.IncludeSchema
            If Me.IsBinarySerialized(info, context) Then
                Me.InitVars(False)
                Dim handler2 As CollectionChangeEventHandler = New CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
                AddHandler Me.Tables.CollectionChanged, handler2
                AddHandler Me.Relations.CollectionChanged, handler2
            Else
                Dim s As String = Conversions.ToString(info.GetValue("XmlSchema", GetType(String)))
                If (Me.DetermineSchemaSerializationMode(info, context) = SchemaSerializationMode.IncludeSchema) Then
                    Dim dataSet As New DataSet
                    dataSet.ReadXmlSchema(New XmlTextReader(New StringReader(s)))
                    If (Not dataSet.Tables.Item("generalfiltersub") Is Nothing) Then
                        MyBase.Tables.Add(New generalfiltersubDataTable(dataSet.Tables.Item("generalfiltersub")))
                    End If
                    If (Not dataSet.Tables.Item("generalfilter") Is Nothing) Then
                        MyBase.Tables.Add(New generalfilterDataTable(dataSet.Tables.Item("generalfilter")))
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
                    Me.ReadXmlSchema(New XmlTextReader(New StringReader(s)))
                End If
                Me.GetSerializationData(info, context)
                Dim handler As CollectionChangeEventHandler = New CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
                AddHandler MyBase.Tables.CollectionChanged, handler
                AddHandler Me.Relations.CollectionChanged, handler
            End If
        End Sub

        <DebuggerNonUserCode> _
        Public Overrides Function Clone() As DataSet
            Dim filter As dsFilter = DirectCast(MyBase.Clone, dsFilter)
            filter.InitVars
            filter.SchemaSerializationMode = Me.SchemaSerializationMode
            Return filter
        End Function

        <DebuggerNonUserCode> _
        Protected Overrides Function GetSchemaSerializable() As XmlSchema
            Dim w As New MemoryStream
            Me.WriteXmlSchema(New XmlTextWriter(w, Nothing))
            w.Position = 0
            Return XmlSchema.Read(New XmlTextReader(w), Nothing)
        End Function

        <DebuggerNonUserCode> _
        Public Shared Function GetTypedDataSetSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
            Dim filter As New dsFilter
            Dim type2 As New XmlSchemaComplexType
            Dim sequence As New XmlSchemaSequence
            xs.Add(filter.GetSchemaSerializable)
            Dim item As New XmlSchemaAny
            item.Namespace = filter.Namespace
            sequence.Items.Add(item)
            type2.Particle = sequence
            Return type2
        End Function

        <DebuggerNonUserCode> _
        Private Sub InitClass()
            Me.DataSetName = "dsFilter"
            Me.Prefix = ""
            Me.Namespace = "http://tempuri.org/dsFilter.xsd"
            Me.EnforceConstraints = True
            Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
            Me.tablegeneralfiltersub = New generalfiltersubDataTable
            MyBase.Tables.Add(Me.tablegeneralfiltersub)
            Me.tablegeneralfilter = New generalfilterDataTable
            MyBase.Tables.Add(Me.tablegeneralfilter)
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub InitializeDerivedDataSet()
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <DebuggerNonUserCode> _
        Friend Sub InitVars()
            Me.InitVars(True)
        End Sub

        <DebuggerNonUserCode> _
        Friend Sub InitVars(ByVal initTable As Boolean)
            Me.tablegeneralfiltersub = DirectCast(MyBase.Tables.Item("generalfiltersub"), generalfiltersubDataTable)
            If (initTable AndAlso (Not Me.tablegeneralfiltersub Is Nothing)) Then
                Me.tablegeneralfiltersub.InitVars
            End If
            Me.tablegeneralfilter = DirectCast(MyBase.Tables.Item("generalfilter"), generalfilterDataTable)
            If (initTable AndAlso (Not Me.tablegeneralfilter Is Nothing)) Then
                Me.tablegeneralfilter.InitVars
            End If
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
            If (Me.DetermineSchemaSerializationMode(reader) = SchemaSerializationMode.IncludeSchema) Then
                Me.Reset
                Dim dataSet As New DataSet
                dataSet.ReadXml(reader)
                If (Not dataSet.Tables.Item("generalfiltersub") Is Nothing) Then
                    MyBase.Tables.Add(New generalfiltersubDataTable(dataSet.Tables.Item("generalfiltersub")))
                End If
                If (Not dataSet.Tables.Item("generalfilter") Is Nothing) Then
                    MyBase.Tables.Add(New generalfilterDataTable(dataSet.Tables.Item("generalfilter")))
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
                Me.ReadXml(reader)
                Me.InitVars
            End If
        End Sub

        <DebuggerNonUserCode> _
        Private Sub SchemaChanged(ByVal sender As Object, ByVal e As CollectionChangeEventArgs)
            If (e.Action = CollectionChangeAction.Remove) Then
                Me.InitVars
            End If
        End Sub

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneralfilter() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneralfiltersub() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Protected Overrides Function ShouldSerializeRelations() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Protected Overrides Function ShouldSerializeTables() As Boolean
            Return False
        End Function


        ' Properties
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(False)> _
        Public ReadOnly Property generalfilter As generalfilterDataTable
            Get
                Return Me.tablegeneralfilter
            End Get
        End Property

        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode> _
        Public ReadOnly Property generalfiltersub As generalfiltersubDataTable
            Get
                Return Me.tablegeneralfiltersub
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode> _
        Public ReadOnly Property Relations As DataRelationCollection
            Get
                Return MyBase.Relations
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Browsable(True)> _
        Public Overrides Property SchemaSerializationMode As SchemaSerializationMode
            Get
                Return Me._schemaSerializationMode
            End Get
            Set(ByVal Value As SchemaSerializationMode)
                Me._schemaSerializationMode = Value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode> _
        Public ReadOnly Property Tables As DataTableCollection
            Get
                Return MyBase.Tables
            End Get
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        Private _schemaSerializationMode As SchemaSerializationMode
        Private tablegeneralfilter As generalfilterDataTable
        Private tablegeneralfiltersub As generalfiltersubDataTable

        ' Nested Types
        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item")> _
        Public Class generalfilterDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalfilterRowChanged As generalfilterRowChangeEventHandler
            Public Event generalfilterRowChanging As generalfilterRowChangeEventHandler
            Public Event generalfilterRowDeleted As generalfilterRowChangeEventHandler
            Public Event generalfilterRowDeleting As generalfilterRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalfilterDataTable.__ENCList
                SyncLock list
                    generalfilterDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalfilter"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalfilterDataTable.__ENCList
                SyncLock list
                    generalfilterDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
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
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = generalfilterDataTable.__ENCList
                SyncLock list
                    generalfilterDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddgeneralfilterRow(ByVal row As generalfilterRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddgeneralfilterRow(ByVal FilterID As Integer, ByVal Name As String, ByVal UserID As String, ByVal MenuID As Integer, ByVal Description As String, ByVal DefaultFilter As Boolean, ByVal SystemFilter As Integer, ByVal TopRows As Integer) As generalfilterRow
                Dim row As generalfilterRow = DirectCast(Me.NewRow, generalfilterRow)
                row.ItemArray = New Object() { FilterID, Name, UserID, MenuID, Description, DefaultFilter, SystemFilter, TopRows }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalfilterDataTable = DirectCast(MyBase.Clone, generalfilterDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalfilterDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByFilterID(ByVal FilterID As Integer) As generalfilterRow
                Return DirectCast(Me.Rows.Find(New Object() { FilterID }), generalfilterRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalfilterRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim filter As New dsFilter
                xs.Add(filter.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = filter.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalfilterDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnFilterID = New DataColumn("FilterID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFilterID)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnUserID = New DataColumn("UserID", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnUserID)
                Me.columnMenuID = New DataColumn("MenuID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuID)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnDefaultFilter = New DataColumn("DefaultFilter", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDefaultFilter)
                Me.columnSystemFilter = New DataColumn("SystemFilter", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSystemFilter)
                Me.columnTopRows = New DataColumn("TopRows", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnTopRows)
                Me.Constraints.Add(New UniqueConstraint("dsFilterKey1", New DataColumn() { Me.columnFilterID }, True))
                Me.columnFilterID.AllowDBNull = False
                Me.columnFilterID.Unique = True
                Me.columnUserID.AllowDBNull = False
                Me.columnMenuID.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnFilterID = MyBase.Columns.Item("FilterID")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnUserID = MyBase.Columns.Item("UserID")
                Me.columnMenuID = MyBase.Columns.Item("MenuID")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnDefaultFilter = MyBase.Columns.Item("DefaultFilter")
                Me.columnSystemFilter = MyBase.Columns.Item("SystemFilter")
                Me.columnTopRows = MyBase.Columns.Item("TopRows")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewgeneralfilterRow() As generalfilterRow
                Return DirectCast(Me.NewRow, generalfilterRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalfilterRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalfilterRowChangedEvent Is Nothing) Then
                    Dim generalfilterRowChangedEvent As generalfilterRowChangeEventHandler = Me.generalfilterRowChangedEvent
                    If (Not generalfilterRowChangedEvent Is Nothing) Then
                        generalfilterRowChangedEvent.Invoke(Me, New generalfilterRowChangeEvent(DirectCast(e.Row, generalfilterRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalfilterRowChangingEvent Is Nothing) Then
                    Dim generalfilterRowChangingEvent As generalfilterRowChangeEventHandler = Me.generalfilterRowChangingEvent
                    If (Not generalfilterRowChangingEvent Is Nothing) Then
                        generalfilterRowChangingEvent.Invoke(Me, New generalfilterRowChangeEvent(DirectCast(e.Row, generalfilterRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalfilterRowDeletedEvent Is Nothing) Then
                    Dim generalfilterRowDeletedEvent As generalfilterRowChangeEventHandler = Me.generalfilterRowDeletedEvent
                    If (Not generalfilterRowDeletedEvent Is Nothing) Then
                        generalfilterRowDeletedEvent.Invoke(Me, New generalfilterRowChangeEvent(DirectCast(e.Row, generalfilterRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalfilterRowDeletingEvent Is Nothing) Then
                    Dim generalfilterRowDeletingEvent As generalfilterRowChangeEventHandler = Me.generalfilterRowDeletingEvent
                    If (Not generalfilterRowDeletingEvent Is Nothing) Then
                        generalfilterRowDeletingEvent.Invoke(Me, New generalfilterRowChangeEvent(DirectCast(e.Row, generalfilterRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovegeneralfilterRow(ByVal row As generalfilterRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DefaultFilterColumn As DataColumn
                Get
                    Return Me.columnDefaultFilter
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FilterIDColumn As DataColumn
                Get
                    Return Me.columnFilterID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalfilterRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generalfilterRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuIDColumn As DataColumn
                Get
                    Return Me.columnMenuID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property NameColumn As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property SystemFilterColumn As DataColumn
                Get
                    Return Me.columnSystemFilter
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property TopRowsColumn As DataColumn
                Get
                    Return Me.columnTopRows
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property UserIDColumn As DataColumn
                Get
                    Return Me.columnUserID
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnDefaultFilter As DataColumn
            Private columnDescription As DataColumn
            Private columnFilterID As DataColumn
            Private columnMenuID As DataColumn
            Private columnName As DataColumn
            Private columnSystemFilter As DataColumn
            Private columnTopRows As DataColumn
            Private columnUserID As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalfilterRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralfilter = DirectCast(Me.Table, generalfilterDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsDefaultFilterNull() As Boolean
                Return Me.IsNull(Me.tablegeneralfilter.DefaultFilterColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tablegeneralfilter.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tablegeneralfilter.NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsSystemFilterNull() As Boolean
                Return Me.IsNull(Me.tablegeneralfilter.SystemFilterColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsTopRowsNull() As Boolean
                Return Me.IsNull(Me.tablegeneralfilter.TopRowsColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetDefaultFilterNull()
                Me.Item(Me.tablegeneralfilter.DefaultFilterColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tablegeneralfilter.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNameNull()
                Me.Item(Me.tablegeneralfilter.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetSystemFilterNull()
                Me.Item(Me.tablegeneralfilter.SystemFilterColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetTopRowsNull()
                Me.Item(Me.tablegeneralfilter.TopRowsColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property DefaultFilter As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralfilter.DefaultFilterColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'DefaultFilter' in table 'generalfilter' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralfilter.DefaultFilterColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralfilter.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'generalfilter' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralfilter.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property FilterID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralfilter.FilterIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralfilter.FilterIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralfilter.MenuIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralfilter.MenuIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralfilter.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'generalfilter' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralfilter.NameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property SystemFilter As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralfilter.SystemFilterColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'SystemFilter' in table 'generalfilter' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralfilter.SystemFilterColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property TopRows As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralfilter.TopRowsColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'TopRows' in table 'generalfilter' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralfilter.TopRowsColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property UserID As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralfilter.UserIDColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralfilter.UserIDColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralfilter As generalfilterDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalfilterRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalfilterRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As generalfilterRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalfilterRow
        End Class

        Public Delegate Sub generalfilterRowChangeEventHandler(ByVal sender As Object, ByVal e As generalfilterRowChangeEvent)

        <Serializable, DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalfiltersubDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalfiltersubRowChanged As generalfiltersubRowChangeEventHandler
            Public Event generalfiltersubRowChanging As generalfiltersubRowChangeEventHandler
            Public Event generalfiltersubRowDeleted As generalfiltersubRowChangeEventHandler
            Public Event generalfiltersubRowDeleting As generalfiltersubRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalfiltersubDataTable.__ENCList
                SyncLock list
                    generalfiltersubDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalfiltersub"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalfiltersubDataTable.__ENCList
                SyncLock list
                    generalfiltersubDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
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
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = generalfiltersubDataTable.__ENCList
                SyncLock list
                    generalfiltersubDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddgeneralfiltersubRow(ByVal row As generalfiltersubRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddgeneralfiltersubRow(ByVal FilterID As Integer, ByVal OrderNbr As Integer, ByVal FieldName As String, ByVal FieldCriteria As String) As generalfiltersubRow
                Dim row As generalfiltersubRow = DirectCast(Me.NewRow, generalfiltersubRow)
                row.ItemArray = New Object() { FilterID, OrderNbr, FieldName, FieldCriteria }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalfiltersubDataTable = DirectCast(MyBase.Clone, generalfiltersubDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalfiltersubDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByFilterIDOrderNbrFieldName(ByVal FilterID As Integer, ByVal OrderNbr As Integer, ByVal FieldName As String) As generalfiltersubRow
                Return DirectCast(Me.Rows.Find(New Object() { FilterID, OrderNbr, FieldName }), generalfiltersubRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalfiltersubRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim filter As New dsFilter
                xs.Add(filter.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = filter.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalfiltersubDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnFilterID = New DataColumn("FilterID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFilterID)
                Me.columnOrderNbr = New DataColumn("OrderNbr", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnOrderNbr)
                Me.columnFieldName = New DataColumn("FieldName", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFieldName)
                Me.columnFieldCriteria = New DataColumn("FieldCriteria", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFieldCriteria)
                Me.Constraints.Add(New UniqueConstraint("dsFilterKey2", New DataColumn() { Me.columnFilterID, Me.columnOrderNbr, Me.columnFieldName }, True))
                Me.columnFilterID.AllowDBNull = False
                Me.columnOrderNbr.AllowDBNull = False
                Me.columnFieldName.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnFilterID = MyBase.Columns.Item("FilterID")
                Me.columnOrderNbr = MyBase.Columns.Item("OrderNbr")
                Me.columnFieldName = MyBase.Columns.Item("FieldName")
                Me.columnFieldCriteria = MyBase.Columns.Item("FieldCriteria")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewgeneralfiltersubRow() As generalfiltersubRow
                Return DirectCast(Me.NewRow, generalfiltersubRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalfiltersubRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalfiltersubRowChangedEvent Is Nothing) Then
                    Dim generalfiltersubRowChangedEvent As generalfiltersubRowChangeEventHandler = Me.generalfiltersubRowChangedEvent
                    If (Not generalfiltersubRowChangedEvent Is Nothing) Then
                        generalfiltersubRowChangedEvent.Invoke(Me, New generalfiltersubRowChangeEvent(DirectCast(e.Row, generalfiltersubRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalfiltersubRowChangingEvent Is Nothing) Then
                    Dim generalfiltersubRowChangingEvent As generalfiltersubRowChangeEventHandler = Me.generalfiltersubRowChangingEvent
                    If (Not generalfiltersubRowChangingEvent Is Nothing) Then
                        generalfiltersubRowChangingEvent.Invoke(Me, New generalfiltersubRowChangeEvent(DirectCast(e.Row, generalfiltersubRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalfiltersubRowDeletedEvent Is Nothing) Then
                    Dim generalfiltersubRowDeletedEvent As generalfiltersubRowChangeEventHandler = Me.generalfiltersubRowDeletedEvent
                    If (Not generalfiltersubRowDeletedEvent Is Nothing) Then
                        generalfiltersubRowDeletedEvent.Invoke(Me, New generalfiltersubRowChangeEvent(DirectCast(e.Row, generalfiltersubRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalfiltersubRowDeletingEvent Is Nothing) Then
                    Dim generalfiltersubRowDeletingEvent As generalfiltersubRowChangeEventHandler = Me.generalfiltersubRowDeletingEvent
                    If (Not generalfiltersubRowDeletingEvent Is Nothing) Then
                        generalfiltersubRowDeletingEvent.Invoke(Me, New generalfiltersubRowChangeEvent(DirectCast(e.Row, generalfiltersubRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovegeneralfiltersubRow(ByVal row As generalfiltersubRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FieldCriteriaColumn As DataColumn
                Get
                    Return Me.columnFieldCriteria
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FieldNameColumn As DataColumn
                Get
                    Return Me.columnFieldName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FilterIDColumn As DataColumn
                Get
                    Return Me.columnFilterID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalfiltersubRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generalfiltersubRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property OrderNbrColumn As DataColumn
                Get
                    Return Me.columnOrderNbr
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnFieldCriteria As DataColumn
            Private columnFieldName As DataColumn
            Private columnFilterID As DataColumn
            Private columnOrderNbr As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalfiltersubRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralfiltersub = DirectCast(Me.Table, generalfiltersubDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsFieldCriteriaNull() As Boolean
                Return Me.IsNull(Me.tablegeneralfiltersub.FieldCriteriaColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetFieldCriteriaNull()
                Me.Item(Me.tablegeneralfiltersub.FieldCriteriaColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property FieldCriteria As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralfiltersub.FieldCriteriaColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'FieldCriteria' in table 'generalfiltersub' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralfiltersub.FieldCriteriaColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property FieldName As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralfiltersub.FieldNameColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralfiltersub.FieldNameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property FilterID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralfiltersub.FilterIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralfiltersub.FilterIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property OrderNbr As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralfiltersub.OrderNbrColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralfiltersub.OrderNbrColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralfiltersub As generalfiltersubDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalfiltersubRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalfiltersubRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As generalfiltersubRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalfiltersubRow
        End Class

        Public Delegate Sub generalfiltersubRowChangeEventHandler(ByVal sender As Object, ByVal e As generalfiltersubRowChangeEvent)
    End Class
End Namespace

