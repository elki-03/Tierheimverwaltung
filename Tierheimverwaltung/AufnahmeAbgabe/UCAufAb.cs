using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.AufnahmeAbgabe
{
    public partial class UCAufAb : UserControl
    {
        public static UCAufAb instance;
        public UCAufAb()
        {
            InitializeComponent();
            
            instance = this;
            UpdateAufAbView();
        }
        
        public void UpdateAufAbView()
        {
            dataGridView1.DataSource = DBAufAb.ReadAllGrid().Tables[0];//liest Tabelle automatisch ganz
        }
        
        public Panel PanelContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }


        private void createButton_Click(object sender, EventArgs e)
        {
            PanelContainer.Controls.Clear();
            UCAufAbCreateEingabeID ucAufAbCreateEingabeID = new UCAufAbCreateEingabeID();
            PanelContainer.Controls.Add(ucAufAbCreateEingabeID);
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            PanelContainer.Controls.Clear();
            UCAufAbUpdateEingabeID ucAufAbUpdateEingabeID = new UCAufAbUpdateEingabeID();
            PanelContainer.Controls.Add(ucAufAbUpdateEingabeID);
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            PanelContainer.Controls.Clear();
            UCAufAbDelete ucAufAbDelete = new UCAufAbDelete();
            PanelContainer.Controls.Add(ucAufAbDelete);
        }
    }
}