namespace ch13_3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // �b�غc�l�����U�ƹ��ƥ�
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
        }
        // �o�Ӥ�k�i�H�d�ũΩ��l�Ƶ{���X
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red; // �w�]�I��������
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
