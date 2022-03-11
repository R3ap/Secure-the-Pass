using Password_Manager_.NET_6.Extensions;
using Service_Core
using Password_Manager_.NET_6.Model;

namespace Password_Manager_.NET_6.Tasks
{
    public class InizializeTask
    {
        private User _loadUser = new();
        private readonly IUserServices _databaseAccess = new();
        public Task<User> InitializeUser(User user)
        {
            try
            {
                _loadUser = new User()
                {
                    ID = user.ID,
                    Email = user.Email.GetDecryptString(),
                    Password = user.Password.GetDecryptString(),
                    Username = user.Username.GetDecryptString()
                };

                return Task.FromResult(_loadUser);

            }
            catch (Exception)
            {
                return Task.FromResult(_loadUser);
            }
        }

        public Task<List<Account>> InitializeAccounts()
        {
            List<Account> accounts;
            try
            {
                accounts = _databaseAccess.SelectAccounts(_loadUser);

                foreach (var acc in accounts)
                {
                    acc.Email = acc.Email.GetDecryptString();
                    acc.Password = acc.Password.GetDecryptString();
                    acc.Website = acc.Website.GetDecryptString();
                    acc.Username = acc.Username.GetDecryptString();
                    acc.Useremail = acc.Useremail.GetDecryptString();
                }
                return Task.FromResult(accounts);

            }
            catch (Exception)
            {
                accounts = null;
                return Task.FromResult(accounts);
            }
        }
    }
}
