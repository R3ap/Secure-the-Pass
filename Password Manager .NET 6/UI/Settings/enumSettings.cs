using System.ComponentModel;

namespace Password_Manager_.NET_6.UI.Settings
{
    public enum enumSettings
    {
        [Description("ShowPass")]
        ShowPass = 0,
        [Description("CopyToClipboard")]
        CopyToClipboard = 1,
        [Description("CopyToClipboard_Email")]
        CopyToClipboard_Email = 0,
        [Description("CopyToClipboard_Password")]
        CopyToClipboard_Password = 1,
        [Description("CopyToClipboard_Username")]
        CopyToClipboard_Username = 2,
    }
}
