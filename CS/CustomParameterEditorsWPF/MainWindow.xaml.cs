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

        readonly XtraReport1 report = new XtraReport1();

        XtraReport Report {
            get {
                return report;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            XtraReportPreviewModel model = new XtraReportPreviewModel(report);
            model.CustomizeParameterEditors += model_CustomizeParameterEditors;
            preview.Model = model;
            report.CreateDocument(false);
        }

        void model_CustomizeParameterEditors(object sender, CustomizeParameterEditorsEventArgs e) {
            if (e.Parameter.Name == "catNames") {
                nwindDataSet dataSet = new nwindDataSet();
                new CustomParameterEditorsWPF.App_data.nwindDataSetTableAdapters.CategoriesTableAdapter().Fill(dataSet.Categories);
                var categoryNames = new List<string>();
                foreach (var category in dataSet.Categories) {
                    categoryNames.Add(category.CategoryName);
                }
                ComboBoxEdit editor = new ComboBoxEdit();
                editor.StyleSettings = new CheckedComboBoxStyleSettings();
                editor.ItemsSource = categoryNames;
                editor.IsTextEditable = false;
                e.Editor = editor;
                e.BoundDataMember = "EditValue";
            }
        }
    }
}
