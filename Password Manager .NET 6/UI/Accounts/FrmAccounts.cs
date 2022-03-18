using Password_Manager_.NET_6.UI.BaseDialog;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Password_Manager_.NET_6.UI.Accounts;
using Services_Core.Model;

namespace Password_Manager_.NET_6
{
    public partial class FrmAccounts : FrmBaseDialog, IAccounts
    {
        public Action GetAccounts { get; set; }
        public Action<string> Search { get; set; }
        
        public FrmAccounts()
        {
            InitializeComponent();
           
        }

        private void FrmDashbord_Load(object? sender, EventArgs? e)
        {
            SetGridProperty();
            GetAccounts?.Invoke();
            Dock = DockStyle.Fill;
            TopLevel = false;
            TopMost = true;
        }

        public void SetDataSource(List<Account> accounts)
        {
            AccGrid.DataSource = accounts;
        }

        public void SetGridProperty()
        {
            AccGrid.RowHeadersVisible = false;
            AccGrid.AutoGenerateColumns = true;
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search?.Invoke(txtSearch.Text);
        }

        private void AccGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
        }

        private void AccGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }


        }
        
        public void SetSelectedRow(int rowIndex)
        {
            AccGrid.Rows[rowIndex].Selected = true;
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
