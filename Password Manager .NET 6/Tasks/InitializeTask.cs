using Password_Manager_.NET_6.Model;

namespace Password_Manager_.NET_6.Tasks
{
    public class InizializeTask
    {
        private User _loadUser = new User();
        private readonly DatabaseAccess _databaseAccess = new DatabaseAccess();
        public Task<User> InitializeUser(User user)
        {
            try
            {
                _loadUser = new User()
                {
                    ID = user.ID,
                    Email = SecurePasswordHasher.GetDecryptString(user.Email),
                    Password = SecurePasswordHasher.GetDecryptString(user.Password),
                    Username = SecurePasswordHasher.GetDecryptString(user.Username)
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
                    acc.Email = SecurePasswordHasher.GetDecryptString(acc.Email);
                    acc.Password = SecurePasswordHasher.GetDecryptString(acc.Password);
                    acc.Website = SecurePasswordHasher.GetDecryptString(acc.Website);
                    acc.Username = SecurePasswordHasher.GetDecryptString(acc.Username);
                    acc.Useremail = SecurePasswordHasher.GetDecryptString(acc.Useremail);
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
