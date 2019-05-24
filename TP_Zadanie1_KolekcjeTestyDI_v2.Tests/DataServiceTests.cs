using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TP_Zadanie1_KolekcjeTestyDI_v2;

namespace TP_Zadanie1_KolekcjeTestyDI_v2.Tests
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void GetZdarzenieByWykazImieTest()
        {
            string imie1 = "Imie1";
            string imie2 = "Imie2";
            string nazwisko1 = "Nazwisko1";
            string nazwisko2 = "Nazwisko2";
            string kategoriaGry1 = "kategoriaGry1";
            string kategoriaGry2 = "kategoriaGry2";
            string nazwaGry1 = "nazwaGry1";
            string nazwaGry2 = "nazwaGry2";
            string autorGry1 = "autorGry1";
            string autorGry2 = "autorGry2";
            string opisGry1 = "opisGry1";
            string opisGry2 = "opisGry2";

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);
            DataService dataService = new DataService(dataRepository);

            Wykaz wykaz1 = new Wykaz(imie1, nazwisko1, 1, new System.DateTime(2018, 11, 1));
            Wykaz wykaz2 = new Wykaz(imie2, nazwisko2, 2, new System.DateTime(2018, 11, 2));
            Katalog katalog1 = new Katalog(1, kategoriaGry1);
            Katalog katalog2 = new Katalog(2, kategoriaGry2);
            OpisStanu opisStanu1 = new OpisStanu(katalog1, nazwaGry1, autorGry1, opisGry1);
            OpisStanu opisStanu2 = new OpisStanu(katalog2, nazwaGry2, autorGry2, opisGry2);
            Zdarzenie zdarzenie1 = new Zdarzenie(1, wykaz1, opisStanu1);
            Zdarzenie zdarzenie2 = new Zdarzenie(2, wykaz2, opisStanu2);

            dataRepository.AddZdarzenie(zdarzenie1);
            dataRepository.AddZdarzenie(zdarzenie2);

            CollectionAssert.Equals(1, dataService.GetZdarzenieByImie(imie1)[0].IdZdarzenia);
            CollectionAssert.Equals(1, dataService.GetZdarzenieByImie(imie1).Count);
        }

        [TestMethod]
        public void GetWykazByKategoriaGryTest()
        {
            string imie1 = "Imie1";
            string imie2 = "Imie2";
            string nazwisko1 = "Nazwisko1";
            string nazwisko2 = "Nazwisko2";
            string kategoriaGry1 = "kategoriaGry1";
            string kategoriaGry2 = "kategoriaGry2";
            string nazwaGry1 = "nazwaGry1";
            string nazwaGry2 = "nazwaGry2";
            string autorGry1 = "autorGry1";
            string autorGry2 = "autorGry2";
            string opisGry1 = "opisGry1";
            string opisGry2 = "opisGry2";

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);
            DataService dataService = new DataService(dataRepository);

            Wykaz wykaz1 = new Wykaz(imie1, nazwisko1, 1, new System.DateTime(2018, 11, 1));
            Wykaz wykaz2 = new Wykaz(imie2, nazwisko2, 2, new System.DateTime(2018, 11, 2));
            Katalog katalog1 = new Katalog(1, kategoriaGry1);
            Katalog katalog2 = new Katalog(2, kategoriaGry2);
            OpisStanu opisStanu1 = new OpisStanu(katalog1, nazwaGry1, autorGry1, opisGry1);
            OpisStanu opisStanu2 = new OpisStanu(katalog2, nazwaGry2, autorGry2, opisGry2);
            Zdarzenie zdarzenie1 = new Zdarzenie(1, wykaz1, opisStanu1);
            Zdarzenie zdarzenie2 = new Zdarzenie(2, wykaz2, opisStanu2);

            dataRepository.AddZdarzenie(zdarzenie1);
            dataRepository.AddZdarzenie(zdarzenie2);

            CollectionAssert.Equals(imie1, dataService.GetWykazByKategoriaGry(kategoriaGry1)[0].Imie);
        }
    }
}
