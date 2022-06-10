using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.Menu {
    public interface IMenu : IBaseDialogTitelBar {
        string Username { get; set; }
        Action ShowAccountsDialog { get; set; }
        Action ShowAddAccountsDialog { get; set; }
        Action ShowSettingsDialog { get; set; }

        void Close();
        void Hide();
    }
}
