using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    class Program
    {
        static void Main ()
        {
            int maxAttempts = 3;
            int attempts = 0;
            while (attempts < maxAttempts)
            {
                Console.WriteLine("Enter your password: ");
                string password = Console.ReadLine();

                if (isPasswordValid(password))
                {
                    Console.WriteLine("Password is valid.");
                    break;
                }
                else
                {
                    attempts++;
                    Console.WriteLine("Invalid password.");
                }
            }
            if (attempts == maxAttempts)
            {
                Console.WriteLine("You have run out of attempts.");
            }
        }




        static bool isPasswordValid(string password )
        {
            int minLength = 8;
            bool hasUppercase = false;
            bool hasLowercase = false; 
            bool hasNum = false;
            bool hasSpecialChar = false;
            
            if (password.Length < minLength)
            {
                Console.WriteLine("Password should have a minimum length of 8 characters.");
                return false;
            }
            
            foreach (char ch in password)
            {
                if (char.IsUpper(ch))
                {
                    hasUppercase = true;
                }
                else if (char.IsLower(ch))
                {
                    hasLowercase = true;
                }
                else if (char.IsNumber(ch))
                {
                    hasNum = true;
                }
                else if (char.IsSymbol(ch) || char.IsPunctuation(ch))
                {
                    hasSpecialChar = true;
                }
            }
            if (hasUppercase && hasLowercase && hasNum && hasSpecialChar)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character.");
                return false;
            }    

        }
    }
}
