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
        ListBox ListBox;

        public WriteInLog(ListBox LBox)
        {
            ListBox = LBox;
        }

        /// <summary> Выводит сообщение в лог. </summary>
        public void Write(string Message)
        {
            ListBox.Items.Add(Message);
            ListBox.SelectedIndex = ListBox.Items.Count - 1;
            ListBox.SelectedIndex = -1;
        }

        public void Clear()
        {
            ListBox.Items.Clear();
        }
    }
}
