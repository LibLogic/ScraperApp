﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using ScraperApp.Areas.Identity.Data;
using static ScraperConsole.Settings.Yahoo;

namespace ScraperApp
{
    public class RunScrape
    {
        public void GetScrape()
        {

  

            string userId = "hdgknsn@gmail.com"; // get these from db
            string pass = "Lino@7196";

            UserCredentials currentUser = new UserCredentials(userId, pass);

            ScraperConsole.Scrape.RunScrape(currentUser); 
        }
    }
}