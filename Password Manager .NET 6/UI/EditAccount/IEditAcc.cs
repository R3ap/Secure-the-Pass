using Password_Manager_.NET_6.UI.BaseDialog;

namespace Password_Manager_.NET_6.UI.EditAccount
{
    public interface IEditAcc : IBaseDialogTitelBar
    {
        string Website { get; set; }
        string Email { get; set; }
        string Username { get; set; }
        string Password { get; set; }
    }
}
