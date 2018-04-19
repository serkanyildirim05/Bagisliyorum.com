﻿using Bagisla.Models;
using Bagisla.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bagisla.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: PartialView
     
        HastaRepository hr = new HastaRepository();
        public ActionResult HastaGetir()
        {
            List<Hastalar> hastaList = new List<Hastalar>();
            hastaList = hr.GetHastalar();

            return View(hastaList);
        }
    }
}