using Password_Manager.Properties;
using Password_Manager_.NET_6.Model;

namespace Password_Manager_.NET_6
{
    public partial class FrmSettings : Form
    {
        private readonly DatabaseAccess _database = new DatabaseAccess();
        private User _user;
        private List<Account> _accounts;
        public event Action IsRemoved;
        public event Action<List<Account>> AccountClean;
        public event Action LogOut;
        public FrmSettings(User user, List<Account> accounts)
        {
            InitializeComponent();
            _user = user;
            _accounts = accounts;
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            cboFilter.SelectedIndex = cboFilter.Items.IndexOf(Settings.Default.Filter);
            SettingsView.Nodes[(int)enumSettings.ShowPass].Checked = Settings.Default.ShowPass;
            var copy = SettingsView.Nodes[(int)enumSettings.CopyToClipboard];
            copy.Checked = Settings.Default.IsCopy;
            copy.Nodes[(int)enumSettings.CopyToClipboard_Email].Checked = Settings.Default.IsEmail;
            copy.Nodes[(int)enumSettings.CopyToClipboard_Password].Checked = Settings.Default.IsPassword;
            copy.Nodes[(int)enumSettings.CopyToClipboard_Username].Checked = Settings.Default.IsUsername;
            txtPWlengt.Text = Settings.Default.PasswordLenght.ToString();
            SettingsView.ExpandAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPWlengt.Text, out int pwlenght))
            {
                SettingProvider.Clear();
                var copy = SettingsView.Nodes[(int)enumSettings.CopyToClipboard];
                Settings.Default.IsCopy = copy.Checked;
                Settings.Default.IsEmail = copy.Nodes[(int)enumSettings.CopyToClipboard_Email].Checked;
                Settings.Default.IsPassword = copy.Nodes[(int)enumSettings.CopyToClipboard_Password].Checked;
                Settings.Default.IsUsername = copy.Nodes[(int)enumSettings.CopyToClipboard_Username].Checked;
                Settings.Default.ShowPass = SettingsView.Nodes[(int)enumSettings.ShowPass].Checked;
                Settings.Default.PasswordLenght = pwlenght;
                Settings.Default.Filter = cboFilter.SelectedItem.ToString();
                Settings.Default.Save();
            }
            else
            {
                SettingProvider.SetError(txtPWlengt, "Only Numbers");
            }
        }
        private void btnCleanAcc_Click(object sender, EventArgs e)
        {
            _database.CleanAccount(_accounts);
            AccountClean?.Invoke(_accounts = new List<Account>());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete this user?", "Are your sure about that?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes && _database.RemoveUser(_user, _accounts))
            {
                dialogResult = MessageBox.Show("Delete was successfull", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    IsRemoved?.Invoke();
                }
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            LogOut?.Invoke();
            Settings.Default.Email = null;
            Settings.Default.Save();
            FrmLogIn frmLogIn = new FrmLogIn();
            frmLogIn.ShowDialog();
        }

        private void treeView1_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                TreeNode treeNode = SettingsView.Nodes[(int)enumSettings.CopyToClipboard];

                if (treeNode.Nodes[e.Node.Text] == null)
                {
                    return;
                }


                if (!treeNode.Checked
                    && (e.Node.Text == treeNode.Nodes[(int)enumSettings.CopyToClipboard_Password].Text
                    || e.Node.Text == treeNode.Nodes[(int)enumSettings.CopyToClipboard_Email].Text
                    || e.Node.Text == treeNode.Nodes[(int)enumSettings.CopyToClipboard_Username].Text))
                {
                    e.Cancel = true;
                    return;
                }


                switch (e.Node.Index)
                {
                    case (int)enumSettings.CopyToClipboard_Email:
                        if (treeNode.Nodes[(int)enumSettings.CopyToClipboard_Password].Checked || treeNode.Nodes[(int)enumSettings.CopyToClipboard_Username].Checked)
                        {
                            e.Cancel = true;
                        }
                        break;
                    case (int)enumSettings.CopyToClipboard_Password:
                        if (treeNode.Nodes[(int)enumSettings.CopyToClipboard_Email].Checked || treeNode.Nodes[(int)enumSettings.CopyToClipboard_Username].Checked)
                        {
                            e.Cancel = true;
                        }
                        break;
                    case (int)enumSettings.CopyToClipboard_Username:
                        if (treeNode.Nodes[(int)enumSettings.CopyToClipboard_Email].Checked || treeNode.Nodes[(int)enumSettings.CopyToClipboard_Password].Checked)
                        {
                            e.Cancel = true;
                        }
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void Error(Exception ex)
        {
            ErrorHandler errorHandler = new ErrorHandler();
            errorHandler.ShowDialog(ex);
        }

        private void txtPWlengt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
