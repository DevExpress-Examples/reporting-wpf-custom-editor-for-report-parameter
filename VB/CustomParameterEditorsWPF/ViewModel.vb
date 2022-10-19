Imports System.Collections.Generic
Imports CustomParameterEditorsWPF.Reports
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Xpf.Printing

' ...
Namespace CustomParameterEditorsWPF

    <POCOViewModel>
    Public Class ViewModel

        Private modelField As XtraReportPreviewModel

        Public Overridable Property Categories As Categories

        Public ReadOnly Property Model As XtraReportPreviewModel
            Get
                Return If(modelField, Function()
                    modelField = CreateReportModel()
                    Return modelField
                End Function())
            End Get
        End Property

        Private Function CreateReportModel() As XtraReportPreviewModel
            Dim model = New XtraReportPreviewModel()
            Dim report = New XtraReport1()
            model.Report = report
            Categories = New Categories()
            AddHandler model.ParametersModel.Validate, AddressOf ParametersModel_Validate
            report.CreateDocument()
            Return model
        End Function

        Private Sub ParametersModel_Validate(ByVal sender As Object, ByVal e As Parameters.Models.ValidateParameterEventArgs)
            If Equals(e.ParameterModel.Name, "catNames") Then
                Dim categories As IList(Of Object) = CType(e.ParameterModel.Value, IList(Of Object))
                If categories.Count = 0 Then
                    e.Error = "No categories selected"
                End If
            End If
        End Sub
    End Class
End Namespace
