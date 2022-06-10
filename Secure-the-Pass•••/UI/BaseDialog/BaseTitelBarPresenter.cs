
namespace Secure_The_Pass.UI.BaseDialog {
    public class BaseTitelBarPresenter<TView> where TView : IBaseDialogTitelBar {
        protected TView View { get; }

        public BaseTitelBarPresenter(TView view) {
            View = view;
        }

        public void ShowDialog() {
            View.ShowDialog();
        }

        public void Close() {
            View.Close();
        }

        public void Show() {
            View.Show();
        }
    }
}
