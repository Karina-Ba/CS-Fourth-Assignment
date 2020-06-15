using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegate
{
    public delegate void ActionItemEvent(); 

    public class ActionMenuItem : MenuItem 
    {
        public event ActionItemEvent ActionItem;
        ///----------------------------------------------------------------///
        public ActionMenuItem(string i_Title) : base(i_Title)
        {
        }
        ///----------------------------------------------------------------///
        public void DoAction()
        {
            Show();
            this.ActionItem?.Invoke();
        }
    }
}
