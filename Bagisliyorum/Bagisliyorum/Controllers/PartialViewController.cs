using Bagisliyorum.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bagisliyorum.Controllers
{
    public class PartialViewController : Controller
    {
        HastalarConcrete hc = new HastalarConcrete();
        [ChildActionOnly]
        public ActionResult HastaGetir()
        {
            return View();
        }
    }
}