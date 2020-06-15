using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interface
{ 
    public abstract class MenuItem 
    {
        private string m_Title;
        ///----------------------------------------------------------------///
        public MenuItem(string i_Title)
        {
            this.m_Title = i_Title;
        }
        ///----------------------------------------------------------------///
        public string Title
        {
            get
            {
                return this.m_Title;
            }
            set
            {
                this.m_Title = value;
            }
        }
        ///----------------------------------------------------------------///
        public virtual void Show()
        {
            Console.Clear();
            Console.WriteLine(this.m_Title + " :");
        }
        ///----------------------------------------------------------------///
        protected virtual MenuItem BackOption()
        {
            return new ActionMenuItem("Back");
        }
        ///----------------------------------------------------------------///
        protected void StartChosenMenuItem(MenuItem i_UserChoiceMenu)
        {
            if (i_UserChoiceMenu is OptionsMenuItem)
            {
                (i_UserChoiceMenu as OptionsMenuItem).Show();
    }
            else
            {
                (i_UserChoiceMenu as ActionMenuItem).DoMenuItemAction();
}
        }
        ///----------------------------------------------------------------///
    }
}
