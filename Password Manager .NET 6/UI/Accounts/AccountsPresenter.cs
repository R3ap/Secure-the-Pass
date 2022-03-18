﻿using Password_Manager_.NET_6.UI.BaseDialog;
using Services_Core.Services.AccountService;
using Services_Core.Extensions;
using Services_Core.Model;
using System.Reflection;
using Password_Manager_.NET_6.UI.EditAccount;

namespace Password_Manager_.NET_6.UI.Accounts
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
        }

        private void EditAccountPresenter(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                SetAccounts();
                EditAccPresenter frmEditAcc = new(_accounts[rowIndex]);
                frmEditAcc.UpdateAcc += UpdateAcc;
                frmEditAcc.ShowDialog();
                View.SetGridProperty();
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
            if (_accounts.Any() && search != "Filter")
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
                if (accounts.Any())
                {
                    View.SetDataSource(accounts);
                }
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
