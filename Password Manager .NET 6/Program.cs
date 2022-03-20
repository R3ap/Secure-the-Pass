using Password_Manager_.NET_6.UI.ErrorHandler;
using Password_Manager_.NET_6.UI.LogInAndRegister.Overview;

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
                new OverviewPresenter().ShowDialog();
            }
            catch (Exception ex)
            {
                ErrorHandlerPresenter error = new();
                error.SetErrorMessage(ex);
                error.ShowDialog();
            }
        }
    }
}