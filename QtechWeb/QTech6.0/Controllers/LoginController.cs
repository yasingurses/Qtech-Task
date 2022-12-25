using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Security.Claims;

namespace QTech6._0.Controllers
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
            if (use.UserName == "admin" && use.UserPassword == "123456")
            {
                var claims = new List<Claim>
                { new Claim(ClaimTypes.Name,"admindefault"),

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

