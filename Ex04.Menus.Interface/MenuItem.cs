using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interface
{ 
    public class MenuItem 
    {
        private List<MenuItem> m_MenuItems;
        private object m_MenuItemEvent;

        public MenuItem(List<MenuItem> i_MenuItems, io i_MenuItemEvent)
        {
            this.m_MenuItems = i_MenuItems;
            this.m_MenuItemEvent = i_MenuItemEvent;

            (i_MenuItemEvent as )
        }


        interface io
        {
            void apple();
        }


        //user create;
        class pio : io
        {
            public void apple()
            {
                string n = "Hi";
            }
        }


        
    }
}
