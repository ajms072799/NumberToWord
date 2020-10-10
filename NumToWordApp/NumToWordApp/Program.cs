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
                    Console.WriteLine(singleDigitNumber[1]);
                break;
                case 2:
                    Console.WriteLine(singleDigitNumber[2]);
                break;
                case 3:
                    Console.WriteLine(singleDigitNumber[3]);
                break;
                case 4:
                    Console.WriteLine(singleDigitNumber[4]);
                break;
                case 5:
                    Console.WriteLine(singleDigitNumber[5]);
                break;
                case 6:
                    Console.WriteLine(singleDigitNumber[6]);
                break;
                case 7:
                    Console.WriteLine(singleDigitNumber[7]);
                break;
                case 8:
                    Console.WriteLine(singleDigitNumber[8]);
                break;
                case 9:
                    Console.WriteLine(singleDigitNumber[9]);
                break;
            }
            // <~ End Switch statement for convertion of single digit number

            // <~ Start If statement for converting double digit number
            if (number > 90)
            {
                int i, indexNumber; // making variable for initialization for loop and for getting the index number

                for (i = 0; i < 1; i++)
                {
                    indexNumber = number - 90; // the indexNumber will be the indexNumber of the array in singleDigitNum
                    Console.WriteLine(doubleDigitNumber[7] + singleDigitNumber[indexNumber]);
                }
            }
            else if (number == 90)
            {
                Console.WriteLine(doubleDigitNumber[7]); // Displaying the result if number is equal to 90
            }
            else if (number > 80)
            {
                int i, indexNumber;

                for (i = 0; i < 1; i++)
                {
                    indexNumber = number - 80;
                    Console.WriteLine(doubleDigitNumber[6] + singleDigitNumber[indexNumber]);
                }
            }
            else if (number == 80)
            {
                Console.WriteLine(doubleDigitNumber[6]);
            }
            else if (number > 70)
            {
                int i, indexNumber;

                for (i = 0; i < 1; i++)
                {
                    indexNumber = number - 70;
                    Console.WriteLine(doubleDigitNumber[5] + singleDigitNumber[indexNumber]);
                }
            }
            else if (number == 70)
            {
                Console.WriteLine(doubleDigitNumber[5]);
            }
            else if (number > 60)
            {
                int i, indexNumber;

                for (i = 0; i < 1; i++)
                {
                    indexNumber = number - 60;
                    Console.WriteLine(doubleDigitNumber[4] + singleDigitNumber[indexNumber]);
                }
            }
            else if (number == 60)
            {
                Console.WriteLine(doubleDigitNumber[4]);
            }
            else if (number > 50)
            {
                int i, indexNumber;

                for (i = 0; i > 0; i++)
                {
                    indexNumber = number - 50;
                    Console.WriteLine(doubleDigitNumber[3] + singleDigitNumber[indexNumber]);
                }
            }
            else if (number == 50)
            {
                Console.WriteLine(doubleDigitNumber[3]);
            }
            else if (number > 40)
            {
                int i, indexNumber;

                for (i = 0; i < 1; i++)
                {
                    indexNumber = number - 40;
                    Console.WriteLine(doubleDigitNumber[2] + singleDigitNumber[indexNumber]);
                }
            }
            else if (number == 40)
            {
                Console.WriteLine(doubleDigitNumber[2]);
            }
            else if (number > 30)
            {
                int i, indexNumber;

                for (i = 0; i < 1; i++)
                {
                    indexNumber = number - 30;
                    Console.WriteLine(doubleDigitNumber[1] + singleDigitNumber[indexNumber]);
                }
            }
            else if (number == 30)
            {
                Console.WriteLine(doubleDigitNumber[1]);
            }
            else if (number > 20)
            {
                int i, indexNumber;

                for (i = 0; i < 1; i++)
                {
                    indexNumber = number - 20;
                    Console.WriteLine(doubleDigitNumber[0] + singleDigitNumber[indexNumber]);
                }
            }
            else if (number == 20)
            {
                Console.WriteLine(doubleDigitNumber[0]);
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
            string[] singleDigitNumber = {"Zero","One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
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
