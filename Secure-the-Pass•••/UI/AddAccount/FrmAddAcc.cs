using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass.UI.AddAccount;

namespace Secure_The_Pass.UI {
    public partial class FrmAddAcc : FrmBaseDialog, IAddAcc {
        public string Website { get => TxtWebsite.Text; set => TxtWebsite.Text = value; }
        public string Email { get => TxtEmail.Text; set => TxtEmail.Text = value; }
        public string Username { get => TxtUsername.Text; set => TxtUsername.Text = value; }
        public string Password { get => TxtPassword.Text; set => TxtPassword.Text = value; }
        public FrmAddAcc() {
            InitializeComponent();
        }

        private void FrmAddAcc_Load(object sender, EventArgs e) {
            Dock = DockStyle.Fill;
            TopLevel = false;
            TopMost = true;
        }

        public void ClearControls() {
            TxtEmail.Clear();
            TxtPassword.Clear();
            TxtUsername.Clear();
            TxtWebsite.Clear();
        }

        public void SetErrorEmail(string errorMessage) {
            TxtEmail.ErrorText = errorMessage;
        }

        public void SetErrorUsername(string errorMessage) {
            TxtUsername.ErrorText = errorMessage;
        }

        public void SetErrorWebsite(string errorMessage) {
            TxtWebsite.ErrorText = errorMessage;
        }

        public void SetErrorPassword(string errorMessage) {
            TxtPassword.ErrorText = errorMessage;
        }

        public void ClearErrorProvider() {
            TxtEmail.ErrorText = "";
            TxtUsername.ErrorText = "";
            TxtWebsite.ErrorText = "";
            TxtPassword.ErrorText = "";
        }
    }
}
