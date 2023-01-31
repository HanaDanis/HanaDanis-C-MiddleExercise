using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using static TestProject2.Results;

namespace TestProject2
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = BrowserFactory.CreateBroser(BrowserFactory.Browser.Chrome);
        }

        [Test]
        public void test()
        {
            Amazon amazon = new Amazon(driver);
            amazon.Pages.Home.SearchBar.Text="mouse";
            amazon.Pages.Home.SearchBar.Click();
            amazon.Pages.Results.GetResultsBy(new Dictionary<string, string>()
            { {"priceLowerThen","100"},
              {"priceHighOrEqual","10"},
              {"freeShipping","true"}
           });        

            Debug.Assert(true);
            Assert.Pass();
        }
    }
}
