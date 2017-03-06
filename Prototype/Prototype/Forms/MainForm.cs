using OwlDotNetApi;
using Prototype.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public ConnectSqlServerForm Connecting;
        public StopWordsForm StopWords;
        public OntologyForm Ontology;
        public ReviewForm Review;
        public FactsForm Facts;

        public MainForm()
        {
            InitializeComponent();
            Connecting = new ConnectSqlServerForm();
            StopWords = new StopWordsForm();
            Ontology = new OntologyForm(this, Path.GetFullPath("Онтология Protege.owl"));
            Review = new ReviewForm();
            Facts = new FactsForm();
            StopWords.Show();
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
            StopWords.StandartPosition();
            Ontology.StandartPosition();
            Review.StandartPosition();
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

        private void btnShowStopWords_Click(object sender, EventArgs e)
        {
            if (StopWords.Visible == true)
            {
                StopWords.Hide();
            }
            else
            {
                StopWords.Show();
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
            int maxWidth = ((ComboBox)sender).Width;
            Label label = new Label();
            foreach (object item in ((ComboBox)sender).Items)
            {
                label.Text = item.ToString();
                if (label.PreferredWidth > maxWidth)
                {
                    maxWidth = label.PreferredWidth;
                }
            }
            ((ComboBox)sender).DropDownWidth = maxWidth;
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
            Facts.ExtractFacts(
                Review.TextReview,
                Review.URI,
                (OwlClass)((OwlClassItem)cbSelectClass.SelectedItem).owlNode);
        }

        private void btnDeleteStopWord_Click(object sender, EventArgs e)
        {
            Review.DeleteStopWords(StopWords.StopWords);
        }

        private void btnConnecting_Click(object sender, EventArgs e)
        {
            Connecting.ShowDialog();
            var SqlConnStr = Connecting.SqlConnectStr;
            if (Connecting.SqlConnectStr == null)
            {
                lStatus.Text = "Не подключено";
                lStatus.ForeColor = Color.Red;
            }
            else
            {
                lStatus.Text = "Сервер: " + Connecting.SqlConnectStr.DataSource;
                lStatus.ForeColor = Color.Green;
                cbCurrentDataBase.Items.Clear();
                using (var sConn = new SqlConnection(SqlConnStr.ConnectionString))
                {
                    sConn.Open();
                    var sCommand = new SqlCommand
                    {
                        Connection = sConn,
                        CommandText = @"USE master SELECT name FROM sys.databases"
                    };
                    var reader = sCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        cbCurrentDataBase.Items.Add((string)reader["name"]);
                    }
                    cbCurrentDataBase.SelectedIndex = (cbCurrentDataBase.Items.Count != 0) ? 0 : -1;
                }
            }
        }

        private void cbCurrentDataBase_TextChanged(object sender, EventArgs e)
        {
            var SqlConnStr = Connecting.SqlConnectStr;
            cbTableReview.Items.Clear();
            SqlConnStr.InitialCatalog = cbCurrentDataBase.Text;
            using (var sConn = new SqlConnection(SqlConnStr.ConnectionString))
            {
                sConn.Open();
                var sCommand = new SqlCommand
                {
                    Connection = sConn,
                    CommandText = @"SELECT name FROM sys.objects WHERE type = 'U'"
                };
                var reader = sCommand.ExecuteReader();
                while (reader.Read())
                {
                    cbTableReview.Items.Add((string)reader["name"]);
                }
                cbTableReview.SelectedIndex = (cbTableReview.Items.Count != 0) ? 0 : -1;
            }
        }
    }
}
