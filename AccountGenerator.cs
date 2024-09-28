using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Management_System
{
    public static class AccountGenerator
    {
        //This is the factory class that generates accounts.
        public static Account GenerateAccount(string accountType, string username)
        {
            // Create account based on account type input. Throw an error if no valid account type is set.
            switch (accountType)
            {
                case "Current":
                    return new CurrentAccount(username);
                case "Savings":
                    return new SavingsAccount(username);
                default:
                    throw new ArgumentException("Invalid Account Type!");
            }
        }
    }
}