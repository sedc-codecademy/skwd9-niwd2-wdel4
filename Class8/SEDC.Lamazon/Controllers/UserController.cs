using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;

namespace SEDC.Lamazon.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult LogIn()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult LogIn(LoginViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isAdmin;
                    _userService.LogIn(model, out isAdmin);
                    if (isAdmin)
                    {
                        return RedirectToAction("listallorders", "order");
                    }
                    else
                    {
                        return RedirectToAction("products", "product");
                    }
                }

            }
            catch(Exception ex)
            {
                throw new Exception($"Message: {ex.Message}");
            }
            return View();
        }


        public IActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _userService.Register(model);
                    return RedirectToAction("products", "product");
                }
            }
            catch (Exception ex)
            {

                throw new Exception($"Message: {ex.Message}");
            }
            return View(model);
        }

    }


}
