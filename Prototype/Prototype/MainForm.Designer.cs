namespace Prototype
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadOntology = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPathText = new System.Windows.Forms.TextBox();
            this.tbPathOntology = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPathText = new System.Windows.Forms.Button();
            this.btnPathOntology = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnWriteGraph = new System.Windows.Forms.Button();
            this.btnExtractFacts = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.cbSelectClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadOntology
            // 
            this.btnLoadOntology.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadOntology.Location = new System.Drawing.Point(3, 16);
            this.btnLoadOntology.Name = "btnLoadOntology";
            this.btnLoadOntology.Size = new System.Drawing.Size(194, 47);
            this.btnLoadOntology.TabIndex = 0;
            this.btnLoadOntology.Text = "Загрузить онтологию";
            this.btnLoadOntology.UseVisualStyleBackColor = true;
            this.btnLoadOntology.Click += new System.EventHandler(this.btnLoadOntology_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 66);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPathText);
            this.groupBox1.Controls.Add(this.tbPathOntology);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 66);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Онтология";
            // 
            // tbPathText
            // 
            this.tbPathText.Location = new System.Drawing.Point(3, 42);
            this.tbPathText.Name = "tbPathText";
            this.tbPathText.ReadOnly = true;
            this.tbPathText.Size = new System.Drawing.Size(549, 20);
            this.tbPathText.TabIndex = 9;
            // 
            // tbPathOntology
            // 
            this.tbPathOntology.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPathOntology.Location = new System.Drawing.Point(3, 16);
            this.tbPathOntology.Name = "tbPathOntology";
            this.tbPathOntology.ReadOnly = true;
            this.tbPathOntology.Size = new System.Drawing.Size(549, 20);
            this.tbPathOntology.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPathText);
            this.panel2.Controls.Add(this.btnPathOntology);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(552, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 47);
            this.panel2.TabIndex = 7;
            // 
            // btnPathText
            // 
            this.btnPathText.Location = new System.Drawing.Point(0, 25);
            this.btnPathText.Name = "btnPathText";
            this.btnPathText.Size = new System.Drawing.Size(29, 21);
            this.btnPathText.TabIndex = 0;
            this.btnPathText.Text = "...";
            this.btnPathText.UseVisualStyleBackColor = true;
            this.btnPathText.Click += new System.EventHandler(this.btnPathText_Click);
            // 
            // btnPathOntology
            // 
            this.btnPathOntology.Location = new System.Drawing.Point(0, 0);
            this.btnPathOntology.Name = "btnPathOntology";
            this.btnPathOntology.Size = new System.Drawing.Size(29, 21);
            this.btnPathOntology.TabIndex = 0;
            this.btnPathOntology.Text = "...";
            this.btnPathOntology.UseVisualStyleBackColor = true;
            this.btnPathOntology.Click += new System.EventHandler(this.btnPathOntology_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoadOntology);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(584, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 66);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Старт";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(378, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 36);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Очистить лог";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnWriteGraph
            // 
            this.btnWriteGraph.Enabled = false;
            this.btnWriteGraph.Location = new System.Drawing.Point(6, 19);
            this.btnWriteGraph.Name = "btnWriteGraph";
            this.btnWriteGraph.Size = new System.Drawing.Size(180, 36);
            this.btnWriteGraph.TabIndex = 9;
            this.btnWriteGraph.Text = "Вывести состав";
            this.btnWriteGraph.UseVisualStyleBackColor = true;
            this.btnWriteGraph.Click += new System.EventHandler(this.btnWriteGraph_Click);
            // 
            // btnExtractFacts
            // 
            this.btnExtractFacts.Enabled = false;
            this.btnExtractFacts.Location = new System.Drawing.Point(192, 19);
            this.btnExtractFacts.Name = "btnExtractFacts";
            this.btnExtractFacts.Size = new System.Drawing.Size(180, 36);
            this.btnExtractFacts.TabIndex = 11;
            this.btnExtractFacts.Text = "Извлечь факты";
            this.btnExtractFacts.UseVisualStyleBackColor = true;
            this.btnExtractFacts.Click += new System.EventHandler(this.btnExtractFacts_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 87);
            this.panel3.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cbSelectClass);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnExtractFacts);
            this.groupBox4.Controls.Add(this.btnWriteGraph);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(784, 87);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Управление";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(784, 405);
            this.panel4.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbLog);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 405);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Лог";
            // 
            // lbLog
            // 
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.HorizontalScrollbar = true;
            this.lbLog.Location = new System.Drawing.Point(3, 16);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(778, 386);
            this.lbLog.TabIndex = 0;
            // 
            // cbSelectClass
            // 
            this.cbSelectClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectClass.FormattingEnabled = true;
            this.cbSelectClass.Location = new System.Drawing.Point(101, 58);
            this.cbSelectClass.Name = "cbSelectClass";
            this.cbSelectClass.Size = new System.Drawing.Size(677, 21);
            this.cbSelectClass.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Корневой класс";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 558);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadOntology;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPathOntology;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPathOntology;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnWriteGraph;
        private System.Windows.Forms.Button btnExtractFacts;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbPathText;
        private System.Windows.Forms.Button btnPathText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectClass;

    }
}

