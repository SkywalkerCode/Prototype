using Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public class WriteInLog : ILogWriter
    {
        ListBox listBox;

        public WriteInLog(ListBox LBox)
        {
            listBox = LBox;
        }

        /// <summary> Выводит сообщение в лог. </summary>
        public void Write(string Message)
        {
            listBox.Items.Add(Message);
            listBox.SelectedIndex = listBox.Items.Count - 1;
            listBox.SelectedIndex = -1;
        }
    }
}
