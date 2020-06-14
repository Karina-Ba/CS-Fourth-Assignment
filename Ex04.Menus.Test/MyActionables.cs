using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class MyActionables : Interface.ActionMenuItem.IActionable
    {
        private int m_ActionNumber;

        public MyActionables(int i_ActionNumber)
        {
            this.m_ActionNumber = i_ActionNumber;
        }

        public void DoChosenOption()
        {
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
        
        private void showVersion()
        {
            Console.WriteLine("Version: 20.2.4.30620");
            System.Threading.Thread.Sleep(2000);

        }


        private void showTime()
        {
            DateTime time = new DateTime();
            Console.WriteLine(time.ToShortTimeString());
            System.Threading.Thread.Sleep(2000);

        }

        private void showDate()
        {
            DateTime date = new DateTime();
            Console.WriteLine(date.ToShortDateString());
            System.Threading.Thread.Sleep(2000);

        }
    }


}
