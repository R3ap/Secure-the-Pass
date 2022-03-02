using Password_Manager_.NET_6.Properties;
using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_.NET_6.UI.AddAccount;

namespace Password_Manager_.NET_6
{
    public partial class FrmAddAcc : FrmBaseDialog, IAddAcc
    {
        public string Website { get => txtWebsite.Text; set => txtWebsite.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string Username { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public FrmAddAcc()
        {
            InitializeComponent();
            
        }

        public void ClearControls()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            txtWebsite.Clear();
        }

        private void FrmAddAcc_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            TopLevel = false;
            TopMost = true;
        }
    }
}
