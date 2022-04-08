using Secure_The_Pass_Services_Core.Model;

namespace Secure_The_Pass_Services_Core.Services.UserServices
{
    public interface IUserService
    {
        /// <summary>
        /// Check for a User with the same <paramref name="email"/>.
        /// </summary>
        /// <returns>True if the user exists with the same email, false otherwise.</returns>
        bool CheckUser(string email);
        /// <summary>
        /// Insert a new <see cref="User"/>.
        /// </summary>
        /// <returns>True if the insertion into the database was successful, false otherwise.</returns>
        bool InsertUser(User user);
        /// <summary>
        /// Remove a user with all accounts.
        /// </summary>
        /// <param name="user">The current User.</param>
        /// <param name="accounts">A list of all Accounts of the current User.</param>
        /// <returns>True if the database removal was successful, false otherwise.</returns>
        bool RemoveUser(User user, IList<Account> accounts);
        /// <summary>
        /// Select All Users in the Database.
        /// </summary>
        /// <returns>A List of <see cref="User"/></returns>
        IList<User> SelectUsers();
        /// <summary>
        /// Update the User with same <paramref name="email"/> and <paramref name="password"/>.
        /// </summary>
        void UpdateUser(string password, string email);
    }
}
