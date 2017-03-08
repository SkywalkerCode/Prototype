using OwlDotNetApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary> Используется для заполнения контролов вершинами OWL. </summary>
    public class OwlItem : OwlNode
    {
        public OwlNode owlNode;

        public OwlItem(OwlNode owlNode)
        {
            this.owlNode = owlNode;
        }

        public override string ToString()
        {
            return OntologyForm.ConvertNameNode(owlNode);
        }
    }
}
