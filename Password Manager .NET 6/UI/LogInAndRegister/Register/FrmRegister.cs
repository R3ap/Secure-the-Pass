using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_.NET_6.UI.LogInAndRegister.Register;

namespace Password_Manager_.NET_6.UI.LogIn
{
    public partial class FrmRegister : FrmBaseDialog, IRegister
    {
        public Func<bool> Register { get; set; }

        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string Username { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public string PasswordConfirm { get => txtConfirm.Text; set => txtConfirm.Text = value; }

        public FrmRegister()
        {
            InitializeComponent();
        }

        public void ClearError()
        {
            PassProvider.Clear();
        }

        public void SetErrorPassword(string errorMessage)
        {
            PassProvider.SetError(btnEyePassword, errorMessage);
        }

        public void SetErrorEmail(string errorMessage)
        {
            PassProvider.SetError(txtEmail, errorMessage);
        }

        public void SetErrorUsername(string errorMessage)
        {
            PassProvider.SetError(txtUsername, errorMessage);
        }

        public void SetErrorPasswordConfirm(string errorMessage)
        {
            PassProvider.SetError(btnEyeConfirm, errorMessage);
        }

        private void txtConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register?.Invoke();
            }
        }

        private void btnEyePassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnEyePassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '•';
        }

        private void btnEyeConfirm_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirm.PasswordChar = '\0';
        }

        private void btnEyeConfirm_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirm.PasswordChar = '•';
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            TopLevel = false;
            TopMost = true;
        }
    }
}
