using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP_ExpensesT
{
    internal class Menu
    {
        public static void ShowMenu()
        {

            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. View Expenses");
            Console.WriteLine("3. Exit/LogOut");
            Console.Write("Please choose one(1) only: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddExpense();
                    break;
                case "2":
                    ViewExpenses();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Your option is INVALID. Please try again.");
                    break;
            }
        }

        public static Dictionary<string, decimal> expensesByCategory = new Dictionary<string, decimal>(); //Dictionary<sting, decimal> is for generally used to store key/value pairs (String and Integer)
        public static void AddExpense()
        {
            Console.Write("Enter expense description: ");
            string description = Console.ReadLine();

            Console.Write("Enter amount: ");
            decimal amount;
            while (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.Write("Your amount is INVALID. Please enter a positive number: ");
            }

            string category = GetCategory();

            if (!expensesByCategory.ContainsKey(category))
            {
                expensesByCategory.Add(category, 0);
            }

            expensesByCategory[category] += amount;
            Console.WriteLine("Your Expense added successfully.\n");
        }

        public static string GetCategory()
        {
            Console.WriteLine("Select Your Category:");
            Console.WriteLine("1. Food");
            Console.WriteLine("2. Clothes or Shoes");
            Console.WriteLine("3. Online Buying");
            Console.WriteLine("4. Others");
            Console.Write("Enter choice (1 only): ");

            string choice = Console.ReadLine();
            string category;
            switch (choice)
            {
                case "1":
                    category = "Food";
                    break;
                case "2":
                    category = "Clothes or Shoes";
                    break;
                case "3":
                    category = "Online Buying";
                    break;
                default:
                    category = "Others";
                    break;
            }
            return category;
        }

        static void ViewExpenses()
        {
            if (expensesByCategory.Count == 0)
            {
                Console.WriteLine("You don't have any expenses, please add expenses to record.\n");
                return;
            }

            Console.WriteLine("\nExpenses by Category:");
            decimal totalExpenses = 0;
            foreach (var category in expensesByCategory)
            {
                Console.WriteLine($"{category.Key}: P{category.Value:C}");
                totalExpenses += category.Value;
            }
            Console.WriteLine($"\nTotal Expenses: {totalExpenses:C}\n");
        }
    }
}
