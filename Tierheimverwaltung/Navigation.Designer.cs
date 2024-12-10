using System.ComponentModel;

namespace Tierheimverwaltung
{
    partial class Navigation
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
            this.button7 = new System.Windows.Forms.Button();
            this.buttonKennzeichnung = new System.Windows.Forms.Button();
            this.buttonStammdaten = new System.Windows.Forms.Button();
            this.panelTierwaltungNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTierwaltungNavigation
            // 
            this.panelTierwaltungNavigation.Controls.Add(this.buttonAufnAbg);
            this.panelTierwaltungNavigation.Controls.Add(this.buttonVerhalten);
            this.panelTierwaltungNavigation.Controls.Add(this.button7);
            this.panelTierwaltungNavigation.Controls.Add(this.buttonKennzeichnung);
            this.panelTierwaltungNavigation.Controls.Add(this.buttonStammdaten);
            this.panelTierwaltungNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelTierwaltungNavigation.Name = "panelTierwaltungNavigation";
            this.panelTierwaltungNavigation.Size = new System.Drawing.Size(1100, 30);
            this.panelTierwaltungNavigation.TabIndex = 57;
            // 
            // buttonAufnAbg
            // 
            this.buttonAufnAbg.BackColor = System.Drawing.Color.Transparent;
            this.buttonAufnAbg.Location = new System.Drawing.Point(595, 3);
            this.buttonAufnAbg.Name = "buttonAufnAbg";
            this.buttonAufnAbg.Size = new System.Drawing.Size(142, 24);
            this.buttonAufnAbg.TabIndex = 93;
            this.buttonAufnAbg.Text = "Aufnahme/Abgabe";
            this.buttonAufnAbg.UseVisualStyleBackColor = false;
            // 
            // buttonVerhalten
            // 
            this.buttonVerhalten.BackColor = System.Drawing.Color.Transparent;
            this.buttonVerhalten.Location = new System.Drawing.Point(447, 4);
            this.buttonVerhalten.Name = "buttonVerhalten";
            this.buttonVerhalten.Size = new System.Drawing.Size(142, 25);
            this.buttonVerhalten.TabIndex = 92;
            this.buttonVerhalten.Text = "Verhalten u. Verträglichkeit";
            this.buttonVerhalten.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Location = new System.Drawing.Point(299, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(142, 21);
            this.button7.TabIndex = 91;
            this.button7.Text = "Medizinische Akte";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // buttonKennzeichnung
            // 
            this.buttonKennzeichnung.BackColor = System.Drawing.Color.Transparent;
            this.buttonKennzeichnung.Location = new System.Drawing.Point(151, 4);
            this.buttonKennzeichnung.Name = "buttonKennzeichnung";
            this.buttonKennzeichnung.Size = new System.Drawing.Size(142, 22);
            this.buttonKennzeichnung.TabIndex = 90;
            this.buttonKennzeichnung.Text = "Kennzeichnung";
            this.buttonKennzeichnung.UseVisualStyleBackColor = false;
            // 
            // buttonStammdaten
            // 
            this.buttonStammdaten.BackColor = System.Drawing.Color.Transparent;
            this.buttonStammdaten.Location = new System.Drawing.Point(3, 3);
            this.buttonStammdaten.Name = "buttonStammdaten";
            this.buttonStammdaten.Size = new System.Drawing.Size(142, 24);
            this.buttonStammdaten.TabIndex = 89;
            this.buttonStammdaten.Text = "Stammdaten";
            this.buttonStammdaten.UseVisualStyleBackColor = false;
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTierwaltungNavigation);
            this.Name = "Navigation";
            this.Size = new System.Drawing.Size(1100, 30);
            this.panelTierwaltungNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonAufnAbg;
        private System.Windows.Forms.Button buttonVerhalten;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonKennzeichnung;
        private System.Windows.Forms.Button buttonStammdaten;

        private System.Windows.Forms.Panel panelTierwaltungNavigation;

        #endregion
    }
}