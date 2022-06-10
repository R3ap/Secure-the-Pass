using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.LogInAndRegister.Register
{
    public partial class FrmRegister : FrmBaseDialog, IRegister
    {
        public Func<bool> Register { get; set; }

        public string Email { get => TxtEmail.Text; set => TxtEmail.Text = value; }
        public string Username { get => TxtUsername.Text; set => TxtUsername.Text = value; }
        public string Password { get => TxtPassword.Text; set => TxtPassword.Text = value; }
        public string PasswordConfirm { get => TxtConfirm.Text; set => TxtConfirm.Text = value; }

        public FrmRegister()
        {
            InitializeComponent();
        }

        public void ClearError()
        {

        }

        public void SetErrorPassword(string errorMessage)
        {
            TxtPassword.ErrorText = errorMessage;
        }

        public void SetErrorEmail(string errorMessage)
        {
            TxtEmail.ErrorText = errorMessage;
        }

        public void SetErrorUsername(string errorMessage)
        {
            TxtUsername.ErrorText = errorMessage;
        }

        public void SetErrorPasswordConfirm(string errorMessage)
        {
            TxtConfirm.ErrorText = errorMessage;
        }

        private void txtConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register?.Invoke();
            }
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            TopLevel = false;
            TopMost = true;
        }
    }
}
