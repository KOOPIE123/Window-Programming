using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Reflection.Emit;

namespace sicbo1
{
    public partial class RegisterForm : Form
    {
        private string pendingEmail = "";
        private string currentVerificationCode = "";
        private bool isEmailVerified = false; // ← 驗證狀態
        public RegisterForm()
        {
            InitializeComponent();
            string bgPath = Path.Combine(Application.StartupPath, "images", "bgp6.png");
            if (File.Exists(bgPath))
            {
                this.BackgroundImage = Image.FromFile(bgPath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        string jsonPath = Path.Combine(Application.StartupPath, "users.json");
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (!isEmailVerified)
            {
                MessageBox.Show("請先完成 Email 驗證！");
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("請完整填寫所有欄位。", "提示");
                return;
            }

            List<User> users = new List<User>();
            if (File.Exists(jsonPath))
            {
                string json = File.ReadAllText(jsonPath);
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }

            if (users.Exists(u => u.Username == username))
            {
                MessageBox.Show("此帳號已存在，請改用其他名稱。", "錯誤");
                return;
            }

            User newUser = new User
            {
                Username = username,
                Password = password,
                Email = email,
                Balance = 1000
            };

            users.Add(newUser);
            File.WriteAllText(jsonPath, JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true }));

            // 寄送 Email（未設 SMTP 的情況可先註解）
            SendConfirmationEmail(email, username);

            MessageBox.Show("註冊成功！初始餘額 $1000，已將確認信寄送至您的 Email。", "成功");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public static void SendConfirmationEmail(string toEmail, string username)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("seer90501@gmail.com");
                mail.To.Add(toEmail);
                mail.Subject = "殼寶遊戲 歡迎註冊成功";

                // 指定圖片路徑
                string bgPath = Path.Combine(Application.StartupPath, "images", "bgp7.png");
                string contentId = "gameImage";

                // HTML 內容：圖片放在最下方
                string htmlBody = $@"
                    <html>
                        <body style='font-family:Microsoft JhengHei;'>
                            <h4>Hi {username}，</h4>
                            <p>感謝你註冊殼寶遊戲帳號，祝你遊戲愉快！</p>
                            <p>註冊成功！我們已為你加值 <strong>$1000</strong> 初始遊戲幣 🎉</p>
                            <p>別忘了探索遊戲商城，享受豐富的內容與獎勵！</p>
                            <p>-----------------------------------------------------------------</p>
                            <p style='font-size:15px; color:#555;'>殼寶遊戲團隊 敬上</p>
                            <img src='cid:{contentId}' width='600' style='margin-top:20px;' />
                        </body>
                    </html>";

                // 建立 HTML 視圖 + 內嵌圖片
                AlternateView avHtml = AlternateView.CreateAlternateViewFromString(htmlBody, null, "text/html");
                LinkedResource inlineImage = new LinkedResource(bgPath, "image/png");
                inlineImage.ContentId = contentId;
                inlineImage.TransferEncoding = System.Net.Mime.TransferEncoding.Base64;
                avHtml.LinkedResources.Add(inlineImage);
                mail.AlternateViews.Add(avHtml);

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("seer90501@gmail.com", "lzortqmtmsbrlggx");

                client.Send(mail);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("寄送 Email 發生錯誤：" + ex.Message);
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string inputCode = txtVerificationCode.Text.Trim(); // 驗證碼輸入框
            if (inputCode == currentVerificationCode && txtEmail.Text.Trim() == pendingEmail)
            {
                isEmailVerified = true;
                MessageBox.Show("驗證成功！");
            }
            else
            {
                isEmailVerified = false;
                MessageBox.Show("驗證碼錯誤或 Email 不一致！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("請輸入 Email。");
                return;
            }

            // 產生隨機驗證碼
            Random rnd = new Random();
            currentVerificationCode = rnd.Next(100000, 999999).ToString();
            pendingEmail = email;
            // 寄出 Email
            try
            {
                MailMessage mail = new MailMessage("seer90501@gmail.com", email);
                mail.Subject = "您的註冊驗證碼";
                mail.Body = $"您好，您的驗證碼為：{currentVerificationCode}";
                string bgPath = Path.Combine(Application.StartupPath, "images", "bgp7.png");

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("seer90501@gmail.com", "lzortqmtmsbrlggx");
                client.Send(mail);

                MessageBox.Show("驗證碼已寄出，請至信箱查看。");
            }
            catch (Exception ex)
            {
                if (txtEmail.Text.Trim() != pendingEmail || txtVerificationCode.Text.Trim() != currentVerificationCode)
                {
                    MessageBox.Show("驗證碼錯誤或 Email 不符。");
                    return;
                }
            }
        }
    }
}
