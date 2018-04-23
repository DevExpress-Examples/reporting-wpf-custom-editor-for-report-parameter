Imports System.Collections.Generic
Imports CustomParameterEditorsWPF.Reports
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Xpf.Printing
' ...

Namespace CustomParameterEditorsWPF
    <POCOViewModel> _
    Public Class ViewModel

        Private model_Renamed As XtraReportPreviewModel
        Public Overridable Property Categories() As Categories

        Public ReadOnly Property Model() As XtraReportPreviewModel
            Get
                If model_Renamed IsNot Nothing Then
                    Return model_Renamed
                Else
                    model_Renamed = CreateReportModel()
                    Return model_Renamed
                End If
            End Get
        End Property

        Private Function CreateReportModel() As XtraReportPreviewModel

            Dim model_Renamed = New XtraReportPreviewModel()
            Dim report = New XtraReport1()
            model_Renamed.Report = report
            Categories = New Categories()
            AddHandler model_Renamed.ParametersModel.Validate, AddressOf ParametersModel_Validate
            report.CreateDocument()
            Return model_Renamed
        End Function

        Private Sub ParametersModel_Validate(ByVal sender As Object, ByVal e As DevExpress.Xpf.Printing.Parameters.Models.ValidateParameterEventArgs)
            If e.ParameterModel.Name = "catNames" Then

                Dim categories_Renamed As IList(Of Object) = DirectCast(e.ParameterModel.Value, IList(Of Object))
                If categories_Renamed.Count = 0 Then
                    e.Error = "No categories selected"
                End If
            End If
        End Sub
    End Class
End Namespace
