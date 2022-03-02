using Password_Manager_.NET_6.Properties;
using System.ComponentModel;

namespace Password_Manager_.NET_6.UI.BaseDialog
{
    public partial class FrmBaseDialogTitelBar : FrmBaseDialog, IBaseDialogTitelBar
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private int borderSize = 2;
        private Size formSize;
        private const string DEFAULT_TITEL = "titel";
        private FormBorderStyle _formBorderStyle;
        public FrmBaseDialogTitelBar()
        {
            InitializeComponent();
            Titel = DEFAULT_TITEL;
            Padding = new Padding(borderSize);
            BackColor = Color.FromArgb(46, 51, 73);
            SetPropertiesOfTitel();
            if (!IsSizable)
            {
                FormBorderStyle = FormBorderStyle.None;
            }
        }

        [Description("The Text of the Titel.")]
        [Category("Appearace")]
        [DefaultValue("Titel")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public string Titel { get => lblTitel.Text; set => lblTitel.Text = Text = $"Password Manager | {value}"; }

        [Description("Set MaximizeBox to Visible")]
        [Category("Appearace")]
        [DefaultValue(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public new bool MaximizeBox { get => btnMax.Visible; set => btnMax.Visible = value; }

        [Description("Set MinimizeBox to Visible.")]
        [Category("Appearace")]
        [DefaultValue(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public new bool MinimizeBox { get => BtnMin.Visible; set => BtnMin.Visible = value; }

        [Description("Set Icon to Visible.")]
        [Category("Appearace")]
        [DefaultValue(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public new bool ShowIcon { get => PbIcon.Visible; set => PbIcon.Visible = base.ShowIcon = value; }

        [Description("Set the Sizable Propertie.")]
        [Category("Appearace")]
        [DefaultValue(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public bool IsSizable { get; set; }

        public new virtual FormBorderStyle FormBorderStyle
        {
            get => _formBorderStyle;
            set
            {
                _formBorderStyle = base.FormBorderStyle = value;
                switch (_formBorderStyle)
                {
                    case FormBorderStyle.None:
                        MaximizeBox = false;
                        IsSizable = false;
                        ShowIcon = false;
                        MinimizeBox = false;
                        break;
                    case FormBorderStyle.FixedSingle:
                        MaximizeBox = false;
                        ShowIcon = false;
                        IsSizable = false;
                        MinimizeBox = false;
                        break;
                    case FormBorderStyle.Fixed3D:
                        MaximizeBox = false;
                        ShowIcon = false;
                        IsSizable = false;
                        MinimizeBox = false;
                        break;
                    case FormBorderStyle.FixedDialog:
                        MaximizeBox = false;
                        ShowIcon = false;
                        MinimizeBox = false;
                        IsSizable = false;
                        break;
                    case FormBorderStyle.Sizable:
                        MaximizeBox = true;
                        ShowIcon = true;
                        MinimizeBox = true;
                        IsSizable = true;
                        break;
                    case FormBorderStyle.FixedToolWindow:
                        MaximizeBox = false;
                        ShowIcon = false;
                        MinimizeBox = false;
                        IsSizable = false;
                        break;
                    case FormBorderStyle.SizableToolWindow:
                        MaximizeBox = true;
                        ShowIcon = true;
                        MinimizeBox = true;
                        IsSizable = true;
                        break;
                    default:
                        break;
                }
            }
        }

        public new void Show()
        {
            if (lblTitel.Visible && Titel.ToLower() == DEFAULT_TITEL)
            {
                MessageBox.Show("The Titel is not set yet!", "Set Titel!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            base.Show();
        }

        public new void ShowDialog()
        {
            if (lblTitel.Visible && Titel.ToLower() == DEFAULT_TITEL)
            {
                MessageBox.Show("The Titel is not set yet!", "Set Titel!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            base.ShowDialog();
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
            if (m.Msg == WM_NCHITTEST && IsSizable == true)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal && MaximizeBox)//Resize the form if it is in normal state
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
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1 && IsSizable == true)
            {
                return;
            }
            #endregion

            #region Keep form size when it is minimized and restored
            if (m.Msg == WM_SYSCOMMAND && MinimizeBox == true)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = m.WParam.ToInt32() & 0xFFF0;
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    Size = formSize;
            }
            #endregion

            base.WndProc(ref m);
        }

        private void SetPropertiesOfTitel()
        {
            lblTitel.Text = "Titel";
            lblTitel.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblTitel.ForeColor = Color.FromArgb(200, 200, 200);
            lblTitel.Location = new Point(35, 6);
        }

        private void AdjustForm()
        {
            switch (WindowState)
            {
                case FormWindowState.Normal:
                    Padding = Padding.Top != borderSize ? new Padding(borderSize) : Padding;
                    btnMax.Image = Resources.icons8_maximize_button_16px1;
                    break;
                case FormWindowState.Maximized:
                    Padding = new Padding(8);
                    btnMax.Image = Resources.icons8_restore_down_16px2;
                    break;
            }
        }

        private void TitelBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2 && e.Button == MouseButtons.Left && IsSizable)
            {
                Maximize();
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            Maximize();
        }

        private void Maximize()
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

        private void BtnMin_Click(object sender, EventArgs e)
        {
            formSize = ClientSize;
            WindowState = FormWindowState.Minimized;
        }

        private void FrmBaseDialogSizable_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MaximizeBox && MinimizeBox && ShowIcon)
            {
                Application.Exit();
            }
            else
            {
                Close();
            }
        }
    }
}
