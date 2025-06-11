using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace sicbo1
{
    public partial class BetForm : Form
    {
        public string SelectedBet { get; private set; }
        public int BetAmount { get; private set; }
        private PictureBox pictureBoxDice1;
        private PictureBox pictureBoxDice2;
        private PictureBox pictureBoxDice3;
        private System.Windows.Forms.Timer diceTimer;
        private Random random = new Random();
        private int animationCounter = 0;
        private int[] finalDicePoints = new int[3];
        public int[] FinalDicePoints => finalDicePoints;
        public BetForm(int balance)
        {
            InitializeComponent();
            labelBalance.Text = $"目前餘額：${balance}";
            comboBox1.Items.AddRange(new string[]
            {
                "大 (Big) 賠率1:1", "小 (Small) 賠率1:1", "點數 1 賠率2~4倍(依出現次數)", "點數 2 賠率2~4倍", "點數 3 賠率2~4倍",
                "點數 4 賠率2~4倍", "點數 5 賠率2~4倍", "點數 6 賠率2~4倍", "雙骰 1 賠率1:11(指定骰子出現兩次)", "雙骰 2 賠率1:11", "雙骰 3 賠率1:11",
                "雙骰 4 賠率1:11", "雙骰 5 賠率1:11", "雙骰 6 賠率1:11", "任意相同 賠率1:30", "豹子*3  賠率1:180", "總點 10 賠率1:6",
                "同時出現 2 和 3 賠率1:5"
            });

            comboBox1.SelectedIndex = 0;
            // 初始化骰子 PictureBox
            pictureBoxDice1 = new PictureBox() { Location = new Point(50, 200), Size = new Size(100, 100) };
            pictureBoxDice2 = new PictureBox() { Location = new Point(155, 200), Size = new Size(100, 100) };
            pictureBoxDice3 = new PictureBox() { Location = new Point(260, 200), Size = new Size(100, 100) };
            this.Controls.Add(pictureBoxDice1);
            this.Controls.Add(pictureBoxDice2);
            this.Controls.Add(pictureBoxDice3);

            // 初始化 Timer
            diceTimer = new System.Windows.Forms.Timer();
            diceTimer.Interval = 100;
            diceTimer.Tick += DiceTimer_Tick;
        }
        private void BetForm_Load(object sender, EventArgs e)
        {
            string bgPath = Path.Combine(Application.StartupPath, "images", "bgp3.png");
            if (File.Exists(bgPath))
            {
                this.BackgroundImage = Image.FromFile(bgPath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int amount) && amount > 0)
            {
                SelectedBet = comboBox1.SelectedItem.ToString();
                BetAmount = amount;
                // 先決定最終點數
                finalDicePoints[0] = random.Next(1, 7);
                finalDicePoints[1] = random.Next(1, 7);
                finalDicePoints[2] = random.Next(1, 7);

                // 啟動動畫
                diceTimer.Start();
                diceTimer.Stop();
                animationCounter = 0;

                LoadDiceImages(finalDicePoints[0], finalDicePoints[1], finalDicePoints[2]);

                MessageBox.Show($"最終點數：{finalDicePoints[0]}, {finalDicePoints[1]}, {finalDicePoints[2]}");

                // ✅ 關閉表單，把資料傳回去
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("請輸入有效金額");
            }
        }
        private void DiceTimer_Tick(object sender, EventArgs e)
        {
            int d1 = random.Next(1, 7);
            int d2 = random.Next(1, 7);
            int d3 = random.Next(1, 7);
            LoadDiceImages(d1, d2, d3);

            animationCounter++;
            if (animationCounter >= 10)
            {
                diceTimer.Stop();
                animationCounter = 0;

                LoadDiceImages(finalDicePoints[0], finalDicePoints[1], finalDicePoints[2]);
                MessageBox.Show($"最終點數：{finalDicePoints[0]}, {finalDicePoints[1]}, {finalDicePoints[2]}");
            }
        }
        private void LoadDiceImages(int d1, int d2, int d3)
        {
            pictureBoxDice1.Image = Image.FromFile($"images/dice{d1}.png");
            pictureBoxDice2.Image = Image.FromFile($"images/dice{d2}.png");
            pictureBoxDice3.Image = Image.FromFile($"images/dice{d3}.png");
        }
    }
}