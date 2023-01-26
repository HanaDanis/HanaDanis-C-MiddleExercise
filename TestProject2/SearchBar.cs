using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TestProject2
{
    internal class SearchBar
    {
        private IWebDriver driver;

        public SearchBar(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Click()
        {
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
        }
        public string Text
        {
            get { return this.Text; }
            set { driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys(value); }
        }
    }
}