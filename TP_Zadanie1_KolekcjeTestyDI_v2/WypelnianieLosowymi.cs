using System;
using System.Linq;

namespace TP_Zadanie1_KolekcjeTestyDI_v2
{
    public class WypelnianieLosowymi : IFillingColection
    {
        private readonly Random random = new Random();

        public string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public DateTime GenererateRandomDate()
        {
            int year = random.Next(1950, 2018);
            int month = random.Next(1, 12);
            int day = DateTime.DaysInMonth(year, month);
            int _day = random.Next(1, day);
            DateTime dateTime = new DateTime(year, month, _day);

            return dateTime;
        }

        public Wykaz GetRandomWykaz()
        {
            Wykaz wykaz = new Wykaz(GenerateRandomString(10), GenerateRandomString(10), random.Next(1, 100), GenererateRandomDate());
            return wykaz;
        }

        public Katalog GetRandomKatalog()
        {
            Katalog katalog = new Katalog(random.Next(1, 100), GenerateRandomString(10));
            return katalog;
        }

        public OpisStanu GetRandomOpisStanu()
        {
            OpisStanu opisStanu = new OpisStanu(GetRandomKatalog(), GenerateRandomString(10), GenerateRandomString(10), GenerateRandomString(10));
            return opisStanu;
        }

        public Zdarzenie GetRandomZdarzenie()
        {
            Zdarzenie zdarzenie = new Zdarzenie(random.Next(1, 100), GetRandomWykaz(), GetRandomOpisStanu());
            return zdarzenie;
        }

        public void FillColection(DataContext dataContext)
        {
            for (int i = 0; i < dataContext.iloscElementowListy; i++)
            {
                dataContext.listaWykazow.Add(GetRandomWykaz());
                dataContext.listaKatalogow.Add(i, GetRandomKatalog());
                dataContext.listaOpisowStanu.Add(GetRandomOpisStanu());
                dataContext.listaZdarzen.Add(GetRandomZdarzenie());
            }
        }
    }
}
