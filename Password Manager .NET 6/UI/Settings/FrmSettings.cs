using Password_Manager_.NET_6.UI.Settings;
using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_.NET_6.Extensions;

namespace Password_Manager_.NET_6
{
    public partial class FrmSettings : FrmBaseDialog, ISettings
    {
        private string _showPassDescription = enumSettings.ShowPass.GetDescription();
        private string _copyDescription = enumSettings.CopyToClipboard.GetDescription();
        private string _emailDescription = enumSettings.CopyToClipboard_Email.GetDescription();
        private string _passwordDescription = enumSettings.CopyToClipboard_Password.GetDescription();
        private string _usernameDescription = enumSettings.CopyToClipboard_Username.GetDescription();
        
        public string PasswordLenght { get => txtPWlengt.Text; set => txtPWlengt.Text = value; }
        public string AllowedCharacters { get => TxtAllowedCharacters.Text; set => TxtAllowedCharacters.Text = value; }
        public string Filter { get => cboFilter.Text; set => cboFilter.Text = value; }
        public bool ShowPass { get => SettingsView.Nodes[_showPassDescription].Checked; set => SettingsView.Nodes[_showPassDescription].Checked = value; }
        public bool IsCopy { get => SettingsView.Nodes[_copyDescription].Checked; set => SettingsView.Nodes[_copyDescription].Checked = value; }
        public bool IsEmail { get => SettingsView.Nodes[_copyDescription].Nodes[_emailDescription].Checked; set => SettingsView.Nodes[_copyDescription].Nodes[_emailDescription].Checked = value; }
        public bool IsUsername { get => SettingsView.Nodes[_copyDescription].Nodes[_passwordDescription].Checked; set => SettingsView.Nodes[_copyDescription].Nodes[_passwordDescription].Checked = value; }
        public bool IsPassword { get => SettingsView.Nodes[_copyDescription].Nodes[_usernameDescription].Checked; set => SettingsView.Nodes[_copyDescription].Nodes[_usernameDescription].Checked = value; }

        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            TopLevel = false; 
            TopMost = true;
            SettingsView.ExpandAll();
        }

        public void SetFilter(string filtername)
        {
            cboFilter.SelectedIndex = cboFilter.Items.IndexOf(filtername);
        }

        public void CleanProvider()
        {
            SettingProvider.Clear();
        }

        public void SetErrorProvider()
        {
            CleanProvider();
            SettingProvider.SetError(txtPWlengt, "Only Numbers");
        }

        private void treeView1_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            //try
            //{
                //TreeNode treeNode = SettingsView.Nodes[_copyDescription];

                //if (treeNode.Nodes[e.Node.Text] == null)
                //{
                //    return;
                //}


                //if (!treeNode.Checked
                //    && (e.Node.Text == treeNode.Nodes[_emailDescription].Text
                //    || e.Node.Text == treeNode.Nodes[_passwordDescription].Text
                //    || e.Node.Text == treeNode.Nodes[_usernameDescription].Text))
                //{
                //    e.Cancel = true;
                //    return;
                //}


                //switch (e.Node.Index)
                //{
                //    case treeNode.Nodes[_emailDescription].Index:
                //        if (treeNode.Nodes[_passwordDescription].Checked || treeNode.Nodes[_usernameDescription].Checked)
                //        {
                //            e.Cancel = true;
                //        }
                //        break;
                //    case _passwordDescription:
                //        if (treeNode.Nodes[_emailDescription].Checked || treeNode.Nodes[_usernameDescription].Checked)
                //        {
                //            e.Cancel = true;
                //        }
                //        break;
                //    case _usernameDescription:
                //        if (treeNode.Nodes[_emailDescription].Checked || treeNode.Nodes[_passwordDescription].Checked)
                //        {
                //            e.Cancel = true;
                //        }
                //        break;
                //    default:
                //        throw new NotImplementedException();
                //}
            //}
            //catch (Exception ex)
            //{
            //    Error(ex);
            //}
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
