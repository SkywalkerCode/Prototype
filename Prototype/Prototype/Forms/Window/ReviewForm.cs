using Prototype.Tools;
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
    public partial class ReviewForm : MasterForm
    {
        private string Path;
        private Review review;

        public Review Review
        {
            get
            {
                return review;
            }
            set
            {
                tbText.Text = value.Text;
                tbURI.Text = value.URI;
                review = value;
            }
        }

        public ReviewForm()
        {
            InitializeComponent();
            review = new Review(tbText.Text, tbURI.Text);
        }

        private bool ChangedText
        {
            get
            {
                if (Path == null && tbText.Text == "")
                {
                    return (tbText.Text != "");
                }
                if (!File.Exists(Path))
                {
                    return true;
                }
                if (File.ReadAllText(Path) != tbText.Text)
                {
                    return true;
                }
                return false;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (Create())
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        tbText.Text = File.ReadAllText(dialog.FileName).ToLower();
                        Path = dialog.FileName;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs(tbText.Text);
        }

        private bool Create()
        {
            if (ChangedText)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "Текст", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Cancel)
                {
                    return false;
                }
                else
                {
                    if (result == DialogResult.Yes)
                    {
                        if (!Save())
                        {
                            return false;
                        }
                    }
                }
            }
            tbText.Text = "";
            Path = null;
            return true;
        }

        private bool Save()
        {
            if (ChangedText)
            {
                if (File.Exists(Path))
                {
                    File.WriteAllText(Path, tbText.Text);
                    return true;
                }
                else
                {
                    return SaveAs(tbText.Text);
                }
            }
            return true;
        }

        private bool SaveAs(string text)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "*.txt|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, tbText.Text);
                    Path = dialog.FileName;
                    return true;
                }
            }
            return false;
        }

        public void RemoveStopWords(List<string> stopWords)
        {
            string allText = tbText.Text.ToLower();
            foreach (string word in stopWords)
            {
                allText = allText.Replace(" " + word.ToLower() + " ", " ");
                allText = allText.Replace(" " + word.ToLower() + ",", ", ");
                allText = allText.Replace("-" + word.ToLower() + " ", "-");
                allText = allText.Replace(" " + word.ToLower() + "-", "-");
            }
            while (allText.Contains("  "))
            {
                allText = allText.Replace("  ", " ");
            }
            tbText.Text = allText;
        }

        private void ReviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NoClosing(sender, e);
        }
    }
}
