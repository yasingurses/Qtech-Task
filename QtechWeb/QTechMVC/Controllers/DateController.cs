using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QTechMVC.Controllers
{
    public class DateController : Controller
    {
     
        private IUserService _userService;

        public DateController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            var userId = Convert.ToInt32( HttpContext.User.Claims.Where(o => o.Type.ToString() == "Id").Select(o => o.Value).FirstOrDefault());
            var result = _userService.Getir(userId);
            return View(result);
        }
        
        }
}
