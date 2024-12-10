using System.ComponentModel;

namespace Tierheimverwaltung.Kennzeichnung
{
    partial class UCKennzeichnung
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCKennzeichnung));
            this.deleteButton = new System.Windows.Forms.Button();
            this.panelContainerKennz = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelContainerKennz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Teal;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(1581, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 72);
            this.deleteButton.TabIndex = 93;
            this.deleteButton.Text = "Daten Löschen";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // panelContainerKennz
            // 
            this.panelContainerKennz.Controls.Add(this.panel1);
            this.panelContainerKennz.Location = new System.Drawing.Point(492, 402);
            this.panelContainerKennz.Name = "panelContainerKennz";
            this.panelContainerKennz.Size = new System.Drawing.Size(819, 427);
            this.panelContainerKennz.TabIndex = 91;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(544, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 421);
            this.panel1.TabIndex = 0;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.updateButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(1472, 13);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(103, 72);
            this.updateButton.TabIndex = 92;
            this.updateButton.Text = "Daten Ändern";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.createButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(1369, 13);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(97, 72);
            this.createButton.TabIndex = 90;
            this.createButton.Text = "Neue Daten eingeben";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(588, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 301);
            this.dataGridView1.TabIndex = 89;
            // 
            // UCKennzeichnung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.panelContainerKennz);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCKennzeichnung";
            this.Size = new System.Drawing.Size(1700, 1100);
            this.panelContainerKennz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panelContainerKennz;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button createButton;
        public System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}