using Password_Manager_.NET_6.UI.BaseDialog;

namespace Password_Manager_.NET_6.UI.ErrorHandler
{
    public interface IErrorHandler : IBaseDialogTitelBar
    {
        void SetMessage(string error, string shortText);
        void SetSize();
    }
}
