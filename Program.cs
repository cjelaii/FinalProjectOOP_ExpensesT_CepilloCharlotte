using System;
using System.ComponentModel.Design;
using System.Security.Principal;

namespace FinalProjectOOP_ExpensesT
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Expenses Tracker");
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string userpassword = Console.ReadLine();
            while (true)
            {
                if(Account.Login(username, userpassword))
                {
                    Menu.ShowMenu();
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }
        }
    }
}