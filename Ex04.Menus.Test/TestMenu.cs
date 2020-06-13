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
            Dictionary<string, List<string>> menuStrings;

            createStringsForMenus(out menuStrings);
            Interface.MainMenu intefaceMenu = new Interface.MainMenu(menuStrings);//??
            Delegate.MainMenu delegateMenu = new Delegate.MainMenu(menuStrings);//??
        }

        private void createStringsForMenus(out Dictionary<string, List<string>> o_MenuStringsDictionary)
        {
            List<string> mainMenuItems = new List<string>();
            List<string> versionAndDigitsMenuItems = new List<string>();
            List<string> showDateOrTimeMenuItems = new List<string>();
            o_MenuStringsDictionary = new Dictionary<string, List<string>>();

            mainMenuItems.Add("Version and Digits");
            mainMenuItems.Add("Show Date/Time");
            o_MenuStringsDictionary.Add("Main menu", mainMenuItems);
            versionAndDigitsMenuItems.Add("Count Capitals");
            versionAndDigitsMenuItems.Add("Show Version");
            o_MenuStringsDictionary.Add("Version and Digits", versionAndDigitsMenuItems);
            showDateOrTimeMenuItems.Add("Show Time");
            showDateOrTimeMenuItems.Add("Show Date");
            o_MenuStringsDictionary.Add("Show Date/Time", showDateOrTimeMenuItems);
        }
    }
}
