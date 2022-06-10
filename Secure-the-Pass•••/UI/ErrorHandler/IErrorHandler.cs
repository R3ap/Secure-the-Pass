using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.ErrorHandler {
    public interface IErrorHandler : IBaseDialogTitelBar {
        void SetMessage(string error, string shortText);
        void SetSize();
    }
}
