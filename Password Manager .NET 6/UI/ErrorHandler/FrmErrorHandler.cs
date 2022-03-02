using Password_Manager_.NET_6.UI.BaseDialog;
using System.Text;

namespace Password_Manager_.NET_6.UI.ErrorHandler
{
    public partial class FrmErrorHandler : FrmBaseDialogTitelBar, IErrorHandler
    {
        public FrmErrorHandler()
        {
            InitializeComponent();
        }

        public void SetMessage(string error)
        {
            TxtMessage.Text = error;
        }
    }
}
