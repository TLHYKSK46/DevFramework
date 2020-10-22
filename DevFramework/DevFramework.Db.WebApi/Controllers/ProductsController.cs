using DevFramework.Db.Business.Abstract;
using DevFramework.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DevFramework.Db.WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        // GET: Products
        private IProductServis _productService;

        public ProductsController(IProductServis productService)
        {
            _productService = productService;
        }

        public List<Product> Get() {
            return _productService.GetAll();

            }
        
    }
}