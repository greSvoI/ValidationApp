using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationApp.Models
{
    public class UserAuthentication
    {
        [Required(ErrorMessage = "ErrorName")]
        [StringLength(50, ErrorMessage = "ErrorName", MinimumLength = 3)]
        [Display(Name="Name")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "ErrorMsgEmail")]
        [Remote(action: "CheckEmail", controller: "Accounts", ErrorMessage = "ErrorMsgEmail")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        
    }
}
