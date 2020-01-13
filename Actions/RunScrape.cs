namespace ScraperApp
{
    public class RunScrape
    {
        public static void GetScrape(string user, string pass)
        {
            Settings.Yahoo.UserCredentials currentUser = new Settings.Yahoo.UserCredentials(user, pass);
            Scrape.RunScrape(currentUser); 
        }
    }
}
