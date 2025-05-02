using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ch8_3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                string inputText = textBox1.Text.Trim();
                string[] input = inputText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] numbers = input.Select(n => int.Parse(n)).ToArray();

                for (int i = 0; i < numbers.Length; i++)
                {
                    int min = arrMin(numbers);
                    int max = arrMax(numbers);
                    label2.Text = $"最小值: {min}" + $" ， 最大值: {max}";
                }
            }
     
             private int arrMin(int[] arr)
             {
                int min = arr[0];
                foreach (int n in arr)
                {
                    if (n < min)
                        min = n;
                }
                return min;
             }

            private int arrMax(int[] arr)
            {
                int max = arr[0];
                foreach (int n in arr)
                {
                if (n > max)
                    max = n;
                }
                return max;
            }
    }
}

