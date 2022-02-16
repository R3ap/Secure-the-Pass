using Password_Manager_.NET_6.Properties;
using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.UI.BaseDialog;

namespace Password_Manager_.NET_6
{
    public partial class FrmEditAcc : FrmBaseDialogTitelBar
    {
        private Account _account;
        private DatabaseAccess _database = new DatabaseAccess();
        private Generator _generator = new Generator();
        public event Action<Account> UpdateAcc;
        public event Action DeleteAcc;
        public FrmEditAcc(Account account)
        {
            InitializeComponent();
            _account = account;
        }

        private void FrmEditAcc_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            Titel = "Edit Account";
            Size = new Size(661, 452);
            txtWebsite.Text = _account.Website;
            txtPassword.Text = _account.Password;
            txtUsername.Text = _account.Username;
            txtEmail.Text = _account.Email;
        }

        private void btnGenaratPW_Click(object sender, EventArgs e)
        {
            txtPassword.Text = _generator.GetPW(Settings.Default.PasswordLenght);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Account account = _database.UpdateAccount(_account.ID, SecurePasswordHasher.GetEncryptString(txtWebsite.Text), SecurePasswordHasher.GetEncryptString(txtEmail.Text), SecurePasswordHasher.GetEncryptString(txtUsername.Text), SecurePasswordHasher.GetEncryptString(txtPassword.Text));
            account.Email = txtEmail.Text;
            account.Website = txtWebsite.Text;
            account.Username = txtUsername.Text;
            account.Password = txtPassword.Text;
            UpdateAcc?.Invoke(account);
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _database.RemoveAcc(_account);
            DeleteAcc?.Invoke();
            Close();
        }
    }
}
