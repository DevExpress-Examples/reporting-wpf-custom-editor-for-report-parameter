Imports System.Windows
Imports System.Windows.Controls
Imports CustomParameterEditorsWPF.Reports

Namespace CustomParameterEditorsWPF

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim report = New XtraReport1()
            Me.preview.DocumentSource = report
        End Sub
    End Class
End Namespace
