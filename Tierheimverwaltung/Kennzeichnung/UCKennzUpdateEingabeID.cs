using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.Kennzeichnung
{
    public partial class UCKennzUpdateEingabeID : UserControl
    {
        public UCKennzUpdateEingabeID()
        {
            InitializeComponent();
        }

        private void buttonIDbestaetigen_Click(object sender, EventArgs e)
        {
            GlobalVariables.idStammtier = Convert.ToInt32(textBoxKennzUpdateID.Text);
                        
            UCKennzUpdate ucKennzUpdate = new UCKennzUpdate();
            UCKennzeichnung.instance.PanelContainerKennz.Controls.Clear();
            UCKennzeichnung.instance.PanelContainerKennz.Controls.Add(ucKennzUpdate);
        }
    }
}