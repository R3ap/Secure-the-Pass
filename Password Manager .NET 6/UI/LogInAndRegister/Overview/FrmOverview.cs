using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass.UI.LogInAndRegister.Overview;

namespace Secure_The_Pass.UI.LogInAndRegister.Overview
{
    public partial class FrmOverview : FrmBaseDialogTitelBar, IOverview
    {
        public Action SetMainControl { get; set; }
        private Size DefaultLoginSize = new(570, 261);
        private Size DefaultRegisterSize = new(570, 320);

        public FrmOverview()
        {
            InitializeComponent();
        }

        public void SetFormSize(bool IsLogin)
        {
            Size =  IsLogin ? DefaultLoginSize : DefaultRegisterSize;
            CenterToScreen();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            SetMainControl?.Invoke();
        }
    }
}
