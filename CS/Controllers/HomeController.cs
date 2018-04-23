using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Example.Models;

namespace Example.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult GridViewPartial() {
            return PartialView("GridViewPartial", Products);
        }

        public ActionResult NewProductPartial(Product product) {
            product.ID = Products.OrderByDescending(p => p.ID)
                .First()
                .ID + 1;

            Products.Add(product);

            return PartialView("GridViewPartial", Products);
        }

        public ActionResult EditProductPartial(Product product) {
            Product editProduct = Products.First<Product>(p => p.ID == product.ID);
            editProduct.Name = product.Name;

            return PartialView("GridViewPartial", Products);
        }

        public ActionResult DeleteProductPartial(Int32 ID) {
            Products.Remove(Products.First<Product>(p => p.ID == ID));

            return PartialView("GridViewPartial", Products);
        }

        private IList<Product> Products {
            get {
                if(HttpContext.Session["products"] == null) {
                    List<Product> products = new List<Product>();

                    for(int i = 0; i < 14; i++)
                        products.Add(new Product() {
                            ID = i,
                            Name = string.Format("Product {0}", i)
                        });

                    HttpContext.Session["products"] = products;
                }

                return (IList<Product>)HttpContext.Session["products"];
            }
            set {
                HttpContext.Session["products"] = value;
            }
        }
    }
}
