// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Factors.cs" company="Bridgelabz">
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
    /// This class is to calculate prime factors of number
    /// </summary>
    public class Factors
    {
        /// <summary>
        /// Primes the factor.
        /// </summary>
        public static void PrimeFactor()
        {
            for (int i = 2; i < Utility.n; i++)
            {
                while (Utility.n % i == 0)
                {
                    Console.WriteLine(i + " ");
                    Utility.n = Utility.n / i;
                }
            }

            if (Utility.n > 2)
            {
                Console.WriteLine(Utility.n);
            }
        }
    }
}
