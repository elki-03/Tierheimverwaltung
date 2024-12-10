using System;
using System.Windows.Forms;

namespace Tierheimverwaltung
{
    public partial class UCStammtierUpdate : UserControl
    {
        public UCStammtierUpdate()
        {
            InitializeComponent();
        }
        
        
        
        

        private void buttonIDbestaetigen_Click_1(object sender, EventArgs e)
        {
           
            GlobalVariables.idStammtier = Convert.ToInt32(textBoxEingabeUpdateID.Text);

            UCStammtierUpdateEingabe ucStammtierCreateUpdateEingabe = new UCStammtierUpdateEingabe();
            Form1.instance.PanelContainer.Controls.Clear();
            Form1.instance.PanelContainer.Controls.Add(ucStammtierCreateUpdateEingabe);
        }
    }
}