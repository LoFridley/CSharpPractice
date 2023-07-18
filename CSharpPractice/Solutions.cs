using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public static class Solutions
    {
        public static void Greetings() 
        {
            Console.WriteLine("Hello, World!");
        }

        public static void GreetingsLogan()
        {
            Console.WriteLine("Hello, Logan!");
            Console.WriteLine("How was your day?");
        }

        public static void GreetingsLogan(string someString)
        {
            Console.WriteLine("Your answer was: " + someString);
        }

        public static void VariablePracticeString1()
        {
            string name1 = "John";
            string name2 = "Jane";
            string name3 = "";  // This string is empty
            string name4;       // This string null



        }

        public static void DeclaringVariablesInARow()
        {
            int a, b, c;
            string firstName, lastName = "";

            string spaceString = " ";
            char spaceChar = ' ';
        }


        /// <summary>
        /// Implement a method that takes two string parameters and prints them in the following format:
        /// Your first parameter: <first parameter>
        /// Your second parameter: <second parameter>
        /// <first parameter><second parameter><first parameter><second parameter>
        /// instead of reusing the writeline() method multiple timnes use the /n character to to add new lines
        /// </summary>
        public static void FormattingStringPractice(string param1, string param2)
        {
            /*            Console.WriteLine("Your first parameter: " + param1);
                        Console.WriteLine("Your second parameter: " + param2);
                        Console.WriteLine(param1 + param2 + param1 + param2);*/

            Console.WriteLine("Your first parameter: " + param1 + 
                "\n Your second parameter: " + param2 + 
                "\n" + param1 + param2 + param1 + param2);

            Console.WriteLine("Your first parameter: {0}\n Your second parameter: {1}\n{0} {1} {0} {1}", param1, param2);
        }

        /// <summary>
        /// Implement a method that takes two string parameters, an int parameter, and prints them in the following format:
        /// Your first parameter: <first parameter>
        /// Your second parameter: <second parameter>
        /// Your third parameter: <third parameter>
        /// <first parameter> <second parameter> <third parameter> <second parameter> <first parameter>
        /// instead of reusing the writeline() method multiple timnes use the /n character to to add new lines
        /// </summary>
        public static void FormattingStringPractice(string param1, string param2, int param3)
        {
            Console.WriteLine("Your first parameter: {0}\n Your second parameter: {1}\n Your third parameter: {2}\n {0} {1} {2} {1} {0}", param1, param2, param3);
        }
        
        public static void StringInterpolationPractice(string param1, string param2, int param3)
        {
            Console.WriteLine($"Your first parameter: {param1}\n Your second parameter: {param2}\n Your third parameter: {param3}\n {param1} {param2} {param3} {param2} {param1}!");
        }


        /// <summary>
        /// Implement a method that 4 string parameters as required to print a fake credit card in the following format:
        /// ------------------------------------------------------
        /// | <cardNumber>                                        |
        /// |                                                     |
        /// | Valid Thru: <expDate>        SecCode<threeDigitCode>|
        /// |                                                     |
        /// | Name: <fullName>                                    |
        /// |                                                     |
        /// _______________________________________________________
        /// Use fake data
        /// instead of reusing the writeline() method multiple timnes use the /n character to to add new lines
        /// </summary>
        public static void PrintCreditCard(string param1, string param2, string param3, string param4)
        {
            Console.WriteLine($"------------------------------------------------------\n" +
                $"| {param1}                              |\n" +
                $"|                                                     |\n" +
                $"| Valid Thru: {param2}        SecCode: {param3}               |\n" +
                $"|                                                     |\n" +
                $"| Name: {param4}                                      |\n" +
                $"|                                                     |\n");
        }

        public static int AddTwoInts(int firstInt, int secondInt)
        {
            Console.WriteLine($"The result of {firstInt} * {secondInt} is:");
            int result = firstInt * secondInt;

            return result;
        }


        public static int SubstractThreeFromInt(int numberToSub)
        {
            Console.WriteLine("The result of {0} - 3 is: {1}", numberToSub, numberToSub -= 3);

            return numberToSub;
        }





        /// <summary>
        /// Implement a method that accepts 4 integer parameters and then multiplies the first with the third
        /// and divides the second by the fourth parameter and adds the results from these two calculations 
        /// and then returns the result in the following format (the reurn type of the method is string):
        /// The result of (<parameter1> x <parameter3>) + (<parameter2> / <parameter4>) is: <result>
        /// </summary>
        public static string Homework2(int param1, int param2, int param3, int param4)
        {

            int result = param1 * param3 + param2 / param4;

            string printThisInTheEnd = ($"The result of ({param1} x {param3}) + ({param2} / {param4}) is: {result}");

            
            return printThisInTheEnd;
        }



        /// <summary>
        /// Implement a method that accepts 4 integer parameters
        /// and then combines those numbers respectively and returns as a string
        /// The format should be as the following:
        /// parameters: x, y, z, a  >> result: xyza
        /// </summary>
        public static string Homework3(int param1, int param2, int param3, int param4)
        {

            string printThis = ($"{param1}{param2}{param3}{param4}");
            return printThis;
        }




        /// <summary>
        /// Implement a method that accepts 2 string parameters and 2 integer parameters
        /// and then returns a string value in the following format:
        /// Name: <stringParam1> Age: <intParam1>
        /// Name: <stringParam2> Age: <intParam2>
        /// </summary>
        public static string Homework4(string stringParam1, int intParam1, string stringParam2, int intParam2)
        {

            string printThisOne = ($"Name: {stringParam1} Age: {intParam1}\n" +
                $"Name: {stringParam2} Age: {intParam2}");

            return printThisOne;
        }


        /// <summary>
        /// Implement a method that accepts one int parameter
        /// and then returns a boolean value if that parameter is greater than or equal to 21
        /// </summary>
        public static bool CanDrink(int param1)
        {
            bool canDrink = param1 >= 21;
            return canDrink;
        }

        public static void TellTheUser(string messageToUser)
        {
            Console.WriteLine(messageToUser);
        }

        public static string TakeUserStringInput()
        {
            return Console.ReadLine() ?? "";
        }

        public static int TakeUserIntInput()
        {
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int intInput))
            {
                Console.WriteLine($"Thank you, you answered {intInput}");

                return intInput;
            }
            else
            {
                Console.WriteLine("Please enter a valid value...");
                return default;
            }
        }

        public static bool TakeUserBoolInput()
        {
            string? input = Console.ReadLine();

            if (input.Equals("y") || input.Equals("Y"))
            {
                return true;
            }
            else if(input.Equals("n") || input.Equals("N"))
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter a valid value...");
                return default;
            }
        }


    }
}
