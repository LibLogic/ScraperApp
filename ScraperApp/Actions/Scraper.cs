using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace ScraperApp
{
    class Scraper
    {
        public static List<string> GetScrape(Settings.Yahoo.UserCredentials currentUser)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless");
            IWebDriver driver = new ChromeDriver(options);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Navigate().GoToUrl(Settings.Yahoo.loginPage);

            Login(driver, currentUser);

            driver.Navigate().GoToUrl(Settings.Yahoo.portfolioPage);

            return GetActions.ScrapeData(driver);
        }

        public static void Login(IWebDriver driver, Settings.Yahoo.UserCredentials currentUser)
        {
            SubmitActions.SubmitText(driver, "Id", Settings.Yahoo.loginNameField, currentUser.UserName);
            SubmitActions.SubmitText(driver, "Id", Settings.Yahoo.loginPassField, currentUser.UserPass);
        }
    }
}
