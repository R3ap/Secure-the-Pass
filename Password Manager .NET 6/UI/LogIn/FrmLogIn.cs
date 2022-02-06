using settings = Password_Manager_.NET_6.Properties;
using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.Tasks;
using Password_Manager_.NET_6.UI.BaseDialog;

namespace Password_Manager_.NET_6.UI.LogIn
{
    public partial class FrmLogIn : FrmBaseDialog, ILogIn
    {

        public FrmLogIn()
        {
            InitializeComponent();
        }


        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //LogIn();
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
                //if (!string.IsNullOrEmpty(settings.Settings.Default.Email))
                //{
                //    List<User> users = _database.SelectUsers();
                //    Application.OpenForms["FrmLogInRegister"].Hide();
                //    bool IsTaskSuccess = GetTaskResult(users.First(x => x.Email == settings.Settings.Default.Email));
                //    if (IsTaskSuccess)
                //    {
                //        FrmMenü frmMenü = new(_user, _accounts);
                //        frmMenü.ShowDialog();
                //    }
                //}
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
