@ModelType Example.Product
@Using (Html.BeginForm("Index", "Home", FormMethod.Post, New With {.id = "frmProduct"}))
    @<table>
        <tr>
            <td>
                @Html.DevExpress().Label( _
                   Sub(s)
                       s.AssociatedControlName = "ID"
                       s.Text = "ID"
                   End Sub).GetHtml()
            </td>
            <td>
                @Html.DevExpress().TextBox( _
                   Sub(s)
                       s.Name = "ID"
                       s.ShowModelErrors = True
                       s.ReadOnly = True
                   End Sub).Bind(Model.ID).GetHtml()
            </td>
        </tr>
        <tr>
            <td>
                @Html.DevExpress().Label( _
                   Sub(s)
                       s.AssociatedControlName = "Name"
                       s.Text = "Name"
                   End Sub).GetHtml()
            </td>
            <td>
                @Html.DevExpress().TextBox( _
                   Sub(s)
                       s.Name = "Name"
                       s.ShowModelErrors = True
                   End Sub).Bind(Model.Name).GetHtml()
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                @Html.DevExpress().HyperLink( _
                   Sub(s)
                       s.Name = "SaveProduct"
                       s.Properties.Text = "Save"
                       s.NavigateUrl = "javascript:UpdateGridView();"
                   End Sub).GetHtml()
                @Html.DevExpress().HyperLink( _
                   Sub(s)
                       s.Name = "CancelProduct"
                       s.Properties.Text = "Cancel"
                       s.NavigateUrl = "javascript:grid.CancelEdit();"
                   End Sub).GetHtml()
            </td>
        </tr>
    </table>
End Using