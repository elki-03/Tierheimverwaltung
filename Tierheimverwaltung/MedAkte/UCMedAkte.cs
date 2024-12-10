using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.MedAkte
{
    public partial class UCMedAkte : UserControl
    {
        public static UCMedAkte instance;
        
        public UCMedAkte()
        {
            InitializeComponent();
            
            instance = this;
            UpdateMedAkteView();
        }
        
        public void UpdateMedAkteView()
        {
            dataGridView1.DataSource = DBMedAkte.ReadAllGrid().Tables[0];//liest Tabelle automatisch ganz
        }
        
        public Panel PanelContainerMed
        {
            get { return panelContainerMed; }
            set { panelContainerMed = value; }
        }


        private void createButton_Click(object sender, EventArgs e)
        {
            PanelContainerMed.Controls.Clear();
            UCMedAkteCreateEingabeID ucMedAkteCreateEingabeID = new UCMedAkteCreateEingabeID();
            PanelContainerMed.Controls.Add(ucMedAkteCreateEingabeID);
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            PanelContainerMed.Controls.Clear();
            UCMedAkteUpdateEingabeID ucMedAkteUpdateEingabeID = new UCMedAkteUpdateEingabeID();
            PanelContainerMed.Controls.Add(ucMedAkteUpdateEingabeID);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            PanelContainerMed.Controls.Clear();
            UCMedAkteDelete ucMedAkteDelete = new UCMedAkteDelete();
            PanelContainerMed.Controls.Add(ucMedAkteDelete);
        }
        
        
        
        
        
        
        
        
        
        
    }
}