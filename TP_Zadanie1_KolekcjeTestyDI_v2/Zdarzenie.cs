using TP_Zadanie1_KolekcjeTestyDI_v2;

namespace TP_Zadanie1_KolekcjeTestyDI
{
    public class Zdarzenie
    {
        private int idZdarzenia;
        private Wykaz wykaz;
        private OpisStanu opisStanu;

        public int IdZdarzenia { get => idZdarzenia; set => idZdarzenia = value; }
        public Wykaz Wykaz { get => wykaz; set => wykaz = value; }
        public OpisStanu OpisStanu { get => opisStanu; set => opisStanu = value; }

        public Zdarzenie(int idZdarzenia, Wykaz wykaz, OpisStanu opisStanu)
        {
            this.idZdarzenia = idZdarzenia;
            this.wykaz = wykaz;
            this.opisStanu = opisStanu;
        }

        public override string ToString()
        {
            return this.wykaz.ToString() + " " + this.opisStanu.ToString();
        }
    }
}