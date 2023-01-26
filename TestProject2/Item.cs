using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    internal class Item
    {

        private string Title { get; set; }
        private string Link { get; set; }
        private string Price { get; set; }
        public Item(string price, string title, string link)
        {
            this.Title = title;
            this.Link = link;
            this.Price = price.Replace("$", "").Replace("\r\n", ".");
        }
    }

}
