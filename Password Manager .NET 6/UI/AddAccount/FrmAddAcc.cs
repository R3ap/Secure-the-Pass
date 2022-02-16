using Password_Manager_.NET_6.Properties;
using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.UI.BaseDialog;

namespace Password_Manager_.NET_6
{
    public partial class FrmAddAcc : FrmBaseDialog
    {
        private readonly DatabaseAccess _database = new();
        private User _user;
        private List<Account> _accounts;
        private Generator _generator = new();
        public FrmAddAcc(ref User user, ref List<Account> accounts)
        {
            InitializeComponent();
            _user = user;
            _accounts = accounts;
        }

        private void btnGenaratPW_Click(object sender, EventArgs e)
        {
            txtPassword.Text = _generator.GetPW(Settings.Default.PasswordLenght);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int indexOfAcc = _database.GetIndexOfAccouts();
            _database.InsertAccount(new Account() { ID = indexOfAcc + 1, Email = SecurePasswordHasher.GetEncryptString(txtEmail.Text), Website = SecurePasswordHasher.GetEncryptString(txtWebsite.Text), Username = SecurePasswordHasher.GetEncryptString(txtUsername.Text), Password = SecurePasswordHasher.GetEncryptString(txtPassword.Text), Useremail = SecurePasswordHasher.GetEncryptString(_user.Email) });
            Account account = new()
            {
                ID = indexOfAcc + 1,
                Email = txtEmail.Text,
                Website = txtWebsite.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Useremail = _user.Email
            };
            _accounts.Add(account);
            txtEmail.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            txtWebsite.Clear();
        }
    }
}
