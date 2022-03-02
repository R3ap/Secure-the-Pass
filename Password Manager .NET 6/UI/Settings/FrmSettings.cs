using Password_Manager_.NET_6.Properties;
using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.UI.Settings;
using Password_Manager_.NET_6.UI.LogIn;
using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_.NET_6.Extensions;

namespace Password_Manager_.NET_6
{
    public partial class FrmSettings : FrmBaseDialog
    {
        private readonly DatabaseAccess _database = new DatabaseAccess();
        private User _user;
        private List<Account> _accounts;
        public event Action IsRemoved;
        public event Action LogOut;
        public FrmSettings(ref User user, ref List<Account> accounts)
        {
            InitializeComponent();
            _user = user;
            _accounts = accounts;
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            cboFilter.SelectedIndex = cboFilter.Items.IndexOf(Settings.Default.Filter);
            SettingsView.Nodes[enumSettings.ShowPass.GetDescription()].Checked = Settings.Default.ShowPass;
            var copy = SettingsView.Nodes[enumSettings.CopyToClipboard.GetDescription()];
            copy.Checked = Settings.Default.IsCopy;
            copy.Nodes[enumSettings.CopyToClipboard_Email.GetDescription()].Checked = Settings.Default.IsEmail;
            copy.Nodes[enumSettings.CopyToClipboard_Password.GetDescription()].Checked = Settings.Default.IsPassword;
            copy.Nodes[enumSettings.CopyToClipboard_Username.GetDescription()].Checked = Settings.Default.IsUsername;
            txtPWlengt.Text = Settings.Default.PasswordLenght.ToString();
            SettingsView.ExpandAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPWlengt.Text, out int pwlenght))
            {
                SettingProvider.Clear();
                var copy = SettingsView.Nodes[enumSettings.CopyToClipboard.GetDescription()];
                Settings.Default.IsCopy = copy.Checked;
                Settings.Default.IsEmail = copy.Nodes[enumSettings.CopyToClipboard_Email.GetDescription()].Checked;
                Settings.Default.IsPassword = copy.Nodes[enumSettings.CopyToClipboard_Password.GetDescription()].Checked;
                Settings.Default.IsUsername = copy.Nodes[enumSettings.CopyToClipboard_Username.GetDescription()].Checked;
                Settings.Default.ShowPass = SettingsView.Nodes[enumSettings.ShowPass.GetDescription()].Checked;
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
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete this user?", "Are your sure about that?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes && _database.RemoveUser(_user, _accounts))
            {
                dialogResult = MessageBox.Show("Delete was successfull", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == System.Windows.Forms.DialogResult.OK)
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
            FrmOverview frmLogIn = new();
            frmLogIn.ShowDialog();
        }

        private void treeView1_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                TreeNode treeNode = SettingsView.Nodes[enumSettings.CopyToClipboard.GetDescription()];

                if (treeNode.Nodes[e.Node.Text] == null)
                {
                    return;
                }


                if (!treeNode.Checked
                    && (e.Node.Text == treeNode.Nodes[enumSettings.CopyToClipboard_Password.GetDescription()].Text
                    || e.Node.Text == treeNode.Nodes[enumSettings.CopyToClipboard_Email.GetDescription()].Text
                    || e.Node.Text == treeNode.Nodes[enumSettings.CopyToClipboard_Username.GetDescription()].Text))
                {
                    e.Cancel = true;
                    return;
                }


                switch (e.Node.Index)
                {
                    case (int)enumSettings.CopyToClipboard_Email:
                        if (treeNode.Nodes[enumSettings.CopyToClipboard_Password.GetDescription()].Checked || treeNode.Nodes[enumSettings.CopyToClipboard_Username.GetDescription()].Checked)
                        {
                            e.Cancel = true;
                        }
                        break;
                    case (int)enumSettings.CopyToClipboard_Password:
                        if (treeNode.Nodes[enumSettings.CopyToClipboard_Email.GetDescription()].Checked || treeNode.Nodes[enumSettings.CopyToClipboard_Username.GetDescription()].Checked)
                        {
                            e.Cancel = true;
                        }
                        break;
                    case (int)enumSettings.CopyToClipboard_Username:
                        if (treeNode.Nodes[enumSettings.CopyToClipboard_Email.GetDescription()].Checked || treeNode.Nodes[enumSettings.CopyToClipboard_Password.GetDescription()].Checked)
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
