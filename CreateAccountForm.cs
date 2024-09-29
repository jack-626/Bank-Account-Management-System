using System.Text.RegularExpressions;

namespace Bank_Account_Management_System
{
    public partial class CreateAccountForm : Form
    {
        private Account account;

        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //On form load, add account types to combo box and set the selected index to the first (Current Account)
            comboBox_AccountType.Items.Add("Current");
            comboBox_AccountType.Items.Add("Savings");
            comboBox_AccountType.SelectedIndex = 0;
        }

        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                // Regex pattern taken from: https://stackoverflow.com/a/2385967
                // Pattern edited and tested using: https://regex101.com
                // This regex pattern only allows letters A-Z in lowercase and uppercase, and some symbols that can be found in some names. (,.'-)
                if (new Regex(@"^[a-z A-Z,.'-]+$").IsMatch(textBox1.Text))
                {
                    account = AccountGenerator.GenerateAccount(comboBox_AccountType.Text, textBox1.Text); // Generate a new account using combo box and text box inputs. 
                    AccountManagementForm AccountForm = new AccountManagementForm(account); // Creates a new instance of the account management form
                    AccountForm.Show(); // Show account management form
                    //this.Hide(); // Hide current form
                } else
                {
                    MessageBox.Show("Invalid Input!"); // Show an error if the text box doesn't match the regex pattern.
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString()); // Show an error message if there are any exceptions.
            }
        }
    }
}