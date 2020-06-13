using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interface
{
    public class MainMenu
    {
        List<MenuItem> m_MenuItems; 

        public MainMenu(Dictionary<string, List<string>> i_DictionaryMenuItems)
        {
            this.m_MenuItems = new List<MenuItem>();
            List<string> mainMenuItems;
            bool foundItems = i_DictionaryMenuItems.TryGetValue("Main menu", out mainMenuItems);

            this.m_MenuItems.Add(new MenuItem("Exit", ));
            if (foundItems)
            {
                foreach (string currentString in mainMenuItems)
                {
                    MenuItem menuItem = new MenuItem(currentString,listofactions, );
                }
            }
        }

        public void Show()
        {
            //looop
            //
        }

        //Ctor <- Dictionary
    }
}
