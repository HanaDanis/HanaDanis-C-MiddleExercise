using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    internal class Home
    {
        private SearchBar searchBar;
        private IWebDriver driver;
        public Home(IWebDriver driver)
        {
            this.driver = driver;
        }
        public SearchBar SearchBar
        {
            get
            {
                if (this.searchBar == null)
                {
                    this.searchBar = new SearchBar(this.driver);
                }
                return this.searchBar;
            }
        }

    }
}
