using Password_Manager_.NET_6.UI.BaseDialog;

namespace Password_Manager_.NET_6.UI.LogIn
{
    public partial class FrmLogInOverview : FrmBaseDialog
    {
        private FrmRegister _register = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private LogInPresenter _login = new();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public FrmLogInOverview()
        {
            InitializeComponent();
        }

        private void LlblForgotPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgotPW frmForgotPW = new();
            frmForgotPW.ShowDialog();
        }



        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (PnlContent.Controls.Contains(_register))
            {
                _register.Register();
            }
            else
            {
                PnlContent.Controls.Clear();
                PnlContent.Controls.Add(_register);
                _register.Show();
            }
        }

        private void FrmLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (PnlContent.Controls.Contains((FrmLogIn)Application.OpenForms[nameof(FrmLogIn)]))
            {
                ((FrmLogIn)Application.OpenForms[nameof(FrmLogIn)]).AcceptClick();
            }
            else
            {
                PnlContent.Controls.Clear();
                _login.Show();
                PnlContent.Controls.Add((FrmLogIn)Application.OpenForms[nameof(FrmLogIn)]);
            }
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            PnlContent.Controls.Clear();
            _login.Show();
            PnlContent.Controls.Add((FrmLogIn)Application.OpenForms[nameof(FrmLogIn)]);
            AddButtonAction(new ButtonAction() { Action = Register, Text = "&Register", Name = "BtnRegister" });
        }

        private void Register()
        {

        }
    }
}
