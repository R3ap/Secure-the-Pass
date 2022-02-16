namespace Password_Manager_.NET_6.UI.BaseDialog
{
    public interface IBaseDialogTitelBar : IBaseDialogBase
    {
        string Titel { get; set; }
        bool MaximizeBox { get; set; }
        bool MinimizeBox { get; set; }
        bool ShowIcon { get; set; }
    }
}
