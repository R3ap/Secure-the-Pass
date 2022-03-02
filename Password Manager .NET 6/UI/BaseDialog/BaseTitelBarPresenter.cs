using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager_.NET_6.UI.BaseDialog
{
    public class BaseTitelBarPresenter<TView> where TView : IBaseDialogTitelBar
    {
        protected TView View { get; }

        public BaseTitelBarPresenter(TView view)
        {
            View = view;
        }

        public void ShowDialog()
        {
            View.ShowDialog();
        }

        public void Show()
        {
            View.Show();
        }
    }
}
