using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sicbo1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            string bgPath = Path.Combine(Application.StartupPath, "images", "bgp5.png");
            if (File.Exists(bgPath))
            {
                this.BackgroundImage = Image.FromFile(bgPath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            lblUsername.BackColor = Color.Transparent;
            lblPassword.BackColor = Color.Transparent;
            lblEmail.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }
        public User LoggedInUser { get; private set; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var users = UserManager.LoadUsers();
            var matchedUser = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (matchedUser != null)
            {
                LoggedInUser = matchedUser;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤！");
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog(); 
        }
    }
}
