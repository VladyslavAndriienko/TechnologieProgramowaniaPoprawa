namespace TP_Zadanie1_KolekcjeTestyDI_v2
{
    public class Katalog
    {
        private int idGry;
        private string kategoriaGry;

        public int IdGry { get => idGry; set => idGry = value; }
        public string KategoriaGry { get => kategoriaGry; set => kategoriaGry = value; }

        public Katalog(int idGry, string kategoriaGry)
        {
            this.idGry = idGry;
            this.kategoriaGry = kategoriaGry;
        }

        public override string ToString()
        {
            return "ID Gry: " + this.idGry + ", Kategoria Gry: " + this.kategoriaGry;
        }
    }
}
