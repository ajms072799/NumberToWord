using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToWordApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number to Word Application

            /*
                TODO List:
             
             * Input for the number.
             * Array for the string number
             * Convert the number to word using if/loop
             
             */

            // Array String Number
            string[] singleDigitNumber = {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
            string[] doubleDigitNumber = {"Twenty", "Thirty", "Fourty","Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("\t Number to Word Application");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Enter a number: ");  // Input number for the Converting the number to words.
            int number = Int32.Parse(Console.ReadLine());

            // <~ End of the Number to Word Application
            Console.ReadLine();
        }
    }
}
