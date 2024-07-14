using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP_ExpensesT
{
    internal class Account
    {
        static List<string> Users = new List<string>();
        static List<string> Password = new List<string>();

        static void CreateDummyUsers()
        {
            Users.Add("Admin1234");
            Users.Add("Admin5678");
            Users.Add("Admin91011");
        }

        static void CreateDummyUsersPassword()
        {
            Password.Add("1234");
            Password.Add("5678");
            Password.Add("91011");
        }
        public static bool Login(string username, string password)
        {
            CreateDummyUsers();
            CreateDummyUsersPassword();

            bool result = false;

            foreach (var user in Users)
            {
                if (user == username)
                {
                    result = true;
                }
            }

            foreach (var userpassword in Password)
            {
                if (password == userpassword)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}