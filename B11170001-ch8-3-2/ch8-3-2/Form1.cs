using System;
using System.Linq;
using System.Windows.Forms;
namespace ch8_3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[5];
            Random rand = new Random();

            // 產生 1~200 的亂數並放入陣列
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 201); // 上限是 exclusive，所以用 201
            }

            // 排序
            Array.Sort(numbers);

            // 顯示結果
            label1.Text = "排序後陣列： " + string.Join(", ", numbers);
        }
    }
}
