using CasperAsp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CasperAsp.Controllers
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> UserDatabase { get; set; }
    }
}