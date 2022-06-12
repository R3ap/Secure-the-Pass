using Secure_The_Pass_Services_Core.Services.User;
using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass_Services_Core.Model;
using Secure_The_Pass.UI.LogInAndRegister.Overview;
using properties = Secure_The_Pass.Properties;
using Secure_The_Pass.UI.Menu;
using Secure_The_Pass_Services_Core.Services.Login;

namespace Secure_The_Pass.UI.LogInAndRegister.Register {
    public class RegisterPresenter : BaseDialogPresenter<IRegister> {
        private User _user;
        private List<Account> _accounts;
        private readonly IUserService _userService = new UserService();
        private readonly ILoginService _loginService = new LoginService();
        public RegisterPresenter() : base(new FrmRegister()) {
            View.Register = Register;
        }

        public bool Register() {
            View.ClearError();

            User user = new() {
                Email = View.Email,
                Password = View.Password,
                Username = View.Username,
            };

            if (_loginService.SignUp(user)) {
                properties.Settings.Default.LastOpenApplication = DateTime.Now;
                properties.Settings.Default.Save();
                Application.OpenForms[nameof(FrmOverview)].Hide();
                Application.OpenForms[nameof(FrmOverview)].Close();
                MenuPresenter frmMenu = new();
                frmMenu.ShowDialog();
                return true;
            }
            string errortext = "Enter incorrect data";

            if (string.IsNullOrEmpty(View.Email)) {
                View.SetErrorEmail(errortext);
            }

            if (string.IsNullOrEmpty(View.Password)) {
                View.SetErrorPassword(errortext);
            }

            if (string.IsNullOrEmpty(View.Username)) {
                View.SetErrorUsername(errortext);
            }

            if (string.IsNullOrEmpty(View.PasswordConfirm)) {
                View.SetErrorPasswordConfirm(errortext);
            }
            return false;
        }
    }
}
