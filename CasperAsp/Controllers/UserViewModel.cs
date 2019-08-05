using CasperAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CasperAsp.Controllers
{
    public class UserViewModel
    {
        public User Utilisateur { get; set; }
        public bool Authentifie { get; set; }
    }
}