using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu newMenu = new Menu();
            newMenu.AddItems();
            newMenu.AddItems();
            newMenu.RemoveItem();
            newMenu.PrintMenu(); 
        }
    }
}
