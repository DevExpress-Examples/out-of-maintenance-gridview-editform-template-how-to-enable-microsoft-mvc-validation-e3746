# GridView - EditForm template - How to enable Microsoft MVC validation


<p>The example shows how to use Microsoft MVC validation (when the <strong>UnobtrusiveJavaScriptEnabled</strong> property is disabled in <i>web.config</i>). The main requirement is to create an Edit Form template with a form and editors. When a user needs to update a record, the following JavaScript should be invoked to process the Edit Form and check validation parameters:</p>

```js
function UpdateGridView() {<newline/>	InitializeMVCValidationScript();
<newline/>	var form = GetEditableForm();<newline/>	if (form.validationCallbacks[0]())<newline/>		grid.UpdateEdit();<newline/>}<newline/>function InitializeMVCValidationScript() {<newline/>	var validationRulesScript = GetEditableForm().nextSibling;<newline/>	if (validationRulesScript && !validationRulesScript.executed) {<newline/>		validationRulesScript.executed = true;<newline/>		eval(validationRulesScript.text);<newline/>		Sys.Mvc.FormContext._Application_Load();<newline/>	}<newline/>}<newline/>function GetEditableForm() {<newline/>	return document.getElementById("frmProduct");<newline/>}
```

<p> </p><p><a href="https://www.devexpress.com/Support/Center/p/E3744">How to enable unobtrusive validation for GridView using the EditForm template</a></p>

<br/>


