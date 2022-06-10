using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.AddAccount {
    public interface IAddAcc : IBaseDialogBase {
        string Password { get; set; }
        string Username { get; set; }
        string Email { get; set; }
        string Website { get; set; }

        void ClearControls();
        void ClearErrorProvider();
        void SetErrorEmail(string errorMessage);
        void SetErrorPassword(string errorMessage);
        void SetErrorUsername(string errorMessage);
        void SetErrorWebsite(string errorMessage);
    }
}
