using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IUserService
    {
        void Register(RegisterViewModel registerModel);
        void LogIn(LoginViewModel loginModel, out bool isAdmin);
        void Logout();
        UserViewModel GetCurrentUser(string username);
    }
}
