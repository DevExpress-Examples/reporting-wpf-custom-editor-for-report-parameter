Imports System.Collections.Generic
Imports System.Windows
Imports CustomParameterEditorsWPF.App_data
Imports CustomParameterEditorsWPF.Reports
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraReports.UI

Namespace CustomParameterEditorsWPF
    Public Class Categories
        Inherits List(Of String)

        Public Sub New()
            Dim dataSet As New nwindDataSet()
            CType(New CustomParameterEditorsWPF.App_data.nwindDataSetTableAdapters.CategoriesTableAdapter(), CustomParameterEditorsWPF.App_data.nwindDataSetTableAdapters.CategoriesTableAdapter).Fill(dataSet.Categories)
            For Each category In dataSet.Categories
                Add(category.CategoryName)
            Next category
        End Sub
    End Class
End Namespace
