using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.Tasks;
using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_.NET_6.UI.LogIn;
using Password_Manager_.NET_6.UI.Menü;

namespace Password_Manager_.NET_6.UI.LogInAndRegister.Register
{
    public class RegisterPresenter : BaseDialogPresenter<IRegister>
    {
        private User _user;
        private List<Account> _accounts;
        private readonly DatabaseAccess _database = new();
        public RegisterPresenter() : base(new FrmRegister())
        {
            View.Register = Register;
        }

        public bool Register()
        {
            View.ClearError();
            if (!_database.CheckUser(View.Email))
            {
                View.SetErrorEmail("The Email Exist");
                return false;
            }
            else if (!string.IsNullOrEmpty(View.Email) && !string.IsNullOrEmpty(View.Password) && !string.IsNullOrEmpty(View.Username) && !string.IsNullOrEmpty(View.PasswordConfirm))
            {
                if (View.Password != View.PasswordConfirm)
                {
                    View.SetErrorPasswordConfirm("The Password is not Equal");
                    return false;
                }
                else
                {
                    User user = new() { ID = _database
                                            .SelectUsers()
                                            .OrderByDescending(x => x.ID)
                                            .First().ID + 1, Email = View.Email.GetEncryptString(), Username = View.Username.GetEncryptString(), Password = View.Password.GetEncryptString() };
                    bool IsTaskSuccess = GetTaskResult(user);
                    if (IsTaskSuccess)
                    {
                        bool error = _database.InsertUser(user);
                        if (error)
                        {
                            Application.OpenForms[nameof(FrmOverview)].Hide();
                            Application.OpenForms[nameof(FrmOverview)].Close();
                            MenüPresenter frmMenü = new(ref _user, ref _accounts);
                            frmMenü.ShowDialog();
                            return true;
                        }
                    }
                }
            }
            else
            {
                string errortext = "This can't be empty!";

                if (string.IsNullOrEmpty(View.Email))
                {
                    View.SetErrorEmail(errortext);
                }

                if (string.IsNullOrEmpty(View.Password))
                {
                    View.SetErrorPassword(errortext);
                }

                if (string.IsNullOrEmpty(View.Username))
                {
                    View.SetErrorUsername(errortext);
                }

                if (string.IsNullOrEmpty(View.PasswordConfirm))
                {
                    View.SetErrorPasswordConfirm(errortext);
                }
            }
            return false;
        }

        private bool GetTaskResult(User user)
        {
            InizializeTask inizializeTask = new InizializeTask();
            _user = inizializeTask.InitializeUser(user).Result;
            _accounts = inizializeTask.InitializeAccounts().Result;
            DialogResult dialogResult = DialogResult.None;
            if (_user == null)
            {
                dialogResult = MessageBox.Show("This Task Initialize User", "Task Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (_accounts == null)
            {
                dialogResult = MessageBox.Show("This Task Initialize Accounts", "Task Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dialogResult == DialogResult.OK)
            {
                return false;
            }

            return true;
        }
    }
}
