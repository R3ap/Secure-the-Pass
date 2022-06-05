using System.ComponentModel;
using System.Windows.Forms.Design;

namespace Secure_The_Pass.UI.Controls
{
    [ToolboxItem(false)]
    [Designer(typeof(ParentControlDesigner))]
    public class DerivableFlowLayoutPanel : FlowLayoutPanel
    {
    }
}
