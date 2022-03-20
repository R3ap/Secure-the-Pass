﻿using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_Services_Core.Model;

namespace Password_Manager_.NET_6.UI.Accounts
{
    public interface IAccounts : IBaseDialogBase
    {
        Action GetAccounts { get; set; }
        Action<string> Search { get; set; }
        Action<int> ShowDetailsAccount { get; set; }
        Action<string> OpenBrowser { get; set; }
        Action<int> IndexClicked { get; set; }

        void SetDataSource(List<Account> accounts);
        void SetGridProperty();
        void SetSelectedRow(int rowIndex);
    }
}
