namespace Tierheimverwaltung
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelContainerBig = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPersonen = new System.Windows.Forms.Button();
            this.buttonTierverwaltung = new System.Windows.Forms.Button();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.panelContainerBig.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainerBig
            // 
            this.panelContainerBig.BackColor = System.Drawing.Color.Transparent;
            this.panelContainerBig.Controls.Add(this.panel2);
            this.panelContainerBig.Controls.Add(this.label1);
            this.panelContainerBig.Location = new System.Drawing.Point(28, 99);
            this.panelContainerBig.Name = "panelContainerBig";
            this.panelContainerBig.Size = new System.Drawing.Size(1800, 1061);
            this.panelContainerBig.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(51, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 562);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(535, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 196);
            this.label1.TabIndex = 1;
            this.label1.Text = "Willkommen zur Tierheimverwaltung v. 0.1.0";
            // 
            // buttonPersonen
            // 
            this.buttonPersonen.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonPersonen.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersonen.ForeColor = System.Drawing.Color.SeaShell;
            this.buttonPersonen.Location = new System.Drawing.Point(237, 16);
            this.buttonPersonen.Name = "buttonPersonen";
            this.buttonPersonen.Size = new System.Drawing.Size(209, 42);
            this.buttonPersonen.TabIndex = 12;
            this.buttonPersonen.Text = "Personen";
            this.buttonPersonen.UseVisualStyleBackColor = false;
            this.buttonPersonen.Click += new System.EventHandler(this.buttonPersonen_Click);
            // 
            // buttonTierverwaltung
            // 
            this.buttonTierverwaltung.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonTierverwaltung.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTierverwaltung.ForeColor = System.Drawing.Color.MistyRose;
            this.buttonTierverwaltung.Location = new System.Drawing.Point(28, 16);
            this.buttonTierverwaltung.Name = "buttonTierverwaltung";
            this.buttonTierverwaltung.Size = new System.Drawing.Size(203, 42);
            this.buttonTierverwaltung.TabIndex = 11;
            this.buttonTierverwaltung.Text = "Tierverwaltung";
            this.buttonTierverwaltung.UseVisualStyleBackColor = false;
            this.buttonTierverwaltung.Click += new System.EventHandler(this.buttonTierverwaltung_Click);
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.Transparent;
            this.panelNavigation.Location = new System.Drawing.Point(28, 64);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(1087, 35);
            this.panelNavigation.TabIndex = 55;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1784, 1061);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelContainerBig);
            this.Controls.Add(this.buttonTierverwaltung);
            this.Controls.Add(this.buttonPersonen);
            this.Name = "Form1";
            this.Text = "Tierheimverwaltung v 0.1.0";
            this.panelContainerBig.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panelNavigation;

        private System.Windows.Forms.Button buttonPersonen;
        private System.Windows.Forms.Button buttonTierverwaltung;

        public System.Windows.Forms.Panel panelContainerBig;

        #endregion
    }
}