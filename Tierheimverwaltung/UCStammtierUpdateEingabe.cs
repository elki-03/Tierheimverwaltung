using System;
using System.Windows.Forms;

namespace Tierheimverwaltung
{
    public partial class UCStammtierUpdateEingabe : UserControl
    {
        //DBStammtierdaten.ReadOneID();
        
        
        
        
        public UCStammtierUpdateEingabe()
        {
            InitializeComponent();
            Stammtierdaten stammtierdaten = DBStammtierdaten.ReadOneID();
            TierIDtb.Text = Convert.ToString(stammtierdaten.StammtierdatenId);
            Tiernametb.Text = stammtierdaten.Tiername;
            Tierarttb.Text = stammtierdaten.Tierart;
            Rassetb.Text = stammtierdaten.Rasse;
            Beschreibungtb.Text = stammtierdaten.Beschreibung;
            Geschlechttb.Text = stammtierdaten.Geschlecht;
            Kastriertcb.Checked = stammtierdaten.Kastriert;
            Groessetb.Text = Convert.ToString(stammtierdaten.Groesse);
            Gewichttb.Text = Convert.ToString(stammtierdaten.Gewicht);
            Geburtstagtb.Text = stammtierdaten.Geburtstag;
            Geburtsorttb.Text = stammtierdaten.Geburtsort;
            Todestagtb.Text = stammtierdaten.Todestag;
            Todesursachetb.Text = stammtierdaten.Todesursache;
            OrtAufbewahrungtb.Text = stammtierdaten.Ort;
            Notizentb.Text = stammtierdaten.Notizen;

        }


        private void buttonSaveUpdateStammtierD_Click(object sender, EventArgs e)
        {
            int stammtierdatenIdNeu = Convert.ToInt32(TierIDtb.Text);
            string tiernameNeu = Tiernametb.Text;
            string tierartNeu = Tierarttb.Text;
            string rasseNeu = Rassetb.Text;
            string beschreibungNeu = Beschreibungtb.Text;
            string geschlechtNeu = Geschlechttb.Text;
            bool kastriertNeu = Convert.ToBoolean(Kastriertcb.Checked);
            double groesseNeu = Convert.ToDouble(Groessetb.Text);
            double gewichtNeu = Convert.ToDouble(Gewichttb.Text);
            string geburtstagNeu = Geburtstagtb.Text;
            string geburtsortNeu = Geburtsorttb.Text;
            string todestagNeu = Todestagtb.Text;
            string todesursacheNeu = Todesursachetb.Text;
            string ortNeu = OrtAufbewahrungtb.Text;
            string notizenNeu = Notizentb.Text;
            Stammtierdaten neueStammtierdaten = new Stammtierdaten(stammtierdatenIdNeu, tiernameNeu, tierartNeu, rasseNeu, beschreibungNeu, geschlechtNeu, kastriertNeu, groesseNeu, gewichtNeu, geburtstagNeu, geburtsortNeu, todestagNeu, todesursacheNeu, ortNeu, notizenNeu);
            
            DBStammtierdaten.UpdateStammtier(neueStammtierdaten);



 


        }
    }
}


