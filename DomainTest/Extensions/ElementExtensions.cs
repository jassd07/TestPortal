using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTest.Extensions
{
    public static class ElementExtensions
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void IsDisplayed(this IWebElement element, string elementName)
        {

            int counter = 1;
            bool result = IsPresent.IsElementPresent(element);
            while (result == false & counter < 3)
            {
                result = IsPresent.IsElementPresent(element);
                counter++;
            }

            try
            {
                if (result == true)
                {
                    var data = element.Text;
                    Assert.IsTrue(data.Contains(elementName), "Error:: " + elementName + " is not displayed");
                    log.Info($"PASS:: {elementName}  is displayed on portal");
                    
                }
                else
                {
                    var data = element.Text;
                    Assert.IsTrue(data.Contains(elementName), "Error:: " + elementName + " is not displayed");

                }
            }
            catch (Exception ex)
            {
                log.Fatal($" {elementName} {ex} occured");
                throw ex;
            }
        }
        public static void ClickOnIt(this IWebElement element, string elementName)
        {
            int counter = 1;
            bool result = IsPresent.IsElementPresent(element);
            while (result == false & counter < 4)
            {
                result = IsPresent.IsElementPresent(element);
                counter++;
            }

            if (result == true)
            {
                element.Click();
                log.Info($"PASS:: Clicked on {elementName}");                
            }
            else
            {
                log.Fatal($"Failed to Click on {elementName} ");                
            }
        }
    }
        public static class IsPresent
        {
            public static bool IsElementPresent(this IWebElement element)
            {
                try
                {
                    return element.Displayed;
                }
                catch (Exception ex)
                {
                    System.Threading.Thread.Sleep(1000);
                    return false;
                    throw ex;
                }
            }
        }
    
}
