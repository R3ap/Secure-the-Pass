using Secure_The_Pass_Services_Core.Services.User;
using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass_Services_Core.Extensions;
using Secure_The_Pass_Services_Core.Model;
using settings = Secure_The_Pass.Properties;
using System.DirectoryServices.AccountManagement;
using Secure_The_Pass.UI.LogInAndRegister.Overview;
using Secure_The_Pass.UI.Menu;
using Secure_The_Pass_Services_Core.Services.Login;

namespace Secure_The_Pass.UI.LogInAndRegister.Login {
    public class LogInPresenter : BaseDialogPresenter<ILogIn> {
        private readonly IUserService _userService = new UserService();
        private readonly ILoginService _loginService = new LoginService();
        public LogInPresenter() : base(new FrmLogIn()) {
            View.OnAcceptClick = LogIn;
            View.LoginByRememberMe = LoginByRememberMe;
        }

        private void LoginByRememberMe() {
            DateTime? lastLoginOn = GetLastLoginOn();
            if (!string.IsNullOrEmpty(settings.Settings.Default.Email) && lastLoginOn < settings.Settings.Default.LastOpenApplication) {
                IList<User> users = _userService.SelectUsers();
                Application.OpenForms[nameof(FrmOverview)].Hide();
                Application.OpenForms[nameof(FrmOverview)].Close();
                if (users.Any(x => x.Email == settings.Settings.Default.Email)) {
                    MenuPresenter frmMenu = new();
                    frmMenu.ShowDialog();
                    settings.Settings.Default.LastOpenApplication = DateTime.Now;
                    settings.Settings.Default.Save();
                }
            } else if (lastLoginOn > settings.Settings.Default.LastOpenApplication) {
                View.Email = settings.Settings.Default.Email.GetDecryptString();
                View.RememberMe = true;
                View.SetFocus();
            }
        }

        public static DateTime? GetLastLoginOn() {
            return UserPrincipal.Current.LastLogon;
        }

        public bool LogIn() {
            if (_loginService.Login(View.Email, View.Password)) {
                settings.Settings.Default.Email = View.RememberMe ? View.Email.GetEncryptString() : null;
                settings.Settings.Default.LastOpenApplication = DateTime.Now;
                settings.Settings.Default.Save();
                Application.OpenForms[nameof(FrmOverview)].Hide();
                Application.OpenForms[nameof(FrmOverview)].Close();
                MenuPresenter menu = new();
                menu.ShowDialog();
                return true;
            } else {
                View.InvalidData();
                return false;
            }
        }
    }
}
