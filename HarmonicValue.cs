// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HarmonicValue.cs" company="Bridgelabz">
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
    /// This class is to calculate Nth harmonic value
    /// </summary>
    public class HarmonicValue
    {
        /// <summary>
        /// Harmonics the sum.
        /// </summary>
        public static void HarmonicSum()
        {
            int i = 1;
            
            double sum = 0;

            while (i <= Utility.n)
            {
                sum = sum + ((double)1 / i);
                i++;   
            }

            Console.WriteLine(sum);
        }
    }
}
