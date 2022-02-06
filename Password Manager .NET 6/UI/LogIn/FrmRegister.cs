using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.Tasks;
using System.Data;

namespace Password_Manager_.NET_6.UI.LogIn
{
    public partial class FrmRegister : Form
    {
        private User _user;
        private List<Account> _accounts;
        private readonly DatabaseAccess _database = new();
        public FrmRegister()
        {
            InitializeComponent();
        }

        public void Register()
        {
            PassProvider.Clear();
            if (!_database.CheckUser(txtEmail.Text))
            {
                PassProvider.SetError(txtEmail, "The Email Exist");
            }
            else if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtConfirm.Text))
            {
                if (txtPassword.Text != txtConfirm.Text)
                {
                    PassProvider.SetError(txtConfirm, "The Password is not Equal");
                }
                else
                {
                    User user = new() { ID = _database.SelectUsers().OrderByDescending(x => x.ID).First().ID + 1, Email = SecurePasswordHasher.GetEncryptString(txtEmail.Text), Username = SecurePasswordHasher.GetEncryptString(txtUsername.Text), Password = SecurePasswordHasher.GetEncryptString(txtPassword.Text) };
                    bool IsTaskSuccess = GetTaskResult(user);
                    if (IsTaskSuccess)
                    {
                        bool error = _database.InsertUser(user);
                        if (error)
                        {
                            Application.OpenForms["FrmLogInRegister"].Hide();
                            FrmMenü frmMenü = new(_user, _accounts);
                            frmMenü.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                Dictionary<Control, string> dic = new Dictionary<Control, string>();
                string errortext = "This can't be Empty";
                dic.Add(txtEmail, errortext);
                dic.Add(txtUsername, errortext);
                dic.Add(btnEyePassword, errortext);
                dic.Add(btnEyeConfirm, errortext);
                PassProvider.DataSource = dic;
            }
        }

        private bool GetTaskResult(User user)
        {
            InizializeTask inizializeTask = new InizializeTask();
            _user = inizializeTask.InitializeUser(user).Result;
            _accounts = inizializeTask.InitializeAccounts().Result;
            DialogResult dialogResult = DialogResult.None;
            if (_user == null)
            {
                dialogResult = MessageBox.Show("This Task Initialize User", "Task Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (_accounts == null)
            {
                dialogResult = MessageBox.Show("This Task Initialize Accounts", "Task Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dialogResult == DialogResult.OK)
            {
                return false;
            }

            return true;
        }

        private void txtConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register();
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

        private void CtrlRegister_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
