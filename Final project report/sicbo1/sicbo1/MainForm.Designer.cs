namespace sicbo1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            buttonShop = new Button();
            labelActiveItems = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 15F);
            button1.Location = new Point(84, 359);
            button1.Name = "button1";
            button1.Size = new Size(135, 45);
            button1.TabIndex = 0;
            button1.Text = "開始下注";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 15F);
            button2.Location = new Point(403, 359);
            button2.Name = "button2";
            button2.Size = new Size(165, 45);
            button2.TabIndex = 1;
            button2.Text = "結束遊戲";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15F);
            label1.Location = new Point(87, 113);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 2;
            label1.Text = "餘額：$1000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15F);
            label2.Location = new Point(87, 149);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 3;
            label2.Text = "骰子點數：";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 20F);
            label3.Location = new Point(304, 35);
            label3.Name = "label3";
            label3.Size = new Size(201, 35);
            label3.TabIndex = 4;
            label3.Text = "🎲 骰寶遊戲 🎲";
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft JhengHei UI", 15F);
            button3.Location = new Point(574, 179);
            button3.Name = "button3";
            button3.Size = new Size(160, 45);
            button3.TabIndex = 5;
            button3.Text = "開啟歷史紀錄";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft JhengHei UI", 15F);
            button4.Location = new Point(574, 248);
            button4.Name = "button4";
            button4.Size = new Size(160, 45);
            button4.TabIndex = 6;
            button4.Text = "開啟遊戲說明";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft JhengHei UI", 15F);
            button5.Location = new Point(574, 317);
            button5.Name = "button5";
            button5.Size = new Size(160, 45);
            button5.TabIndex = 7;
            button5.Text = "開啟遊戲設定";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // buttonShop
            // 
            buttonShop.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonShop.Location = new Point(574, 113);
            buttonShop.Name = "buttonShop";
            buttonShop.Size = new Size(160, 45);
            buttonShop.TabIndex = 8;
            buttonShop.Text = "進入商店";
            buttonShop.UseVisualStyleBackColor = true;
            buttonShop.Click += buttonShop_Click;
            // 
            // labelActiveItems
            // 
            labelActiveItems.AutoSize = true;
            labelActiveItems.Font = new Font("Microsoft JhengHei UI", 15F);
            labelActiveItems.Location = new Point(87, 317);
            labelActiveItems.Name = "labelActiveItems";
            labelActiveItems.Size = new Size(0, 25);
            labelActiveItems.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelActiveItems);
            Controls.Add(buttonShop);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button buttonShop;
        private Label labelActiveItems;
    }
}
