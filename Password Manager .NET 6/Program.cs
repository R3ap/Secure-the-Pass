using Password_Manager_.NET_6.UI.LogIn;

namespace Password_Manager_.NET_6
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                new FrmLogInOverview().ShowDialog();
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler();
                error.ShowDialog(ex);
            }
        }
    }
}