using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.MedAkte
{
    public partial class UCMedAkteCreateEingabeID : UserControl
    {
        public UCMedAkteCreateEingabeID()
        {
            InitializeComponent();
        }


        private void buttonIDbestaetigen_Click(object sender, EventArgs e)
        {
            GlobalVariables.idStammtier = Convert.ToInt32(textBoxCreateID.Text);
            
            UCMedAkteCreate ucMedAkteCreate = new UCMedAkteCreate();
            UCMedAkte.instance.PanelContainerMed.Controls.Clear();
            UCMedAkte.instance.PanelContainerMed.Controls.Add(ucMedAkteCreate);
        }
    }
}