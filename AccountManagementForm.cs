using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Account_Management_System
{
    public partial class AccountManagementForm : Form
    {
        private Account account;

        public AccountManagementForm(Account createdAccount)
        {
            InitializeComponent();
            account = createdAccount; // Get data of created account when this form is created.
        }

        private void AccountManagementForm_Load(object sender, EventArgs e)
        {
            // Check that there is an account loaded when this form loads, exit app if not. This form should not be loaded until there has been an account created in the previous form.
            if (account == null)
            {
                Application.Exit();
            }

            label_Username.Text = account.Username; // Set username label text to the accounts username.
            label_Balance.Text = account.GetBalance().ToString(); // Get account balance and update balance label text.
            label_AccType.Text = account.AccountType; // Get account type and set the account type label.
        }

        #region Text Boxes
        /*
         * https://stackoverflow.com/a/9897665 - Regex pattern taken from here
         * https://regex101.com/ - Regex pattern tested using this site 
         */
        private void textBox_DepositAmount_TextChanged(object sender, EventArgs e)
        {
            //Try to match text box to regex pattern, change text color to green if is a match, red if not.
            if (new Regex(@"^\xA3?\d{1,3}?([,]\d{3}|\d)*?([.]\d{1,2})?$").IsMatch(textBox_DepositAmount.Text))
            {
                textBox_DepositAmount.ForeColor = Color.Green;
            }
            else
            {
                textBox_DepositAmount.ForeColor = Color.Red;
            }
        }

        private void textBox_WithdrawAmount_TextChanged(object sender, EventArgs e)
        {
            //Try to match text box to regex pattern, change text color to green if is a match, red if not.
            if (new Regex(@"^\xA3?\d{1,3}?([,]\d{3}|\d)*?([.]\d{1,2})?$").IsMatch(textBox_WithdrawAmount.Text))
            {
                textBox_WithdrawAmount.ForeColor = Color.Green;
            }
            else
            {
                textBox_WithdrawAmount.ForeColor = Color.Red;
            }
        }
        #endregion

        #region Buttons

        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            try
            {
                if (new Regex(@"^\xA3?\d{1,3}?([,]\d{3}|\d)*?([.]\d{1,2})?$").IsMatch(textBox_DepositAmount.Text)) //Checks for regex pattern match
                {
                    account.Deposit(float.Parse(textBox_DepositAmount.Text.Replace("£", " "))); // Deposit money to account. Removes and replaces £ symbol with nothing and converts the string to a float. 
                    label_Balance.Text = account.GetBalance().ToString(); // Update balance text box
                }
                else
                {
                    MessageBox.Show("Invalid Input!"); // Shows error message if regex match fails.
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString()); // Shows error message if there is an exception.
            }
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            try
            {
                if (new Regex(@"^\xA3?\d{1,3}?([,]\d{3}|\d)*?([.]\d{1,2})?$").IsMatch(textBox_WithdrawAmount.Text)) //Checks for regex pattern match
                {
                    account.Withdraw(float.Parse(textBox_WithdrawAmount.Text.Replace("£", " "))); // Withdraw money from account. Removes and replaces "£" symbol with nothing and converts the string to a float. 
                    label_Balance.Text = account.GetBalance().ToString(); // Update balance text box
                }
                else
                {
                    MessageBox.Show("Invalid Input!"); // Shows error message if regex match fails.
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString()); // Shows error message if there is an exception.
            }
        }
        #endregion
    }
}