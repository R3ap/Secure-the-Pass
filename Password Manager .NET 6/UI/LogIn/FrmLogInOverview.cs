using Password_Manager_.NET_6.UI.BaseDialog;

namespace Password_Manager_.NET_6.UI.LogIn
{
    public partial class FrmLogInOverview : FrmBaseDialogTitelBar
    {
        private FrmRegister _register = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private LogInPresenter _login = new();
        
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
            MaximizeBox = false;
            MinimizeBox = false;
            Titel = "LogIn";
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
