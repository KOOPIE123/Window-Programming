namespace sicbo1
{
    partial class BetForm
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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            labelBalance = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(61, 168);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 0;
            label1.Text = "選擇下注類型：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(61, 111);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 1;
            label2.Text = "輸入下注金額：";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft JhengHei UI", 15F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(219, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(323, 33);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft JhengHei UI", 15F);
            textBox1.Location = new Point(219, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 33);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button1.Location = new Point(615, 322);
            button1.Name = "button1";
            button1.Size = new Size(116, 58);
            button1.TabIndex = 4;
            button1.Text = "確認下注";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            labelBalance.Location = new Point(61, 62);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(0, 25);
            labelBalance.TabIndex = 5;
            // 
            // BetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelBalance);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BetForm";
            Text = "BetForm";
            Load += BetForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
        private Label labelBalance;
    }
}