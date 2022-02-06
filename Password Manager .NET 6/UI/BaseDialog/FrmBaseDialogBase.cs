using System.ComponentModel;

namespace Password_Manager_.NET_6.UI.BaseDialog
{
    public abstract partial class FrmBaseDialogBase : Form, IBaseDialogBase
    {
        private const string DEFAULT_TITEL = "baseDialog";
        private enumDialogType _dialogType;
        private readonly Dictionary<string, Button> _buttons = new();

        protected abstract Button BtAccept { get; }
        protected abstract Button BtAbort { get; }
        public virtual enumDialogType DialogType
        {
            get => _dialogType;
            set
            {
                _dialogType = value;
                switch (_dialogType)
                {

                    case enumDialogType.OkAndAbort:
                        BtAccept.Visible = true;
                        BtAccept.Text = "&OK";
                        BtAbort.Visible = true;
                        BtAbort.Text = "&Abort";
                        AcceptButton = BtAccept;
                        CancelButton = BtAbort;
                        break;
                    case enumDialogType.Close:
                        BtAccept.Visible = false;
                        BtAbort.Visible = true;
                        BtAbort.Text = "&Close";
                        AcceptButton = null;
                        CancelButton = BtAbort;
                        break;
                    case enumDialogType.None:
                        BtAccept.Visible = false;
                        BtAbort.Visible = false;
                        AcceptButton = null;
                        break;
                }
            }
        }

        public new enumDialogResult DialogResult
        {
            get
            {
                switch (base.DialogResult)
                {
                    case System.Windows.Forms.DialogResult.OK:
                    case System.Windows.Forms.DialogResult.Retry:
                    case System.Windows.Forms.DialogResult.Yes:
                        return enumDialogResult.OK;
                    case System.Windows.Forms.DialogResult.Cancel:
                    case System.Windows.Forms.DialogResult.No:
                        return enumDialogResult.Cancel;
                    default:
                        return enumDialogResult.Close;
                }
            }
            protected set
            {
                switch (value)
                {
                    case enumDialogResult.OK:
                        base.DialogResult = System.Windows.Forms.DialogResult.OK;
                        break;
                    case enumDialogResult.Cancel:
                        base.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        break;
                    default:
                        base.DialogResult = System.Windows.Forms.DialogResult.Abort;
                        break;
                }
            }
        }

        public new void Show()
        {
            if (Titel == DEFAULT_TITEL)
            {
                MessageBox.Show("The Title has not been set yet!");
            }
            base.Show();
        }
        public new void ShowDialog()
        {
            if (Titel == DEFAULT_TITEL)
            {
                MessageBox.Show("The Title has not been set yet!");
            }
            base.ShowDialog();
        }


        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<bool> OnAcceptClick { get; set; }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<bool> OnCloseClick { get; set; }

        public string Titel { get => Text; set => Text = value; }

        [Description("The Text of the Accept button.")]
        [Category("Appearace")]
        [DefaultValue("&OK")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public string AcceptText
        {
            get => BtAccept.Text;
            set => BtAccept.Text = value;
        }

        [Description("The Text of the Abort button.")]
        [Category("Appearace")]
        [DefaultValue("&Abort")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public string AbortText
        {
            get => BtAbort.Text;
            set => BtAbort.Text = value;
        }

        public Func<Task<bool>> OnAcceptClickAsync { get; set; }
        public Func<Task<bool>> OnCloseClickAsync { get; set; }


        protected FrmBaseDialogBase() : this(enumDialogType.OkAndAbort) { }

        protected FrmBaseDialogBase(enumDialogType enumDialogType)
        {
            InitializeComponent();

            pnlButton.Controls.Add(BtAbort);
            pnlButton.Controls.Add(BtAccept);
            BtAbort.Click += BtAbort_Click;
            BtAccept.Click += BtAccept_Click;
            DialogType = enumDialogType;
            StartPosition = FormStartPosition.CenterParent;

            if (!DesignMode)
            {
                pnlButton.BorderStyle = BorderStyle.None;

                pnlButton.Visible = pnlButton.Controls.Count != 0;
            }

            CancelButton = BtAbort;
        }


        private async void BtAccept_Click(object? sender, EventArgs e)
        {
            if (OnAcceptClickAsync != null)
            {
                if (await OnAcceptClickAsync.Invoke())
                {
                    DialogResult = enumDialogResult.OK;
                }
                return;
            }

            if (OnAcceptClick?.Invoke() ?? true)
            {
                DialogResult = enumDialogResult.OK;
            }
        }

        private void BtAbort_Click(object? sender, EventArgs e)
        {
            Close();
        }

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (DialogResult != enumDialogResult.OK)
            {
                DialogResult = DialogType == enumDialogType.Close ? enumDialogResult.Close : enumDialogResult.Cancel;
                if (OnCloseClickAsync != null && OnCloseClick != null)
                {
                    throw new InvalidOperationException();
                }
                if (OnCloseClickAsync != null)
                {
                    e.Cancel = !await OnCloseClickAsync.Invoke();
                }
                else if (OnCloseClick != null)
                {
                    e.Cancel = !OnCloseClick();
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }


        public void AddButtonAction(ButtonAction buttonAction)
        {
            Button button = new()
            {
                Text = buttonAction.Text,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowOnly,
                MinimumSize = buttonAction.MinimumSize
            };
            button.Click += buttonAction.OnClickHandler;
            button.ForeColor = Color.FromArgb(158, 161, 176);
            button.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            button.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            Point point = _buttons.Any() ? GetButton(_buttons.Last().Key).Location : BtAccept.Location;
            point.X -= 4;
            button.Location = point;
            pnlButton.Width += button.Width;
            pnlButton.Controls.Add(button);
            _buttons.Add(buttonAction.Name ?? buttonAction.GetHashCode().ToString(), button);
        }

        public Button? GetButton(string name)
        {
            return _buttons.ContainsKey(name) ? null : _buttons[name];
        }

        private void pnlButton_ControlAdded(object sender, ControlEventArgs e)
        {
            pnlButton.Visible = true;
        }

        private void pnlButton_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (pnlButton.Controls.Count == 0)
            {
                pnlButton.Visible = false;
            }
        }
    }
}
