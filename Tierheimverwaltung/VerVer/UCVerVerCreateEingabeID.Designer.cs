using System.ComponentModel;

namespace Tierheimverwaltung.VerVer
{
    partial class UCVerVerCreateEingabeID
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
            this.labelDatensatzID = new System.Windows.Forms.Label();
            this.textBoxCreateID = new System.Windows.Forms.TextBox();
            this.buttonIDbestaetigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDatensatzID
            // 
            this.labelDatensatzID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.labelDatensatzID.ForeColor = System.Drawing.Color.Black;
            this.labelDatensatzID.Location = new System.Drawing.Point(143, 116);
            this.labelDatensatzID.Name = "labelDatensatzID";
            this.labelDatensatzID.Size = new System.Drawing.Size(470, 42);
            this.labelDatensatzID.TabIndex = 123;
            this.labelDatensatzID.Text = "Bitte geben Sie die ID des Datensatzes ein, zu der Sie das Verhalten und die Vert" + "räglichkeit erstellen möchten";
            // 
            // textBoxCreateID
            // 
            this.textBoxCreateID.Location = new System.Drawing.Point(231, 175);
            this.textBoxCreateID.Name = "textBoxCreateID";
            this.textBoxCreateID.Size = new System.Drawing.Size(152, 20);
            this.textBoxCreateID.TabIndex = 124;
            // 
            // buttonIDbestaetigen
            // 
            this.buttonIDbestaetigen.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonIDbestaetigen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonIDbestaetigen.ForeColor = System.Drawing.Color.White;
            this.buttonIDbestaetigen.Location = new System.Drawing.Point(401, 161);
            this.buttonIDbestaetigen.Name = "buttonIDbestaetigen";
            this.buttonIDbestaetigen.Size = new System.Drawing.Size(105, 34);
            this.buttonIDbestaetigen.TabIndex = 122;
            this.buttonIDbestaetigen.Text = "Bestätigen";
            this.buttonIDbestaetigen.UseVisualStyleBackColor = false;
            this.buttonIDbestaetigen.Click += new System.EventHandler(this.buttonIDbestaetigen_Click);
            // 
            // UCVerVerCreateEingabeID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.labelDatensatzID);
            this.Controls.Add(this.textBoxCreateID);
            this.Controls.Add(this.buttonIDbestaetigen);
            this.Name = "UCVerVerCreateEingabeID";
            this.Size = new System.Drawing.Size(819, 427);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelDatensatzID;
        private System.Windows.Forms.TextBox textBoxCreateID;
        private System.Windows.Forms.Button buttonIDbestaetigen;

        #endregion
    }
}