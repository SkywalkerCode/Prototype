using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype.Forms
{
    public partial class ConnectSqlServerForm : Form
    {
        private SqlConnectionStringBuilder SqlConnStr;

        public SqlConnectionStringBuilder SqlConnectStr
        {
            get
            {
                return SqlConnStr;
            }
        }

        public ConnectSqlServerForm()
        {
            InitializeComponent();
            cbTypeCheck.SelectedIndex = 0;
            SqlConnStr = null;
            cbServerName_TextChanged(null, null);
        }

        private void cbTypeCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeCheck.SelectedItem.ToString() == "Проверка подлинности Windows")
            {
                tbPassword.Enabled = false;
                tbUserName.Enabled = false;
            }
            else
            {
                tbPassword.Enabled = true;
                tbUserName.Enabled = true;
            }
        }

        private void btnSearchServers_Click(object sender, EventArgs e)
        {
            Enabled = false;
            cbServerName.Items.Clear();
            DataTable table = SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow row in table.Rows)
            {
                cbServerName.Items.Add(string.Concat(row["ServerName"], "\\", row["InstanceName"]));
            }
            cbServerName.SelectedIndex = (cbServerName.Items.Count != 0) ? 0 : -1;
            Enabled = true;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder sConnStr; // Строка подключения к БД.
                if (cbTypeCheck.SelectedItem.ToString() == "Проверка подлинности Windows")
                {
                    sConnStr = new SqlConnectionStringBuilder
                    {
                        DataSource = cbServerName.Text,
                        IntegratedSecurity = true,
                    };
                }
                else
                {
                    sConnStr = new SqlConnectionStringBuilder
                    {
                        DataSource = cbServerName.Text,
                        IntegratedSecurity = false,
                        UserID = tbUserName.Text,
                        Password = tbPassword.Text
                    };
                }
                using (var sConn = new SqlConnection(sConnStr.ConnectionString)) // Проверка подключения.
                {
                    sConn.Open();
                    var sCommand = new SqlCommand
                    {
                        Connection = sConn,
                        CommandText = @"select 1"
                    };
                    sCommand.ExecuteNonQuery();
                }
                SqlConnStr = sConnStr; // Если подключение удалось, сохраняем строку подключения.
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Ошибка подключения\nНеверный логин и/или пароль.");
            }
        }

        private void cbServerName_TextChanged(object sender, EventArgs e)
        {
            btnConnection.Enabled = (cbServerName.Text != "");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}