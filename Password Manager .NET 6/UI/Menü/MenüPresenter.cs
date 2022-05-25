using Password_Manager_.NET_6;
using Secure_The_Pass.UI.Accounts;
using Secure_The_Pass.UI.AddAccount;
using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass.UI.ErrorHandler;
using Secure_The_Pass.UI.Settings;
using Secure_The_Pass_Services_Core.Extensions;
using Secure_The_Pass_Services_Core.Model;
using Secure_The_Pass_Services_Core.Services.AccountService;

namespace Secure_The_Pass.UI.Menü
{
    public class MenüPresenter : BaseTitelBarPresenter<IMenü>
    {
        private User _user;
        private List<Account> _accounts;
        private readonly IAccountService _accountService = new AccountService();
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
                SetAccounts();
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

        private void SetAccounts()
        {
            _accounts = _accountService.SelectAccounts(_user).ToList();
            
            _accounts.ForEach(x =>
            {
                x.Email = x.Email.GetDecryptString();
                x.Password = x.Password.GetDecryptString();
                x.Username = x.Username.GetDecryptString();
                x.Useremail = x.Useremail.GetDecryptString();
                x.Website = x.Website.GetDecryptString();
            });

            if (!Properties.Settings.Default.ShowPass)
            {
                _accounts.ForEach(x => x.Password = new string('•', x.Password.Length));
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
