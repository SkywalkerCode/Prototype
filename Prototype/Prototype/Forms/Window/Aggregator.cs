using OwlDotNetApi;
using Prototype.SocialNetwork;
using Prototype.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Prototype.Forms.Window
{
    public partial class Aggregator : Form
    {
        private List<ISocialNetwork> SocialNetworks;
        private List<Review> Reviews;
        private OntologyForm Ontology;
        private ConnectSqlServerForm ConnectingForm;
        private StopWordsForm StopWords;

        public Aggregator()
        {
            InitializeComponent();
            LoadNetWorks();
            Reviews = new List<Review>();
            ConnectingForm = new ConnectSqlServerForm();
            Ontology = new OntologyForm(cbHeadOwlClass, Path.GetFullPath("Онтология Protege.owl"));
            StopWords = new StopWordsForm();
        }

        #region Import
        private int CountConnectedNetWorks;

        private void LoadNetWorks()
        {
            SocialNetworks = new List<ISocialNetwork>();
            CountConnectedNetWorks = 0;
            SocialNetworks.Add(new VK());
            UpdateNetWorks();
        }

        private void AddNewRequest(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                lbRequests.Items.Add(tbRequest.Text);
            }
        }

        private void AddNewSpam(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                lbSpam.Items.Add(tbSpam.Text);
            }
        }

        private void RemoveSelectedItemsFromListBox(object sender, KeyEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            if (e.KeyData == Keys.Delete)
            {
                List<object> items = new List<object>();
                foreach (object item in listBox.SelectedItems)
                {
                    items.Add(item);
                }
                foreach (object item in items)
                {
                    listBox.Items.Remove(item);
                }
            }
        }

        private void DateTypeChange(object sender, EventArgs e)
        {
            dtpEndDate.Visible = labelSplit.Visible = rbRange.Checked;
        }

        private void UpdateNetWorks()
        {
            lvNetworks.Items.Clear();
            lvNetworks.Columns.Clear();
            lvNetworks.Columns.Add("Название");
            lvNetworks.Columns.Add("Подключение");
            foreach (ISocialNetwork netWork in SocialNetworks)
            {
                ListViewItem lvi = new ListViewItem(new string[] { netWork.Name, netWork.IsAuthorized.ToString() })
                {
                    Tag = netWork,
                    ForeColor = netWork.IsAuthorized ? Color.Green : Color.Red
                };
                lvNetworks.Items.Add(lvi);
            }
            lvNetworks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvNetworks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ShowMenuForNetWork(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvNetworks.FocusedItem != null)
                {
                    menuNetWork.Items[0].Enabled = (lvNetworks.FocusedItem.Bounds.Contains(e.Location));
                }
                else
                {
                    menuNetWork.Items[0].Enabled = false;
                }
                menuNetWork.Show(Cursor.Position);
            }
        }

        private void btnConnectedSelectNetWork_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvNetworks.SelectedItems)
            {
                ConnectNewWork(lvi);
            }
        }

        private void btnConnectAllNetWork_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvNetworks.Items)
            {
                ConnectNewWork(lvi);
            }
        }

        private void btnReloadAll_Click(object sender, EventArgs e)
        {
            LoadNetWorks();
            foreach (ListViewItem lvi in lvNetworks.Items)
            {
                ConnectNewWork(lvi);
            }
        }

        private void ConnectNewWork(ListViewItem lvi)
        {
            ISocialNetwork netWork = (ISocialNetwork)lvi.Tag;
            CountConnectedNetWorks += netWork.Autorization() ? 1 : 0;
            lvi.SubItems[1].Text = netWork.IsAuthorized.ToString();
            lvi.ForeColor = netWork.IsAuthorized ? Color.Green : Color.Red;
        }

        private bool CheckExportData()
        {
            if (CountConnectedNetWorks == 0)
            {
                MessageBox.Show("Ни одна сеть не подключена!");
                return false;
            }
            if (rbRange.Checked && dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Некорректный диапазон времени!");
                return false;
            }
            return true;
        }

        private void btnSearchComments_Click(object sender, EventArgs e)
        {
            if (CheckExportData())
            {
                btnSearchComments.Text = "Выполняется поиск..";
                Reviews = new List<Review>();
                List<string> requests = new List<string>();
                foreach (string item in lbRequests.Items)
                {
                    requests.Add(item);
                }
                foreach (ISocialNetwork netWork in SocialNetworks)
                {
                    if (netWork.IsAuthorized)
                    {
                        netWork.Requests.AddRange(requests);
                        if (cbGroup.Checked)
                        {
                            Reviews.AddRange(netWork.GetReviewsFromGroups(dtpStartDate.Value.Date, dtpEndDate.Value.Date));
                        }
                        if (cbTopics.Checked)
                        {
                            Reviews.AddRange(netWork.GetReviewsFromTopics(dtpStartDate.Value.Date, dtpEndDate.Value.Date));
                        }
                    }
                }
                UpdateUriReviews();
                SystemSounds.Hand.Play();
                btnSearchComments.Text = "Искать комментарии";
            }
        }
        #endregion

        #region Extract
        private void UpdateUriReviews()
        {
            lvReviews.Items.Clear();
            lvReviews.Columns.Clear();
            lvReviews.Columns.Add("URI");
            lvReviews.Columns.Add("Фактов");
            lvReviews.Columns.Add("Длина");
            foreach (Review review in Reviews)
            {
                ListViewItem lvi = new ListViewItem(new string[] {
                    review.URI,
                    review.FactsExtracted ? review.CountFacts.ToString() : "---",
                    review.Text.Length.ToString()
                })
                {
                    Tag = review
                };
                lvReviews.Items.Add(lvi);
            }
            lvReviews.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvReviews.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void lvReviews_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedReview();
        }

        private void SelectedReview()
        {
            if (lvReviews.SelectedItems.Count != 1)
            {
                tbTextReview.Text = "";
                tvFacts.Nodes.Clear();
            }
            else
            {
                Review review = (Review)lvReviews.SelectedItems[0].Tag;
                tbTextReview.Text = review.Text;
                tvFacts.Nodes.AddRange(review.Nodes);
                tvFacts.ExpandAll();
            }
        }

        private void lvReviews_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvReviews.FocusedItem != null)
                {
                    menuReview.Items[0].Enabled = (lvReviews.FocusedItem.Bounds.Contains(e.Location));
                }
                else
                {
                    menuReview.Items[0].Enabled = false;
                }
                menuReview.Show(Cursor.Position);
            }
        }

        private void btnExtractFacts_Click(object sender, EventArgs e)
        {
            List<ListViewItem> selectedItems = new List<ListViewItem>();
            foreach (ListViewItem lvi in lvReviews.SelectedItems)
            {
                selectedItems.Add(lvi);
            }
            foreach (ListViewItem lvi in selectedItems)
            {
                Review review = (Review)lvi.Tag;
                lvReviews.SelectedItems.Clear();
                lvi.Selected = true;
                review.ExtractFacts((OwlClass)((OwlItem)cbHeadOwlClass.SelectedItem).owlNode);
                lvi.SubItems[1].Text = review.FactsExtracted ? review.CountFacts.ToString() : "---";
                tbTextReview.Text = review.Text;
                break;
            }
            foreach (ListViewItem lvi in selectedItems)
            {
                lvi.Selected = true;
            }
            if (selectedItems.Count == 1)
            {
                SelectedReview();
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvReviews.Items)
            {
                item.Selected = true;
            }
        }

        private void cbDeleteStopWords_Click(object sender, EventArgs e)
        {
            cbDeleteStopWords.Checked = !cbDeleteStopWords.Checked;
        }

        private void lvReviews_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = lvReviews.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                lvReviews.ListViewItemSorter = sorter;
            }
            else
            {
                sorter.SortOrder = !sorter.SortOrder;
                sorter.ColumnIndex = e.Column;
            }
            lvReviews.Sort();
        }

        private void btnLoadReview_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Review review = new Review(
                        File.ReadAllText(dialog.FileName),
                        dialog.FileName);
                    ListViewItem lvi = new ListViewItem(new string[] {
                    review.URI,
                    review.FactsExtracted ? review.CountFacts.ToString() : "---",
                    review.Text.Length.ToString()})
                    {
                        Tag = review
                    };
                    lvReviews.Items.Add(lvi);
                    lvReviews.SelectedItems.Clear();
                    lvi.Selected = true;
                    lvReviews.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lvReviews.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    Reviews.Add(review);
                }
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            List<ListViewItem> selectedItems = new List<ListViewItem>();
            foreach (ListViewItem lvi in lvReviews.SelectedItems)
            {
                selectedItems.Add(lvi);
            }
            foreach (ListViewItem lvi in selectedItems)
            {
                lvReviews.Items.Remove(lvi);
                Reviews.Remove((Review)lvi.Tag);
            }
        }

        private void tvFacts_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuFacts.Show(Cursor.Position);
            }
        }

        private void btnExpandFacts_Click(object sender, EventArgs e)
        {
            tvFacts.ExpandAll();
        }

        private void btnCollapseFacts_Click(object sender, EventArgs e)
        {
            tvFacts.CollapseAll();
        }
        #endregion

        #region Export
        private void btnConnectingDataBase_Click(object sender, EventArgs e)
        {
            ConnectingForm.ShowDialog();
            var SqlConnStr = ConnectingForm.SqlConnectStr;
            gbExport.Enabled = SqlConnStr != null;
            if (SqlConnStr == null)
            {
                lStatusConnect.Text = "Не подключено";
                lStatusConnect.ForeColor = Color.Red;
            }
            else
            {
                lStatusConnect.Text = "Сервер: " + ConnectingForm.SqlConnectStr.DataSource;
                lStatusConnect.ForeColor = Color.Green;
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

        private void cbCurrentDataBase_SelectedIndexChanged(object sender, EventArgs e)
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
            btnExport.Enabled = (cbTableReview.SelectedIndex != -1);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            foreach (Review review in Reviews)
            {
                using (var sConn = new SqlConnection(ConnectingForm.SqlConnectStr.ConnectionString))
                {
                    sConn.Open();
                    string strQuery = "insert into " + cbTableReview.Text + " output inserted.id values ({0}, {1})";
                    SqlQuery sqlQuery = new SqlQuery(strQuery, review.Text, review.URI);
                    int idReview = 0;
                    try
                    {
                        idReview = Convert.ToInt32(sqlQuery.GetSqlCommand(sConn).ExecuteScalar());
                        lbReviews.Items.Add(sqlQuery);
                    }
                    catch
                    {
                        lbErrors.Items.Add("Главная таблица не подходит по составу!");
                        return;
                    }
                    foreach (Fact fact in review.Facts)
                    {
                        try
                        {
                            strQuery = "insert into " + fact.Table + " values ({0}, {1})";
                            sqlQuery = new SqlQuery(strQuery, idReview.ToString(), fact.Text);
                            sqlQuery.GetSqlCommand(sConn).ExecuteNonQuery();
                            lbReviews.Items.Add(sqlQuery);
                        }
                        catch
                        {
                            if (fact.Table == null)
                            {
                                lbErrors.Items.Add("Для факта \"" + fact.Text + "\" не указана таблица!");
                            }
                            if (fact.Table == "")
                            {
                                lbErrors.Items.Add("Для факта \"" + fact.Text + "\" не указана таблица!");
                            }
                            if (true)
                            {
                                lbErrors.Items.Add("Таблица '" + fact.Table + "' не обнаружена в БД!");
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region Settings
        private void ShowMenuSettings(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuSettings.Show(Cursor.Position);
            }
        }

        private void btnShowOntology_Click(object sender, EventArgs e)
        {
            Ontology.Show();
            Ontology.WindowState = FormWindowState.Normal;
            Ontology.Activate();
        }

        private void btnShowStopWords_Click(object sender, EventArgs e)
        {
            StopWords.Show();
            StopWords.WindowState = FormWindowState.Normal;
            StopWords.Activate();
        }
        #endregion
    }
}
