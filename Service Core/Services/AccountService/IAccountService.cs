using Password_Manager_Services_Core.Model;

namespace Password_Manager_Services_Core.Services.AccountService
{
    public interface IAccountService
    {
        void CleanAccount(IList<Account> accounts);
        int GetIndexOfAccouts();
        void InsertAccount(Account account);
        void RemoveAcc(Account account);
        IList<Account> SelectAccounts(User user);
        Account UpdateAccount(int ID, string website, string email, string username, string password);
    }
}
