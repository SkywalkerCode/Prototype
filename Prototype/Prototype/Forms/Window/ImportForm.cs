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

        public void Autorization()
        {
            new AutorizationSocialNetworkForm(ListSocialNetworks).ShowDialog();
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

        private DateTime StartTime
        {
            get
            {
                return dtpDate.Value.Date;
            }
        }

        private DateTime EndTime
        {
            get
            {
                if (rbRange.Checked)
                {
                    return dtpDateFinish.Value.Date;
                }
                else
                {
                    return StartTime;
                }
            }
        }

        private void ImportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NoClosing(sender, e);
        }

        private void ChangeDateTypeSearch(object sender, EventArgs e)
        {
            dtpDateFinish.Enabled = !rbDate.Checked;
        }

        private void btnAddQuery_Click(object sender, EventArgs e)
        {
            lbQuery.Items.Add(tbNewQuery.Text);
        }

        private void btnDeleteSelectQuery_Click(object sender, EventArgs e)
        {
            lbQuery.Items.Remove(lbQuery.SelectedItem);
        }

        public void StartSearchComments()
        {
            Reviews.Clear();
            foreach (ISocialNetwork netWork in ListSocialNetworks)
            {
                foreach (string request in lbQuery.Items)
                {
                    netWork.Requests.Add(request);
                }
                if (cbGroup.Checked)
                {
                    Reviews.AddRange(netWork.GetReviewsFromGroups(StartTime, EndTime));
                }
                if (cbTopics.Checked)
                {
                    Reviews.AddRange(netWork.GetReviewsFromTopics(StartTime, EndTime));
                }
            }
        }

        public void RemoveSpam()
        {
            foreach (Review review in Reviews)
            {
                foreach (string spam in lbSpam.Items)
                {
                    if (review.Text.ToLower().Contains(spam.ToLower()))
                    {
                        Reviews.Remove(review);
                    }
                }
            }
        }

        private void btnAddSpam_Click(object sender, EventArgs e)
        {
            lbSpam.Items.Add(tbSpam.Text);
        }

        private void btnRemoveSpam_Click(object sender, EventArgs e)
        {
            lbSpam.Items.Remove(tbSpam.Text);
        }
    }
}