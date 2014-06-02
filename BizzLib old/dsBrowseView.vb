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
    <Serializable, ToolboxItem(True), DesignerCategory("code"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlRoot("dsBrowseView"), XmlSchemaProvider("GetTypedDataSetSchema"), HelpKeyword("vs.data.DataSet")> _
    Public Class dsBrowseView
        Inherits DataSet
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Dim list As ArrayList = dsBrowseView.__ENCList
            SyncLock list
                dsBrowseView.__ENCList.Add(New WeakReference(Me))
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
            Dim list As ArrayList = dsBrowseView.__ENCList
            SyncLock list
                dsBrowseView.__ENCList.Add(New WeakReference(Me))
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
                    If (Not dataSet.Tables.Item("generalbrowseviewgroupby") Is Nothing) Then
                        MyBase.Tables.Add(New generalbrowseviewgroupbyDataTable(dataSet.Tables.Item("generalbrowseviewgroupby")))
                    End If
                    If (Not dataSet.Tables.Item("TotalSummaryType") Is Nothing) Then
                        MyBase.Tables.Add(New TotalSummaryTypeDataTable(dataSet.Tables.Item("TotalSummaryType")))
                    End If
                    If (Not dataSet.Tables.Item("GroupSummaryType") Is Nothing) Then
                        MyBase.Tables.Add(New GroupSummaryTypeDataTable(dataSet.Tables.Item("GroupSummaryType")))
                    End If
                    If (Not dataSet.Tables.Item("generalbrowseview") Is Nothing) Then
                        MyBase.Tables.Add(New generalbrowseviewDataTable(dataSet.Tables.Item("generalbrowseview")))
                    End If
                    If (Not dataSet.Tables.Item("generalbrowseviewcolumn") Is Nothing) Then
                        MyBase.Tables.Add(New generalbrowseviewcolumnDataTable(dataSet.Tables.Item("generalbrowseviewcolumn")))
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
            Dim view As dsBrowseView = DirectCast(MyBase.Clone, dsBrowseView)
            view.InitVars
            view.SchemaSerializationMode = Me.SchemaSerializationMode
            Return view
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
            Dim view As New dsBrowseView
            Dim type2 As New XmlSchemaComplexType
            Dim sequence As New XmlSchemaSequence
            xs.Add(view.GetSchemaSerializable)
            Dim item As New XmlSchemaAny
            item.Namespace = view.Namespace
            sequence.Items.Add(item)
            type2.Particle = sequence
            Return type2
        End Function

        <DebuggerNonUserCode> _
        Private Sub InitClass()
            Me.DataSetName = "dsBrowseView"
            Me.Prefix = ""
            Me.Namespace = "http://tempuri.org/dsBrowseView.xsd"
            Me.EnforceConstraints = True
            Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
            Me.tablegeneralbrowseviewgroupby = New generalbrowseviewgroupbyDataTable
            MyBase.Tables.Add(Me.tablegeneralbrowseviewgroupby)
            Me.tableTotalSummaryType = New TotalSummaryTypeDataTable
            MyBase.Tables.Add(Me.tableTotalSummaryType)
            Me.tableGroupSummaryType = New GroupSummaryTypeDataTable
            MyBase.Tables.Add(Me.tableGroupSummaryType)
            Me.tablegeneralbrowseview = New generalbrowseviewDataTable
            MyBase.Tables.Add(Me.tablegeneralbrowseview)
            Me.tablegeneralbrowseviewcolumn = New generalbrowseviewcolumnDataTable
            MyBase.Tables.Add(Me.tablegeneralbrowseviewcolumn)
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
            Me.tablegeneralbrowseviewgroupby = DirectCast(MyBase.Tables.Item("generalbrowseviewgroupby"), generalbrowseviewgroupbyDataTable)
            If (initTable AndAlso (Not Me.tablegeneralbrowseviewgroupby Is Nothing)) Then
                Me.tablegeneralbrowseviewgroupby.InitVars
            End If
            Me.tableTotalSummaryType = DirectCast(MyBase.Tables.Item("TotalSummaryType"), TotalSummaryTypeDataTable)
            If (initTable AndAlso (Not Me.tableTotalSummaryType Is Nothing)) Then
                Me.tableTotalSummaryType.InitVars
            End If
            Me.tableGroupSummaryType = DirectCast(MyBase.Tables.Item("GroupSummaryType"), GroupSummaryTypeDataTable)
            If (initTable AndAlso (Not Me.tableGroupSummaryType Is Nothing)) Then
                Me.tableGroupSummaryType.InitVars
            End If
            Me.tablegeneralbrowseview = DirectCast(MyBase.Tables.Item("generalbrowseview"), generalbrowseviewDataTable)
            If (initTable AndAlso (Not Me.tablegeneralbrowseview Is Nothing)) Then
                Me.tablegeneralbrowseview.InitVars
            End If
            Me.tablegeneralbrowseviewcolumn = DirectCast(MyBase.Tables.Item("generalbrowseviewcolumn"), generalbrowseviewcolumnDataTable)
            If (initTable AndAlso (Not Me.tablegeneralbrowseviewcolumn Is Nothing)) Then
                Me.tablegeneralbrowseviewcolumn.InitVars
            End If
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
            If (Me.DetermineSchemaSerializationMode(reader) = SchemaSerializationMode.IncludeSchema) Then
                Me.Reset
                Dim dataSet As New DataSet
                dataSet.ReadXml(reader)
                If (Not dataSet.Tables.Item("generalbrowseviewgroupby") Is Nothing) Then
                    MyBase.Tables.Add(New generalbrowseviewgroupbyDataTable(dataSet.Tables.Item("generalbrowseviewgroupby")))
                End If
                If (Not dataSet.Tables.Item("TotalSummaryType") Is Nothing) Then
                    MyBase.Tables.Add(New TotalSummaryTypeDataTable(dataSet.Tables.Item("TotalSummaryType")))
                End If
                If (Not dataSet.Tables.Item("GroupSummaryType") Is Nothing) Then
                    MyBase.Tables.Add(New GroupSummaryTypeDataTable(dataSet.Tables.Item("GroupSummaryType")))
                End If
                If (Not dataSet.Tables.Item("generalbrowseview") Is Nothing) Then
                    MyBase.Tables.Add(New generalbrowseviewDataTable(dataSet.Tables.Item("generalbrowseview")))
                End If
                If (Not dataSet.Tables.Item("generalbrowseviewcolumn") Is Nothing) Then
                    MyBase.Tables.Add(New generalbrowseviewcolumnDataTable(dataSet.Tables.Item("generalbrowseviewcolumn")))
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
        Private Function ShouldSerializegeneralbrowseview() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneralbrowseviewcolumn() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneralbrowseviewgroupby() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializeGroupSummaryType() As Boolean
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

        <DebuggerNonUserCode> _
        Private Function ShouldSerializeTotalSummaryType() As Boolean
            Return False
        End Function


        ' Properties
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(False)> _
        Public ReadOnly Property generalbrowseview As generalbrowseviewDataTable
            Get
                Return Me.tablegeneralbrowseview
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False), DebuggerNonUserCode> _
        Public ReadOnly Property generalbrowseviewcolumn As generalbrowseviewcolumnDataTable
            Get
                Return Me.tablegeneralbrowseviewcolumn
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(False)> _
        Public ReadOnly Property generalbrowseviewgroupby As generalbrowseviewgroupbyDataTable
            Get
                Return Me.tablegeneralbrowseviewgroupby
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property GroupSummaryType As GroupSummaryTypeDataTable
            Get
                Return Me.tableGroupSummaryType
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
        Public ReadOnly Property Relations As DataRelationCollection
            Get
                Return MyBase.Relations
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Browsable(True), DebuggerNonUserCode> _
        Public Overrides Property SchemaSerializationMode As SchemaSerializationMode
            Get
                Return Me._schemaSerializationMode
            End Get
            Set(ByVal Value As SchemaSerializationMode)
                Me._schemaSerializationMode = Value
            End Set
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
        Public ReadOnly Property Tables As DataTableCollection
            Get
                Return MyBase.Tables
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property TotalSummaryType As TotalSummaryTypeDataTable
            Get
                Return Me.tableTotalSummaryType
            End Get
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        Private _schemaSerializationMode As SchemaSerializationMode
        Private tablegeneralbrowseview As generalbrowseviewDataTable
        Private tablegeneralbrowseviewcolumn As generalbrowseviewcolumnDataTable
        Private tablegeneralbrowseviewgroupby As generalbrowseviewgroupbyDataTable
        Private tableGroupSummaryType As GroupSummaryTypeDataTable
        Private tableTotalSummaryType As TotalSummaryTypeDataTable

        ' Nested Types
        <Serializable, DefaultMember("Item"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class generalbrowseviewcolumnDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalbrowseviewcolumnRowChanged As generalbrowseviewcolumnRowChangeEventHandler
            Public Event generalbrowseviewcolumnRowChanging As generalbrowseviewcolumnRowChangeEventHandler
            Public Event generalbrowseviewcolumnRowDeleted As generalbrowseviewcolumnRowChangeEventHandler
            Public Event generalbrowseviewcolumnRowDeleting As generalbrowseviewcolumnRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalbrowseviewcolumnDataTable.__ENCList
                SyncLock list
                    generalbrowseviewcolumnDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalbrowseviewcolumn"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalbrowseviewcolumnDataTable.__ENCList
                SyncLock list
                    generalbrowseviewcolumnDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = generalbrowseviewcolumnDataTable.__ENCList
                SyncLock list
                    generalbrowseviewcolumnDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddgeneralbrowseviewcolumnRow(ByVal row As generalbrowseviewcolumnRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddgeneralbrowseviewcolumnRow(ByVal BrowseViewID As Integer, ByVal ViewName As String, ByVal FieldName As String, ByVal ToShow As Boolean, ByVal ColumnWidth As Integer, ByVal OrderNbr As Integer, ByVal RowIndex As Integer, ByVal GroupSummary As Integer, ByVal TotalSummary As Integer, ByVal DataType As String, ByVal column_header As String) As generalbrowseviewcolumnRow
                Dim row As generalbrowseviewcolumnRow = DirectCast(Me.NewRow, generalbrowseviewcolumnRow)
                row.ItemArray = New Object() { BrowseViewID, ViewName, FieldName, ToShow, ColumnWidth, OrderNbr, RowIndex, GroupSummary, TotalSummary, DataType, column_header }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalbrowseviewcolumnDataTable = DirectCast(MyBase.Clone, generalbrowseviewcolumnDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalbrowseviewcolumnDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByBrowseViewIDViewNameFieldName(ByVal BrowseViewID As Integer, ByVal ViewName As String, ByVal FieldName As String) As generalbrowseviewcolumnRow
                Return DirectCast(Me.Rows.Find(New Object() { BrowseViewID, ViewName, FieldName }), generalbrowseviewcolumnRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalbrowseviewcolumnRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim view As New dsBrowseView
                xs.Add(view.GetSchemaSerializable)
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
                attribute.FixedValue = view.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalbrowseviewcolumnDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnBrowseViewID = New DataColumn("BrowseViewID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBrowseViewID)
                Me.columnViewName = New DataColumn("ViewName", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnViewName)
                Me.columnFieldName = New DataColumn("FieldName", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFieldName)
                Me.columnToShow = New DataColumn("ToShow", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnToShow)
                Me.columnColumnWidth = New DataColumn("ColumnWidth", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnColumnWidth)
                Me.columnOrderNbr = New DataColumn("OrderNbr", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnOrderNbr)
                Me.columnRowIndex = New DataColumn("RowIndex", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnRowIndex)
                Me.columnGroupSummary = New DataColumn("GroupSummary", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnGroupSummary)
                Me.columnTotalSummary = New DataColumn("TotalSummary", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnTotalSummary)
                Me.columnDataType = New DataColumn("DataType", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDataType)
                Me.columncolumn_header = New DataColumn("column_header", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columncolumn_header)
                Me.Constraints.Add(New UniqueConstraint("dsBrowseViewKey2", New DataColumn() { Me.columnBrowseViewID, Me.columnViewName, Me.columnFieldName }, True))
                Me.columnBrowseViewID.AllowDBNull = False
                Me.columnViewName.AllowDBNull = False
                Me.columnFieldName.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnBrowseViewID = MyBase.Columns.Item("BrowseViewID")
                Me.columnViewName = MyBase.Columns.Item("ViewName")
                Me.columnFieldName = MyBase.Columns.Item("FieldName")
                Me.columnToShow = MyBase.Columns.Item("ToShow")
                Me.columnColumnWidth = MyBase.Columns.Item("ColumnWidth")
                Me.columnOrderNbr = MyBase.Columns.Item("OrderNbr")
                Me.columnRowIndex = MyBase.Columns.Item("RowIndex")
                Me.columnGroupSummary = MyBase.Columns.Item("GroupSummary")
                Me.columnTotalSummary = MyBase.Columns.Item("TotalSummary")
                Me.columnDataType = MyBase.Columns.Item("DataType")
                Me.columncolumn_header = MyBase.Columns.Item("column_header")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewgeneralbrowseviewcolumnRow() As generalbrowseviewcolumnRow
                Return DirectCast(Me.NewRow, generalbrowseviewcolumnRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalbrowseviewcolumnRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalbrowseviewcolumnRowChangedEvent Is Nothing) Then
                    Dim generalbrowseviewcolumnRowChangedEvent As generalbrowseviewcolumnRowChangeEventHandler = Me.generalbrowseviewcolumnRowChangedEvent
                    If (Not generalbrowseviewcolumnRowChangedEvent Is Nothing) Then
                        generalbrowseviewcolumnRowChangedEvent.Invoke(Me, New generalbrowseviewcolumnRowChangeEvent(DirectCast(e.Row, generalbrowseviewcolumnRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalbrowseviewcolumnRowChangingEvent Is Nothing) Then
                    Dim generalbrowseviewcolumnRowChangingEvent As generalbrowseviewcolumnRowChangeEventHandler = Me.generalbrowseviewcolumnRowChangingEvent
                    If (Not generalbrowseviewcolumnRowChangingEvent Is Nothing) Then
                        generalbrowseviewcolumnRowChangingEvent.Invoke(Me, New generalbrowseviewcolumnRowChangeEvent(DirectCast(e.Row, generalbrowseviewcolumnRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalbrowseviewcolumnRowDeletedEvent Is Nothing) Then
                    Dim generalbrowseviewcolumnRowDeletedEvent As generalbrowseviewcolumnRowChangeEventHandler = Me.generalbrowseviewcolumnRowDeletedEvent
                    If (Not generalbrowseviewcolumnRowDeletedEvent Is Nothing) Then
                        generalbrowseviewcolumnRowDeletedEvent.Invoke(Me, New generalbrowseviewcolumnRowChangeEvent(DirectCast(e.Row, generalbrowseviewcolumnRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalbrowseviewcolumnRowDeletingEvent Is Nothing) Then
                    Dim generalbrowseviewcolumnRowDeletingEvent As generalbrowseviewcolumnRowChangeEventHandler = Me.generalbrowseviewcolumnRowDeletingEvent
                    If (Not generalbrowseviewcolumnRowDeletingEvent Is Nothing) Then
                        generalbrowseviewcolumnRowDeletingEvent.Invoke(Me, New generalbrowseviewcolumnRowChangeEvent(DirectCast(e.Row, generalbrowseviewcolumnRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovegeneralbrowseviewcolumnRow(ByVal row As generalbrowseviewcolumnRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property BrowseViewIDColumn As DataColumn
                Get
                    Return Me.columnBrowseViewID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property column_headerColumn As DataColumn
                Get
                    Return Me.columncolumn_header
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ColumnWidthColumn As DataColumn
                Get
                    Return Me.columnColumnWidth
                End Get
            End Property

            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DataTypeColumn As DataColumn
                Get
                    Return Me.columnDataType
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FieldNameColumn As DataColumn
                Get
                    Return Me.columnFieldName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property GroupSummaryColumn As DataColumn
                Get
                    Return Me.columnGroupSummary
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalbrowseviewcolumnRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generalbrowseviewcolumnRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property OrderNbrColumn As DataColumn
                Get
                    Return Me.columnOrderNbr
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property RowIndexColumn As DataColumn
                Get
                    Return Me.columnRowIndex
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ToShowColumn As DataColumn
                Get
                    Return Me.columnToShow
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property TotalSummaryColumn As DataColumn
                Get
                    Return Me.columnTotalSummary
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ViewNameColumn As DataColumn
                Get
                    Return Me.columnViewName
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnBrowseViewID As DataColumn
            Private columncolumn_header As DataColumn
            Private columnColumnWidth As DataColumn
            Private columnDataType As DataColumn
            Private columnFieldName As DataColumn
            Private columnGroupSummary As DataColumn
            Private columnOrderNbr As DataColumn
            Private columnRowIndex As DataColumn
            Private columnToShow As DataColumn
            Private columnTotalSummary As DataColumn
            Private columnViewName As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalbrowseviewcolumnRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralbrowseviewcolumn = DirectCast(Me.Table, generalbrowseviewcolumnDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function Iscolumn_headerNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseviewcolumn.column_headerColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsColumnWidthNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseviewcolumn.ColumnWidthColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDataTypeNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseviewcolumn.DataTypeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsGroupSummaryNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseviewcolumn.GroupSummaryColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsOrderNbrNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseviewcolumn.OrderNbrColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsRowIndexNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseviewcolumn.RowIndexColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsToShowNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseviewcolumn.ToShowColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsTotalSummaryNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseviewcolumn.TotalSummaryColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub Setcolumn_headerNull()
                Me.Item(Me.tablegeneralbrowseviewcolumn.column_headerColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetColumnWidthNull()
                Me.Item(Me.tablegeneralbrowseviewcolumn.ColumnWidthColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDataTypeNull()
                Me.Item(Me.tablegeneralbrowseviewcolumn.DataTypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetGroupSummaryNull()
                Me.Item(Me.tablegeneralbrowseviewcolumn.GroupSummaryColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetOrderNbrNull()
                Me.Item(Me.tablegeneralbrowseviewcolumn.OrderNbrColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetRowIndexNull()
                Me.Item(Me.tablegeneralbrowseviewcolumn.RowIndexColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetToShowNull()
                Me.Item(Me.tablegeneralbrowseviewcolumn.ToShowColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetTotalSummaryNull()
                Me.Item(Me.tablegeneralbrowseviewcolumn.TotalSummaryColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property BrowseViewID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralbrowseviewcolumn.BrowseViewIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralbrowseviewcolumn.BrowseViewIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property column_header As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralbrowseviewcolumn.column_headerColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'column_header' in table 'generalbrowseviewcolumn' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralbrowseviewcolumn.column_headerColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ColumnWidth As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralbrowseviewcolumn.ColumnWidthColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ColumnWidth' in table 'generalbrowseviewcolumn' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralbrowseviewcolumn.ColumnWidthColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property DataType As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralbrowseviewcolumn.DataTypeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'DataType' in table 'generalbrowseviewcolumn' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralbrowseviewcolumn.DataTypeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property FieldName As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralbrowseviewcolumn.FieldNameColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralbrowseviewcolumn.FieldNameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property GroupSummary As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralbrowseviewcolumn.GroupSummaryColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'GroupSummary' in table 'generalbrowseviewcolumn' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralbrowseviewcolumn.GroupSummaryColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property OrderNbr As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralbrowseviewcolumn.OrderNbrColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'OrderNbr' in table 'generalbrowseviewcolumn' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralbrowseviewcolumn.OrderNbrColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property RowIndex As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralbrowseviewcolumn.RowIndexColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'RowIndex' in table 'generalbrowseviewcolumn' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralbrowseviewcolumn.RowIndexColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ToShow As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralbrowseviewcolumn.ToShowColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ToShow' in table 'generalbrowseviewcolumn' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralbrowseviewcolumn.ToShowColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property TotalSummary As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralbrowseviewcolumn.TotalSummaryColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'TotalSummary' in table 'generalbrowseviewcolumn' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralbrowseviewcolumn.TotalSummaryColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ViewName As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralbrowseviewcolumn.ViewNameColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralbrowseviewcolumn.ViewNameColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralbrowseviewcolumn As generalbrowseviewcolumnDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalbrowseviewcolumnRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalbrowseviewcolumnRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As generalbrowseviewcolumnRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalbrowseviewcolumnRow
        End Class

        Public Delegate Sub generalbrowseviewcolumnRowChangeEventHandler(ByVal sender As Object, ByVal e As generalbrowseviewcolumnRowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class generalbrowseviewDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalbrowseviewRowChanged As generalbrowseviewRowChangeEventHandler
            Public Event generalbrowseviewRowChanging As generalbrowseviewRowChangeEventHandler
            Public Event generalbrowseviewRowDeleted As generalbrowseviewRowChangeEventHandler
            Public Event generalbrowseviewRowDeleting As generalbrowseviewRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalbrowseviewDataTable.__ENCList
                SyncLock list
                    generalbrowseviewDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalbrowseview"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalbrowseviewDataTable.__ENCList
                SyncLock list
                    generalbrowseviewDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = generalbrowseviewDataTable.__ENCList
                SyncLock list
                    generalbrowseviewDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddgeneralbrowseviewRow(ByVal row As generalbrowseviewRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddgeneralbrowseviewRow(ByVal BrowseViewID As Integer, ByVal UserID As Integer, ByVal MenuID As Integer, ByVal Name As String, ByVal Description As String, ByVal DefaultView As Integer, ByVal WindowWidth As Integer, ByVal WindowHeight As Integer, ByVal SystemView As Integer) As generalbrowseviewRow
                Dim row As generalbrowseviewRow = DirectCast(Me.NewRow, generalbrowseviewRow)
                row.ItemArray = New Object() { BrowseViewID, UserID, MenuID, Name, Description, DefaultView, WindowWidth, WindowHeight, SystemView }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalbrowseviewDataTable = DirectCast(MyBase.Clone, generalbrowseviewDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalbrowseviewDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByBrowseViewID(ByVal BrowseViewID As Integer) As generalbrowseviewRow
                Return DirectCast(Me.Rows.Find(New Object() { BrowseViewID }), generalbrowseviewRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalbrowseviewRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim view As New dsBrowseView
                xs.Add(view.GetSchemaSerializable)
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
                attribute.FixedValue = view.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalbrowseviewDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnBrowseViewID = New DataColumn("BrowseViewID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBrowseViewID)
                Me.columnUserID = New DataColumn("UserID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnUserID)
                Me.columnMenuID = New DataColumn("MenuID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuID)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnDefaultView = New DataColumn("DefaultView", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDefaultView)
                Me.columnWindowWidth = New DataColumn("WindowWidth", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnWindowWidth)
                Me.columnWindowHeight = New DataColumn("WindowHeight", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnWindowHeight)
                Me.columnSystemView = New DataColumn("SystemView", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSystemView)
                Me.Constraints.Add(New UniqueConstraint("dsBrowseViewKey1", New DataColumn() { Me.columnBrowseViewID }, True))
                Me.columnBrowseViewID.AllowDBNull = False
                Me.columnBrowseViewID.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnBrowseViewID = MyBase.Columns.Item("BrowseViewID")
                Me.columnUserID = MyBase.Columns.Item("UserID")
                Me.columnMenuID = MyBase.Columns.Item("MenuID")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnDefaultView = MyBase.Columns.Item("DefaultView")
                Me.columnWindowWidth = MyBase.Columns.Item("WindowWidth")
                Me.columnWindowHeight = MyBase.Columns.Item("WindowHeight")
                Me.columnSystemView = MyBase.Columns.Item("SystemView")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewgeneralbrowseviewRow() As generalbrowseviewRow
                Return DirectCast(Me.NewRow, generalbrowseviewRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalbrowseviewRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalbrowseviewRowChangedEvent Is Nothing) Then
                    Dim generalbrowseviewRowChangedEvent As generalbrowseviewRowChangeEventHandler = Me.generalbrowseviewRowChangedEvent
                    If (Not generalbrowseviewRowChangedEvent Is Nothing) Then
                        generalbrowseviewRowChangedEvent.Invoke(Me, New generalbrowseviewRowChangeEvent(DirectCast(e.Row, generalbrowseviewRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalbrowseviewRowChangingEvent Is Nothing) Then
                    Dim generalbrowseviewRowChangingEvent As generalbrowseviewRowChangeEventHandler = Me.generalbrowseviewRowChangingEvent
                    If (Not generalbrowseviewRowChangingEvent Is Nothing) Then
                        generalbrowseviewRowChangingEvent.Invoke(Me, New generalbrowseviewRowChangeEvent(DirectCast(e.Row, generalbrowseviewRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalbrowseviewRowDeletedEvent Is Nothing) Then
                    Dim generalbrowseviewRowDeletedEvent As generalbrowseviewRowChangeEventHandler = Me.generalbrowseviewRowDeletedEvent
                    If (Not generalbrowseviewRowDeletedEvent Is Nothing) Then
                        generalbrowseviewRowDeletedEvent.Invoke(Me, New generalbrowseviewRowChangeEvent(DirectCast(e.Row, generalbrowseviewRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalbrowseviewRowDeletingEvent Is Nothing) Then
                    Dim generalbrowseviewRowDeletingEvent As generalbrowseviewRowChangeEventHandler = Me.generalbrowseviewRowDeletingEvent
                    If (Not generalbrowseviewRowDeletingEvent Is Nothing) Then
                        generalbrowseviewRowDeletingEvent.Invoke(Me, New generalbrowseviewRowChangeEvent(DirectCast(e.Row, generalbrowseviewRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovegeneralbrowseviewRow(ByVal row As generalbrowseviewRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property BrowseViewIDColumn As DataColumn
                Get
                    Return Me.columnBrowseViewID
                End Get
            End Property

            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DefaultViewColumn As DataColumn
                Get
                    Return Me.columnDefaultView
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalbrowseviewRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generalbrowseviewRow)
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
            Public ReadOnly Property SystemViewColumn As DataColumn
                Get
                    Return Me.columnSystemView
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property UserIDColumn As DataColumn
                Get
                    Return Me.columnUserID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property WindowHeightColumn As DataColumn
                Get
                    Return Me.columnWindowHeight
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property WindowWidthColumn As DataColumn
                Get
                    Return Me.columnWindowWidth
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnBrowseViewID As DataColumn
            Private columnDefaultView As DataColumn
            Private columnDescription As DataColumn
            Private columnMenuID As DataColumn
            Private columnName As DataColumn
            Private columnSystemView As DataColumn
            Private columnUserID As DataColumn
            Private columnWindowHeight As DataColumn
            Private columnWindowWidth As DataColumn
        End Class

        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item")> _
        Public Class generalbrowseviewgroupbyDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalbrowseviewgroupbyRowChanged As generalbrowseviewgroupbyRowChangeEventHandler
            Public Event generalbrowseviewgroupbyRowChanging As generalbrowseviewgroupbyRowChangeEventHandler
            Public Event generalbrowseviewgroupbyRowDeleted As generalbrowseviewgroupbyRowChangeEventHandler
            Public Event generalbrowseviewgroupbyRowDeleting As generalbrowseviewgroupbyRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalbrowseviewgroupbyDataTable.__ENCList
                SyncLock list
                    generalbrowseviewgroupbyDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalbrowseviewgroupby"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalbrowseviewgroupbyDataTable.__ENCList
                SyncLock list
                    generalbrowseviewgroupbyDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = generalbrowseviewgroupbyDataTable.__ENCList
                SyncLock list
                    generalbrowseviewgroupbyDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddgeneralbrowseviewgroupbyRow(ByVal row As generalbrowseviewgroupbyRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddgeneralbrowseviewgroupbyRow(ByVal BrowseViewID As Integer, ByVal ViewName As String, ByVal FieldName As String, ByVal OrderNbr As Integer, ByVal ToGroup As Boolean) As generalbrowseviewgroupbyRow
                Dim row As generalbrowseviewgroupbyRow = DirectCast(Me.NewRow, generalbrowseviewgroupbyRow)
                row.ItemArray = New Object() { BrowseViewID, ViewName, FieldName, OrderNbr, ToGroup }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalbrowseviewgroupbyDataTable = DirectCast(MyBase.Clone, generalbrowseviewgroupbyDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalbrowseviewgroupbyDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByBrowseViewIDViewNameFieldName(ByVal BrowseViewID As Integer, ByVal ViewName As String, ByVal FieldName As String) As generalbrowseviewgroupbyRow
                Return DirectCast(Me.Rows.Find(New Object() { BrowseViewID, ViewName, FieldName }), generalbrowseviewgroupbyRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalbrowseviewgroupbyRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim view As New dsBrowseView
                xs.Add(view.GetSchemaSerializable)
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
                attribute.FixedValue = view.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalbrowseviewgroupbyDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnBrowseViewID = New DataColumn("BrowseViewID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBrowseViewID)
                Me.columnViewName = New DataColumn("ViewName", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnViewName)
                Me.columnFieldName = New DataColumn("FieldName", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFieldName)
                Me.columnOrderNbr = New DataColumn("OrderNbr", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnOrderNbr)
                Me.columnToGroup = New DataColumn("ToGroup", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnToGroup)
                Me.Constraints.Add(New UniqueConstraint("dsBrowseViewKey3", New DataColumn() { Me.columnBrowseViewID, Me.columnViewName, Me.columnFieldName }, True))
                Me.columnBrowseViewID.AllowDBNull = False
                Me.columnViewName.AllowDBNull = False
                Me.columnFieldName.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnBrowseViewID = MyBase.Columns.Item("BrowseViewID")
                Me.columnViewName = MyBase.Columns.Item("ViewName")
                Me.columnFieldName = MyBase.Columns.Item("FieldName")
                Me.columnOrderNbr = MyBase.Columns.Item("OrderNbr")
                Me.columnToGroup = MyBase.Columns.Item("ToGroup")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewgeneralbrowseviewgroupbyRow() As generalbrowseviewgroupbyRow
                Return DirectCast(Me.NewRow, generalbrowseviewgroupbyRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalbrowseviewgroupbyRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalbrowseviewgroupbyRowChangedEvent Is Nothing) Then
                    Dim generalbrowseviewgroupbyRowChangedEvent As generalbrowseviewgroupbyRowChangeEventHandler = Me.generalbrowseviewgroupbyRowChangedEvent
                    If (Not generalbrowseviewgroupbyRowChangedEvent Is Nothing) Then
                        generalbrowseviewgroupbyRowChangedEvent.Invoke(Me, New generalbrowseviewgroupbyRowChangeEvent(DirectCast(e.Row, generalbrowseviewgroupbyRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalbrowseviewgroupbyRowChangingEvent Is Nothing) Then
                    Dim generalbrowseviewgroupbyRowChangingEvent As generalbrowseviewgroupbyRowChangeEventHandler = Me.generalbrowseviewgroupbyRowChangingEvent
                    If (Not generalbrowseviewgroupbyRowChangingEvent Is Nothing) Then
                        generalbrowseviewgroupbyRowChangingEvent.Invoke(Me, New generalbrowseviewgroupbyRowChangeEvent(DirectCast(e.Row, generalbrowseviewgroupbyRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalbrowseviewgroupbyRowDeletedEvent Is Nothing) Then
                    Dim generalbrowseviewgroupbyRowDeletedEvent As generalbrowseviewgroupbyRowChangeEventHandler = Me.generalbrowseviewgroupbyRowDeletedEvent
                    If (Not generalbrowseviewgroupbyRowDeletedEvent Is Nothing) Then
                        generalbrowseviewgroupbyRowDeletedEvent.Invoke(Me, New generalbrowseviewgroupbyRowChangeEvent(DirectCast(e.Row, generalbrowseviewgroupbyRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalbrowseviewgroupbyRowDeletingEvent Is Nothing) Then
                    Dim generalbrowseviewgroupbyRowDeletingEvent As generalbrowseviewgroupbyRowChangeEventHandler = Me.generalbrowseviewgroupbyRowDeletingEvent
                    If (Not generalbrowseviewgroupbyRowDeletingEvent Is Nothing) Then
                        generalbrowseviewgroupbyRowDeletingEvent.Invoke(Me, New generalbrowseviewgroupbyRowChangeEvent(DirectCast(e.Row, generalbrowseviewgroupbyRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovegeneralbrowseviewgroupbyRow(ByVal row As generalbrowseviewgroupbyRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property BrowseViewIDColumn As DataColumn
                Get
                    Return Me.columnBrowseViewID
                End Get
            End Property

            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FieldNameColumn As DataColumn
                Get
                    Return Me.columnFieldName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalbrowseviewgroupbyRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generalbrowseviewgroupbyRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property OrderNbrColumn As DataColumn
                Get
                    Return Me.columnOrderNbr
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ToGroupColumn As DataColumn
                Get
                    Return Me.columnToGroup
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ViewNameColumn As DataColumn
                Get
                    Return Me.columnViewName
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnBrowseViewID As DataColumn
            Private columnFieldName As DataColumn
            Private columnOrderNbr As DataColumn
            Private columnToGroup As DataColumn
            Private columnViewName As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalbrowseviewgroupbyRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralbrowseviewgroupby = DirectCast(Me.Table, generalbrowseviewgroupbyDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsOrderNbrNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseviewgroupby.OrderNbrColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsToGroupNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseviewgroupby.ToGroupColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetOrderNbrNull()
                Me.Item(Me.tablegeneralbrowseviewgroupby.OrderNbrColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetToGroupNull()
                Me.Item(Me.tablegeneralbrowseviewgroupby.ToGroupColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property BrowseViewID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralbrowseviewgroupby.BrowseViewIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralbrowseviewgroupby.BrowseViewIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property FieldName As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralbrowseviewgroupby.FieldNameColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralbrowseviewgroupby.FieldNameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property OrderNbr As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralbrowseviewgroupby.OrderNbrColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'OrderNbr' in table 'generalbrowseviewgroupby' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralbrowseviewgroupby.OrderNbrColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ToGroup As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralbrowseviewgroupby.ToGroupColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ToGroup' in table 'generalbrowseviewgroupby' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralbrowseviewgroupby.ToGroupColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ViewName As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralbrowseviewgroupby.ViewNameColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralbrowseviewgroupby.ViewNameColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralbrowseviewgroupby As generalbrowseviewgroupbyDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalbrowseviewgroupbyRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalbrowseviewgroupbyRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As generalbrowseviewgroupbyRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalbrowseviewgroupbyRow
        End Class

        Public Delegate Sub generalbrowseviewgroupbyRowChangeEventHandler(ByVal sender As Object, ByVal e As generalbrowseviewgroupbyRowChangeEvent)

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalbrowseviewRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralbrowseview = DirectCast(Me.Table, generalbrowseviewDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsDefaultViewNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseview.DefaultViewColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseview.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuIDNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseview.MenuIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseview.NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsSystemViewNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseview.SystemViewColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsUserIDNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseview.UserIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsWindowHeightNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseview.WindowHeightColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsWindowWidthNull() As Boolean
                Return Me.IsNull(Me.tablegeneralbrowseview.WindowWidthColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetDefaultViewNull()
                Me.Item(Me.tablegeneralbrowseview.DefaultViewColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tablegeneralbrowseview.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuIDNull()
                Me.Item(Me.tablegeneralbrowseview.MenuIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNameNull()
                Me.Item(Me.tablegeneralbrowseview.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetSystemViewNull()
                Me.Item(Me.tablegeneralbrowseview.SystemViewColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetUserIDNull()
                Me.Item(Me.tablegeneralbrowseview.UserIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetWindowHeightNull()
                Me.Item(Me.tablegeneralbrowseview.WindowHeightColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetWindowWidthNull()
                Me.Item(Me.tablegeneralbrowseview.WindowWidthColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property BrowseViewID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralbrowseview.BrowseViewIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralbrowseview.BrowseViewIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property DefaultView As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralbrowseview.DefaultViewColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'DefaultView' in table 'generalbrowseview' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralbrowseview.DefaultViewColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralbrowseview.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'generalbrowseview' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralbrowseview.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralbrowseview.MenuIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuID' in table 'generalbrowseview' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralbrowseview.MenuIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralbrowseview.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'generalbrowseview' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralbrowseview.NameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property SystemView As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralbrowseview.SystemViewColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'SystemView' in table 'generalbrowseview' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralbrowseview.SystemViewColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property UserID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralbrowseview.UserIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'UserID' in table 'generalbrowseview' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralbrowseview.UserIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property WindowHeight As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralbrowseview.WindowHeightColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'WindowHeight' in table 'generalbrowseview' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralbrowseview.WindowHeightColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property WindowWidth As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralbrowseview.WindowWidthColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'WindowWidth' in table 'generalbrowseview' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralbrowseview.WindowWidthColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralbrowseview As generalbrowseviewDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalbrowseviewRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalbrowseviewRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As generalbrowseviewRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalbrowseviewRow
        End Class

        Public Delegate Sub generalbrowseviewRowChangeEventHandler(ByVal sender As Object, ByVal e As generalbrowseviewRowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class GroupSummaryTypeDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event GroupSummaryTypeRowChanged As GroupSummaryTypeRowChangeEventHandler
            Public Event GroupSummaryTypeRowChanging As GroupSummaryTypeRowChangeEventHandler
            Public Event GroupSummaryTypeRowDeleted As GroupSummaryTypeRowChangeEventHandler
            Public Event GroupSummaryTypeRowDeleting As GroupSummaryTypeRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = GroupSummaryTypeDataTable.__ENCList
                SyncLock list
                    GroupSummaryTypeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "GroupSummaryType"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = GroupSummaryTypeDataTable.__ENCList
                SyncLock list
                    GroupSummaryTypeDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = GroupSummaryTypeDataTable.__ENCList
                SyncLock list
                    GroupSummaryTypeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddGroupSummaryTypeRow(ByVal row As GroupSummaryTypeRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddGroupSummaryTypeRow(ByVal CodeType As String, ByVal CodeValue As Integer, ByVal CodeDesc As String) As GroupSummaryTypeRow
                Dim row As GroupSummaryTypeRow = DirectCast(Me.NewRow, GroupSummaryTypeRow)
                row.ItemArray = New Object() { CodeType, CodeValue, CodeDesc }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As GroupSummaryTypeDataTable = DirectCast(MyBase.Clone, GroupSummaryTypeDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New GroupSummaryTypeDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByCodeTypeCodeValue(ByVal CodeType As String, ByVal CodeValue As Integer) As GroupSummaryTypeRow
                Return DirectCast(Me.Rows.Find(New Object() { CodeType, CodeValue }), GroupSummaryTypeRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(GroupSummaryTypeRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim view As New dsBrowseView
                xs.Add(view.GetSchemaSerializable)
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
                attribute.FixedValue = view.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "GroupSummaryTypeDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnCodeType = New DataColumn("CodeType", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeType)
                Me.columnCodeValue = New DataColumn("CodeValue", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeValue)
                Me.columnCodeDesc = New DataColumn("CodeDesc", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeDesc)
                Me.Constraints.Add(New UniqueConstraint("dsBrowseViewKey5", New DataColumn() { Me.columnCodeType, Me.columnCodeValue }, True))
                Me.columnCodeType.AllowDBNull = False
                Me.columnCodeValue.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnCodeType = MyBase.Columns.Item("CodeType")
                Me.columnCodeValue = MyBase.Columns.Item("CodeValue")
                Me.columnCodeDesc = MyBase.Columns.Item("CodeDesc")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewGroupSummaryTypeRow() As GroupSummaryTypeRow
                Return DirectCast(Me.NewRow, GroupSummaryTypeRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New GroupSummaryTypeRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.GroupSummaryTypeRowChangedEvent Is Nothing) Then
                    Dim groupSummaryTypeRowChangedEvent As GroupSummaryTypeRowChangeEventHandler = Me.GroupSummaryTypeRowChangedEvent
                    If (Not groupSummaryTypeRowChangedEvent Is Nothing) Then
                        groupSummaryTypeRowChangedEvent.Invoke(Me, New GroupSummaryTypeRowChangeEvent(DirectCast(e.Row, GroupSummaryTypeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.GroupSummaryTypeRowChangingEvent Is Nothing) Then
                    Dim groupSummaryTypeRowChangingEvent As GroupSummaryTypeRowChangeEventHandler = Me.GroupSummaryTypeRowChangingEvent
                    If (Not groupSummaryTypeRowChangingEvent Is Nothing) Then
                        groupSummaryTypeRowChangingEvent.Invoke(Me, New GroupSummaryTypeRowChangeEvent(DirectCast(e.Row, GroupSummaryTypeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.GroupSummaryTypeRowDeletedEvent Is Nothing) Then
                    Dim groupSummaryTypeRowDeletedEvent As GroupSummaryTypeRowChangeEventHandler = Me.GroupSummaryTypeRowDeletedEvent
                    If (Not groupSummaryTypeRowDeletedEvent Is Nothing) Then
                        groupSummaryTypeRowDeletedEvent.Invoke(Me, New GroupSummaryTypeRowChangeEvent(DirectCast(e.Row, GroupSummaryTypeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.GroupSummaryTypeRowDeletingEvent Is Nothing) Then
                    Dim groupSummaryTypeRowDeletingEvent As GroupSummaryTypeRowChangeEventHandler = Me.GroupSummaryTypeRowDeletingEvent
                    If (Not groupSummaryTypeRowDeletingEvent Is Nothing) Then
                        groupSummaryTypeRowDeletingEvent.Invoke(Me, New GroupSummaryTypeRowChangeEvent(DirectCast(e.Row, GroupSummaryTypeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemoveGroupSummaryTypeRow(ByVal row As GroupSummaryTypeRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeDescColumn As DataColumn
                Get
                    Return Me.columnCodeDesc
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeTypeColumn As DataColumn
                Get
                    Return Me.columnCodeType
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeValueColumn As DataColumn
                Get
                    Return Me.columnCodeValue
                End Get
            End Property

            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As GroupSummaryTypeRow
                Get
                    Return DirectCast(Me.Rows.Item(index), GroupSummaryTypeRow)
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnCodeDesc As DataColumn
            Private columnCodeType As DataColumn
            Private columnCodeValue As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class GroupSummaryTypeRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableGroupSummaryType = DirectCast(Me.Table, GroupSummaryTypeDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsCodeDescNull() As Boolean
                Return Me.IsNull(Me.tableGroupSummaryType.CodeDescColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetCodeDescNull()
                Me.Item(Me.tableGroupSummaryType.CodeDescColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property CodeDesc As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGroupSummaryType.CodeDescColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CodeDesc' in table 'GroupSummaryType' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGroupSummaryType.CodeDescColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CodeType As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tableGroupSummaryType.CodeTypeColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGroupSummaryType.CodeTypeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CodeValue As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tableGroupSummaryType.CodeValueColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGroupSummaryType.CodeValueColumn) = Value
                End Set
            End Property


            ' Fields
            Private tableGroupSummaryType As GroupSummaryTypeDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class GroupSummaryTypeRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As GroupSummaryTypeRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As GroupSummaryTypeRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As GroupSummaryTypeRow
        End Class

        Public Delegate Sub GroupSummaryTypeRowChangeEventHandler(ByVal sender As Object, ByVal e As GroupSummaryTypeRowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class TotalSummaryTypeDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event TotalSummaryTypeRowChanged As TotalSummaryTypeRowChangeEventHandler
            Public Event TotalSummaryTypeRowChanging As TotalSummaryTypeRowChangeEventHandler
            Public Event TotalSummaryTypeRowDeleted As TotalSummaryTypeRowChangeEventHandler
            Public Event TotalSummaryTypeRowDeleting As TotalSummaryTypeRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = TotalSummaryTypeDataTable.__ENCList
                SyncLock list
                    TotalSummaryTypeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "TotalSummaryType"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = TotalSummaryTypeDataTable.__ENCList
                SyncLock list
                    TotalSummaryTypeDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = TotalSummaryTypeDataTable.__ENCList
                SyncLock list
                    TotalSummaryTypeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddTotalSummaryTypeRow(ByVal row As TotalSummaryTypeRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddTotalSummaryTypeRow(ByVal CodeType As String, ByVal CodeValue As Integer, ByVal CodeDesc As String) As TotalSummaryTypeRow
                Dim row As TotalSummaryTypeRow = DirectCast(Me.NewRow, TotalSummaryTypeRow)
                row.ItemArray = New Object() { CodeType, CodeValue, CodeDesc }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As TotalSummaryTypeDataTable = DirectCast(MyBase.Clone, TotalSummaryTypeDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New TotalSummaryTypeDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByCodeTypeCodeValue(ByVal CodeType As String, ByVal CodeValue As Integer) As TotalSummaryTypeRow
                Return DirectCast(Me.Rows.Find(New Object() { CodeType, CodeValue }), TotalSummaryTypeRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(TotalSummaryTypeRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim view As New dsBrowseView
                xs.Add(view.GetSchemaSerializable)
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
                attribute.FixedValue = view.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "TotalSummaryTypeDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnCodeType = New DataColumn("CodeType", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeType)
                Me.columnCodeValue = New DataColumn("CodeValue", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeValue)
                Me.columnCodeDesc = New DataColumn("CodeDesc", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeDesc)
                Me.Constraints.Add(New UniqueConstraint("dsBrowseViewKey4", New DataColumn() { Me.columnCodeType, Me.columnCodeValue }, True))
                Me.columnCodeType.AllowDBNull = False
                Me.columnCodeValue.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnCodeType = MyBase.Columns.Item("CodeType")
                Me.columnCodeValue = MyBase.Columns.Item("CodeValue")
                Me.columnCodeDesc = MyBase.Columns.Item("CodeDesc")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New TotalSummaryTypeRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewTotalSummaryTypeRow() As TotalSummaryTypeRow
                Return DirectCast(Me.NewRow, TotalSummaryTypeRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.TotalSummaryTypeRowChangedEvent Is Nothing) Then
                    Dim totalSummaryTypeRowChangedEvent As TotalSummaryTypeRowChangeEventHandler = Me.TotalSummaryTypeRowChangedEvent
                    If (Not totalSummaryTypeRowChangedEvent Is Nothing) Then
                        totalSummaryTypeRowChangedEvent.Invoke(Me, New TotalSummaryTypeRowChangeEvent(DirectCast(e.Row, TotalSummaryTypeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.TotalSummaryTypeRowChangingEvent Is Nothing) Then
                    Dim totalSummaryTypeRowChangingEvent As TotalSummaryTypeRowChangeEventHandler = Me.TotalSummaryTypeRowChangingEvent
                    If (Not totalSummaryTypeRowChangingEvent Is Nothing) Then
                        totalSummaryTypeRowChangingEvent.Invoke(Me, New TotalSummaryTypeRowChangeEvent(DirectCast(e.Row, TotalSummaryTypeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.TotalSummaryTypeRowDeletedEvent Is Nothing) Then
                    Dim totalSummaryTypeRowDeletedEvent As TotalSummaryTypeRowChangeEventHandler = Me.TotalSummaryTypeRowDeletedEvent
                    If (Not totalSummaryTypeRowDeletedEvent Is Nothing) Then
                        totalSummaryTypeRowDeletedEvent.Invoke(Me, New TotalSummaryTypeRowChangeEvent(DirectCast(e.Row, TotalSummaryTypeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.TotalSummaryTypeRowDeletingEvent Is Nothing) Then
                    Dim totalSummaryTypeRowDeletingEvent As TotalSummaryTypeRowChangeEventHandler = Me.TotalSummaryTypeRowDeletingEvent
                    If (Not totalSummaryTypeRowDeletingEvent Is Nothing) Then
                        totalSummaryTypeRowDeletingEvent.Invoke(Me, New TotalSummaryTypeRowChangeEvent(DirectCast(e.Row, TotalSummaryTypeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemoveTotalSummaryTypeRow(ByVal row As TotalSummaryTypeRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeDescColumn As DataColumn
                Get
                    Return Me.columnCodeDesc
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeTypeColumn As DataColumn
                Get
                    Return Me.columnCodeType
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeValueColumn As DataColumn
                Get
                    Return Me.columnCodeValue
                End Get
            End Property

            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As TotalSummaryTypeRow
                Get
                    Return DirectCast(Me.Rows.Item(index), TotalSummaryTypeRow)
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnCodeDesc As DataColumn
            Private columnCodeType As DataColumn
            Private columnCodeValue As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class TotalSummaryTypeRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableTotalSummaryType = DirectCast(Me.Table, TotalSummaryTypeDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsCodeDescNull() As Boolean
                Return Me.IsNull(Me.tableTotalSummaryType.CodeDescColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetCodeDescNull()
                Me.Item(Me.tableTotalSummaryType.CodeDescColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property CodeDesc As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableTotalSummaryType.CodeDescColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CodeDesc' in table 'TotalSummaryType' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableTotalSummaryType.CodeDescColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CodeType As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tableTotalSummaryType.CodeTypeColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableTotalSummaryType.CodeTypeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CodeValue As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tableTotalSummaryType.CodeValueColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableTotalSummaryType.CodeValueColumn) = Value
                End Set
            End Property


            ' Fields
            Private tableTotalSummaryType As TotalSummaryTypeDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class TotalSummaryTypeRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As TotalSummaryTypeRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As TotalSummaryTypeRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As TotalSummaryTypeRow
        End Class

        Public Delegate Sub TotalSummaryTypeRowChangeEventHandler(ByVal sender As Object, ByVal e As TotalSummaryTypeRowChangeEvent)
    End Class
End Namespace

