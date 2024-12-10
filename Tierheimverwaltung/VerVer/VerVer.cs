namespace Tierheimverwaltung.VerVer
{
    public class VerVer
    {
        private int stammtierdaten_id;
        private int verhalten_vertraeglichkeitID;
        private string verhalten_notizen;
        private string vertreglichkeit_notizen;
        private int zustPerson_ID;
        private string Pate;
        
        //Constructor

        public VerVer(int stammtierdatenId, string verhaltenNotizen, string vertreglichkeitNotizen, int zustPersonId, string pate)
        {
            stammtierdaten_id = stammtierdatenId;
            verhalten_notizen = verhaltenNotizen;
            vertreglichkeit_notizen = vertreglichkeitNotizen;
            zustPerson_ID = zustPersonId;
            Pate = pate;
        }
        
        
        //Properties

        public int Stammtierdaten_id
        {
            get => stammtierdaten_id;
            set => stammtierdaten_id = value;
        }

        public int VerhaltenVertraeglichkeitID
        {
            get => verhalten_vertraeglichkeitID;
            set => verhalten_vertraeglichkeitID = value;
        }

        public string VerhaltenNo
        {
            get => verhalten_notizen;
            set => verhalten_notizen = value;
        }

        public string VertraeglichkeitNo
        {
            get => vertreglichkeit_notizen;
            set => vertreglichkeit_notizen = value;
        }

        public int ZustPerson_id
        {
            get => zustPerson_ID;
            set => zustPerson_ID = value;
        }

        public string Pate1
        {
            get => Pate;
            set => Pate = value;
        }
    }
}