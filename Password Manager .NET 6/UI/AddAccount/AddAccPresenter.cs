using Password_Manager_.NET_6.Model;
using settings = Password_Manager_.NET_6.Properties;
using Password_Manager_.NET_6.UI.BaseDialog;

namespace Password_Manager_.NET_6.UI.AddAccount
{
    public class AddAccPresenter : BaseDialogPresenter<IAddAcc>
    {
        private readonly DatabaseAccess _database = new();
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
            int indexOfAcc = _database.GetIndexOfAccouts();
            _database.InsertAccount(new Account() { 
                ID = indexOfAcc + 1, 
                Email = SecurePasswordHasher.GetEncryptString(View.Email), 
                Website = SecurePasswordHasher.GetEncryptString(View.Website), 
                Username = SecurePasswordHasher.GetEncryptString(View.Username), 
                Password = SecurePasswordHasher.GetEncryptString(View.Password), 
                Useremail = SecurePasswordHasher.GetEncryptString(_user.Email) 
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
            return false;
        }

        private bool GenaratPW()
        {
            View.Password = _generator.GetPW(settings.Settings.Default.PasswordLenght);
            return false;
        }
    }
}
