using Prototype.Forms.Dialog;
using Prototype.SocialNetwork;
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

namespace Prototype.Forms.Window
{
    public partial class ImportForm : MasterForm
    {
        private List<ISocialNetwork> ListSocialNetworks;
        private List<Review> Reviews;

        public List<Review> Comments
        {
            get
            {
                return Reviews;
            }
        }

        public ImportForm()
        {
            InitializeComponent();
            ListSocialNetworks = new List<ISocialNetwork>();
            ListSocialNetworks.Add(new VK());
            Reviews = new List<Review>();
        }

        public int CountNetWorks
        {
            get
            {
                return ListSocialNetworks.Count;
            }
        }

        public int CountAutorizedNetWorks
        {
            get
            {
                int count = 0;
                foreach (ISocialNetwork netWork in ListSocialNetworks)
                {
                    if (netWork.IsAuthorized)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        private void ImportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NoClosing(sender, e);
        }

        public void Autorization()
        {
            new AutorizationSocialNetworkForm(ListSocialNetworks).ShowDialog();
        }

        private void ChangeDateTypeSearch(object sender, EventArgs e)
        {
            dtpDateFinish.Enabled = !rbDate.Checked;
        }

        private void btnAddQuery_Click(object sender, EventArgs e)
        {
            lbQuery.Items.Add(tbNewQuery.Text);
            foreach (ISocialNetwork netWork in ListSocialNetworks)
            {
                netWork.AddQuery(tbNewQuery.Text);
            }
        }

        private void btnDeleteSelectQuery_Click(object sender, EventArgs e)
        {
            foreach (ISocialNetwork netWork in ListSocialNetworks)
            {
                netWork.RemoveQuery(lbQuery.SelectedItem.ToString());
            }
            lbQuery.Items.Remove(lbQuery.SelectedItem);
        }

        public void StartSearchComments()
        {
            foreach (ISocialNetwork netWork in ListSocialNetworks)
            {
                Reviews.AddRange(netWork.GetComments(dtpDate.Value, dtpDateFinish.Value, cbDiscussions.Checked, cbTopics.Checked));
            }
        }
    }
}