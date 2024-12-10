using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.Kennzeichnung
{
    public partial class UCKennzDelete : UserControl
    {
        public UCKennzDelete()
        {
            InitializeComponent();
            
            
        }

        
        
        
        
        private void buttonIDbestaetigen_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxEingabeDeleteID.Text);
            DBKennzeichnung.Delete(id);
            UCKennzeichnung.instance.UpdateKennzView();
            MessageBox.Show("Erfolgreich gelöscht");
        }
    }
}