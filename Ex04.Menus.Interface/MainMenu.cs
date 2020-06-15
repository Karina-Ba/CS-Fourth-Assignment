using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interface
{
    public class MainMenu : OptionsMenuItem
    {
        public MainMenu(List<MenuItem> i_MenuOptions) : base(i_MenuOptions, "Main menu")
        {
        }
        ///----------------------------------------------------------------///
        protected override MenuItem BackOption()
        {
            return new ActionMenuItem("Exit");
        }
        ///----------------------------------------------------------------///
    }
}
