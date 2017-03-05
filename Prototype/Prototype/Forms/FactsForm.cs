using OwlDotNetApi;
using Prototype.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype.Forms
{
    public partial class FactsForm : Form
    {
        public FactsForm()
        {
            InitializeComponent();
        }

        public void StandartPosition()
        {
            this.Location = new Point()
            {
                Y = Screen.PrimaryScreen.WorkingArea.Height * 2 / 7,
                X = Screen.PrimaryScreen.WorkingArea.Left
            };
            this.Size = new Size()
            {
                Height = Screen.PrimaryScreen.WorkingArea.Height * 5 / 7,
                Width = Screen.PrimaryScreen.WorkingArea.Width / 2
            };
        }

        private void FactsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void ExtractFacts(string textReview, OwlClass owlClass)
        {
            string owlClassName = OntologyForm.ConvertNameNode(owlClass);
            TreeNode nodeClass = new TreeNode(owlClassName);
            tvFacts.Nodes.Add(nodeClass);
            foreach (OwlEdge owlEdge in owlClass.ParentEdges)
            {
                OwlIndividual owlIndividual = (OwlIndividual)(owlEdge.ParentNode);
                string owlIndividualName = OntologyForm.ConvertNameNode(owlIndividual);
                TreeNode nodeIndividual = new TreeNode(owlIndividualName);
                nodeClass.Nodes.Add(nodeIndividual);
                ExtractFactsFromIndividual(textReview, owlIndividual, nodeIndividual);
                nodeClass.Expand();
            }
        }

        private void ExtractFactsFromIndividual(string textReview, OwlIndividual owlIndividual, TreeNode nodeIndividual)
        {
            if (owlIndividual is OwlIndividual)
            {
                List<string> _keyWords = new List<string>();
                string _script = "";

                foreach (OwlEdge owlAttribute in owlIndividual.ChildEdges)
                {
                    if (OntologyForm.ConvertNameNode(owlAttribute) == "HasKeyWord")
                    {
                        OwlNode Attribute = (OwlNode)(owlAttribute.ChildNode);
                        _keyWords.Add(Attribute.ID);
                    }

                    if (OntologyForm.ConvertNameNode(owlAttribute) == "HasScript")
                    {
                        OwlNode attribute = (OwlNode)(owlAttribute.ChildNode);
                        _script = attribute.ID;
                    }
                }

                if (_script != "")
                {
                    List<string> listFacts = TomitaParser.GetFacts(_script, _keyWords, textReview);
                    foreach (string fact in listFacts)
                        nodeIndividual.Nodes.Add(fact);
                }
            }
        }
        
        private void btnExpandAll_Click_1(object sender, EventArgs e)
        {
            tvFacts.ExpandAll();
        }

        private void btnCollapseAll_Click_1(object sender, EventArgs e)
        {
            tvFacts.CollapseAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tvFacts.Nodes.Clear();
        }
    }
}
