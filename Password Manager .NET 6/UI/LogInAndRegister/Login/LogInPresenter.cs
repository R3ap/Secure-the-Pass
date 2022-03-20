using Microsoft.VisualBasic.Logging;
using Password_Manager_.NET_6.Tasks;
using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_.NET_6.UI.LogIn;
using Password_Manager_.NET_6.UI.Menü;
using Password_Manager_Services_Core.Extensions;
using Password_Manager_Services_Core.Model;
using Password_Manager_Services_Core.Services.UserServices;
using System.Diagnostics;
using System.Globalization;
using System.Management;
using settings = Password_Manager_.NET_6.Properties;

namespace Password_Manager_.NET_6.UI.LogInAndRegister.Login
{
    public class LogInPresenter : BaseDialogPresenter<ILogIn>
    {
        private User _user;
        private List<Account> _accounts;
        private readonly IUserService _userService = new UserService();
        public LogInPresenter() : base(new FrmLogIn())
        {
            View.OnAcceptClick = LogIn;
            View.LoginByRememberMe = LoginByRememberMe;
            Log log = new("Password Manager logs");
            log.WriteEntry("Log message example", TraceEventType.Information, 1);
        }

        private void LoginByRememberMe()
        {
            if (!string.IsNullOrEmpty(settings.Settings.Default.Email))
            {
                IList<User> users = _userService.SelectUsers();
                Application.OpenForms[nameof(FrmOverview)].Hide();
                Application.OpenForms[nameof(FrmOverview)].Close();
                if (GetTaskResult(users.First(x => x.Email == settings.Settings.Default.Email)))
                {
                    MenüPresenter frmMenü = new(ref _user, ref _accounts);
                    frmMenü.ShowDialog();
                }
            }
        }

        private DateTime GetLastAppStartup()
        {
            var lastAppStartup = File.ReadAllText("lastbootuptime.txt");
            return DateTime.ParseExact(lastAppStartup, "yyyy-MM-dd hh:mm:ss", CultureInfo.InvariantCulture);
        }

        private DateTime GetLastBootUpTime()
        {
            var query = new SelectQuery(@"SELECT * FROM Win32_OperatingSystem");
            var searcher = new ManagementObjectSearcher(query);
            var result = DateTime.Now;

            foreach (ManagementObject mo in searcher.Get())
            {
                result = ManagementDateTimeConverter
                            .ToDateTime(mo.Properties["LastBootUpTime"].Value.ToString());
            }

            return result;
        }


        public bool LogIn()
        {
            IList<User> users = _userService.SelectUsers();
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
    }
}
