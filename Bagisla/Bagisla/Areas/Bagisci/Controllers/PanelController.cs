using Bagisla.Models;
using Bagisla.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Bagisla.Areas.Bagisci.Controllers
{
  // [Authorize(Roles ="Bagisci")]
    public class PanelController : Controller
    {
        // GET: Bagisci/Panel
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BagisYap()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            
            return RedirectToAction("../../Account/LogOut");
        }
        public ActionResult Profilim()
        {
            BagisciRepository _br = new BagisciRepository();
            
            return View(_br.GetBagisciDetay(User.Identity.Name));
        }
        [HttpPost]
        public ActionResult Profilim(BagisciDetay model)
        {
            BagisciRepository _br = new BagisciRepository();

            if (ModelState.IsValid)
            {
                BagisciDetay bagisciDetay = _br.GetBagisciDetay(User.Identity.Name);
                model.aspnet_Membership = bagisciDetay.aspnet_Membership;
                  
               model =_br.UpdateDetay(model);
                return View(model);

            }
            return View(_br.GetBagisciDetay(User.Identity.Name));
        }

    }
}