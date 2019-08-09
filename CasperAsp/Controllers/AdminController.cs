using CasperAsp.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        public ActionResult Modify()
        {
            List<User> users = new List<User>();
            using (MySqlConnection myServerSQL = new MySqlConnection("server=137.74.118.171;userid=sta41;persistsecurityinfo=True;password=w5fc03;database=sta41"))
            {
                string query = "SELECT Identifiant, Password FROM Users";
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = myServerSQL;
                    myServerSQL.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            users.Add(new User
                            {
                                Identifiant = sdr["Identifiant"].ToString(),
                                Password = sdr["Password"].ToString()
                            });
                        }
                    }
                    myServerSQL.Close();
                }
            }

            return View(users);
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Add_validation(User u)
        {
            // connection mySQL
            MySqlConnection myServerSQL = new MySqlConnection("server=137.74.118.171;userid=sta41;persistsecurityinfo=True;password=w5fc03;database=sta41");
            myServerSQL.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Users (Identifiant, Password) VALUES ('"+u.Identifiant +"','"+u.Password+"')", myServerSQL);

            cmd.ExecuteNonQuery();
            myServerSQL.Close();

            return RedirectToAction("Users");
        }


    }
}