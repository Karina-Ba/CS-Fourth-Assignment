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

        public MenuItem(string i_Title)
        {
            this.m_Title = i_Title;
        }

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
        public virtual void Show()
        {
            Console.Clear();
            Console.WriteLine(this.m_Title + " :");
        }

        public virtual MenuItem BackOption()
        {
            return new ActionMenuItem(null, "Back");
        }
    }

    public class OptionsMenuItem : MenuItem
    {
        private List<MenuItem> m_MenuOptions;

        public OptionsMenuItem(List<MenuItem> i_MenuOptions, string i_Title) : base(i_Title)
        {
            this.m_MenuOptions = i_MenuOptions;
            this.m_MenuOptions.Insert(0, this.BackOption());
                
        }

        public List<MenuItem> MenuOptions
        {
            get
            {
                return this.m_MenuOptions;
            }
            set
            {
                this.m_MenuOptions = value;
            }
        }

        public override void Show()
        {
            int lengthOfList = this.m_MenuOptions.Count;
            int userChoiceNumber = -1;

            while(userChoiceNumber != 0)
            {
                base.Show();
                this.printMenuOptions(lengthOfList);
                userChoiceNumber = this.getUserChoiceNumber(0, lengthOfList - 1);
                this.initOption(this.m_MenuOptions[userChoiceNumber]);
            }
        }

        private void initOption(MenuItem i_UserChoiceMenu)
        {
            if (i_UserChoiceMenu is OptionsMenuItem)
            {
                (i_UserChoiceMenu as OptionsMenuItem).Show();
            }
            else
            {
                (i_UserChoiceMenu as ActionMenuItem).StartAction();
            }
        }

        private void printMenuOptions(int i_ListLenght)
        {
            for (int i = 0; i < i_ListLenght; ++i)
            {
                Console.WriteLine("{0}. {1}", i, this.m_MenuOptions[i].Title);
            }
        }

        private int getUserChoiceNumber(int i_MinValue, int i_MaxValue)
        {
            int userChoiceNum = 0;
            bool isValidInput = false;
            Console.Write("Please choose an option: ");
            string userInput = Console.ReadLine();

            while(!isValidInput)
            {
                isValidInput = int.TryParse(userInput, out userChoiceNum);

                if (isValidInput && (userChoiceNum < i_MinValue || userChoiceNum > i_MaxValue))
                {
                    Console.Write("Your choice is out of boundarie which are between {0} to {1}, please try again: ", 
                        i_MinValue,
                        i_MaxValue);
                    userInput = Console.ReadLine();
                    isValidInput = false;
                }
                else if (!isValidInput)
                {
                    Console.Write("Only numbers are allowed as choices, please try again: ");
                    userInput = Console.ReadLine();
                }
            }

            return userChoiceNum;
        }
    }

    public class ActionMenuItem : MenuItem
    {
        IActionable m_MenuItemAction;

        public IActionable MenuItemAction
        {
            get
            {
                return this.m_MenuItemAction;
            }
            set
            {
                this.m_MenuItemAction = value;
            }
        }

        public ActionMenuItem(IActionable i_Action, string i_Title) : base(i_Title)
        {
            this.m_MenuItemAction = i_Action;
        }

        public void StartAction()
        {
            base.Show();
            System.Threading.Thread.Sleep(2000);

            if (this.m_MenuItemAction != null)
            {
                this.m_MenuItemAction.DoChosenOption();
            }
        }

        public interface IActionable
        {
            void DoChosenOption();
        }
    }
}
