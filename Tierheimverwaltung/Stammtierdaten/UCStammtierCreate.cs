using System;
using System.Windows.Forms;

namespace Tierheimverwaltung
{
    public partial class UCStammtierCreate : UserControl
    {
        public UCStammtierCreate()
        {
            InitializeComponent();
        }
        
        
        
        
        private void buttonSaveCreateStammtierD_Click(object sender, EventArgs e)
        {
            //int inputTextTierID = Convert.ToInt32(TierIDtb.Text);
            string inputTextTiername = Tiernametb.Text;
            string inputTextTierart = Tierarttb.Text;
            string inputTextRasse = Rassetb.Text;
            string inputTextBeschreibung = Beschreibungtb.Text;
            string inputTextGeschlecht = Geschlechttb.Text;
            
            bool inputBoolKastriert = Convert.ToBoolean(Kastriertcb.Checked);// --> als true gespeichert?
            
            double inputTextGroesse = Convert.ToDouble(Groessetb.Text);
            double inputTextGewicht = Convert.ToDouble(Gewichttb.Text);
            string inputTextGeburtstag = Geburtstagtb.Text;
            string inputTextGeburtsort = Geburtsorttb.Text;
            string inputTextTodestag = Todestagtb.Text;
            string inputTextTodesursache = Todesursachetb.Text;
            string inputTextAufbewahrungsort = OrtAufbewahrungtb.Text;
            string inputTextNotizen = Notizentb.Text;


            Stammtierdaten stammtierdatenZusammen = new Stammtierdaten( inputTextTiername,
                inputTextTierart, inputTextRasse, inputTextBeschreibung, inputTextGeschlecht, inputBoolKastriert, inputTextGroesse, inputTextGewicht, inputTextGeburtstag, inputTextGeburtsort, inputTextTodestag, inputTextTodesursache, inputTextAufbewahrungsort, inputTextNotizen );
            DBStammtierdaten.Create(stammtierdatenZusammen);
            //
            UCStammtierdaten.instance.UpdateStammtierView();
            MessageBox.Show("Erfolgreich angelegt");




        }
    }
}