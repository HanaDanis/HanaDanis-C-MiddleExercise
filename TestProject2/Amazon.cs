using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    internal class Amazon
    {
        private Pages pages;
        private IWebDriver driver;
        public Amazon(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.amazon.com/");
            this.driver = driver;
        }
        public Pages Pages { 
            get 
            { 
                if (this.pages== null)
                {
                    this.pages = new Pages(this.driver);
                }
                return this.pages;
            }
        }



    }
}
