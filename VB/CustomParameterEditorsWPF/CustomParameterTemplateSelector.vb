Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.Printing.Parameters
Imports DevExpress.XtraReports.Parameters.ViewModels

Namespace CustomParameterEditorsWPF

    Public Class CustomParameterTemplateSelector
        Inherits ParameterTemplateSelector

        Private templatesField As Dictionary(Of Object, DataTemplate) = New Dictionary(Of Object, DataTemplate)()

        Public ReadOnly Property Templates As Dictionary(Of Object, DataTemplate)
            Get
                Return templatesField
            End Get
        End Property

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim parameter = TryCast(item, ParameterItemViewModel)
            If parameter Is Nothing Then Return Nothing
            If parameter.MultiValue Then Return Templates("multiValueTemplate")
            Return MyBase.SelectTemplate(item, container)
        End Function
    End Class
End Namespace
