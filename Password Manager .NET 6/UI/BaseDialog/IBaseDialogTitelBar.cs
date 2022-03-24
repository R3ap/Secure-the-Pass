namespace Secure_The_Pass.UI.BaseDialog
{
    public interface IBaseDialogTitelBar : IBaseDialogBase
    {
        string Titel { get; set; }
        bool MaximizeBox { get; set; }
        bool MinimizeBox { get; set; }
        bool ShowIcon { get; set; }
    }
}
