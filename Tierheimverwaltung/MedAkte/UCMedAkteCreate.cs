using System;
using System.Windows.Forms;
using MySqlConnector;

namespace Tierheimverwaltung.MedAkte
{
    public partial class UCMedAkteCreate : UserControl
    {
        public UCMedAkteCreate()
        {
            InitializeComponent();
            labelTierIDMedAkte.Text = Convert.ToString(GlobalVariables.idStammtier);
        }


        private void buttonSaveCreateStammtierD_Click(object sender, EventArgs e)//falscher name aber egal
        {
            try
            {
                int inputTextTier_id = Convert.ToInt32(labelTierIDMedAkte.Text);
                string inputTextDiagnose = diagnosetb.Text;
                string inputBehandlungen = behandlungentb.Text;
                string inputTextBehandlungenLangFr = behandlungenLangFrtb.Text;
                string inputTextImpfungen = impfungentb.Text;
                string inputTextMedikamente = medikamentetb.Text;
                double inputTextGewichtsverlauf = Convert.ToDouble(gewichtsverlauftb.Text);
                string inputTextDokumente = dokumentetb.Text;


                MedAkte medakteZusammen = new MedAkte(inputTextTier_id, inputTextDiagnose, inputBehandlungen,
                    inputTextBehandlungenLangFr, inputTextImpfungen, inputTextMedikamente, inputTextGewichtsverlauf,
                    inputTextDokumente);


                DBMedAkte.Create(medakteZusammen);
                //
                UCMedAkte.instance.UpdateMedAkteView();
                MessageBox.Show("Erfolgreich angelegt");
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

    }
}