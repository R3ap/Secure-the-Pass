using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.Properties;
using Password_Manager_.NET_6.UI.BaseDialog;

namespace Password_Manager_.NET_6
{
    public partial class FrmMenü : FrmBaseDialogTitelBar
    {
        private User _user;
        private List<Account> _accounts;
        public FrmMenü(ref User user, ref List<Account> accounts)
        {
            InitializeComponent();
            _user = user;
            _accounts = accounts;
        }

        private void FrmMenü_Load(object sender, EventArgs e)
        {
            ShowAccounts();
            Size = Settings.Default.DefaultSize;
            WindowState = Settings.Default.IsMaximize ? FormWindowState.Maximized : FormWindowState.Normal;
            CenterToParent();
            lblUsername.Text = _user.Username;
            btnAccounts.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void BtnAccounts_Click(object sender, EventArgs e)
        {
            ShowAccounts();
        }

        private static void Error(Exception ex)
        {
            ErrorHandler error = new();
            error.ShowDialog(ex);
        }

        private void ShowAccounts()
        {
            try
            {
                pnlNav.Height = btnAccounts.Height;
                pnlNav.Top = btnAccounts.Top;
                pnlNav.Left = btnAccounts.Left;
                pnlNav.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                Titel = "Accounts";
                pnlFormload.Controls.Clear();
                FrmAccounts frmAccounts = new(_user, ref _accounts) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmAccounts.Show();
                //frmAccounts = (FrmAccounts)Application.OpenForms[nameof(FrmAccounts)];
                frmAccounts.FormBorderStyle = FormBorderStyle.None;
                pnlFormload.Controls.Add(frmAccounts);
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            try
            {
                pnlNav.Height = btnNewAcc.Height;
                pnlNav.Top = btnNewAcc.Top;
                pnlNav.Left = btnNewAcc.Left;
                pnlNav.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                Titel = "Add Account";
                this.pnlFormload.Controls.Clear();
                FrmAddAcc frmAddAcc = new(ref _user, ref _accounts) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmAddAcc.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormload.Controls.Add(frmAddAcc);
                frmAddAcc.Show();

            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                pnlNav.Height = btnSettings.Height;
                pnlNav.Top = btnSettings.Top;
                pnlNav.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

                Titel = "Settings";
                this.pnlFormload.Controls.Clear();
                FrmSettings frmSettings = new(ref _user, ref _accounts) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmSettings.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormload.Controls.Add(frmSettings);
                frmSettings.IsRemoved += UserRemoved;
                frmSettings.LogOut += OnLogOut;
                frmSettings.Show();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void OnLogOut()
        {
            Hide();
            Close();
        }

        public void UserRemoved()
        {
            Close();
        }

        private void FrmMenü_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.IsMaximize = WindowState == FormWindowState.Maximized;
            if (!Settings.Default.IsMaximize)
            {
                Settings.Default.DefaultSize = Size;
            }
            Settings.Default.Save();
        }
    }
}
