namespace Bank_Account_Management_System
{
    partial class CreateAccountForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_CreateAccount = new Button();
            label1 = new Label();
            comboBox_AccountType = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_CreateAccount
            // 
            btn_CreateAccount.Location = new Point(236, 3);
            btn_CreateAccount.Name = "btn_CreateAccount";
            btn_CreateAccount.Size = new Size(129, 57);
            btn_CreateAccount.TabIndex = 0;
            btn_CreateAccount.Text = "Create Account";
            btn_CreateAccount.UseVisualStyleBackColor = true;
            btn_CreateAccount.Click += btn_CreateAccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 15);
            label1.TabIndex = 1;
            label1.Text = "Welcome to the bank! Please create an account!";
            // 
            // comboBox_AccountType
            // 
            comboBox_AccountType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_AccountType.FormattingEnabled = true;
            comboBox_AccountType.Location = new Point(109, 32);
            comboBox_AccountType.Name = "comboBox_AccountType";
            comboBox_AccountType.Size = new Size(121, 23);
            comboBox_AccountType.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 6);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "Username: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 35);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 5;
            label3.Text = "Account Type: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_CreateAccount);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox_AccountType);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 66);
            panel1.TabIndex = 6;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 101);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateAccountForm";
            ShowIcon = false;
            Text = "Bank Account Creation";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_CreateAccount;
        private Label label1;
        private ComboBox comboBox_AccountType;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Panel panel1;
    }
}
