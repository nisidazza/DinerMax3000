using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //access data from database
            List<Menu> menusFromDatabase = Menu.GetAllMenus();


            Menu firstMenu = menusFromDatabase[0];
            firstMenu.SaveNewMenuItem("Smorgas", "A classic nordic dish.", 10);
            //reload the data
            menusFromDatabase = Menu.GetAllMenus();

            Order hungryGuestOrder = new Order();

            // loops through the menus
            foreach (Menu currentMenu in menusFromDatabase) 
            {
                foreach (MenuItem currentItem in currentMenu.Items)
                {
                    hungryGuestOrder.items.Add(currentItem);
                }
            }

            Console.WriteLine("The total is: " + hungryGuestOrder.Total);
            Console.ReadLine();
        }
    }
}
