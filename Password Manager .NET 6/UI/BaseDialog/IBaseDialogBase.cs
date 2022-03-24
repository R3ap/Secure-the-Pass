namespace Secure_The_Pass.UI.BaseDialog
{
    public interface IBaseDialogBase
    {
        enumDialogType DialogType { get; set; }
        enumDialogResult DialogResult { get; }

        void AddControl(Control control);
        bool ContainsControl(Control form);

        void Show();
        void ShowDialog();

        void AddButtonAction(ButtonAction buttonAction);
        Button? GetButton(string name);

        Func<bool> OnAcceptClick { get; set; }
        Func<Task<bool>> OnAcceptClickAsync { get; set; }

        Func<bool> OnCloseClick { get; set; }
        Func<Task<bool>> OnCloseClickAsync { get; set; }

        string AcceptText { get; set; }
        string AbortText { get; set; }
    }

    public class ButtonAction
    {
        public Func<bool> Action { get; set; }
        public Func<Task<bool>> ActionAsync { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        public enumDialogResult DialogResult { get; private set; }
        public Size MinimumSize { get; set; }
        internal async void OnClickHandler(object sender, EventArgs e)
        {
            if (Action != null && ActionAsync != null)
            {
                throw new InvalidOperationException();
            }

            if (ActionAsync != null)
            {
                if (await ActionAsync.Invoke())
                {
                    DialogResult = enumDialogResult.OK;
                }
                return;
            }

            if (Action?.Invoke() ?? true)
            {
                DialogResult = enumDialogResult.OK;
            }
        }
    }
}
