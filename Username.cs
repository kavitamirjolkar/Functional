// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserName.cs" company="Bridgelabz">
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
    /// This class is to set correct username
    /// </summary>
    public class Username
    {
        /// <summary>
        /// Checks the username.
        /// </summary>
        public static void CheckUsername()
        {
            Console.WriteLine("Enter username: ");
            string str = Console.ReadLine();
            if (str.Replace(" ","").Length <= 3 || string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("Please enter correct name");
                else if (str.Replace(" ", "").Length > 3 || string.IsNullOrWhiteSpace(str))
                {
                    Console.WriteLine("Hello " + str.Replace(" ", "") + " How are you?");
                }
            }
                        
        }      
    }
}
