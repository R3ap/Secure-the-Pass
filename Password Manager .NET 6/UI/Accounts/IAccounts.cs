using Password_Manager_.NET_6.UI.BaseDialog;
using Services_Core.Model;

namespace Password_Manager_.NET_6.UI.Accounts
{
    public interface IAccounts : IBaseDialogBase
    {
        Action GetAccounts { get; set; }
        Action<string> Search { get; set; }

        void SetDataSource(List<Account> accounts);
        void SetGridProperty();
        void SetSelectedRow(int rowIndex);
    }
}
