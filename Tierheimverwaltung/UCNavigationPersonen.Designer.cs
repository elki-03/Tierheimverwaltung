using System.ComponentModel;

namespace Tierheimverwaltung
{
    partial class UCNavigationPersonen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMitarbeiter = new System.Windows.Forms.Button();
            this.buttonEhrenamtliche = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonMitarbeiter);
            this.panel1.Controls.Add(this.buttonEhrenamtliche);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 30);
            this.panel1.TabIndex = 0;
            // 
            // buttonMitarbeiter
            // 
            this.buttonMitarbeiter.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMitarbeiter.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonMitarbeiter.Location = new System.Drawing.Point(212, 3);
            this.buttonMitarbeiter.Name = "buttonMitarbeiter";
            this.buttonMitarbeiter.Size = new System.Drawing.Size(139, 27);
            this.buttonMitarbeiter.TabIndex = 16;
            this.buttonMitarbeiter.Text = "Mitarbeiter";
            this.buttonMitarbeiter.UseVisualStyleBackColor = true;
            // 
            // buttonEhrenamtliche
            // 
            this.buttonEhrenamtliche.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEhrenamtliche.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonEhrenamtliche.Location = new System.Drawing.Point(357, 3);
            this.buttonEhrenamtliche.Name = "buttonEhrenamtliche";
            this.buttonEhrenamtliche.Size = new System.Drawing.Size(139, 27);
            this.buttonEhrenamtliche.TabIndex = 17;
            this.buttonEhrenamtliche.Text = "Ehrenamtliche";
            this.buttonEhrenamtliche.UseVisualStyleBackColor = true;
            // 
            // UCNavigationPersonen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCNavigationPersonen";
            this.Size = new System.Drawing.Size(1100, 30);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonMitarbeiter;
        private System.Windows.Forms.Button buttonEhrenamtliche;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}