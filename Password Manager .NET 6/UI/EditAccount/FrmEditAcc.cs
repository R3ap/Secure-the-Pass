using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.EditAccount
{
    public partial class FrmEditAcc : FrmBaseDialogTitelBar, IEditAcc
    {
        public string Website { get => txtWebsite.Text; set => txtWebsite.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string Username { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public FrmEditAcc()
        {
            InitializeComponent();
        }

        private void FrmEditAcc_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            Titel = "Edit Account";
            Size = new Size(661, 452);
        }
    }
}
