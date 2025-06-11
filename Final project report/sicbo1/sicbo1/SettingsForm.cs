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
    public partial class SettingsForm : Form
    {
        public int InitialBalance { get; private set; }
        public bool EnableSound { get; private set; }

        public SettingsForm(int currentBalance, bool soundEnabled)
        {
            InitializeComponent();

            textBox1.Text = currentBalance.ToString();
            checkBox1.Checked = soundEnabled;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            string bgPath = Path.Combine(Application.StartupPath, "images", "bgp4.png");
            if (File.Exists(bgPath))
            {
                this.BackgroundImage = Image.FromFile(bgPath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            checkBox1.BackColor = Color.Transparent;
        }
        public SettingsForm()
        {
            InitializeComponent();
            textBox1.Text = "1000"; // 預設餘額
            checkBox1.Checked = true; // 預設啟用音效
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int balance) && balance >= 0)
            {
                InitialBalance = balance;
                EnableSound = checkBox1.Checked;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("請輸入有效的餘額（非負整數）");
            }
        }
    }
}
