using Secure_The_Pass.UI.BaseDialog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_The_Pass.UI.Menü
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
