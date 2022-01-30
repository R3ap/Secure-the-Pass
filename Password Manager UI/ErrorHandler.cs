using System.Text;

namespace Password_Manager_.NET_6
{
    public partial class ErrorHandler : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        
        public ErrorHandler()
        {
            InitializeComponent();
        }

        public void ShowDialog(Exception ex)
        {
            StringBuilder sB = new StringBuilder();
            sB.AppendLine("----Message----");
            sB.AppendLine(ex.Message);
            sB.AppendLine();
            sB.AppendLine("----Source----");
            sB.AppendLine(ex.Source);
            sB.AppendLine();
            sB.AppendLine("---TargetSite----");
            sB.AppendLine(ex.TargetSite.ToString());
            sB.AppendLine();
            sB.AppendLine("---Data----");
            sB.AppendLine(ex.Data.ToString());
            sB.AppendLine();
            sB.AppendLine("---StackTrace----");
            sB.AppendLine(ex.StackTrace);
            sB.AppendLine();
            if (ex.InnerException != null)
            {
                sB.AppendLine("----InnerException----");
                sB.AppendLine(ex.InnerException.Message);
                sB.AppendLine();
                sB.AppendLine("----InnerException Source----");
                sB.AppendLine(ex.InnerException.Source);
                sB.AppendLine();
                sB.AppendLine("----InnerException TargetSite----");
                sB.AppendLine(ex.InnerException.TargetSite.ToString());
                sB.AppendLine();
                sB.AppendLine("---InnerException Data----");
                sB.AppendLine(ex.InnerException.Data.ToString());
                sB.AppendLine();
                sB.AppendLine("----InnerException StackTrace----");
                sB.AppendLine(ex.InnerException.StackTrace);
            }
            txtErrorMessage.Text = sB.ToString();
            ShowDialog();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (btnDetails.Text == "Show less")
            {
                btnCopy.Visible = false;
                Height -= 500;
                Width -= 500;
                btnDetails.Text = "More Details";
            }
            else
            {
                btnCopy.Visible = true;
                Height += 500;
                Width += 500;
                btnDetails.Text = "Show less";
            }
            CenterToScreen();
        }

        private void ErrorHandler_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtErrorMessage.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
