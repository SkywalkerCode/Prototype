namespace Prototype.Forms.Window
{
    partial class ImportForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbQuery = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteSelectQuery = new System.Windows.Forms.Button();
            this.btnAddQuery = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbNewQuery = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDiscussions = new System.Windows.Forms.CheckBox();
            this.cbTopics = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDate = new System.Windows.Forms.RadioButton();
            this.rbRange = new System.Windows.Forms.RadioButton();
            this.dtpDateFinish = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbQuery);
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(201, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 197);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Тексты запросов";
            // 
            // lbQuery
            // 
            this.lbQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbQuery.FormattingEnabled = true;
            this.lbQuery.Location = new System.Drawing.Point(3, 58);
            this.lbQuery.Name = "lbQuery";
            this.lbQuery.Size = new System.Drawing.Size(193, 136);
            this.lbQuery.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeleteSelectQuery);
            this.panel3.Controls.Add(this.btnAddQuery);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 42);
            this.panel3.TabIndex = 4;
            // 
            // btnDeleteSelectQuery
            // 
            this.btnDeleteSelectQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteSelectQuery.Location = new System.Drawing.Point(92, 20);
            this.btnDeleteSelectQuery.Name = "btnDeleteSelectQuery";
            this.btnDeleteSelectQuery.Size = new System.Drawing.Size(92, 22);
            this.btnDeleteSelectQuery.TabIndex = 5;
            this.btnDeleteSelectQuery.Text = "Удалить";
            this.btnDeleteSelectQuery.UseVisualStyleBackColor = true;
            this.btnDeleteSelectQuery.Click += new System.EventHandler(this.btnDeleteSelectQuery_Click);
            // 
            // btnAddQuery
            // 
            this.btnAddQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddQuery.Location = new System.Drawing.Point(0, 20);
            this.btnAddQuery.Name = "btnAddQuery";
            this.btnAddQuery.Size = new System.Drawing.Size(92, 22);
            this.btnAddQuery.TabIndex = 4;
            this.btnAddQuery.Text = "Добавить";
            this.btnAddQuery.UseVisualStyleBackColor = true;
            this.btnAddQuery.Click += new System.EventHandler(this.btnAddQuery_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbNewQuery);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 20);
            this.panel1.TabIndex = 3;
            // 
            // tbNewQuery
            // 
            this.tbNewQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNewQuery.Location = new System.Drawing.Point(50, 0);
            this.tbNewQuery.Name = "tbNewQuery";
            this.tbNewQuery.Size = new System.Drawing.Size(143, 20);
            this.tbNewQuery.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 20);
            this.panel2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Запрос:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 197);
            this.panel4.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 197);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры поиска";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbDiscussions);
            this.groupBox3.Controls.Add(this.cbTopics);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 63);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Контент";
            // 
            // cbDiscussions
            // 
            this.cbDiscussions.AutoSize = true;
            this.cbDiscussions.Checked = true;
            this.cbDiscussions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDiscussions.Location = new System.Drawing.Point(6, 19);
            this.cbDiscussions.Name = "cbDiscussions";
            this.cbDiscussions.Size = new System.Drawing.Size(145, 17);
            this.cbDiscussions.TabIndex = 10;
            this.cbDiscussions.Text = "Поиск по обсуждениям";
            this.cbDiscussions.UseVisualStyleBackColor = true;
            // 
            // cbTopics
            // 
            this.cbTopics.AutoSize = true;
            this.cbTopics.Checked = true;
            this.cbTopics.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTopics.Location = new System.Drawing.Point(6, 42);
            this.cbTopics.Name = "cbTopics";
            this.cbTopics.Size = new System.Drawing.Size(113, 17);
            this.cbTopics.TabIndex = 9;
            this.cbTopics.Text = "Поиск по постам";
            this.cbTopics.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rbDate);
            this.groupBox2.Controls.Add(this.rbRange);
            this.groupBox2.Controls.Add(this.dtpDateFinish);
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 92);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Временной диапазон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Конец:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Начало:";
            // 
            // rbDate
            // 
            this.rbDate.AutoSize = true;
            this.rbDate.Checked = true;
            this.rbDate.Location = new System.Drawing.Point(55, 71);
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(51, 17);
            this.rbDate.TabIndex = 10;
            this.rbDate.TabStop = true;
            this.rbDate.Text = "Дата";
            this.rbDate.UseVisualStyleBackColor = true;
            this.rbDate.CheckedChanged += new System.EventHandler(this.ChangeDateTypeSearch);
            // 
            // rbRange
            // 
            this.rbRange.AutoSize = true;
            this.rbRange.Location = new System.Drawing.Point(116, 71);
            this.rbRange.Name = "rbRange";
            this.rbRange.Size = new System.Drawing.Size(76, 17);
            this.rbRange.TabIndex = 9;
            this.rbRange.Text = "Диапазон";
            this.rbRange.UseVisualStyleBackColor = true;
            this.rbRange.CheckedChanged += new System.EventHandler(this.ChangeDateTypeSearch);
            // 
            // dtpDateFinish
            // 
            this.dtpDateFinish.Enabled = false;
            this.dtpDateFinish.Location = new System.Drawing.Point(55, 45);
            this.dtpDateFinish.Name = "dtpDateFinish";
            this.dtpDateFinish.Size = new System.Drawing.Size(137, 20);
            this.dtpDateFinish.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(55, 19);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(137, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 197);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel4);
            this.Name = "ImportForm";
            this.Text = "Импорт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportForm_FormClosing);
            this.groupBox4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbQuery;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteSelectQuery;
        private System.Windows.Forms.Button btnAddQuery;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbNewQuery;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbDate;
        private System.Windows.Forms.RadioButton rbRange;
        private System.Windows.Forms.DateTimePicker dtpDateFinish;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbDiscussions;
        private System.Windows.Forms.CheckBox cbTopics;



    }
}