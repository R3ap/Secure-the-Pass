using Secure_The_Pass.UI.LogInAndRegister.Overview;
using Secure_The_Pass.UI.ErrorHandler;

namespace Secure_The_Pass
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