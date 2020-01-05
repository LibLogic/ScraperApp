using static ScraperConsole.Settings.Yahoo;

namespace ScraperApp
{
    public class RunScrape
    {
        public void GetScrape(string user, string pass)
        {
            UserCredentials currentUser = new UserCredentials(user, pass);
            ScraperConsole.Scrape.RunScrape(currentUser); 
        }
    }
}
