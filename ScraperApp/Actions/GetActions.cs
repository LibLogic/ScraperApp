using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using static ScraperConsole.Settings.Yahoo;

namespace ScraperApp
{
    class GetActions
    {
        public static List<string> ScrapeData(IWebDriver driver)
        {
            IWebElement element;
            List<string> tableText = new List<string>();
            string xPath;

            tableText.Add("id");
            tableText.Add("Scrape Time");
            for (int i = 1; i <= 13; i++)
            {
                if (i == 13)
                {
                    xPath = $"//*[@id='pf-detail-table']/div[1]/table/thead/tr/th[{i}]";
                    element = driver.FindElement(By.XPath(xPath));
                    tableText.Add(element.Text + "\n");
                }
                else
                {
                    xPath = $"//*[@id='pf-detail-table']/div[1]/table/thead/tr/th[{i}]";
                    element = driver.FindElement(By.XPath(xPath));
                    tableText.Add(element.Text);
                }
            }

            DateTime time = DateTime.Now;

            IWebElement elementTable = driver.FindElement(By.XPath($"//*[@id='pf-detail-table']/div[1]/table"));
            List<IWebElement> elementRows = new List<IWebElement>(elementTable.FindElements(By.TagName("tr")));

            for (int i = 1; i < elementRows.Count; i++)
            {
                tableText.Add(time.ToString("O"));

                xPath = $"//*[@id='pf-detail-table']/div[1]/table/tbody/tr[{i}]/td[1]/a";
                element = driver.FindElement(By.XPath(xPath));
                tableText.Add(element.Text);


                for (int j = 2; j <= 13; j++)
                {
                    switch (j)
                    {
                        case 10:
                        case 11:
                        case 12:
                            tableText.Add("-");
                            break;
                        case 13:
                            tableText.Add(element.Text + "\n");
                            break;
                        default:
                            xPath = $"//*[@id='pf-detail-table']/div[1]/table/tbody/tr[{i}]/td[{j}]";
                            element = driver.FindElement(By.XPath(xPath));
                            tableText.Add(element.Text.Replace(",", ""));
                            break;
                    }
                }
            }
            driver.Quit();
            return tableText;
        }
    }
}