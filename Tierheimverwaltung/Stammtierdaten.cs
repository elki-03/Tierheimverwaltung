namespace Tierheimverwaltung
{
    public class Stammtierdaten
    {
        private int stammtierdatenID;
        private string tiername;
        private string tierart;
        private string rasse;
        private string beschreibung;
        private string geschlecht;
        private bool kastriert;
        private double groesse;
        private double gewicht;
        private string geburtstag;
        private string geburtsort;
        private string todestag;
        private string todesursache;
        private string ort;
        private string notizen;

        public Stammtierdaten()
        {
        }

        //Contructor
        public Stammtierdaten(int stammtierdatenId, string tiername, string tierart, string rasse, string beschreibung, string geschlecht, bool kastriert, double groesse, double gewicht, string geburtstag, string geburtsort, string todestag, string todesursache, string ort, string notizen)
        {
            stammtierdatenID = stammtierdatenId;
            this.tiername = tiername;
            this.tierart = tierart;
            this.rasse = rasse;
            this.beschreibung = beschreibung;
            this.geschlecht = geschlecht;
            this.kastriert = kastriert;
            this.groesse = groesse;
            this.gewicht = gewicht;
            this.geburtstag = geburtstag;
            this.geburtsort = geburtsort;
            this.todestag = todestag;
            this.todesursache = todesursache;
            this.ort = ort;
            this.notizen = notizen;
        }
        
        public Stammtierdaten(string tiername, string tierart, string rasse, string beschreibung, string geschlecht, bool kastriert, double groesse, double gewicht, string geburtstag, string geburtsort, string todestag, string todesursache, string ort, string notizen)
        {
            this.tiername = tiername;
            this.tierart = tierart;
            this.rasse = rasse;
            this.beschreibung = beschreibung;
            this.geschlecht = geschlecht;
            this.kastriert = kastriert;
            this.groesse = groesse;
            this.gewicht = gewicht;
            this.geburtstag = geburtstag;
            this.geburtsort = geburtsort;
            this.todestag = todestag;
            this.todesursache = todesursache;
            this.ort = ort;
            this.notizen = notizen;
        }
        
        //Properties (anstlle vonGetSet)
        public int StammtierdatenId
        {
            get => stammtierdatenID;
            set => stammtierdatenID = value;
        }

        public string Tiername
        {
            get => tiername;
            set => tiername = value;
        }

        public string Tierart
        {
            get => tierart;
            set => tierart = value;
        }

        public string Rasse
        {
            get => rasse;
            set => rasse = value;
        }

        public string Beschreibung
        {
            get => beschreibung;
            set => beschreibung = value;
        }

        public string Geschlecht
        {
            get => geschlecht;
            set => geschlecht = value;
        }

        public bool Kastriert
        {
            get => kastriert;
            set => kastriert = value;
        }

        public double Groesse
        {
            get => groesse;
            set => groesse = value;
        }

        public double Gewicht
        {
            get => gewicht;
            set => gewicht = value;
        }

        public string Geburtstag
        {
            get => geburtstag;
            set => geburtstag = value;
        }

        public string Geburtsort
        {
            get => geburtsort;
            set => geburtsort = value;
        }

        public string Todestag
        {
            get => todestag;
            set => todestag = value;
        }

        public string Todesursache
        {
            get => todesursache;
            set => todesursache = value;
        }

        public string Ort
        {
            get => ort;
            set => ort = value;
        }

        public string Notizen
        {
            get => notizen;
            set => notizen = value;
        }
        
        
        
        
    }
}