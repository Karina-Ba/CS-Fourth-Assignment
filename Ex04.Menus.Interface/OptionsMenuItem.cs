﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interface
{
    public class OptionsMenuItem : MenuItem
    {
        private List<MenuItem> m_MenuOptions;
        ///----------------------------------------------------------------///
        public OptionsMenuItem(List<MenuItem> i_MenuOptions, string i_Title) : base(i_Title)
        {
            this.m_MenuOptions = i_MenuOptions;
            this.m_MenuOptions.Insert(0, this.BackOption());
        }
        ///----------------------------------------------------------------///
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
        ///----------------------------------------------------------------///
        public override void Show()
        {
            int lengthOfList = this.m_MenuOptions.Count;
            int userChoiceNumber = -1;

            while (userChoiceNumber != 0)
            {
                base.Show();
                this.printMenuOptions(lengthOfList);
                userChoiceNumber = this.getUserChoiceNumber(0, lengthOfList - 1);
                this.startChosenMenuItem(this.m_MenuOptions[userChoiceNumber]);
            }
        }
        ///----------------------------------------------------------------///
        private void startChosenMenuItem(MenuItem i_UserChoiceMenu)
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
        private void printMenuOptions(int i_ListLenght)
        {
            for (int i = 0; i < i_ListLenght; ++i)
            {
                Console.WriteLine("{0}. {1}", i, this.m_MenuOptions[i].Title);
            }
        }
        ///----------------------------------------------------------------///
        private int getUserChoiceNumber(int i_MinValue, int i_MaxValue)
        {
            int userChoiceNum = 0;
            bool isValidInput = false;
            Console.Write("Please choose what you want to do: ");

            while (!isValidInput)
            {
                string userInput = Console.ReadLine();
                isValidInput = int.TryParse(userInput, out userChoiceNum);

                if (isValidInput && (userChoiceNum < i_MinValue || userChoiceNum > i_MaxValue))
                {
                    Console.Write("Your choice is out of boundarie which are between {0} to {1}, please try again: ",
                        i_MinValue,
                        i_MaxValue);
                    isValidInput = false;
                }
                else if (!isValidInput)
                {
                    Console.Write("Only numbers are allowed as choices, please try again: ");
                }
            }

            return userChoiceNum;
        }
        ///----------------------------------------------------------------///
    }
}