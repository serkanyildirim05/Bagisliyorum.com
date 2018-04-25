using Bagisla.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Bagisla.Areas.Bagisci.Controllers
{
    [ChildActionOnly]
    public class ProfilPartialViewController : Controller
    {
       
        // GET: Bagisci/PartialView
        ProfilRepository pr = new ProfilRepository();
        public ActionResult PVProfil()
        {

            MembershipUser user = Membership.GetUser();
            return View(); 
        }
    }
}