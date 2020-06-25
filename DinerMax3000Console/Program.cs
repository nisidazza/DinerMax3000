﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer Menu";
            summerMenu.AddMenuItems("Salmon", "Fresh Norwegian Salmon with Sandefjord butter.", 25.50);
            summerMenu.AddMenuItems("Taco", "All Norwegians eat taco on Fridays.", 10);
            summerMenu.HospitalDirections = "Right around the corner of 5th street. Ask for Dr. Jones";


            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and code.";
            outsideDrinks.AddMenuItems("Virgin Cuba Libre", "A classic", 10);
            outsideDrinks.AddMenuItems("Screwdriver", "Makes you hammered", 15);

            Order hungryGuestOrder = new Order();

            for (int i=0; i<=summerMenu.items.Count - 1; i++)
            {
                MenuItem currentItem = summerMenu.items[i];
                hungryGuestOrder.items.Add(currentItem);
            }

            foreach (MenuItem currentItem in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(currentItem);
            }
        }
    }
}
