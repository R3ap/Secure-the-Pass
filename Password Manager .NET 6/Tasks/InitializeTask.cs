﻿using Secure_The_Pass_Services_Core.Extensions;
using Secure_The_Pass_Services_Core.Model;
using Secure_The_Pass_Services_Core.Services.AccountService;

namespace Secure_The_Pass.Tasks
{
    public class InizializeTask
    {
        private User _loadUser = new();
        private readonly IAccountService _accountServices = new AccountService();
        public Task<User> InitializeUser(User user)
        {
            try
            {
                _loadUser = new User()
                {
                    Guid = user.Guid,
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

        public Task<IList<Account>> InitializeAccounts()
        {
            IList<Account> accounts;
            try
            {
                accounts = _accountServices.SelectAccounts(_loadUser);

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
