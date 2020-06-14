using System;
using System.Collections.Generic;

namespace Ex04.Menus.Test
{
    public class TestMenu
    {
        Interface.MainMenu m_InterfaceMenu;
        Delegate.MainMenu m_DelegateMenu;
        ///----------------------------------------------------------------///
        public void InitTestMenu()
        {
            this.setMenus();   
        }
        ///----------------------------------------------------------------///
        private void setMenus()
        {
            List<Interface.MenuItem> newMenuFromUser = createInterfaceMenu();
            this.m_InterfaceMenu = new Interface.MainMenu(newMenuFromUser);
            //this.m_DelegateMenu = new Delegate.MainMenu(menuStrings);//?? create this
            this.m_InterfaceMenu.Show();
        }
        ///----------------------------------------------------------------///
        private List<Interface.MenuItem> createInterfaceMenu()
        {
            List<Interface.MenuItem> newInterfaceMenu = new List<Interface.MenuItem>();
            List<Interface.MenuItem> versionAndDigitsMenu = new List<Interface.MenuItem>();
            List<Interface.MenuItem> showDateAndTime = new List<Interface.MenuItem>();

            versionAndDigitsMenu.Add(new MyActionables(1, "Count Capitals"));
            versionAndDigitsMenu.Add(new MyActionables(2, "Show Version"));
            showDateAndTime.Add(new MyActionables(3, "Show Time"));
            showDateAndTime.Add(new MyActionables(4, "Show Date"));
            newInterfaceMenu.Add(new Interface.OptionsMenuItem(versionAndDigitsMenu, "Version and Digits"));
            newInterfaceMenu.Add(new Interface.OptionsMenuItem(showDateAndTime, "Show Date/Time"));

            return newInterfaceMenu;
        }
        ///----------------------------------------------------------------///
    }
}
