using Password_Manager_.NET_6.UI.BaseDialog;

namespace Password_Manager_.NET_6.UI.LogInAndRegister.Overview
{
    public interface IOverview : IBaseDialogTitelBar
    {
        Action SetMainControl { get; set; }

        void SetFormSize(bool IsLogin);
    }
}