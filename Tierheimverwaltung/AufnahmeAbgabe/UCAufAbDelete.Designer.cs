using System.ComponentModel;

namespace Tierheimverwaltung.AufnahmeAbgabe
{
    partial class UCAufAbDelete
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
            this.textBoxEingabeDeleteID = new System.Windows.Forms.TextBox();
            this.buttonIDbestaetigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDatensatzID
            // 
            this.labelDatensatzID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.labelDatensatzID.Location = new System.Drawing.Point(182, 116);
            this.labelDatensatzID.Name = "labelDatensatzID";
            this.labelDatensatzID.Size = new System.Drawing.Size(471, 18);
            this.labelDatensatzID.TabIndex = 132;
            this.labelDatensatzID.Text = "Bitte geben Sie die ID des Datensatzes ein, den Sie löschen möchten";
            // 
            // textBoxEingabeDeleteID
            // 
            this.textBoxEingabeDeleteID.Location = new System.Drawing.Point(279, 167);
            this.textBoxEingabeDeleteID.Name = "textBoxEingabeDeleteID";
            this.textBoxEingabeDeleteID.Size = new System.Drawing.Size(152, 20);
            this.textBoxEingabeDeleteID.TabIndex = 133;
            // 
            // buttonIDbestaetigen
            // 
            this.buttonIDbestaetigen.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonIDbestaetigen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonIDbestaetigen.ForeColor = System.Drawing.Color.White;
            this.buttonIDbestaetigen.Location = new System.Drawing.Point(437, 159);
            this.buttonIDbestaetigen.Name = "buttonIDbestaetigen";
            this.buttonIDbestaetigen.Size = new System.Drawing.Size(105, 34);
            this.buttonIDbestaetigen.TabIndex = 131;
            this.buttonIDbestaetigen.Text = "Bestätigen";
            this.buttonIDbestaetigen.UseVisualStyleBackColor = false;
            this.buttonIDbestaetigen.Click += new System.EventHandler(this.buttonIDbestaetigen_Click);
            // 
            // UCAufAbDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.labelDatensatzID);
            this.Controls.Add(this.textBoxEingabeDeleteID);
            this.Controls.Add(this.buttonIDbestaetigen);
            this.Name = "UCAufAbDelete";
            this.Size = new System.Drawing.Size(819, 427);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelDatensatzID;
        private System.Windows.Forms.TextBox textBoxEingabeDeleteID;
        private System.Windows.Forms.Button buttonIDbestaetigen;

        #endregion
    }
}