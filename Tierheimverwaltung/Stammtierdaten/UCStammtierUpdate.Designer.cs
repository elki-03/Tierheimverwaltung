using System.ComponentModel;

namespace Tierheimverwaltung
{
    partial class UCStammtierUpdate
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
            this.buttonIDbestaetigen = new System.Windows.Forms.Button();
            this.labelDatensatzID = new System.Windows.Forms.Label();
            this.textBoxEingabeUpdateID = new System.Windows.Forms.TextBox();
            this.panelContainerUp = new System.Windows.Forms.Panel();
            this.panelContainerUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonIDbestaetigen
            // 
            this.buttonIDbestaetigen.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonIDbestaetigen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonIDbestaetigen.ForeColor = System.Drawing.Color.White;
            this.buttonIDbestaetigen.Location = new System.Drawing.Point(470, 111);
            this.buttonIDbestaetigen.Name = "buttonIDbestaetigen";
            this.buttonIDbestaetigen.Size = new System.Drawing.Size(105, 44);
            this.buttonIDbestaetigen.TabIndex = 116;
            this.buttonIDbestaetigen.Text = "Bestätigen";
            this.buttonIDbestaetigen.UseVisualStyleBackColor = false;
            this.buttonIDbestaetigen.Click += new System.EventHandler(this.buttonIDbestaetigen_Click_1);
            // 
            // labelDatensatzID
            // 
            this.labelDatensatzID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.labelDatensatzID.Location = new System.Drawing.Point(243, 80);
            this.labelDatensatzID.Name = "labelDatensatzID";
            this.labelDatensatzID.Size = new System.Drawing.Size(418, 28);
            this.labelDatensatzID.TabIndex = 117;
            this.labelDatensatzID.Text = "Bitte geben Sie die ID des Datensatzes ein, den Sie ändern möchten";
            // 
            // textBoxEingabeUpdateID
            // 
            this.textBoxEingabeUpdateID.Location = new System.Drawing.Point(302, 135);
            this.textBoxEingabeUpdateID.Name = "textBoxEingabeUpdateID";
            this.textBoxEingabeUpdateID.Size = new System.Drawing.Size(152, 20);
            this.textBoxEingabeUpdateID.TabIndex = 118;
            // 
            // panelContainerUp
            // 
            this.panelContainerUp.Controls.Add(this.labelDatensatzID);
            this.panelContainerUp.Controls.Add(this.textBoxEingabeUpdateID);
            this.panelContainerUp.Controls.Add(this.buttonIDbestaetigen);
            this.panelContainerUp.Location = new System.Drawing.Point(0, 0);
            this.panelContainerUp.Name = "panelContainerUp";
            this.panelContainerUp.Size = new System.Drawing.Size(902, 424);
            this.panelContainerUp.TabIndex = 119;
            // 
            // UCStammtierUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.panelContainerUp);
            this.Name = "UCStammtierUpdate";
            this.Size = new System.Drawing.Size(902, 424);
            this.panelContainerUp.ResumeLayout(false);
            this.panelContainerUp.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelContainerUp;

        private System.Windows.Forms.TextBox textBoxEingabeUpdateID;

        private System.Windows.Forms.Button buttonIDbestaetigen;
        private System.Windows.Forms.Label labelDatensatzID;

        #endregion
    }
}