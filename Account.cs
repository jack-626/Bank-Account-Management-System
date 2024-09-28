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
        protected float balance; //Account Balance

        //Methods for depositing and withdrawing.
        public abstract void Deposit(float amount);
        public abstract void Withdraw(float amount);

        //Method for getting current balance
        public float GetBalance()
        {
            return balance;
        }
    }
}
