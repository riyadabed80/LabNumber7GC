using System;
using System.Text.RegularExpressions;

namespace LabNumber7GC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid name");
            string input = Console.ReadLine();
            if (CheckNames(input))
            {
                Console.WriteLine("Thx! Got your name!");
            }
            else
            {
                Console.WriteLine("That's not a valid name!");
            }

            Console.WriteLine("Please enter a valid email");
            string inputEmail = Console.ReadLine();
            if (CheckEmail(inputEmail))
            {
                Console.WriteLine("Email is valid!");
            }
            else
            {
                Console.WriteLine("Email is not valid!");
            }
            Console.WriteLine("Please enter a valid phone number in 111-111-1111 format");
            string inputPhoneNum = Console.ReadLine();
            if (CheckPhoneNum(inputPhoneNum))
            {
                Console.WriteLine("Thx! That phone number is valid!");
            }
            else
            {
                Console.WriteLine("That is not a valid phone number!");
            }
            Console.WriteLine("Please enter date in dd/mm/yyyy format");
            string inputDate = Console.ReadLine();
            if (CheckDate(inputDate))
            {
                Console.WriteLine("The date is valid");
            }
            else
            {
                Console.WriteLine("The date is not valid");
            }

        }
        public static bool CheckNames(string input)
        {
            return (Regex.IsMatch(input, @"^(-?([A-Z].\s)?([A-Z][a-z]{1,29})\s?)$"));
        }

        public static bool CheckEmail(string inputEmail)
        {
            return (Regex.IsMatch(inputEmail, @"^\b[\w]{5,30}@[\w]{5,10}\.\w{2,3}\b$"));
        }

        public static bool CheckPhoneNum(string inputPhoneNum)
        {
            return (Regex.IsMatch(inputPhoneNum, @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$"));
        }

        public static bool CheckDate(string inputDate)
        {
            return (Regex.IsMatch(inputDate, @"^(0[1-9]|1[0-2])[\/](0[1-9]|[12]\d|3[01])[\/](19|20)\d{2}$"));

            }
        }
    }    
