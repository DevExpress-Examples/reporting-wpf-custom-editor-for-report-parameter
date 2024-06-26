<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602855/11.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3359)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/CustomParameterEditorsWPF/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomParameterEditorsWPF/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomParameterEditorsWPF/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomParameterEditorsWPF/MainWindow.xaml.vb))
* [XtraReport1.cs](./CS/CustomParameterEditorsWPF/Reports/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/CustomParameterEditorsWPF/Reports/XtraReport1.vb))
<!-- default file list end -->
# How to provide custom editors for report parameters in WPF


<p>This example demonstrates how you can provide custom editors for report parameters of arbitrary types. In particular, it shows how to utilize a custom <strong>ComboBoxEdit</strong> as an editor for a multi-value report parameter.</p>
<p> To provide the described functionality, implement a custom parameter template selector and assign it to the <strong>ParameterTemplateSelector </strong>property of the <strong>DocumentPreviewControl</strong>'s <strong>ParametersPanel</strong>. In this example, the custom parameters template selector extends the base <strong>ParameterTemplateSelector</strong> class with the capability to provide a custom editor template for each parameter whose <strong>MultiValue</strong> property is set to <strong>true</strong>. The custom editor template is declared in XAML.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-custom-editor-for-report-parameter&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-custom-editor-for-report-parameter&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
