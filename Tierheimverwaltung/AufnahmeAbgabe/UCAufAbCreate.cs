using System;
using System.Windows.Forms;
using MySqlConnector;
using Tierheimverwaltung.VerVer;

namespace Tierheimverwaltung.AufnahmeAbgabe
{
    public partial class UCAufAbCreate : UserControl
    {
        public UCAufAbCreate()
        {
            InitializeComponent();
            labelTierIDAufAb.Text = Convert.ToString(GlobalVariables.idStammtier); //auswirkungen wenn man das weglässt?
        }

       

        private void buttonSaveCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int inputTextTier_id = Convert.ToInt32(labelTierIDAufAb.Text);
                
                int inputTextAufnahmePerson_idtb = Convert.ToInt32(aufnahmePerson_idtb.Text);
                
                bool inputBoolVorbesitzercb = Convert.ToBoolean(vorbesitzercb.Checked);
                bool inputBoolFundtiercb = Convert.ToBoolean(fundtiercb.Checked);
                string inputTextAufnahmeorttb = aufnahmeorttb.Text;
                string inputTextAufnahmedatumtb = aufnahmedatumtb.Text;
                string inputTextAufnahmegrundtb =aufnahmegrundtb.Text;
                string inputTextAufnahmeNotizentb = aufnahmeNotizentb.Text;
                string inputTextAbgabedatumtb = abgabedatumtb.Text;
                int inputTextAbgabePerson_idtb = Convert.ToInt32(abgabePerson_idtb.Text);
                string inputTextAbgabePersonVorkontrolletb = abgabePersonVorkontrolletb.Text;
                string inputTextAbgabePersonNachkontrolletb = abgabePersonNachkontrolletb.Text;
                string inputTextAbgabeNotizentb = abgabeNotizentb.Text;



                AufAb aufAbZusammen = new AufAb(inputTextTier_id, inputTextAufnahmePerson_idtb, inputBoolVorbesitzercb, inputBoolFundtiercb, inputTextAufnahmeorttb, inputTextAufnahmedatumtb , inputTextAufnahmegrundtb, inputTextAufnahmeNotizentb, inputTextAbgabedatumtb, inputTextAbgabePerson_idtb , inputTextAbgabePersonVorkontrolletb, inputTextAbgabePersonNachkontrolletb, inputTextAbgabeNotizentb);
            
            
                DBAufAb.Create(aufAbZusammen);
                
                UCAufAb.instance.UpdateAufAbView();
                MessageBox.Show("Erfolgreich angelegt");
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

       
    }
}