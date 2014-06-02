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
    <Serializable, XmlRoot("dsAnalyze"), XmlSchemaProvider("GetTypedDataSetSchema"), ToolboxItem(True), DesignerCategory("code"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet")> _
    Public Class dsAnalyze
        Inherits DataSet
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Dim list As ArrayList = dsAnalyze.__ENCList
            SyncLock list
                dsAnalyze.__ENCList.Add(New WeakReference(Me))
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
            Dim list As ArrayList = dsAnalyze.__ENCList
            SyncLock list
                dsAnalyze.__ENCList.Add(New WeakReference(Me))
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
                    If (Not dataSet.Tables.Item("generalanalyze1") Is Nothing) Then
                        MyBase.Tables.Add(New generalanalyze1DataTable(dataSet.Tables.Item("generalanalyze1")))
                    End If
                    If (Not dataSet.Tables.Item("generalanalyze") Is Nothing) Then
                        MyBase.Tables.Add(New generalanalyzeDataTable(dataSet.Tables.Item("generalanalyze")))
                    End If
                    If (Not dataSet.Tables.Item("generalanalyzefield") Is Nothing) Then
                        MyBase.Tables.Add(New generalanalyzefieldDataTable(dataSet.Tables.Item("generalanalyzefield")))
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
            Dim analyze As dsAnalyze = DirectCast(MyBase.Clone, dsAnalyze)
            analyze.InitVars
            analyze.SchemaSerializationMode = Me.SchemaSerializationMode
            Return analyze
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
            Dim analyze As New dsAnalyze
            Dim type2 As New XmlSchemaComplexType
            Dim sequence As New XmlSchemaSequence
            xs.Add(analyze.GetSchemaSerializable)
            Dim item As New XmlSchemaAny
            item.Namespace = analyze.Namespace
            sequence.Items.Add(item)
            type2.Particle = sequence
            Return type2
        End Function

        <DebuggerNonUserCode> _
        Private Sub InitClass()
            Me.DataSetName = "dsAnalyze"
            Me.Prefix = ""
            Me.Namespace = "http://tempuri.org/dsAnalyze.xsd"
            Me.EnforceConstraints = True
            Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
            Me.tablegeneralanalyze1 = New generalanalyze1DataTable
            MyBase.Tables.Add(Me.tablegeneralanalyze1)
            Me.tablegeneralanalyze = New generalanalyzeDataTable
            MyBase.Tables.Add(Me.tablegeneralanalyze)
            Me.tablegeneralanalyzefield = New generalanalyzefieldDataTable
            MyBase.Tables.Add(Me.tablegeneralanalyzefield)
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
            Me.tablegeneralanalyze1 = DirectCast(MyBase.Tables.Item("generalanalyze1"), generalanalyze1DataTable)
            If (initTable AndAlso (Not Me.tablegeneralanalyze1 Is Nothing)) Then
                Me.tablegeneralanalyze1.InitVars
            End If
            Me.tablegeneralanalyze = DirectCast(MyBase.Tables.Item("generalanalyze"), generalanalyzeDataTable)
            If (initTable AndAlso (Not Me.tablegeneralanalyze Is Nothing)) Then
                Me.tablegeneralanalyze.InitVars
            End If
            Me.tablegeneralanalyzefield = DirectCast(MyBase.Tables.Item("generalanalyzefield"), generalanalyzefieldDataTable)
            If (initTable AndAlso (Not Me.tablegeneralanalyzefield Is Nothing)) Then
                Me.tablegeneralanalyzefield.InitVars
            End If
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
            If (Me.DetermineSchemaSerializationMode(reader) = SchemaSerializationMode.IncludeSchema) Then
                Me.Reset
                Dim dataSet As New DataSet
                dataSet.ReadXml(reader)
                If (Not dataSet.Tables.Item("generalanalyze1") Is Nothing) Then
                    MyBase.Tables.Add(New generalanalyze1DataTable(dataSet.Tables.Item("generalanalyze1")))
                End If
                If (Not dataSet.Tables.Item("generalanalyze") Is Nothing) Then
                    MyBase.Tables.Add(New generalanalyzeDataTable(dataSet.Tables.Item("generalanalyze")))
                End If
                If (Not dataSet.Tables.Item("generalanalyzefield") Is Nothing) Then
                    MyBase.Tables.Add(New generalanalyzefieldDataTable(dataSet.Tables.Item("generalanalyzefield")))
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
        Private Function ShouldSerializegeneralanalyze() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneralanalyze1() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneralanalyzefield() As Boolean
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
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False), DebuggerNonUserCode> _
        Public ReadOnly Property generalanalyze As generalanalyzeDataTable
            Get
                Return Me.tablegeneralanalyze
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(False)> _
        Public ReadOnly Property generalanalyze1 As generalanalyze1DataTable
            Get
                Return Me.tablegeneralanalyze1
            End Get
        End Property

        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode> _
        Public ReadOnly Property generalanalyzefield As generalanalyzefieldDataTable
            Get
                Return Me.tablegeneralanalyzefield
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
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
        Private tablegeneralanalyze As generalanalyzeDataTable
        Private tablegeneralanalyze1 As generalanalyze1DataTable
        Private tablegeneralanalyzefield As generalanalyzefieldDataTable

        ' Nested Types
        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema"), DefaultMember("Item")> _
        Public Class generalanalyze1DataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalanalyze1RowChanged As generalanalyze1RowChangeEventHandler
            Public Event generalanalyze1RowChanging As generalanalyze1RowChangeEventHandler
            Public Event generalanalyze1RowDeleted As generalanalyze1RowChangeEventHandler
            Public Event generalanalyze1RowDeleting As generalanalyze1RowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalanalyze1DataTable.__ENCList
                SyncLock list
                    generalanalyze1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalanalyze1"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalanalyze1DataTable.__ENCList
                SyncLock list
                    generalanalyze1DataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = generalanalyze1DataTable.__ENCList
                SyncLock list
                    generalanalyze1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub Addgeneralanalyze1Row(ByVal row As generalanalyze1Row)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function Addgeneralanalyze1Row(ByVal AnalyzeID As Integer, ByVal UserID As Integer, ByVal MenuID As Integer, ByVal Name As String, ByVal Description As String, ByVal ColGrandTotal As Boolean, ByVal ColTotal As Boolean, ByVal GrandTotalSingle As Boolean, ByVal RowGrandTotal As Boolean, ByVal RowTotal As Boolean, ByVal TotalSingle As Boolean) As generalanalyze1Row
                Dim row As generalanalyze1Row = DirectCast(Me.NewRow, generalanalyze1Row)
                row.ItemArray = New Object() { AnalyzeID, UserID, MenuID, Name, Description, ColGrandTotal, ColTotal, GrandTotalSingle, RowGrandTotal, RowTotal, TotalSingle }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalanalyze1DataTable = DirectCast(MyBase.Clone, generalanalyze1DataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalanalyze1DataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByAnalyzeID(ByVal AnalyzeID As Integer) As generalanalyze1Row
                Return DirectCast(Me.Rows.Find(New Object() { AnalyzeID }), generalanalyze1Row)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalanalyze1Row)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim analyze As New dsAnalyze
                xs.Add(analyze.GetSchemaSerializable)
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
                attribute.FixedValue = analyze.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalanalyze1DataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnAnalyzeID = New DataColumn("AnalyzeID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAnalyzeID)
                Me.columnUserID = New DataColumn("UserID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnUserID)
                Me.columnMenuID = New DataColumn("MenuID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuID)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnColGrandTotal = New DataColumn("ColGrandTotal", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnColGrandTotal)
                Me.columnColTotal = New DataColumn("ColTotal", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnColTotal)
                Me.columnGrandTotalSingle = New DataColumn("GrandTotalSingle", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnGrandTotalSingle)
                Me.columnRowGrandTotal = New DataColumn("RowGrandTotal", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnRowGrandTotal)
                Me.columnRowTotal = New DataColumn("RowTotal", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnRowTotal)
                Me.columnTotalSingle = New DataColumn("TotalSingle", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnTotalSingle)
                Me.Constraints.Add(New UniqueConstraint("dsAnalyzeKey3", New DataColumn() { Me.columnAnalyzeID }, True))
                Me.columnAnalyzeID.AllowDBNull = False
                Me.columnAnalyzeID.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnAnalyzeID = MyBase.Columns.Item("AnalyzeID")
                Me.columnUserID = MyBase.Columns.Item("UserID")
                Me.columnMenuID = MyBase.Columns.Item("MenuID")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnColGrandTotal = MyBase.Columns.Item("ColGrandTotal")
                Me.columnColTotal = MyBase.Columns.Item("ColTotal")
                Me.columnGrandTotalSingle = MyBase.Columns.Item("GrandTotalSingle")
                Me.columnRowGrandTotal = MyBase.Columns.Item("RowGrandTotal")
                Me.columnRowTotal = MyBase.Columns.Item("RowTotal")
                Me.columnTotalSingle = MyBase.Columns.Item("TotalSingle")
            End Sub

            <DebuggerNonUserCode> _
            Public Function Newgeneralanalyze1Row() As generalanalyze1Row
                Return DirectCast(Me.NewRow, generalanalyze1Row)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalanalyze1Row(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalanalyze1RowChangedEvent Is Nothing) Then
                    Dim handler As generalanalyze1RowChangeEventHandler = Me.generalanalyze1RowChangedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New generalanalyze1RowChangeEvent(DirectCast(e.Row, generalanalyze1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalanalyze1RowChangingEvent Is Nothing) Then
                    Dim handler As generalanalyze1RowChangeEventHandler = Me.generalanalyze1RowChangingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New generalanalyze1RowChangeEvent(DirectCast(e.Row, generalanalyze1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalanalyze1RowDeletedEvent Is Nothing) Then
                    Dim handler As generalanalyze1RowChangeEventHandler = Me.generalanalyze1RowDeletedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New generalanalyze1RowChangeEvent(DirectCast(e.Row, generalanalyze1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalanalyze1RowDeletingEvent Is Nothing) Then
                    Dim handler As generalanalyze1RowChangeEventHandler = Me.generalanalyze1RowDeletingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New generalanalyze1RowChangeEvent(DirectCast(e.Row, generalanalyze1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub Removegeneralanalyze1Row(ByVal row As generalanalyze1Row)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property AnalyzeIDColumn As DataColumn
                Get
                    Return Me.columnAnalyzeID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ColGrandTotalColumn As DataColumn
                Get
                    Return Me.columnColGrandTotal
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ColTotalColumn As DataColumn
                Get
                    Return Me.columnColTotal
                End Get
            End Property

            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property GrandTotalSingleColumn As DataColumn
                Get
                    Return Me.columnGrandTotalSingle
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalanalyze1Row
                Get
                    Return DirectCast(Me.Rows.Item(index), generalanalyze1Row)
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
            Public ReadOnly Property RowGrandTotalColumn As DataColumn
                Get
                    Return Me.columnRowGrandTotal
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property RowTotalColumn As DataColumn
                Get
                    Return Me.columnRowTotal
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property TotalSingleColumn As DataColumn
                Get
                    Return Me.columnTotalSingle
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
            Private columnAnalyzeID As DataColumn
            Private columnColGrandTotal As DataColumn
            Private columnColTotal As DataColumn
            Private columnDescription As DataColumn
            Private columnGrandTotalSingle As DataColumn
            Private columnMenuID As DataColumn
            Private columnName As DataColumn
            Private columnRowGrandTotal As DataColumn
            Private columnRowTotal As DataColumn
            Private columnTotalSingle As DataColumn
            Private columnUserID As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalanalyze1Row
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralanalyze1 = DirectCast(Me.Table, generalanalyze1DataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsColGrandTotalNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze1.ColGrandTotalColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsColTotalNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze1.ColTotalColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze1.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsGrandTotalSingleNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze1.GrandTotalSingleColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuIDNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze1.MenuIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze1.NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsRowGrandTotalNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze1.RowGrandTotalColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsRowTotalNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze1.RowTotalColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsTotalSingleNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze1.TotalSingleColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsUserIDNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze1.UserIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetColGrandTotalNull()
                Me.Item(Me.tablegeneralanalyze1.ColGrandTotalColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetColTotalNull()
                Me.Item(Me.tablegeneralanalyze1.ColTotalColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tablegeneralanalyze1.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetGrandTotalSingleNull()
                Me.Item(Me.tablegeneralanalyze1.GrandTotalSingleColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuIDNull()
                Me.Item(Me.tablegeneralanalyze1.MenuIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNameNull()
                Me.Item(Me.tablegeneralanalyze1.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetRowGrandTotalNull()
                Me.Item(Me.tablegeneralanalyze1.RowGrandTotalColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetRowTotalNull()
                Me.Item(Me.tablegeneralanalyze1.RowTotalColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetTotalSingleNull()
                Me.Item(Me.tablegeneralanalyze1.TotalSingleColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetUserIDNull()
                Me.Item(Me.tablegeneralanalyze1.UserIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property AnalyzeID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralanalyze1.AnalyzeIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralanalyze1.AnalyzeIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ColGrandTotal As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralanalyze1.ColGrandTotalColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ColGrandTotal' in table 'generalanalyze1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralanalyze1.ColGrandTotalColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ColTotal As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralanalyze1.ColTotalColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ColTotal' in table 'generalanalyze1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralanalyze1.ColTotalColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralanalyze1.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'generalanalyze1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralanalyze1.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property GrandTotalSingle As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralanalyze1.GrandTotalSingleColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'GrandTotalSingle' in table 'generalanalyze1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralanalyze1.GrandTotalSingleColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralanalyze1.MenuIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuID' in table 'generalanalyze1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralanalyze1.MenuIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralanalyze1.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'generalanalyze1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralanalyze1.NameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property RowGrandTotal As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralanalyze1.RowGrandTotalColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'RowGrandTotal' in table 'generalanalyze1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralanalyze1.RowGrandTotalColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property RowTotal As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralanalyze1.RowTotalColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'RowTotal' in table 'generalanalyze1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralanalyze1.RowTotalColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property TotalSingle As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralanalyze1.TotalSingleColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'TotalSingle' in table 'generalanalyze1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralanalyze1.TotalSingleColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property UserID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralanalyze1.UserIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'UserID' in table 'generalanalyze1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralanalyze1.UserIDColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralanalyze1 As generalanalyze1DataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalanalyze1RowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalanalyze1Row, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As generalanalyze1Row
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalanalyze1Row
        End Class

        Public Delegate Sub generalanalyze1RowChangeEventHandler(ByVal sender As Object, ByVal e As generalanalyze1RowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class generalanalyzeDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalanalyzeRowChanged As generalanalyzeRowChangeEventHandler
            Public Event generalanalyzeRowChanging As generalanalyzeRowChangeEventHandler
            Public Event generalanalyzeRowDeleted As generalanalyzeRowChangeEventHandler
            Public Event generalanalyzeRowDeleting As generalanalyzeRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalanalyzeDataTable.__ENCList
                SyncLock list
                    generalanalyzeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalanalyze"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalanalyzeDataTable.__ENCList
                SyncLock list
                    generalanalyzeDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = generalanalyzeDataTable.__ENCList
                SyncLock list
                    generalanalyzeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddgeneralanalyzeRow(ByVal row As generalanalyzeRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddgeneralanalyzeRow(ByVal AnalyzeID As Integer, ByVal UserID As Integer, ByVal MenuID As Integer, ByVal Name As String, ByVal Description As String, ByVal ColGrandTotal As Boolean, ByVal ColTotal As Boolean, ByVal GrandTotalSingle As Boolean, ByVal RowGrandTotal As Boolean, ByVal RowTotal As Boolean, ByVal TotalSingle As Boolean) As generalanalyzeRow
                Dim row As generalanalyzeRow = DirectCast(Me.NewRow, generalanalyzeRow)
                row.ItemArray = New Object() { AnalyzeID, UserID, MenuID, Name, Description, ColGrandTotal, ColTotal, GrandTotalSingle, RowGrandTotal, RowTotal, TotalSingle }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalanalyzeDataTable = DirectCast(MyBase.Clone, generalanalyzeDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalanalyzeDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByAnalyzeID(ByVal AnalyzeID As Integer) As generalanalyzeRow
                Return DirectCast(Me.Rows.Find(New Object() { AnalyzeID }), generalanalyzeRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalanalyzeRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim analyze As New dsAnalyze
                xs.Add(analyze.GetSchemaSerializable)
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
                attribute.FixedValue = analyze.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalanalyzeDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnAnalyzeID = New DataColumn("AnalyzeID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAnalyzeID)
                Me.columnUserID = New DataColumn("UserID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnUserID)
                Me.columnMenuID = New DataColumn("MenuID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuID)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnColGrandTotal = New DataColumn("ColGrandTotal", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnColGrandTotal)
                Me.columnColTotal = New DataColumn("ColTotal", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnColTotal)
                Me.columnGrandTotalSingle = New DataColumn("GrandTotalSingle", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnGrandTotalSingle)
                Me.columnRowGrandTotal = New DataColumn("RowGrandTotal", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnRowGrandTotal)
                Me.columnRowTotal = New DataColumn("RowTotal", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnRowTotal)
                Me.columnTotalSingle = New DataColumn("TotalSingle", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnTotalSingle)
                Me.Constraints.Add(New UniqueConstraint("dsAnalyzeKey1", New DataColumn() { Me.columnAnalyzeID }, True))
                Me.columnAnalyzeID.AllowDBNull = False
                Me.columnAnalyzeID.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnAnalyzeID = MyBase.Columns.Item("AnalyzeID")
                Me.columnUserID = MyBase.Columns.Item("UserID")
                Me.columnMenuID = MyBase.Columns.Item("MenuID")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnColGrandTotal = MyBase.Columns.Item("ColGrandTotal")
                Me.columnColTotal = MyBase.Columns.Item("ColTotal")
                Me.columnGrandTotalSingle = MyBase.Columns.Item("GrandTotalSingle")
                Me.columnRowGrandTotal = MyBase.Columns.Item("RowGrandTotal")
                Me.columnRowTotal = MyBase.Columns.Item("RowTotal")
                Me.columnTotalSingle = MyBase.Columns.Item("TotalSingle")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewgeneralanalyzeRow() As generalanalyzeRow
                Return DirectCast(Me.NewRow, generalanalyzeRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalanalyzeRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalanalyzeRowChangedEvent Is Nothing) Then
                    Dim generalanalyzeRowChangedEvent As generalanalyzeRowChangeEventHandler = Me.generalanalyzeRowChangedEvent
                    If (Not generalanalyzeRowChangedEvent Is Nothing) Then
                        generalanalyzeRowChangedEvent.Invoke(Me, New generalanalyzeRowChangeEvent(DirectCast(e.Row, generalanalyzeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalanalyzeRowChangingEvent Is Nothing) Then
                    Dim generalanalyzeRowChangingEvent As generalanalyzeRowChangeEventHandler = Me.generalanalyzeRowChangingEvent
                    If (Not generalanalyzeRowChangingEvent Is Nothing) Then
                        generalanalyzeRowChangingEvent.Invoke(Me, New generalanalyzeRowChangeEvent(DirectCast(e.Row, generalanalyzeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalanalyzeRowDeletedEvent Is Nothing) Then
                    Dim generalanalyzeRowDeletedEvent As generalanalyzeRowChangeEventHandler = Me.generalanalyzeRowDeletedEvent
                    If (Not generalanalyzeRowDeletedEvent Is Nothing) Then
                        generalanalyzeRowDeletedEvent.Invoke(Me, New generalanalyzeRowChangeEvent(DirectCast(e.Row, generalanalyzeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalanalyzeRowDeletingEvent Is Nothing) Then
                    Dim generalanalyzeRowDeletingEvent As generalanalyzeRowChangeEventHandler = Me.generalanalyzeRowDeletingEvent
                    If (Not generalanalyzeRowDeletingEvent Is Nothing) Then
                        generalanalyzeRowDeletingEvent.Invoke(Me, New generalanalyzeRowChangeEvent(DirectCast(e.Row, generalanalyzeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovegeneralanalyzeRow(ByVal row As generalanalyzeRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property AnalyzeIDColumn As DataColumn
                Get
                    Return Me.columnAnalyzeID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ColGrandTotalColumn As DataColumn
                Get
                    Return Me.columnColGrandTotal
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ColTotalColumn As DataColumn
                Get
                    Return Me.columnColTotal
                End Get
            End Property

            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property GrandTotalSingleColumn As DataColumn
                Get
                    Return Me.columnGrandTotalSingle
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalanalyzeRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generalanalyzeRow)
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
            Public ReadOnly Property RowGrandTotalColumn As DataColumn
                Get
                    Return Me.columnRowGrandTotal
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property RowTotalColumn As DataColumn
                Get
                    Return Me.columnRowTotal
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property TotalSingleColumn As DataColumn
                Get
                    Return Me.columnTotalSingle
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
            Private columnAnalyzeID As DataColumn
            Private columnColGrandTotal As DataColumn
            Private columnColTotal As DataColumn
            Private columnDescription As DataColumn
            Private columnGrandTotalSingle As DataColumn
            Private columnMenuID As DataColumn
            Private columnName As DataColumn
            Private columnRowGrandTotal As DataColumn
            Private columnRowTotal As DataColumn
            Private columnTotalSingle As DataColumn
            Private columnUserID As DataColumn
        End Class

        <Serializable, DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalanalyzefieldDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalanalyzefieldRowChanged As generalanalyzefieldRowChangeEventHandler
            Public Event generalanalyzefieldRowChanging As generalanalyzefieldRowChangeEventHandler
            Public Event generalanalyzefieldRowDeleted As generalanalyzefieldRowChangeEventHandler
            Public Event generalanalyzefieldRowDeleting As generalanalyzefieldRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalanalyzefieldDataTable.__ENCList
                SyncLock list
                    generalanalyzefieldDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalanalyzefield"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalanalyzefieldDataTable.__ENCList
                SyncLock list
                    generalanalyzefieldDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = generalanalyzefieldDataTable.__ENCList
                SyncLock list
                    generalanalyzefieldDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddgeneralanalyzefieldRow(ByVal row As generalanalyzefieldRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddgeneralanalyzefieldRow(ByVal AnalyzeID As Integer, ByVal FieldName As String, ByVal Area As Integer, ByVal TopValueCount As Integer, ByVal TopValueShowOthers As Boolean, ByVal FieldCaption As String, ByVal BestFit As Boolean, ByVal SortBySummaryField As String, ByVal FieldVisible As Boolean, ByVal SummaryType As Integer, ByVal SortOrder As Integer) As generalanalyzefieldRow
                Dim row As generalanalyzefieldRow = DirectCast(Me.NewRow, generalanalyzefieldRow)
                row.ItemArray = New Object() { AnalyzeID, FieldName, Area, TopValueCount, TopValueShowOthers, FieldCaption, BestFit, SortBySummaryField, FieldVisible, SummaryType, SortOrder }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalanalyzefieldDataTable = DirectCast(MyBase.Clone, generalanalyzefieldDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalanalyzefieldDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByAnalyzeIDFieldName(ByVal AnalyzeID As Integer, ByVal FieldName As String) As generalanalyzefieldRow
                Return DirectCast(Me.Rows.Find(New Object() { AnalyzeID, FieldName }), generalanalyzefieldRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalanalyzefieldRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim analyze As New dsAnalyze
                xs.Add(analyze.GetSchemaSerializable)
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
                attribute.FixedValue = analyze.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalanalyzefieldDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnAnalyzeID = New DataColumn("AnalyzeID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAnalyzeID)
                Me.columnFieldName = New DataColumn("FieldName", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFieldName)
                Me.columnArea = New DataColumn("Area", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnArea)
                Me.columnTopValueCount = New DataColumn("TopValueCount", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnTopValueCount)
                Me.columnTopValueShowOthers = New DataColumn("TopValueShowOthers", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnTopValueShowOthers)
                Me.columnFieldCaption = New DataColumn("FieldCaption", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFieldCaption)
                Me.columnBestFit = New DataColumn("BestFit", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBestFit)
                Me.columnSortBySummaryField = New DataColumn("SortBySummaryField", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSortBySummaryField)
                Me.columnFieldVisible = New DataColumn("FieldVisible", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFieldVisible)
                Me.columnSummaryType = New DataColumn("SummaryType", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSummaryType)
                Me.columnSortOrder = New DataColumn("SortOrder", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSortOrder)
                Me.Constraints.Add(New UniqueConstraint("dsAnalyzeKey2", New DataColumn() { Me.columnAnalyzeID, Me.columnFieldName }, True))
                Me.columnAnalyzeID.AllowDBNull = False
                Me.columnFieldName.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnAnalyzeID = MyBase.Columns.Item("AnalyzeID")
                Me.columnFieldName = MyBase.Columns.Item("FieldName")
                Me.columnArea = MyBase.Columns.Item("Area")
                Me.columnTopValueCount = MyBase.Columns.Item("TopValueCount")
                Me.columnTopValueShowOthers = MyBase.Columns.Item("TopValueShowOthers")
                Me.columnFieldCaption = MyBase.Columns.Item("FieldCaption")
                Me.columnBestFit = MyBase.Columns.Item("BestFit")
                Me.columnSortBySummaryField = MyBase.Columns.Item("SortBySummaryField")
                Me.columnFieldVisible = MyBase.Columns.Item("FieldVisible")
                Me.columnSummaryType = MyBase.Columns.Item("SummaryType")
                Me.columnSortOrder = MyBase.Columns.Item("SortOrder")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewgeneralanalyzefieldRow() As generalanalyzefieldRow
                Return DirectCast(Me.NewRow, generalanalyzefieldRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalanalyzefieldRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalanalyzefieldRowChangedEvent Is Nothing) Then
                    Dim generalanalyzefieldRowChangedEvent As generalanalyzefieldRowChangeEventHandler = Me.generalanalyzefieldRowChangedEvent
                    If (Not generalanalyzefieldRowChangedEvent Is Nothing) Then
                        generalanalyzefieldRowChangedEvent.Invoke(Me, New generalanalyzefieldRowChangeEvent(DirectCast(e.Row, generalanalyzefieldRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalanalyzefieldRowChangingEvent Is Nothing) Then
                    Dim generalanalyzefieldRowChangingEvent As generalanalyzefieldRowChangeEventHandler = Me.generalanalyzefieldRowChangingEvent
                    If (Not generalanalyzefieldRowChangingEvent Is Nothing) Then
                        generalanalyzefieldRowChangingEvent.Invoke(Me, New generalanalyzefieldRowChangeEvent(DirectCast(e.Row, generalanalyzefieldRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalanalyzefieldRowDeletedEvent Is Nothing) Then
                    Dim generalanalyzefieldRowDeletedEvent As generalanalyzefieldRowChangeEventHandler = Me.generalanalyzefieldRowDeletedEvent
                    If (Not generalanalyzefieldRowDeletedEvent Is Nothing) Then
                        generalanalyzefieldRowDeletedEvent.Invoke(Me, New generalanalyzefieldRowChangeEvent(DirectCast(e.Row, generalanalyzefieldRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalanalyzefieldRowDeletingEvent Is Nothing) Then
                    Dim generalanalyzefieldRowDeletingEvent As generalanalyzefieldRowChangeEventHandler = Me.generalanalyzefieldRowDeletingEvent
                    If (Not generalanalyzefieldRowDeletingEvent Is Nothing) Then
                        generalanalyzefieldRowDeletingEvent.Invoke(Me, New generalanalyzefieldRowChangeEvent(DirectCast(e.Row, generalanalyzefieldRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovegeneralanalyzefieldRow(ByVal row As generalanalyzefieldRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property AnalyzeIDColumn As DataColumn
                Get
                    Return Me.columnAnalyzeID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property AreaColumn As DataColumn
                Get
                    Return Me.columnArea
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BestFitColumn As DataColumn
                Get
                    Return Me.columnBestFit
                End Get
            End Property

            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FieldCaptionColumn As DataColumn
                Get
                    Return Me.columnFieldCaption
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FieldNameColumn As DataColumn
                Get
                    Return Me.columnFieldName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FieldVisibleColumn As DataColumn
                Get
                    Return Me.columnFieldVisible
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalanalyzefieldRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generalanalyzefieldRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property SortBySummaryFieldColumn As DataColumn
                Get
                    Return Me.columnSortBySummaryField
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property SortOrderColumn As DataColumn
                Get
                    Return Me.columnSortOrder
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property SummaryTypeColumn As DataColumn
                Get
                    Return Me.columnSummaryType
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property TopValueCountColumn As DataColumn
                Get
                    Return Me.columnTopValueCount
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property TopValueShowOthersColumn As DataColumn
                Get
                    Return Me.columnTopValueShowOthers
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnAnalyzeID As DataColumn
            Private columnArea As DataColumn
            Private columnBestFit As DataColumn
            Private columnFieldCaption As DataColumn
            Private columnFieldName As DataColumn
            Private columnFieldVisible As DataColumn
            Private columnSortBySummaryField As DataColumn
            Private columnSortOrder As DataColumn
            Private columnSummaryType As DataColumn
            Private columnTopValueCount As DataColumn
            Private columnTopValueShowOthers As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalanalyzefieldRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralanalyzefield = DirectCast(Me.Table, generalanalyzefieldDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsAreaNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyzefield.AreaColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBestFitNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyzefield.BestFitColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsFieldCaptionNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyzefield.FieldCaptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsFieldVisibleNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyzefield.FieldVisibleColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsSortBySummaryFieldNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyzefield.SortBySummaryFieldColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsSortOrderNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyzefield.SortOrderColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsSummaryTypeNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyzefield.SummaryTypeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsTopValueCountNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyzefield.TopValueCountColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsTopValueShowOthersNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyzefield.TopValueShowOthersColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetAreaNull()
                Me.Item(Me.tablegeneralanalyzefield.AreaColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBestFitNull()
                Me.Item(Me.tablegeneralanalyzefield.BestFitColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetFieldCaptionNull()
                Me.Item(Me.tablegeneralanalyzefield.FieldCaptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetFieldVisibleNull()
                Me.Item(Me.tablegeneralanalyzefield.FieldVisibleColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetSortBySummaryFieldNull()
                Me.Item(Me.tablegeneralanalyzefield.SortBySummaryFieldColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetSortOrderNull()
                Me.Item(Me.tablegeneralanalyzefield.SortOrderColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetSummaryTypeNull()
                Me.Item(Me.tablegeneralanalyzefield.SummaryTypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetTopValueCountNull()
                Me.Item(Me.tablegeneralanalyzefield.TopValueCountColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetTopValueShowOthersNull()
                Me.Item(Me.tablegeneralanalyzefield.TopValueShowOthersColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property AnalyzeID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralanalyzefield.AnalyzeIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralanalyzefield.AnalyzeIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Area As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralanalyzefield.AreaColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Area' in table 'generalanalyzefield' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralanalyzefield.AreaColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BestFit As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralanalyzefield.BestFitColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BestFit' in table 'generalanalyzefield' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralanalyzefield.BestFitColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property FieldCaption As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralanalyzefield.FieldCaptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'FieldCaption' in table 'generalanalyzefield' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralanalyzefield.FieldCaptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property FieldName As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralanalyzefield.FieldNameColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralanalyzefield.FieldNameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property FieldVisible As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralanalyzefield.FieldVisibleColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'FieldVisible' in table 'generalanalyzefield' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralanalyzefield.FieldVisibleColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property SortBySummaryField As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralanalyzefield.SortBySummaryFieldColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'SortBySummaryField' in table 'generalanalyzefield' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralanalyzefield.SortBySummaryFieldColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property SortOrder As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralanalyzefield.SortOrderColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'SortOrder' in table 'generalanalyzefield' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralanalyzefield.SortOrderColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property SummaryType As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralanalyzefield.SummaryTypeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'SummaryType' in table 'generalanalyzefield' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralanalyzefield.SummaryTypeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property TopValueCount As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralanalyzefield.TopValueCountColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'TopValueCount' in table 'generalanalyzefield' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralanalyzefield.TopValueCountColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property TopValueShowOthers As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralanalyzefield.TopValueShowOthersColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'TopValueShowOthers' in table 'generalanalyzefield' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralanalyzefield.TopValueShowOthersColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralanalyzefield As generalanalyzefieldDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalanalyzefieldRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalanalyzefieldRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As generalanalyzefieldRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalanalyzefieldRow
        End Class

        Public Delegate Sub generalanalyzefieldRowChangeEventHandler(ByVal sender As Object, ByVal e As generalanalyzefieldRowChangeEvent)

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalanalyzeRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralanalyze = DirectCast(Me.Table, generalanalyzeDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsColGrandTotalNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze.ColGrandTotalColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsColTotalNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze.ColTotalColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsGrandTotalSingleNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze.GrandTotalSingleColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuIDNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze.MenuIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze.NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsRowGrandTotalNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze.RowGrandTotalColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsRowTotalNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze.RowTotalColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsTotalSingleNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze.TotalSingleColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsUserIDNull() As Boolean
                Return Me.IsNull(Me.tablegeneralanalyze.UserIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetColGrandTotalNull()
                Me.Item(Me.tablegeneralanalyze.ColGrandTotalColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetColTotalNull()
                Me.Item(Me.tablegeneralanalyze.ColTotalColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tablegeneralanalyze.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetGrandTotalSingleNull()
                Me.Item(Me.tablegeneralanalyze.GrandTotalSingleColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuIDNull()
                Me.Item(Me.tablegeneralanalyze.MenuIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNameNull()
                Me.Item(Me.tablegeneralanalyze.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetRowGrandTotalNull()
                Me.Item(Me.tablegeneralanalyze.RowGrandTotalColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetRowTotalNull()
                Me.Item(Me.tablegeneralanalyze.RowTotalColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetTotalSingleNull()
                Me.Item(Me.tablegeneralanalyze.TotalSingleColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetUserIDNull()
                Me.Item(Me.tablegeneralanalyze.UserIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property AnalyzeID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralanalyze.AnalyzeIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralanalyze.AnalyzeIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ColGrandTotal As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralanalyze.ColGrandTotalColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ColGrandTotal' in table 'generalanalyze' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralanalyze.ColGrandTotalColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ColTotal As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralanalyze.ColTotalColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ColTotal' in table 'generalanalyze' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralanalyze.ColTotalColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralanalyze.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'generalanalyze' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralanalyze.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property GrandTotalSingle As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralanalyze.GrandTotalSingleColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'GrandTotalSingle' in table 'generalanalyze' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralanalyze.GrandTotalSingleColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralanalyze.MenuIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuID' in table 'generalanalyze' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralanalyze.MenuIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralanalyze.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'generalanalyze' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralanalyze.NameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property RowGrandTotal As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralanalyze.RowGrandTotalColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'RowGrandTotal' in table 'generalanalyze' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralanalyze.RowGrandTotalColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property RowTotal As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralanalyze.RowTotalColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'RowTotal' in table 'generalanalyze' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralanalyze.RowTotalColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property TotalSingle As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneralanalyze.TotalSingleColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'TotalSingle' in table 'generalanalyze' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneralanalyze.TotalSingleColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property UserID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralanalyze.UserIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'UserID' in table 'generalanalyze' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralanalyze.UserIDColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralanalyze As generalanalyzeDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalanalyzeRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalanalyzeRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As generalanalyzeRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalanalyzeRow
        End Class

        Public Delegate Sub generalanalyzeRowChangeEventHandler(ByVal sender As Object, ByVal e As generalanalyzeRowChangeEvent)
    End Class
End Namespace

