using Secure_The_Pass_Services_Core.Services.User;
using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass_Services_Core.Extensions;
using Secure_The_Pass_Services_Core.Model;
using Secure_The_Pass.UI.LogInAndRegister.Overview;
using properties = Secure_The_Pass.Properties;
using Secure_The_Pass.UI.Menu;

namespace Secure_The_Pass.UI.LogInAndRegister.Register {
    public class RegisterPresenter : BaseDialogPresenter<IRegister> {
        private User _user;
        private List<Account> _accounts;
        private readonly IUserService _userService = new UserService();
        public RegisterPresenter() : base(new FrmRegister()) {
            View.Register = Register;
        }

        public bool Register() {
            View.ClearError();
            if (!_userService.CheckUser(View.Email)) {
                View.SetErrorEmail("The Email Exist");
                return false;
            } else if (!string.IsNullOrEmpty(View.Email)
                       && !string.IsNullOrEmpty(View.Password)
                       && !string.IsNullOrEmpty(View.Username)
                       && !string.IsNullOrEmpty(View.PasswordConfirm)) {
                if (View.Password != View.PasswordConfirm) {
                    View.SetErrorPasswordConfirm("The Password is not Equal!");
                    return false;
                } else {
                    User user = new() {
                        Email = View.Email,
                        Username = View.Username,
                        Password = View.Password
                    };

                    if (_userService.InsertUser(user.GetEncryptedUser())) {
                        properties.Settings.Default.LastOpenApplication = DateTime.Now;
                        properties.Settings.Default.Save();
                        Application.OpenForms[nameof(FrmOverview)].Hide();
                        Application.OpenForms[nameof(FrmOverview)].Close();
                        MenuPresenter frmMenu = new();
                        frmMenu.ShowDialog();
                        return true;
                    }
                }
            } else {

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
            }
            return false;
        }
    }
}
