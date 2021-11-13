using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using Serilog;

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
                    Log.Debug("Authenticating user with username {username}:", model.Username);
                    _userService.LogIn(model, out isAdmin);
                    if (isAdmin)
                    {
                        Log.Debug("User with username {username} succesfully logged in as Admin", model.Username);
                        return RedirectToAction("listallorders", "order");
                    }
                    else
                    {
                        Log.Debug("User with username {username} succesfully logged in as Customer", model.Username);
                        return RedirectToAction("products", "product");
                    }
                }

            }
            catch(Exception ex)
            {
                Log.Error("Message: {message}", ex.Message);
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
                    Log.Information($"New user is registered with username: {model.Username}");
                    _userService.Register(model);
                    return RedirectToAction("products", "product");
                }
            }
            catch (Exception ex)
            {

                Log.Error($"Message: {ex.Message}");
            }
            return View(model);
        }

        public IActionResult LogOut()
        {
            _userService.Logout();
            return RedirectToAction("index", "home");
        }
    }


}
