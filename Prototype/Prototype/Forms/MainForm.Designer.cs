namespace Prototype
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowFacts = new System.Windows.Forms.Button();
            this.btnShowReview = new System.Windows.Forms.Button();
            this.btnShowOntology = new System.Windows.Forms.Button();
            this.btnWindowsNormalize = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExtractFacts = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbSelectClass = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DeleteStopWord = new System.Windows.Forms.Button();
            this.btnShowStopWords = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnWindowsNormalize);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Окна";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowStopWords);
            this.groupBox2.Controls.Add(this.btnShowFacts);
            this.groupBox2.Controls.Add(this.btnShowReview);
            this.groupBox2.Controls.Add(this.btnShowOntology);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Показать/скрыть";
            // 
            // btnShowFacts
            // 
            this.btnShowFacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowFacts.Location = new System.Drawing.Point(3, 62);
            this.btnShowFacts.Name = "btnShowFacts";
            this.btnShowFacts.Size = new System.Drawing.Size(109, 23);
            this.btnShowFacts.TabIndex = 11;
            this.btnShowFacts.Text = "Факты";
            this.btnShowFacts.UseVisualStyleBackColor = true;
            this.btnShowFacts.Click += new System.EventHandler(this.btnShowFacts_Click);
            // 
            // btnShowReview
            // 
            this.btnShowReview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowReview.Location = new System.Drawing.Point(3, 39);
            this.btnShowReview.Name = "btnShowReview";
            this.btnShowReview.Size = new System.Drawing.Size(109, 23);
            this.btnShowReview.TabIndex = 10;
            this.btnShowReview.Text = "Текст отзыва";
            this.btnShowReview.UseVisualStyleBackColor = true;
            this.btnShowReview.Click += new System.EventHandler(this.btnShowReview_Click);
            // 
            // btnShowOntology
            // 
            this.btnShowOntology.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowOntology.Location = new System.Drawing.Point(3, 16);
            this.btnShowOntology.Name = "btnShowOntology";
            this.btnShowOntology.Size = new System.Drawing.Size(109, 23);
            this.btnShowOntology.TabIndex = 9;
            this.btnShowOntology.Text = "Онтология";
            this.btnShowOntology.UseVisualStyleBackColor = true;
            this.btnShowOntology.Click += new System.EventHandler(this.btnShowOntology_Click);
            // 
            // btnWindowsNormalize
            // 
            this.btnWindowsNormalize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWindowsNormalize.Location = new System.Drawing.Point(3, 16);
            this.btnWindowsNormalize.Name = "btnWindowsNormalize";
            this.btnWindowsNormalize.Size = new System.Drawing.Size(115, 23);
            this.btnWindowsNormalize.TabIndex = 0;
            this.btnWindowsNormalize.Text = "Упорядочить";
            this.btnWindowsNormalize.UseVisualStyleBackColor = true;
            this.btnWindowsNormalize.Click += new System.EventHandler(this.btnWindowsNormalize_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExtractFacts);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(121, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 212);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Извлечение фактов";
            // 
            // btnExtractFacts
            // 
            this.btnExtractFacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExtractFacts.Enabled = false;
            this.btnExtractFacts.Location = new System.Drawing.Point(3, 57);
            this.btnExtractFacts.Name = "btnExtractFacts";
            this.btnExtractFacts.Size = new System.Drawing.Size(174, 23);
            this.btnExtractFacts.TabIndex = 4;
            this.btnExtractFacts.Text = "Извлечь факты";
            this.btnExtractFacts.UseVisualStyleBackColor = true;
            this.btnExtractFacts.Click += new System.EventHandler(this.btnExtractFacts_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbSelectClass);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 41);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Корневой класс";
            // 
            // cbSelectClass
            // 
            this.cbSelectClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSelectClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectClass.FormattingEnabled = true;
            this.cbSelectClass.Location = new System.Drawing.Point(3, 16);
            this.cbSelectClass.Name = "cbSelectClass";
            this.cbSelectClass.Size = new System.Drawing.Size(168, 21);
            this.cbSelectClass.Sorted = true;
            this.cbSelectClass.TabIndex = 1;
            this.cbSelectClass.DropDown += new System.EventHandler(this.cbSelectClass_DropDown);
            this.cbSelectClass.SelectedValueChanged += new System.EventHandler(this.cbSelectClass_SelectedValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DeleteStopWord);
            this.groupBox5.Location = new System.Drawing.Point(304, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(155, 44);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Текст отзыва";
            // 
            // DeleteStopWord
            // 
            this.DeleteStopWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteStopWord.Location = new System.Drawing.Point(3, 16);
            this.DeleteStopWord.Name = "DeleteStopWord";
            this.DeleteStopWord.Size = new System.Drawing.Size(149, 23);
            this.DeleteStopWord.TabIndex = 0;
            this.DeleteStopWord.Text = "Удалить стоп-слова";
            this.DeleteStopWord.UseVisualStyleBackColor = true;
            this.DeleteStopWord.Click += new System.EventHandler(this.DeleteStopWord_Click);
            // 
            // btnShowStopWords
            // 
            this.btnShowStopWords.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowStopWords.Location = new System.Drawing.Point(3, 85);
            this.btnShowStopWords.Name = "btnShowStopWords";
            this.btnShowStopWords.Size = new System.Drawing.Size(109, 23);
            this.btnShowStopWords.TabIndex = 13;
            this.btnShowStopWords.Text = "Стоп-слова";
            this.btnShowStopWords.UseVisualStyleBackColor = true;
            this.btnShowStopWords.Click += new System.EventHandler(this.btnShowStopWords_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 212);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Параметры";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWindowsNormalize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowFacts;
        private System.Windows.Forms.Button btnShowReview;
        private System.Windows.Forms.Button btnShowOntology;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbSelectClass;
        private System.Windows.Forms.Button btnExtractFacts;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button DeleteStopWord;
        private System.Windows.Forms.Button btnShowStopWords;

    }
}