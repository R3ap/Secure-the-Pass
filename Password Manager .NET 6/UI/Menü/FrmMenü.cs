using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.Properties;

namespace Password_Manager_.NET_6
{
    public partial class FrmMenü : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private User _user;
        private List<Account> _accounts;
        private Size _defaultSize;
        public FrmMenü(User user, List<Account> accounts)
        {
            InitializeComponent();
            _user = user;
            _accounts = accounts;
        }
        private void FrmMenü_Load(object sender, EventArgs e)
        {
            ShowDashbord();
            txtUser.Text = _user.Username;
            _defaultSize = Size;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashbord();
        }

        private void Error(Exception ex)
        {
            ErrorHandler error = new ErrorHandler();
            error.ShowDialog(ex);
        }

        private void ShowDashbord()
        {
            try
            {
                pnlNav.Height = btnDashboard.Height;
                pnlNav.Top = btnDashboard.Top;
                pnlNav.Left = btnDashboard.Left;
                pnlNav.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                lblTitle.Text = "Dashboard";
                this.pnlFormload.Controls.Clear();
                FrmDashboard frmDashboard = new(_user, _accounts) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, Name = "frmDashboard" };
                frmDashboard.Show();
                frmDashboard = (FrmDashboard)Application.OpenForms["frmDashboard"];
                frmDashboard.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormload.Controls.Add(frmDashboard);
                frmDashboard.SetnewListAcc += SetnewListAcc;
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void SetnewListAcc(List<Account> accounts)
        {
            _accounts = accounts;
        }

        public Screen GetScreen()
        {
            return Screen.FromControl(this);
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            try
            {
                pnlNav.Height = btnNewAcc.Height;
                pnlNav.Top = btnNewAcc.Top;
                pnlNav.Left = btnNewAcc.Left;
                pnlNav.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                lblTitle.Text = "Account";
                this.pnlFormload.Controls.Clear();
                FrmAddAcc frmAddAcc = new(_user, _accounts) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmAddAcc.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormload.Controls.Add(frmAddAcc);
                frmAddAcc.AddAccount += AddAccount;
                frmAddAcc.Show();

            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                pnlNav.Height = btnSettings.Height;
                pnlNav.Top = btnSettings.Top;
                pnlNav.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

                lblTitle.Text = "Settings";
                this.pnlFormload.Controls.Clear();
                FrmSettings frmSettings = new(_user, _accounts) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmSettings.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormload.Controls.Add(frmSettings);
                frmSettings.IsRemoved += UserRemoved;
                frmSettings.AccountClean += AccountClean;
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

        public void AccountClean(List<Account> accounts)
        {
            _accounts = accounts;
        }

        public void UserRemoved()
        {
            Close();
        }

        private void FrmMenü_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                Screen screen = GetScreen();
                if (Size == screen.WorkingArea.Size)
                {
                    Size = _defaultSize;
                    CenterToScreen();
                }
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            ChangeSize();
        }

        private void ChangeSize()
        {
            if (Size == _defaultSize)
            {
                Screen screen = GetScreen();
                Size = screen.WorkingArea.Size;

            }
            else
            {
                Size = _defaultSize;
            }
            CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmMenü_SizeChanged(object sender, EventArgs e)
        {
            if (_defaultSize != new Size())
            {
                if (Size != _defaultSize)
                {
                    btnMax.Image = Resources.icons8_restore_down_16px;
                }
                else
                {
                    btnMax.Image = Resources.icons8_maximize_button_16px_2;
                }
            }
        }
    }
}
