using System.Collections.Generic;
using System.Windows;
using CustomParameterEditorsWPF.App_data;
using CustomParameterEditorsWPF.Reports;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Printing;
using DevExpress.XtraReports.UI;
// ...

namespace CustomParameterEditorsWPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            ThemeManager.ApplicationThemeName = "Azure";
        }
    }
}
