namespace sicbo1
{
    partial class RegisterForm
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
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            button1 = new Button();
            lblStatus = new Label();
            btnSendCode = new Button();
            txtVerificationCode = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblUsername.Location = new Point(156, 93);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(72, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "帳號：";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txtUsername.Location = new Point(234, 90);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(278, 33);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblPassword.Location = new Point(156, 143);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(72, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "密碼：";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txtPassword.Location = new Point(234, 140);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(278, 33);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblEmail.Location = new Point(156, 193);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(75, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txtEmail.Location = new Point(234, 190);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 33);
            txtEmail.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button1.Location = new Point(156, 322);
            button1.Name = "button1";
            button1.Size = new Size(122, 52);
            button1.TabIndex = 6;
            button1.Text = "驗證並註冊";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRegister_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblStatus.Location = new Point(156, 250);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 25);
            lblStatus.TabIndex = 7;
            // 
            // btnSendCode
            // 
            btnSendCode.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnSendCode.Location = new Point(534, 186);
            btnSendCode.Name = "btnSendCode";
            btnSendCode.Size = new Size(122, 39);
            btnSendCode.TabIndex = 8;
            btnSendCode.Text = "寄送驗證碼";
            btnSendCode.UseVisualStyleBackColor = true;
            btnSendCode.Click += button2_Click;
            // 
            // txtVerificationCode
            // 
            txtVerificationCode.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txtVerificationCode.Location = new Point(234, 242);
            txtVerificationCode.Name = "txtVerificationCode";
            txtVerificationCode.Size = new Size(278, 33);
            txtVerificationCode.TabIndex = 9;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnRegister.Location = new Point(534, 238);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(122, 39);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "驗證";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(txtVerificationCode);
            Controls.Add(btnSendCode);
            Controls.Add(lblStatus);
            Controls.Add(button1);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button button1;
        private Label lblStatus;
        private Button btnSendCode;
        private TextBox txtVerificationCode;
        private Button btnRegister;
    }
}