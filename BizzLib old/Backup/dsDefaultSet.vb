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
    <Serializable, XmlSchemaProvider("GetTypedDataSetSchema"), ToolboxItem(True), DesignerCategory("code"), XmlRoot("dsDefaultSet"), HelpKeyword("vs.data.DataSet"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
    Public Class dsDefaultSet
        Inherits DataSet
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Dim list As ArrayList = dsDefaultSet.__ENCList
            SyncLock list
                dsDefaultSet.__ENCList.Add(New WeakReference(Me))
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
            Dim list As ArrayList = dsDefaultSet.__ENCList
            SyncLock list
                dsDefaultSet.__ENCList.Add(New WeakReference(Me))
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
                    If (Not dataSet.Tables.Item("generalreport") Is Nothing) Then
                        MyBase.Tables.Add(New generalreportDataTable(dataSet.Tables.Item("generalreport")))
                    End If
                    If (Not dataSet.Tables.Item("generaldefaultset") Is Nothing) Then
                        MyBase.Tables.Add(New generaldefaultsetDataTable(dataSet.Tables.Item("generaldefaultset")))
                    End If
                    If (Not dataSet.Tables.Item("generaldefaultsetsub") Is Nothing) Then
                        MyBase.Tables.Add(New generaldefaultsetsubDataTable(dataSet.Tables.Item("generaldefaultsetsub")))
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
            Dim set As dsDefaultSet = DirectCast(MyBase.Clone, dsDefaultSet)
            ClsDs.InitVars()
            ClsDs.SchemaSerializationMode = Me.SchemaSerializationMode
            Return ClsDs
        End Function

        <DebuggerNonUserCode()> _
        Protected Overrides Function GetSchemaSerializable() As XmlSchema
            Dim w As New MemoryStream
            Me.WriteXmlSchema(New XmlTextWriter(w, Nothing))
            w.Position = 0
            Return XmlSchema.Read(New XmlTextReader(w), Nothing)
        End Function

        <DebuggerNonUserCode()> _
        Public Shared Function GetTypedDataSetSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
            Dim set As New dsDefaultSet
            Dim type2 As New XmlSchemaComplexType
            Dim sequence As New XmlSchemaSequence
            xs.Add(ClsDs.GetSchemaSerializable)
            Dim item As New XmlSchemaAny
            item.Namespace = ClsDs.Namespace
            sequence.Items.Add(item)
            type2.Particle = sequence
            Return type2
        End Function

        <DebuggerNonUserCode()> _
        Private Sub InitClass()
            Me.DataSetName = "dsDefaultSet"
            Me.Prefix = ""
            Me.Namespace = "http://tempuri.org/dsDefaultSet.xsd"
            Me.EnforceConstraints = True
            Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
            Me.tablegeneralreport = New generalreportDataTable
            MyBase.Tables.Add(Me.tablegeneralreport)
            Me.tablegeneraldefaultset = New generaldefaultsetDataTable
            MyBase.Tables.Add(Me.tablegeneraldefaultset)
            Me.tablegeneraldefaultsetsub = New generaldefaultsetsubDataTable
            MyBase.Tables.Add(Me.tablegeneraldefaultsetsub)
        End Sub

        <DebuggerNonUserCode()> _
        Protected Overrides Sub InitializeDerivedDataSet()
            Me.BeginInit()
            Me.InitClass()
            Me.EndInit()
        End Sub

        <DebuggerNonUserCode()> _
        Friend Sub InitVars()
            Me.InitVars(True)
        End Sub

        <DebuggerNonUserCode()> _
        Friend Sub InitVars(ByVal initTable As Boolean)
            Me.tablegeneralreport = DirectCast(MyBase.Tables.Item("generalreport"), generalreportDataTable)
            If (initTable AndAlso (Not Me.tablegeneralreport Is Nothing)) Then
                Me.tablegeneralreport.InitVars()
            End If
            Me.tablegeneraldefaultset = DirectCast(MyBase.Tables.Item("generaldefaultset"), generaldefaultsetDataTable)
            If (initTable AndAlso (Not Me.tablegeneraldefaultset Is Nothing)) Then
                Me.tablegeneraldefaultset.InitVars()
            End If
            Me.tablegeneraldefaultsetsub = DirectCast(MyBase.Tables.Item("generaldefaultsetsub"), generaldefaultsetsubDataTable)
            If (initTable AndAlso (Not Me.tablegeneraldefaultsetsub Is Nothing)) Then
                Me.tablegeneraldefaultsetsub.InitVars()
            End If
        End Sub

        <DebuggerNonUserCode()> _
        Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
            If (Me.DetermineSchemaSerializationMode(reader) = SchemaSerializationMode.IncludeSchema) Then
                Me.Reset()
                Dim dataSet As New DataSet
                dataSet.ReadXml(reader)
                If (Not dataSet.Tables.Item("generalreport") Is Nothing) Then
                    MyBase.Tables.Add(New generalreportDataTable(dataSet.Tables.Item("generalreport")))
                End If
                If (Not dataSet.Tables.Item("generaldefaultset") Is Nothing) Then
                    MyBase.Tables.Add(New generaldefaultsetDataTable(dataSet.Tables.Item("generaldefaultset")))
                End If
                If (Not dataSet.Tables.Item("generaldefaultsetsub") Is Nothing) Then
                    MyBase.Tables.Add(New generaldefaultsetsubDataTable(dataSet.Tables.Item("generaldefaultsetsub")))
                End If
                Me.DataSetName = dataSet.DataSetName
                Me.Prefix = dataSet.Prefix
                Me.Namespace = dataSet.Namespace
                Me.Locale = dataSet.Locale
                Me.CaseSensitive = dataSet.CaseSensitive
                Me.EnforceConstraints = dataSet.EnforceConstraints
                Me.Merge(dataSet, False, MissingSchemaAction.Add)
                Me.InitVars()
            Else
                Me.ReadXml(reader)
                Me.InitVars()
            End If
        End Sub

        <DebuggerNonUserCode()> _
        Private Sub SchemaChanged(ByVal sender As Object, ByVal e As CollectionChangeEventArgs)
            If (e.Action = CollectionChangeAction.Remove) Then
                Me.InitVars()
            End If
        End Sub

        <DebuggerNonUserCode()> _
        Private Function ShouldSerializegeneraldefaultset() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode()> _
        Private Function ShouldSerializegeneraldefaultsetsub() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode()> _
        Private Function ShouldSerializegeneralreport() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode()> _
        Protected Overrides Function ShouldSerializeRelations() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode()> _
        Protected Overrides Function ShouldSerializeTables() As Boolean
            Return False
        End Function


        ' Properties
        <DebuggerNonUserCode(), Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property generaldefaultset() As generaldefaultsetDataTable
            Get
                Return Me.tablegeneraldefaultset
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False), DebuggerNonUserCode()> _
        Public ReadOnly Property generaldefaultsetsub() As generaldefaultsetsubDataTable
            Get
                Return Me.tablegeneraldefaultsetsub
            End Get
        End Property

        <Browsable(False), DebuggerNonUserCode(), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property generalreport() As generalreportDataTable
            Get
                Return Me.tablegeneralreport
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode()> _
        Public ReadOnly Property Relations() As DataRelationCollection
            Get
                Return MyBase.Relations
            End Get
        End Property

        <DebuggerNonUserCode(), Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
        Public Overrides Property SchemaSerializationMode() As SchemaSerializationMode
            Get
                Return Me._schemaSerializationMode
            End Get
            Set(ByVal Value As SchemaSerializationMode)
                Me._schemaSerializationMode = Value
            End Set
        End Property

        <DebuggerNonUserCode(), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
        Public ReadOnly Property Tables() As DataTableCollection
            Get
                Return MyBase.Tables
            End Get
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        Private _schemaSerializationMode As SchemaSerializationMode
        Private tablegeneraldefaultset As generaldefaultsetDataTable
        Private tablegeneraldefaultsetsub As generaldefaultsetsubDataTable
        Private tablegeneralreport As generalreportDataTable

        ' Nested Types
        <Serializable(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class generaldefaultsetDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generaldefaultsetRowChanged As generaldefaultsetRowChangeEventHandler
            Public Event generaldefaultsetRowChanging As generaldefaultsetRowChangeEventHandler
            Public Event generaldefaultsetRowDeleted As generaldefaultsetRowChangeEventHandler
            Public Event generaldefaultsetRowDeleting As generaldefaultsetRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode()> _
            Public Sub New()
                Dim list As ArrayList = generaldefaultsetDataTable.__ENCList
                SyncLock list
                    generaldefaultsetDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generaldefaultset"
                Me.BeginInit()
                Me.InitClass()
                Me.EndInit()
            End Sub

            <DebuggerNonUserCode()> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generaldefaultsetDataTable.__ENCList
                SyncLock list
                    generaldefaultsetDataTable.__ENCList.Add(New WeakReference(Me))
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

            <DebuggerNonUserCode()> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = generaldefaultsetDataTable.__ENCList
                SyncLock list
                    generaldefaultsetDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars()
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub AddgeneraldefaultsetRow(ByVal row As generaldefaultsetRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode()> _
            Public Function AddgeneraldefaultsetRow(ByVal DefaultSetID As Integer, ByVal UserID As Integer, ByVal MenuID As Integer, ByVal Name As String, ByVal Description As String, ByVal DefaultCriteria As Integer, ByVal SystemCriteria As Integer, ByVal TemplateCriteria As Integer) As generaldefaultsetRow
                Dim row As generaldefaultsetRow = DirectCast(Me.NewRow, generaldefaultsetRow)
                row.ItemArray = New Object() {DefaultSetID, UserID, MenuID, Name, Description, DefaultCriteria, SystemCriteria, TemplateCriteria}
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode()> _
            Public Overrides Function Clone() As DataTable
                Dim table As generaldefaultsetDataTable = DirectCast(MyBase.Clone, generaldefaultsetDataTable)
                table.InitVars()
                Return table
            End Function

            <DebuggerNonUserCode()> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generaldefaultsetDataTable
            End Function

            <DebuggerNonUserCode()> _
            Public Function FindByDefaultSetID(ByVal DefaultSetID As Integer) As generaldefaultsetRow
                Return DirectCast(Me.Rows.Find(New Object() {DefaultSetID}), generaldefaultsetRow)
            End Function

            <DebuggerNonUserCode()> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode()> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generaldefaultsetRow)
            End Function

            <DebuggerNonUserCode()> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim set As New dsDefaultSet
                xs.Add(ClsDs.GetSchemaSerializable)
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
                attribute.FixedValue = ClsDs.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generaldefaultsetDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode()> _
            Private Sub InitClass()
                Me.columnDefaultSetID = New DataColumn("DefaultSetID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDefaultSetID)
                Me.columnUserID = New DataColumn("UserID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnUserID)
                Me.columnMenuID = New DataColumn("MenuID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuID)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnDefaultCriteria = New DataColumn("DefaultCriteria", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDefaultCriteria)
                Me.columnSystemCriteria = New DataColumn("SystemCriteria", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSystemCriteria)
                Me.columnTemplateCriteria = New DataColumn("TemplateCriteria", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnTemplateCriteria)
                Me.Constraints.Add(New UniqueConstraint("dsDefaultSetKey1", New DataColumn() {Me.columnDefaultSetID}, True))
                Me.columnDefaultSetID.AllowDBNull = False
                Me.columnDefaultSetID.Unique = True
            End Sub

            <DebuggerNonUserCode()> _
            Friend Sub InitVars()
                Me.columnDefaultSetID = MyBase.Columns.Item("DefaultSetID")
                Me.columnUserID = MyBase.Columns.Item("UserID")
                Me.columnMenuID = MyBase.Columns.Item("MenuID")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnDefaultCriteria = MyBase.Columns.Item("DefaultCriteria")
                Me.columnSystemCriteria = MyBase.Columns.Item("SystemCriteria")
                Me.columnTemplateCriteria = MyBase.Columns.Item("TemplateCriteria")
            End Sub

            <DebuggerNonUserCode()> _
            Public Function NewgeneraldefaultsetRow() As generaldefaultsetRow
                Return DirectCast(Me.NewRow, generaldefaultsetRow)
            End Function

            <DebuggerNonUserCode()> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generaldefaultsetRow(builder)
            End Function

            <DebuggerNonUserCode()> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generaldefaultsetRowChangedEvent Is Nothing) Then
                    Dim generaldefaultsetRowChangedEvent As generaldefaultsetRowChangeEventHandler = Me.generaldefaultsetRowChangedEvent
                    If (Not generaldefaultsetRowChangedEvent Is Nothing) Then
                        generaldefaultsetRowChangedEvent.Invoke(Me, New generaldefaultsetRowChangeEvent(DirectCast(e.Row, generaldefaultsetRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode()> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generaldefaultsetRowChangingEvent Is Nothing) Then
                    Dim generaldefaultsetRowChangingEvent As generaldefaultsetRowChangeEventHandler = Me.generaldefaultsetRowChangingEvent
                    If (Not generaldefaultsetRowChangingEvent Is Nothing) Then
                        generaldefaultsetRowChangingEvent.Invoke(Me, New generaldefaultsetRowChangeEvent(DirectCast(e.Row, generaldefaultsetRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode()> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generaldefaultsetRowDeletedEvent Is Nothing) Then
                    Dim generaldefaultsetRowDeletedEvent As generaldefaultsetRowChangeEventHandler = Me.generaldefaultsetRowDeletedEvent
                    If (Not generaldefaultsetRowDeletedEvent Is Nothing) Then
                        generaldefaultsetRowDeletedEvent.Invoke(Me, New generaldefaultsetRowChangeEvent(DirectCast(e.Row, generaldefaultsetRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode()> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generaldefaultsetRowDeletingEvent Is Nothing) Then
                    Dim generaldefaultsetRowDeletingEvent As generaldefaultsetRowChangeEventHandler = Me.generaldefaultsetRowDeletingEvent
                    If (Not generaldefaultsetRowDeletingEvent Is Nothing) Then
                        generaldefaultsetRowDeletingEvent.Invoke(Me, New generaldefaultsetRowChangeEvent(DirectCast(e.Row, generaldefaultsetRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub RemovegeneraldefaultsetRow(ByVal row As generaldefaultsetRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <Browsable(False), DebuggerNonUserCode()> _
            Public ReadOnly Property Count() As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property DefaultCriteriaColumn() As DataColumn
                Get
                    Return Me.columnDefaultCriteria
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property DefaultSetIDColumn() As DataColumn
                Get
                    Return Me.columnDefaultSetID
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property DescriptionColumn() As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Default Public ReadOnly Property Item(ByVal index As Integer) As generaldefaultsetRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generaldefaultsetRow)
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property MenuIDColumn() As DataColumn
                Get
                    Return Me.columnMenuID
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property NameColumn() As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property SystemCriteriaColumn() As DataColumn
                Get
                    Return Me.columnSystemCriteria
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property TemplateCriteriaColumn() As DataColumn
                Get
                    Return Me.columnTemplateCriteria
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property UserIDColumn() As DataColumn
                Get
                    Return Me.columnUserID
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnDefaultCriteria As DataColumn
            Private columnDefaultSetID As DataColumn
            Private columnDescription As DataColumn
            Private columnMenuID As DataColumn
            Private columnName As DataColumn
            Private columnSystemCriteria As DataColumn
            Private columnTemplateCriteria As DataColumn
            Private columnUserID As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generaldefaultsetRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode()> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneraldefaultset = DirectCast(Me.Table, generaldefaultsetDataTable)
            End Sub

            <DebuggerNonUserCode()> _
            Public Function IsDefaultCriteriaNull() As Boolean
                Return Me.IsNull(Me.tablegeneraldefaultset.DefaultCriteriaColumn)
            End Function

            <DebuggerNonUserCode()> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tablegeneraldefaultset.DescriptionColumn)
            End Function

            <DebuggerNonUserCode()> _
            Public Function IsMenuIDNull() As Boolean
                Return Me.IsNull(Me.tablegeneraldefaultset.MenuIDColumn)
            End Function

            <DebuggerNonUserCode()> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tablegeneraldefaultset.NameColumn)
            End Function

            <DebuggerNonUserCode()> _
            Public Function IsSystemCriteriaNull() As Boolean
                Return Me.IsNull(Me.tablegeneraldefaultset.SystemCriteriaColumn)
            End Function

            <DebuggerNonUserCode()> _
            Public Function IsTemplateCriteriaNull() As Boolean
                Return Me.IsNull(Me.tablegeneraldefaultset.TemplateCriteriaColumn)
            End Function

            <DebuggerNonUserCode()> _
            Public Function IsUserIDNull() As Boolean
                Return Me.IsNull(Me.tablegeneraldefaultset.UserIDColumn)
            End Function

            <DebuggerNonUserCode()> _
            Public Sub SetDefaultCriteriaNull()
                Me.Item(Me.tablegeneraldefaultset.DefaultCriteriaColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tablegeneraldefaultset.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub SetMenuIDNull()
                Me.Item(Me.tablegeneraldefaultset.MenuIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub SetNameNull()
                Me.Item(Me.tablegeneraldefaultset.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub SetSystemCriteriaNull()
                Me.Item(Me.tablegeneraldefaultset.SystemCriteriaColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub SetTemplateCriteriaNull()
                Me.Item(Me.tablegeneraldefaultset.TemplateCriteriaColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub SetUserIDNull()
                Me.Item(Me.tablegeneraldefaultset.UserIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode()> _
            Public Property DefaultCriteria() As Integer
                Get
                    Dim num As Integer
                    Try
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneraldefaultset.DefaultCriteriaColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'DefaultCriteria' in table 'generaldefaultset' is DBNull.", innerException)
                        ProjectData.ClearProjectError()
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneraldefaultset.DefaultCriteriaColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode()> _
            Public Property DefaultSetID() As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneraldefaultset.DefaultSetIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneraldefaultset.DefaultSetIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode()> _
            Public Property Description() As String
                Get
                    Dim str As String
                    Try
                        str = Conversions.ToString(Me.Item(Me.tablegeneraldefaultset.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'generaldefaultset' is DBNull.", innerException)
                        ProjectData.ClearProjectError()
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneraldefaultset.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode()> _
            Public Property MenuID() As Integer
                Get
                    Dim num As Integer
                    Try
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneraldefaultset.MenuIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuID' in table 'generaldefaultset' is DBNull.", innerException)
                        ProjectData.ClearProjectError()
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneraldefaultset.MenuIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode()> _
            Public Property Name() As String
                Get
                    Dim str As String
                    Try
                        str = Conversions.ToString(Me.Item(Me.tablegeneraldefaultset.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'generaldefaultset' is DBNull.", innerException)
                        ProjectData.ClearProjectError()
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneraldefaultset.NameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode()> _
            Public Property SystemCriteria() As Integer
                Get
                    Dim num As Integer
                    Try
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneraldefaultset.SystemCriteriaColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'SystemCriteria' in table 'generaldefaultset' is DBNull.", innerException)
                        ProjectData.ClearProjectError()
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneraldefaultset.SystemCriteriaColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode()> _
            Public Property TemplateCriteria() As Integer
                Get
                    Dim num As Integer
                    Try
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneraldefaultset.TemplateCriteriaColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'TemplateCriteria' in table 'generaldefaultset' is DBNull.", innerException)
                        ProjectData.ClearProjectError()
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneraldefaultset.TemplateCriteriaColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode()> _
            Public Property UserID() As Integer
                Get
                    Dim num As Integer
                    Try
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneraldefaultset.UserIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'UserID' in table 'generaldefaultset' is DBNull.", innerException)
                        ProjectData.ClearProjectError()
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneraldefaultset.UserIDColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneraldefaultset As generaldefaultsetDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generaldefaultsetRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode()> _
            Public Sub New(ByVal row As generaldefaultsetRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode()> _
            Public ReadOnly Property Action() As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property Row() As generaldefaultsetRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generaldefaultsetRow
        End Class

        Public Delegate Sub generaldefaultsetRowChangeEventHandler(ByVal sender As Object, ByVal e As generaldefaultsetRowChangeEvent)

        <Serializable(), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generaldefaultsetsubDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generaldefaultsetsubRowChanged As generaldefaultsetsubRowChangeEventHandler
            Public Event generaldefaultsetsubRowChanging As generaldefaultsetsubRowChangeEventHandler
            Public Event generaldefaultsetsubRowDeleted As generaldefaultsetsubRowChangeEventHandler
            Public Event generaldefaultsetsubRowDeleting As generaldefaultsetsubRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode()> _
            Public Sub New()
                Dim list As ArrayList = generaldefaultsetsubDataTable.__ENCList
                SyncLock list
                    generaldefaultsetsubDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generaldefaultsetsub"
                Me.BeginInit()
                Me.InitClass()
                Me.EndInit()
            End Sub

            <DebuggerNonUserCode()> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generaldefaultsetsubDataTable.__ENCList
                SyncLock list
                    generaldefaultsetsubDataTable.__ENCList.Add(New WeakReference(Me))
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

            <DebuggerNonUserCode()> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = generaldefaultsetsubDataTable.__ENCList
                SyncLock list
                    generaldefaultsetsubDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars()
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub AddgeneraldefaultsetsubRow(ByVal row As generaldefaultsetsubRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode()> _
            Public Function AddgeneraldefaultsetsubRow(ByVal DefaultSetID As Integer, ByVal ControlName As String, ByVal ControlType As String, ByVal ControlProperty As String, ByVal ValueType As String, ByVal DateValue As DateTime, ByVal BoolValue As Boolean, ByVal IntValue As Integer, ByVal DblValue As Double, ByVal StringValue As String) As generaldefaultsetsubRow
                Dim row As generaldefaultsetsubRow = DirectCast(Me.NewRow, generaldefaultsetsubRow)
                row.ItemArray = New Object() {DefaultSetID, ControlName, ControlType, ControlProperty, ValueType, DateValue, BoolValue, IntValue, DblValue, StringValue}
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode()> _
            Public Overrides Function Clone() As DataTable
                Dim table As generaldefaultsetsubDataTable = DirectCast(MyBase.Clone, generaldefaultsetsubDataTable)
                table.InitVars()
                Return table
            End Function

            <DebuggerNonUserCode()> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generaldefaultsetsubDataTable
            End Function

            <DebuggerNonUserCode()> _
            Public Function FindByDefaultSetIDControlName(ByVal DefaultSetID As Integer, ByVal ControlName As String) As generaldefaultsetsubRow
                Return DirectCast(Me.Rows.Find(New Object() {DefaultSetID, ControlName}), generaldefaultsetsubRow)
            End Function

            <DebuggerNonUserCode()> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode()> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generaldefaultsetsubRow)
            End Function

            <DebuggerNonUserCode()> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim set As New dsDefaultSet
                xs.Add(ClsDs.GetSchemaSerializable)
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
                attribute.FixedValue = ClsDs.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generaldefaultsetsubDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode()> _
            Private Sub InitClass()
                Me.columnDefaultSetID = New DataColumn("DefaultSetID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDefaultSetID)
                Me.columnControlName = New DataColumn("ControlName", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnControlName)
                Me.columnControlType = New DataColumn("ControlType", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnControlType)
                Me.columnControlProperty = New DataColumn("ControlProperty", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnControlProperty)
                Me.columnValueType = New DataColumn("ValueType", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnValueType)
                Me.columnDateValue = New DataColumn("DateValue", GetType(DateTime), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDateValue)
                Me.columnBoolValue = New DataColumn("BoolValue", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBoolValue)
                Me.columnIntValue = New DataColumn("IntValue", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnIntValue)
                Me.columnDblValue = New DataColumn("DblValue", GetType(Double), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDblValue)
                Me.columnStringValue = New DataColumn("StringValue", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnStringValue)
                Me.Constraints.Add(New UniqueConstraint("dsDefaultSetKey2", New DataColumn() {Me.columnDefaultSetID, Me.columnControlName}, True))
                Me.columnDefaultSetID.AllowDBNull = False
                Me.columnControlName.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode()> _
            Friend Sub InitVars()
                Me.columnDefaultSetID = MyBase.Columns.Item("DefaultSetID")
                Me.columnControlName = MyBase.Columns.Item("ControlName")
                Me.columnControlType = MyBase.Columns.Item("ControlType")
                Me.columnControlProperty = MyBase.Columns.Item("ControlProperty")
                Me.columnValueType = MyBase.Columns.Item("ValueType")
                Me.columnDateValue = MyBase.Columns.Item("DateValue")
                Me.columnBoolValue = MyBase.Columns.Item("BoolValue")
                Me.columnIntValue = MyBase.Columns.Item("IntValue")
                Me.columnDblValue = MyBase.Columns.Item("DblValue")
                Me.columnStringValue = MyBase.Columns.Item("StringValue")
            End Sub

            <DebuggerNonUserCode()> _
            Public Function NewgeneraldefaultsetsubRow() As generaldefaultsetsubRow
                Return DirectCast(Me.NewRow, generaldefaultsetsubRow)
            End Function

            <DebuggerNonUserCode()> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generaldefaultsetsubRow(builder)
            End Function

            <DebuggerNonUserCode()> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generaldefaultsetsubRowChangedEvent Is Nothing) Then
                    Dim generaldefaultsetsubRowChangedEvent As generaldefaultsetsubRowChangeEventHandler = Me.generaldefaultsetsubRowChangedEvent
                    If (Not generaldefaultsetsubRowChangedEvent Is Nothing) Then
                        generaldefaultsetsubRowChangedEvent.Invoke(Me, New generaldefaultsetsubRowChangeEvent(DirectCast(e.Row, generaldefaultsetsubRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode()> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generaldefaultsetsubRowChangingEvent Is Nothing) Then
                    Dim generaldefaultsetsubRowChangingEvent As generaldefaultsetsubRowChangeEventHandler = Me.generaldefaultsetsubRowChangingEvent
                    If (Not generaldefaultsetsubRowChangingEvent Is Nothing) Then
                        generaldefaultsetsubRowChangingEvent.Invoke(Me, New generaldefaultsetsubRowChangeEvent(DirectCast(e.Row, generaldefaultsetsubRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode()> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generaldefaultsetsubRowDeletedEvent Is Nothing) Then
                    Dim generaldefaultsetsubRowDeletedEvent As generaldefaultsetsubRowChangeEventHandler = Me.generaldefaultsetsubRowDeletedEvent
                    If (Not generaldefaultsetsubRowDeletedEvent Is Nothing) Then
                        generaldefaultsetsubRowDeletedEvent.Invoke(Me, New generaldefaultsetsubRowChangeEvent(DirectCast(e.Row, generaldefaultsetsubRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode()> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generaldefaultsetsubRowDeletingEvent Is Nothing) Then
                    Dim generaldefaultsetsubRowDeletingEvent As generaldefaultsetsubRowChangeEventHandler = Me.generaldefaultsetsubRowDeletingEvent
                    If (Not generaldefaultsetsubRowDeletingEvent Is Nothing) Then
                        generaldefaultsetsubRowDeletingEvent.Invoke(Me, New generaldefaultsetsubRowChangeEvent(DirectCast(e.Row, generaldefaultsetsubRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub RemovegeneraldefaultsetsubRow(ByVal row As generaldefaultsetsubRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode()> _
            Public ReadOnly Property BoolValueColumn() As DataColumn
                Get
                    Return Me.columnBoolValue
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property ControlNameColumn() As DataColumn
                Get
                    Return Me.columnControlName
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property ControlPropertyColumn() As DataColumn
                Get
                    Return Me.columnControlProperty
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property ControlTypeColumn() As DataColumn
                Get
                    Return Me.columnControlType
                End Get
            End Property

            <Browsable(False), DebuggerNonUserCode()> _
            Public ReadOnly Property Count() As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property DateValueColumn() As DataColumn
                Get
                    Return Me.columnDateValue
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property DblValueColumn() As DataColumn
                Get
                    Return Me.columnDblValue
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property DefaultSetIDColumn() As DataColumn
                Get
                    Return Me.columnDefaultSetID
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property IntValueColumn() As DataColumn
                Get
                    Return Me.columnIntValue
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Default Public ReadOnly Property Item(ByVal index As Integer) As generaldefaultsetsubRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generaldefaultsetsubRow)
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property StringValueColumn() As DataColumn
                Get
                    Return Me.columnStringValue
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property ValueTypeColumn() As DataColumn
                Get
                    Return Me.columnValueType
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnBoolValue As DataColumn
            Private columnControlName As DataColumn
            Private columnControlProperty As DataColumn
            Private columnControlType As DataColumn
            Private columnDateValue As DataColumn
            Private columnDblValue As DataColumn
            Private columnDefaultSetID As DataColumn
            Private columnIntValue As DataColumn
            Private columnStringValue As DataColumn
            Private columnValueType As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generaldefaultsetsubRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode()> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneraldefaultsetsub = DirectCast(Me.Table, generaldefaultsetsubDataTable)
            End Sub

            <DebuggerNonUserCode()> _
            Public Function IsBoolValueNull() As Boolean
                Return Me.IsNull(Me.tablegeneraldefaultsetsub.BoolValueColumn)
            End Function

            <DebuggerNonUserCode()> _
            Public Function IsControlPropertyNull() As Boolean
                Return Me.IsNull(Me.tablegeneraldefaultsetsub.ControlPropertyColumn)
            End Function

            <DebuggerNonUserCode()> _
            Public Function IsControlTypeNull() As Boolean
                Return Me.IsNull(Me.tablegeneraldefaultsetsub.ControlTypeColumn)
            End Function

            <DebuggerNonUserCode()> _
            Public Function IsDateValueNull() As Boolean
                Return Me.IsNull(Me.tablegeneraldefaultsetsub.DateValueColumn)
            End Function

            <DebuggerNonUserCode()> _
            Public Function IsDblValueNull() As Boolean
                Return Me.IsNull(Me.tablegeneraldefaultsetsub.DblValueColumn)
            End Function

            <DebuggerNonUserCode()> _
            Public Function IsIntValueNull() As Boolean
                Return Me.IsNull(Me.tablegeneraldefaultsetsub.IntValueColumn)
            End Function

            <DebuggerNonUserCode()> _
            Public Function IsStringValueNull() As Boolean
                Return Me.IsNull(Me.tablegeneraldefaultsetsub.StringValueColumn)
            End Function

            <DebuggerNonUserCode()> _
            Public Function IsValueTypeNull() As Boolean
                Return Me.IsNull(Me.tablegeneraldefaultsetsub.ValueTypeColumn)
            End Function

            <DebuggerNonUserCode()> _
            Public Sub SetBoolValueNull()
                Me.Item(Me.tablegeneraldefaultsetsub.BoolValueColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub SetControlPropertyNull()
                Me.Item(Me.tablegeneraldefaultsetsub.ControlPropertyColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub SetControlTypeNull()
                Me.Item(Me.tablegeneraldefaultsetsub.ControlTypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub SetDateValueNull()
                Me.Item(Me.tablegeneraldefaultsetsub.DateValueColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub SetDblValueNull()
                Me.Item(Me.tablegeneraldefaultsetsub.DblValueColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub SetIntValueNull()
                Me.Item(Me.tablegeneraldefaultsetsub.IntValueColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub SetStringValueNull()
                Me.Item(Me.tablegeneraldefaultsetsub.StringValueColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub SetValueTypeNull()
                Me.Item(Me.tablegeneraldefaultsetsub.ValueTypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode()> _
            Public Property BoolValue() As Boolean
                Get
                    Dim flag As Boolean
                    Try
                        flag = Conversions.ToBoolean(Me.Item(Me.tablegeneraldefaultsetsub.BoolValueColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BoolValue' in table 'generaldefaultsetsub' is DBNull.", innerException)
                        ProjectData.ClearProjectError()
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablegeneraldefaultsetsub.BoolValueColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode()> _
            Public Property ControlName() As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneraldefaultsetsub.ControlNameColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneraldefaultsetsub.ControlNameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode()> _
            Public Property ControlProperty() As String
                Get
                    Dim str As String
                    Try
                        str = Conversions.ToString(Me.Item(Me.tablegeneraldefaultsetsub.ControlPropertyColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ControlProperty' in table 'generaldefaultsetsub' is DBNull.", innerException)
                        ProjectData.ClearProjectError()
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneraldefaultsetsub.ControlPropertyColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode()> _
            Public Property ControlType() As String
                Get
                    Dim str As String
                    Try
                        str = Conversions.ToString(Me.Item(Me.tablegeneraldefaultsetsub.ControlTypeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ControlType' in table 'generaldefaultsetsub' is DBNull.", innerException)
                        ProjectData.ClearProjectError()
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneraldefaultsetsub.ControlTypeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode()> _
            Public Property DateValue() As DateTime
                Get
                    Dim time As DateTime
                    Try
                        time = Conversions.ToDate(Me.Item(Me.tablegeneraldefaultsetsub.DateValueColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'DateValue' in table 'generaldefaultsetsub' is DBNull.", innerException)
                        ProjectData.ClearProjectError()
                    End Try
                    Return time
                End Get
                Set(ByVal Value As DateTime)
                    Me.Item(Me.tablegeneraldefaultsetsub.DateValueColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode()> _
            Public Property DblValue() As Double
                Get
                    Dim num As Double
                    Try
                        num = Conversions.ToDouble(Me.Item(Me.tablegeneraldefaultsetsub.DblValueColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'DblValue' in table 'generaldefaultsetsub' is DBNull.", innerException)
                        ProjectData.ClearProjectError()
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Double)
                    Me.Item(Me.tablegeneraldefaultsetsub.DblValueColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode()> _
            Public Property DefaultSetID() As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneraldefaultsetsub.DefaultSetIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneraldefaultsetsub.DefaultSetIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode()> _
            Public Property IntValue() As Integer
                Get
                    Dim num As Integer
                    Try
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneraldefaultsetsub.IntValueColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'IntValue' in table 'generaldefaultsetsub' is DBNull.", innerException)
                        ProjectData.ClearProjectError()
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneraldefaultsetsub.IntValueColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode()> _
            Public Property StringValue() As String
                Get
                    Dim str As String
                    Try
                        str = Conversions.ToString(Me.Item(Me.tablegeneraldefaultsetsub.StringValueColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'StringValue' in table 'generaldefaultsetsub' is DBNull.", innerException)
                        ProjectData.ClearProjectError()
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneraldefaultsetsub.StringValueColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode()> _
            Public Property ValueType() As String
                Get
                    Dim str As String
                    Try
                        str = Conversions.ToString(Me.Item(Me.tablegeneraldefaultsetsub.ValueTypeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ValueType' in table 'generaldefaultsetsub' is DBNull.", innerException)
                        ProjectData.ClearProjectError()
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneraldefaultsetsub.ValueTypeColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneraldefaultsetsub As generaldefaultsetsubDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generaldefaultsetsubRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode()> _
            Public Sub New(ByVal row As generaldefaultsetsubRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode()> _
            Public ReadOnly Property Action() As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property Row() As generaldefaultsetsubRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generaldefaultsetsubRow
        End Class

        Public Delegate Sub generaldefaultsetsubRowChangeEventHandler(ByVal sender As Object, ByVal e As generaldefaultsetsubRowChangeEvent)

        <Serializable(), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class generalreportDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalreportRowChanged As generalreportRowChangeEventHandler
            Public Event generalreportRowChanging As generalreportRowChangeEventHandler
            Public Event generalreportRowDeleted As generalreportRowChangeEventHandler
            Public Event generalreportRowDeleting As generalreportRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode()> _
            Public Sub New()
                Dim list As ArrayList = generalreportDataTable.__ENCList
                SyncLock list
                    generalreportDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalreport"
                Me.BeginInit()
                Me.InitClass()
                Me.EndInit()
            End Sub

            <DebuggerNonUserCode()> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalreportDataTable.__ENCList
                SyncLock list
                    generalreportDataTable.__ENCList.Add(New WeakReference(Me))
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

            <DebuggerNonUserCode()> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = generalreportDataTable.__ENCList
                SyncLock list
                    generalreportDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars()
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub AddgeneralreportRow(ByVal row As generalreportRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode()> _
            Public Function AddgeneralreportRow(ByVal ReportID As Integer, ByVal MenuID As Integer, ByVal UserID As Integer, ByVal Name As String, ByVal Description As String, ByVal ReportPath As String, ByVal SystemReport As Integer, ByVal DefaultReport As Integer) As generalreportRow
                Dim row As generalreportRow = DirectCast(Me.NewRow, generalreportRow)
                row.ItemArray = New Object() {ReportID, MenuID, UserID, Name, Description, ReportPath, SystemReport, DefaultReport}
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode()> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalreportDataTable = DirectCast(MyBase.Clone, generalreportDataTable)
                table.InitVars()
                Return table
            End Function

            <DebuggerNonUserCode()> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalreportDataTable
            End Function

            <DebuggerNonUserCode()> _
            Public Function FindByReportID(ByVal ReportID As Integer) As generalreportRow
                Return DirectCast(Me.Rows.Find(New Object() {ReportID}), generalreportRow)
            End Function

            <DebuggerNonUserCode()> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode()> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalreportRow)
            End Function

            <DebuggerNonUserCode()> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim set As New dsDefaultSet
                xs.Add(ClsDs.GetSchemaSerializable)
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
                attribute.FixedValue = ClsDs.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalreportDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode()> _
            Private Sub InitClass()
                Me.columnReportID = New DataColumn("ReportID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnReportID)
                Me.columnMenuID = New DataColumn("MenuID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuID)
                Me.columnUserID = New DataColumn("UserID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnUserID)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnReportPath = New DataColumn("ReportPath", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnReportPath)
                Me.columnSystemReport = New DataColumn("SystemReport", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSystemReport)
                Me.columnDefaultReport = New DataColumn("DefaultReport", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDefaultReport)
                Me.Constraints.Add(New UniqueConstraint("dsDefaultSetKey3", New DataColumn() {Me.columnReportID}, True))
                Me.columnReportID.AllowDBNull = False
                Me.columnReportID.Unique = True
            End Sub

            <DebuggerNonUserCode()> _
            Friend Sub InitVars()
                Me.columnReportID = MyBase.Columns.Item("ReportID")
                Me.columnMenuID = MyBase.Columns.Item("MenuID")
                Me.columnUserID = MyBase.Columns.Item("UserID")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnReportPath = MyBase.Columns.Item("ReportPath")
                Me.columnSystemReport = MyBase.Columns.Item("SystemReport")
                Me.columnDefaultReport = MyBase.Columns.Item("DefaultReport")
            End Sub

            <DebuggerNonUserCode()> _
            Public Function NewgeneralreportRow() As generalreportRow
                Return DirectCast(Me.NewRow, generalreportRow)
            End Function

            <DebuggerNonUserCode()> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalreportRow(builder)
            End Function

            <DebuggerNonUserCode()> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalreportRowChangedEvent Is Nothing) Then
                    Dim generalreportRowChangedEvent As generalreportRowChangeEventHandler = Me.generalreportRowChangedEvent
                    If (Not generalreportRowChangedEvent Is Nothing) Then
                        generalreportRowChangedEvent.Invoke(Me, New generalreportRowChangeEvent(DirectCast(e.Row, generalreportRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode()> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalreportRowChangingEvent Is Nothing) Then
                    Dim generalreportRowChangingEvent As generalreportRowChangeEventHandler = Me.generalreportRowChangingEvent
                    If (Not generalreportRowChangingEvent Is Nothing) Then
                        generalreportRowChangingEvent.Invoke(Me, New generalreportRowChangeEvent(DirectCast(e.Row, generalreportRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode()> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalreportRowDeletedEvent Is Nothing) Then
                    Dim generalreportRowDeletedEvent As generalreportRowChangeEventHandler = Me.generalreportRowDeletedEvent
                    If (Not generalreportRowDeletedEvent Is Nothing) Then
                        generalreportRowDeletedEvent.Invoke(Me, New generalreportRowChangeEvent(DirectCast(e.Row, generalreportRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode()> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalreportRowDeletingEvent Is Nothing) Then
                    Dim generalreportRowDeletingEvent As generalreportRowChangeEventHandler = Me.generalreportRowDeletingEvent
                    If (Not generalreportRowDeletingEvent Is Nothing) Then
                        generalreportRowDeletingEvent.Invoke(Me, New generalreportRowChangeEvent(DirectCast(e.Row, generalreportRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode()> _
            Public Sub RemovegeneralreportRow(ByVal row As generalreportRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <Browsable(False), DebuggerNonUserCode()> _
            Public ReadOnly Property Count() As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property DefaultReportColumn() As DataColumn
                Get
                    Return Me.columnDefaultReport
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property DescriptionColumn() As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Default Public ReadOnly Property Item(ByVal index As Integer) As generalreportRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generalreportRow)
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property MenuIDColumn() As DataColumn
                Get
                    Return Me.columnMenuID
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property NameColumn() As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property ReportIDColumn() As DataColumn
                Get
                    Return Me.columnReportID
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property ReportPathColumn() As DataColumn
                Get
                    Return Me.columnReportPath
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property SystemReportColumn() As DataColumn
                Get
                    Return Me.columnSystemReport
                End Get
            End Property

            <DebuggerNonUserCode()> _
            Public ReadOnly Property UserIDColumn() As DataColumn
                Get
                    Return Me.columnUserID
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnDefaultReport As DataColumn
            Private columnDescription As DataColumn
            Private columnMenuID As DataColumn
            Private columnName As DataColumn
            Private columnReportID As DataColumn
            Private columnReportPath As DataColumn
            Private columnSystemReport As DataColumn
            Private columnUserID As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalreportRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralreport = DirectCast(Me.Table, generalreportDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsDefaultReportNull() As Boolean
                Return Me.IsNull(Me.tablegeneralreport.DefaultReportColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tablegeneralreport.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuIDNull() As Boolean
                Return Me.IsNull(Me.tablegeneralreport.MenuIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tablegeneralreport.NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsReportPathNull() As Boolean
                Return Me.IsNull(Me.tablegeneralreport.ReportPathColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsSystemReportNull() As Boolean
                Return Me.IsNull(Me.tablegeneralreport.SystemReportColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsUserIDNull() As Boolean
                Return Me.IsNull(Me.tablegeneralreport.UserIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetDefaultReportNull()
                Me.Item(Me.tablegeneralreport.DefaultReportColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tablegeneralreport.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuIDNull()
                Me.Item(Me.tablegeneralreport.MenuIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNameNull()
                Me.Item(Me.tablegeneralreport.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetReportPathNull()
                Me.Item(Me.tablegeneralreport.ReportPathColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetSystemReportNull()
                Me.Item(Me.tablegeneralreport.SystemReportColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetUserIDNull()
                Me.Item(Me.tablegeneralreport.UserIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property DefaultReport As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralreport.DefaultReportColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'DefaultReport' in table 'generalreport' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralreport.DefaultReportColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralreport.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'generalreport' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralreport.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralreport.MenuIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuID' in table 'generalreport' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralreport.MenuIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralreport.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'generalreport' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralreport.NameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ReportID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralreport.ReportIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralreport.ReportIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ReportPath As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralreport.ReportPathColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ReportPath' in table 'generalreport' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralreport.ReportPathColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property SystemReport As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralreport.SystemReportColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'SystemReport' in table 'generalreport' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralreport.SystemReportColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property UserID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralreport.UserIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'UserID' in table 'generalreport' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralreport.UserIDColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralreport As generalreportDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalreportRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalreportRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As generalreportRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalreportRow
        End Class

        Public Delegate Sub generalreportRowChangeEventHandler(ByVal sender As Object, ByVal e As generalreportRowChangeEvent)
    End Class
End Namespace

