using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTest.WrapperFactory
{
    class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        private static IWebDriver driver;
        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return driver;
            }
            private set
            {
                driver = value;
            }
        }

        public static void InitBrowser()
        {
            //Initilizing Driver
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        public static void LoadApplication(string url)
        {
            driver.Url = url;
        }
        public static void navigateto(string passthroughurl)
        {
            driver.Navigate().GoToUrl(passthroughurl);
        }


        public static void CloseAllDrivers()
        {
            driver.Close();
            driver.Quit();
        }
        public static string getTitle()
        {
            string myTitle=driver.Title;
            return myTitle;
        }

    }
}
