using System.Collections.Generic;
using DevExpress.XtraReports.UI;
// ...

namespace CustomParameterEditorsWPF.Reports {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
            catNames.Type = typeof(List<object>);
            catNames.Value = new List<object>() { "Confections", "Produce" };
        }

        private void XtraReport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            string filter = string.Empty;
            List<object> categoryNames = (List<object>)catNames.Value;
            for (int i = 0; i < categoryNames.Count; i++) {
                filter += string.Format("[CategoryName] = '{0}'", categoryNames[i]);
                if (i != categoryNames.Count - 1)
                    filter += " OR";
            }
            ((XtraReport)sender).FilterString = filter;
        }

    }
}
