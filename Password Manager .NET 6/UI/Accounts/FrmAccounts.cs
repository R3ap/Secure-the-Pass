using Password_Manager_.NET_6.Properties;
using Password_Manager_.NET_6.Model;
using System.Data;
using Password_Manager_.NET_6.UI.BaseDialog;
using System.Reflection;
using Password_Manager_.NET_6.UI.EditAccount;

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
        public FrmAccounts(User user, ref List<Account> accounts)
        {
            InitializeComponent();
            _user = user;
            _accounts = accounts;
        }

        private void FrmDashbord_Load(object? sender, EventArgs? e)
        {
            SetGridProperty();
        }

        private void SetGridProperty()
        {
            if (!Settings.Default.ShowPass)
            {
                _accounts.ForEach(x => x.Password = new string('•', x.Password.Length));
            }
            else
            {
                SetAccounts();
            }
            AccGrid.RowHeadersVisible = false;
            AccGrid.AutoGenerateColumns = true;
            AccGrid.DataSource = _accounts;
            AccGrid.AllowUserToResizeColumns = false;
            AccGrid.AllowUserToResizeRows = false;
            AccGrid.EnableHeadersVisualStyles = false;
            foreach (DataGridViewColumn item in AccGrid.Columns)
            {
                item.AutoSizeMode = item.Index == AccGrid.Columns.Count - 1
                                                ? DataGridViewAutoSizeColumnMode.Fill
                                                : DataGridViewAutoSizeColumnMode.AllCells;

            }
        }

        private void SetAccounts()
        {
            List<Account> accounts = _db.SelectAccounts(_user);

            foreach (var acc in accounts)
            {
                acc.Email = acc.Email.GetDecryptString();
                acc.Password = acc.Password.GetDecryptString();
                acc.Website = acc.Website.GetDecryptString();
                acc.Username = acc.Username.GetDecryptString();
                acc.Useremail = acc.Useremail.GetDecryptString();
            }

            _accounts = accounts;
        }

        private void UpdateAcc()
        {
            SetAccounts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_accounts.Any() && txtSearch.Text != "Filter")
            {
                switch (Settings.Default.Filter)
                {
                    case "Username":
                        AccGrid.DataSource = _accounts.Where(x => x.Username.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
                        break;
                    case "Email":
                        AccGrid.DataSource = _accounts.Where(x => x.Email.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
                        break;
                    case "Password":
                        AccGrid.DataSource = _accounts.Where(x => x.Password.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
                        break;
                    case "Website":
                        AccGrid.DataSource = _accounts.Where(x => x.Website.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
                        break;
                    default:
                        _notifyIcon.Visible = true;
                        _notifyIcon.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
                        _notifyIcon.ShowBalloonTip(1000, "Filter Invaild", $"There is no Filter Like this: {Settings.Default.Filter}", ToolTipIcon.Error);
                        break;
                }
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
                EditAccPresenter frmEditAcc = new(_accounts[e.RowIndex]);
                frmEditAcc.UpdateAcc += UpdateAcc;
                frmEditAcc.ShowDialog();
                SetGridProperty();
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

                    AccGrid.Rows[e.RowIndex].Selected = true;
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
