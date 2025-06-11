namespace sicbo1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // �Y�n�J���\�A���o�n�J�� User ���
                    var user = loginForm.LoggedInUser;

                    // �ǻ��b���T��D�e��
                    Application.Run(new MainForm(user));
                }
            }
        }
    }
}