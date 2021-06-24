using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    //This code is both 18 and 19 Studio
    class Menu
    {
        private List<MenuItem> menu = new List<MenuItem>();
        private DateTime currentMenu = DateTime.Now;

        public void AddItems()
        {
            Console.WriteLine("Please enter category: ");
            string category = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter a item: ");
            string itemName = Console.ReadLine();
            Console.WriteLine("Please enter a description: ");
            string descrip = Console.ReadLine();
            Console.WriteLine("Please enter a price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            MenuItem item = new MenuItem(category,itemName, descrip, price);
            if (!menu.Contains(item))
            {
                
                currentMenu = DateTime.Now;
                menu.Add(item);
                DateTime afterAdd = DateTime.Now;
                int newIt = DateTime.Compare(currentMenu, afterAdd);  
                if(newIt < 0)
                {
                    string newItem = "(New)";
                }
                
            }
            
        }

        public void RemoveItem()
        {
            Console.WriteLine("Enter item to remove: ");
            var itemRemoveName = Console.ReadLine();

            foreach (MenuItem item in menu)
            {
                if (item.ItemName == itemRemoveName)
                {
                    menu.Remove(item);
                    currentMenu = DateTime.Now;
                    break;
                }
            }
        }

        public void PrintMenu()
        {
            foreach(MenuItem item in menu)
            {
                if(item.Category == "appetizer")
                {
                    Console.WriteLine("\t\t\t\t\t Appetizers \t\t\t");
                    Console.WriteLine($"{item.ItemName}\t\t {item.Price}\n {item.Description}");
                }
                if(item.Category == "main")
                {
                    Console.WriteLine("\t\t\t\t\t Main Dishes \t\t\t");
                    Console.WriteLine($"{item.ItemName}\t\t\t{item.Price}\n {item.Description}");
                }
                if (item.Category == "desserts")
                {
                    Console.WriteLine("\t\t\t\t\t Desserts a.k.a.(stressed) \t\t\t");
                    Console.WriteLine($"{item.ItemName}\t\t\t{item.Price}\n {item.Description}");
                }
            }
        }

    }
}
