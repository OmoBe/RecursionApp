using System;
using System.Collections.Generic;

namespace Menus
{
    public class MenuItem
    {
        public MenuItem(string name)
        {
            Name = name;
            SubMenu = new List<MenuItem>();
        }
        public string Name { get; }
        public List<MenuItem> SubMenu = null;


        public static List<MenuItem> DefaultMenu()
        {
            List<MenuItem> menus = new List<MenuItem>();
            //Create the 2 top level Menu Items
            MenuItem _item = new MenuItem("Administration");
            menus.Add(_item);

            //User Admin menu items
            _item.SubMenu.Add(new MenuItem("User Admin"));
            _item.SubMenu[0].SubMenu.Add(new MenuItem("Create User"));
            _item.SubMenu[0].SubMenu.Add(new MenuItem("Edit User"));

            //Product Admin menu items
            _item.SubMenu.Add(new MenuItem("Product Admin"));
            _item.SubMenu[1].SubMenu.Add(new MenuItem("All Products"));
            _item.SubMenu[1].SubMenu[0].SubMenu.Add(new MenuItem("My Products"));
            _item.SubMenu[1].SubMenu.Add(new MenuItem("Create Product"));

            //Order Admin menu item
            _item.SubMenu.Add(new MenuItem("Order Admin"));
            _item.SubMenu[2].SubMenu.Add(new MenuItem("Order Reports"));
            _item.SubMenu[2].SubMenu[0].SubMenu.Add(new MenuItem("Audit Reports"));
            _item.SubMenu[2].SubMenu[0].SubMenu[0].SubMenu.Add(new MenuItem("Updated Orders"));
            _item.SubMenu[2].SubMenu[0].SubMenu[0].SubMenu.Add(new MenuItem("Created Orders"));
            _item.SubMenu[2].SubMenu.Add(new MenuItem("Create Order"));

            _item = new MenuItem("Reports");
            menus.Add(_item);
            _item.SubMenu.Add(new MenuItem("Win Tech Report"));
            menus[1].SubMenu.Add(new MenuItem("Microsoft Report"));

            return menus;
        }

    }
}
