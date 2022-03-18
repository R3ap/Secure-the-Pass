using Password_Manager_.NET_6.Tasks;
using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_.NET_6.UI.LogIn;
using Password_Manager_.NET_6.UI.Menü;
using Services_Core.Extensions;
using Services_Core.Model;
using Services_Core.Services.UserServices;
using settings = Password_Manager_.NET_6.Properties;

namespace Password_Manager_.NET_6.UI.LogInAndRegister.Login
{
    public class LogInPresenter : BaseDialogPresenter<ILogIn>
    {
        private User _user;
        private List<Account> _accounts;
        private readonly IUserService _database = new UserService();
        public LogInPresenter() : base(new FrmLogIn()) 
        {
            View.OnAcceptClick = LogIn;
            View.LoginByRememberMe = LoginByRememberMe;
        }

        private void LoginByRememberMe()
        {
            if (!string.IsNullOrEmpty(settings.Settings.Default.Email))
            {
                IList<User> users = _database.SelectUsers();
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
            InizializeTask inizializeTask = new();
            _user = inizializeTask.InitializeUser(user).Result;
            _accounts = inizializeTask.InitializeAccounts().Result.ToList();
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
            IList<User> users = _database.SelectUsers();
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
                View.InvalidData();
                return false;
            }
        }
    }
}
