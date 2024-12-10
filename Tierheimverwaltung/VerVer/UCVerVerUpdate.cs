using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.VerVer
{
    public partial class UCVerVerUpdate : UserControl
    {
        public UCVerVerUpdate()
        {
            InitializeComponent();
            
            VerVer verVer = DBVerVer.ReadOneID();

            labelTierIDVerVer.Text = Convert.ToString(verVer.Stammtierdaten_id);
            verhaltenNotb.Text = Convert.ToString(verVer.VerhaltenNo);
            vertraeglichkeitNotb.Text = Convert.ToString(verVer.VertraeglichkeitNo);
            zustPerson_idtb.Text = Convert.ToString(verVer.ZustPerson_id);
            patetb.Text = Convert.ToString(verVer.Pate1);
            
        }


        private void buttonSaveCreate_Click(object sender, EventArgs e)
        {
            
            
            int stammtierdaten_idNeu = Convert.ToInt32(labelTierIDVerVer.Text);
            string verhaltenNoNeu = verhaltenNotb.Text;
            string vertraeglichkeitNoNeu = vertraeglichkeitNotb.Text;
            int zustPerson_idNeu = Convert.ToInt32(zustPerson_idtb.Text);
            string pateNeu = patetb.Text;
            
            
            VerVer neuesVerVer =
                new VerVer(stammtierdaten_idNeu, verhaltenNoNeu, vertraeglichkeitNoNeu, zustPerson_idNeu, pateNeu);
            
            DBVerVer.UpdateVerVer(neuesVerVer);
            UCVerVer.instance.UpdateVerVerView();
            MessageBox.Show("Erfolgreich geändert");

        }
    }
}