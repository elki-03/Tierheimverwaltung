﻿using System.ComponentModel;

namespace Tierheimverwaltung.AufnahmeAbgabe
{
    partial class UCAufAbUpdateEingabeID
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
            this.textBoxUpdateID = new System.Windows.Forms.TextBox();
            this.buttonIDbestaetigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDatensatzID
            // 
            this.labelDatensatzID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.labelDatensatzID.Location = new System.Drawing.Point(174, 120);
            this.labelDatensatzID.Name = "labelDatensatzID";
            this.labelDatensatzID.Size = new System.Drawing.Size(458, 18);
            this.labelDatensatzID.TabIndex = 129;
            this.labelDatensatzID.Text = "Bitte geben Sie die Tier ID des Datensatzes ein, den Sie ändern möchten";
            // 
            // textBoxUpdateID
            // 
            this.textBoxUpdateID.Location = new System.Drawing.Point(256, 169);
            this.textBoxUpdateID.Name = "textBoxUpdateID";
            this.textBoxUpdateID.Size = new System.Drawing.Size(152, 20);
            this.textBoxUpdateID.TabIndex = 130;
            // 
            // buttonIDbestaetigen
            // 
            this.buttonIDbestaetigen.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonIDbestaetigen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonIDbestaetigen.ForeColor = System.Drawing.Color.White;
            this.buttonIDbestaetigen.Location = new System.Drawing.Point(414, 161);
            this.buttonIDbestaetigen.Name = "buttonIDbestaetigen";
            this.buttonIDbestaetigen.Size = new System.Drawing.Size(105, 34);
            this.buttonIDbestaetigen.TabIndex = 128;
            this.buttonIDbestaetigen.Text = "Bestätigen";
            this.buttonIDbestaetigen.UseVisualStyleBackColor = false;
            this.buttonIDbestaetigen.Click += new System.EventHandler(this.buttonIDbestaetigen_Click);
            // 
            // UCAufAbUpdateEingabeID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.labelDatensatzID);
            this.Controls.Add(this.textBoxUpdateID);
            this.Controls.Add(this.buttonIDbestaetigen);
            this.Name = "UCAufAbUpdateEingabeID";
            this.Size = new System.Drawing.Size(819, 427);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelDatensatzID;
        private System.Windows.Forms.TextBox textBoxUpdateID;
        private System.Windows.Forms.Button buttonIDbestaetigen;

        #endregion
    }
}