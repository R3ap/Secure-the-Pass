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
        public event Action UpdateAcc;
        public event Action<List<Account>> SetnewListAcc;
        private NotifyIcon _notifyIcon = new();
        private readonly IAccountService _accountService = new AccountService();
        public AccountsPresenter(User user, ref List<Account> accounts) : base(new FrmAccounts())
        {
            _user = user;
            _accounts = accounts;
            View.Search = Search;
            View.GetAccounts = SetAccounts;
            View.ShowDetailsAccount = EditAccountPresenter;
            View.OpenBrowser = OpenBrowser;
            View.IndexClicked = SetCopyToClipboard;
        }

        private void EditAccountPresenter(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                EditAccPresenter frmEditAcc = new(_accounts[rowIndex]);
                frmEditAcc.UpdateAcc += UpdateAcc;
                frmEditAcc.ShowDialog();
                View.SetGridProperty();
            }
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

        private void AnonymizePassword()
        {
            if (!Properties.Settings.Default.ShowPass)
            {
                _accounts.ForEach(x => x.Password = new string('•', x.Password.Length));
            }
            else
            {
                SetAccounts();
            }
        }

        private void Search(string search)
        {
            if (_accounts.Any())
            {
                List<Account> accounts = new();
                switch (Properties.Settings.Default.Filter)
                {
                    case "Username":
                        accounts = _accounts.Where(x => x.Username.ToLower().Contains(search.ToLower())).ToList();
                        break;
                    case "Email":
                        accounts = _accounts.Where(x => x.Email.ToLower().Contains(search.ToLower())).ToList();
                        break;
                    case "Password":
                        accounts = _accounts.Where(x => x.Password.ToLower().Contains(search.ToLower())).ToList();
                        break;
                    case "Website":
                        accounts = _accounts.Where(x => x.Website.ToLower().Contains(search.ToLower())).ToList();
                        break;
                    default:
                        _notifyIcon.Visible = true;
                        _notifyIcon.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
                        _notifyIcon.ShowBalloonTip(1000, "Filter Invaild", $"There is no Filter Like this: {Properties.Settings.Default.Filter}", ToolTipIcon.Error);
                        break;
                }

                if (!accounts.Any())
                {
                    View.SetError();
                }
                View.SetDataSource(accounts);
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
                    if (Properties.Settings.Default.IsEmail)
                    {
                        Clipboard.SetText(_accounts[rowIndex].Email);
                    }
                    else if (Properties.Settings.Default.IsPassword)
                    {
                        Clipboard.SetText(_accounts[rowIndex].Password);
                    }
                    else if (Properties.Settings.Default.IsUsername)
                    {
                        Clipboard.SetText(_accounts[rowIndex].Username);
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

        private void SetAccounts()
        {
            List<Account> accounts = _accountService.SelectAccounts(_user).ToList();

            foreach (var acc in accounts)
            {
                acc.Email = acc.Email.GetDecryptString();
                acc.Password = acc.Password.GetDecryptString();
                acc.Website = acc.Website.GetDecryptString();
                acc.Username = acc.Username.GetDecryptString();
                acc.Useremail = acc.Useremail.GetDecryptString();
            }

            _accounts = accounts.ToList();
            AnonymizePassword();
            View.SetDataSource(_accounts);
        }
    }
}
