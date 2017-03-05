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

namespace Prototype.Forms
{
    public partial class StopWordsForm : Form
    {
        private string Path;

        public StopWordsForm()
        {
            InitializeComponent();
        }

        public List<string> StopWords
        {
            get
            {
                List<string> stopWords = new List<string>();
                foreach (string str in tbStopWords.Text.Split(new char[] { '\r', '\n' }))
                {
                    if (str != "")
                    {
                        stopWords.Add(str);
                    }
                }
                return stopWords;
            }
        }

        public void StandartPosition()
        {
            Location = new Point()
            {
                Y = Screen.PrimaryScreen.WorkingArea.Height * 2 / 7,
                X = Screen.PrimaryScreen.WorkingArea.Width * 9 / 25
            };
            Size = new Size()
            {
                Height = Screen.PrimaryScreen.WorkingArea.Height * 5 / 7,
                Width = Screen.PrimaryScreen.WorkingArea.Width / 2 - Screen.PrimaryScreen.WorkingArea.Width * 9 / 25
            };
        }

        private bool ChangedText
        {
            get
            {
                if (Path == null && tbStopWords.Text == "")
                {
                    return false;
                }
                if (Path == null && tbStopWords.Text != "")
                {
                    return true;
                }
                if (!File.Exists(Path))
                {
                    return true;
                }
                if (File.ReadAllText(Path) != tbStopWords.Text)
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
                        tbStopWords.Text = File.ReadAllText(dialog.FileName);
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
            SaveAs(tbStopWords.Text);
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
            tbStopWords.Text = "";
            Path = null;
            return true;
        }

        private bool Save()
        {
            if (ChangedText)
            {
                if (File.Exists(Path))
                {
                    File.WriteAllText(Path, tbStopWords.Text);
                    return true;
                }
                else
                {
                    return SaveAs(tbStopWords.Text);
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
                    File.WriteAllText(dialog.FileName, tbStopWords.Text);
                    Path = dialog.FileName;
                    return true;
                }
            }
            return false;
        }
    }
}
