using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    public class BrowserFactory
    {
        public enum Browser
        {
            Firefox,
            Chrome,
            Edge
        }

        public static IWebDriver CreateBroser(Browser browser)
        {
            IWebDriver driver;
            switch (browser)
            {
                case Browser.Chrome:
                    driver = new ChromeDriver();
                    break;
                case Browser.Firefox:
                    driver = new FirefoxDriver();
                    break;
                case Browser.Edge:
                default:
                    driver = new EdgeDriver();
                    break;
            }
            return driver;
        }

    }
}
