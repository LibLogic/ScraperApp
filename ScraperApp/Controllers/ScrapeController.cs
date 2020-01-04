using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ScraperApp.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Claims;

namespace ScraperApp.Controllers
{
    [Authorize]
    public class ScrapeController : Controller
    {
        private readonly ScraperAppContext _application;
        public ScrapeController(ScraperAppContext application)
        {
            _application = application;
        }

        readonly string connectionString = @"Data Source=WINDOWS-10; Initial Catalog=WebScraper; Integrated Security=SSPI";

        [HttpGet]
        // GET: Scrape
        public ActionResult Index ([FromQuery(Name = "scrapeId")] string scrapeId)
        {
            //RunScrape runscrape = new RunScrape();
            //runscrape.GetScrape();
            string user = User.FindFirst(ClaimTypes.Name).Value;
            //string query = $"SELECT * FROM Scrapes WHERE ScrapeTime = (SELECT ScrapeId FROM Users_Scrapes WHERE ScrapeId = (SELECT MAX(ScrapeId) FROM Users_Scrapes) AND Users_Scrapes.UserName = '{user}')";

            string query = $"SELECT* FROM Scrapes WHERE ScrapeTime = (SELECT ScrapeId FROM Users_Scrapes WHERE ScrapeId = (SELECT MAX(ScrapeId) FROM Users_Scrapes WHERE UserName = '{user}'))";
            
            if (scrapeId != null)
            {
                query = $"SELECT * FROM Scrapes WHERE ScrapeTime = (SELECT ScrapeId FROM Users_Scrapes WHERE Users_Scrapes.id = '{scrapeId}' AND Users_Scrapes.UserName = '{user}')";
            }

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
 
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(dt);
            }
            return View(dt);
        }

        private object DateTime(string v)
        {
            throw new NotImplementedException();
        }

        public ActionResult History()
        {
            string user = User.FindFirst(ClaimTypes.Name).Value;

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = $"SELECT ScrapeId, id FROM Users_Scrapes WHERE UserName = '{user}'";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(dt);
            }
            return View(dt);
        }
    }
}