using System;

namespace TP_Zadanie1_KolekcjeTestyDI_v2
{
    public class Wykaz
    {
        private string imie;
        private string nazwisko;
        private int pesel;
        private System.DateTime dataUrodzenia;

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public int Pesel { get => pesel; set => pesel = value; }
        public DateTime DataUrodzenia { get => dataUrodzenia; set => dataUrodzenia = value; }

        public Wykaz(string imie, string nazwisko, int pesel, System.DateTime dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.dataUrodzenia = dataUrodzenia;
        }

        public override string ToString()
        {
            return "Imie:" + this.imie + ", Nazwisko: " + this.nazwisko + ", Data Urodzenia: " + this.dataUrodzenia;
        }
    }
}
