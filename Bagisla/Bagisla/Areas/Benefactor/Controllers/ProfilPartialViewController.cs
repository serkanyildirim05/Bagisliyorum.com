using _DbEntities.Repository.Concrete;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Bagisla.Areas.Benefactor.Controllers
{
    [ChildActionOnly]
    public class ProfilPartialViewController : Controller
    {
       
        // GET: Bagisci/PartialView
    
        public ActionResult PVProfil()
        {

            UserRepository ur = new UserRepository();
            return View(ur.GetUserById(User.Identity.GetUserId())); 
        }
    }
}