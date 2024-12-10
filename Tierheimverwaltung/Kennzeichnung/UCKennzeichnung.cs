using System.Windows.Forms;
using System;

namespace Tierheimverwaltung.Kennzeichnung
{
    public partial class UCKennzeichnung : UserControl
    {
        public static UCKennzeichnung instance;
        
        public UCKennzeichnung()
        {
            InitializeComponent();
            
            instance = this;
            UpdateKennzView();
        }
        
        
        public void UpdateKennzView()
        {
            dataGridView1.DataSource = DBKennzeichnung.ReadAllGrid().Tables[0];//liest Tabelle automatisch ganz
        }
        
        
        public Panel PanelContainerKennz
        {
            get { return panelContainerKennz; }
            set { panelContainerKennz = value; }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            PanelContainerKennz.Controls.Clear();
            UCKennzCreateEingabe ucKennzCreateEingabe = new UCKennzCreateEingabe();
            PanelContainerKennz.Controls.Add(ucKennzCreateEingabe);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            PanelContainerKennz.Controls.Clear();
            UCKennzUpdateEingabeID ucKennzUpdateEingabeID = new UCKennzUpdateEingabeID();
            PanelContainerKennz.Controls.Add(ucKennzUpdateEingabeID);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            PanelContainerKennz.Controls.Clear();
            UCKennzDelete ucKennzDelete = new UCKennzDelete();
            PanelContainerKennz.Controls.Add(ucKennzDelete);
        }
    }
}