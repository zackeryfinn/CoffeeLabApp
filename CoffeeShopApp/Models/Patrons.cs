using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeShopApp.Models
{
    public class Patrons
    {
        public enum Drinks
        {
            Coffee, Espresso, Tea, Cappuccino, Latte, Americano, Other
        }

        public int PatronID { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter at least 8 charaters")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage ="You must enter at least 8 characters")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage ="The passwords must match")] 
        [Display(Name = "Re-enter your password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Required field")]
        public string Email { get; set; }

        [Compare("Email", ErrorMessage ="The emails you entered do not match")]
        [Display(Name = "Re-enter your email address")]
        [DataType(DataType.EmailAddress)]
        public string ConfirmEmail { get; set; }

       

        }
    }
