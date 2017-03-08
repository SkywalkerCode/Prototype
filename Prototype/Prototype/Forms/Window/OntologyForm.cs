using OwlDotNetApi;
using Prototype.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class OntologyForm : MasterForm
    {
        private MainForm MainForm;
        private WriteInLog LogWriter;
        private string Path;
        private OwlGraph OwlGraph;
        private List<OwlClass> ListOwlClass;
        private List<OwlProperty> ListOwlProperty;
        private List<OwlIndividual> ListOwlIndividual;
        private List<OwlDatatypeProperty> ListOwlDatatypeProperty;

        public OntologyForm(MainForm mainForm)
        {
            InitializeComponent();
            LogWriter = new WriteInLog(lbLog);
            MainForm = mainForm;
        }

        public OntologyForm(MainForm mainForm, string path)
        {
            InitializeComponent();
            LogWriter = new WriteInLog(lbLog);
            MainForm = mainForm;
            if (File.Exists(path))
            {
                Path = path;
                LoadOntology();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "OWL File|*.owl|All Files|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Path = dialog.FileName;
                    LoadOntology();
                }
            }
        }

        private void LoadOntology()
        {
            LogWriter.Clear();
            LogWriter.Write("Загрузка онтологии: " + Path);
            OwlXmlParser parser = new OwlXmlParser();
            LogWriter.Write("Парсинг файла онтологии...");
            OwlGraph = (OwlGraph)parser.ParseOwl(Path);
            LogWriter.Write(string.Format("Парсинг онтологии завершен с {0} ошибками и {1} предупреждениями.", ((OwlParser)parser).Errors.Count, ((OwlParser)parser).Warnings.Count));
            LogWriter.Write(string.Format("Онтологический граф построен и содержит {0} вершин и {1} граней.", OwlGraph.Nodes.Count, OwlGraph.Edges.Count));
            ClassificationOwlNodes();
            WriteTree();
            MainForm.ListOwlClass = ListOwlClass;
        }

        private void ClassificationOwlNodes()
        {
            ListOwlClass = new List<OwlClass>();
            ListOwlProperty = new List<OwlProperty>();
            ListOwlIndividual = new List<OwlIndividual>();
            ListOwlDatatypeProperty = new List<OwlDatatypeProperty>();

            IDictionaryEnumerator enumerator = (IDictionaryEnumerator)OwlGraph.Nodes.GetEnumerator();
            while (enumerator.MoveNext())
            {
                OwlNode owlNode = (OwlNode)OwlGraph.Nodes[(string)enumerator.Key];
                if (!owlNode.IsAnonymous())
                {
                    if (owlNode is OwlClass)
                    {
                        ListOwlClass.Add((OwlClass)owlNode);
                    }
                    if (owlNode is OwlProperty)
                    {
                        ListOwlProperty.Add((OwlProperty)owlNode);
                    }
                    if (owlNode is OwlIndividual)
                    {
                        ListOwlIndividual.Add((OwlIndividual)owlNode);
                    }
                    if (owlNode is OwlDatatypeProperty)
                    {
                        ListOwlDatatypeProperty.Add((OwlDatatypeProperty)owlNode);
                    }
                }
            }
            WriteStructure();
        }

        private void WriteStructure()
        {
            LogWriter.Write("--------------------> OwlClass");
            foreach (OwlClass owlClass in ListOwlClass)
            {
                LogWriter.Write(ConvertNameNode(owlClass));
            }
            LogWriter.Write("--------------------> OwlProperty");
            foreach (OwlProperty owlProperty in ListOwlProperty)
            {
                LogWriter.Write(ConvertNameNode(owlProperty));
            }
            LogWriter.Write("--------------------> OwlIndividual");
            foreach (OwlIndividual owlIndividual in ListOwlIndividual)
            {
                LogWriter.Write(ConvertNameNode(owlIndividual));
            }
            LogWriter.Write("--------------------> OwlDatatypeProperty");
            foreach (OwlDatatypeProperty owlDatatypeProperty in ListOwlDatatypeProperty)
            {
                LogWriter.Write(ConvertNameNode(owlDatatypeProperty));
            }
        }

        public static string ConvertNameNode(OwlNode owlNode)
        {
            string[] name = owlNode.ID.Split('#');
            if (name.Length > 1)
                return name[1];
            else
                return "---";
        }

        public static string ConvertNameNode(OwlEdge owlEdge)
        {
            string[] name = owlEdge.ID.Split('#');
            if (name.Length > 1)
                return name[1];
            else
                return "Нет Вершины!!! Ошибка!!!";
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            LogWriter.Clear();
        }

        private void btnWriteGraph_Click(object sender, EventArgs e)
        {
            WriteStructure();
        }

        private void OntologyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NoClosing(sender, e);
        }

        private void WriteTree()
        {
            tvClasses.Nodes.Clear();
            lbIndividuals.Items.Clear();
            tvDataProperty.Nodes.Clear();
            foreach (OwlClass owlClass in ListOwlClass)
            {
                if (owlClass.ChildEdges.Count == 1)
                {
                    TreeNode treeNode = new TreeNode(ConvertNameNode(owlClass));
                    WriteTree(owlClass, treeNode);
                    tvClasses.Nodes.Add(treeNode);
                }
            }
            tvClasses.ExpandAll();
        }

        private void WriteTree(OwlClass owlClass, TreeNode treeNode)
        {
            foreach (OwlEdge owlEdge in owlClass.ParentEdges)
            {
                OwlNode owlNode = (OwlNode)owlEdge.ParentNode;
                if (owlNode is OwlClass)
                {
                    TreeNode childTreeNode = new TreeNode(ConvertNameNode(owlNode));
                    WriteTree((OwlClass)owlNode, childTreeNode);
                    treeNode.Nodes.Add(childTreeNode);
                }
            }
        }

        private void tvClasses_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lbIndividuals.Items.Clear();
            tvDataProperty.Nodes.Clear();
            foreach (OwlClass owlClass in ListOwlClass)
            {
                if (ConvertNameNode(owlClass) == tvClasses.SelectedNode.Text)
                {
                    foreach (OwlEdge owlIndividual in owlClass.ParentEdges)
                    {
                        if (owlIndividual.ParentNode is OwlIndividual)
                        {
                            lbIndividuals.Items.Add(ConvertNameNode((OwlNode)owlIndividual.ParentNode));
                        }
                    }
                    break;
                }
            }
        }

        private void lbIndividuals_SelectedIndexChanged(object sender, EventArgs e)
        {
            tvDataProperty.Nodes.Clear();
            foreach (OwlIndividual individual in ListOwlIndividual)
            {
                if (ConvertNameNode(individual) == lbIndividuals.Text)
                {
                    TreeNode hasKeyWord = new TreeNode("HasKeyWord");
                    TreeNode hasScript = new TreeNode("HasScript");
                    TreeNode hasTable = new TreeNode("HasTable");
                    foreach (OwlEdge owlAttribute in individual.ChildEdges)
                    {
                        OwlNode attribute = (OwlNode)(owlAttribute.ChildNode);
                        if (OntologyForm.ConvertNameNode(owlAttribute) == "HasKeyWord")
                        {
                            hasKeyWord.Nodes.Add(attribute.ID);
                        }
                        if (OntologyForm.ConvertNameNode(owlAttribute) == "HasScript")
                        {
                            hasScript.Nodes.Add(attribute.ID);
                        }
                        if (OntologyForm.ConvertNameNode(owlAttribute) == "HasTable")
                        {
                            hasTable.Nodes.Add(attribute.ID);
                        }
                    }
                    tvDataProperty.Nodes.Add(hasKeyWord);
                    tvDataProperty.Nodes.Add(hasScript);
                    tvDataProperty.Nodes.Add(hasTable);
                    tvDataProperty.ExpandAll();
                    break;
                }
            }
        }
    }
}
