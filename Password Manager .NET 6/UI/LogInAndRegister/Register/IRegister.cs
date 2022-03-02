using Password_Manager_.NET_6.UI.BaseDialog;

namespace Password_Manager_.NET_6.UI.LogInAndRegister.Register
{
    public interface IRegister : IBaseDialogBase
    {
        Func<bool> Register { get; set; }
        string Email { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string PasswordConfirm { get; set; }

        void ClearError();
        void SetErrorEmail(string errorMessage);
        void SetErrorPassword(string errorMessage);
        void SetErrorPasswordConfirm(string errorMessage);
        void SetErrorUsername(string errorMessage);
    }
}
