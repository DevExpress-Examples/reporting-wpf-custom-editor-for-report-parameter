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
    End Class
End Namespace
