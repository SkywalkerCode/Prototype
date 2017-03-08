using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype.Tools
{
    public class MasterForm : Form
    {
        public void WindowPosition(Point point, Size size)
        {
            WindowState = FormWindowState.Normal;
            Location = point;
            Size = size;
        }

        public void NoClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
