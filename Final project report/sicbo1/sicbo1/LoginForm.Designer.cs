namespace sicbo1
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        // 所有元件欄位宣告
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
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
            btnLogin = new Button();
            btnRegister = new Button();
            lblStatus = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblUsername.Location = new Point(216, 136);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(122, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "使用者名稱 :";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txtUsername.Location = new Point(344, 128);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(145, 33);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblPassword.ForeColor = SystemColors.ActiveCaptionText;
            lblPassword.Location = new Point(216, 188);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(62, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "密碼 :";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txtPassword.Location = new Point(344, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(145, 33);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnLogin.Location = new Point(224, 331);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 55);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "登入";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnRegister.Location = new Point(512, 331);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(114, 55);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "註冊";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(0, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblEmail.Location = new Point(216, 239);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(85, 25);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email：";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txtEmail.Location = new Point(344, 231);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(294, 33);
            txtEmail.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 20F);
            label3.Location = new Point(255, 35);
            label3.Name = "label3";
            label3.Size = new Size(309, 35);
            label3.TabIndex = 9;
            label3.Text = "🎲 骰寶遊戲登入介面 🎲";
            // 
            // LoginForm
            // 
            ClientSize = new Size(816, 489);
            Controls.Add(label3);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(lblStatus);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Name = "LoginForm";
            Text = "使用者登入";
            ResumeLayout(false);
            PerformLayout();

        }
        private Label label3;
    }
    #endregion
}