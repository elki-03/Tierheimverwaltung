using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.AufnahmeAbgabe
{
    public partial class UCAufAbCreateEingabeID : UserControl
    {
        public UCAufAbCreateEingabeID()
        {
            InitializeComponent();
        }

        private void buttonIDbestaetigen_Click(object sender, EventArgs e)
        {
            GlobalVariables.idStammtier = Convert.ToInt32(textBoxCreateID.Text);
            
            UCAufAbCreate ucAufAbCreate = new UCAufAbCreate();
            UCAufAb.instance.PanelContainer.Controls.Clear();
            UCAufAb.instance.PanelContainer.Controls.Add(ucAufAbCreate);
        }
    }
}