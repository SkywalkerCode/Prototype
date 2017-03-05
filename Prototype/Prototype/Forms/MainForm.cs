using OwlDotNetApi;
using Prototype.Forms;
using System;
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
    public partial class MainForm : Form
    {
        public OntologyForm Ontology;
        public ReviewForm Review;
        public FactsForm Facts;

        public MainForm()
        {
            InitializeComponent();
            Ontology = new OntologyForm(this, Path.GetFullPath("Онтология Protege.owl"));
            Review = new ReviewForm();
            Facts = new FactsForm();
            Ontology.Show();
            Review.Show();
            Facts.Show();
        }

        public List<OwlClass> ListOwlClass
        {
            set
            {
                cbSelectClass.Items.Clear();
                foreach (OwlClass owlClass in value)
                {
                    OwlClassItem item = new OwlClassItem(owlClass);
                    cbSelectClass.Items.Add(item);
                }
                if (value.Count != 0)
                {
                    cbSelectClass.SelectedItem = cbSelectClass.Items[0];
                }
            }
        }

        private void WindowsNormalize()
        {
            Review.StandartPosition();
            Ontology.StandartPosition();
            Facts.StandartPosition();
            this.StandartPosition();
        }

        public void StandartPosition()
        {
            this.Location = new Point()
            {
                Y = Screen.PrimaryScreen.WorkingArea.Top,
                X = Screen.PrimaryScreen.WorkingArea.Left
            };
            this.Size = new Size()
            {
                Height = Screen.PrimaryScreen.WorkingArea.Height * 2 / 7,
                Width = Screen.PrimaryScreen.WorkingArea.Width / 2
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WindowsNormalize();
        }

        private void btnWindowsNormalize_Click_1(object sender, EventArgs e)
        {
            WindowsNormalize();
        }

        private void btnShowOntology_Click(object sender, EventArgs e)
        {
            if (Ontology.Visible == true)
            {
                Ontology.Hide();
            }
            else
            {
                Ontology.Show();
            }
        }

        private void btnShowReview_Click(object sender, EventArgs e)
        {
            if (Review.Visible == true)
            {
                Review.Hide();
            }
            else
            {
                Review.Show();
            }
        }

        private void btnShowFacts_Click(object sender, EventArgs e)
        {
            if (Facts.Visible == true)
            {
                Facts.Hide();
            }
            else
            {
                Facts.Show();
            }
        }

        private void cbSelectClass_DropDown(object sender, EventArgs e)
        {
            int maxWidth = cbSelectClass.Width;
            Label label = new Label();
            foreach (object item in cbSelectClass.Items)
            {
                label.Text = item.ToString();
                if (label.PreferredWidth > maxWidth)
                {
                    maxWidth = label.PreferredWidth;
                }
            }
            cbSelectClass.DropDownWidth = maxWidth;
        }

        private void cbSelectClass_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSelectClass.SelectedItem is OwlClassItem)
            {
                btnExtractFacts.Enabled = true;
            }
            else
            {
                btnExtractFacts.Enabled = false;
            }
        }

        private void btnExtractFacts_Click(object sender, EventArgs e)
        {
            string textReview = Review.TextReview;
            OwlClassItem headClass = (OwlClassItem)cbSelectClass.SelectedItem;
            Facts.ExtractFacts(textReview, (OwlClass)headClass.owlNode);
        }
    }
}
