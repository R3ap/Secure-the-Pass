using settings = Password_Manager_.NET_6.Properties;
using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_.NET_6.UI.LogInAndRegister.Login;
using Password_Manager_.NET_6.UI.ErrorHandler;

namespace Password_Manager_.NET_6.UI.LogIn
{
    public partial class FrmLogIn : FrmBaseDialog, ILogIn
    {
        public Action LoginByRememberMe { get; set; }

        public bool RememberMe { get => ChkRememberMe.Checked; set => ChkRememberMe.Checked = value; }

        public string Email { get => TxtEmail.Text; set => TxtEmail.Text = value; }

        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }

        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OnAcceptClick?.Invoke();
            }
        }

        public void InvalidData()
        {
            PassProvider.SetError(TxtEmail, "Wrong Data");
            PassProvider.SetError(txtPassword, "Wrong Data");
        }

        private void LlblForgotPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgotPW frmForgotPW = new();
            frmForgotPW.ShowDialog();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            try
            {
                Dock = DockStyle.Fill;
                TopLevel = false;
                TopMost = true;

                if (!string.IsNullOrEmpty(settings.Settings.Default.Email))
                {
                    LoginByRememberMe?.Invoke();
                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private static void Error(Exception ex)
        {
            ErrorHandlerPresenter errorHandler = new();
            errorHandler.SetErrorMessage(ex, "Login Error");
            errorHandler.ShowDialog();
        }
    }
}
