using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.VerVer
{
    public partial class UCVerVerUpdateEingabeID : UserControl
    {
        public UCVerVerUpdateEingabeID()
        {
            InitializeComponent();
        }

        private void buttonIDbestaetigen_Click(object sender, EventArgs e)
        {
            GlobalVariables.idStammtier = Convert.ToInt32(textBoxUpdateID.Text);
                        
            UCVerVerUpdate ucVerVerUpdate = new UCVerVerUpdate();
            UCVerVer.instance.PanelContainer.Controls.Clear();
            UCVerVer.instance.PanelContainer.Controls.Add(ucVerVerUpdate);
        }
    }
}