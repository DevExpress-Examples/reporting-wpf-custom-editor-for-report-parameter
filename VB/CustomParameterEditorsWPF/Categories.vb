Imports System.Collections.Generic
Imports CustomParameterEditorsWPF.App_data

' ...
Namespace CustomParameterEditorsWPF

    Public Class Categories
        Inherits List(Of String)

        Public Sub New()
            Dim dataSet As nwindDataSet = New nwindDataSet()
            Call New nwindDataSetTableAdapters.CategoriesTableAdapter().Fill(dataSet.Categories)
            For Each category In dataSet.Categories
                Add(category.CategoryName)
            Next
        End Sub
    End Class
End Namespace
