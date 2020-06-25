using System;
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
        }
    }
}
