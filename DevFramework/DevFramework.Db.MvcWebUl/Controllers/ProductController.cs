using DevFramework.Db.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace DevFramework.Db.MvcWebUl.Controllers
{
    public class ProductController : Controller
    {

        // GET: Product
        IProductServis _productService;

        public ProductController(IProductServis productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.GetAll(),
            };

            return View(model);
        }
    }
}