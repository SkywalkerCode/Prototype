using OwlDotNetApi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using xNet;

namespace Prototype.Tools
{
    public class Review
    {
        private string uri;
        private string text;
        private List<Fact> facts;
        private List<TreeNode> nodes;
        private bool factsExtracted;

        public Review(string text, string uri)
        {
            facts = new List<Fact>();
            this.text = text;
            this.uri = uri;
            factsExtracted = false;
            nodes = new List<TreeNode>();
        }

        public string URI
        {
            get
            {
                return uri;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }
        }

        public int CountFacts
        {
            get
            {
                return facts.Count;
            }
        }

        public bool FactsExtracted
        {
            get
            {
                return factsExtracted;
            }
        }

        public TreeNode[] Nodes
        {
            get
            {
                return nodes.ToArray();
            }
        }

        public List<Fact> Facts
        {
            get
            {
                return facts;
            }
        }

        public void Add(Fact fact)
        {
            this.facts.Add(fact);
        } // удалить после..

        public void ExtractFacts(OwlClass owlClass)
        {
            if (factsExtracted) return;
            string owlClassName = OntologyForm.ConvertNameNode(owlClass);
            foreach (OwlEdge owlEdge in owlClass.ParentEdges)
            {
                OwlIndividual owlIndividual = (OwlIndividual)(owlEdge.ParentNode);
                string owlIndividualName = OntologyForm.ConvertNameNode(owlIndividual);
                TreeNode nodeIndividual = new TreeNode(owlIndividualName);
                try
                {
                    ExtractFactsFromIndividual(owlIndividual, nodeIndividual);
                    nodes.Add(nodeIndividual);
                }
                catch (Exception exception)
                {
                    nodes.Add(new TreeNode(owlIndividualName + ": " + exception.Message));
                }
            }
            factsExtracted = true;
        }

        private void ExtractFactsFromIndividual(OwlIndividual owlIndividual, TreeNode nodeIndividual)
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
                foreach (string fact in GetFacts(script, keyWords))
                {
                    facts.Add(new Fact(fact, table));
                    nodeIndividual.Nodes.Add(fact);
                }
            }
        }

        private List<string> GetFacts(string script, List<string> keyWords)
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

        public override string ToString()
        {
            return uri;
        }
    }
}
