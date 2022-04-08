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

        private void AccGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.Value == null) return;

            StringFormat sf = StringFormat.GenericTypographic;
            sf.FormatFlags = sf.FormatFlags | StringFormatFlags.MeasureTrailingSpaces | StringFormatFlags.DisplayFormatControl;
            e.PaintBackground(e.CellBounds, true);

            SolidBrush br = new(Color.FromArgb(46, 51, 73));
            if (((int)e.State & (int)DataGridViewElementStates.Selected) == 0)
                br.Color = Color.FromArgb(0, 126, 249);

            AccGrid.Font = new Font(new FontFamily("Segoe UI"), 10, FontStyle.Bold);

            string text = e.Value.ToString();
            SizeF textSize = e.Graphics.MeasureString(text, AccGrid.Font, e.CellBounds.Width, sf);

            int keyPos = text.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase);
            if (keyPos >= 0)
            {
                SizeF textMetricSize = new(0, 0);
                if (keyPos >= 1)
                {
                    string textMetric = text[..keyPos];
                    textMetricSize = e.Graphics.MeasureString(textMetric, AccGrid.Font, e.CellBounds.Width, sf);
                }

                SizeF keySize = e.Graphics.MeasureString(text.Substring(keyPos, txtSearch.Text.Length), AccGrid.Font, e.CellBounds.Width, sf);
                float left = e.CellBounds.Left + (keyPos <= 0 ? 0 : textMetricSize.Width) + 2;
                RectangleF keyRect = new(left, e.CellBounds.Top + 1, keySize.Width, e.CellBounds.Height - 2);

                SolidBrush fillBrush = new(Color.Yellow);
                e.Graphics.FillRectangle(fillBrush, keyRect);
                fillBrush.Dispose();
            }
            e.Graphics.DrawString(text, AccGrid.Font, br, new PointF(e.CellBounds.Left + 2, e.CellBounds.Top + (e.CellBounds.Height - textSize.Height) / 2), sf);
            e.Handled = true;

            br.Dispose();
        }
    }
}
