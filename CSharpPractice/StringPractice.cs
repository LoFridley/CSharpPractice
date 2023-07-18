using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public static class StringPractice
    {

        //implement a method that takes two string parameters and returns the following string:
        //"The length of <dog1name> is <x> and the length of <dog2name> is <y>"

        public static string MyDogs(string myFirstDog, string mySecondDog)
        {
            string result;

            int lengthofdog1 = myFirstDog.Length;
            int lengthofdog2 = mySecondDog.Length;

            result = $"The length of {myFirstDog} is {lengthofdog1} and the length of {mySecondDog} is {lengthofdog2}";

            return result;
        }

        //Go to SMLLC website and copy the first text you see
        //Implement a method that takes a string parameter and
        //returns a string that is the same string with the input except, underscores for spaces
        //In the main class, use this method with the above text acquired from SMLLC website

        public static string ReplaceSpacesWithUnderscores(string phrase)
        {
            string result;


            result = phrase.Replace(' ', '_');

            return result;
        }


        public static string GetFirstNameFromFullName(string fullName)
        {
            string result;

            int indexOfSpace = fullName.IndexOf(' ');

            result = fullName.Remove(indexOfSpace);
            return result;
        }




    }
}
/*Small Government, Big Solutions*/