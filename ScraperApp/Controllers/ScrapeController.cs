using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ScraperApp.Controllers
{
    public class ScrapeController : Controller
    {
        string connectionString = @"Data Source=WINDOWS-10; Initial Catalog=WebScraper; Integrated Security=SSPI";
        [HttpGet]
        // GET: Scrape
        public ActionResult Index()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Scrapes";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(dt);
            }
                return View(dt);
        }

        // GET: Scrape/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Scrape/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Scrape/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Scrape/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Scrape/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Scrape/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Scrape/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}