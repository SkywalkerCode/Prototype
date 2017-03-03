using OwlDotNetApi;
using Prototype.Interfaces;
using Prototype.OntologyTools;
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

namespace Prototype
{
    public partial class MainForm : Form
    {
        private WriteInLog WriteInLog;
        private Ontology ontology;
        private string text;

        private string FileNameOntology
        {
            get
            {
                return tbPathOntology.Text;
            }
            set
            {
                if (File.Exists(value))
                {
                    tbPathOntology.Text = value;
                    WriteInLog.Write("Текущий путь к файлу онтологии: " + value);
                }
                else
                {
                    WriteInLog.Write("Файл онтологии \"" + value + "\" не найден: ");
                }
            }
        }

        private string FileNameText
        {
            get
            {
                return tbPathText.Text;
            }
            set
            {
                if (File.Exists(value))
                {
                    text = File.ReadAllText(value);
                    tbPathText.Text = value;
                    WriteInLog.Write("Текущий путь к файлу отзыва: " + value);
                }
                else
                {
                    WriteInLog.Write("Файл отзыва \"" + value + "\" не найден: ");
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            WriteInLog = new WriteInLog(lbLog);
            FileNameOntology = @"Онтология Protege.owl"; // Начальное значение пути к онтологии.
            FileNameText = @"Отзывы.txt"; // Начальное значение пути к файлу отзыва.
        }

        private void btnPathOntology_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "OWL File|*.owl|All Files|*.*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileNameOntology = fileDialog.FileName;
                }
            }
        }

        private void btnPathText_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Text File|*.txt|All Files|*.*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileNameText = fileDialog.FileName;
                }
            }
        }

        private void btnLoadOntology_Click(object sender, EventArgs e)
        {
            ontology = new Ontology(FileNameOntology, WriteInLog);
            btnWriteGraph.Enabled = btnExtractFacts.Enabled = true;
            foreach (OwlClass owlClass in ontology.ListOwlClass)
            {
                cbSelectClass.Items.Add(owlClass);
            }
            if (cbSelectClass.Items.Count != 0)
            {
                cbSelectClass.SelectedItem = cbSelectClass.Items[0];
            }
            else
            {
                WriteInLog.Write("Ошибка! Онтология не содержит классов!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbLog.Items.Clear();
        }

        private void btnWriteGraph_Click(object sender, EventArgs e)
        {
            if (ontology != null)
                ontology.Classification();
        }

        private void btnExtractFacts_Click(object sender, EventArgs e)
        {
            if (ontology != null && cbSelectClass.SelectedItem != null)
            {
                text = File.ReadAllText(FileNameText);
                this.Enabled = false;
                ontology.ExtractFacts(this, text, (OwlClass)cbSelectClass.SelectedItem);
                this.Enabled = true;
            }
        }
    }
}
