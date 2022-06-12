using Password_Manager_.NET_6;
using Secure_The_Pass.UI.Accounts;
using Secure_The_Pass.UI.AddAccount;
using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass.UI.ErrorHandler;
using Secure_The_Pass.UI.Settings;
using Secure_The_Pass_Services_Core.Extensions;
using Secure_The_Pass_Services_Core.Services.Account;
using Secure_The_Pass_Services_Core.Services.User;

namespace Secure_The_Pass.UI.Menu
{
    public class MenuPresenter : BaseTitelBarPresenter<IMenu>
    {
        private readonly IAccountService _accountService = new AccountService();
        private readonly IUserService _userService = new UserService();
        public MenuPresenter() : base(new FrmMenu())
        {
            View.Username = _userService.GetCurrentUser().Username;
            View.ShowAccountsDialog = ShowAccountsDialog;
            View.ShowAddAccountsDialog = ShowAddAccountsDialog;
            View.ShowSettingsDialog = ShowSettingsDialog;
        }

        private void ShowAccountsDialog()
        {
            try
            {
                View.Titel = "Accounts";
                AccountsPresenter accountsPresenter = new();
                accountsPresenter.Show();
                FrmAccounts frmAccounts = (FrmAccounts)Application.OpenForms[nameof(FrmAccounts)];
                frmAccounts.FormBorderStyle = FormBorderStyle.None;
                View.AddControl(frmAccounts);
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void ShowAddAccountsDialog()
        {
            try
            {
                View.Titel = "Add Account";
                AddAccPresenter AddAcc = new();
                AddAcc.Show();
                FrmAddAcc frmAddAcc = (FrmAddAcc)Application.OpenForms[nameof(FrmAddAcc)];
                frmAddAcc.FormBorderStyle = FormBorderStyle.None;
                View.AddControl(frmAddAcc);
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void ShowSettingsDialog()
        {
            try
            {
                View.Titel = "Settings";
                SettingsPresenter presenter = new();
                presenter.Show();
                FrmSettings frmSettings = (FrmSettings)Application.OpenForms[nameof(FrmSettings)];
                frmSettings.FormBorderStyle = FormBorderStyle.None;
                View.AddControl(frmSettings);
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        public void OnLogOut()
        {
            View.Hide();
            View.Close();
        }

        public void UserRemoved()
        {
            View.Close();
        }

        private static void Error(Exception ex)
        {
            ErrorHandlerPresenter error = new();
            error.SetErrorMessage(ex);
            error.ShowDialog();
        }
    }
}
