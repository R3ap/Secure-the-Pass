using System.Reflection;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Password_Manager_.NET_6;
using Secure_The_Pass.UI.EditAccount;
using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass_Services_Core.Services.AccountService;
using Secure_The_Pass_Services_Core.Model;
using Secure_The_Pass_Services_Core.Extensions;

namespace Secure_The_Pass.UI.Accounts
{
    public class AccountsPresenter : BaseDialogPresenter<IAccounts>
    {
        private User _user;
        private List<Account> _accounts;
        public event Action<List<Account>> SetnewListAcc;
        private NotifyIcon _notifyIcon = new();
        private readonly IAccountService _accountService = new AccountService();
        private int _rowIndex;
        public AccountsPresenter(User user, ref List<Account> accounts) : base(new FrmAccounts())
        {
            _user = user;
            _accounts = accounts;
            View.Search = Search;
            View.ShowDetailsAccount = EditAccountPresenter;
            View.OpenBrowser = OpenBrowser;
            View.IndexClicked = SetCopyToClipboard;
            View.SetDataSource(_accounts);
            View.SetGridProperty();
        }

        private void EditAccountPresenter(int rowIndex)
        {
            _rowIndex = rowIndex;
            if (_rowIndex >= 0)
            {
                EditAccPresenter frmEditAcc = new(GetAccounts()[_rowIndex]);
                frmEditAcc.UpdateAcc += UpdateAcc;
                frmEditAcc.RemoveAcc += RemoveAcc;
                frmEditAcc.ShowDialog();
            }
        }

        private void RemoveAcc()
        {
            _accounts.RemoveAt(_rowIndex);
            View.SetDataSource(_accounts);
            View.SetGridProperty();
        }

        private void UpdateAcc(Account account)
        {
            if (!Properties.Settings.Default.ShowPass)
            {
                account.Password = new string('•', account.Password.Length);
            }
            _accounts[_rowIndex] = account;
            View.SetDataSource(_accounts);
            View.SetGridProperty();
        }

        public static void OpenBrowser(string url)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}"));
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open", url);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", url);
            }
        }

        private void Search(string search)
        {
            if (_accounts.Any())
            {
                List<Account> accounts = _accounts.Where(x => x.Username.ToLower().Contains(search.ToLower())
                                                             || x.Email.ToLower().Contains(search.ToLower())
                                                             || x.Password.ToLower().Contains(search.ToLower())
                                                             || x.Website.ToLower().Contains(search.ToLower())).ToList();
                if (!accounts.Any())
                {
                    View.SetError();
                }
                View.SetDataSource(accounts);
                View.SetGridProperty();
            }
        }

        private void SetCopyToClipboard(int rowIndex)
        {
            try
            {
                _notifyIcon.Visible = true;
                _notifyIcon.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
                if (Properties.Settings.Default.IsCopy)
                {
                    switch (Properties.Settings.Default.CopyToClipboard)
                    {
                        case Settings.enumSettings.CopyToClipboard_Email:
                            Clipboard.SetText(_accounts[rowIndex].Email);
                            break;
                        case Settings.enumSettings.CopyToClipboard_Password:
                            Clipboard.SetText(_accounts[rowIndex].Password.All(x => x == '•')
                                                ? GetAccounts()[rowIndex].Password
                                                : _accounts[rowIndex].Password);
                            break;
                        case Settings.enumSettings.CopyToClipboard_Username:
                            Clipboard.SetText(_accounts[rowIndex].Username);
                            break;
                    }

                    View.SetSelectedRow(rowIndex);
                    _notifyIcon.ShowBalloonTip(1000, "Copy to Clipbord", "Copy to Clipbord was successfull", ToolTipIcon.Info);
                }
            }
            catch
            {
                _notifyIcon.ShowBalloonTip(1000, "Copy to Clipbord", "Copy to Clipbord was failed", ToolTipIcon.Error);
            }
        }

        private List<Account> GetAccounts()
        {
            List<Account> accounts = _accountService.SelectAccounts(_user).ToList();

            accounts.ForEach(x =>
            {
                x.Email = x.Email.GetDecryptString();
                x.Password = x.Password.GetDecryptString();
                x.Useremail = x.Useremail.GetDecryptString();
                x.Username = x.Username.GetDecryptString();
                x.Website = x.Website.GetDecryptString();
            });

            return accounts;
        }
    }
}