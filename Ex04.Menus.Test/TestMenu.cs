using System;
using System.Collections.Generic;

namespace Ex04.Menus.Test
{
    public class TestMenu
    {
        private Interface.MainMenu m_InterfaceMenu;
        private Delegate.MainMenu m_DelegateMenu;
        ///----------------------------------------------------------------///
        public void InitTestMenu()
        {
            this.setMenus();   
        }
        ///----------------------------------------------------------------///
        private void setMenus()
        {
            List<Interface.MenuItem> newInterfaceMenu = createInterfaceMenu();
            List<Delegate.MenuItem> newDelegateMenu = createDelegateMenu();

            this.m_InterfaceMenu = new Interface.MainMenu(newInterfaceMenu);
            this.m_DelegateMenu = new Delegate.MainMenu(newDelegateMenu);
            this.m_InterfaceMenu.Show();
            this.m_DelegateMenu.Show();
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
        private List<Delegate.MenuItem> createDelegateMenu()
        {
            List<Delegate.MenuItem> newDelegateMenu = new List<Delegate.MenuItem>();
            List<Delegate.MenuItem> versionAndDigitsMenu = new List<Delegate.MenuItem>();
            List<Delegate.MenuItem> showDateAndTime = new List<Delegate.MenuItem>();
            Delegate.ActionMenuItem actionItem = new Delegate.ActionMenuItem("Count Capitals");

            actionItem.ActionItem += new Delegate.ActionItemEvent(MyActionables.CountCapitals);
            versionAndDigitsMenu.Add(actionItem);
            actionItem = new Delegate.ActionMenuItem("Show Version");
            actionItem.ActionItem += new Delegate.ActionItemEvent(MyActionables.ShowVersion);
            versionAndDigitsMenu.Add(actionItem);
            actionItem = new Delegate.ActionMenuItem("Show Time");
            actionItem.ActionItem += new Delegate.ActionItemEvent(MyActionables.ShowTime);
            showDateAndTime.Add(actionItem);
            actionItem = new Delegate.ActionMenuItem("Show Date");
            actionItem.ActionItem += new Delegate.ActionItemEvent(MyActionables.ShowDate);
            showDateAndTime.Add(actionItem);
            newDelegateMenu.Add(new Delegate.OptionsMenuItem(versionAndDigitsMenu, "Version and Digits"));
            newDelegateMenu.Add(new Delegate.OptionsMenuItem(showDateAndTime, "Show Date/Time"));

            return newDelegateMenu;
        }
    }
}
