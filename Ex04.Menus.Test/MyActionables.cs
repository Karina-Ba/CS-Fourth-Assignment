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
                    CountCapitals();
                    break;
                case 2:
                    ShowVersion();
                    break;
                case 3:
                    ShowTime();
                    break;
                case 4:
                    ShowDate();
                    break;
            }
        }
        ///----------------------------------------------------------------///
        public static void CountCapitals()
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
        public static void ShowVersion()
        {
            Console.WriteLine("Version: 20.2.4.30620");
            System.Threading.Thread.Sleep(2000);
        }
        ///----------------------------------------------------------------///
        public static void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            System.Threading.Thread.Sleep(2000);
        }
        ///----------------------------------------------------------------///
        public static void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
            System.Threading.Thread.Sleep(2000);

        }
        ///----------------------------------------------------------------///
    }
}
