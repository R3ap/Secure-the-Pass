using Password_Manager_.NET_6.Properties;
using System.Data;
using Password_Manager_.NET_6.UI.BaseDialog;
using System.Reflection;
using Password_Manager_.NET_6.UI.EditAccount;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Password_Manager_.NET_6.UI.Accounts;
using Service_Core.Model;

namespace Password_Manager_.NET_6
{
    public partial class FrmAccounts : FrmBaseDialog, IAccounts
    {
        private int _rowIndex;
        
        private NotifyIcon _notifyIcon = new();
        public FrmAccounts()
        {
            InitializeComponent();
           
        }

        private void FrmDashbord_Load(object? sender, EventArgs? e)
        {
            SetGridProperty();
        }

        public void SetGridProperty(List<Account> accounts)
        {
            if (!Settings.Default.ShowPass)
            {
                accounts.ForEach(x => x.Password = new string('•', x.Password.Length));
            }
            else
            {
                SetAccounts();
            }
            AccGrid.RowHeadersVisible = false;
            AccGrid.AutoGenerateColumns = true;
            AccGrid.DataSource = accounts;
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
            if (e.Button != MouseButtons.Left)
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
            if (e.Button != MouseButtons.Right)
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

        private void AccGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in AccGrid.Rows)
            {
                if (Uri.IsWellFormedUriString(r.Cells[nameof(Account.Website)].Value.ToString(), UriKind.Absolute))
                {
                    r.Cells[nameof(Account.Website)] = new DataGridViewLinkCell();
                    DataGridViewLinkCell c = r.Cells[nameof(Account.Website)] as DataGridViewLinkCell;
                    c.LinkColor = Color.Aqua;
                    c.VisitedLinkColor = c.ActiveLinkColor = Color.CadetBlue;
                }
            }
        }

        private void AccGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AccGrid[e.ColumnIndex, e.RowIndex] is DataGridViewLinkCell)
            {
                OpenBrowser(AccGrid[e.ColumnIndex, e.RowIndex].Value.ToString());
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
    }
}
