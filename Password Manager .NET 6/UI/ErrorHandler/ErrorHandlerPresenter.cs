using Password_Manager_.NET_6.UI.BaseDialog;
using System.Text;

namespace Password_Manager_.NET_6.UI.ErrorHandler
{
    public class ErrorHandlerPresenter : BaseTitelBarPresenter<IErrorHandler>
    {
        public ErrorHandlerPresenter() : base(new FrmErrorHandler())
        {
            View.AddButtonAction(new ButtonAction() { Action = ShowDetials, Text = "Show More", Name = "BtnShowDetails" });
            View.Titel = "Error Message";
        }

        private bool ShowDetials()
        {
            string buttonText = View.GetButton("BtnShowDetails").Text;
            View.GetButton("BtnShowDetails").Text = buttonText == "Show More" ? "Show Less" : "Show More";
            View.SetSize();
            return false;
        }

        public void SetErrorMessage(Exception ex, string shortText = "")
        {
            StringBuilder sB = new();
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

            View.SetMessage(sB.ToString(), shortText);
        }
    }
}
