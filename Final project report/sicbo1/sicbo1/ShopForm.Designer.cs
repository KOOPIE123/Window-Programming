// ShopForm.Designer.cs - Visual Studio 設計工具相容版
namespace sicbo1
{
    partial class ShopForm
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

        private void InitializeComponent()
        {
            lblBalance = new Label();
            itemList = new ListBox();
            lblDescription = new Label();
            buyButton = new Button();
            buttonClose = new Button();
            itemPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)itemPicture).BeginInit();
            SuspendLayout();
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblBalance.Location = new Point(20, 29);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(172, 25);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "目前餘額：$1000";
            // 
            // itemList
            // 
            itemList.Font = new Font("Microsoft JhengHei UI", 15F);
            itemList.FormattingEnabled = true;
            itemList.ItemHeight = 25;
            itemList.Items.AddRange(new object[] { "倍率提升道具（$500）", "必中一次道具（$800）", "保底道具：輸了不扣錢（$600）" });
            itemList.Location = new Point(20, 61);
            itemList.Name = "itemList";
            itemList.Size = new Size(300, 204);
            itemList.TabIndex = 1;
            itemList.SelectedIndexChanged += itemList_SelectedIndexChanged;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblDescription.Location = new Point(337, 61);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(316, 25);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "使用後可使下次獲勝獎勵乘上10倍";
            // 
            // buyButton
            // 
            buyButton.BackColor = SystemColors.ActiveBorder;
            buyButton.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            buyButton.Location = new Point(20, 286);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(147, 45);
            buyButton.TabIndex = 3;
            buyButton.Text = "購買所選道具";
            buyButton.UseVisualStyleBackColor = false;
            buyButton.Click += buyButton_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = SystemColors.ActiveBorder;
            buttonClose.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            buttonClose.Location = new Point(173, 286);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(147, 45);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "關閉";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // itemPicture
            // 
            itemPicture.Location = new Point(400, 113);
            itemPicture.Name = "itemPicture";
            itemPicture.Size = new Size(213, 197);
            itemPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            itemPicture.TabIndex = 5;
            itemPicture.TabStop = false;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 372);
            Controls.Add(itemPicture);
            Controls.Add(buttonClose);
            Controls.Add(buyButton);
            Controls.Add(lblDescription);
            Controls.Add(itemList);
            Controls.Add(lblBalance);
            Name = "ShopForm";
            Text = "遊戲商店";
            Load += ShopForm_Load;
            ((System.ComponentModel.ISupportInitialize)itemPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox itemPicture;
    }
}
