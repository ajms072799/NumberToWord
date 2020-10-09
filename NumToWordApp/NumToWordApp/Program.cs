using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToWordApp
{
    class Program
    {
        // <~ Start's of the ConvertNumToWord Function
        static void ConvertNumToWord(int number, string[] singleDigitNumber, string[] doubleDigitNumber) {
            // <~ Start Switch statement for convertion of single digit number
            switch(number)
            {
                case 1:
                    Console.WriteLine(singleDigitNumber[0]);
                break;
                case 2:
                    Console.WriteLine(singleDigitNumber[1]);
                break;
                case 3:
                    Console.WriteLine(singleDigitNumber[2]);
                break;
                case 4:
                    Console.WriteLine(singleDigitNumber[3]);
                break;
                case 5:
                    Console.WriteLine(singleDigitNumber[4]);
                break;
                case 6:
                    Console.WriteLine(singleDigitNumber[5]);
                break;
                case 7:
                    Console.WriteLine(singleDigitNumber[6]);
                break;
                case 8:
                    Console.WriteLine(singleDigitNumber[7]);
                break;
                case 9:
                    Console.WriteLine(singleDigitNumber[8]);
                break;
            }
            // <~ End Switch statement for convertion of single digit number

            // <~ Start If statement for converting double digit number
            if (number == 20)
            {
                Console.WriteLine(doubleDigitNumber[0]);
            }
            else if (number > 20)
            {
                switch (number)
                { 
                    case 21:
                        Console.WriteLine(doubleDigitNumber[0] + singleDigitNumber[0]);
                    break;
                    case 22:
                        Console.WriteLine(doubleDigitNumber[0] + singleDigitNumber[1]);
                    break;
                    case 23:
                        Console.WriteLine(doubleDigitNumber[0] + singleDigitNumber[2]);
                    break;
                    case 24:
                        Console.WriteLine(doubleDigitNumber[0] + singleDigitNumber[3]);
                    break;
                    case 25:
                        Console.WriteLine(doubleDigitNumber[0] + singleDigitNumber[4]);
                    break;
                    case 26:
                        Console.WriteLine(doubleDigitNumber[0] + singleDigitNumber[5]);
                    break;
                    case 27:
                        Console.WriteLine(doubleDigitNumber[0] + singleDigitNumber[6]);
                    break;
                    case 28:
                        Console.WriteLine(doubleDigitNumber[0] + singleDigitNumber[7]);
                    break;
                    case 29:
                        Console.WriteLine(doubleDigitNumber[0] + singleDigitNumber[8]);
                    break;
                }
            }
            // <~ End If statement for converting double digit number
        }
        // <~ End of the ConvertNumToWord Function
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

            // Result of Converting number to word.
            ConvertNumToWord(number,singleDigitNumber,doubleDigitNumber);

            // <~ End of the Number to Word Application
            Console.ReadLine();
        }
    }
}
