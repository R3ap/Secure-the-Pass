using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass.UI.AddAccount;

namespace Secure_The_Pass.UI
{
    public partial class FrmAddAcc : FrmBaseDialog, IAddAcc
    {
        public string Website { get => TxtWebsite.Text; set => TxtWebsite.Text = value; }
        public string Email { get => TxtEmail.Text; set => TxtEmail.Text = value; }
        public string Username { get => TxtUsername.Text; set => TxtUsername.Text = value; }
        public string Password { get => TxtPassword.Text; set => TxtPassword.Text = value; }
        public FrmAddAcc()
        {
            InitializeComponent();
        }

        private void FrmAddAcc_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            TopLevel = false;
            TopMost = true;
        }

        public void ClearControls()
        {
            TxtEmail.Clear();
            TxtPassword.Clear();
            TxtUsername.Clear();
            TxtWebsite.Clear();
        }

        public void SetErrorEmail(string errorMessage)
        {
            TxtEmail.ErroText = errorMessage;
        }

        public void SetErrorUsername(string errorMessage)
        {
            TxtUsername.ErroText = errorMessage;
        }

        public void SetErrorWebsite(string errorMessage)
        {
            TxtWebsite.ErroText = errorMessage;
        }

        public void SetErrorPassword(string errorMessage)
        {
            TxtPassword.ErroText = errorMessage;
        }

        public void ClearErrorProvider()
        {
            TxtEmail.ErroText = "";
            TxtUsername.ErroText = "";
            TxtWebsite.ErroText = "";
            TxtPassword.ErroText = "";
        }
    }
}
