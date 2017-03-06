using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Tools
{
    public class Fact
    {
        private string Text { get; set; }
        private string Query { get; set; }

        public Fact(string text, string query)
        {
            Text = text;
            Query = query;
        }
    }
}
