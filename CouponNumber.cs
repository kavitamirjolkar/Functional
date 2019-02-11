// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CouponNumber.cs" company="Bridgelabz">
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
    /// This class is to generate distinct coupons by using random numbers
    /// </summary>
    public class CouponNumber
    {
        /// <summary>
        /// Distinct the coupon.
        /// </summary>
        public static void DistinctCoupon()
        {
            int count = 0;
            ////Array is used to store the all random numbers
            int[] distinct = new int[Utility.n];
            Random random = new Random();
            for (int i = 0; i < distinct.Length; i++)
            {
                count++;
                int r = Convert.ToInt32(random.Next(0, Utility.n));
                distinct[i] = r;

                for (int j = 0; j < i; j++)
                {
                    if (distinct[i] == distinct[j])
                    {
                        i--;
                    }
                }
            }

            Console.WriteLine("count= " + count);
            Console.WriteLine("Distinct numbers are: ");
            for (int i = 0; i < distinct.Length; i++)
            {
                Console.Write(distinct[i] + " ");
            }   
       }
    }
}
