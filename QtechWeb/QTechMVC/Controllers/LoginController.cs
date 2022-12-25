using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QTechMVC.Controllers
{
    public class LoginController : Controller
    {

        UserMan um = new UserMan(new UserRepo());
        private readonly IToastNotification _toastNotification;

        public LoginController(IToastNotification toastNotification)
        {
            _toastNotification = toastNotification;
        }

        [HttpGet]
        public IActionResult Index(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View();
             

        }
        [HttpPost]
        public async Task<IActionResult> Index(Users use)
        {
            Context c = new Context();
            var admin = c.users.FirstOrDefault(x => x.UserName == use.UserName && x.UserPassword == use.UserPassword);
            if (admin != null)
            {
                var claims = new List<Claim>
                { new Claim(ClaimTypes.Name,admin.UserName),
                   new Claim("Id",admin.UserID.ToString())
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                _toastNotification.AddSuccessToastMessage("Başarılı giriş");
                if (TempData["returnUrl"] != null)
                {
                    if (Url.IsLocalUrl(TempData["returnUrl"].ToString()))
                    {
                        return Redirect(TempData["returnUrl"].ToString());
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Date");
                }

            }
             
            _toastNotification.AddErrorToastMessage("Bilgileriniz yanlış");
            return View();

        }
    }
}
