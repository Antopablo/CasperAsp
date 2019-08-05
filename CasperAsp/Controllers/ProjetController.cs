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
        public List<string> ListeProjet { get; set; }
        // GET: Projet
        public ActionResult Index()
        {
            MySqlConnection myServerSQL = new MySqlConnection("server=137.74.118.171;userid=sta41;persistsecurityinfo=True;password=w5fc03;database=sta41");
            myServerSQL.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Name FROM Projets", myServerSQL);
            MySqlDataReader reader = cmd.ExecuteReader();
            ListeProjet = new List<string>();

            while (reader.Read())
            {
                ListeProjet.Add(reader["Name"].ToString());
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