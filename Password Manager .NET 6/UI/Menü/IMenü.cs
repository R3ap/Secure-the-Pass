using Password_Manager_.NET_6.UI.BaseDialog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager_.NET_6.UI.Menü
{
    public interface IMenü : IBaseDialogTitelBar
    {
        string Username { get; set; }
        Action ShowAccountsDialog { get; set; }
        Action ShowAddAccountsDialog { get; set; }
        Action ShowSettingsDialog { get; set; }

        void Close();
        void Hide();
    }
}
