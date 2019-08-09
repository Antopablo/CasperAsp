﻿using CasperAsp.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasperAsp.Controllers
{
    public class HomeController : Controller
    {
        public MySqlConnection myServerSQL;
        MySqlCommand cmd;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult connect_click(User u)
        {
            // connection mySQL
            myServerSQL = new MySqlConnection("server=137.74.118.171;userid=sta41;persistsecurityinfo=True;password=w5fc03;database=sta41");
            myServerSQL.Open();
            cmd = new MySqlCommand("SELECT Identifiant FROM Users WHERE Identifiant = " + "'" + u.Identifiant + "' AND Password = '" + u.Password + "'", myServerSQL);

            MySqlDataReader reader = cmd.ExecuteReader();

            // dans la BDD
            if (reader.HasRows)
            {
                reader.Close();
                return RedirectToAction("Index", "Projet");
            }
            //Pas trouvé dans la BDD
            else
            {
                reader.Close();
                return View("Index");
            }
        }
    }
}