using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ScraperConsole
{
    public class Tests
    {

        readonly IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void BrowserLogin()
        {
            Settings.Yahoo.UserCredentials currentUser = new Settings.Yahoo.UserCredentials("hdgknsn@gmail.com", "Lino@7196");

            driver.Navigate().GoToUrl(Settings.Yahoo.loginPage);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
           
            driver.FindElement(By.Id(Settings.Yahoo.loginNameField)).SendKeys(currentUser.UserName + Keys.Enter);

            driver.FindElement(By.Id(Settings.Yahoo.loginPassField)).SendKeys(currentUser.UserPass + Keys.Enter);

            driver.Navigate().GoToUrl(Settings.Yahoo.portfolioPage);
        }

        public static SqlConnection conn;
        [Test]
        public void OpenConnection()
        {
            conn = new SqlConnection(@"Data Source=WINDOWS-10; Initial Catalog=WebScraper; Integrated Security=SSPI");
            conn.Open();
        }

        [Test]
        public static void ReadTable()
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM Scrape", conn);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}",
                                        reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7],
                                        reader[8], reader[9], reader[10], reader[11], reader[12], reader[13]);
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        [Test]
        public void ScrapeData()
        {
            IWebElement element;
            List<string> innerText = new List<string>();
            string xPath;

            for (int i = 1; i <= 9; i++)
            {
                xPath = $"//*[@id='pf-detail-table']/div[1]/table/thead/tr/th[{i}]";

                element = driver.FindElement(By.XPath(xPath));
                innerText.Add(element.Text);
            }

            for (int i = 1; i <= 10; i++)
            {
                xPath = $"//*[@id='pf-detail-table']/div[1]/table/tbody/tr[{i}]/td[1]/a";

                element = driver.FindElement(By.XPath(xPath));
                innerText.Add(element.Text);

                for (int j = 2; j <= 9; j++)
                {
                    xPath = $"//*[@id='pf-detail-table']/div[1]/table/tbody/tr[{i}]/td[{j}]";

                    element = driver.FindElement(By.XPath(xPath));
                    innerText.Add(element.Text);
                }
            }
            System.IO.File.WriteAllLines(@"C:\Users\Tom\Desktop\Development\CapstoneProject\WebScraperNet\tableData.txt", innerText);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}