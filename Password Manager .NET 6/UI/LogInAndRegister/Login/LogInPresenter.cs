using Password_Manager_.NET_6.Extensions;
using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.Tasks;
using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_.NET_6.UI.LogIn;
using Password_Manager_.NET_6.UI.Menü;
using settings = Password_Manager_.NET_6.Properties;

namespace Password_Manager_.NET_6.UI.LogInAndRegister.Login
{
    public class LogInPresenter : BaseDialogPresenter<ILogIn>
    {
        private User _user;
        private List<Account> _accounts;
        private readonly DatabaseAccess _database = new();
        public LogInPresenter() : base(new FrmLogIn()) 
        {
            View.OnAcceptClick = LogIn;
            View.LoginByRememberMe = LoginByRememberMe;
        }

        private void LoginByRememberMe()
        {
            if (!string.IsNullOrEmpty(settings.Settings.Default.Email))
            {
                List<User> users = _database.SelectUsers();
                Application.OpenForms[nameof(FrmOverview)].Hide();
                Application.OpenForms[nameof(FrmOverview)].Close();
                if (GetTaskResult(users.First(x => x.Email == settings.Settings.Default.Email)))
                {
                    MenüPresenter frmMenü = new(ref _user, ref _accounts);
                    frmMenü.ShowDialog();
                }
            }
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
            if (users.Any(x => x.Email == View.Email.GetEncryptString()) && View.Password.Verify(users.First(x => x.Email == View.Email.GetEncryptString()).Password))
            {
                if (GetTaskResult(users.First(x => x.Email == View.Email.GetEncryptString())))
                {
                    if (View.RememberMe)
                    {
                        settings.Settings.Default.Email = _user.Email.GetEncryptString();
                    }
                    else
                    {
                        settings.Settings.Default.Email = null;
                    }
                    settings.Settings.Default.Save();
                    Application.OpenForms[nameof(FrmOverview)].Hide();
                    Application.OpenForms[nameof(FrmOverview)].Close();
                    MenüPresenter menü = new(ref _user, ref _accounts);
                    menü.ShowDialog();
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
