using OwlDotNetApi;
using Prototype.Forms;
using Prototype.Tools;
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
    public partial class MainForm : MasterForm
    {
        public ConnectSqlServerForm ConnectingForm;
        public StopWordsForm StopWordsForm;
        public OntologyForm OntologyForm;
        public ReviewForm ReviewForm;
        public FactsForm FactsForm;

        public MainForm()
        {
            InitializeComponent();
            ConnectingForm = new ConnectSqlServerForm();
            StopWordsForm = new StopWordsForm();
            OntologyForm = new OntologyForm(this, Path.GetFullPath("Онтология Protege.owl"));
            ReviewForm = new ReviewForm();
            FactsForm = new FactsForm();
            StopWordsForm.Show();
            OntologyForm.Show();
            ReviewForm.Show();
            FactsForm.Show();
        }

        public List<OwlClass> ListOwlClass
        {
            set
            {
                cbSelectClass.Items.Clear();
                foreach (OwlClass owlClass in value)
                {
                    OwlItem item = new OwlItem(owlClass);
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
            Point location= new Point();;
            Size size = new Size();
            Rectangle area = Screen.PrimaryScreen.WorkingArea;
            // StopWordsForm
            location.Y = area.Height * 2 / 7;
            location.X = area.Width * 9 / 25;
            size.Height = area.Height * 5 / 7;
            size.Width = area.Width / 2 - area.Width * 9 / 25;
            StopWordsForm.WindowPosition(location, size);
            // OntologyForm
            location.Y = area.Top;
            location.X = area.Width / 2;
            size.Height = area.Height / 2;
            size.Width = area.Width / 2;
            OntologyForm.WindowPosition(location, size);
            // ReviewForm
            location.Y = area.Height / 2;
            location.X = area.Width / 2;
            size.Height = area.Height / 2;
            size.Width = area.Width / 2;
            ReviewForm.WindowPosition(location, size);
            // FactsForm
            location.Y = area.Height * 2 / 7;
            location.X = area.Left;
            size.Height = area.Height * 5 / 7;
            size.Width = area.Width * 9 / 25;
            FactsForm.WindowPosition(location, size);
            // MainForm
            location.Y = area.Top;
            location.X = area.Left;
            size.Height = area.Height * 2 / 7;
            size.Width = area.Width / 2;
            this.WindowPosition(location, size);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WindowsNormalize();
        }

        private void btnWindowsNormalize_Click(object sender, EventArgs e)
        {
            WindowsNormalize();
        }

        private void btnShowOntology_Click(object sender, EventArgs e)
        {
            if (OntologyForm.Visible == true)
            {
                OntologyForm.Hide();
            }
            else
            {
                OntologyForm.Show();
            }
        }

        private void btnShowReview_Click(object sender, EventArgs e)
        {
            if (ReviewForm.Visible == true)
            {
                ReviewForm.Hide();
            }
            else
            {
                ReviewForm.Show();
            }
        }

        private void btnShowStopWords_Click(object sender, EventArgs e)
        {
            if (StopWordsForm.Visible == true)
            {
                StopWordsForm.Hide();
            }
            else
            {
                StopWordsForm.Show();
            }
        }

        private void btnShowFacts_Click(object sender, EventArgs e)
        {
            if (FactsForm.Visible == true)
            {
                FactsForm.Hide();
            }
            else
            {
                FactsForm.Show();
            }
        }

        private void ComboBox_DropDown(object sender, EventArgs e)
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
            btnExtractFacts.Enabled = (cbSelectClass.SelectedItem is OwlItem);
        }

        private void btnExtractFacts_Click(object sender, EventArgs e)
        {
            FactsForm.ExtractFacts(
                ReviewForm.TextReview,
                ReviewForm.URI,
                (OwlClass)((OwlItem)cbSelectClass.SelectedItem).owlNode);
        }

        private void btnRemoveStopWord_Click(object sender, EventArgs e)
        {
            ReviewForm.RemoveStopWords(StopWordsForm.StopWords);
        }

        private void btnConnecting_Click(object sender, EventArgs e)
        {
            ConnectingForm.ShowDialog();
            var SqlConnStr = ConnectingForm.SqlConnectStr;
            if (SqlConnStr == null)
            {
                lStatus.Text = "Не подключено";
                lStatus.ForeColor = Color.Red;
            }
            else
            {
                lStatus.Text = "Сервер: " + ConnectingForm.SqlConnectStr.DataSource;
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
            var SqlConnStr = ConnectingForm.SqlConnectStr;
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

        private void cbTableReview_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnExport.Enabled = cbShowQuery.Enabled = (cbTableReview.SelectedIndex != -1);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string tableReviewName = cbTableReview.Text;
            ExportForm export = new ExportForm(ConnectingForm.SqlConnectStr, tableReviewName);
            foreach (Review review in FactsForm.Reviews)
            {
                export.ExecuteQuery(review);
            }
            if (cbShowQuery.Checked)
            {
                export.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActivateWindows_Click(object sender, EventArgs e)
        {
            // StopWordsForm
            StopWordsForm.Activate();
            // OntologyForm
            OntologyForm.Activate();
            // ReviewForm
            ReviewForm.Activate();
            // FactsForm
            FactsForm.Activate();
            // MainForm
            this.Activate();
        }

        private void btnShowAllWindows_Click(object sender, EventArgs e)
        {
            // StopWordsForm
            StopWordsForm.Show();
            // OntologyForm
            OntologyForm.Show();
            // ReviewForm
            ReviewForm.Show();
            // FactsForm
            FactsForm.Show();
            // MainForm
            this.Show();
        }
    }
}
