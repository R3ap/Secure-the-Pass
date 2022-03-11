using Password_Manager_.NET_6.Extensions;
using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.UI.BaseDialog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager_.NET_6.UI.Accounts
{
    public class AccountsPresenter : BaseDialogPresenter<IAccounts>
    {
        private User _user;
        private List<Account> _accounts;
        public event Action<List<Account>> SetnewListAcc;
        private readonly DatabaseAccess _db = new();
        public AccountsPresenter(User user, ref List<Account> accounts) : base(new FrmAccounts())
        {
            _user = user;
            _accounts = accounts;
        }

        private void SetAccounts()
        {
            List<Account> accounts = _db.SelectAccounts(_user);

            foreach (var acc in accounts)
            {
                acc.Email = acc.Email.GetDecryptString();
                acc.Password = acc.Password.GetDecryptString();
                acc.Website = acc.Website.GetDecryptString();
                acc.Username = acc.Username.GetDecryptString();
                acc.Useremail = acc.Useremail.GetDecryptString();
            }

            _accounts = accounts;
        }

    }
}
