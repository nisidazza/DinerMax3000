using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business.dsDinerMax3000TableAdapters;

namespace DinerMax3000.Business
{
    public class Menu
    {
        public Menu() {
            Items = new List<MenuItem>();

        }

        private int _databaseId;

        public void SaveNewMenuItem(string Name, string Description, double Price)
        {
            // new instance of item table adapater
            Menu_ItemTableAdapter taMenuItem = new Menu_ItemTableAdapter();
            taMenuItem.InsertNewMenuItem(Name, Description, Price, _databaseId);
        }

        public static List<Menu> GetAllMenus()
        {
            //create instances
            MenuTableAdapter taMenu = new MenuTableAdapter();
            Menu_ItemTableAdapter taMenuItem = new Menu_ItemTableAdapter();

            
            var dtMenu = taMenu.GetData();
            // list returned by the method
            List<Menu> allMenus = new List<Menu>();

            // iterate through all the menu rows
            foreach(dsDinerMax3000.MenuRow menuRow in dtMenu.Rows)
            {
                Menu currentMenu = new Menu();
                //set the value from row
                currentMenu.Name = menuRow.Name;
                currentMenu._databaseId = menuRow.Id;
                allMenus.Add(currentMenu);

                var dtMenuItems = taMenuItem.GetMenuItemsByMenuId(menuRow.Id);
                foreach (dsDinerMax3000.Menu_ItemRow menuItemRow in dtMenuItems.Rows)
                {
                    currentMenu.AddMenuItems(menuItemRow.Name, menuItemRow.Description, menuItemRow.Price);
                }
            }

            return allMenus;
        }

        public void AddMenuItems(string Title, string Description, double Price)
        {
            MenuItem item = new MenuItem();
            item.Title = Title;
            item.Description = Description;
            item.Price = Price;
            Items.Add(item);
        }

        public string Name { get; set; }
        public List<MenuItem> Items { get; set; }
    }
}
