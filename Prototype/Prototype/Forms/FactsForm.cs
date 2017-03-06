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
    public partial class FactsForm : Form
    {
        private List<Review> Reviews;

        public FactsForm()
        {
            InitializeComponent();
            Reviews = new List<Review>();
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
                Width = Screen.PrimaryScreen.WorkingArea.Width * 9 / 25
            };
        }

        private void FactsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void ExtractFacts(string textReview, string URI, OwlClass owlClass)
        {
            Review review = new Review(textReview, URI);
            Reviews.Add(review);
            string owlClassName = OntologyForm.ConvertNameNode(owlClass);
            TreeNode nodeClass = new TreeNode(owlClassName);
            tvFacts.Nodes.Add(nodeClass);
            foreach (OwlEdge owlEdge in owlClass.ParentEdges)
            {
                OwlIndividual owlIndividual = (OwlIndividual)(owlEdge.ParentNode);
                string owlIndividualName = OntologyForm.ConvertNameNode(owlIndividual);
                TreeNode nodeIndividual = new TreeNode(owlIndividualName);
                ExtractFactsFromIndividual(textReview, owlIndividual, nodeIndividual, review);
                nodeClass.Nodes.Add(nodeIndividual);
                nodeClass.Expand();
            }
        }

        private void ExtractFactsFromIndividual(string textReview, OwlIndividual owlIndividual, TreeNode nodeIndividual, Review review)
        {
            if (owlIndividual is OwlIndividual)
            {
                List<string> keyWords = new List<string>();
                string script = "";
                string query = "";

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
                    if (OntologyForm.ConvertNameNode(owlAttribute) == "HasQuery")
                    {
                        OwlNode attribute = (OwlNode)(owlAttribute.ChildNode);
                        query = attribute.ID;
                    }
                }
                if (script != "")
                {
                    List<string> listFacts = GetFacts(script, keyWords, textReview);
                    foreach (string fact in listFacts)
                    {
                        review.Add(new Fact(fact, query));
                        nodeIndividual.Nodes.Add(fact);
                    }
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
            Reviews.Clear();
        }

        private static List<string> GetFacts(string script, List<string> keyWords, string text)
        {
            string entity = "";
            List<string> listFacts = new List<string>();
            foreach (string synonym in keyWords)
            {
                entity += "'" + synonym.ToLower() + "'" + " | ";
            }
            script = script.Replace("[ENTITY]", entity.Remove(entity.Length - 3));
            File.WriteAllText(@"Script.cxx", script);
            File.WriteAllText(@"Input.txt", text);
            Process Parsing = new Process();
            Parsing.StartInfo.FileName = @"tomitaparser.exe";
            Parsing.StartInfo.Arguments = @"Config.proto";
            Parsing.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Parsing.Start();
            Parsing.WaitForExit();
            if (File.Exists("PrettyOutput.html"))
            {
                string factsHTML = File.ReadAllText("PrettyOutput.html");
                foreach (string fact in factsHTML.Substrings("<a href=", "</a>").ToList())
                    listFacts.Add(fact.Remove(0, fact.IndexOf(">") + 1));
            }
            File.Delete("PrettyOutput.html");
            File.Delete("Input.txt");
            return listFacts;
        } 
    }
}
