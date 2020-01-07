using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ScraperApp.Data;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;

namespace ScraperApp.Controllers
{
    [Authorize]
    public class ScrapeController : Controller
    {
        private readonly ScraperAppContext _db;
        public ScrapeController(ScraperAppContext db)
        {
            _db = db;
        }

        readonly string connectionString = @"Data Source=WINDOWS-10; Initial Catalog=WebScraper; Integrated Security=SSPI";
       
        string latestScrape = "";

        [HttpGet]
        // GET: Scrape
        public ActionResult Index([FromQuery(Name = "scrapeId")] string scrapeId, [FromQuery(Name = "getScrape")] string getScrape, [FromQuery(Name = "stale")] string stale)
        {
            string user = User.Identity.Name;
            string pass = "";

            if (getScrape == "true")
            {
                foreach (var item in _db.Users.ToList())
                {
                    if (item.UserName == user)
                    {
                        pass = item.YahooPassword;
                    }
                }
                RunScrape runscrape = new RunScrape();
                runscrape.GetScrape(user, pass);
            }

            string query = $"SELECT* FROM Scrapes WHERE ScrapeTime = (SELECT ScrapeId FROM Users_Scrapes WHERE ScrapeId = (SELECT MAX(ScrapeId) FROM Users_Scrapes WHERE UserName = '{user}')) ORDER BY Symbol";

            if (scrapeId != null)
            {
                if (stale == "true")
                {
                    ViewBag.status = "stale";
                }
                query = $"SELECT * FROM Scrapes WHERE ScrapeTime = (SELECT ScrapeId FROM Users_Scrapes WHERE Users_Scrapes.id = '{scrapeId}' AND Users_Scrapes.UserName = '{user}') ORDER BY Symbol";
            }

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(dt);
            }
 
            return View(dt);
        }

        public ActionResult History()
        {
            string user = User.FindFirst(ClaimTypes.Name).Value;

            string query1 = $"SELECT* FROM Scrapes WHERE ScrapeTime = (SELECT ScrapeId FROM Users_Scrapes WHERE ScrapeId = (SELECT MAX(ScrapeId) FROM Users_Scrapes WHERE UserName = '{user}'))";
            DataTable dt1 = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter(query1, con);
                sda.Fill(dt1);

                latestScrape = dt1.Rows[dt1.Rows.Count - 1][1].ToString();
            }

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = $"SELECT ScrapeId, id FROM Users_Scrapes WHERE UserName = '{user}' ORDER BY ScrapeId DESC";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(dt);
            }

            ViewBag.latest = latestScrape;
            return View(dt);
        }

        public ActionResult Retrospective()
        {
            return View();
        }

        public ActionResult Fetch()
        {
            return View();
        }
    }
}