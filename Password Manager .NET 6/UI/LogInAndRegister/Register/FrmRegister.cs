using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_.NET_6.UI.LogInAndRegister.Register;

namespace Password_Manager_.NET_6.UI.LogIn
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
            PassProvider.Clear();
        }

        public void SetErrorPassword(string errorMessage)
        {
            PassProvider.SetError(TxtPassword, errorMessage);
        }

        public void SetErrorEmail(string errorMessage)
        {
            PassProvider.SetError(TxtEmail, errorMessage);
        }

        public void SetErrorUsername(string errorMessage)
        {
            PassProvider.SetError(TxtUsername, errorMessage);
        }

        public void SetErrorPasswordConfirm(string errorMessage)
        {
            PassProvider.SetError(TxtConfirm, errorMessage);
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
