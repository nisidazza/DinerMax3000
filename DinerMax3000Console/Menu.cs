using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    class Menu
    {
        public Menu() {
            items = new List<MenuItem>();

        }

        public void AddMenuItems(string Title, string Description, double Price)
        { 
        }

        public string Name;
        public List<MenuItem> items;
    }
}
