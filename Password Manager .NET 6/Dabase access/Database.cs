using Password_Manager_.NET_6.Model;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Password_Manager_.NET_6.UI.ErrorHandler;

namespace Password_Manager_.NET_6
{
    public class DatabaseAccess
    {
        public DatabaseAccess()
        {

        }

        public void CleanAccount(List<Account> accounts)
        {
            try
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
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        public bool RemoveUser(User user, List<Account> accounts)
        {
            try
            {
                using (var db = new PMContext())
                using (var transaction = db.Database.BeginTransaction())
                {
                    db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Users] ON");

                    db.Remove(user);
                    db.SaveChanges();

                    db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Users] OFF");
                    transaction.Commit();

                    CleanAccount(accounts);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Error(ex);
                return false;
            }
        }

        public void RemoveAcc(Account account)
        {
            try
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
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        public bool InsertUser(User user)
        {
            try
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
            catch (Exception ex)
            {
                Error(ex);
                return false;
            }
        }

        public void UpdateUser(string password, string email)
        {
            try
            {
                using (var db = new PMContext())
                using (var transaction = db.Database.BeginTransaction())
                {

                    db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Users] ON");

                    User newuser = db.Users.First(x => x.Email == email);
                    newuser.Password = SecurePasswordHasher.GetEncryptString(password);

                    db.SaveChanges();

                    db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Users] OFF");

                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        public List<User> SelectUsers()
        {
            List<User> users = new List<User>();
            try
            {
                using (var db = new PMContext())
                {
                    users = db.Users.ToList();
                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
            return users;
        }

        public bool CheckUser(string email)
        {
            try
            {
                List<User> users = SelectUsers();
                if (users.Any(x => x.Email == SecurePasswordHasher.GetEncryptString(email)))
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Error(ex);
                return false;
            }
        }

        public Account UpdateAccount(int ID, string website, string email, string username, string password)
        {
            Account account = new Account();
            try
            {
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
            }
            catch (Exception ex)
            {
                Error(ex);
            }
            return account;
        }

        public void InsertAccount(Account account)
        {
            try
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
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        public int GetIndexOfAccouts()
        {
            int allIndex = 0;
            try
            {
                using (var db = new PMContext())
                {
                    if (db.Account.Any())
                    {
                        allIndex = db.Account.OrderByDescending(x => x.ID).First().ID;
                    }
                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
            return allIndex;
        }

        public List<Account> SelectAccounts(User user)
        {
            List<Account> accounts = new List<Account>();
            try
            {
                using (var db = new PMContext())
                {
                    if (db.Account.Any())
                    {
                        if (db.Account.Any(x => x.Useremail == SecurePasswordHasher.GetEncryptString(user.Email)))
                        {
                            accounts = db.Account.Where(x => x.Useremail == SecurePasswordHasher.GetEncryptString(user.Email)).ToList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
            return accounts;
        }

        private void Error(Exception ex)
        {
            ErrorHandlerPresenter errorHandler = new();
            errorHandler.ShowDialog();
            errorHandler.SetErrorMessage(ex);
        }

    }
}
