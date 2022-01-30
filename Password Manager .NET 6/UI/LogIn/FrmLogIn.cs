using Password_Manager.Properties;
using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.Tasks;
using System.Data;

namespace Password_Manager_.NET_6
{
    public partial class FrmLogIn : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private User _user;
        private List<Account> _accounts;
        private readonly DatabaseAccess _database = new DatabaseAccess();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void LlblForgotPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgotPW frmForgotPW = new FrmForgotPW();
            frmForgotPW.ShowDialog();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (lblTitle.Text == "Register")
            {
                Register();
            }
            else
            {
                lblTitle.Text = "Register";
                lblConfirm.Visible = true;
                PassProvider.Clear();
                txtUser.Visible = true;
                lblEmail.Visible = true;
                llblForgotPw.Visible = false;
                txtConfirm.Visible = true;
                btnEyeConfirm.Visible = true;
                Size = new Size(558, 370);
                chkStayLogged.Visible = false;
            }
        }

        private void Register()
        {
            PassProvider.Clear();
            if (!_database.CheckUser(txtEmail.Text))
            {
                PassProvider.SetError(txtEmail, "The Email Exist");
            }
            else if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtConfirm.Text))
            {
                if (txtPassword.Text != txtConfirm.Text)
                {
                    PassProvider.SetError(txtConfirm, "The Password is not Equal");
                }
                else
                {
                    User user = new User() { ID = _database.SelectUsers().OrderByDescending(x => x.ID).First().ID + 1, Email = SecurePasswordHasher.GetEncryptString(txtEmail.Text), Username = SecurePasswordHasher.GetEncryptString(txtUser.Text), Password = SecurePasswordHasher.GetEncryptString(txtPassword.Text) };
                    bool IsTaskSuccess = GetTaskResult(user);
                    if (IsTaskSuccess)
                    {
                        bool error = _database.InsertUser(user);
                        if (error)
                        {
                            this.Hide();
                            FrmMenü frmMenü = new FrmMenü(_user, _accounts);
                            frmMenü.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                PassProvider.SetError(txtEmail, "This can't be Empty");
                PassProvider.SetError(txtUser, "This can't be Empty");
                PassProvider.SetError(btnEyePassword, "This can't be Empty");
                PassProvider.SetError(btnEyeConfirm, "This can't be Empty");
            }
        }

        private void FrmLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LogIn()
        {
            List<User> users = _database.SelectUsers();
            if (users.Any(x => x.Email == SecurePasswordHasher.GetEncryptString(txtEmail.Text)) && SecurePasswordHasher.Verify(users.First(x => x.Email == SecurePasswordHasher.GetEncryptString(txtEmail.Text)).Password, txtPassword.Text))
            {
                this.Hide();
                bool IsTaskSuccess = GetTaskResult(users.First(x => x.Email == SecurePasswordHasher.GetEncryptString(txtEmail.Text)));
                if (IsTaskSuccess)
                {
                    if (chkStayLogged.Checked)
                    {
                        Settings.Default.Email = SecurePasswordHasher.GetEncryptString(_user.Email);
                    }
                    else
                    {
                        Settings.Default.Email = null;
                    }
                    Settings.Default.Save();
                    FrmMenü frmMenü = new FrmMenü(_user, _accounts);
                    frmMenü.ShowDialog();
                }
            }
            else
            {
                PassProvider.SetError(txtEmail, "Wrong Data");
                PassProvider.SetError(btnEyePassword, "Wrong Data");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (lblTitle.Text == "LogIn")
            {
                LogIn();
            }
            else
            {
                PassProvider.Clear();
                lblTitle.Text = "LogIn";
                lblConfirm.Visible = false;
                txtUser.Visible = false;
                lblEmail.Visible = false;
                llblForgotPw.Visible = true;
                txtConfirm.Visible = false;
                btnEyeConfirm.Visible = false;
                Size = new Size(558, 329);
                chkStayLogged.Visible = true;
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

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && lblTitle.Text == "LogIn")
            {
                LogIn();
            }
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

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Settings.Default.Email))
                {
                    List<User> users = _database.SelectUsers();
                    this.Close();
                    bool IsTaskSuccess = GetTaskResult(users.First(x => x.Email == Settings.Default.Email));
                    if (IsTaskSuccess)
                    {
                        FrmMenü frmMenü = new FrmMenü(_user, _accounts);
                        frmMenü.ShowDialog();

                    }
                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void Error(Exception ex)
        {
            ErrorHandler error = new ErrorHandler();
            error.ShowDialog(ex);
        }
    }
}
