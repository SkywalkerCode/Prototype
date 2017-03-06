using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Tools
{
    public class Review
    {
        private string Uri;
        private string text;
        private List<Fact> facts;

        public string URI
        {
            get
            {
                return Uri;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }
        }

        public List<Fact> Facts
        {
            get
            {
                return facts;
            }
        }

        public Review(string text, string uri)
        {
            facts = new List<Fact>();
            this.text = text;
            this.Uri = uri;
        }

        public void Add(Fact fact)
        {
            this.facts.Add(fact);
        }
    }
}
