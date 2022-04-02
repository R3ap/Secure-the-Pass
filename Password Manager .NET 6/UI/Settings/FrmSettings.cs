using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass_Services_Core.Extensions;

namespace Secure_The_Pass.UI.Settings
{
    public partial class FrmSettings : FrmBaseDialog, ISettings
    {
        private string _showPassDescription = enumSettings.ShowPass.GetDescription();
        private string _copyDescription = enumSettings.CopyToClipboard.GetDescription();
        private string _rememberMe = enumSettings.RememberMe.GetDescription();

        public string PasswordLenght { get => TxtPasswordLength.Text; set => TxtPasswordLength.Text = value; }
        public string AllowedCharacters { get => TxtAllowedCharacters.Text; set => TxtAllowedCharacters.Text = value; }
        public bool ShowPass { get => SettingsView.Nodes[_showPassDescription].Checked; set => SettingsView.Nodes[_showPassDescription].Checked = value; }
        public bool IsCopy { get => SettingsView.Nodes[_copyDescription].Checked; set => SettingsView.Nodes[_copyDescription].Checked = value; }
        public bool RememberMe { get => SettingsView.Nodes[_rememberMe].Checked; set => SettingsView.Nodes[_rememberMe].Checked = value; }
        public string CopyToClipboard { get => CboCopyToClipboard.Text; set => CboCopyToClipboard.Text = value; }

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

        public void CleanProvider()
        {
            TxtPasswordLength.ErroText = "";
        }

        public void SetError()
        {
            TxtPasswordLength.ErroText = "Only Numbers";
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
