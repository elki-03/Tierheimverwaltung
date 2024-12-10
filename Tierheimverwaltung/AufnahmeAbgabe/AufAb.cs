namespace Tierheimverwaltung.AufnahmeAbgabe
{
    public class AufAb
    {
        private int stammtierdaten_id;
        private int aufnahme_abgabeID;
        private int aufnahme_Person_id;
        private bool vorbesitzer;
        private bool fundtier;
        private string aufnahmeort;
        private string aufnahmedatum;
        private string aufnahmegrund;
        private string aufnahmenotizen;
        private string abgabedatum;
        private int abgabe_Person_id;
        private string abgabePersonVorkontrolle;
        private string abgabePersonNachkontrolle;
        private string abgabeNotizen;
        
        
        //Construktor

        public AufAb(int stammtierdatenId, int aufnahmePersonId, bool vorbesitzer, bool fundtier, string aufnahmeort, string aufnahmedatum, string aufnahmegrund, string aufnahmenotizen, string abgabedatum, int abgabePersonId, string abgabePersonVorkontrolle, string abgabePersonNachkontrolle, string abgabeNotizen)
        {
            stammtierdaten_id = stammtierdatenId;
            aufnahme_Person_id = aufnahmePersonId;
            this.vorbesitzer = vorbesitzer;
            this.fundtier = fundtier;
            this.aufnahmeort = aufnahmeort;
            this.aufnahmedatum = aufnahmedatum;
            this.aufnahmegrund = aufnahmegrund;
            this.aufnahmenotizen = aufnahmenotizen;
            this.abgabedatum = abgabedatum;
            abgabe_Person_id = abgabePersonId;
            this.abgabePersonVorkontrolle = abgabePersonVorkontrolle;
            this.abgabePersonNachkontrolle = abgabePersonNachkontrolle;
            this.abgabeNotizen = abgabeNotizen;
        }

        

        // Properties

        public int Stammtierdaten_id
        {
            get => stammtierdaten_id;
            set => stammtierdaten_id = value;
        }

        public int AufnahmePerson_id
        {
            get => aufnahme_Person_id;
            set => aufnahme_Person_id = value;
        }

        public bool Vorbesitzer
        {
            get => vorbesitzer;
            set => vorbesitzer = value;
        }

        public bool Fundtier
        {
            get => fundtier;
            set => fundtier = value;
        }

        public string Aufnahmeort
        {
            get => aufnahmeort;
            set => aufnahmeort = value;
        }

        public string Aufnahmedatum
        {
            get => aufnahmedatum;
            set => aufnahmedatum = value;
        }

        public string Aufnahmegrund
        {
            get => aufnahmegrund;
            set => aufnahmegrund = value;
        }

        public string Aufnahmenotizen
        {
            get => aufnahmenotizen;
            set => aufnahmenotizen = value;
        }

        public string Abgabedatum
        {
            get => abgabedatum;
            set => abgabedatum = value;
        }

        public int AbgabePerson_id
        {
            get => abgabe_Person_id;
            set => abgabe_Person_id = value;
        }

        public string AbgabePersonVorkontrolle
        {
            get => abgabePersonVorkontrolle;
            set => abgabePersonVorkontrolle = value;
        }

        public string AbgabePersonNachkontrolle
        {
            get => abgabePersonNachkontrolle;
            set => abgabePersonNachkontrolle = value;
        }

        public string AbgabeNotizen
        {
            get => abgabeNotizen;
            set => abgabeNotizen = value;
        }
    }
}