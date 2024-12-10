using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.Kennzeichnung
{
    public partial class UCKennzCreateEingabe : UserControl
    {
        public UCKennzCreateEingabe()
        {
            InitializeComponent();
        }

        private void buttonIDbestaetigen_Click(object sender, EventArgs e)
        {
            GlobalVariables.idStammtier = Convert.ToInt32(textBoxKennzCreateID.Text);
            
            UCKennzCreate ucKennzCreate = new UCKennzCreate();
            UCKennzeichnung.instance.PanelContainerKennz.Controls.Clear();
            UCKennzeichnung.instance.PanelContainerKennz.Controls.Add(ucKennzCreate);
        }
    }
}