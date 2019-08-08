using CasperAsp.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasperAsp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Users()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Add_validation(User u)
        {
            // connection mySQL
            MySqlConnection myServerSQL = new MySqlConnection("server=137.74.118.171;userid=sta41;persistsecurityinfo=True;password=w5fc03;database=sta41");
            myServerSQL.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Users (Identifiant, Password) VALUES ('"+u.Name +"','"+u.Password+"')", myServerSQL);

            cmd.ExecuteNonQuery();
            myServerSQL.Close();

            return RedirectToAction("Users");
        }
    }
}