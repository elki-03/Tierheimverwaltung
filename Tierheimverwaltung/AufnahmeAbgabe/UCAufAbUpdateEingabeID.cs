using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.AufnahmeAbgabe
{
    public partial class UCAufAbUpdateEingabeID : UserControl
    {
        public UCAufAbUpdateEingabeID()
        {
            InitializeComponent();
        }

        private void buttonIDbestaetigen_Click(object sender, EventArgs e)
        {
            GlobalVariables.idStammtier = Convert.ToInt32(textBoxUpdateID.Text);
                        
            UCAufAbUpdate ucAufAbUpdate = new UCAufAbUpdate();
            UCAufAb.instance.PanelContainer.Controls.Clear();
            UCAufAb.instance.PanelContainer.Controls.Add(ucAufAbUpdate);
        }
    }
}