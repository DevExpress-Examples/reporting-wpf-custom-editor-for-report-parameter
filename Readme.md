<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602855/23.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3359)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for WPF - Custom Editors for Report Parameters


This example invokes a custom [ComboBoxEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.ComboBoxEdit) editor for a multi-value report parameter.

To implement a custom parameter editor, create a custom parameter template selector and assign it to the [ParameterTemplateSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.Parameters.ParametersPanel.ParameterTemplateSelector) property of the of the [DocumentPreviewControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.DocumentPreviewControl)‘s [ParametersPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.Parameters.ParametersPanel). 

The custom parameters template selector extends the base [ParameterTemplateSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.Parameters.ParameterTemplateSelector) class, and specifies a custom editor template for the multivalue parameter.

![Screenshot](Images/screenshot.png)
## Files to Review

* [CustomParameterTemplateSelector.cs](./CS/CustomParameterEditorsWPF/CustomParameterTemplateSelector.cs) (VB: [CustomParameterTemplateSelector.vb](./VB/CustomParameterEditorsWPF/CustomParameterTemplateSelector.vb))
* [MainWindow.xaml](./CS/CustomParameterEditorsWPF/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomParameterEditorsWPF/MainWindow.xaml))

## Documentation

* [Custom Editors for Report Parameters](https://docs.devexpress.com/XtraReports/17763/wpf-reporting/wpf-reporting-document-preview/api-and-customization/provide-custom-editors-for-report-parameters)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-custom-editor-for-report-parameter&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-custom-editor-for-report-parameter&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
