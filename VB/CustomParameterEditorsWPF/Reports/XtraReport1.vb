Imports System.Collections.Generic
Imports DevExpress.XtraReports.UI
' ...

Namespace CustomParameterEditorsWPF.Reports
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            catNames.Type = GetType(List(Of Object))
            catNames.Value = New List(Of Object)() From {"Confections", "Produce"}
        End Sub

        Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
            Dim filter As String = String.Empty
            Dim categoryNames As List(Of Object) = CType(catNames.Value, List(Of Object))
            For i As Integer = 0 To categoryNames.Count - 1
                filter &= String.Format("[CategoryName] = '{0}'", categoryNames(i))
                If i <> categoryNames.Count - 1 Then
                    filter &= " OR"
                End If
            Next i
            DirectCast(sender, XtraReport).FilterString = filter
        End Sub

    End Class
End Namespace
