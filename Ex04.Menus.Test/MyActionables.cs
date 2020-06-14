using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class MyActionables : Interface.ActionMenuItem
    {
        private int m_ActionNumber;
        ///----------------------------------------------------------------///
        public MyActionables(int i_ActionNumber, string i_Title) : base(i_Title)
        {
            this.m_ActionNumber = i_ActionNumber;
        }
        ///----------------------------------------------------------------///
        public override void DoMenuItemAction()
        {
            base.DoMenuItemAction();

            switch (this.m_ActionNumber)
            {
                case 1:
                    this.countCapitals();
                    break;
                case 2:
                    this.showVersion();
                    break;
                case 3:
                    this.showTime();
                    break;
                case 4:
                    this.showDate();
                    break;
            }
        }
        ///----------------------------------------------------------------///
        private void countCapitals()
        {
            int numOfUpper = 0;
            Console.WriteLine("Please enter a string:");
            string userInputString = Console.ReadLine();

            foreach(char currentChar in userInputString)
            {
                if(char.IsUpper(currentChar))
                {
                    ++numOfUpper;
                }
            }

            Console.WriteLine("There are {0} capital letters in your string", numOfUpper);
            System.Threading.Thread.Sleep(2000);
        }
        ///----------------------------------------------------------------///
        private void showVersion()
        {
            Console.WriteLine("Version: 20.2.4.30620");
            System.Threading.Thread.Sleep(2000);
        }
        ///----------------------------------------------------------------///
        private void showTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            System.Threading.Thread.Sleep(2000);
        }
        ///----------------------------------------------------------------///
        private void showDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
            System.Threading.Thread.Sleep(2000);

        }
        ///----------------------------------------------------------------///
    }
}
