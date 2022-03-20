using Password_Manager_.NET_6.UI.Accounts;
using Password_Manager_.NET_6.UI.AddAccount;
using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_.NET_6.UI.ErrorHandler;
using Password_Manager_.NET_6.UI.Settings;
using Password_Manager_Services_Core.Model;

namespace Password_Manager_.NET_6.UI.Menü
{
    public class MenüPresenter : BaseTitelBarPresenter<IMenü>
    {
        private User _user;
        private List<Account> _accounts;
        public MenüPresenter(ref User user, ref List<Account> accounts) : base(new FrmMenü())
        {
            _user = user;
            _accounts = accounts;
            View.Username = _user.Username;
            View.ShowAccountsDialog = ShowAccountsDialog;
            View.ShowAddAccountsDialog = ShowAddAccountsDialog;
            View.ShowSettingsDialog = ShowSettingsDialog;
        }

        private void ShowAccountsDialog()
        {
            try
            {
                View.Titel = "Accounts";
                AccountsPresenter accountsPresenter = new(_user, ref _accounts);
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
                AddAccPresenter AddAcc = new(ref _user, ref _accounts);
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
                SettingsPresenter presenter = new(ref _user, ref _accounts);
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
