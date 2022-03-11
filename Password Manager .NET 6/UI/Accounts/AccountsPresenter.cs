using Password_Manager_.NET_6.Extensions;
using Password_Manager_.NET_6.UI.BaseDialog;
using Service_Core.Model;
using Service_Core.Services.AccountService;

namespace Password_Manager_.NET_6.UI.Accounts
{
    public class AccountsPresenter : BaseDialogPresenter<IAccounts>
    {
        private User _user;
        private List<Account> _accounts;
        public event Action<List<Account>> SetnewListAcc;
        private readonly IAccountService _accountService = new AccountService();
        public AccountsPresenter(User user, ref List<Account> accounts) : base(new FrmAccounts())
        {
            _user = user;
            _accounts = accounts;
        }

        private void SetAccounts()
        {
            IList<Account> accounts = _accountService.SelectAccounts(_user);

            foreach (var acc in accounts)
            {
                acc.Email = acc.Email.GetDecryptString();
                acc.Password = acc.Password.GetDecryptString();
                acc.Website = acc.Website.GetDecryptString();
                acc.Username = acc.Username.GetDecryptString();
                acc.Useremail = acc.Useremail.GetDecryptString();
            }

            _accounts = accounts.ToList();
        }

    }
}
