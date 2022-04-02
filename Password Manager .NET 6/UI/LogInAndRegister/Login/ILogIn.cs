using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.LogInAndRegister.Login
{
    public interface ILogIn : IBaseDialogBase
    {
        bool RememberMe { get; set; }

        string Email { get; set; }

        string Password { get; set; }
        Action LoginByRememberMe { get; set; }

        void InvalidData();
        void SetFocus();
    }
}
