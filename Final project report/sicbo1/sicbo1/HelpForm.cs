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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            richTextBox1.Text =
                @"🎲【骰寶（Sic Bo）遊戲說明】🎲

                1️⃣ 基本規則：
                - 投擲三顆骰子。
                - 玩家可下注各種點數組合或範圍。

                2️⃣ 常見下注類型：
                - 大：總點數 11~17（不含三顆相同）
                - 小：總點數 4~10（不含三顆相同）
                - 單一點數：押其中一個點數出現幾次
                - 雙骰/三骰：押指定點數出現兩次或三次
                - 總點數：押三顆骰子總和為指定點
                - 兩骰組合：押兩個指定點數同時出現

                3️⃣ 派彩範例：
                - 單一點數中 1 次：賠率 1:1
                - 雙骰：賠率 1:11
                - 任意三骰：賠率 1:30
                - 指定三骰：賠率 1:180

                📝 提示：
                - 若開出三顆相同點數，大、小皆為輸。
                - 選擇合適賠率與風險進行下注！";

                label2.Text = "版本：v1.0";
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            string bgPath = Path.Combine(Application.StartupPath, "images", "bgp2.png");
            if (File.Exists(bgPath))
            {
                this.BackgroundImage = Image.FromFile(bgPath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
