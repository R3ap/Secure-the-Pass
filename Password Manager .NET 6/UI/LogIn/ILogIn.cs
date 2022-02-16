using Password_Manager_.NET_6.UI.BaseDialog;

namespace Password_Manager_.NET_6.UI.LogIn
{
    public interface ILogIn : IBaseDialogBase
    {
        bool RememberMe { get; set; }

        string Email { get; set ; }

        string Password { get; set; }
        Action LoginByRememberMe { get; set; }
    }
}
