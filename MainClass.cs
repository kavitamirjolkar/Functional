// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainClass.cs" company="Bridgelabz">
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
    /// This is main class from where the methods are called
    /// </summary>
   public class MainClass
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Please select your choice from the giving list: ");
            Console.WriteLine("1. Username");
            Console.WriteLine("2. Flip Coin");
            Console.WriteLine("3. Leap Year");
            Console.WriteLine("4. Power of two");
            Console.WriteLine("5. Harmonic Number");
            Console.WriteLine("6. Factors");
            Console.WriteLine("8. Coupon Number");
            Console.WriteLine("9. 2D Array");
            Console.WriteLine("10. Sum of three Integer adds to ZERO");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    
                    Username.CheckUsername();
                    Console.ReadKey();
                    break;

                case 2:
                    Utility.GetInt();
                    FlipCoin.FlipCoinResult();
                    Console.ReadKey();
                    break;

                case 3:
                    Utility.InputYear();
                    LeapYear.CheckLeap();
                    Console.ReadKey();
                    break;

                case 4:
                    Utility.GetInt();
                    PowerOf2.TableOf2();
                    Console.ReadKey();
                    break;

                case 5:
                    Utility.GetInt();
                    HarmonicValue.HarmonicSum();
                    Console.ReadKey();
                    break;

                case 6:

                    Utility.GetInt();
                    Factors.PrimeFactor();
                    Console.ReadKey();
                    break;

                case 8:

                    Utility.GetInt();
                    CouponNumber.DistinctCoupon();
                    Console.ReadKey();
                    break;

                case 9:

                    TwoDimentionalArray.WriteArray();
                    Console.ReadKey();
                    break;

                case 10:
                    Utility.GetInt();
                    Triplets.FindTriplets();
                    Console.ReadKey();
                    break;
            }   
        }
    }
}
