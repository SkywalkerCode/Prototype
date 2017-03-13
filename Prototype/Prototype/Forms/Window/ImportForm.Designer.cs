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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbGroup = new System.Windows.Forms.CheckBox();
            this.cbTopics = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDate = new System.Windows.Forms.RadioButton();
            this.rbRange = new System.Windows.Forms.RadioButton();
            this.dtpDateFinish = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbSpam = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRemoveSpam = new System.Windows.Forms.Button();
            this.btnAddSpam = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbSpam = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbQuery);
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 385);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Тексты запросов";
            // 
            // lbQuery
            // 
            this.lbQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbQuery.FormattingEnabled = true;
            this.lbQuery.Items.AddRange(new object[] {
            "Жилой комплекс"});
            this.lbQuery.Location = new System.Drawing.Point(3, 58);
            this.lbQuery.Name = "lbQuery";
            this.lbQuery.Size = new System.Drawing.Size(277, 324);
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
            this.panel3.Size = new System.Drawing.Size(277, 42);
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
            this.panel1.Size = new System.Drawing.Size(277, 20);
            this.panel1.TabIndex = 3;
            // 
            // tbNewQuery
            // 
            this.tbNewQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNewQuery.Location = new System.Drawing.Point(50, 0);
            this.tbNewQuery.Name = "tbNewQuery";
            this.tbNewQuery.Size = new System.Drawing.Size(227, 20);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 172);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры поиска";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbGroup);
            this.groupBox3.Controls.Add(this.cbTopics);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 63);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Контент";
            // 
            // cbGroup
            // 
            this.cbGroup.AutoSize = true;
            this.cbGroup.Checked = true;
            this.cbGroup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGroup.Location = new System.Drawing.Point(6, 19);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(118, 17);
            this.cbGroup.TabIndex = 10;
            this.cbGroup.Text = "Поиск по группам";
            this.cbGroup.UseVisualStyleBackColor = true;
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
            this.groupBox2.Size = new System.Drawing.Size(203, 92);
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
            this.dtpDate.Value = new System.DateTime(2017, 3, 13, 17, 7, 1, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(496, 385);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 23;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbSpam);
            this.groupBox5.Controls.Add(this.panel5);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 172);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(209, 213);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Спам-фильтр";
            // 
            // lbSpam
            // 
            this.lbSpam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSpam.FormattingEnabled = true;
            this.lbSpam.Location = new System.Drawing.Point(3, 58);
            this.lbSpam.Name = "lbSpam";
            this.lbSpam.Size = new System.Drawing.Size(203, 152);
            this.lbSpam.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnRemoveSpam);
            this.panel5.Controls.Add(this.btnAddSpam);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(203, 42);
            this.panel5.TabIndex = 4;
            // 
            // btnRemoveSpam
            // 
            this.btnRemoveSpam.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemoveSpam.Location = new System.Drawing.Point(92, 20);
            this.btnRemoveSpam.Name = "btnRemoveSpam";
            this.btnRemoveSpam.Size = new System.Drawing.Size(92, 22);
            this.btnRemoveSpam.TabIndex = 5;
            this.btnRemoveSpam.Text = "Удалить";
            this.btnRemoveSpam.UseVisualStyleBackColor = true;
            this.btnRemoveSpam.Click += new System.EventHandler(this.btnRemoveSpam_Click);
            // 
            // btnAddSpam
            // 
            this.btnAddSpam.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddSpam.Location = new System.Drawing.Point(0, 20);
            this.btnAddSpam.Name = "btnAddSpam";
            this.btnAddSpam.Size = new System.Drawing.Size(92, 22);
            this.btnAddSpam.TabIndex = 4;
            this.btnAddSpam.Text = "Добавить";
            this.btnAddSpam.UseVisualStyleBackColor = true;
            this.btnAddSpam.Click += new System.EventHandler(this.btnAddSpam_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbSpam);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(203, 20);
            this.panel6.TabIndex = 3;
            // 
            // tbSpam
            // 
            this.tbSpam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSpam.Location = new System.Drawing.Point(42, 0);
            this.tbSpam.Name = "tbSpam";
            this.tbSpam.Size = new System.Drawing.Size(161, 20);
            this.tbSpam.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(42, 20);
            this.panel7.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Спам:";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 385);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ImportForm";
            this.Text = "Импорт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportForm_FormClosing);
            this.groupBox4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbDate;
        private System.Windows.Forms.RadioButton rbRange;
        private System.Windows.Forms.DateTimePicker dtpDateFinish;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbGroup;
        private System.Windows.Forms.CheckBox cbTopics;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lbSpam;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRemoveSpam;
        private System.Windows.Forms.Button btnAddSpam;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbSpam;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;



    }
}