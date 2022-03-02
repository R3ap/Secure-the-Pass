using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_.NET_6.UI.LogIn;
using Password_Manager_.NET_6.UI.LogInAndRegister.Login;

namespace Password_Manager_.NET_6.UI.LogInAndRegister.Overview
{
    public class OverviewPresenter
    {
        private FrmRegister _register = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private LogInPresenter _login = new();
        private IOverview _view = new FrmOverview();
        public OverviewPresenter()
        {
            _view.OnAcceptClick = Login;
            _view.SetMainControl = SetMainControl;
            _view.AddButtonAction(new ButtonAction() { Action = Register, Text = "&Register", Name = "BtnRegister" });
        }

        private void SetMainControl()
        {
            _view.Titel = "Login";
            _view.SetFormSize(true);
            _login.Show();
            _view.AddControl((FrmLogIn)Application.OpenForms[nameof(FrmLogIn)]);
        }

        private bool Login()
        {
            _view.Titel = "Login";
            _view.SetFormSize(true);
            if (_view.ContainsControl((FrmLogIn)Application.OpenForms[nameof(FrmLogIn)]))
            {
                return _login.LogIn();
            }
            else
            {
                _login.Show();
                _view.AddControl((FrmLogIn)Application.OpenForms[nameof(FrmLogIn)]);
                return false;
            }
        }

        public void ShowDialog()
        {
            _view.ShowDialog();
        }

        private void Register()
        {
            _view.Titel = "Register";
            _view.SetFormSize(false);
            if (_view.ContainsControl(_register))
            {
                _register.Register();
            }
            else
            {
                _view.AddControl(_register);
                _register.Show();
            }
        }
    }
}
