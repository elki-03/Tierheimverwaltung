using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.VerVer
{
    public partial class UCVerVerCreateEingabeID : UserControl
    {
        public UCVerVerCreateEingabeID()
        {
            InitializeComponent();
        }
        
        
        private void buttonIDbestaetigen_Click(object sender, EventArgs e)
        {
            GlobalVariables.idStammtier = Convert.ToInt32(textBoxCreateID.Text);
            
            UCVerVerCreate ucVerVerCreate = new UCVerVerCreate();
            UCVerVer.instance.PanelContainer.Controls.Clear();
            UCVerVer.instance.PanelContainer.Controls.Add(ucVerVerCreate);
        }
    }
}