using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bagisla.Areas.Benefactor.Controllers
{
  
    public class PanelController : Controller
    {
        // GET: Benefactor/Panel
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MyProfile()
        {
            return View();

        }

    }
}