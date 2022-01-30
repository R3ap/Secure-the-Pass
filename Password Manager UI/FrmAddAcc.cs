using Password_Manager.Properties;
using Password_Manager_.NET_6;
using Password_Manager_.NET_6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Password_Manager_.NET_6
{
    public partial class FrmAddAcc : Form
    {
        private readonly DatabaseAccess _database = new DatabaseAccess();
        private User _user;
        private List<Account> _accounts;
        private Generator _generator = new Generator();
        public event Action<Account> AddAccount;
        public FrmAddAcc(User user, List<Account> accounts)
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
            Account account = new Account();
            account.ID = indexOfAcc + 1;
            account.Email = txtEmail.Text;
            account.Website = txtWebsite.Text;
            account.Username = txtUsername.Text;
            account.Password = txtPassword.Text;
            account.Useremail = _user.Email;
            AddAccount?.Invoke(account);
            txtEmail.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            txtWebsite.Clear();
        }

        private void FrmAddAcc_Load(object sender, EventArgs e)
        {

        }
    }
}
