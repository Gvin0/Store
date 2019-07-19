using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.WebAdmin.Controllers {
   using Domain.Domains;
   using Domain.Interfaces;
   using Services;

   public class CategoryController : BaseController<Category, ICategoryService> {
      private readonly IProductListService _productListService;

      public CategoryController(ICategoryService service, IProductListService productListService) : base(service) {
         _productListService = productListService;
      }

      public ActionResult Index() {

         return View();
      }
   }
}