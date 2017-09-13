using NUnit.Framework;
using System.Configuration;
using DomainTest.Utilities;
using DomainTest.WrapperFactory;
using DomainTest.PageObjects;

namespace DomainTest.test
{
    class ValidateTabs
    {
        
        private string URL = ConfigurationManager.AppSettings["URL"];
        private string newHomeTitle = ConfigurationManager.AppSettings["newHomeTitle"];
        private string soldTabTitle = ConfigurationManager.AppSettings["soldTabTitle"];
        private string commercialTabTitle = ConfigurationManager.AppSettings["commercialTabTitle"];
        private string commercialTabLabel = ConfigurationManager.AppSettings["commercialTabLabel"];
        private string AgentTabTitle = ConfigurationManager.AppSettings["AgentTabTitle"];
        private string NewsTabTitle = ConfigurationManager.AppSettings["NewsTabTitle"];
        private string LatestTabTitle = ConfigurationManager.AppSettings["LatestTabTitle"];
        



        [SetUp]
        public void PrepareSetup()
        {
            Log4NetWrapper Logger = new Log4NetWrapper();
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(URL);
        }
        [Test]
        public void TestBuyTab()
        {
            Page.Domain.OnBuyTab("Buy");
        }
        [Test]
        public void TestRentTab()
        {
            Page.Domain.OnRentTab("Rent");
        }
        [Test]
        public void TestNewHomeTab()
        {
            string getTitle=Page.Domain.OnNewHomeTab("Rent");
            Assert.IsTrue(getTitle.Contains(newHomeTitle), "Error::  "+ newHomeTitle + " is not displayed");
        }
        [Test]
        public void TestSoldTab()
        {
            string getTitle = Page.Domain.OnSoldTab("Sold");
            Assert.IsTrue(getTitle.Contains(soldTabTitle), "Error::  " + soldTabTitle + " is not displayed");
        }
        [Test]
        public void TestCommercialTab()
        {
            string getTitle = Page.Domain.OnCommercialTab(commercialTabLabel);
            Assert.IsTrue(getTitle.Contains(commercialTabTitle), "Error::  " + commercialTabTitle + " is not displayed");
        }
        [Test]
        public void TestAgentsTab()
        {
            string getTitle = Page.Domain.OnAgentsTab("Real Estate Agent");
            Assert.IsTrue(getTitle.Contains(AgentTabTitle), "Error::  " + AgentTabTitle + " is not displayed");
        }

        [Test]
        public void TestNewsHomeTab()
        {
            string getTitle = Page.Domain.OnNewsHomeTab("News");
            Assert.IsTrue(getTitle.Contains(NewsTabTitle), "Error::  " + NewsTabTitle + " is not displayed");           
        }

        [Test]
        public void TestNewsLatestTab()
        {
            string getTitle = Page.Domain.OnNewsLatestTab("Latest");
            Assert.IsTrue(getTitle.Contains(LatestTabTitle), "Error::  " + LatestTabTitle + " is not displayed");
        }

        [TearDown]
        public void TearDownSetup()
        {
            BrowserFactory.CloseAllDrivers();
        }

    }
}
