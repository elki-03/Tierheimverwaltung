using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.MedAkte
{
    public partial class UCMedAkteUpdate : UserControl
    {
        public UCMedAkteUpdate()
        {
            InitializeComponent();
            
            MedAkte medAkte = DBMedAkte.ReadOneID();
            
            labelTierIDMedText.Text = Convert.ToString(medAkte.Stammtierdaten_id);
            diagnosetb.Text = Convert.ToString(medAkte.Diagnose);
            behandlungentb.Text = Convert.ToString(medAkte.Behandlungen);
            behandlungenLangFrtb.Text = Convert.ToString(medAkte.BehandlungLangFr);
            impfungentb.Text = Convert.ToString(medAkte.Impfungen);
            medikamentetb.Text = Convert.ToString(medAkte.Medikamente);
            gewichtsverlauftb.Text = Convert.ToString(medAkte.Gewichtsverlauf);
            dokumentetb.Text = Convert.ToString(medAkte.Dokumente);
        }

        private void buttonSaveCreateMedAkte_Click(object sender, EventArgs e)
        {
            //int stammdaten_id = Convert.ToInt32(labelTierIDMedText.Text); k.A. ob DB das mitmacht
            int stammtierdaten_idNeu = Convert.ToInt32(labelTierIDMedText.Text);
            string diagnoseNeu = diagnosetb.Text;
            string behandlungenNeu = behandlungentb.Text;
            string behandlungenLangFrNeu = behandlungenLangFrtb.Text;
            string impfungenNeu = impfungentb.Text;
            string medikamenteNeu = medikamentetb.Text;
            double gewichtsverlaufNeu = Convert.ToDouble(gewichtsverlauftb.Text);
            string dokumenteNeu = dokumentetb.Text;
            

            MedAkte neueMedAkte =
                new MedAkte(stammtierdaten_idNeu, diagnoseNeu, behandlungenNeu, behandlungenLangFrNeu, impfungenNeu, medikamenteNeu,  gewichtsverlaufNeu,  dokumenteNeu);
            
            DBMedAkte.UpdateMedAkte(neueMedAkte);
            UCMedAkte.instance.UpdateMedAkteView();
            MessageBox.Show("Erfolgreich geändert");
        }
    }
}