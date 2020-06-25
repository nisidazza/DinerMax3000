﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000.Business
{
    public class Order
    {
        public List<MenuItem> items = new List<MenuItem>();

        public double Total
        {
            // loop through every menu item in the list and calculate the total
            get
            {
                double calculatedTotal = 0;
                foreach (MenuItem item in items) {
                    calculatedTotal += item.Price;
                }
                return calculatedTotal;
            }
        }
    }
}
