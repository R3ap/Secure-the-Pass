using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.EditAccount
{
    public interface IEditAcc : IBaseDialogTitelBar
    {
        string Website { get; set; }
        string Email { get; set; }
        string Username { get; set; }
        string Password { get; set; }
    }
}
