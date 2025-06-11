// MainForm.cs - 主程式碼檔
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Media;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace sicbo1
{
    public partial class MainForm : Form
    {
       
        private bool soundEnabled = true;
        private bool hasMultiplierBoost = false;
        private bool hasGuaranteeWin = false;
        private bool hasNoLosePenalty = false;
        private User currentUser;
        private List<string> history = new List<string>();
        private PictureBox pictureBoxDice1;
        private PictureBox pictureBoxDice2;
        private PictureBox pictureBoxDice3;

        public MainForm(User user)
        {
            InitializeComponent();
            this.currentUser = user;

            label1.Text = $"餘額：${currentUser.Balance}";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string bgPath = Path.Combine(Application.StartupPath, "images", "bgp1.png");
            if (File.Exists(bgPath))
            {
                this.BackgroundImage = Image.FromFile(bgPath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            // 美化所有主要按鈕
            StyleButton(button1); // 開始下注
            StyleButton(button2); // 結束遊戲
            StyleButton(button3); // 開啟歷史紀錄
            StyleButton(button4); // 開啟遊戲說明
            StyleButton(button5); // 開啟遊戲設定
            StyleButton(buttonShop); // 進入商店

            Font unifiedFont = new Font("微軟正黑體", 20F, FontStyle.Bold);
            label1.Font = unifiedFont;
            label2.Font = unifiedFont;
            label3.Font = unifiedFont;
            labelActiveItems.Font = unifiedFont;

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            labelActiveItems.BackColor = Color.Transparent;

            pictureBoxDice1 = new PictureBox()
            {
                Location = new Point(70, 200),
                Size = new Size(100, 100),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            pictureBoxDice2 = new PictureBox()
            {
                Location = new Point(190, 200),
                Size = new Size(100, 100),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            pictureBoxDice3 = new PictureBox()
            {
                Location = new Point(310, 200),
                Size = new Size(100, 100),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            this.Controls.Add(pictureBoxDice1);
            this.Controls.Add(pictureBoxDice2);
            this.Controls.Add(pictureBoxDice3);
        }
        private void UpdateDiceImages(int d1, int d2, int d3)
        {
            pictureBoxDice1.Image = Image.FromFile($"images/dice{d1}.png");
            pictureBoxDice2.Image = Image.FromFile($"images/dice{d2}.png");
            pictureBoxDice3.Image = Image.FromFile($"images/dice{d3}.png");
        }
        private void PlaySound(string soundFile)
        {
            if (!soundEnabled) return; // 如果沒啟用音效，直接跳出

            try
            {
                SoundPlayer player = new SoundPlayer(soundFile);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("音效播放錯誤：" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var betForm = new BetForm(currentUser.Balance))
            {
                if (betForm.ShowDialog() == DialogResult.OK)
                {
                    string bet = betForm.SelectedBet;
                    int amount = betForm.BetAmount;
                    int[] result = betForm.FinalDicePoints;

                    if (amount > currentUser.Balance)
                    {
                        MessageBox.Show("餘額不足，請重新下注！");
                        return;
                    }

                    // 先扣除下注金額
                    currentUser.Balance -= amount;

                    // 顯示擲骰結果
                    UpdateDiceImages(result[0], result[1], result[2]);
                    label2.Text = $"骰子點數：{string.Join(", ", result)}";

                    // 計算賠率
                    int multiplier = hasGuaranteeWin ? 2 : GameEngine.CalculatePayout(bet, result);
                    if (hasGuaranteeWin) hasGuaranteeWin = false;
                    if (hasMultiplierBoost)
                    {
                        multiplier *= 10;
                        hasMultiplierBoost = false;
                    }

                    int payout = amount * multiplier;
                    int netGain = payout;

                    // 保底道具處理（如果輸錢）
                    if (multiplier == 0 && hasNoLosePenalty)
                    {
                        currentUser.Balance += amount; // 退還下注金額
                        hasNoLosePenalty = false;
                        netGain = 0;
                        MessageBox.Show("你本來會輸錢，但保底道具發動，這回合不扣錢！", "保底發動");
                    }
                    else
                    {
                        currentUser.Balance += payout;
                    }

                    // 更新餘額顯示
                    label1.Text = $"餘額：${currentUser.Balance}";
                    UpdateActiveItemLabel();

                    // 記錄歷史
                    history.Add($"下注：{bet}，金額：{amount}，結果：{string.Join(", ", result)}，獲得：{payout - amount}");

                    // 播放音效與訊息
                    if (multiplier > 1)
                    {
                        PlaySound("soundeffect/lose.wav");
                        MessageBox.Show($"你贏了 ${payout - amount}！", "結果");
                    }
                    else if (multiplier == 1)
                    {
                        PlaySound("soundeffect/lose.wav");
                        MessageBox.Show("平手！", "結果");
                    }
                    else
                    {
                        PlaySound("soundeffect/vitory.wav");
                        MessageBox.Show("你輸了！", "結果");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // currentUser.Balance 早已是最新餘額
            var users = UserManager.LoadUsers();
            var userInList = users.FirstOrDefault(u => u.Username == currentUser.Username);
            if (userInList != null)
            {
                userInList.Balance = currentUser.Balance;
            }

            UserManager.SaveUsers(users);
            UserManager.UpdateUserBalance(currentUser.Username, currentUser.Balance);
            UserManager.SendFinalBalanceEmail(currentUser.Email, currentUser.Username, currentUser.Balance);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var historyForm = new HistoryForm(history))
            {
                historyForm.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var helpForm = new HelpForm())
            {
                helpForm.ShowDialog();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new SettingsForm())
            {
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    currentUser.Balance = settingsForm.InitialBalance;
                    soundEnabled = settingsForm.EnableSound;
                    label1.Text = $"餘額：${currentUser.Balance}";
                }
            }
        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            using (var shopForm = new ShopForm(currentUser.Balance))
            {
                if (shopForm.ShowDialog() == DialogResult.OK)
                {
                    currentUser.Balance = shopForm.GetRemainingBalance();
                    hasMultiplierBoost = shopForm.MultiplierBoostPurchased;
                    hasGuaranteeWin = shopForm.GuaranteeWinPurchased;
                    hasNoLosePenalty = shopForm.NoLosePenaltyPurchased;

                    label1.Text = $"餘額：${currentUser.Balance}";
                    UpdateActiveItemLabel();
                }
            }
        }

        private void UpdateActiveItemLabel()
        {
            List<string> active = new List<string>();
            if (hasMultiplierBoost) active.Add("倍率提升");
            if (hasGuaranteeWin) active.Add("必中一次");
            if (hasNoLosePenalty) active.Add("保底不扣錢");

            labelActiveItems.Text = "已啟用道具：" + (active.Count > 0 ? string.Join("、", active) : "無");
        }
        private void StyleButton(Button btn)
        {
            btn.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            btn.BackColor = Color.Gainsboro;         // 淡灰白背景
            btn.ForeColor = Color.Black;             // 黑字
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.DimGray; // 邊框灰
            btn.Cursor = Cursors.Hand;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
