using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass.UI.Accounts;
using Secure_The_Pass_Services_Core.Model;
using System.Drawing.Text;

namespace Password_Manager_.NET_6
{
    public partial class FrmAccounts : FrmBaseDialog, IAccounts
    {
        public Action<string> Search { get; set; }
        public Action<int> ShowDetailsAccount { get; set; }
        public Action<string> OpenBrowser { get; set; }
        public Action<int> IndexClicked { get; set; }
        public Func<bool> ShowPassword { get; set; }

        public FrmAccounts()
        {
            InitializeComponent();
        }

        private void FrmDashbord_Load(object? sender, EventArgs? e)
        {
            Dock = DockStyle.Fill;
            TopLevel = false;
            TopMost = true;
            Focus();
        }

        public void SetDataSource(List<Account> accounts)
        {
            AccGrid.DataSource = null;
            AccGrid.DataMember = null;
            AccGrid.DataSource = accounts;
        }

        public void SetGridProperty()
        {
            AccGrid.RowHeadersVisible = false;
            AccGrid.AutoGenerateColumns = true;
            AccGrid.AllowUserToResizeColumns = false;
            AccGrid.AllowUserToResizeRows = false;
            AccGrid.EnableHeadersVisualStyles = false;
            foreach (DataGridViewColumn cell in AccGrid.Columns)
            {
                cell.AutoSizeMode = cell.Index == AccGrid.Columns.Count - 1
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

            ShowDetailsAccount?.Invoke(e.RowIndex);
        }

        private void AccGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            IndexClicked?.Invoke(e.RowIndex);
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
                OpenBrowser?.Invoke(AccGrid[e.ColumnIndex, e.RowIndex].Value.ToString());
            }
        }

        public void SetError()
        {
            txtSearch.IsInvalid = true;
        }

        private void FrmAccounts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {
                txtSearch.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ShowDetailsAccount?.Invoke(AccGrid.SelectedRows[0].Index);
                e.Handled = true;
            }

            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {
                IndexClicked?.Invoke(AccGrid.SelectedRows[0].Index);
                e.Handled = true;
            }
        }

        private void AccGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null && !ShowPassword.Invoke())
            {
                e.Value = new string('•', e.Value.ToString().Length);
            }
        }
    }
}
