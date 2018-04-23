using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Printing.Parameters;
using DevExpress.Xpf.Printing.Parameters.Models;


namespace CustomParameterEditorsWPF {
    public class CustomParameterTemplateSelector : ParameterTemplateSelector {
        Dictionary<object, DataTemplate> templates = new Dictionary<object, DataTemplate>();
        public Dictionary<object, DataTemplate> Templates { get { return templates; } }

        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            var parameter = item as ParameterModel;
            if(parameter == null)
                return null;
            if(parameter.MultiValue)
                return Templates["multiValueTemplate"];
            return base.SelectTemplate(item, container);
        }
    }
}
