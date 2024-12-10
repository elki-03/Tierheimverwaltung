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
            this.panelContainerBig = new System.Windows.Forms.Panel();
            this.buttonEhrenamtliche = new System.Windows.Forms.Button();
            this.buttonMitarbeiter = new System.Windows.Forms.Button();
            this.buttonPersonen = new System.Windows.Forms.Button();
            this.buttonTierverwaltung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelContainerBig
            // 
            this.panelContainerBig.Location = new System.Drawing.Point(28, 60);
            this.panelContainerBig.Name = "panelContainerBig";
            this.panelContainerBig.Size = new System.Drawing.Size(1800, 1100);
            this.panelContainerBig.TabIndex = 54;
            // 
            // buttonEhrenamtliche
            // 
            this.buttonEhrenamtliche.Location = new System.Drawing.Point(968, 33);
            this.buttonEhrenamtliche.Name = "buttonEhrenamtliche";
            this.buttonEhrenamtliche.Size = new System.Drawing.Size(139, 21);
            this.buttonEhrenamtliche.TabIndex = 15;
            this.buttonEhrenamtliche.Text = "Ehrenamtliche";
            this.buttonEhrenamtliche.UseVisualStyleBackColor = true;
            // 
            // buttonMitarbeiter
            // 
            this.buttonMitarbeiter.Location = new System.Drawing.Point(823, 30);
            this.buttonMitarbeiter.Name = "buttonMitarbeiter";
            this.buttonMitarbeiter.Size = new System.Drawing.Size(139, 24);
            this.buttonMitarbeiter.TabIndex = 14;
            this.buttonMitarbeiter.Text = "Mitarbeiter";
            this.buttonMitarbeiter.UseVisualStyleBackColor = true;
            // 
            // buttonPersonen
            // 
            this.buttonPersonen.Location = new System.Drawing.Point(261, 12);
            this.buttonPersonen.Name = "buttonPersonen";
            this.buttonPersonen.Size = new System.Drawing.Size(209, 42);
            this.buttonPersonen.TabIndex = 12;
            this.buttonPersonen.Text = "Personen";
            this.buttonPersonen.UseVisualStyleBackColor = true;
            // 
            // buttonTierverwaltung
            // 
            this.buttonTierverwaltung.Location = new System.Drawing.Point(42, 12);
            this.buttonTierverwaltung.Name = "buttonTierverwaltung";
            this.buttonTierverwaltung.Size = new System.Drawing.Size(203, 42);
            this.buttonTierverwaltung.TabIndex = 11;
            this.buttonTierverwaltung.Text = "Tierverwaltung";
            this.buttonTierverwaltung.UseVisualStyleBackColor = true;
            this.buttonTierverwaltung.Click += new System.EventHandler(this.buttonTierverwaltung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1784, 1061);
            this.Controls.Add(this.panelContainerBig);
            this.Controls.Add(this.buttonTierverwaltung);
            this.Controls.Add(this.buttonPersonen);
            this.Controls.Add(this.buttonMitarbeiter);
            this.Controls.Add(this.buttonEhrenamtliche);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonEhrenamtliche;
        private System.Windows.Forms.Button buttonMitarbeiter;
        private System.Windows.Forms.Button buttonPersonen;
        private System.Windows.Forms.Button buttonTierverwaltung;

        private System.Windows.Forms.Panel panelContainerBig;

        #endregion
    }
}