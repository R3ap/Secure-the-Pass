using System.ComponentModel;

namespace Secure_The_Pass.UI.Settings
{
    public enum enumSettings
    {
        [Description("ShowPass")]
        ShowPass = 0,
        [Description("CopyToClipboard")]
        CopyToClipboard = 1,
        [Description("Email")]
        CopyToClipboard_Email = 2,
        [Description("Password")]
        CopyToClipboard_Password = 3,
        [Description("Username")]
        CopyToClipboard_Username = 4,
    }
}
