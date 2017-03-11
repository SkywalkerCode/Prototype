using Prototype.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype.Forms.Dialog
{
    public partial class AutorizationSocialNetworkForm : Form
    {
        public AutorizationSocialNetworkForm(List<ISocialNetwork> listSocialNetwork)
        {
            InitializeComponent();
            lvNetworks.Columns.Add("Название");
            lvNetworks.Columns.Add("Подключение");
            foreach (ISocialNetwork netWork in listSocialNetwork)
            {
                string[] items = { netWork.Name, netWork.IsAuthorized.ToString() };
                ListViewItem lvi = new ListViewItem(items)
                {
                    Tag = netWork,
                    ForeColor = netWork.IsAuthorized? Color.Green : Color.Red
                };
                lvNetworks.Items.Add(lvi);
            }
            lvNetworks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvNetworks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnConnectSelect_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvNetworks.SelectedItems)
            {
                ISocialNetwork netWork = (ISocialNetwork)lvi.Tag;
                netWork.Autorization();
                lvi.SubItems[1].Text = netWork.IsAuthorized.ToString();
                lvi.ForeColor = netWork.IsAuthorized ? Color.Green : Color.Red;
            }
        }

        private void btnConnectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvNetworks.Items)
            {
                ISocialNetwork netWork = (ISocialNetwork)lvi.Tag;
                netWork.Autorization();
                lvi.SubItems[1].Text = netWork.IsAuthorized.ToString();
                lvi.ForeColor = netWork.IsAuthorized ? Color.Green : Color.Red;
            }
        }
    }
}
