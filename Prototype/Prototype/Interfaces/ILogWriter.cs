using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Interfaces
{
    /// <summary> Используется для вывода сообщений в лог. </summary>
    public interface ILogWriter
    {
        void Write(string Message);

        void Clear();
    }
}
