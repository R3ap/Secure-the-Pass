using Password_Manager_.NET_6.UI.BaseDialog;

namespace Password_Manager_.NET_6.UI.LogIn
{
    public interface ILogIn : IBaseDialogBase
    {
        new Func<string, string, bool, bool> OnAcceptClick { get; set; }
        Action LoginByRememberMe { get; set; }
    }
}
