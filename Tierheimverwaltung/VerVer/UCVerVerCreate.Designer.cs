using System.ComponentModel;

namespace Tierheimverwaltung.VerVer
{
    partial class UCVerVerCreate
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
            this.labelTierIDVerVer = new System.Windows.Forms.Label();
            this.buttonSaveCreateMedAkte = new System.Windows.Forms.Button();
            this.labelPate = new System.Windows.Forms.Label();
            this.labelzustPerson_id = new System.Windows.Forms.Label();
            this.labelVertraeglichkeitNo = new System.Windows.Forms.Label();
            this.labelVerhaltenNo = new System.Windows.Forms.Label();
            this.zustPerson_idtb = new System.Windows.Forms.TextBox();
            this.vertraeglichkeitNotb = new System.Windows.Forms.TextBox();
            this.verhaltenNotb = new System.Windows.Forms.TextBox();
            this.labelTierID = new System.Windows.Forms.Label();
            this.patetb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTierIDVerVer
            // 
            this.labelTierIDVerVer.ForeColor = System.Drawing.Color.White;
            this.labelTierIDVerVer.Location = new System.Drawing.Point(339, 71);
            this.labelTierIDVerVer.Name = "labelTierIDVerVer";
            this.labelTierIDVerVer.Size = new System.Drawing.Size(164, 23);
            this.labelTierIDVerVer.TabIndex = 186;
            // 
            // buttonSaveCreateMedAkte
            // 
            this.buttonSaveCreateMedAkte.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonSaveCreateMedAkte.Location = new System.Drawing.Point(541, 41);
            this.buttonSaveCreateMedAkte.Name = "buttonSaveCreateMedAkte";
            this.buttonSaveCreateMedAkte.Size = new System.Drawing.Size(88, 53);
            this.buttonSaveCreateMedAkte.TabIndex = 179;
            this.buttonSaveCreateMedAkte.Text = "Save";
            this.buttonSaveCreateMedAkte.UseVisualStyleBackColor = true;
            this.buttonSaveCreateMedAkte.Click += new System.EventHandler(this.buttonSaveCreateMedAkte_Click);
            // 
            // labelPate
            // 
            this.labelPate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelPate.ForeColor = System.Drawing.Color.White;
            this.labelPate.Location = new System.Drawing.Point(200, 222);
            this.labelPate.Name = "labelPate";
            this.labelPate.Size = new System.Drawing.Size(106, 22);
            this.labelPate.TabIndex = 178;
            this.labelPate.Text = "Pate";
            // 
            // labelzustPerson_id
            // 
            this.labelzustPerson_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelzustPerson_id.ForeColor = System.Drawing.Color.White;
            this.labelzustPerson_id.Location = new System.Drawing.Point(200, 177);
            this.labelzustPerson_id.Name = "labelzustPerson_id";
            this.labelzustPerson_id.Size = new System.Drawing.Size(106, 22);
            this.labelzustPerson_id.TabIndex = 177;
            this.labelzustPerson_id.Text = "zustPerson_id";
            // 
            // labelVertraeglichkeitNo
            // 
            this.labelVertraeglichkeitNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelVertraeglichkeitNo.ForeColor = System.Drawing.Color.White;
            this.labelVertraeglichkeitNo.Location = new System.Drawing.Point(200, 141);
            this.labelVertraeglichkeitNo.Name = "labelVertraeglichkeitNo";
            this.labelVertraeglichkeitNo.Size = new System.Drawing.Size(133, 22);
            this.labelVertraeglichkeitNo.TabIndex = 176;
            this.labelVertraeglichkeitNo.Text = "Verträglichkeit Notizen";
            // 
            // labelVerhaltenNo
            // 
            this.labelVerhaltenNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelVerhaltenNo.ForeColor = System.Drawing.Color.White;
            this.labelVerhaltenNo.Location = new System.Drawing.Point(200, 106);
            this.labelVerhaltenNo.Name = "labelVerhaltenNo";
            this.labelVerhaltenNo.Size = new System.Drawing.Size(120, 22);
            this.labelVerhaltenNo.TabIndex = 175;
            this.labelVerhaltenNo.Text = "Verhalten Notizen";
            // 
            // zustPerson_idtb
            // 
            this.zustPerson_idtb.Location = new System.Drawing.Point(339, 181);
            this.zustPerson_idtb.Name = "zustPerson_idtb";
            this.zustPerson_idtb.Size = new System.Drawing.Size(164, 20);
            this.zustPerson_idtb.TabIndex = 174;
            // 
            // vertraeglichkeitNotb
            // 
            this.vertraeglichkeitNotb.Location = new System.Drawing.Point(339, 143);
            this.vertraeglichkeitNotb.Name = "vertraeglichkeitNotb";
            this.vertraeglichkeitNotb.Size = new System.Drawing.Size(164, 20);
            this.vertraeglichkeitNotb.TabIndex = 173;
            // 
            // verhaltenNotb
            // 
            this.verhaltenNotb.Location = new System.Drawing.Point(339, 108);
            this.verhaltenNotb.Name = "verhaltenNotb";
            this.verhaltenNotb.Size = new System.Drawing.Size(164, 20);
            this.verhaltenNotb.TabIndex = 172;
            // 
            // labelTierID
            // 
            this.labelTierID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelTierID.ForeColor = System.Drawing.Color.White;
            this.labelTierID.Location = new System.Drawing.Point(200, 71);
            this.labelTierID.Name = "labelTierID";
            this.labelTierID.Size = new System.Drawing.Size(106, 23);
            this.labelTierID.TabIndex = 171;
            this.labelTierID.Text = "Tier ID";
            // 
            // patetb
            // 
            this.patetb.Location = new System.Drawing.Point(339, 224);
            this.patetb.Name = "patetb";
            this.patetb.Size = new System.Drawing.Size(164, 20);
            this.patetb.TabIndex = 170;
            // 
            // UCVerVerCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.labelTierIDVerVer);
            this.Controls.Add(this.buttonSaveCreateMedAkte);
            this.Controls.Add(this.labelPate);
            this.Controls.Add(this.labelzustPerson_id);
            this.Controls.Add(this.labelVertraeglichkeitNo);
            this.Controls.Add(this.labelVerhaltenNo);
            this.Controls.Add(this.zustPerson_idtb);
            this.Controls.Add(this.vertraeglichkeitNotb);
            this.Controls.Add(this.verhaltenNotb);
            this.Controls.Add(this.labelTierID);
            this.Controls.Add(this.patetb);
            this.Name = "UCVerVerCreate";
            this.Size = new System.Drawing.Size(819, 427);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTierIDVerVer;
        private System.Windows.Forms.Button buttonSaveCreateMedAkte;
        private System.Windows.Forms.Label labelPate;
        private System.Windows.Forms.Label labelzustPerson_id;
        private System.Windows.Forms.Label labelVertraeglichkeitNo;
        private System.Windows.Forms.Label labelVerhaltenNo;
        private System.Windows.Forms.TextBox zustPerson_idtb;
        private System.Windows.Forms.TextBox vertraeglichkeitNotb;
        private System.Windows.Forms.TextBox verhaltenNotb;
        private System.Windows.Forms.Label labelTierID;
        private System.Windows.Forms.TextBox patetb;

        #endregion
    }
}