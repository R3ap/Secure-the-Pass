﻿using Password_Manager_.NET_6.Properties;
using Password_Manager_.NET_6.Model;
using System.Data;
using Password_Manager_.NET_6.UI.BaseDialog;
using System.Reflection;

namespace Password_Manager_.NET_6
{
    public partial class FrmAccounts : FrmBaseDialog
    {
        private User _user;
        private List<Account> _accounts;
        public event Action<List<Account>> SetnewListAcc;
        private int _rowIndex;
        private NotifyIcon _notifyIcon = new();
        private readonly DatabaseAccess _db = new();
        public FrmAccounts(ref User user, ref List<Account> accounts)
        {
            InitializeComponent();
            _user = user;
            _accounts = accounts;
        }

        private void FrmDashbord_Load(object? sender = null, EventArgs? e = null)
        {
            AccGrid.RowHeadersVisible = false;
            AccGrid.AutoGenerateColumns = true;
            if (!Settings.Default.ShowPass)
            {
                foreach (var acc in _accounts)
                {
                    acc.Password = new string('•', acc.Password.Length);
                }
            }
            else if (_accounts.Any(x => x.Password.Contains('•')))
            {
                SetAccounts();
            }
            AccGrid.DataSource = _accounts;
            AccGrid.AllowUserToResizeColumns = false;
            AccGrid.AllowUserToResizeRows = false;
            AccGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AccGrid.EnableHeadersVisualStyles = false;
        }

        private void SetAccounts()
        {
            List<Account> accounts = _db.SelectAccounts(_user);

            foreach (var acc in accounts)
            {
                acc.Email = SecurePasswordHasher.GetDecryptString(acc.Email);
                acc.Password = SecurePasswordHasher.GetDecryptString(acc.Password);
                acc.Website = SecurePasswordHasher.GetDecryptString(acc.Website);
                acc.Username = SecurePasswordHasher.GetDecryptString(acc.Username);
                acc.Useremail = SecurePasswordHasher.GetDecryptString(acc.Useremail);
            }
            _accounts = accounts;
        }

        private void AccGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OnDeleteAcc()
        {
            List<Account> accounts = _db.SelectAccounts(_user);

            foreach (var acc in accounts)
            {
                acc.Email = SecurePasswordHasher.GetDecryptString(acc.Email);
                acc.Password = SecurePasswordHasher.GetDecryptString(acc.Password);
                acc.Website = SecurePasswordHasher.GetDecryptString(acc.Website);
                acc.Username = SecurePasswordHasher.GetDecryptString(acc.Username);
                acc.Useremail = SecurePasswordHasher.GetDecryptString(acc.Useremail);
            }
            _accounts = accounts;
            AccGrid.DataSource = _accounts;
        }

        private void UpdateAcc(Account account)
        {
            _accounts[_rowIndex] = account;
            SetnewListAcc?.Invoke(_accounts);
            FrmDashbord_Load();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_accounts.Any() && txtSearch.Text != "Filter")
            {
                switch (Settings.Default.Filter)
                {
                    case "Username":
                        AccGrid.DataSource = _accounts.Where(x => x.Username.Contains(txtSearch.Text)).ToList();
                        break;
                    case "Email":
                        AccGrid.DataSource = _accounts.Where(x => x.Email.Contains(txtSearch.Text)).ToList();
                        break;
                    case "Password":
                        AccGrid.DataSource = _accounts.Where(x => x.Password.Contains(txtSearch.Text)).ToList();
                        break;
                    case "Website":
                        AccGrid.DataSource = _accounts.Where(x => x.Website.Contains(txtSearch.Text)).ToList();
                        break;
                    default:
                        _notifyIcon.Visible = true;
                        _notifyIcon.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
                        _notifyIcon.ShowBalloonTip(1000, "Filter Invaild", $"There is no Filter Like this: {Settings.Default.Filter}", ToolTipIcon.Error);
                        break;
                }
            }
        }

        private void TxtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Filter")
            {
                txtSearch.Clear();
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                txtSearch.Text = "Filter";
            }
        }

        private void AccGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                return;
            }

            if (e.RowIndex >= 0)
            {
                SetAccounts();
                _rowIndex = e.RowIndex;
                FrmEditAcc frmEditAcc = new(_accounts[e.RowIndex]);
                frmEditAcc.UpdateAcc += UpdateAcc;
                frmEditAcc.DeleteAcc += OnDeleteAcc;
                frmEditAcc.ShowDialog();
            }
        }

        private void AccGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                return;
            }

            try
            {
                _notifyIcon.Visible = true;
                _notifyIcon.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
                if (Settings.Default.IsCopy)
                {
                    if (Settings.Default.IsEmail)
                    {
                        Clipboard.SetText(_accounts[e.RowIndex].Email);
                    }
                    else if (Settings.Default.IsPassword)
                    {
                        Clipboard.SetText(_accounts[e.RowIndex].Password);
                    }
                    else if (Settings.Default.IsUsername)
                    {
                        Clipboard.SetText(_accounts[e.RowIndex].Username);
                    }

                    _notifyIcon.ShowBalloonTip(1000, "Copy to Clipbord", "Copy to Clipbord was successfull", ToolTipIcon.Info);
                }
            }
            catch
            {
                _notifyIcon.ShowBalloonTip(1000, "Copy to Clipbord", "Copy to Clipbord was failed", ToolTipIcon.Error);
            }
        }
    }
}