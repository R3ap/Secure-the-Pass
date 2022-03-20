using Password_Manager_.NET_6.UI.BaseDialog;
using Password_Manager_.NET_6.UI.LogInAndRegister.Overview;

namespace Password_Manager_.NET_6.UI.LogIn
{
    public partial class FrmOverview : FrmBaseDialogTitelBar, IOverview
    {
        public Action SetMainControl { get; set; }
        private Size DefaultLoginSize = new(570, 261);
        private Size DefaultRegisterSize = new(570, 310);

        public FrmOverview()
        {
            InitializeComponent();
        }

        public void SetFormSize(bool IsLogin)
        {
            Size =  IsLogin? DefaultLoginSize : DefaultRegisterSize;
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            PnlContent.Controls.Clear();
            SetMainControl?.Invoke();
        }
    }
}
