using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass_Services_Core.Extensions;
using Secure_The_Pass_Services_Core.Model;
using Secure_The_Pass_Services_Core.Services.AccountService;

namespace Secure_The_Pass.UI.EditAccount
{
    public class EditAccPresenter : BaseTitelBarPresenter<IEditAcc>
    {
        private Account _account;
        private IAccountService _accountService = new AccountService();
        private Generator _generator = new();
        public event Action<Account> UpdateAcc;
        public event Action RemoveAcc;
        public EditAccPresenter(Account account) : base(new FrmEditAcc())
        {
            _account = account;
            View.AddButtonAction(new ButtonAction() { Action = GeneratePW, Name = "BtnGeneratePW", Text = "Generate Password" });
            View.AddButtonAction(new ButtonAction() { Action = DeleteAcc, Name = "BtnDeleteAcc", Text = "Delete Account" });
            View.OnAcceptClick = SaveAccount;
            View.Website = _account.Website;
            View.Password = _account.Password;
            View.Username = _account.Username;
            View.Email = _account.Email;
            View.AcceptText = "&Save";
        }

        private bool DeleteAcc()
        {
            _accountService.RemoveAcc(_account);
            RemoveAcc?.Invoke();
            Close();
            return true;
        }

        private bool SaveAccount()
        {
            _accountService.UpdateAccount(_account.Guid,
                                                     View.Website.GetEncryptString(),
                                                     View.Email.GetEncryptString(),
                                                     View.Username.GetEncryptString(),
                                                     View.Password.GetEncryptString());
            _account.Email = View.Email;
            _account.Username = View.Username;
            _account.Website = View.Website;
            _account.Password = View.Password;
            UpdateAcc?.Invoke(_account);
            return true;
        }

        private bool GeneratePW()
        {
            View.Password = _generator.GetPW();
            return false;
        }
    }
}
