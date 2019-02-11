// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Kavita Mirjolkar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Functional
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    /// <summary>
    /// This class is to check whether the year is leap or not
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// Checks the leap.
        /// </summary>
        public static void CheckLeap()
        {
            int count = 0;
            
            while (Utility.Year > 0)
            {
                Utility.Year = Utility.Year / 10;
                count++;
            }

            if ((Utility.Year % 4 == 0 && Utility.Year % 100 != 0) || (Utility.Year % 400 == 0))
                {
                    Console.WriteLine("Leap Year");
                }
            else
                {
                    Console.WriteLine("Not a Leap Year");
                }
        }     
    }
}
