using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.MedAkte
{
    public partial class UCMedAkteUpdateEingabeID : UserControl
    {
        public UCMedAkteUpdateEingabeID()
        {
            InitializeComponent();
        }

        
        
        
        
        private void buttonIDbestaetigen_Click(object sender, EventArgs e)
        {
            GlobalVariables.idStammtier = Convert.ToInt32(textBoxUpdateID.Text);
                        
            UCMedAkteUpdate ucMedAkteUpdate = new UCMedAkteUpdate();
            UCMedAkte.instance.PanelContainerMed.Controls.Clear();
            UCMedAkte.instance.PanelContainerMed.Controls.Add(ucMedAkteUpdate);
        }
    }
}