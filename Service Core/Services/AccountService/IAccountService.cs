using Password_Manager_.NET_6.Model;

namespace Service_Core.Services.AccountService
{
    public interface IAccountServices
    {
        void CleanAccount(IList<Account> accounts);
        int GetIndexOfAccouts();
        void InsertAccount(Account account);
        void RemoveAcc(Account account);
        List<Account> SelectAccounts(User user);
        Account UpdateAccount(int ID, string website, string email, string username, string password);
    }
}
