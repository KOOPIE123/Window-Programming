using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace sicbo1
{
    public partial class ShopForm : Form
    {
        private int playerBalance;

        public bool MultiplierBoostPurchased { get; private set; } = false;
        public bool GuaranteeWinPurchased { get; private set; } = false;
        public bool NoLosePenaltyPurchased { get; private set; } = false;

        public ShopForm(int currentBalance)
        {
            playerBalance = currentBalance;
            InitializeComponent();
            lblBalance.Text = $"目前餘額：${playerBalance}";
        }

        public int GetRemainingBalance() => playerBalance;

        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemList == null || lblDescription == null || itemPicture == null) return;

            switch (itemList.SelectedIndex)
            {
                case 0:
                    lblDescription.Text = "使用後可使下次獲勝獎勵乘上10倍";
                    itemPicture.Image = Image.FromFile(Path.Combine(Application.StartupPath, "images", "cash.png"));
                    break;
                case 1:
                    lblDescription.Text = "下次遊戲將必定獲勝，僅觸發一次";
                    itemPicture.Image = Image.FromFile(Path.Combine(Application.StartupPath, "images", "target.png"));
                    break;
                case 2:
                    lblDescription.Text = "下次若輸了，將不扣任何金額";
                    itemPicture.Image = Image.FromFile(Path.Combine(Application.StartupPath, "images", "tate.png"));
                    break;
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (itemList == null || lblBalance == null) return;

            switch (itemList.SelectedIndex)
            {
                case 0:
                    if (playerBalance >= 500)
                    {
                        playerBalance -= 500;
                        lblBalance.Text = $"目前餘額：${playerBalance}";
                        MultiplierBoostPurchased = true;
                        MessageBox.Show("購買成功！下次獲勝倍率將提升10倍！");
                    }
                    else
                    {
                        MessageBox.Show("餘額不足，無法購買");
                    }
                    break;
                case 1:
                    if (playerBalance >= 800)
                    {
                        playerBalance -= 800;
                        lblBalance.Text = $"目前餘額：${playerBalance}";
                        GuaranteeWinPurchased = true;
                        MessageBox.Show("購買成功！下次遊戲必中！");
                    }
                    else
                    {
                        MessageBox.Show("餘額不足，無法購買");
                    }
                    break;
                case 2:
                    if (playerBalance >= 600)
                    {
                        playerBalance -= 600;
                        lblBalance.Text = $"目前餘額：${playerBalance}";
                        NoLosePenaltyPurchased = true;
                        MessageBox.Show("購買成功！下次輸了不扣錢！");
                    }
                    else
                    {
                        MessageBox.Show("餘額不足，無法購買");
                    }
                    break;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            string bgPath = Path.Combine(Application.StartupPath, "images", "sale.png");
            if (File.Exists(bgPath))
            {
                this.BackgroundImage = Image.FromFile(bgPath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            lblBalance.BackColor = Color.Transparent;
            lblDescription.BackColor = Color.Transparent;
        }
    }
}
