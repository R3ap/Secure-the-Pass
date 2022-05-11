using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.ErrorHandler
{
    public partial class FrmErrorHandler : FrmBaseDialogTitelBar, IErrorHandler
    {
        public FrmErrorHandler()
        {
            InitializeComponent();
        }

        public void SetMessage(string error, string shortText)
        {
            TxtMessage.Text = error;
            LblShortDescription.Text = shortText;
        }

        public void SetSize()
        {
            Size = Size == new Size(855, 561) ? new Size(661, 196) : new Size(855, 561);
            CenterToParent();
        }

        private void FrmErrorHandler_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
