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
            this.btnShowStopWords = new System.Windows.Forms.Button();
            this.btnShowFacts = new System.Windows.Forms.Button();
            this.btnShowReview = new System.Windows.Forms.Button();
            this.btnShowOntology = new System.Windows.Forms.Button();
            this.btnWindowsNormalize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDeleteStopWord = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExtractFacts = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbSelectClass = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnConnecting = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbCurrentDataBase = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbTableReview = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnWindowsNormalize);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 217);
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
            this.groupBox2.Size = new System.Drawing.Size(135, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Показать/скрыть";
            // 
            // btnShowStopWords
            // 
            this.btnShowStopWords.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowStopWords.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowStopWords.Location = new System.Drawing.Point(3, 85);
            this.btnShowStopWords.Name = "btnShowStopWords";
            this.btnShowStopWords.Size = new System.Drawing.Size(129, 23);
            this.btnShowStopWords.TabIndex = 13;
            this.btnShowStopWords.Text = "Стоп-слова";
            this.btnShowStopWords.UseVisualStyleBackColor = true;
            this.btnShowStopWords.Click += new System.EventHandler(this.btnShowStopWords_Click);
            // 
            // btnShowFacts
            // 
            this.btnShowFacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowFacts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowFacts.Location = new System.Drawing.Point(3, 62);
            this.btnShowFacts.Name = "btnShowFacts";
            this.btnShowFacts.Size = new System.Drawing.Size(129, 23);
            this.btnShowFacts.TabIndex = 11;
            this.btnShowFacts.Text = "Факты";
            this.btnShowFacts.UseVisualStyleBackColor = true;
            this.btnShowFacts.Click += new System.EventHandler(this.btnShowFacts_Click);
            // 
            // btnShowReview
            // 
            this.btnShowReview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowReview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowReview.Location = new System.Drawing.Point(3, 39);
            this.btnShowReview.Name = "btnShowReview";
            this.btnShowReview.Size = new System.Drawing.Size(129, 23);
            this.btnShowReview.TabIndex = 10;
            this.btnShowReview.Text = "Текст отзыва";
            this.btnShowReview.UseVisualStyleBackColor = true;
            this.btnShowReview.Click += new System.EventHandler(this.btnShowReview_Click);
            // 
            // btnShowOntology
            // 
            this.btnShowOntology.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowOntology.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowOntology.Location = new System.Drawing.Point(3, 16);
            this.btnShowOntology.Name = "btnShowOntology";
            this.btnShowOntology.Size = new System.Drawing.Size(129, 23);
            this.btnShowOntology.TabIndex = 9;
            this.btnShowOntology.Text = "Онтология";
            this.btnShowOntology.UseVisualStyleBackColor = true;
            this.btnShowOntology.Click += new System.EventHandler(this.btnShowOntology_Click);
            // 
            // btnWindowsNormalize
            // 
            this.btnWindowsNormalize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWindowsNormalize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWindowsNormalize.Location = new System.Drawing.Point(3, 16);
            this.btnWindowsNormalize.Name = "btnWindowsNormalize";
            this.btnWindowsNormalize.Size = new System.Drawing.Size(135, 23);
            this.btnWindowsNormalize.TabIndex = 0;
            this.btnWindowsNormalize.Text = "Упорядочить";
            this.btnWindowsNormalize.UseVisualStyleBackColor = true;
            this.btnWindowsNormalize.Click += new System.EventHandler(this.btnWindowsNormalize_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox10);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(141, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 217);
            this.panel1.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDeleteStopWord);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox5.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox5.Location = new System.Drawing.Point(0, 90);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 44);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Текст отзыва";
            // 
            // btnDeleteStopWord
            // 
            this.btnDeleteStopWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteStopWord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteStopWord.Location = new System.Drawing.Point(3, 16);
            this.btnDeleteStopWord.Name = "btnDeleteStopWord";
            this.btnDeleteStopWord.Size = new System.Drawing.Size(174, 23);
            this.btnDeleteStopWord.TabIndex = 0;
            this.btnDeleteStopWord.Text = "Удалить стоп-слова";
            this.btnDeleteStopWord.UseVisualStyleBackColor = true;
            this.btnDeleteStopWord.Click += new System.EventHandler(this.btnDeleteStopWord_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExtractFacts);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 90);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Извлечение фактов";
            // 
            // btnExtractFacts
            // 
            this.btnExtractFacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExtractFacts.Enabled = false;
            this.btnExtractFacts.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.groupBox4.Text = "Корневой класс онтологии";
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
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Controls.Add(this.lStatus);
            this.groupBox9.Controls.Add(this.btnConnecting);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox9.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox9.Location = new System.Drawing.Point(0, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(227, 64);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Подключение к БД";
            // 
            // btnConnecting
            // 
            this.btnConnecting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConnecting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConnecting.Location = new System.Drawing.Point(3, 16);
            this.btnConnecting.Name = "btnConnecting";
            this.btnConnecting.Size = new System.Drawing.Size(221, 23);
            this.btnConnecting.TabIndex = 17;
            this.btnConnecting.Text = "Подключиться к серверу";
            this.btnConnecting.UseVisualStyleBackColor = true;
            this.btnConnecting.Click += new System.EventHandler(this.btnConnecting_Click);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.ForeColor = System.Drawing.Color.Red;
            this.lStatus.Location = new System.Drawing.Point(56, 42);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(85, 13);
            this.lStatus.TabIndex = 18;
            this.lStatus.Text = "Не подключено";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Статус:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnExport);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox6.Location = new System.Drawing.Point(0, 64);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(227, 124);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Экспорт фактов в БД";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbCurrentDataBase);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(3, 16);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(221, 41);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "База данных";
            // 
            // cbCurrentDataBase
            // 
            this.cbCurrentDataBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCurrentDataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrentDataBase.FormattingEnabled = true;
            this.cbCurrentDataBase.Location = new System.Drawing.Point(3, 16);
            this.cbCurrentDataBase.Name = "cbCurrentDataBase";
            this.cbCurrentDataBase.Size = new System.Drawing.Size(215, 21);
            this.cbCurrentDataBase.TabIndex = 2;
            this.cbCurrentDataBase.TextChanged += new System.EventHandler(this.cbCurrentDataBase_TextChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbTableReview);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Location = new System.Drawing.Point(3, 57);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(221, 41);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Таблица для отзыва";
            // 
            // cbTableReview
            // 
            this.cbTableReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTableReview.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTableReview.FormattingEnabled = true;
            this.cbTableReview.Location = new System.Drawing.Point(3, 16);
            this.cbTableReview.Name = "cbTableReview";
            this.cbTableReview.Size = new System.Drawing.Size(215, 21);
            this.cbTableReview.TabIndex = 2;
            this.cbTableReview.SelectedIndexChanged += new System.EventHandler(this.cbTableReview_SelectedIndexChanged);
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExport.Enabled = false;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExport.Location = new System.Drawing.Point(3, 98);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(221, 23);
            this.btnExport.TabIndex = 21;
            this.btnExport.Text = "Экспортировать факты";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.groupBox9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(321, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 217);
            this.panel2.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(3, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выход из программы";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnExit);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox10.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox10.Location = new System.Drawing.Point(0, 134);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(180, 43);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Завершение работы";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 217);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Управление";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWindowsNormalize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowFacts;
        private System.Windows.Forms.Button btnShowReview;
        private System.Windows.Forms.Button btnShowOntology;
        private System.Windows.Forms.Button btnShowStopWords;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExtractFacts;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbSelectClass;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDeleteStopWord;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Button btnConnecting;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cbTableReview;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cbCurrentDataBase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnExit;

    }
}