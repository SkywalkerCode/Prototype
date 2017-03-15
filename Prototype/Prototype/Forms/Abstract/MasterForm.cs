using System.Windows.Forms;

namespace Prototype.Tools
{
    public class MasterForm : Form
    {
        public void NoClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
