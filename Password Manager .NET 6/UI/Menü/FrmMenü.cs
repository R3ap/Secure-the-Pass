using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.Properties;
using Password_Manager_.NET_6.UI.AddAccount;
using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_.NET_6.UI.ErrorHandler;
using Password_Manager_.NET_6.UI.Menü;

namespace Password_Manager_.NET_6
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
            Size = Settings.Default.DefaultSize;
            WindowState = Settings.Default.IsMaximize ? FormWindowState.Maximized : FormWindowState.Normal;
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
            Settings.Default.IsMaximize = WindowState == FormWindowState.Maximized;
            if (!Settings.Default.IsMaximize)
            {
                Settings.Default.DefaultSize = Size;
            }
            Settings.Default.Save();
        }
    }
}
