@ModelType IList(Of Example.Product)
@Html.DevExpress().GridView( _
    Sub(s)
            s.Name = "grid"
            s.KeyFieldName = "ID"

            s.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "GridViewPartial"}
   
            s.Columns.Add( _
                Sub(c)
                        c.FieldName = "ID"
                        c.SortIndex = 0
                        c.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
                End Sub)
                    
            s.Columns.Add("Name")

            s.CommandColumn.Visible = True
            s.CommandColumn.NewButton.Visible = True
            s.CommandColumn.EditButton.Visible = True
            s.CommandColumn.DeleteButton.Visible = True

            s.SettingsEditing.AddNewRowRouteValues = New With {Key .Controller = "Home", Key .Action = "NewProductPartial"}
            s.SettingsEditing.DeleteRowRouteValues = New With {Key .Controller = "Home", Key .Action = "DeleteProductPartial"}
            s.SettingsEditing.UpdateRowRouteValues = New With {Key .Controller = "Home", Key .Action = "EditProductPartial"}
            s.SettingsEditing.Mode = GridViewEditingMode.EditFormAndDisplayRow

            s.SettingsEditing.ShowModelErrorsForEditors = True

            s.SetEditFormTemplateContent( _
                Sub(c)
                        Html.RenderPartial("ProductFormPartial",
                            If((Not c.Grid.IsNewRowEditing),
                                    Model.FirstOrDefault(Function(m) m.ID = Convert.ToInt32(DataBinder.Eval(c.DataItem, "ID"))),
                                    New Example.Product() With {.ID = Model.OrderByDescending(Function(p) p.ID).First().ID + 1})
                            )
                End Sub)
            
    End Sub).Bind(Model).GetHtml()