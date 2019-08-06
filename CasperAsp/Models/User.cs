using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CasperAsp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "Prénom")]
        public string Name { get; set; }

        [Display(Name = "Mot de passe")]
        public string Password { get; set; }
    }
}