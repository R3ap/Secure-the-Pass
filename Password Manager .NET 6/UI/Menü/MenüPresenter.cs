using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.UI.AddAccount;
using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_.NET_6.UI.ErrorHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                FrmAccounts frmAccounts = new(_user, ref _accounts) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmAccounts.Show();
                //frmAccounts = (FrmAccounts)Application.OpenForms[nameof(FrmAccounts)];
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
                FrmSettings frmSettings = new(ref _user, ref _accounts) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmSettings.FormBorderStyle = FormBorderStyle.None;
                View.AddControl(frmSettings);
                frmSettings.IsRemoved += UserRemoved;
                frmSettings.LogOut += OnLogOut;
                frmSettings.Show();
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
            error.ShowDialog();
            error.SetErrorMessage(ex);
        }
    }
}
