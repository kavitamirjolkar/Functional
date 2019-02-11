// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PowerOf2.cs" company="Bridgelabz">
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
    /// This class is to calculate Table of power of two
    /// </summary>
    public class PowerOf2
    {
        /// <summary>
        /// Table the of 2.
        /// </summary>
        public static void TableOf2()
        {
            int i = 0;
            int power = 1;
           
            for (i = 0; i <= Utility.n; i++)
            {
                if (Utility.n >= 31)
                {
                    Console.Write("Please enter a value less than 31");
                    break;
                }

                Console.WriteLine("2^" + i + "=" + power);
                power = power * 2;     
            } 
        }
    }
}
