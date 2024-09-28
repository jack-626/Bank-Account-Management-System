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

        }

        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                account = AccountGenerator.GenerateAccount("Savings", "Jeff");
                AccountManagementForm AccountForm = new AccountManagementForm(account);
                AccountForm.Show(); // Show account management form
                this.Hide(); // Hide current form
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }
        }
    }
}
