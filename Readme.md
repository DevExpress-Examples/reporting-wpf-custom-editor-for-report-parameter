<!-- default file list -->
*Files to look at*:

* [CustomParameterTemplateSelector.cs](./CS/CustomParameterEditorsWPF/CustomParameterTemplateSelector.cs) (VB: [CustomParameterTemplateSelector.vb](./VB/CustomParameterEditorsWPF/CustomParameterTemplateSelector.vb))
* [MainWindow.xaml](./CS/CustomParameterEditorsWPF/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomParameterEditorsWPF/MainWindow.xaml))
* [XtraReport1.cs](./CS/CustomParameterEditorsWPF/Reports/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/CustomParameterEditorsWPF/Reports/XtraReport1.vb))
* [ViewModel.cs](./CS/CustomParameterEditorsWPF/ViewModel.cs) (VB: [ViewModel.vb](./VB/CustomParameterEditorsWPF/ViewModel.vb))
<!-- default file list end -->
# How to provide custom editors for report parameters in WPF


<p>This example demonstrates how you can provide custom editors for report parameters of arbitrary types. In particular, it shows how to utilize a custom <strong>ComboBoxEdit</strong> as an editor for a multi-value report parameter.</p>
<p> To provide the described functionality, implement a custom parameter template selector and assign it to the <strong>ParameterTemplateSelector </strong>property of the <strong>DocumentPreviewControl</strong>'s <strong>ParametersPanel</strong>. In this example, the custom parameters template selector extends the base <strong>ParameterTemplateSelector</strong> class with the capability to provide a custom editor template for each parameter whose <strong>MultiValue</strong> property is set to <strong>true</strong>. The custom editor template is declared in XAML.</p>

<br/>


