// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlipCoin.cs" company="Bridgelabz">
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
    /// This class is to calculate percentage of heads and tails
    /// </summary>
   public class FlipCoin
   {
        /// <summary>
        /// Flips the coin result.
        /// </summary>
        public static void FlipCoinResult()
        {
            int head_count = 0;
            int tail_count = 0;
            Random r = new Random();
            for (int i = 1; i < Utility.n; i++)
            {
                Console.WriteLine("flip the coin");
                Console.ReadLine();
                int n = Convert.ToInt32(r.Next(0, 2));
                if (n == 1)
                {
                    head_count++;
                    Console.WriteLine("head");
                }
                else
                {
                    tail_count++;
                    Console.WriteLine("tail");
                }
            }

            int per_head = (head_count / Utility.n) * 100;
            int per_tail = (tail_count / Utility.n) * 100;
            Console.WriteLine(per_head);
            Console.WriteLine(per_tail);
        }
   }
}
