using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.WebAdmin.Controllers {
   using Domain.Domains;
   using Domain.Interfaces;
   using Services;

   public class BaseController<TEntity, TService> : Controller
        where TEntity : class
        where TService : IBaseService<TEntity> {

      protected readonly TService _service;

      public BaseController(TService service) {
         _service = service;
      }
   }
}