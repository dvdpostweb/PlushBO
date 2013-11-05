

Public Class clsSingleton

    'class pour passage de variable entre les forms
    Private Shared singleton_instance As clsSingleton = Nothing
    Private Shared ReadOnly mylock As New Object()


    Public Products_dvd_id As Integer
    'Public Products_id As Integer
    Public TypeStepPaymentOffline As Integer
    Public StrTypeStepPaymentOffline As String
    Public Activation_Discount_id As Integer
    Public isSummary As Boolean
    Public CustomersId As Integer


    Protected Sub New()
    End Sub

    Public Shared Function GetVersionAssembly() As Integer
        Dim type As Type = type.GetType("System.Int32")
        Dim ass As System.Reflection.Assembly = System.Reflection.Assembly.GetAssembly(type)
        Dim assemblyName As System.Reflection.AssemblyName = ass.GetName()
        Dim version As Version = assemblyName.Version
    End Function

    Public Shared Function Instance() As clsSingleton
        SyncLock (mylock)

            If singleton_instance Is Nothing Then
                singleton_instance = New clsSingleton
            End If


            ' return the initialized instance of the Singleton Class
            Return singleton_instance
        End SyncLock
    End Function


End Class

