using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEDC.Lamazon.WebModels.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please insert first name!")]
        [Display(Name ="Enter first name:")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please insert last name!")]
        [Display(Name = "Enter last name:")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please insert email!")]
        [Display(Name = "Enter email name:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please insert Address!")]
        [Display(Name = "Enter Address:")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please insert username!")]
        [Display(Name = "Enter username:")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Please insert password!")]
        [Display(Name = "Enter password:")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password!")]
        [Display(Name = "Confirm password:")]
        public string ConfirmPassword { get; set; }
    }
}
