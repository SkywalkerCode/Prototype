using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Tools
{
    public class Fact
    {
        private string text;
        private string table;

        public string Text
        {
            get
            {
                return text;
            }
        }

        public string Table
        {
            get
            {
                return table;
            }
        }

        public Fact(string text, string table)
        {
            this.text = text;
            this.table = table;
        }
    }
}
