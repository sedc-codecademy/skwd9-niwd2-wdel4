using Microsoft.AspNetCore.Identity;
using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Enums;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Services
{
    public class UserService : IUserService
    {
        protected readonly IUserRepository _userRepository;
        protected readonly SignInManager<User> _signInManager;
        protected readonly UserManager<User> _userManager;

        public UserService(IUserRepository userRepository,
                           SignInManager<User> signInManager,
                           UserManager<User> userManager)
        {
            _userRepository = userRepository;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public UserViewModel GetCurrentUser(string username)
        {
            try
            {
                User user = _userRepository.GetByUsername(username);
                return new UserViewModel
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Fullname = user.FullName
                };

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void LogIn(LoginViewModel loginModel, out bool isAdmin)
        {
            var result = _signInManager.PasswordSignInAsync(loginModel.Username, loginModel.Password, false, false).Result;
            User user = _userRepository.GetByUsername(loginModel.Username);
            isAdmin = false;

            if (result.Succeeded)
            {
                isAdmin = _userManager.IsInRoleAsync(user, "admin").Result;
            }
            if (result.IsNotAllowed)
            {
                throw new Exception("Username or Password is not correct!");
            }
        }

        public void Logout()
        {
            _signInManager.SignOutAsync();
        }

        public void Register(RegisterViewModel registerModel)
        {
            User user = new User
            {
                UserName = registerModel.Username,
                FullName = String.Format("{0} {1}", registerModel.FirstName, registerModel.LastName),
                Email = registerModel.Email,
                Orders = new List<Order>()
                {
                    new Order
                    {
                        Status = StatusType.Init
                    }
                }
            };

            var password = registerModel.Password;
            var result = _userManager.CreateAsync(user, password).Result;
            bool isAdmin = false;

            if (result.Succeeded)
            {
                var currentUser = _userManager.FindByNameAsync(user.UserName).Result;
                var roleResult = _userManager.AddToRoleAsync(currentUser, "user").Result;
                if (roleResult.Succeeded)
                {
                    LogIn(new LoginViewModel
                    {
                        Username = registerModel.Username,
                        Password = registerModel.Password
                    }, out isAdmin);
                }
                else
                {
                    throw new Exception("Adding user failed");
                }
            }
        }
    }
}
