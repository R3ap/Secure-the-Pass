using System.ComponentModel;

namespace Secure_The_Pass.UI.Settings
{
    [Serializable()]
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
        [Description("Remember me")]
        RememberMe = 5,
    }

    public static class Settings
    {
        public static enumSettings? MappingOnEnumSettings(this string notmapped)
        {
            return notmapped switch
            {
                "Password" => enumSettings.CopyToClipboard_Password,
                "Email" => enumSettings.CopyToClipboard_Email,
                "Username" => enumSettings.CopyToClipboard_Username,
                "ShowPass" => enumSettings.ShowPass,
                "CopyToClipboard" => enumSettings.CopyToClipboard,
                "Remember me" => enumSettings.RememberMe,
                _ => null,
            };
        }
    }
}
