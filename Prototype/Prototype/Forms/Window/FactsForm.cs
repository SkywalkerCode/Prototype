using OwlDotNetApi;
using Prototype.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace Prototype.Forms
{
    public partial class FactsForm : MasterForm
    {
        private List<Review> reviews;

        public List<Review> Reviews
        {
            get
            {
                return reviews;
            }
        }

        public FactsForm()
        {
            InitializeComponent();
            reviews = new List<Review>();
        }

        public void ExtractFacts(string textReview, string URI, OwlClass owlClass)
        {
            Review review = new Review(textReview, URI);
            reviews.Add(review);
            string owlClassName = OntologyForm.ConvertNameNode(owlClass);
            TreeNode nodeClass = new TreeNode(owlClassName + " " + (tvFacts.Nodes.Count + 1).ToString() + ": " + URI);
            tvFacts.Nodes.Add(nodeClass);
            foreach (OwlEdge owlEdge in owlClass.ParentEdges)
            {
                OwlIndividual owlIndividual = (OwlIndividual)(owlEdge.ParentNode);
                string owlIndividualName = OntologyForm.ConvertNameNode(owlIndividual);
                TreeNode nodeIndividual = new TreeNode(owlIndividualName);
                try
                {
                    ExtractFactsFromIndividual(textReview, owlIndividual, nodeIndividual, review);
                    nodeClass.Nodes.Add(nodeIndividual);
                }
                catch (Exception exception)
                {
                    nodeClass.Nodes.Add(owlIndividualName + ": " + exception.Message);
                }
                nodeClass.Expand();
            }
        }

        private void ExtractFactsFromIndividual(string textReview, OwlIndividual owlIndividual, TreeNode nodeIndividual, Review review)
        {
            if (owlIndividual is OwlIndividual)
            {
                List<string> keyWords = new List<string>();
                string script = "";
                string table = "";
                foreach (OwlEdge owlAttribute in owlIndividual.ChildEdges)
                {
                    if (OntologyForm.ConvertNameNode(owlAttribute) == "HasKeyWord")
                    {
                        OwlNode Attribute = (OwlNode)(owlAttribute.ChildNode);
                        keyWords.Add(Attribute.ID);
                    }
                    if (OntologyForm.ConvertNameNode(owlAttribute) == "HasScript")
                    {
                        OwlNode attribute = (OwlNode)(owlAttribute.ChildNode);
                        script = attribute.ID;
                    }
                    if (OntologyForm.ConvertNameNode(owlAttribute) == "HasTable")
                    {
                        OwlNode attribute = (OwlNode)(owlAttribute.ChildNode);
                        table = attribute.ID;
                    }
                }
                foreach (string fact in GetFacts(script, keyWords, textReview))
                {
                    review.Add(new Fact(fact, table));
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
            reviews.Clear();
        }

        private static List<string> GetFacts(string script, List<string> keyWords, string text)
        {
            if (script == "")
            {
                throw new Exception("Паттерн пуст!");
            }
            if (keyWords.Count == 0)
            {
                throw new Exception("Ключевые слова отсутствуют!");
            }
            string entity = "#encoding \"utf-8\"\n#GRAMMAR_ROOT S\nEntity -> ";
            List<string> listFacts = new List<string>();
            foreach (string synonym in keyWords)
            {
                entity += String.Format("'{0}' | ", synonym.ToLower());
            }
            string pattern = entity.Remove(entity.Length - 3) + ";\n" + script;
            File.WriteAllText(@"Script.cxx", pattern);
            File.WriteAllText(@"Input.txt", text);
            using (Process Parsing = new Process())
            {
                Parsing.StartInfo.FileName = @"tomitaparser.exe";
                Parsing.StartInfo.Arguments = @"Config.proto";
                Parsing.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Parsing.Start();
                Parsing.WaitForExit();
            }
            if (File.Exists("PrettyOutput.html"))
            {
                string factsHTML = File.ReadAllText("PrettyOutput.html");
                foreach (string fact in factsHTML.Substrings("<a href=", "</a>").ToList())
                    listFacts.Add(fact.Remove(0, fact.IndexOf(">") + 1));
            }
            else
            {
                throw new Exception("Паттерн некорректен!");
            }
            File.Delete(@"Script.cxx");
            File.Delete(@"PrettyOutput.html");
            File.Delete(@"Input.txt");
            File.Delete(@"Dictionary.gzt.bin");
            File.Delete(@"Script.bin");
            return listFacts;
        }

        private void FactsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NoClosing(sender, e);
        } 
    }
}
