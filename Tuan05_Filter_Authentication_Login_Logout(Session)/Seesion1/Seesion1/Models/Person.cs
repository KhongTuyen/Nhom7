using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seesion1.Models
{
    public class Person
    {
        [Key]
        
        public long ID { get; set; }

        [Display(Name ="Full Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Username")]
        [Required]
        public string Username { get; set; }
        [Display(Name = "Password")]
        [Required]
        public string Password { get; set; }
        [Display(Name = "Repassword")]
        [Compare("Password",ErrorMessage="-Isvalid Password")]
        [Required]
        public string Repassword { get; set; }
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }
        public bool Rol { get; set; }

    }
}