using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sicbo1
{
    public partial class HistoryForm : Form
    {
        private List<string> historyList;

        public HistoryForm(List<string> history)
        {
            InitializeComponent();
            historyList = history;

            // 將歷史資料加入 ListBox 顯示
            listBox1.Items.Clear();
            foreach (var record in historyList)
            {
                listBox1.Items.Add(record);
            }

            label2.Text = $"總局數：{historyList.Count}";
        }


        private void HistoryForm_Load(object sender, EventArgs e)
        {
            string bgPath = Path.Combine(Application.StartupPath, "images", "bgp1.png");
            if (File.Exists(bgPath))
            {
                this.BackgroundImage = Image.FromFile(bgPath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }

            // 可選：讓 label 和 listbox 背景透明
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            listBox1.BackColor = Color.WhiteSmoke; // 或用 LightGray / Transparent 看你喜歡
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            historyList.Clear();
            listBox1.Items.Clear();
            label2.Text = "總局數：0";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
