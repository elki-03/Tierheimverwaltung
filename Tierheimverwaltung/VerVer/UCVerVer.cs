using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.VerVer
{
    public partial class UCVerVer : UserControl
    {
        public static UCVerVer instance;
        public UCVerVer()
        {
            InitializeComponent();
            
            instance = this;
            UpdateVerVerView();
            
        }
        
        public void UpdateVerVerView()
        {
            dataGridView1.DataSource = DBVerVer.ReadAllGrid().Tables[0];//liest Tabelle automatisch ganz
        }
        
        public Panel PanelContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }


        private void createButton_Click(object sender, EventArgs e)
        {
            PanelContainer.Controls.Clear();
            UCVerVerCreateEingabeID ucMedAkteCreateEingabeID = new UCVerVerCreateEingabeID();
            PanelContainer.Controls.Add(ucMedAkteCreateEingabeID);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            PanelContainer.Controls.Clear();
            UCVerVerUpdateEingabeID ucMedAkteUpdateEingabeID = new UCVerVerUpdateEingabeID();
            PanelContainer.Controls.Add(ucMedAkteUpdateEingabeID);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            PanelContainer.Controls.Clear();
            UCVerVerDelete ucVerVerDelete = new UCVerVerDelete();
            PanelContainer.Controls.Add(ucVerVerDelete);
        }
    }
}