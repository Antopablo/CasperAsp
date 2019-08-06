using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasperAsp.Controllers
{
    public class ProjetController : Controller
    {
        // GET: Projet
        public ActionResult Index()
        {
            MySqlConnection myServerSQL = new MySqlConnection("server=137.74.118.171;userid=sta41;persistsecurityinfo=True;password=w5fc03;database=sta41");
            myServerSQL.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Name FROM Projets", myServerSQL);
            MySqlDataReader reader = cmd.ExecuteReader();

            int compteur = 0;
            while (reader.Read())
            {
                TempData["Projets" + compteur] += reader["Name"].ToString();
                compteur++;
            }
            reader.Close();
           
            return View("SelectProjet");
        }

        public ActionResult SelectProjet()
        {
            return View();
        }          
    }
}