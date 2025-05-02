namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
                Random rnd = new Random();
                int[] str = new int[5];
                int sum;
                for (int i = 0; i < 5; i++)
                {
                    str[i] = rnd.Next(1, 200);
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (str[i] < str[j])
                        {
                            sum = str[i];
                            str[i] = str[j];
                            str[j] = sum;
                        }
                    }
                    label1.Text = string.Join(",",str);
                }
            }
    }
}
