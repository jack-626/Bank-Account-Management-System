namespace Bank_Account_Management_System
{
    partial class AccountManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Username = new Label();
            label1 = new Label();
            label_Balance = new Label();
            label2 = new Label();
            btn_Deposit = new Button();
            textBox_DepositAmount = new TextBox();
            textBox_WithdrawAmount = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn_Withdraw = new Button();
            label3 = new Label();
            label_AccType = new Label();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Location = new Point(158, 9);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(75, 15);
            label_Username.TabIndex = 0;
            label_Username.Text = "<username>";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 1;
            label1.Text = "Account Username: ";
            // 
            // label_Balance
            // 
            label_Balance.AutoSize = true;
            label_Balance.Location = new Point(158, 61);
            label_Balance.Name = "label_Balance";
            label_Balance.Size = new Size(64, 15);
            label_Balance.TabIndex = 2;
            label_Balance.Text = "<balance>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 61);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 3;
            label2.Text = "Account Balance: ";
            // 
            // btn_Deposit
            // 
            btn_Deposit.Location = new Point(3, 3);
            btn_Deposit.Name = "btn_Deposit";
            btn_Deposit.Size = new Size(75, 23);
            btn_Deposit.TabIndex = 4;
            btn_Deposit.Text = "Deposit";
            btn_Deposit.UseVisualStyleBackColor = true;
            btn_Deposit.Click += btn_Deposit_Click;
            // 
            // textBox_DepositAmount
            // 
            textBox_DepositAmount.Location = new Point(3, 32);
            textBox_DepositAmount.Name = "textBox_DepositAmount";
            textBox_DepositAmount.Size = new Size(100, 23);
            textBox_DepositAmount.TabIndex = 5;
            textBox_DepositAmount.TextChanged += textBox_DepositAmount_TextChanged;
            // 
            // textBox_WithdrawAmount
            // 
            textBox_WithdrawAmount.Location = new Point(3, 32);
            textBox_WithdrawAmount.Name = "textBox_WithdrawAmount";
            textBox_WithdrawAmount.Size = new Size(100, 23);
            textBox_WithdrawAmount.TabIndex = 6;
            textBox_WithdrawAmount.TextChanged += textBox_WithdrawAmount_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveBorder;
            flowLayoutPanel1.Controls.Add(btn_Deposit);
            flowLayoutPanel1.Controls.Add(textBox_DepositAmount);
            flowLayoutPanel1.Location = new Point(41, 88);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(111, 65);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.ActiveBorder;
            flowLayoutPanel2.Controls.Add(btn_Withdraw);
            flowLayoutPanel2.Controls.Add(textBox_WithdrawAmount);
            flowLayoutPanel2.Location = new Point(158, 88);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(114, 65);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // btn_Withdraw
            // 
            btn_Withdraw.Location = new Point(3, 3);
            btn_Withdraw.Name = "btn_Withdraw";
            btn_Withdraw.Size = new Size(75, 23);
            btn_Withdraw.TabIndex = 7;
            btn_Withdraw.Text = "Withdraw";
            btn_Withdraw.UseVisualStyleBackColor = true;
            btn_Withdraw.Click += btn_Withdraw_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 37);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 10;
            label3.Text = "Account Type: ";
            // 
            // label_AccType
            // 
            label_AccType.AutoSize = true;
            label_AccType.Location = new Point(158, 37);
            label_AccType.Name = "label_AccType";
            label_AccType.Size = new Size(92, 15);
            label_AccType.TabIndex = 11;
            label_AccType.Text = "<account type>";
            // 
            // AccountManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 175);
            Controls.Add(label_AccType);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label_Balance);
            Controls.Add(label1);
            Controls.Add(label_Username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AccountManagementForm";
            Text = "Account Management";
            Load += AccountManagementForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Username;
        private Label label1;
        private Label label_Balance;
        private Label label2;
        private Button btn_Deposit;
        private TextBox textBox_DepositAmount;
        private TextBox textBox_WithdrawAmount;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btn_Withdraw;
        private Label label3;
        private Label label_AccType;
    }
}