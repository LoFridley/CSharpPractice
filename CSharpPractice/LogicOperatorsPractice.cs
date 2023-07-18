using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public static class LogicOperatorsPractice
    {




        ///<summary>
        /// Implement a method that accepts one int parameter for age, two bool parameters for hasLicence and licenseSuspended
        /// Then returns a bool value which is true only if the age is greater than or equal to 21, hasLicence is true, and license suspended is false
        /// </summary>
        public static bool EligibleToRentCar(int age, bool haslicense, bool licensesuspended)
        {

            bool eligibleToRentCar;

            bool validAge = age >= 21;

            eligibleToRentCar = validAge && haslicense && !licensesuspended;

            return eligibleToRentCar;
        }



        ///<summary>
        /// Implement a method that accepts an int parameter for monthly income, and another parameter for monthly rent
        /// Then returns a bool value which is true only if the monthly income is three times the rent or greater
        /// </summary>
        public static bool HouseIsSuitableToRent()
        {

            return default;
        }


        ///<summary>
        /// Implement a method that accepts a double parameter for GPA, an int parameter for age, and a bool parameter for hasCollegeDegree
        /// Then returns a bool value which is true only if the GPA is greater than or equal to 3.0 and age is smaller than 33 and hasCollegeDegree is true
        /// </summary>
        public static bool EligibleToApplyFBI()
        {

            return default;
        }





    }
}
