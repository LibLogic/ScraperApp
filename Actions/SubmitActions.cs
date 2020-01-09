using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ScraperApp
{
    class SubmitActions
    {
        public static void SubmitText(IWebDriver driver, string elementType, string element, string value)
        {
            if (elementType == "Id") 
                driver.FindElement(By.Id(element)).SendKeys(value + Keys.Enter);
            
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value + Keys.Enter);
        }
    }
}
