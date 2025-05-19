namespace ch13_3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 在建構子中註冊滑鼠事件
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
        }
        // 這個方法可以留空或放初始化程式碼
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red; // 預設背景為紅色
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.Yellow;
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.BackColor = Color.Green;
            }
        }
    }
}
