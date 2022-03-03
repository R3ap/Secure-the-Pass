using Password_Manager_.NET_6.Extensions;
using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.UI.BaseDialog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager_.NET_6.UI.Settings
{
    public class SettingsPresenter : BaseDialogPresenter<ISettings>
    {
        private readonly DatabaseAccess _database = new DatabaseAccess();
        private User _user;
        private List<Account> _accounts;
        public event Action IsRemoved;
        public event Action LogOut;
        private string _showPassDescription = enumSettings.ShowPass.GetDescription();
        private string _copyDescription = enumSettings.CopyToClipboard.GetDescription();
        private string _emailDescription = enumSettings.CopyToClipboard_Email.GetDescription();
        private string _passwordDescription = enumSettings.CopyToClipboard_Password.GetDescription();
        private string _usernameDescription = enumSettings.CopyToClipboard_Username.GetDescription();
        public SettingsPresenter(ref User user, ref List<Account> accounts) : base(new FrmSettings())
        {
            View.OnAcceptClick = Setting;
        }

        private bool Setting()
        {
            if (int.TryParse(txtPWlengt.Text, out int pwlenght))
            {
                SettingProvider.Clear();
                var copy = SettingsView.Nodes[_copyDescription];
                Settings.Default.IsCopy = copy.Checked;
                Settings.Default.IsEmail = copy.Nodes[_emailDescription].Checked;
                Settings.Default.IsPassword = copy.Nodes[_passwordDescription].Checked;
                Settings.Default.IsUsername = copy.Nodes[_usernameDescription].Checked;
                Settings.Default.ShowPass = SettingsView.Nodes[_showPassDescription].Checked;
                Settings.Default.PasswordLenght = pwlenght;
                Settings.Default.Filter = cboFilter.SelectedItem.ToString();
                Settings.Default.Save();
            }
            else
            {
                SettingProvider.SetError(txtPWlengt, "Only Numbers");
            }
            return false;
        }

    }
}
