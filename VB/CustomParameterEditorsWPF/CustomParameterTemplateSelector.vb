Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Printing.Parameters
Imports DevExpress.Xpf.Printing.Parameters.Models


Namespace CustomParameterEditorsWPF
    Public Class CustomParameterTemplateSelector
        Inherits ParameterTemplateSelector


        Private templates_Renamed As New Dictionary(Of Object, DataTemplate)()
        Public ReadOnly Property Templates() As Dictionary(Of Object, DataTemplate)
            Get
                Return templates_Renamed
            End Get
        End Property

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim parameter = TryCast(item, ParameterModel)
            If parameter Is Nothing Then
                Return Nothing
            End If
            If parameter.MultiValue Then
                Return Templates("multiValueTemplate")
            End If
            Return MyBase.SelectTemplate(item, container)
        End Function
    End Class
End Namespace
