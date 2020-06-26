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
            List<Menu> menusFromDatabase = Menu.GetAllMenus();

            Order hungryGuestOrder = new Order();

            for (int i = 0; i <= summerMenu.items.Count - 1; i++)
            {
                MenuItem currentItem = summerMenu.items[i];
                hungryGuestOrder.items.Add(currentItem);
            }

            foreach (MenuItem currentItem in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(currentItem);
            }

            Console.WriteLine("The total is: " + hungryGuestOrder.Total);

            try
            {
                outsideDrinks.AddMenuItems("Himkok", "9 of 10 peple recommend staying away from this drinks.", -1);
            }
            catch (Exception thrownException)
            {
                Console.WriteLine(thrownException.Message);
            }

            Console.ReadLine();
        }
    }
}
