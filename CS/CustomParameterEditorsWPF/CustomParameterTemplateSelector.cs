using System.Collections.Generic;
using System.Windows;
using DevExpress.Xpf.Printing.Parameters;
using DevExpress.XtraReports.Parameters.ViewModels;

namespace CustomParameterEditorsWPF
{
    public class CustomParameterTemplateSelector : ParameterTemplateSelector {
        Dictionary<object, DataTemplate> templates = new Dictionary<object, DataTemplate>();
        public Dictionary<object, DataTemplate> Templates { get { return templates; } }

        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            var parameter = item as ParameterItemViewModel;
            if(parameter == null)
                return null;
            if(parameter.MultiValue)
                return Templates["multiValueTemplate"];
            return base.SelectTemplate(item, container);
        }
    }
}
