using Bagisla.Models;
using Bagisla.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Bagisla.Controllers
{
    public class HomeController : Controller
    {
        DoktorRepository dr = new DoktorRepository();
        SSSRepository sr = new SSSRepository();

        public ActionResult Index()
        {
            return View();
        }

     
        // GET: Doktor
        public ActionResult Doktorlar()
        {
            List<DoktorDetay> doktorList = new List<DoktorDetay>();
            doktorList = dr.GetDoktorlar();

            return View(doktorList);
        }
        public ActionResult SSS()
        {
            List<SSS> sList = new List<SSS>();
            sList = sr.GetSSS();

            return View(sList);
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult NasilCalisir()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View(new Mesajlar());
        }
        [HttpPost]
        public ActionResult Iletisim(Mesajlar model)
        {
            MesajlarRepository _m = new MesajlarRepository();
            if (_m.Add_Mesajlar(model)>0)ViewBag.result = true;
            else ViewBag.result = false;
            return View(model);
        }
        public ActionResult RolesManagement()
        {

            Roles.CreateRole("Administrator");
            Roles.CreateRole("Doktor");
            Roles.CreateRole("Hasta");
            Roles.AddUserToRole("arda", "Doktor");


            return View();
        }
        public ActionResult Detay()
        {
            return View();

        }

    }
}