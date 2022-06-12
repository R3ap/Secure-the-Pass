using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass_Services_Core.Services.Account;
using Secure_The_Pass_Services_Core.Model;
using Secure_The_Pass_Services_Core.Extensions;
using Secure_The_Pass_Services_Core.Services.User;

namespace Secure_The_Pass.UI.AddAccount {
    public class AddAccPresenter : BaseDialogPresenter<IAddAcc> {
        private readonly IAccountService _accountService = new AccountService();
        private readonly IUserService _userService = new UserService();
        private User _user;
        private List<Account> _accounts;
        private Generator _generator = new();
        public AddAccPresenter() : base(new FrmAddAcc()) {
            _user = _userService.GetCurrentUser();
            _accounts = _accountService.SelectAccounts(_user).ToList();
            View.OnAcceptClick = SaveAccount;
            View.AddButtonAction(new ButtonAction() { Action = GenaratPW, Name = "BtnGenaratPW", Text = "Genarat Password" });
            View.AddButtonAction(new ButtonAction() { Action = Clear, Name = "BtnClear", Text = "Clear" });
        }

        private bool Clear() {
            View.Email = "";
            View.Password = "";
            View.Username = "";
            View.Website = "";
            return false;
        }

        private bool SaveAccount() {
            View.ClearErrorProvider();

            if (!ValidateAccount()) {
                return false;
            }

            if (!Uri.IsWellFormedUriString(View.Website, UriKind.Absolute)) {
                View.Website = $"https://{View.Website.ToLower()}";
            }

            Account account = new() {
                Email = View.Email,
                Website = View.Website,
                Username = View.Username,
                Password = View.Password,
                UserGuid = _user.Guid
            };

            _accountService.InsertAccount(account.GetEncryptedAccount());
            _accounts.Add(account);
            View.ClearControls();
            return false;
        }


        private bool ValidateAccount() {
            bool isValid = true;
            if (string.IsNullOrEmpty(View.Email.Trim())) {
                View.SetErrorEmail("This can't be Empty");
                isValid = false;
            }

            if (string.IsNullOrEmpty(View.Password.Trim())) {
                View.SetErrorPassword("This can't be Empty");
                isValid = false;
            }

            if (string.IsNullOrEmpty(View.Website.Trim())) {
                View.SetErrorWebsite("This can't be Empty");
                isValid = false;
            }

            if (string.IsNullOrEmpty(View.Username.Trim())) {
                View.SetErrorUsername("This can't be Empty");
                isValid = false;
            }
            return isValid;
        }

        private bool GenaratPW() {
            View.Password = _generator.GetPW();
            return false;
        }
    }
}
