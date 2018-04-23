Imports Microsoft.VisualBasic
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
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			ThemeManager.ApplicationThemeName = "Azure"
		End Sub

		Private ReadOnly report_Renamed As New XtraReport1()

		Private ReadOnly Property Report() As XtraReport
			Get
				Return report_Renamed
			End Get
		End Property

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim model As New XtraReportPreviewModel(report_Renamed)
			AddHandler model.CustomizeParameterEditors, AddressOf model_CustomizeParameterEditors
			preview.Model = model
			report_Renamed.CreateDocument(False)
		End Sub

		Private Sub model_CustomizeParameterEditors(ByVal sender As Object, ByVal e As CustomizeParameterEditorsEventArgs)
			If e.Parameter.Name = "catNames" Then
				Dim dataSet As New nwindDataSet()
				CType(New CustomParameterEditorsWPF.App_data.nwindDataSetTableAdapters.CategoriesTableAdapter(), CustomParameterEditorsWPF.App_data.nwindDataSetTableAdapters.CategoriesTableAdapter).Fill(dataSet.Categories)
				Dim categoryNames = New List(Of String)()
				For Each category In dataSet.Categories
					categoryNames.Add(category.CategoryName)
				Next category
				Dim editor As New ComboBoxEdit()
				editor.StyleSettings = New CheckedComboBoxStyleSettings()
				editor.ItemsSource = categoryNames
				editor.IsTextEditable = False
				e.Editor = editor
				e.BoundDataMember = "EditValue"
			End If
		End Sub
	End Class
End Namespace
