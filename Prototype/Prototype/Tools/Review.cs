using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Tools
{
    public class Review
    {
        private string URI;
        private string Text;
        private List<Fact> Fact;

        public Review(string text, string uri)
        {
            Fact = new List<Fact>();
            Text = text;
            URI = uri;
        }

        public void Add(Fact fact)
        {
            Fact.Add(fact);
        }
    }
}
