using System;

namespace Ex04.Menus.Interface
{
    public class ActionMenuItem : MenuItem, IActionable
    {
        ///----------------------------------------------------------------///
        public ActionMenuItem(string i_Title) : base(i_Title)
        {
        }
        ///----------------------------------------------------------------///
        public virtual void DoMenuItemAction()
        {
            Show();
            System.Threading.Thread.Sleep(500);
        }
        ///----------------------------------------------------------------///
    }
}
