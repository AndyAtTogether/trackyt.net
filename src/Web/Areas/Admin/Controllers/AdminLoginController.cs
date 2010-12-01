﻿using System.Web.Mvc;
using Trackyt.Core.Services;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers
{
    public class AdminLoginController : Controller
    {
        private IAuthenticationService _authentication;

        public AdminLoginController(IAuthenticationService auth)
        {
            _authentication = auth;
        }

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login(AdminLogin model)
        {
            if (ModelState.IsValid)
            {
                if (_authentication.Authenticate("Admin", model.Password))
                {
                    return Redirect("~/Admin/AdminDashboard");
                }   
                else
                {
                    return Redirect("~/Admin");
                }
            }

            return View();
        }
    }
}
