using System.ComponentModel;

namespace Tierheimverwaltung.AufnahmeAbgabe
{
    partial class UCAufAbCreate
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
            this.labelTierIDAufAb = new System.Windows.Forms.Label();
            this.buttonSaveCreate = new System.Windows.Forms.Button();
            this.labelAufnahmeort = new System.Windows.Forms.Label();
            this.labelFundtier = new System.Windows.Forms.Label();
            this.labelVorbesitzer = new System.Windows.Forms.Label();
            this.labelAufnahmePerson_id = new System.Windows.Forms.Label();
            this.labelTierID = new System.Windows.Forms.Label();
            this.aufnahmeorttb = new System.Windows.Forms.TextBox();
            this.labelAufnahmeNotizen = new System.Windows.Forms.Label();
            this.labelAufnahmegrund = new System.Windows.Forms.Label();
            this.labelAufnahmedatum = new System.Windows.Forms.Label();
            this.aufnahmegrundtb = new System.Windows.Forms.TextBox();
            this.aufnahmedatumtb = new System.Windows.Forms.TextBox();
            this.labelAbgabePersonVorkontrolle = new System.Windows.Forms.Label();
            this.labelAbgabePerson_id = new System.Windows.Forms.Label();
            this.labelAbgabedatum = new System.Windows.Forms.Label();
            this.abgabePerson_idtb = new System.Windows.Forms.TextBox();
            this.abgabedatumtb = new System.Windows.Forms.TextBox();
            this.abgabePersonVorkontrolletb = new System.Windows.Forms.TextBox();
            this.labelAbgabeNotizen = new System.Windows.Forms.Label();
            this.labelAbgabePersonNachkontrolle = new System.Windows.Forms.Label();
            this.abgabePersonNachkontrolletb = new System.Windows.Forms.TextBox();
            this.aufnahmePerson_idtb = new System.Windows.Forms.TextBox();
            this.vorbesitzercb = new System.Windows.Forms.CheckBox();
            this.fundtiercb = new System.Windows.Forms.CheckBox();
            this.abgabeNotizentb = new System.Windows.Forms.RichTextBox();
            this.aufnahmeNotizentb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelTierIDAufAb
            // 
            this.labelTierIDAufAb.ForeColor = System.Drawing.Color.White;
            this.labelTierIDAufAb.Location = new System.Drawing.Point(157, 27);
            this.labelTierIDAufAb.Name = "labelTierIDAufAb";
            this.labelTierIDAufAb.Size = new System.Drawing.Size(164, 23);
            this.labelTierIDAufAb.TabIndex = 197;
            // 
            // buttonSaveCreate
            // 
            this.buttonSaveCreate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonSaveCreate.Location = new System.Drawing.Point(695, 27);
            this.buttonSaveCreate.Name = "buttonSaveCreate";
            this.buttonSaveCreate.Size = new System.Drawing.Size(88, 53);
            this.buttonSaveCreate.TabIndex = 196;
            this.buttonSaveCreate.Text = "Save";
            this.buttonSaveCreate.UseVisualStyleBackColor = true;
            this.buttonSaveCreate.Click += new System.EventHandler(this.buttonSaveCreate_Click);
            // 
            // labelAufnahmeort
            // 
            this.labelAufnahmeort.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelAufnahmeort.ForeColor = System.Drawing.Color.White;
            this.labelAufnahmeort.Location = new System.Drawing.Point(30, 178);
            this.labelAufnahmeort.Name = "labelAufnahmeort";
            this.labelAufnahmeort.Size = new System.Drawing.Size(112, 22);
            this.labelAufnahmeort.TabIndex = 195;
            this.labelAufnahmeort.Text = "Aufnahmeort";
            // 
            // labelFundtier
            // 
            this.labelFundtier.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelFundtier.ForeColor = System.Drawing.Color.White;
            this.labelFundtier.Location = new System.Drawing.Point(30, 133);
            this.labelFundtier.Name = "labelFundtier";
            this.labelFundtier.Size = new System.Drawing.Size(112, 22);
            this.labelFundtier.TabIndex = 194;
            this.labelFundtier.Text = "fundtier";
            // 
            // labelVorbesitzer
            // 
            this.labelVorbesitzer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelVorbesitzer.ForeColor = System.Drawing.Color.White;
            this.labelVorbesitzer.Location = new System.Drawing.Point(30, 97);
            this.labelVorbesitzer.Name = "labelVorbesitzer";
            this.labelVorbesitzer.Size = new System.Drawing.Size(112, 22);
            this.labelVorbesitzer.TabIndex = 193;
            this.labelVorbesitzer.Text = "Vorbesitzer";
            // 
            // labelAufnahmePerson_id
            // 
            this.labelAufnahmePerson_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelAufnahmePerson_id.ForeColor = System.Drawing.Color.White;
            this.labelAufnahmePerson_id.Location = new System.Drawing.Point(30, 62);
            this.labelAufnahmePerson_id.Name = "labelAufnahmePerson_id";
            this.labelAufnahmePerson_id.Size = new System.Drawing.Size(133, 22);
            this.labelAufnahmePerson_id.TabIndex = 192;
            this.labelAufnahmePerson_id.Text = "Person ID Aufnahme";
            // 
            // labelTierID
            // 
            this.labelTierID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelTierID.ForeColor = System.Drawing.Color.White;
            this.labelTierID.Location = new System.Drawing.Point(30, 27);
            this.labelTierID.Name = "labelTierID";
            this.labelTierID.Size = new System.Drawing.Size(133, 35);
            this.labelTierID.TabIndex = 188;
            this.labelTierID.Text = "Tier ID";
            // 
            // aufnahmeorttb
            // 
            this.aufnahmeorttb.Location = new System.Drawing.Point(157, 180);
            this.aufnahmeorttb.Name = "aufnahmeorttb";
            this.aufnahmeorttb.Size = new System.Drawing.Size(164, 20);
            this.aufnahmeorttb.TabIndex = 187;
            // 
            // labelAufnahmeNotizen
            // 
            this.labelAufnahmeNotizen.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelAufnahmeNotizen.ForeColor = System.Drawing.Color.White;
            this.labelAufnahmeNotizen.Location = new System.Drawing.Point(30, 293);
            this.labelAufnahmeNotizen.Name = "labelAufnahmeNotizen";
            this.labelAufnahmeNotizen.Size = new System.Drawing.Size(112, 22);
            this.labelAufnahmeNotizen.TabIndex = 204;
            this.labelAufnahmeNotizen.Text = "Aufnahme Notizen";
            // 
            // labelAufnahmegrund
            // 
            this.labelAufnahmegrund.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelAufnahmegrund.ForeColor = System.Drawing.Color.White;
            this.labelAufnahmegrund.Location = new System.Drawing.Point(30, 257);
            this.labelAufnahmegrund.Name = "labelAufnahmegrund";
            this.labelAufnahmegrund.Size = new System.Drawing.Size(112, 22);
            this.labelAufnahmegrund.TabIndex = 203;
            this.labelAufnahmegrund.Text = "Aufnahmegrund";
            // 
            // labelAufnahmedatum
            // 
            this.labelAufnahmedatum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelAufnahmedatum.ForeColor = System.Drawing.Color.White;
            this.labelAufnahmedatum.Location = new System.Drawing.Point(30, 222);
            this.labelAufnahmedatum.Name = "labelAufnahmedatum";
            this.labelAufnahmedatum.Size = new System.Drawing.Size(112, 22);
            this.labelAufnahmedatum.TabIndex = 202;
            this.labelAufnahmedatum.Text = "Aufnahmedatum";
            // 
            // aufnahmegrundtb
            // 
            this.aufnahmegrundtb.Location = new System.Drawing.Point(157, 259);
            this.aufnahmegrundtb.Name = "aufnahmegrundtb";
            this.aufnahmegrundtb.Size = new System.Drawing.Size(164, 20);
            this.aufnahmegrundtb.TabIndex = 200;
            // 
            // aufnahmedatumtb
            // 
            this.aufnahmedatumtb.Location = new System.Drawing.Point(157, 224);
            this.aufnahmedatumtb.Name = "aufnahmedatumtb";
            this.aufnahmedatumtb.Size = new System.Drawing.Size(164, 20);
            this.aufnahmedatumtb.TabIndex = 199;
            // 
            // labelAbgabePersonVorkontrolle
            // 
            this.labelAbgabePersonVorkontrolle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelAbgabePersonVorkontrolle.ForeColor = System.Drawing.Color.White;
            this.labelAbgabePersonVorkontrolle.Location = new System.Drawing.Point(356, 178);
            this.labelAbgabePersonVorkontrolle.Name = "labelAbgabePersonVorkontrolle";
            this.labelAbgabePersonVorkontrolle.Size = new System.Drawing.Size(133, 22);
            this.labelAbgabePersonVorkontrolle.TabIndex = 213;
            this.labelAbgabePersonVorkontrolle.Text = "Abgabe Vorkontrolle";
            // 
            // labelAbgabePerson_id
            // 
            this.labelAbgabePerson_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelAbgabePerson_id.ForeColor = System.Drawing.Color.White;
            this.labelAbgabePerson_id.Location = new System.Drawing.Point(356, 135);
            this.labelAbgabePerson_id.Name = "labelAbgabePerson_id";
            this.labelAbgabePerson_id.Size = new System.Drawing.Size(111, 22);
            this.labelAbgabePerson_id.TabIndex = 212;
            this.labelAbgabePerson_id.Text = "Person ID Abgabe";
            // 
            // labelAbgabedatum
            // 
            this.labelAbgabedatum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelAbgabedatum.ForeColor = System.Drawing.Color.White;
            this.labelAbgabedatum.Location = new System.Drawing.Point(356, 66);
            this.labelAbgabedatum.Name = "labelAbgabedatum";
            this.labelAbgabedatum.Size = new System.Drawing.Size(89, 22);
            this.labelAbgabedatum.TabIndex = 210;
            this.labelAbgabedatum.Text = "Abgabedatum";
            // 
            // abgabePerson_idtb
            // 
            this.abgabePerson_idtb.Location = new System.Drawing.Point(500, 137);
            this.abgabePerson_idtb.Name = "abgabePerson_idtb";
            this.abgabePerson_idtb.Size = new System.Drawing.Size(164, 20);
            this.abgabePerson_idtb.TabIndex = 209;
            // 
            // abgabedatumtb
            // 
            this.abgabedatumtb.Location = new System.Drawing.Point(500, 64);
            this.abgabedatumtb.Name = "abgabedatumtb";
            this.abgabedatumtb.Size = new System.Drawing.Size(164, 20);
            this.abgabedatumtb.TabIndex = 207;
            // 
            // abgabePersonVorkontrolletb
            // 
            this.abgabePersonVorkontrolletb.Location = new System.Drawing.Point(500, 180);
            this.abgabePersonVorkontrolletb.Name = "abgabePersonVorkontrolletb";
            this.abgabePersonVorkontrolletb.Size = new System.Drawing.Size(164, 20);
            this.abgabePersonVorkontrolletb.TabIndex = 206;
            // 
            // labelAbgabeNotizen
            // 
            this.labelAbgabeNotizen.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelAbgabeNotizen.ForeColor = System.Drawing.Color.White;
            this.labelAbgabeNotizen.Location = new System.Drawing.Point(356, 284);
            this.labelAbgabeNotizen.Name = "labelAbgabeNotizen";
            this.labelAbgabeNotizen.Size = new System.Drawing.Size(119, 22);
            this.labelAbgabeNotizen.TabIndex = 219;
            this.labelAbgabeNotizen.Text = "AbgabeNotizen";
            // 
            // labelAbgabePersonNachkontrolle
            // 
            this.labelAbgabePersonNachkontrolle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelAbgabePersonNachkontrolle.ForeColor = System.Drawing.Color.White;
            this.labelAbgabePersonNachkontrolle.Location = new System.Drawing.Point(356, 213);
            this.labelAbgabePersonNachkontrolle.Name = "labelAbgabePersonNachkontrolle";
            this.labelAbgabePersonNachkontrolle.Size = new System.Drawing.Size(133, 22);
            this.labelAbgabePersonNachkontrolle.TabIndex = 218;
            this.labelAbgabePersonNachkontrolle.Text = "Abgabe Nachkontrolle";
            // 
            // abgabePersonNachkontrolletb
            // 
            this.abgabePersonNachkontrolletb.Location = new System.Drawing.Point(500, 215);
            this.abgabePersonNachkontrolletb.Name = "abgabePersonNachkontrolletb";
            this.abgabePersonNachkontrolletb.Size = new System.Drawing.Size(164, 20);
            this.abgabePersonNachkontrolletb.TabIndex = 215;
            // 
            // aufnahmePerson_idtb
            // 
            this.aufnahmePerson_idtb.Location = new System.Drawing.Point(157, 64);
            this.aufnahmePerson_idtb.Name = "aufnahmePerson_idtb";
            this.aufnahmePerson_idtb.Size = new System.Drawing.Size(164, 20);
            this.aufnahmePerson_idtb.TabIndex = 189;
            // 
            // vorbesitzercb
            // 
            this.vorbesitzercb.Location = new System.Drawing.Point(163, 97);
            this.vorbesitzercb.Name = "vorbesitzercb";
            this.vorbesitzercb.Size = new System.Drawing.Size(104, 24);
            this.vorbesitzercb.TabIndex = 220;
            this.vorbesitzercb.UseVisualStyleBackColor = true;
            // 
            // fundtiercb
            // 
            this.fundtiercb.Location = new System.Drawing.Point(163, 129);
            this.fundtiercb.Name = "fundtiercb";
            this.fundtiercb.Size = new System.Drawing.Size(104, 24);
            this.fundtiercb.TabIndex = 221;
            this.fundtiercb.UseVisualStyleBackColor = true;
            // 
            // abgabeNotizentb
            // 
            this.abgabeNotizentb.Location = new System.Drawing.Point(500, 282);
            this.abgabeNotizentb.Name = "abgabeNotizentb";
            this.abgabeNotizentb.Size = new System.Drawing.Size(164, 71);
            this.abgabeNotizentb.TabIndex = 222;
            this.abgabeNotizentb.Text = "";
            // 
            // aufnahmeNotizentb
            // 
            this.aufnahmeNotizentb.Location = new System.Drawing.Point(157, 293);
            this.aufnahmeNotizentb.Name = "aufnahmeNotizentb";
            this.aufnahmeNotizentb.Size = new System.Drawing.Size(164, 69);
            this.aufnahmeNotizentb.TabIndex = 223;
            this.aufnahmeNotizentb.Text = "";
            // 
            // UCAufAbCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.aufnahmeNotizentb);
            this.Controls.Add(this.abgabeNotizentb);
            this.Controls.Add(this.fundtiercb);
            this.Controls.Add(this.vorbesitzercb);
            this.Controls.Add(this.labelAbgabeNotizen);
            this.Controls.Add(this.labelAbgabePersonNachkontrolle);
            this.Controls.Add(this.abgabePersonNachkontrolletb);
            this.Controls.Add(this.labelAbgabePersonVorkontrolle);
            this.Controls.Add(this.labelAbgabePerson_id);
            this.Controls.Add(this.labelAbgabedatum);
            this.Controls.Add(this.abgabePerson_idtb);
            this.Controls.Add(this.abgabedatumtb);
            this.Controls.Add(this.abgabePersonVorkontrolletb);
            this.Controls.Add(this.labelAufnahmeNotizen);
            this.Controls.Add(this.labelAufnahmegrund);
            this.Controls.Add(this.labelAufnahmedatum);
            this.Controls.Add(this.aufnahmegrundtb);
            this.Controls.Add(this.aufnahmedatumtb);
            this.Controls.Add(this.labelTierIDAufAb);
            this.Controls.Add(this.buttonSaveCreate);
            this.Controls.Add(this.labelAufnahmeort);
            this.Controls.Add(this.labelFundtier);
            this.Controls.Add(this.labelVorbesitzer);
            this.Controls.Add(this.labelAufnahmePerson_id);
            this.Controls.Add(this.aufnahmePerson_idtb);
            this.Controls.Add(this.labelTierID);
            this.Controls.Add(this.aufnahmeorttb);
            this.Name = "UCAufAbCreate";
            this.Size = new System.Drawing.Size(819, 427);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox abgabePersonVorkontrolletb;

        private System.Windows.Forms.CheckBox vorbesitzercb;
        private System.Windows.Forms.CheckBox fundtiercb;
        private System.Windows.Forms.RichTextBox abgabeNotizentb;
        private System.Windows.Forms.RichTextBox aufnahmeNotizentb;

        private System.Windows.Forms.Label labelAufnahmeNotizen;
        private System.Windows.Forms.Label labelAufnahmegrund;
        private System.Windows.Forms.Label labelAufnahmedatum;
        private System.Windows.Forms.TextBox aufnahmegrundtb;
        private System.Windows.Forms.TextBox aufnahmedatumtb;
        private System.Windows.Forms.Label labelAbgabePersonVorkontrolle;
        private System.Windows.Forms.Label labelAbgabePerson_id;
        private System.Windows.Forms.Label labelAbgabedatum;
        private System.Windows.Forms.TextBox abgabePerson_idtb;
        private System.Windows.Forms.TextBox abgabedatumtb;
        private System.Windows.Forms.TextBox abgabePersonNachkontrolletb;
        private System.Windows.Forms.Label labelAbgabeNotizen;
        private System.Windows.Forms.Label labelAbgabePersonNachkontrolle;
        private System.Windows.Forms.TextBox textBox11;

        private System.Windows.Forms.Label labelTierIDAufAb;
        private System.Windows.Forms.Button buttonSaveCreate;
        private System.Windows.Forms.Label labelAufnahmeort;
        private System.Windows.Forms.Label labelFundtier;
        private System.Windows.Forms.Label labelVorbesitzer;
        private System.Windows.Forms.Label labelAufnahmePerson_id;
        private System.Windows.Forms.TextBox vorbesitzertb;
        private System.Windows.Forms.TextBox aufnahmePerson_idtb;
        private System.Windows.Forms.Label labelTierID;
        private System.Windows.Forms.TextBox aufnahmeorttb;

        #endregion
    }
}