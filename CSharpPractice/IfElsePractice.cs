using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public static class IfElsePractice
    {

        /// <summary>
        /// Write a method that takes two string parameters and copares their length
        /// and prints whichever parameter is longer than the other in the following format:
        /// <name1/> is longer than <name2/>
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="name2"></param>
        public static void CompareNameLengths(string name1, string name2)
        {
            if (name1.Length > name2.Length)
            {
                Console.WriteLine($"{name1} is longer than {name2}");
            }
            else if (name1.Length == name2.Length)
            {
                Console.WriteLine($"{name2} is equal to {name1} in length");
            }
            else
            {
                Console.WriteLine($"{name2} is longer than {name1}");
            }
        }

        /// <summary>
        /// Write a method that takes two int parameters to process as ages 
        /// and two string parameters to process as names
        /// and prints whoever is older than the other in the following format:
        /// <name1/> is <age difference> years older longer than <name2/>
        /// </summary>
        /// <param name="age1"></param>
        /// <param name="age1"></param>        
        /// <param name="name2"></param>
        /// <param name="age2"></param
        public static string CompareAges(int age1, int age2, string name1, string name2)
        {
            string result;

            if (age1 > age2)
            {
                int ageDifference = age1 - age2;
                result = ($"{name1} is {ageDifference} years older than {name2}");
            }
            else if (age1 == age2)
            {
                result = ($"{name1} is the same age as {name2}");
            }
            else
            {
                int ageDifference = age2 - age1;
                result= ($"{name1} is {ageDifference} years younger than {name2}");
            }


            return result;
        }



    }
}
