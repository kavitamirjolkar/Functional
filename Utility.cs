// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
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
    /// This class is to set an user input
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// The string
        /// </summary>
        public static string Str = " ";
        public static int Year;
        public static int n;
        
        /// <summary>
        /// Inputs the string.
        /// </summary>
        /// <returns></returns>
        public static string InputString()
        {
            //string str = " ";
            Console.WriteLine("Enter Username: ");
            Str = Console.ReadLine();
            return Str;
        }

        /// <summary>
        /// Inputs the year.
        /// </summary>
        /// <returns></returns>
        public static int InputYear()
        {
            Console.WriteLine("Enter year : ");
            Year = Convert.ToInt32(Console.ReadLine());
            
            return Year;
        }
         
        /// <summary>
        /// Inputs the integer.
        /// </summary>
        /// <returns></returns>
        public static Int32 GetInt()
        {
            int n = 0;
            Console.WriteLine("Enter Number : ");
            n = Convert.ToInt32(Console.ReadLine());
            return n;
        }      
    }
}
