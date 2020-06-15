using System;

namespace Ex04.Menus.Delegate
{ 
    public delegate void ChosenMenuItemEvent();

    public abstract class MenuItem
    {
        public event ChosenMenuItemEvent MenuItemChosen;
        private string m_Title;
        ///----------------------------------------------------------------///
        public MenuItem(string i_Title)
        {
            this.m_Title = i_Title;
            this.MenuItemChosen += new ChosenMenuItemEvent(clearScreenPrintTitle);
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
            this.MenuItemChosen?.Invoke();
        }
        ///----------------------------------------------------------------///
        protected virtual MenuItem BackOption()
        {
            return new ActionMenuItem("Back");
        }
        ///----------------------------------------------------------------///
        protected void clearScreenPrintTitle()
        {
            Console.Clear();
            Console.WriteLine(this.m_Title + " :");
            System.Threading.Thread.Sleep(500);

        }
        ///----------------------------------------------------------------///
    }
}
