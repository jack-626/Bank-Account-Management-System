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
            SuspendLayout();
            // 
            // btn_CreateAccount
            // 
            btn_CreateAccount.Location = new Point(100, 126);
            btn_CreateAccount.Name = "btn_CreateAccount";
            btn_CreateAccount.Size = new Size(201, 76);
            btn_CreateAccount.TabIndex = 0;
            btn_CreateAccount.Text = "Create Account";
            btn_CreateAccount.UseVisualStyleBackColor = true;
            btn_CreateAccount.Click += btn_CreateAccount_Click;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_CreateAccount);
            Name = "CreateAccountForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_CreateAccount;
    }
}
