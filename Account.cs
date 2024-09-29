using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Management_System
{
    public abstract class Account
    {
        public string Username { get; set; } //Account Username
        public string AccountType { get; set; }
        protected decimal balance; //Account Balance

        //Methods for depositing and withdrawing.
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);

        //Method for getting current balance
        public decimal GetBalance()
        {
            return balance;
        }
    }
}
