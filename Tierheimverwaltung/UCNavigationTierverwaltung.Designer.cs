using System.ComponentModel;

namespace Tierheimverwaltung
{
    partial class UCNavigationTierverwaltung
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
            this.panelTierwaltungNavigation = new System.Windows.Forms.Panel();
            this.buttonAufnAbg = new System.Windows.Forms.Button();
            this.buttonVerhalten = new System.Windows.Forms.Button();
            this.buttonMedizinischeAkte = new System.Windows.Forms.Button();
            this.buttonKennzeichnung = new System.Windows.Forms.Button();
            this.buttonStammdaten = new System.Windows.Forms.Button();
            this.panelTierwaltungNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTierwaltungNavigation
            // 
            this.panelTierwaltungNavigation.Controls.Add(this.buttonAufnAbg);
            this.panelTierwaltungNavigation.Controls.Add(this.buttonVerhalten);
            this.panelTierwaltungNavigation.Controls.Add(this.buttonMedizinischeAkte);
            this.panelTierwaltungNavigation.Controls.Add(this.buttonKennzeichnung);
            this.panelTierwaltungNavigation.Controls.Add(this.buttonStammdaten);
            this.panelTierwaltungNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelTierwaltungNavigation.Name = "panelTierwaltungNavigation";
            this.panelTierwaltungNavigation.Size = new System.Drawing.Size(1283, 35);
            this.panelTierwaltungNavigation.TabIndex = 58;
            // 
            // buttonAufnAbg
            // 
            this.buttonAufnAbg.BackColor = System.Drawing.Color.Transparent;
            this.buttonAufnAbg.Location = new System.Drawing.Point(611, 3);
            this.buttonAufnAbg.Name = "buttonAufnAbg";
            this.buttonAufnAbg.Size = new System.Drawing.Size(139, 27);
            this.buttonAufnAbg.TabIndex = 93;
            this.buttonAufnAbg.Text = "Aufnahme/Abgabe";
            this.buttonAufnAbg.UseVisualStyleBackColor = false;
            this.buttonAufnAbg.Click += new System.EventHandler(this.buttonAufnAbg_Click);
            // 
            // buttonVerhalten
            // 
            this.buttonVerhalten.BackColor = System.Drawing.Color.Transparent;
            this.buttonVerhalten.Location = new System.Drawing.Point(438, 3);
            this.buttonVerhalten.Name = "buttonVerhalten";
            this.buttonVerhalten.Size = new System.Drawing.Size(167, 27);
            this.buttonVerhalten.TabIndex = 92;
            this.buttonVerhalten.Text = "Verhalten u. Verträglichkeit";
            this.buttonVerhalten.UseVisualStyleBackColor = false;
            this.buttonVerhalten.Click += new System.EventHandler(this.buttonVerhalten_Click);
            // 
            // buttonMedizinischeAkte
            // 
            this.buttonMedizinischeAkte.BackColor = System.Drawing.Color.Transparent;
            this.buttonMedizinischeAkte.Location = new System.Drawing.Point(293, 3);
            this.buttonMedizinischeAkte.Name = "buttonMedizinischeAkte";
            this.buttonMedizinischeAkte.Size = new System.Drawing.Size(139, 27);
            this.buttonMedizinischeAkte.TabIndex = 91;
            this.buttonMedizinischeAkte.Text = "Medizinische Akte";
            this.buttonMedizinischeAkte.UseVisualStyleBackColor = false;
            this.buttonMedizinischeAkte.Click += new System.EventHandler(this.buttonMedizinischeAkte_Click);
            // 
            // buttonKennzeichnung
            // 
            this.buttonKennzeichnung.BackColor = System.Drawing.Color.Transparent;
            this.buttonKennzeichnung.Location = new System.Drawing.Point(148, 3);
            this.buttonKennzeichnung.Name = "buttonKennzeichnung";
            this.buttonKennzeichnung.Size = new System.Drawing.Size(139, 27);
            this.buttonKennzeichnung.TabIndex = 90;
            this.buttonKennzeichnung.Text = "Kennzeichnung";
            this.buttonKennzeichnung.UseVisualStyleBackColor = false;
            this.buttonKennzeichnung.Click += new System.EventHandler(this.buttonKennzeichnung_Click);
            // 
            // buttonStammdaten
            // 
            this.buttonStammdaten.BackColor = System.Drawing.Color.Transparent;
            this.buttonStammdaten.Location = new System.Drawing.Point(3, 3);
            this.buttonStammdaten.Name = "buttonStammdaten";
            this.buttonStammdaten.Size = new System.Drawing.Size(139, 27);
            this.buttonStammdaten.TabIndex = 89;
            this.buttonStammdaten.Text = "Stammdaten";
            this.buttonStammdaten.UseVisualStyleBackColor = false;
            this.buttonStammdaten.Click += new System.EventHandler(this.buttonStammdaten_Click);
            // 
            // UCNavigationTierverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTierwaltungNavigation);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Name = "UCNavigationTierverwaltung";
            this.Size = new System.Drawing.Size(1283, 35);
            this.panelTierwaltungNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTierwaltungNavigation;
        private System.Windows.Forms.Button buttonAufnAbg;
        private System.Windows.Forms.Button buttonVerhalten;
        private System.Windows.Forms.Button buttonMedizinischeAkte;
        private System.Windows.Forms.Button buttonKennzeichnung;
        private System.Windows.Forms.Button buttonStammdaten;

        #endregion
    }
}