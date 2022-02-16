using settings = Password_Manager_.NET_6.Properties;
using Password_Manager_.NET_6.UI.BaseDialog;

namespace Password_Manager_.NET_6.UI.LogIn
{
    public partial class FrmLogIn : FrmBaseDialog, ILogIn
    {
        public new Func<string, string, bool, bool> OnAcceptClick { get; set; }
        public Action LoginByRememberMe { get;  set; }

        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AcceptClick();
            }
        }

        public void AcceptClick()
        {
            if (OnAcceptClick?.Invoke(txtEmail.Text, txtPassword.Text, ChkRememberMe.Checked) ?? true)
            {
                DialogResult = enumDialogResult.OK;
            }
            else
            {
                DialogResult = enumDialogResult.Cancel;
            }
        }

        private void btnEyePassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnEyePassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '•';
        }

        private void CtrlLogIn_Load(object sender, EventArgs e)
        {
            try
            {
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
            ErrorHandler error = new();
            error.ShowDialog(ex);
        }
    }
}
