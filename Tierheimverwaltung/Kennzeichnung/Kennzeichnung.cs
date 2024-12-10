namespace Tierheimverwaltung.Kennzeichnung
{
    public class Kennzeichnung
    {

        private int stammtierdaten_id;
        private int tierkennzeichnungID;
        private int chipNr;
        private int tatooNr;
        private int ringNr;
        private int ausweisNr;

        
        //Constructor
        public Kennzeichnung(int stammtierdatenId, int tierkennzeichnungId, int chipNr, int tatooNr, int ringNr, int ausweisNr)
        {
            stammtierdaten_id = stammtierdatenId;
            tierkennzeichnungID = tierkennzeichnungId;
            this.chipNr = chipNr;
            this.tatooNr = tatooNr;
            this.ringNr = ringNr;
            this.ausweisNr = ausweisNr;
        }

        public Kennzeichnung(int stammtierdaten_Id, int chipNr, int tatooNr, int ringNr, int ausweisNr)
        {
            stammtierdaten_id = stammtierdaten_Id;
            this.chipNr = chipNr;
            this.tatooNr = tatooNr;
            this.ringNr = ringNr;
            this.ausweisNr = ausweisNr;
        }
        
        
        // public Kennzeichnung( int chipNr, int tatooNr, int ringNr, int ausweisNrint, stammtierdaten_Id)
        // {
        //     
        //     this.chipNr = chipNr;
        //     this.tatooNr = tatooNr;
        //     this.ringNr = ringNr;
        //     this.ausweisNr = ausweisNr;
        //     stammtierdaten_id = stammtierdaten_Id;
        // }


        //Properties

        public int Stammtierdaten_id
        {
            get => stammtierdaten_id;
            set => stammtierdaten_id = value;
        }

        public int TierkennzeichnungID
        {
            get => tierkennzeichnungID;
            set => tierkennzeichnungID = value;
        }

        public int ChipNr
        {
            get => chipNr;
            set => chipNr = value;
        }

        public int TatooNr
        {
            get => tatooNr;
            set => tatooNr = value;
        }

        public int RingNr
        {
            get => ringNr;
            set => ringNr = value;
        }

        public int AusweisNr
        {
            get => ausweisNr;
            set => ausweisNr = value;
        }
    }
}