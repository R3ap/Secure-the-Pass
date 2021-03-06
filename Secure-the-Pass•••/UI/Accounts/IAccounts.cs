using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass_Services_Core.Model;

namespace Secure_The_Pass.UI.Accounts {
    public interface IAccounts : IBaseDialogBase {
        Action<string> Search { get; set; }
        Action<int> ShowDetailsAccount { get; set; }
        Action<string> OpenBrowser { get; set; }
        Action<int> IndexClicked { get; set; }
        Func<bool> ShowPassword { get; set; }

        void SetDataSource(List<Account> accounts);
        void SetSelectedRow(int rowIndex);
        void SetError();
        void SetGridProperty();
    }
}
