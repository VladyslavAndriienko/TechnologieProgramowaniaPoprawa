namespace TP_Zadanie1_KolekcjeTestyDI_v2
{
    public class OpisStanu
    {
        private Katalog katalog;
        private string nazwaGry;
        private string autorGry;
        private string opisGry;

        public Katalog Katalog { get => katalog; set => katalog = value; }
        public string NazwaGry { get => nazwaGry; set => nazwaGry = value; }
        public string AutorGry { get => autorGry; set => autorGry = value; }
        public string OpisGry { get => opisGry; set => opisGry = value; }

        public OpisStanu(Katalog katalog, string nazwaGry, string autorGry, string opisGry)
        {
            this.katalog = katalog;
            this.nazwaGry = nazwaGry;
            this.autorGry = autorGry;
            this.opisGry = opisGry;
        }

        public override string ToString()
        {
            return this.katalog.ToString() + "Nazwa Gry: " + this.nazwaGry + ", Autor Gry: " +
                   this.autorGry + ", Opis Gry:" + this.opisGry;
        }
    }
}