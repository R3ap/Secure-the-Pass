namespace Password_Manager_.NET_6.UI.BaseDialog
{
    public partial class FrmBaseDialog : FrmBaseDialogBase
    {
        protected readonly Button _btAccept = new();
        protected readonly Button _btAbort = new();
        public FrmBaseDialog() : this(enumDialogType.OkAndAbort) { }
        public FrmBaseDialog(enumDialogType dialogType) : base(dialogType)
        {
            InitializeComponent();
        }

        protected override Button BtAccept => _btAccept;

        protected override Button BtAbort => _btAbort;
    }
}
