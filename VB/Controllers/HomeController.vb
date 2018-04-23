Public Class HomeController
    Inherits Controller
    Public Function Index() As ActionResult
        Return View()
    End Function

    Public Function GridViewPartial() As ActionResult
        Return PartialView("GridViewPartial", Products)
    End Function

    Public Function NewProductPartial(ByVal product As Product) As ActionResult
        product.ID = Products.OrderByDescending(Function(p) p.ID).First().ID + 1

        Products.Add(product)

        Return PartialView("GridViewPartial", Products)
    End Function

    Public Function EditProductPartial(ByVal product As Product) As ActionResult
        Dim editProduct As Product = Products.First(Function(p) p.ID = product.ID)
        editProduct.Name = product.Name

        Return PartialView("GridViewPartial", Products)
    End Function

    Public Function DeleteProductPartial(ByVal ID As Int32) As ActionResult
        Products.Remove(Products.First(Function(p) p.ID = ID))

        Return PartialView("GridViewPartial", Products)
    End Function

    Private Property Products() As IList(Of Product)
        Get
            If HttpContext.Session("products") Is Nothing Then
                Dim productsLocal As List(Of Product) = New List(Of Product)()

                For i As Integer = 0 To 13
                    productsLocal.Add(New Product() With {.ID = i, .Name = String.Format("Product {0}", i)})
                Next i

                HttpContext.Session("products") = productsLocal
            End If

            Return CType(HttpContext.Session("products"), IList(Of Product))
        End Get
        Set(ByVal value As IList(Of Product))
            HttpContext.Session("products") = value
        End Set
    End Property
End Class