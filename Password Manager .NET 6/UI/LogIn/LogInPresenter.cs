using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.Tasks;
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
            _view.LoginByRememberMe = LoginByRememberMe;
        }

        private void LoginByRememberMe()
        {
            if (!string.IsNullOrEmpty(settings.Settings.Default.Email))
            {
                List<User> users = _database.SelectUsers();
                Application.OpenForms[nameof(FrmLogInOverview)].Hide();
                Application.OpenForms[nameof(FrmLogInOverview)].Close();
                if (GetTaskResult(users.First(x => x.Email == settings.Settings.Default.Email)))
                {
                    FrmMenü frmMenü = new(ref _user, ref _accounts);
                    frmMenü.ShowDialog();
                }
            }
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
            if (users.Any(x => x.Email == SecurePasswordHasher.GetEncryptString(_view.Email)) && SecurePasswordHasher.Verify(users.First(x => x.Email == SecurePasswordHasher.GetEncryptString(_view.Email)).Password, _view.Password))
            {
                if (GetTaskResult(users.First(x => x.Email == SecurePasswordHasher.GetEncryptString(_view.Email))))
                {
                    if (_view.RememberMe)
                    {
                        settings.Settings.Default.Email = SecurePasswordHasher.GetEncryptString(_user.Email);
                    }
                    else
                    {
                        settings.Settings.Default.Email = null;
                    }
                    settings.Settings.Default.Save();
                    Application.OpenForms[nameof(FrmLogInOverview)].Hide();
                    Application.OpenForms[nameof(FrmLogInOverview)].Close();
                    FrmMenü frmMenü = new(ref _user, ref _accounts);
                    frmMenü.ShowDialog();
                    return true;
                }
                else
                {
                    return false;
                    throw new Exception("Task failed");
                }
            }
            else
            {
                //PassProvider.SetError(txtEmail, "Wrong Data");
                //PassProvider.SetError(btnEyePassword, "Wrong Data");
                // TODO: Implement new Method PassInvailed
                return false;
            }
        }
    }
}
