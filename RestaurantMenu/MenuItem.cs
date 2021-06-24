using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class MenuItem
    {
        public string Category { get; }
        public string ItemName
        { get; }
        public string Description
        { get; set; }
        public double Price { get; set; }

        public MenuItem(string category, string name, string description, double price)
        {
            Category = category;
            ItemName = name;
            Description = description;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            MenuItem i = obj as MenuItem;
            return i.ItemName == ItemName && i.Price == Price && i.Description == Description;
        }
    }
}
