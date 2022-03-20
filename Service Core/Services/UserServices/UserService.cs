using Microsoft.EntityFrameworkCore;
using Password_Manager_Services_Core.Extensions;
using Password_Manager_Services_Core.Model;
using Password_Manager_Services_Core.Services.AccountService;
using Password_Manager_Services_Core.Context;

namespace Password_Manager_Services_Core.Services.UserServices
{
    public class UserService : IUserService
    {
        private IAccountService _userService = new AccountService.AccountService();
        public bool RemoveUser(User user, IList<Account> accounts)
        {
            using (var db = new PMContext())
            using (var transaction = db.Database.BeginTransaction())
            {
                db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Users] ON");

                db.Remove(user);
                db.SaveChanges();

                db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Users] OFF");
                transaction.Commit();

                _userService.CleanAccount(accounts);
                return true;
            }
        }

        public bool InsertUser(User user)
        {
            if (CheckUser(user.Email))
            {
                using (var db = new PMContext())
                using (var transaction = db.Database.BeginTransaction())
                {
                    db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Users] ON");

                    db.Users.Add(user);
                    db.SaveChanges();

                    db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Users] OFF");
                    transaction.Commit();
                }
            }
            return true;
        }

        public void UpdateUser(string password, string email)
        {
            using (var db = new PMContext())
            using (var transaction = db.Database.BeginTransaction())
            {

                db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Users] ON");

                User newuser = db.Users.First(x => x.Email == email);
                newuser.Password = password.GetEncryptString();

                db.SaveChanges();

                db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Users] OFF");

                transaction.Commit();
            }
        }

        public IList<User> SelectUsers()
        {
            IList<User> users = new List<User>();
            using (var db = new PMContext())
            {
                users = db.Users.ToList();
            }
            return users;
        }

        public bool CheckUser(string email)
        {
            IList<User> users = SelectUsers();
            if (users.Any(x => x.Email == email.GetEncryptString()))
            {
                return false;
            }
            return true;
        }

    }
}
