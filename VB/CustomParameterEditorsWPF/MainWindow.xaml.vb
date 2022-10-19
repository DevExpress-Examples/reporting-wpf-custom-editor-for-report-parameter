Imports System.Collections.Generic
Imports System.Windows
Imports CustomParameterEditorsWPF.App_data
Imports CustomParameterEditorsWPF.Reports
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraReports.UI

' ...
Namespace CustomParameterEditorsWPF

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            ThemeManager.ApplicationThemeName = "Azure"
        End Sub

        Private ReadOnly reportField As XtraReport1 = New XtraReport1()

        Private ReadOnly Property Report As XtraReport
            Get
                Return reportField
            End Get
        End Property

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim model As XtraReportPreviewModel = New XtraReportPreviewModel(reportField)
            AddHandler model.CustomizeParameterEditors, AddressOf model_CustomizeParameterEditors
            Me.preview.Model = model
            reportField.CreateDocument(False)
        End Sub

        Private Sub model_CustomizeParameterEditors(ByVal sender As Object, ByVal e As CustomizeParameterEditorsEventArgs)
            If Equals(e.Parameter.Name, "catNames") Then
                Dim dataSet As nwindDataSet = New nwindDataSet()
                Call New nwindDataSetTableAdapters.CategoriesTableAdapter().Fill(dataSet.Categories)
                Dim categoryNames = New List(Of String)()
                For Each category In dataSet.Categories
                    categoryNames.Add(category.CategoryName)
                Next

                Dim editor As ComboBoxEdit = New ComboBoxEdit()
                editor.StyleSettings = New CheckedComboBoxStyleSettings()
                editor.ItemsSource = categoryNames
                editor.IsTextEditable = False
                e.Editor = editor
                e.BoundDataMember = "EditValue"
            End If
        End Sub
    End Class
End Namespace
