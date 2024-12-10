using System;
using System.Windows.Forms;

namespace Tierheimverwaltung.AufnahmeAbgabe
{
    public partial class UCAufAbUpdate : UserControl
    {
        public UCAufAbUpdate()
        {
            InitializeComponent();
            
            AufAb aufAb = DBAufAb.ReadOneID();

            labelTierIDAufAb.Text = Convert.ToString(aufAb.Stammtierdaten_id);
            aufnahmePerson_idtb.Text = Convert.ToString(aufAb.AufnahmePerson_id);
            vorbesitzercb.Checked = aufAb.Vorbesitzer;
            fundtiercb.Checked = aufAb.Fundtier;
            aufnahmeorttb.Text = aufAb.Aufnahmeort;
            aufnahmedatumtb.Text = aufAb.Abgabedatum;
            aufnahmegrundtb.Text = aufAb.Aufnahmegrund;
            aufnahmeNotizentb.Text = aufAb.Aufnahmenotizen;
            abgabedatumtb.Text = aufAb.Aufnahmedatum;
            abgabePerson_idtb.Text = Convert.ToString(aufAb.AbgabePerson_id);
            abgabePersonVorkontrolletb.Text = aufAb.AbgabePersonVorkontrolle;
            abgabePersonNachkontrolletb.Text = aufAb.AbgabePersonNachkontrolle;
            abgabeNotizentb.Text = aufAb.AbgabeNotizen;
        }


        private void buttonSaveCreate_Click(object sender, EventArgs e)
        {
            int inputTextTier_id = Convert.ToInt32(labelTierIDAufAb.Text);
            int inputTextufAufnahmePerson_idtb = Convert.ToInt32(aufnahmePerson_idtb.Text);
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
            string inputTextAbgabeNotizentb = abgabeNotizentb.Text; // --> alle neu
            
            
            AufAb neueAufAb =
                new AufAb(inputTextTier_id , inputTextufAufnahmePerson_idtb , inputBoolVorbesitzercb , inputBoolFundtiercb, inputTextAufnahmeorttb, inputTextAufnahmedatumtb, inputTextAufnahmegrundtb, inputTextAufnahmeNotizentb , inputTextAbgabedatumtb, inputTextAbgabePerson_idtb, inputTextAbgabePersonVorkontrolletb, inputTextAbgabePersonNachkontrolletb, inputTextAbgabeNotizentb);


            DBAufAb.UpdateAufAb(neueAufAb);
            UCAufAb.instance.UpdateAufAbView();
            MessageBox.Show("Erfolgreich geändert");
            
        }
    }
}