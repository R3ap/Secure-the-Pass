using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass.UI.LogInAndRegister.Login;
using Secure_The_Pass.UI.LogInAndRegister.Register;

namespace Secure_The_Pass.UI.LogInAndRegister.Overview
{
    public class OverviewPresenter : BaseTitelBarPresenter<IOverview>
    {
        private RegisterPresenter _register = new();
        private LogInPresenter _login = new();
        public OverviewPresenter() : base(new FrmOverview())
        {
            View.OnAcceptClick = Login;
            View.SetMainControl = SetMainControl;
            View.AddButtonAction(new ButtonAction() { Action = Register, Text = "&Register", Name = "BtnRegister" });
            View.AcceptText = "Login";
        }

        private void SetMainControl()
        {
            View.Titel = "Login";
            View.SetFormSize(true);
            _login.Show();
            View.AddControl((FrmLogIn)Application.OpenForms[nameof(FrmLogIn)]);
        }

        private bool Login()
        {
            View.Titel = "Login";
            View.SetFormSize(true);
            if (View.ContainsControl((FrmLogIn)Application.OpenForms[nameof(FrmLogIn)]))
            {
                return _login.LogIn();
            }
            else
            {
                _login.Show();
                View.AddControl((FrmLogIn)Application.OpenForms[nameof(FrmLogIn)]);
                return false;
            }
        }

        private bool Register()
        {
            View.Titel = "Register";
            View.SetFormSize(false);
            if (View.ContainsControl((FrmRegister)Application.OpenForms[nameof(FrmRegister)]))
            {
                return _register.Register();
            }
            else
            {
                _register.Show();
                View.AddControl((FrmRegister)Application.OpenForms[nameof(FrmRegister)]);
                return false;
            }
        }
    }
}
