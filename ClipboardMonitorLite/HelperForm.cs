using System.Windows.Forms;

namespace ClipboardMonitorLite
{
    public partial class HelperForm : Form
    {
        public HelperForm()
        {
            InitializeComponent();
            /*
               This Form is being inherited by the ClipChange class
               to detect clipboard change in Windows with user32.
               Inheriting from Main_Form would duplicate 
               the notification icon and most of it's behaviour.
            */
        }
    }
}
