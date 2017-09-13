using DomainTest.WrapperFactory;
using OpenQA.Selenium.Support.PageObjects;

namespace DomainTest.PageObjects
{
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(BrowserFactory.Driver, page);
            return page;
        }
        public static DomainPage Domain
        {
            get { return GetPage<DomainPage>(); }
        }

    }
}
