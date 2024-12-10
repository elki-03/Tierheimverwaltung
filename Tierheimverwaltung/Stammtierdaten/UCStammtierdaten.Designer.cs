using System.ComponentModel;

namespace Tierheimverwaltung
{
    partial class UCStammtierdaten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCStammtierdaten));
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelContainerStammt = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelContainerStammt.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Teal;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(1581, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 72);
            this.deleteButton.TabIndex = 83;
            this.deleteButton.Text = "Daten Löschen";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.updateButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(1472, 13);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(103, 72);
            this.updateButton.TabIndex = 82;
            this.updateButton.Text = "Daten Ändern";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.createButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(1369, 13);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(97, 72);
            this.createButton.TabIndex = 80;
            this.createButton.Text = "Neue Daten eingeben";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(84, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1549, 301);
            this.dataGridView1.TabIndex = 79;
            // 
            // panelContainerStammt
            // 
            this.panelContainerStammt.Controls.Add(this.panel1);
            this.panelContainerStammt.Location = new System.Drawing.Point(436, 397);
            this.panelContainerStammt.Name = "panelContainerStammt";
            this.panelContainerStammt.Size = new System.Drawing.Size(819, 427);
            this.panelContainerStammt.TabIndex = 81;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(42, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 424);
            this.panel1.TabIndex = 0;
            // 
            // UCStammtierdaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.panelContainerStammt);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCStammtierdaten";
            this.Size = new System.Drawing.Size(1700, 1100);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelContainerStammt.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panelContainerStammt;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button createButton;
        public System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}