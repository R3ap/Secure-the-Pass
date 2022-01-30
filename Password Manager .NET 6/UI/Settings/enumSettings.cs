using System.ComponentModel;

namespace Password_Manager_.NET_6.UI.Settings
{
    public enum enumSettings
    {
        [Description("Shows the Password in the Grid")]
        ShowPass = 0,
        [Description("Allows to Copy the Email, Password or Username")]
        CopyToClipboard = 1,
        [Description("Copys the Email")]
        CopyToClipboard_Email = 0,
        [Description("Copys the Password")]
        CopyToClipboard_Password = 1,
        [Description("Copys the Username")]
        CopyToClipboard_Username = 2,
    }
}
