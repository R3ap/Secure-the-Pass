using properties = Secure_The_Pass.Properties;
using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.Menü
{
    public partial class FrmMenü : FrmBaseDialogTitelBar, IMenü
    {
        public Action ShowAccountsDialog { get; set; }
        public Action ShowAddAccountsDialog { get; set; }
        public Action ShowSettingsDialog { get; set; }
        public FrmMenü()
        {
            InitializeComponent();

        }

        private void FrmMenü_Load(object sender, EventArgs e)
        {
            ShowAccounts();
            Size = properties.Settings.Default.DefaultSize;
            WindowState = properties.Settings.Default.IsMaximize ? FormWindowState.Maximized : FormWindowState.Normal;
            CenterToParent();
            btnAccounts.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnNewAcc.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnSettings.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        public string Username { get => lblUsername.Text; set => lblUsername.Text = value; }

        private void BtnAccounts_Click(object sender, EventArgs e)
        {
            ShowAccounts();
        }



        public void ShowAccounts()
        {
            pnlNav.Height = btnAccounts.Height;
            pnlNav.Top = btnAccounts.Top;
            pnlNav.Left = btnAccounts.Left;
            pnlNav.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ShowAccountsDialog?.Invoke();
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnNewAcc.Height;
            pnlNav.Top = btnNewAcc.Top;
            pnlNav.Left = btnNewAcc.Left;
            pnlNav.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ShowAddAccountsDialog?.Invoke();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            pnlNav.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ShowSettingsDialog?.Invoke();
        }
        
        public new void Hide()
        {
            base.Hide();
        }

        public new void Close()
        {
            base.Close();
        }

        private void FrmMenü_FormClosed(object sender, FormClosedEventArgs e)
        {
            properties.Settings.Default.IsMaximize = WindowState == FormWindowState.Maximized;
            if (!properties.Settings.Default.IsMaximize)
            {
                properties.Settings.Default.DefaultSize = Size;
            }
            properties.Settings.Default.Save();
        }
    }
}
