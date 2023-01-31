using OpenQA.Selenium;
using System.Reflection;
using TestProject2;

namespace TestProject2
{
    class Results
    {
        private IWebDriver driver;

        public Results(IWebDriver driver)
        {
            this.driver = driver;
        }

        public List<Item> GetResultsBy(Dictionary<String, String> filters)
        {
            List<Item> results = new List<Item>();
            string xpath = "//span[@class = 'a-price'";

            foreach (var filter in filters)
            {
                switch (filter.Key)
                {
                    case "priceLowerThen":
                        xpath += " and concat(descendant::span[@class = 'a-price-whole']//text() ,'.',descendant::span[@class='a-price-fraction']//text()) < " + filter.Value;
                        break;
                    case "priceHighOrEqual":
                        xpath += " and concat(descendant::span[@class = 'a-price-whole']//text() ,'.',descendant::span[@class='a-price-fraction']//text()) >= " + filter.Value;
                        break;
                    case "freeShipping":
                        if (filter.Value != null)
                        {
                            xpath += " and (ancestor::div[@class = 'a-section a-spacing-small a-spacing-top-small']//descendant::span[@class = 'a-color-base a-text-bold'])";
                        }
                        else
                        {
                            xpath += " and not (ancestor::div[@class = 'a-section a-spacing-small a-spacing-top-small']//descendant::span[@class = 'a-color-base a-text-bold'])";
                        }
                        break;
                }
            }

            var filterResult = this.driver.FindElements(By.XPath(xpath + ']'));

            foreach (var filterR in filterResult)
            {
                string title = filterR.FindElement(By.XPath("//*[@class = 'a-size-medium a-color-base a-text-normal']")).Text;
                string url = filterR.FindElement(By.XPath("//a[@class='a-link-normal s-underline-text s-underline-link-text s-link-style a-text-normal']")).GetAttribute("href");
                string price = filterR.Text;
                results.Add(new Item(price, title, url));
            }

            return results;
        }
    }
}



