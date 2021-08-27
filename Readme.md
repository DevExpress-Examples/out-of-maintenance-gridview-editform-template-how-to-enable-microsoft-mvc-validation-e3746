<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128549685/11.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3746)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))
* [Global.asax.cs](./CS/Global.asax.cs) (VB: [Global.asax.vb](./VB/Global.asax.vb))
* [Product.cs](./CS/Models/Product.cs) (VB: [Product.vb](./VB/Models/Product.vb))
* [GridViewPartial.cshtml](./CS/Views/Home/GridViewPartial.cshtml)
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
* [ProductFormPartial.cshtml](./CS/Views/Home/ProductFormPartial.cshtml)
<!-- default file list end -->
# GridView - EditForm template - How to enable Microsoft MVC validation
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3746)**
<!-- run online end -->


<p>The example shows how to use Microsoft MVC validation (when the <strong>UnobtrusiveJavaScriptEnabled</strong> property is disabled in <i>web.config</i>). The main requirement is to create an Edit Form template with a form and editors. When a user needs to update a record, the following JavaScript should be invoked to process the Edit Form and check validation parameters:</p>

```js
function UpdateGridView() {<newline/>	InitializeMVCValidationScript();
<newline/>	var form = GetEditableForm();<newline/>	if (form.validationCallbacks[0]())<newline/>		grid.UpdateEdit();<newline/>}<newline/>function InitializeMVCValidationScript() {<newline/>	var validationRulesScript = GetEditableForm().nextSibling;<newline/>	if (validationRulesScript && !validationRulesScript.executed) {<newline/>		validationRulesScript.executed = true;<newline/>		eval(validationRulesScript.text);<newline/>		Sys.Mvc.FormContext._Application_Load();<newline/>	}<newline/>}<newline/>function GetEditableForm() {<newline/>	return document.getElementById("frmProduct");<newline/>}
```

<p> </p><p><a href="https://www.devexpress.com/Support/Center/p/E3744">How to enable unobtrusive validation for GridView using the EditForm template</a></p>

<br/>


