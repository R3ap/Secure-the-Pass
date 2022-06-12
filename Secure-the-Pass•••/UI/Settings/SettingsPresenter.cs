using properties = Secure_The_Pass.Properties;
using Secure_The_Pass_Services_Core.Services.User;
using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass.UI.LogInAndRegister.Overview;
using Secure_The_Pass_Services_Core.Services.Account;
using Secure_The_Pass_Services_Core.Model;
using Secure_The_Pass_Services_Core.Extensions;
using Secure_The_Pass.UI.Menu;

namespace Secure_The_Pass.UI.Settings
{
    public class SettingsPresenter : BaseDialogPresenter<ISettings>
    {
        private readonly IUserService _userService = new UserService();
        private readonly IAccountService _accountService = new AccountService();
        private User _user;
        private List<Account> _accounts;

        public SettingsPresenter() : base(new FrmSettings())
        {
            _user = _userService.GetCurrentUser();
            _accounts = _accountService.SelectAccounts(_user).ToList();
            View.OnAcceptClick = Save;
            View.AddButtonAction(new ButtonAction() { Action = CleanAccountClick, Name = "BtnCleanAccount", Text = "Clean All Accounts" });
            View.AddButtonAction(new ButtonAction() { Action = DeleteUserClick, Name = "BtnDeleteUser", Text = "Delete User" });
            View.AddButtonAction(new ButtonAction() { Action = SignOutClick, Name = "BtnSignOut", Text = "Sign out" });
            View.ShowPass = properties.Settings.Default.ShowPass;
            View.IsCopy = properties.Settings.Default.IsCopy;
            View.CopyToClipboard = properties.Settings.Default.CopyToClipboard.GetDescription();
            View.PasswordLenght = properties.Settings.Default.PasswordLenght.ToString();
            View.AllowedCharacters = properties.Settings.Default.AllowedCharacters;
            View.RememberMe = !string.IsNullOrEmpty(properties.Settings.Default.Email);
        }

        private bool SignOutClick()
        {
            ((FrmMenu)Application.OpenForms[nameof(FrmMenu)]).Hide();
            ((FrmMenu)Application.OpenForms[nameof(FrmMenu)]).Close();
            properties.Settings.Default.Email = null;
            properties.Settings.Default.Save();
            OverviewPresenter LogIn = new();
            LogIn.ShowDialog();
            return false;
        }

        private bool DeleteUserClick()
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete this user?", "Are your sure about that?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes && _userService.RemoveUser(_user))
            {
                dialogResult = MessageBox.Show("Delete was successfull", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            return false;
        }

        private bool CleanAccountClick()
        {
            _accountService.RemoveAllAccounts(_accounts);
            return false;
        }

        private bool Save()
        {
            if (int.TryParse(View.PasswordLenght, out int pwlenght))
            {
                View.CleanProvider();
                properties.Settings.Default.IsCopy = View.IsCopy;
                properties.Settings.Default.CopyToClipboard = View.CopyToClipboard.MappingOnEnumSettings().Value;
                properties.Settings.Default.ShowPass = View.ShowPass;
                properties.Settings.Default.PasswordLenght = pwlenght;
                properties.Settings.Default.AllowedCharacters = View.AllowedCharacters;
                properties.Settings.Default.Email = View.RememberMe ? _user.Email.GetEncryptString() : "";
                properties.Settings.Default.Save();
            }
            else
            {
                View.SetError();
            }
            return false;
        }
    }
}
