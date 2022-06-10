namespace Secure_The_Pass.UI.BaseDialog {
    public abstract class BaseDialogPresenter<TView> where TView : IBaseDialogBase {
        protected TView View { get; }

        public BaseDialogPresenter(TView view) {
            View = view;
        }

        public void ShowDialog() {
            View.ShowDialog();
        }

        public void Show() {
            View.Show();
        }
    }
}
