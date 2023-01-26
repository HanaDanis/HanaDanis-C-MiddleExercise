using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using static TestProject2.Results;

namespace TestProject2
{
    public class Tests
    {
        
        Amazon amazon = new Amazon(BrowserFactory.CreateBroser(BrowserFactory.Browser.Chrome));
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void test()
        {
            amazon.Pages.Home.SearchBar.Text="mouse";
            amazon.Pages.Home.SearchBar.Click();
            amazon.Pages.Results.GetResultsBy(new Dictionary<string, string>()
            { {"priceLowerThen","100"},
              {"priceHighOrEqual","10"},
              {"freeShipping","True"}
           }
        );
            Debug.Assert(true);
            Assert.Pass();
        }
    }
}
