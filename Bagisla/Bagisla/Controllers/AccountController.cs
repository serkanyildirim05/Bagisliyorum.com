using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Bagisla.Models;
using System.Web.Security;
using System.Collections.Generic;
using Bagisla.Models.ViewModel;
using Bagisla.Repository.Concrete;

namespace Bagisla.Controllers
{
    public class AccountController : Controller
    {

        //-----------------------------------------------------------------------------------------------//
        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }

        //public ActionResult Register(RegisterModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
              
        //        MembershipCreateStatus status;
        //        MembershipUser User=  Membership.CreateUser(model.UserName, model.Password, model.Email, "soru", "cevap", true, out status);
        //        FormsAuthentication.SetAuthCookie(model.UserName, false);
        //        if (status == MembershipCreateStatus.Success)
        //        {
        //            if (model.Bagisci == true)
        //            {
        //                Roles.AddUserToRole(User.UserName, "Bagisci");
        //            }
        //            return RedirectToAction("Index", "Home");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", status.ToString());
        //        }
        //    }
        //    return View(model);
        //}

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult BagisciKayit(RegisterViewModel model)
        {

            return RedirectToAction("Register",model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult HastaKayit(RegisterViewModel model)
        {
            HastaRepository _hr =new HastaRepository();
            if (model.HD!=null)
            {
            
                    RedirectToAction("Register",new {model});
                
              

                //MembershipCreateStatus status;
                //MembershipUser User = Membership.CreateUser(model.UserName, model.Password, model.Email, "soru", "cevap", true, out status);
                //FormsAuthentication.SetAuthCookie(model.UserName, false);
                //if (status == MembershipCreateStatus.Success)
                //{
                //    if (model.Bagisci == true)
                //    {
                //        Roles.AddUserToRole(User.UserName, "Bagisci");
                //    }
                //    return RedirectToAction("Index", "Home");
                //}
                //else
                //{
                //    ModelState.AddModelError("", status.ToString());
                //}
                //_hr.HastaDetayEkle(model.HD);
            }
            return RedirectToAction("Register", model);
        }
        public ActionResult LogOn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(model.UserName, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/") && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                        return Redirect(returnUrl);
                    else
                        return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı!");
                }
            }
            return View(model);
        }

        public ActionResult ChangePassword()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                bool result;
                try
                {
                    MembershipUser currentUser = Membership.GetUser(User.Identity.Name, true);
                    result = currentUser.ChangePassword(model.OldPassword, model.NewPassword);
                }
                catch
                {
                    result = false;
                }
                if (result)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Şifre değiştirmöe başarısız!");
                }
            }
            return View(model);
        }
    }
}