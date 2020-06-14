using System;
using System.Collections.Generic;

namespace Ex04.Menus.Test
{
    public class TestMenu
    {
        public void InitTestMenu()
        {
            
            this.setMenus();
            
        }

        private void setMenus()
        {
            List<Interface.MenuItem> newMenuFromUser = createInterfaceMenu();
            Interface.MainMenu interfaceMenu = new Interface.MainMenu(newMenuFromUser);
            interfaceMenu.Show();
            //Delegate.MainMenu delegateMenu = new Delegate.MainMenu(menuStrings);//??
        }

        private List<Interface.MenuItem> createInterfaceMenu()
        {
            List<Interface.MenuItem> newInterfaceMenu = new List<Interface.MenuItem>();
            List<Interface.MenuItem> versionAndDigitsMenu = new List<Interface.MenuItem>();
            List<Interface.MenuItem> showDateAndTime = new List<Interface.MenuItem>();

            versionAndDigitsMenu.Add(new Interface.ActionMenuItem(new MyActionables(1), "Count Capitals"));
            versionAndDigitsMenu.Add(new Interface.ActionMenuItem(new MyActionables(2), "Show Version"));
            showDateAndTime.Add(new Interface.ActionMenuItem(new MyActionables(3), "Show Time"));
            showDateAndTime.Add(new Interface.ActionMenuItem(new MyActionables(3), "Show Date"));
            newInterfaceMenu.Add(new Interface.OptionsMenuItem(versionAndDigitsMenu, "Version and Digits"));
            newInterfaceMenu.Add(new Interface.OptionsMenuItem(showDateAndTime, "Show Date/Time"));

            return newInterfaceMenu;
        }
    }
}
