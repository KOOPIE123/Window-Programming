using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms; // 用於 MessageBox
using System.Windows.Forms.VisualStyles; // 防止 Application.StartupPath 錯誤

namespace sicbo1
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; } // 這裡建議之後加密
        public string Email { get; set; }
        public int Balance { get; set; }
    }

    public static class UserManager
    {
        private static string filePath = Path.Combine(Application.StartupPath, "users.json");

        public static List<User> LoadUsers()
        {
            if (!File.Exists(filePath))
                return new List<User>();

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<User>>(json);
        }

        public static void SaveUsers(List<User> users)
        {
            string json = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static User Login(string username, string password)
        {
            var users = LoadUsers();
            return users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public static void UpdateUserBalance(string username, int newBalance)
        {
            var users = LoadUsers();
            var user = users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                user.Balance = newBalance;
                SaveUsers(users);
            }
        }
        public static void SendFinalBalanceEmail(string toEmail, string username, int balance)
        {
            try
            {
                MailMessage mail = new MailMessage("seer90501@gmail.com", toEmail);
                mail.Subject = "遊戲結束餘額通知";
                // 內嵌圖片準備
                string bgPath = Path.Combine(Application.StartupPath, "images", "bgp7.png");
                string contentId = "gameImage";

                    // HTML 內容 + 內嵌圖片
                    string html = $@"
                <html>
                    <body>
                        <p>Hi {username}，</p>
                        <p>感謝你參與本次遊戲。</p>
                        <p>目前剩餘餘額為：<strong>${balance}</strong>。</p>
                        <p>謝謝，下次光臨！</p>
                        <p>-----------------------------------------------------------------</p>
                        <p style='font-size:15px; color:#555;'>殼寶遊戲團隊 敬上</p>
                        <img src='cid:{contentId}' width='600' style='margin-top:20px;' />
                    </body>
                </html>";

                // 建立 HTML 視圖 + 內嵌圖片
                AlternateView avHtml = AlternateView.CreateAlternateViewFromString(html, null, "text/html");
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
                MessageBox.Show("寄送餘額 Email 失敗：" + ex.Message);
            }
        }
    }
}
