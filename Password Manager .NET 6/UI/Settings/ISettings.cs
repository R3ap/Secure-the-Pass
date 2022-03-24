using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.Settings
{
    public interface ISettings : IBaseDialogBase
    {
        string PasswordLenght { get; set; }
        string Filter { get; set; }
        bool ShowPass { get; set; }
        bool IsPassword { get; set; }
        bool IsUsername { get; set; }
        bool IsEmail { get; set; }
        bool IsCopy { get; set; }
        string AllowedCharacters { get; set; }

        void CleanProvider();
        void SetErrorProvider();
        void SetFilter(string filtername);
    }
}
