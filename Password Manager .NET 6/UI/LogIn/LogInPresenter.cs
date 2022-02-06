using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.Tasks;
using Password_Manager_.NET_6.UI.BaseDialog;
using settings = Password_Manager_.NET_6.Properties;

namespace Password_Manager_.NET_6.UI.LogIn
{
    public class LogInPresenter
    {
        private ILogIn _view = new FrmLogIn() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private User _user;
        private List<Account> _accounts;
        private readonly DatabaseAccess _database = new();
        public LogInPresenter()
        {
            _view.OnAcceptClick = LogIn;
        }


        private void Register()
        {

        }

        public void Show()
        {
            _view.Show();
        }

        public void ShowDialog()
        {
            _view.ShowDialog();
        }

        private bool GetTaskResult(User user)
        {
            InizializeTask inizializeTask = new InizializeTask();
            _user = inizializeTask.InitializeUser(user).Result;
            _accounts = inizializeTask.InitializeAccounts().Result;
            DialogResult dialogResult = DialogResult.None;
            if (_user == null)
            {
                dialogResult = MessageBox.Show("This Task Initialize User", "Task Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (_accounts == null)
            {
                dialogResult = MessageBox.Show("This Task Initialize Accounts", "Task Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dialogResult == DialogResult.OK)
            {
                return false;
            }

            return true;
        }

        public bool LogIn()
        {
            List<User> users = _database.SelectUsers();
            if (users.Any(x => x.Email == SecurePasswordHasher.GetEncryptString(txtEmail.Text)) && SecurePasswordHasher.Verify(users.First(x => x.Email == SecurePasswordHasher.GetEncryptString(txtEmail.Text)).Password, txtPassword.Text))
            {
                Application.OpenForms["FrmLogInRegister"].Hide();
                bool IsTaskSuccess = GetTaskResult(users.First(x => x.Email == SecurePasswordHasher.GetEncryptString(txtEmail.Text)));
                if (IsTaskSuccess)
                {
                    if (chkStayLogged.Checked)
                    {
                        settings.Settings.Default.Email = SecurePasswordHasher.GetEncryptString(_user.Email);
                    }
                    else
                    {
                        settings.Settings.Default.Email = null;
                    }
                    settings.Settings.Default.Save();
                    FrmMenü frmMenü = new(_user, _accounts);
                    frmMenü.ShowDialog();
                    return true;
                }
            }
            else
            {
                PassProvider.SetError(txtEmail, "Wrong Data");
                PassProvider.SetError(btnEyePassword, "Wrong Data");
                return false;
            }
        }

    }
}
