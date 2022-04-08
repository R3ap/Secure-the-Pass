using Secure_The_Pass_Services_Core.Model;

namespace Secure_The_Pass_Services_Core.Services.AccountService
{
    public interface IAccountService
    {
        /// <summary>
        /// Removes All Accounts.
        /// </summary>
        void CleanAccount(IList<Account> accounts);
        /// <summary>
        /// Get Heighest ID of all Accounts.
        /// </summary>
        /// <returns>the Heighest ID in the Database.</returns>
        int GetIndexOfAccouts();
        /// <summary>
        /// Insert a new <see cref="Account"/> with this <paramref name="account"/> Data. 
        /// </summary>
        /// <param name="account"></param>
        void InsertAccount(Account account);
        /// <summary>
        /// Remove a <see cref="Account"/> with this <paramref name="account"> Data. 
        /// </summary>
        /// <param name="account"></param>
        void RemoveAcc(Account account);
        /// <summary>
        /// Select all Accounts with this <param name="user"></param>
        /// </summary>
        /// <returns>A list of All Accounts with this <paramref name="user"></returns>
        IList<Account> SelectAccounts(User user);
        /// <summary>
        /// Update the Account.
        /// </summary>
        /// <returns>The updated Account.</returns>
        Account UpdateAccount(int ID, string website, string email, string username, string password);
    }
}
