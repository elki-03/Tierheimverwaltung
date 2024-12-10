namespace Tierheimverwaltung.MedAkte
{
    public class MedAkte
    {
        private int stammtierdaten_id;
        private int medizinische_akteID;
        private string diagnose;
        private string behandlungen;
        private string behandlungLangFr;
        private string impfungen;
        private string medikamente;
        private double gewichtsverlauf;
        private string dokumente;


        //Constructor
        public MedAkte(int stammtierdatenId, int medizinischeAkteId, string diagnose, string behandlungen, string behandlungLangFr, string impfungen, string medikamente, double gewichtsverlauf, string dokumente)
        {
            stammtierdaten_id = stammtierdatenId;
            medizinische_akteID = medizinischeAkteId;
            this.diagnose = diagnose;
            this.behandlungen = behandlungen;
            this.behandlungLangFr = behandlungLangFr;
            this.impfungen = impfungen;
            this.medikamente = medikamente;
            this.gewichtsverlauf = gewichtsverlauf;
            this.dokumente = dokumente;
        }

        public MedAkte(int stammtierdatenId, string diagnose, string behandlungen, string behandlungLangFr, string impfungen, string medikamente, double gewichtsverlauf, string dokumente)
        {
            stammtierdaten_id = stammtierdatenId;
            this.diagnose = diagnose;
            this.behandlungen = behandlungen;
            this.behandlungLangFr = behandlungLangFr;
            this.impfungen = impfungen;
            this.medikamente = medikamente;
            this.gewichtsverlauf = gewichtsverlauf;
            this.dokumente = dokumente;
        }

        public MedAkte(string diagnose, string behandlungen, string behandlungLangFr, string impfungen, string medikamente, double gewichtsverlauf, string dokumente)
        {
            this.diagnose = diagnose;
            this.behandlungen = behandlungen;
            this.behandlungLangFr = behandlungLangFr;
            this.impfungen = impfungen;
            this.medikamente = medikamente;
            this.gewichtsverlauf = gewichtsverlauf;
            this.dokumente = dokumente;
        }
        
        


        //Properties

        public int Stammtierdaten_id
        {
            get => stammtierdaten_id;
            set => stammtierdaten_id = value;
        }

        public int MedizinischeAkteId
        {
            get => medizinische_akteID;
            set => medizinische_akteID = value;
        }

        public string Diagnose
        {
            get => diagnose;
            set => diagnose = value;
        }

        public string Behandlungen
        {
            get => behandlungen;
            set => behandlungen = value;
        }

        public string BehandlungLangFr
        {
            get => behandlungLangFr;
            set => behandlungLangFr = value;
        }

        public string Impfungen
        {
            get => impfungen;
            set => impfungen = value;
        }

        public string Medikamente
        {
            get => medikamente;
            set => medikamente = value;
        }

        public double Gewichtsverlauf
        {
            get => gewichtsverlauf;
            set => gewichtsverlauf = value;
        }

        public string Dokumente
        {
            get => dokumente;
            set => dokumente = value;
        }
    }
}