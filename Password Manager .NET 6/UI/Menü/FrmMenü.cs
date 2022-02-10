using Password_Manager_.NET_6.Model;
using Password_Manager_.NET_6.Properties;
using Password_Manager_.NET_6.UI.BaseDialog;

namespace Password_Manager_.NET_6
{
    public partial class FrmMenü : FrmBaseDialog
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private User _user;
        private List<Account> _accounts;
        private int borderSize = 1;
        private Size formSize;
        public FrmMenü(User user, List<Account> accounts)
        {
            InitializeComponent();
            _user = user;
            _accounts = accounts;
            Padding = new Padding(borderSize);
            BackColor = Color.FromArgb(46, 51, 73);
        }
        private void FrmMenü_Load(object sender, EventArgs e)
        {
            ShowDashbord();
            lblUsername.Text = _user.Username;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashbord();
        }

        private void Error(Exception ex)
        {
            ErrorHandler error = new ErrorHandler();
            error.ShowDialog(ex);
        }

        private void ShowDashbord()
        {
            try
            {
                pnlNav.Height = btnAccounts.Height;
                pnlNav.Top = btnAccounts.Top;
                pnlNav.Left = btnAccounts.Left;
                pnlNav.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                lblTitle.Text = "Accounts";
                this.pnlFormload.Controls.Clear();
                FrmAccounts frmDashboard = new(_user, _accounts) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, Name = "frmDashboard" };
                frmDashboard.Show();
                frmDashboard = (FrmAccounts)Application.OpenForms["frmDashboard"];
                frmDashboard.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormload.Controls.Add(frmDashboard);
                frmDashboard.SetnewListAcc += SetnewListAcc;
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void SetnewListAcc(List<Account> accounts)
        {
            _accounts = accounts;
        }

        public Screen GetScreen()
        {
            return Screen.FromControl(this);
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            try
            {
                pnlNav.Height = btnNewAcc.Height;
                pnlNav.Top = btnNewAcc.Top;
                pnlNav.Left = btnNewAcc.Left;
                pnlNav.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                lblTitle.Text = "Add Account";
                this.pnlFormload.Controls.Clear();
                FrmAddAcc frmAddAcc = new(_user, _accounts) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmAddAcc.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormload.Controls.Add(frmAddAcc);
                frmAddAcc.AddAccount += AddAccount;
                frmAddAcc.Show();

            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                pnlNav.Height = btnSettings.Height;
                pnlNav.Top = btnSettings.Top;
                pnlNav.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

                lblTitle.Text = "Settings";
                this.pnlFormload.Controls.Clear();
                FrmSettings frmSettings = new(_user, _accounts) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmSettings.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormload.Controls.Add(frmSettings);
                frmSettings.IsRemoved += UserRemoved;
                frmSettings.AccountClean += AccountClean;
                frmSettings.LogOut += OnLogOut;
                frmSettings.Show();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void OnLogOut()
        {
            Hide();
            Close();
        }

        public void AccountClean(List<Account> accounts)
        {
            _accounts = accounts;
        }

        public void UserRemoved()
        {
            Close();
        }

        private void FrmMenü_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                formSize = ClientSize;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                Size = formSize;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            formSize = ClientSize;
            WindowState = FormWindowState.Minimized;
        }

        private void FrmMenü_SizeChanged(object sender, EventArgs e)
        {

        }

        private void PnlTitelBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            #region Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            #endregion

            #region Keep form size when it is minimized and restored
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            #endregion

            base.WndProc(ref m);
        }

        private void FrmMenü_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (WindowState)
            {
                case FormWindowState.Normal:
                    if (Padding.Top != borderSize)
                    {
                        Padding = new Padding(borderSize);
                    }
                    btnMax.Image = Resources.icons8_maximize_button_16px1;
                    break;
                case FormWindowState.Minimized:
                    break;
                case FormWindowState.Maximized:
                    Padding = new Padding(8, 8, 8, 8);
                    btnMax.Image = Resources.icons8_restore_down_16px2;
                    break;
                default:
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
