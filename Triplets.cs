// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Triplets.cs" company="Bridgelabz">
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
    /// This class is to find out triplets in the array which when added together will give zero
    /// </summary>
    public class Triplets
    {
        /// <summary>
        /// Finds the triplets.
        /// </summary>
        public static void FindTriplets()
        {
            bool found = false;
            int count = 0;
            int[] array = new int[Utility.n];
            Console.WriteLine("Enter the elements: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < array.Length - 2; i++)
            {
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    for (int k = j + 1; k < array.Length; k++)
                    {
                        if (array[i] + array[j] + array[k] == 0)
                        {
                            count++;
                            
                            Console.WriteLine("Integers are: " + array[i] + " " + array[j] + " " + array[k]);   
                        }  
                    }
                }
            }

            Console.WriteLine("Number of triplets present in array: " + count);
            found = true;
            if (found)
            {
                Console.WriteLine("No such Triplets in array");
            }
        }
    }
}
