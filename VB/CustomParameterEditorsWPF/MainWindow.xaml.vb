Imports System.Windows
Imports DevExpress.Xpf.Core

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
    End Class
End Namespace
