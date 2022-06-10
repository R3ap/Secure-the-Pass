using properties = Secure_The_Pass.Properties;
using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.Menu {
    public partial class FrmMenu : FrmBaseDialogTitelBar, IMenu {
        public Action ShowAccountsDialog { get; set; }
        public Action ShowAddAccountsDialog { get; set; }
        public Action ShowSettingsDialog { get; set; }
        public string Username { get => lblUsername.Text; set => lblUsername.Text = value; }
        public FrmMenu() {
            InitializeComponent();

        }

        private void FrmMenü_Load(object sender, EventArgs e) {
            ShowAccounts();
            Size = properties.Settings.Default.DefaultSize;
            WindowState = properties.Settings.Default.IsMaximize ? FormWindowState.Maximized : FormWindowState.Normal;
            CenterToParent();
            btnAccounts.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnNewAcc.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnSettings.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            pnlNav.Height = btnAccounts.Height;
            pnlNav.Top = btnAccounts.Top;
            pnlNav.Left = btnAccounts.Left;
        }

        private void BtnAccounts_Click(object sender, EventArgs e) {
            ShowAccounts();
        }

        public void ShowAccounts() {
            pnlNav.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ShowAccountsDialog?.Invoke();
        }

        private void btnNewAcc_Click(object sender, EventArgs e) {
            pnlNav.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ShowAddAccountsDialog?.Invoke();
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            pnlNav.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ShowSettingsDialog?.Invoke();
        }

        public new void Hide() {
            base.Hide();
        }

        public new void Close() {
            base.Close();
        }

        private void FrmMenü_FormClosed(object sender, FormClosedEventArgs e) {
            properties.Settings.Default.IsMaximize = WindowState == FormWindowState.Maximized;
            if (!properties.Settings.Default.IsMaximize) {
                properties.Settings.Default.DefaultSize = Size;
            }
            properties.Settings.Default.Save();
        }

        private void BtnEnter(object sender, EventArgs e) {
            if (sender is Button button) {
                pnlNav.Height = button.Height;
                pnlNav.Top = button.Top;
                pnlNav.Left = button.Left;
            }
        }
    }
}
