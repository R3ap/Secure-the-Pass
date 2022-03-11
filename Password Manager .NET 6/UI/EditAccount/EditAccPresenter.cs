using Password_Manager_.NET_6.Extensions;
using Password_Manager_.NET_6.UI.BaseDialog;
using Service_Core.Model;

namespace Password_Manager_.NET_6.UI.EditAccount
{
    public class EditAccPresenter : BaseTitelBarPresenter<IEditAcc>
    {
        private Account _account;
        private DatabaseAccess _database = new DatabaseAccess();
        private Generator _generator = new Generator();
        public event Action UpdateAcc;
        public EditAccPresenter(Account account) : base(new FrmEditAcc())
        {
            _account = account;
            View.AddButtonAction(new ButtonAction() { Action = GeneratePW, Name = "BtnGeneratePW", Text = "Generate Password" });
            View.AddButtonAction(new ButtonAction() { Action = DeleteAcc, Name = "BtnDeleteAcc", Text = "Delete Account" });
            View.OnAcceptClick = SaveAccount;
            View.Website = _account.Website;
            View.Password = _account.Password;
            View.Username= _account.Username;
            View.Email = _account.Email;
        }

        private bool DeleteAcc()
        {
            _database.RemoveAcc(_account);
            UpdateAcc?.Invoke();
            return true;
        }

        private bool SaveAccount()
        {
            _database.UpdateAccount(_account.ID,
                                    View.Website.GetEncryptString(),
                                    View.Email.GetEncryptString(),
                                    View.Username.GetEncryptString(),
                                    View.Password.GetEncryptString());
            UpdateAcc?.Invoke();
            return true;
        }

        private bool GeneratePW()
        {
            View.Password = _generator.GetPW();
            return false;
        }
    }
}
