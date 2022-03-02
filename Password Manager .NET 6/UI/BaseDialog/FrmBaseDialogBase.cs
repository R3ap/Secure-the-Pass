using System.ComponentModel;

namespace Password_Manager_.NET_6.UI.BaseDialog
{
    public abstract partial class FrmBaseDialogBase : Form, IBaseDialogBase
    {
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
                        PnlActions.Visible = true;
                        BtAbort.Text = "&Abort";
                        AcceptButton = BtAccept;
                        CancelButton = BtAbort;
                        break;
                    case enumDialogType.Close:
                        BtAccept.Visible = false;
                        BtAbort.Visible = true;
                        BtAbort.Text = "&Close";
                        AcceptButton = null;
                        PnlActions.Visible = true;
                        CancelButton = BtAbort;
                        break;
                    case enumDialogType.Ok:
                        BtAccept.Visible = true;
                        BtAbort.Visible = false;
                        BtAbort.Text = "&OK";
                        AcceptButton = BtAccept;
                        PnlActions.Visible = true;
                        CancelButton = null;
                        break;
                    case enumDialogType.None:
                        BtAccept.Visible = false;
                        BtAbort.Visible = false;
                        PnlActions.Visible = false;
                        AcceptButton = null;
                        CancelButton = null;
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
            base.Show();
        }
        public new void ShowDialog()
        {
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

            PnlActionsBase.Controls.Add(BtAbort);
            PnlActionsBase.Controls.Add(BtAccept);
            BtAbort.Click += BtAbort_Click;
            BtAccept.Click += BtAccept_Click;
            BtAbort.AutoSize = true;
            BtAccept.AutoSize = true;
            DialogType = enumDialogType;
            StartPosition = FormStartPosition.CenterParent;

            if (!DesignMode)
            {
                PnlActions.BorderStyle = BorderStyle.None;

                PnlActions.Visible = PnlActions.Controls.Count != 0;
            }

            CancelButton = BtAbort;
        }

        public bool ContainsControl(Control control)
        {
            return PnlContent.Controls.Contains(control);
        }

        public void AddControl(Control control)
        {
            PnlContent.Controls.Clear();
            PnlContent.Controls.Add(control);
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
                MinimumSize = buttonAction.MinimumSize,
            };
            button.Click += buttonAction.OnClickHandler;
            button.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            button.BackColor = BtAccept.BackColor;
            button.ForeColor = BtAccept.ForeColor;
            PnlActionsExtension.Controls.Add(button);
            _buttons.Add(buttonAction.Name ?? buttonAction.GetHashCode().ToString(), button);
        }

        public Button? GetButton(string name)
        {
            return _buttons.ContainsKey(name) ? null : _buttons[name];
        }

        private void PnlActionsExtension_ControlAdded(object sender, ControlEventArgs e)
        {
            PnlActionsExtension.Visible = true;
        }

        private void PnlActionsExtension_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (PnlActionsExtension.Controls.Count == 0)
            {
                PnlActionsExtension.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
