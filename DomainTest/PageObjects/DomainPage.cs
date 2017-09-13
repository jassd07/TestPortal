using DomainTest.Extensions;
using DomainTest.WrapperFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;



namespace DomainTest.PageObjects
{
    public class DomainPage
    {
        [FindsBy(How = How.Id, Using = "react-select-2--value-item")]
        [CacheLookup]
        private IWebElement DropDownLabel { get; set; }

        [FindsBy(How = How.LinkText, Using = "Rent")]
        [CacheLookup]
        private IWebElement SelectRent { get; set; }

        [FindsBy(How = How.LinkText, Using = "New homes")]
        [CacheLookup]
        private IWebElement SelectHomes { get; set; }

        [FindsBy(How = How.LinkText, Using = "Sold")]
        [CacheLookup]
        private IWebElement SelectSold { get; set; }

        [FindsBy(How = How.LinkText, Using = "Commercial")]
        [CacheLookup]
        private IWebElement SelectCommercial { get; set; }

        [FindsBy(How = How.ClassName, Using = "homepage-tag-line")]
        [CacheLookup]
        private IWebElement TagLine { get; set; }

        [FindsBy(How = How.LinkText, Using = "Agents")]
        [CacheLookup]
        private IWebElement SelectAgents { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='skip-link-content']/h1/span[2]")]
        [CacheLookup]
        private IWebElement LabelAgents { get; set; }

        [FindsBy(How = How.LinkText, Using = "News")]
        [CacheLookup]
        private IWebElement SelectNews { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='homepage']/div/div/div[1]/header/div[1]/div/nav/ul/li[6]/ul/li[1]/a")]
        [CacheLookup]
        private IWebElement SelectHome { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='main']/div[1]/header/h1")]
        [CacheLookup]
        private IWebElement NewsHeader { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='homepage']/div/div/div[1]/header/div[1]/div/nav/ul/li[6]/ul/li[2]/a")]
        [CacheLookup]
        private IWebElement SelectLatest { get; set; }
        
        public void OnBuyTab(string label)
        {
            DropDownLabel.IsDisplayed(label);
        }

        public void OnRentTab(string label)
        {
            SelectRent.ClickOnIt("Rent Link");
            DropDownLabel.IsDisplayed(label);
        }

        public string OnNewHomeTab(string label)
        {
            SelectHomes.ClickOnIt("Home Link");            
            return BrowserFactory.getTitle();
        }

        public string OnSoldTab(string label)
        {
            SelectSold.ClickOnIt("Sold Link");
            DropDownLabel.IsDisplayed(label);
            return BrowserFactory.getTitle();
        }
        public string OnCommercialTab(string label)
        {
            SelectCommercial.ClickOnIt("Commercial Link");
            TagLine.IsDisplayed(label);
            return BrowserFactory.getTitle();
        }
        public string OnAgentsTab(string label)
        {
            SelectAgents.ClickOnIt("Agent Link");
            LabelAgents.IsDisplayed(label);
            return BrowserFactory.getTitle();
        }
        public string OnNewsHomeTab(string label)
        { 
            
            SelectNews.ClickOnIt("News Link");
            SelectHome.ClickOnIt("News Home Link");
            NewsHeader.IsDisplayed(label);
            return BrowserFactory.getTitle();
        }
        public string OnNewsLatestTab(string label)
        {

            SelectNews.ClickOnIt("News Link");
            SelectLatest.ClickOnIt("News Latest Link");
            NewsHeader.IsDisplayed(label);
            return BrowserFactory.getTitle();
        }



    }
}
