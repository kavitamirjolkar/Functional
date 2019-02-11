// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TwoDimentionalArray.cs" company="Bridgelabz">
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
    /// This class is to print 2D array
    /// </summary>
    public class TwoDimentionalArray
    {
        /// <summary>
        /// Writes the array.
        /// </summary>
        public static void WriteArray()
        {
            ////Taking input from user
            Console.Write("enter row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter column: ");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[row, col];
            
           ////Reading the elements of array
            Console.WriteLine("enter elements: ");
            
                for (int i = 0; i < array.GetLength(0); i++)
                {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                }

                ////Displaying the array
            Console.WriteLine("2D Array: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
