using OwlDotNetApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary> Используется для заполнения контролов вершинами OWL. </summary>
    public class OwlClassItem : OwlNode
    {
        public OwlNode owlNode;

        public OwlClassItem(OwlNode owlNode)
        {
            this.owlNode = owlNode;
        }

        public override string ToString()
        {
            return OntologyForm.ConvertNameNode(owlNode);
        }
    }
}
