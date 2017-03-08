using Prototype.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype.Forms
{
    public partial class ExportForm : Form
    {
        private SqlConnectionStringBuilder sConnStr;
        private string TableReviewName;
        private List<SqlQuery> SqlQueryes;

        public ExportForm(SqlConnectionStringBuilder SqlConnectStr, string tableReviewName)
        {
            InitializeComponent();
            sConnStr = SqlConnectStr;
            TableReviewName = tableReviewName;
            SqlQueryes = new List<SqlQuery>();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ExecuteQuery(Review review)
        {
            using (var sConn = new SqlConnection(sConnStr.ConnectionString))
            {
                sConn.Open();
                string strQuery = "insert into " + TableReviewName + " output inserted.id values ({0}, {1})";
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
}
