using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.AufnahmeAbgabe
{
    public partial class UCAufAbDelete : UserControl
    {
        public UCAufAbDelete()
        {
            InitializeComponent();
        }

        private void buttonIDbestaetigen_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxEingabeDeleteID.Text);
            DBAufAb.Delete(id);
            UCAufAb.instance.UpdateAufAbView();
            MessageBox.Show("Erfolgreich gelöscht");
        }
    }
}