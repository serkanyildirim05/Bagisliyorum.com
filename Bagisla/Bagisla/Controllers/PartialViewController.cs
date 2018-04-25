using Bagisla.Models;
using Bagisla.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bagisla.Controllers
{
    [ChildActionOnly]
    public class PartialViewController : Controller
    {
        // GET: PartialView
     
        HastaRepository hr = new HastaRepository();
        public ActionResult HastaGetir()
        {
            List<HastaDetay> hastaList = new List<HastaDetay>();
            hastaList = hr.GetHastalar();

            return View(hastaList);
        }
    }
}