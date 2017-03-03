using OwlDotNetApi;
using Prototype.Interfaces;
using Prototype.Parser;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype.OntologyTools
{
    
    public class Ontology
    {
        private ILogWriter LogWriter;
        private OwlGraph OwlGraph;
        public List<OwlClass> ListOwlClass { get; set; }
        private List<OwlIndividual> ListOwlIndividual;
        private List<OwlDatatypeProperty> ListOwlDatatypeProperty;

        public Ontology(string Path, ILogWriter LogWriter)
        {
            this.LogWriter = LogWriter;
            WriteInLog("Загрузка файла онтологии: " + Path);
            OwlXmlParser _owlParser = new OwlXmlParser();
            WriteInLog("Парсинг файла онтологии...");
            OwlGraph = (OwlGraph)_owlParser.ParseOwl(Path);
            WriteInLog(string.Format("Парсинг онтологии завершен с {0} ошибками и {1} предупреждениями.", ((OwlParser)_owlParser).Errors.Count, ((OwlParser)_owlParser).Warnings.Count));
            WriteInLog(string.Format("Онтологический граф построен и содержит {0} вершин и {1} граней.", OwlGraph.Nodes.Count, OwlGraph.Edges.Count));
            Classification();
        }

        /// <summary> Классификация вершин графа. </summary>
        public void Classification()
        {
            ListOwlClass = new List<OwlClass>();
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
                    if (owlNode is OwlDatatypeProperty)
                    {
                        ListOwlDatatypeProperty.Add((OwlDatatypeProperty)owlNode);
                    }
                    if (owlNode is OwlIndividual)
                    {
                        ListOwlIndividual.Add((OwlIndividual)owlNode);
                    }
                }
            }

            // Вывод полученных данных в лог.
            WriteInLog("----------> OwlClass");
            foreach (OwlClass owlClass in ListOwlClass)
            {
                WriteInLog(ConvertNameNode(owlClass));
            }
            WriteInLog("----------> OwlIndividual");
            foreach (OwlIndividual owlIndividual in ListOwlIndividual)
            {
                WriteInLog(ConvertNameNode(owlIndividual));
            }
            WriteInLog("----------> OwlDatatypeProperty");
            foreach (OwlDatatypeProperty owlDatatypeProperty in ListOwlDatatypeProperty)
            {
                WriteInLog(ConvertNameNode(owlDatatypeProperty));
            }

        }

        /// <summary> Извлечение фактов. </summary>
        public void ExtractFacts(Form form, string text, OwlClass owlClass)
        {
            WriteInLog("Извлечение фактов... Класс: " + ConvertNameNode(owlClass));
            foreach (OwlEdge owlEdge in owlClass.ParentEdges)
            {
                OwlIndividual owlIndividual = (OwlIndividual)(owlEdge.ParentNode);
                if (owlIndividual is OwlIndividual)
                {
                    WriteInLog(ConvertNameNode(owlIndividual));
                    List<string> _keyWords = new List<string>();
                    string _script = "";
                    string _table = "";
                    string _attribute = "";

                    foreach (OwlEdge owlAttribute in owlIndividual.ChildEdges)
                    {
                        if (ConvertNameNode(owlAttribute) == "HasKeyWord")
                        {
                            OwlNode Attribute = (OwlNode)(owlAttribute.ChildNode);
                            //WriteInLog("   " + Attribute.ID);
                            _keyWords.Add(Attribute.ID);
                        }

                        if (ConvertNameNode(owlAttribute) == "HasScript")
                        {
                            OwlNode attribute = (OwlNode)(owlAttribute.ChildNode);
                            _script = attribute.ID;
                        }
                        //if (ConvertNameNode(owlAttribute) == "HasTable")
                        //{
                        //    OwlNode Attribute = (OwlNode)(owlAttribute.ChildNode);
                        //    WriteInLog("   " + Attribute.ID);
                        //}

                        //if (ConvertNameNode(owlAttribute) == "HasAttribute")
                        //{
                        //    OwlNode Attribute = (OwlNode)(owlAttribute.ChildNode);
                        //    WriteInLog("   " + Attribute.ID);
                        //}
                    }
                    //WriteInLog("   " + _script);
                    bool stopProcess = false;
                    List<string> listFacts = TomitaParser.GetFacts(_script, _keyWords, text);
                    if (stopProcess){
                        WriteInLog("Процесс прерван.");
                        return;
                    }
                    if (listFacts != null)
                        foreach (string fact in listFacts)
                            WriteInLog("     " + fact);
                }
            }
        }

        /// <summary> Корректное имя вершины. </summary>
        private static string ConvertNameNode(OwlNode owlNode)
        {
            string[] name = owlNode.ID.Split('#');
            if (name.Length > 1)
                return name[1];
            else
                return "---";
        }

        /// <summary> Корректное имя ребра. </summary>
        private static string ConvertNameNode(OwlEdge owlEdge)
        {
            string[] name = owlEdge.ID.Split('#');
            if (name.Length > 1)
                return name[1];
            else
                return "Нет Вершины!!! Ошибка!!!";
        }

        /// <summary> Запись в лог, если он была получена ссылка на него при инициализации. </summary>
        private void WriteInLog(string Message)
        { // Защита от пустой ссылки.
            if (LogWriter != null)
                LogWriter.Write(Message);
        }
    }
}
