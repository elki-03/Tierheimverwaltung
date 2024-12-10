using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.Kennzeichnung
{
    public partial class UCKennzUpdate : UserControl
    {
        public UCKennzUpdate()
        {
            InitializeComponent();
            
            //labelKennID.Text = Convert.ToString(GlobalVariables.idStammtier);
            
            
            
            
            Kennzeichnung kennzeichnung = DBKennzeichnung.ReadOneID();
            
            tierIDtb.Text = Convert.ToString(kennzeichnung.Stammtierdaten_id);
            chipNrtb.Text = Convert.ToString(kennzeichnung.ChipNr);
            tatooNrtb.Text = Convert.ToString(kennzeichnung.TatooNr);
            ringNrtb.Text = Convert.ToString(kennzeichnung.RingNr);
            ausweisNrtb.Text = Convert.ToString(kennzeichnung.AusweisNr);
            
        }


        private void buttonSaveUpdateStammtierD_Click(object sender, EventArgs e)
        {
            
            int chipNrNeu = Convert.ToInt32(chipNrtb.Text);
            int tatooNrNeu = Convert.ToInt32(tatooNrtb.Text);
            int ringNrNeu = Convert.ToInt32(ringNrtb.Text);
            int ausweisNrNeu = Convert.ToInt32(ausweisNrtb.Text);
            int stammtierdatenIdNeu = Convert.ToInt32(tierIDtb.Text);

            Kennzeichnung neueKennzeichnung =
                new Kennzeichnung(stammtierdatenIdNeu, chipNrNeu, tatooNrNeu, ringNrNeu, ausweisNrNeu);
            
            DBKennzeichnung.UpdateKennz(neueKennzeichnung);
            UCKennzeichnung.instance.UpdateKennzView();
            MessageBox.Show("Erfolgreich geändert");

        }
    }
}