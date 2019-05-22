namespace TP_Zadanie1_KolekcjeTestyDI_v2
{
    public class Katalog
    {
        private int idGry;

        public int IdGry { get => idGry; set => idGry = value; }

        public Katalog(int idGry)
        {
            this.idGry = idGry;
        }

        public override string ToString()
        {
            return "ID Gry: " + this.idGry;
        }
    }
}
