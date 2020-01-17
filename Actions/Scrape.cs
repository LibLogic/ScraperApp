namespace ScraperApp
{
    public class Scrape
    {
        public static void RunScrape(Settings.Yahoo.UserCredentials currentUser, string UserId)
        {

        var scrapeData = Scraper.GetScrape(currentUser);

            DBActions.WriteTables(scrapeData, "Scrapes", currentUser, UserId);
        }
    }
}
