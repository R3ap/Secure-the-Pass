using properties = Password_Manager_.NET_6.Properties;
using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_.NET_6.UI.LogInAndRegister.Overview;
using Service_Core.Model;
using Service_Core.Services.UserServices;
using Service_Core.Services.AccountService;

namespace Password_Manager_.NET_6.UI.Settings
{
    public class SettingsPresenter : BaseDialogPresenter<ISettings>
    {
        private readonly IUserService _userService = new UserService();
        private readonly IAccountService _accountService = new AccountService();
        private User _user;
        private List<Account> _accounts;
        
        public SettingsPresenter(ref User user, ref List<Account> accounts) : base(new FrmSettings())
        {
            _user = user;
            _accounts = accounts;
            View.OnAcceptClick = Save;
            View.AddButtonAction(new ButtonAction() { Action = CleanAccountClick, Name = "BtnCleanAccount", Text = "Clean Account"});
            View.AddButtonAction(new ButtonAction() { Action = DeleteUserClick, Name = "BtnDeleteUser", Text = "Delete Account"});
            View.AddButtonAction(new ButtonAction() { Action = SignOutClick, Name = "BtnSignOut", Text = "Sign out" });
            View.SetFilter(properties.Settings.Default.Filter);
            View.ShowPass = properties.Settings.Default.ShowPass;
            View.IsCopy = properties.Settings.Default.IsCopy;
            View.IsEmail = properties.Settings.Default.IsEmail;
            View.IsPassword = properties.Settings.Default.IsPassword;
            View.IsUsername = properties.Settings.Default.IsUsername;
            View.PasswordLenght = properties.Settings.Default.PasswordLenght.ToString();
            View.AllowedCharacters = properties.Settings.Default.AllowedCharacters;
        }

        private bool SignOutClick()
        {
            ((FrmMenü)Application.OpenForms[nameof(FrmMenü)]).Hide();
            ((FrmMenü)Application.OpenForms[nameof(FrmMenü)]).Close();
            properties.Settings.Default.Email = null;
            properties.Settings.Default.Save();
            OverviewPresenter LogIn = new();
            LogIn.ShowDialog();
            return false;
        }

        private bool DeleteUserClick()
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete this user?", "Are your sure about that?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes && _userService.RemoveUser(_user, _accounts))
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
            _accountService.CleanAccount(_accounts);
            return false;
        }

        private bool Save()
        {
            if (int.TryParse(View.PasswordLenght, out int pwlenght))
            {
                View.CleanProvider();
                properties.Settings.Default.IsCopy = View.IsCopy;
                properties.Settings.Default.IsEmail = View.IsEmail;
                properties.Settings.Default.IsPassword = View.IsPassword;
                properties.Settings.Default.IsUsername = View.IsUsername;
                properties.Settings.Default.ShowPass = View.ShowPass;
                properties.Settings.Default.PasswordLenght = pwlenght;
                properties.Settings.Default.Filter = View.Filter;
                properties.Settings.Default.AllowedCharacters = View.AllowedCharacters;
                properties.Settings.Default.Save();
            }
            else
            {
                View.SetErrorProvider();
            }
            return false;
        }

    }
}
