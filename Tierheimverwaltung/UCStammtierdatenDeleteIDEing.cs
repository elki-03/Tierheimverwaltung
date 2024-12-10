using System;
using System.Windows.Forms;
using MySqlConnector;

namespace Tierheimverwaltung
{
    public partial class UCStammtierdatenDeleteIDEing : UserControl
    {
        public UCStammtierdatenDeleteIDEing()
        {
            InitializeComponent();
        }

        private void buttonIDbestaetigen_Click(object sender, EventArgs e)
        {
            //GlobalVariables.idStammtier = Convert.ToInt32(textBoxEingabeDeleteID.Text);
            //UCStammtierDeleteEingabe ucStammtierDeleteEingabe = new UCStammtierDeleteEingabe();

         
                //DBStammtierdaten.Delete(GlobalVariables.idStammtier);
                int id = Convert.ToInt32(textBoxEingabeDeleteID.Text);
                DBStammtierdaten.Delete(id);
                MessageBox.Show("Erfolgreich gelöscht");


            
        }
    }
}