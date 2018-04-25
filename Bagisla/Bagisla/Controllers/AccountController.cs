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
        public ActionResult Register(RegisterViewModel model,ModelState state)
        {
            if (TempData["a"]!=null)
            {
                foreach (var item in (List<string>)TempData["a"])
                {
                    ModelState.AddModelError("", item);
                }
            }
            return View(model);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult BagisciKayit(RegisterViewModel model)
        {
            if (model.User.Password == model.User.ConfirmPassword)
            {
                MembershipCreateStatus status;
               
                MembershipUser user = Membership.CreateUser(model.User.Email, model.User.Password,model.User.Email,"soru","cevap",true,out status);
                switch (status)
                {
                    case MembershipCreateStatus.Success:
                        BagisciRepository br = new BagisciRepository();
                        model.BD.ID = Guid.Parse(user.ProviderUserKey.ToString());
                        br.BagisciDetayEkle(model.BD);
                        Roles.AddUserToRole(user.Email, "Bagisci");
                        FormsAuthentication.SetAuthCookie(model.User.Email, false);
                        return RedirectToAction("Index","Bagisci/Panel");
                    case MembershipCreateStatus.InvalidUserName:
                        break;
                    case MembershipCreateStatus.InvalidPassword:
                        break;
                    case MembershipCreateStatus.InvalidQuestion:
                        break;
                    case MembershipCreateStatus.InvalidAnswer:
                        break;
                    case MembershipCreateStatus.InvalidEmail:
                        break;
                    case MembershipCreateStatus.DuplicateUserName:
                        break;
                    case MembershipCreateStatus.DuplicateEmail:
                        break;
                    case MembershipCreateStatus.UserRejected:
                        break;
                    case MembershipCreateStatus.InvalidProviderUserKey:
                        break;
                    case MembershipCreateStatus.DuplicateProviderUserKey:
                        break;
                    case MembershipCreateStatus.ProviderError:
                        break;
                    default:
                        break;
                        

                }
                
              
            }
            else
            {
              ModelState.AddModelError("", "Şifreler Uyuşmuyor");
            }
            List<string> a = new List<string>();
            foreach (var item in ModelState)
            {
                foreach (var item2 in item.Value.Errors)
                {
                    a.Add(item2.ErrorMessage);
                }
            }
            TempData["a"] = a;
            TempData["ModelState"] = ModelState;
            return RedirectToAction("Register");
           

        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult HastaKayit(RegisterViewModel model)
        {
            if (model.User.Password == model.User.ConfirmPassword)
            {
                MembershipCreateStatus status;
                MembershipUser user = Membership.CreateUser(model.User.Email, model.User.Password, model.User.Email, "soru", "cevap", true, out status);
                switch (status)
                {
                    case MembershipCreateStatus.Success:
                        HastaRepository hr = new HastaRepository();
                        model.HD.ID = Guid.Parse(user.ProviderUserKey.ToString());
                        hr.HastaDetayEkle(model.HD);
                        Roles.AddUserToRole(user.Email, "Hasta");
                        return RedirectToAction("Login");
                    case MembershipCreateStatus.InvalidUserName:
                        break;
                    case MembershipCreateStatus.InvalidPassword:
                        break;
                    case MembershipCreateStatus.InvalidQuestion:
                        break;
                    case MembershipCreateStatus.InvalidAnswer:
                        break;
                    case MembershipCreateStatus.InvalidEmail:
                        break;
                    case MembershipCreateStatus.DuplicateUserName:
                        break;
                    case MembershipCreateStatus.DuplicateEmail:
                        break;
                    case MembershipCreateStatus.UserRejected:
                        break;
                    case MembershipCreateStatus.InvalidProviderUserKey:
                        break;
                    case MembershipCreateStatus.DuplicateProviderUserKey:
                        break;
                    case MembershipCreateStatus.ProviderError:
                        break;
                    default:
                        break;
                }

            }
            else
            {
                ModelState.AddModelError("", "Şifreler Uyuşmuyor");
            }
            List<string> a = new List<string>();
            foreach (var item in ModelState)
            {
                foreach (var item2 in item.Value.Errors)
                {
                    a.Add(item2.ErrorMessage);
                }
            }
            TempData["a"] = a;
            TempData["ModelState"] = ModelState;
            return RedirectToAction("Register");
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
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Roles.DeleteCookie();
            Session.Clear();
            return RedirectToAction("Index","Home");
           
        }

    }
}