using System;
using System.Windows.Forms;
using MySqlConnector;

namespace Tierheimverwaltung.Kennzeichnung
{
    public partial class UCKennzCreate : UserControl
    {
        public UCKennzCreate()
        {
            InitializeComponent();


            labelTierIDKenn.Text = Convert.ToString(GlobalVariables.idStammtier);
        }


        private void buttonSaveCreateStammtierD_Click(object sender, EventArgs e)
        {

            try
            {
                int inputTextTier_id= Convert.ToInt32(labelTierIDKenn.Text);
                int inputTextChipNr = Convert.ToInt32(chipNrtb.Text);
                int inputTextTatooNr = Convert.ToInt32(tatooNrtb.Text);
                int inputTextRingNr = Convert.ToInt32(ringNrtb.Text);
                int inputTextAusweisNr = Convert.ToInt32(ausweisNrtb.Text);
            

                Kennzeichnung kennzeichnungZusammen = new Kennzeichnung( inputTextTier_id,
                    inputTextChipNr, inputTextTatooNr, inputTextRingNr, inputTextAusweisNr);
                DBKennzeichnung.Create(kennzeichnungZusammen);
                //
                UCKennzeichnung.instance.UpdateKennzView();
                MessageBox.Show("Erfolgreich angelegt");

            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }


        }
    }
}