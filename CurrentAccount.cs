using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Management_System
{
    public class CurrentAccount : Account
    {
        //Constructor for account username. Takes username input and sets the username on the parent class.
        public CurrentAccount(string username)
        {
            Username = username;
        }

        // Method for depositing money. Checks that deposit amount is valid before adding to the account balance.
        public override void Deposit(float depositAmount)
        {
            if (depositAmount <= 0) // Check that deposit amount is greater than 0. if not, throw an error. 
            {
                throw new ArgumentException("Must deposit more than £0.");
            } 
            else
            {
                balance += depositAmount; // Add deposit amount to the balance.
            }
        }

        // Method for withdrawing money. Checks that the account has sufficient balance and that the withdrawal amount is valid. 
        public override void Withdraw(float withdrawAmount)
        {
            if (withdrawAmount <= 0) // Check that the withdraw amount is greater than 0. if not, throw an error. 
            {
                throw new ArgumentException("Must withdraw more than £0.");
            }
            else if (balance - withdrawAmount < 0) // Check that account has sufficient funds. if not, throw an error. 
            {
                throw new ArgumentException("You do not have sufficient funds.");
            } else
            {
                balance -= withdrawAmount; // Remove withdraw amount from the balance
            }
        }
    }
}
