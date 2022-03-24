using Password_Manager_.NET_6;
using Secure_The_Pass;
using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass_Services_Core.Services.AccountService;
using Secure_The_Pass_Services_Core.Model;
using Secure_The_Pass_Services_Core.Extensions;

namespace Secure_The_Pass.UI.AddAccount
{
    public class AddAccPresenter : BaseDialogPresenter<IAddAcc>
    {
        private readonly IAccountService _userService = new AccountService();
        private User _user;
        private List<Account> _accounts;
        private Generator _generator = new();
        public AddAccPresenter(ref User user, ref List<Account> accounts) : base(new FrmAddAcc())
        {
            _user = user;
            _accounts = accounts;
            View.OnAcceptClick = SaveAccount;
            View.AddButtonAction(new ButtonAction() { Action = GenaratPW, Name = "BtnGenaratPW", Text = "Genarat Password" });
        }

        private bool SaveAccount()
        {
            View.ClearErrorProvider();

            if (!ValidateAccount())
            {
                return false;
            }

            int indexOfAcc = _userService.GetIndexOfAccouts();
            _userService.InsertAccount(new Account()
            {
                ID = indexOfAcc + 1,
                Email = View.Email.GetEncryptString(),
                Website = View.Website.GetEncryptString(),
                Username = View.Username.GetEncryptString(),
                Password = View.Password.GetEncryptString(),
                Useremail = _user.Email.GetEncryptString()
            });
            Account account = new()
            {
                ID = indexOfAcc + 1,
                Email = View.Email,
                Website = View.Website,
                Username = View.Username,
                Password = View.Password,
                Useremail = _user.Email
            };
            _accounts.Add(account);
            View.ClearControls();
            return false;
        }


        private bool ValidateAccount()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(View.Email))
            {
                View.SetErrorEmail("This can't be Empty");
                isValid = false;
            }

            if (string.IsNullOrEmpty(View.Password))
            {
                View.SetErrorPassword("This can't be Empty");
                isValid = false;
            }

            if (string.IsNullOrEmpty(View.Website))
            {
                View.SetErrorWebsite("This can't be Empty");
                isValid = false;
            }

            if (string.IsNullOrEmpty(View.Username))
            {
                View.SetErrorUsername("This can't be Empty");
                isValid = false;
            }
            return isValid;
        }

        private bool GenaratPW()
        {
            View.Password = _generator.GetPW();
            return false;
        }
    }
}
