using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
