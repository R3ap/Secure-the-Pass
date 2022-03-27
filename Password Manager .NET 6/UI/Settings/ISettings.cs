using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.Settings
{
    public interface ISettings : IBaseDialogBase
    {
        string PasswordLenght { get; set; }
        string Filter { get; set; }
        bool ShowPass { get; set; }
        bool IsCopy { get; set; }
        string AllowedCharacters { get; set; }
        string CopyToClipboard { get; set; }
        bool RememberMe { get; set; }

        void CleanProvider();
        void SetErrorProvider();
        void SetFilter(string filtername);
    }
}
