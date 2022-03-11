using Microsoft.EntityFrameworkCore;
using Password_Manager_.NET_6.Extensions;
using Service_Core.Model;
using Services_Core.Context;

namespace Service_Core.Services.AccountService
{
    public class AccountService : IAccountService
    {
        public void CleanAccount(IList<Account> accounts)
        {
            if (accounts.Any())
            {
                using (var db = new PMContext())
                using (var transaction = db.Database.BeginTransaction())
                {
                    db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Account] ON");

                    db.Account.RemoveRange(accounts);
                    db.SaveChanges();

                    db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Account] OFF");
                    transaction.Commit();
                }
            }
        }

        public void RemoveAcc(Account account)
        {
            using (var db = new PMContext())
            using (var transaction = db.Database.BeginTransaction())
            {
                db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Account] ON");

                db.Remove(account);
                db.SaveChanges();

                db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Account] OFF");
                transaction.Commit();
            }
        }

        public Account UpdateAccount(int ID, string website, string email, string username, string password)
        {
            Account account = new();
            using (var db = new PMContext())
            using (var transaction = db.Database.BeginTransaction())
            {
                db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Account] ON");

                account = db.Account.First(x => x.ID == ID);
                account.Email = email;
                account.Website = website;
                account.Username = username;
                account.Password = password;
                db.SaveChanges();

                db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Account] OFF");

                transaction.Commit();
            }
            return account;
        }

        public void InsertAccount(Account account)
        {
            using (var db = new PMContext())
            using (var transaction = db.Database.BeginTransaction())
            {

                db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Account] ON;");

                db.Account.Add(account);
                db.SaveChanges();

                db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Account] OFF;");

                transaction.Commit();
            }
        }

        public int GetIndexOfAccouts()
        {
            int allIndex = 0;
            using (var db = new PMContext())
            {
                if (db.Account.Any())
                {
                    allIndex = db.Account.OrderByDescending(x => x.ID).First().ID;
                }
            }
            return allIndex;
        }

        public List<Account> SelectAccounts(User user)
        {
            List<Account> accounts = new();
            using (var db = new PMContext())
            {
                if (db.Account.Any())
                {
                    if (db.Account.Any(x => x.Useremail == user.Email.GetEncryptString()))
                    {
                        accounts = db.Account.Where(x => x.Useremail == user.Email.GetEncryptString()).ToList();
                    }
                }
            }
            return accounts;
        }
    }
}
