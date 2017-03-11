namespace Prototype.Forms.Dialog
{
    partial class AutorizationSocialNetworkForm
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
            this.btnConnectSelect = new System.Windows.Forms.Button();
            this.btnConnectAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvNetworks = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnectSelect
            // 
            this.btnConnectSelect.Location = new System.Drawing.Point(3, 3);
            this.btnConnectSelect.Name = "btnConnectSelect";
            this.btnConnectSelect.Size = new System.Drawing.Size(100, 23);
            this.btnConnectSelect.TabIndex = 1;
            this.btnConnectSelect.Text = "Подключить";
            this.btnConnectSelect.UseVisualStyleBackColor = true;
            this.btnConnectSelect.Click += new System.EventHandler(this.btnConnectSelect_Click);
            // 
            // btnConnectAll
            // 
            this.btnConnectAll.Location = new System.Drawing.Point(109, 3);
            this.btnConnectAll.Name = "btnConnectAll";
            this.btnConnectAll.Size = new System.Drawing.Size(100, 23);
            this.btnConnectAll.TabIndex = 1;
            this.btnConnectAll.Text = "Подключить всё";
            this.btnConnectAll.UseVisualStyleBackColor = true;
            this.btnConnectAll.Click += new System.EventHandler(this.btnConnectAll_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConnectSelect);
            this.panel1.Controls.Add(this.btnConnectAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 30);
            this.panel1.TabIndex = 2;
            // 
            // lvNetworks
            // 
            this.lvNetworks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNetworks.FullRowSelect = true;
            this.lvNetworks.Location = new System.Drawing.Point(0, 30);
            this.lvNetworks.Name = "lvNetworks";
            this.lvNetworks.Size = new System.Drawing.Size(253, 243);
            this.lvNetworks.TabIndex = 3;
            this.lvNetworks.UseCompatibleStateImageBehavior = false;
            this.lvNetworks.View = System.Windows.Forms.View.Details;
            // 
            // AutorizationSocialNetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 273);
            this.Controls.Add(this.lvNetworks);
            this.Controls.Add(this.panel1);
            this.Name = "AutorizationSocialNetworkForm";
            this.Text = "Авторизация";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnectSelect;
        private System.Windows.Forms.Button btnConnectAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvNetworks;

    }
}