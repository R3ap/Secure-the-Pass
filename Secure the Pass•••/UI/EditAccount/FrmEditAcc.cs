using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.EditAccount
{
    public partial class FrmEditAcc : FrmBaseDialogTitelBar, IEditAcc
    {
        public string Website { get => TxtWebsite.Text; set => TxtWebsite.Text = value; }
        public string Email { get => TxtEmail.Text; set => TxtEmail.Text = value; }
        public string Username { get => TxtUsername.Text; set => TxtUsername.Text = value; }
        public string Password { get => TxtPassword.Text; set => TxtPassword.Text = value; }
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
