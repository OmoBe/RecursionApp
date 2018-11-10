using System;
using System.Collections.Generic;
using Derivco.Menu;

namespace DerivcoMenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //

            List<MenuItem> _menuItems = MenuItem.DefaultMenu();
            PrintMenu(menuItems: _menuItems);
            Console.ReadKey();
        }




        private static void PrintMenu(List<MenuItem> menuItems, int level = 1)
        {

            string _tab = new String('\t', level);
            foreach (var item in menuItems)
            {
                Console.WriteLine(_tab + item.Name);
                //foreach (List<MenuItem> _subMenu in item.SubMenu)
                PrintMenu(item.SubMenu, level + 1);
            }
        }
    }
}
