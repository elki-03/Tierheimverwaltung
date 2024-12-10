using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.VerVer
{
    public partial class UCVerVerDelete : UserControl
    {
        public UCVerVerDelete()
        {
            InitializeComponent();
        }

        private void buttonIDbestaetigen_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxEingabeDeleteID.Text);
            DBVerVer.Delete(id);
            UCVerVer.instance.UpdateVerVerView();
            MessageBox.Show("Erfolgreich gelöscht");
        }
    }
}