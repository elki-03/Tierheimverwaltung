using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.MedAkte
{
    public partial class UCMedAkteDelete : UserControl
    {
        public UCMedAkteDelete()
        {
            InitializeComponent();
        }

        private void buttonIDbestaetigen_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxEingabeDeleteID.Text);
            DBMedAkte.Delete(id);
            UCMedAkte.instance.UpdateMedAkteView();
            MessageBox.Show("Erfolgreich gelöscht");
        }
    }
}