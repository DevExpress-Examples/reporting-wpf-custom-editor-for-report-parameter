using System.Collections.Generic;
using CustomParameterEditorsWPF.Reports;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Printing;
// ...

namespace CustomParameterEditorsWPF {
    [POCOViewModel]
    public class ViewModel {
        XtraReportPreviewModel model;
        public virtual Categories Categories { get; set; }

        public XtraReportPreviewModel Model {
            get {
                return model ?? (model = CreateReportModel());
            }
        }

        XtraReportPreviewModel CreateReportModel() {
            var model = new XtraReportPreviewModel();
            var report = new XtraReport1();
            model.Report = report;
            Categories = new Categories();
            model.ParametersModel.Validate += ParametersModel_Validate;
            report.CreateDocument();
            return model;
        }

        void ParametersModel_Validate(object sender, DevExpress.Xpf.Printing.Parameters.Models.ValidateParameterEventArgs e) {
            if(e.ParameterModel.Name == "catNames") {
                IList<object> categories = (IList<object>)e.ParameterModel.Value;
                if(categories.Count == 0) {
                    e.Error = "No categories selected";
                }
            }
        }
    }
}
