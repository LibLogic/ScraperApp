namespace ScraperApp
{
    public class Scrape
    {
        public static void RunScrape(Settings.Yahoo.UserCredentials currentUser)
        {
            var scrapeData = Scraper.GetScrape(currentUser);

            DBActions.WriteTables(scrapeData, "Scrapes", currentUser);
        }
    }
}
