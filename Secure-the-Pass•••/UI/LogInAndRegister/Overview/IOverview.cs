using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.LogInAndRegister.Overview {
    public interface IOverview : IBaseDialogTitelBar {
        Action SetMainControl { get; set; }

        void SetFormSize(bool IsLogin);
    }
}