using Password_Manager_.NET_6.UI.BaseDialog;

namespace Password_Manager_.NET_6.UI.AddAccount
{
    public interface IAddAcc : IBaseDialogBase
    {
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
