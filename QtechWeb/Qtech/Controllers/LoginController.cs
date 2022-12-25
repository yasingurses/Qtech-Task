using BusinessLayer.Concrete;
using DataAccesLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace Qtech.Controllers
{
    public class LoginController : Controller
    {
        UserMan um = new UserMan(new UserRepo());
        private readonly IToastNotification _toastNotification;

        public LoginController(IToastNotification toastNotification)
        {
            _toastNotification = toastNotification;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
