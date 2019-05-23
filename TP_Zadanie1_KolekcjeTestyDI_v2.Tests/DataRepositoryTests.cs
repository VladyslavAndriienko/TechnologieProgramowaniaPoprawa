using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using TP_Zadanie1_KolekcjeTestyDI_v2;

namespace TP_Zadanie1_KolekcjeTestyDI_v2.Tests
{
    [TestClass]
   public class DataRepositoryTests
    {
        [TestMethod]
        public void FillCollectionTest()
        {
            string imie1 = "Imie1";

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);

            dataRepository.FillColection(dataContext);

            Assert.AreEqual(imie1, dataRepository.DataContext.listaWykazow[0].Imie);
            CollectionAssert.AllItemsAreNotNull(dataRepository.DataContext.listaWykazow);
        }

        [TestMethod]
        public void AddWykazTest()
        {
            string imie1 = "Imie1";
            string nazwisko1 = "Nazwisko1";

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);
            Wykaz wykaz1 = new Wykaz(imie1, nazwisko1, 1, new System.DateTime(2019, 05, 23));

            dataRepository.AddWykaz(wykaz1);

            CollectionAssert.Contains(dataRepository.DataContext.listaWykazow, wykaz1);
        }

        [TestMethod]
        public void DeleteWykazTest()
        {
            string imie1 = "Imie1";
            string nazwisko1 = "Nazwisko1";

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);
            Wykaz wykaz1 = new Wykaz(imie1, nazwisko1, 1, new System.DateTime(2019, 05, 23));

            dataRepository.AddWykaz(wykaz1);
            dataRepository.DeleteWykaz(1);

            CollectionAssert.DoesNotContain(dataContext.listaWykazow, wykaz1);
        }

        [TestMethod]
        public void GetWykazTest()
        {
            string imie1 = "Imie1";
            string nazwisko1 = "Nazwisko1";

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);
            Wykaz wykaz = new Wykaz(imie1, nazwisko1, 1, new System.DateTime(2019, 05, 23));

            dataRepository.AddWykaz(wykaz);

            Assert.AreEqual(imie1, dataRepository.GetWykaz(1).Imie);
        }

        [TestMethod]
        public void GetAllWykazTest()
        {
            string imie1 = "Imie1";
            string imie2 = "Imie2";
            string nazwisko1 = "Nazwisko1";
            string nazwisko2 = "Nazwisko2";

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);
            Wykaz wykaz1 = new Wykaz(imie1, nazwisko1, 1, new System.DateTime(2019, 05, 22));
            Wykaz wykaz2 = new Wykaz(imie2, nazwisko2, 2, new System.DateTime(2019, 05, 23));

            dataRepository.AddWykaz(wykaz1);
            dataRepository.AddWykaz(wykaz2);

            Assert.AreEqual(2, dataContext.listaWykazow.Count);
        }

        [TestMethod]
        public void AddKatalogTest()
        {
            string kategoriaGry1 = "kategoriaGry1";

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);
            Katalog katalog1 = new Katalog(1, kategoriaGry1);

            dataRepository.AddKatalog(1, katalog1);

            Assert.AreEqual(kategoriaGry1, dataContext.listaKatalogow[1].KategoriaGry);
        }

        [TestMethod]
        public void DeleteKatalogTest()
        {
            string kategoriaGry1 = "kategoriaGry1";

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);
            Katalog katalog1 = new Katalog(1, kategoriaGry1);

            dataRepository.AddKatalog(1, katalog1);
            dataRepository.DeleteKatalog(1);

            CollectionAssert.DoesNotContain(dataContext.listaKatalogow, katalog1);
        }

        [TestMethod]
        public void GetKatalogTest()
        {
            string kategoriaGry1 = "kategoriaGry1";

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);
            Katalog katalog1 = new Katalog(1, kategoriaGry1);

            dataRepository.AddKatalog(1, katalog1);

            Assert.AreEqual(kategoriaGry1, dataRepository.GetKatalog(1).KategoriaGry);
        }

        [TestMethod]
        public void GetAllKatalogTest()
        {
            string kategoriaGry1 = "kategoriaGry1";
            string kategoriaGry2 = "kategoriaGry2"; ;

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);
            Katalog katalog1 = new Katalog(1, kategoriaGry1);
            Katalog katalog2 = new Katalog(2, kategoriaGry2);

            dataRepository.AddKatalog(1, katalog1);
            dataRepository.AddKatalog(2, katalog2);

            Assert.AreEqual(2, dataRepository.GetAllKatalog().Count);
        }

        [TestMethod]
        public void AddOpisStanuTest()
        {
            string kategoriaGry1 = "kategoriaGry1";
            string nazwaGry1 = "nazwaGry1";
            string autorGry1 = "autorGry1";
            string opisGry1 = "opisGry1";

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);
            Katalog katalog1 = new Katalog(1, kategoriaGry1);
            OpisStanu opisStanu1 = new OpisStanu(katalog1, nazwaGry1, autorGry1, opisGry1);

            dataRepository.AddOpisStanu(opisStanu1);

            CollectionAssert.Contains(dataContext.listaOpisowStanu, opisStanu1);
        }

        [TestMethod]
        public void DeleteOpisStanu()
        {
            string kategoriaGry1 = "kategoriaGry1";
            string nazwaGry1 = "nazwaGry1";
            string autorGry1 = "autorGry1";
            string opisGry1 = "opisGry1";

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);
            Katalog katalog1 = new Katalog(1, kategoriaGry1);
            OpisStanu opisStanu1 = new OpisStanu(katalog1, nazwaGry1, autorGry1, opisGry1);

            dataRepository.AddOpisStanu(opisStanu1);
            dataRepository.DeleteOpisStanu("nazwaGry1");

            CollectionAssert.DoesNotContain(dataContext.listaOpisowStanu, opisStanu1);
        }

        [TestMethod]
        public void GetOpisStanuTest()
        {
            string kategoriaGry1 = "kategoriaGry1";
            string nazwaGry1 = "nazwaGry1";
            string autorGry1 = "autorGry1";
            string opisGry1 = "opisGry1";

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);
            Katalog katalog1 = new Katalog(1, kategoriaGry1);
            OpisStanu opisStanu1 = new OpisStanu(katalog1, nazwaGry1, autorGry1, opisGry1);

            dataRepository.AddOpisStanu(opisStanu1);

            Assert.AreEqual(nazwaGry1, dataRepository.GetOpisStanu(nazwaGry1).NazwaGry);
        }

        [TestMethod]
        public void GetAllOpisStanuTest()
        {
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
            Katalog katalog1 = new Katalog(1, kategoriaGry1);
            Katalog katalog2 = new Katalog(1, kategoriaGry2);
            OpisStanu opisStanu1 = new OpisStanu(katalog1, nazwaGry1, autorGry1, opisGry1);
            OpisStanu opisStanu2 = new OpisStanu(katalog2, nazwaGry2, autorGry2, opisGry2);

            dataRepository.AddOpisStanu(opisStanu1);
            dataRepository.AddOpisStanu(opisStanu2);

            Assert.AreEqual(2, dataRepository.GetAllOpisStanu().Count);
        }

        [TestMethod]
        public void AddZdarzenieTest()
        {
            string imie1 = "Imie1";
            string nazwisko1 = "Nazwisko1";
            string kategoriaGry1 = "kategoriaGry1";
            string nazwaGry1 = "nazwaGry1";
            string autorGry1 = "autorGry1";
            string opisGry1 = "opisGry1";

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);
            Wykaz wykaz1 = new Wykaz(imie1, nazwisko1, 1, new System.DateTime(2018, 11, 1));
            Katalog katalog1 = new Katalog(1, kategoriaGry1);
            OpisStanu opisStanu1 = new OpisStanu(katalog1, nazwaGry1, autorGry1, opisGry1);
            Zdarzenie zdarzenie1 = new Zdarzenie(1, wykaz1, opisStanu1);

            dataRepository.AddZdarzenie(zdarzenie1);

            CollectionAssert.Contains(dataContext.listaZdarzen, zdarzenie1);
        }

        [TestMethod]
        public void DeleteZdarzenieTest()
        {
            string imie1 = "Imie1";
            string nazwisko1 = "Nazwisko1";
            string kategoriaGry1 = "kategoriaGry1";
            string nazwaGry1 = "nazwaGry1";
            string autorGry1 = "autorGry1";
            string opisGry1 = "opisGry1";

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);
            Wykaz wykaz1 = new Wykaz(imie1, nazwisko1, 1, new System.DateTime(2018, 11, 1));
            Katalog katalog1 = new Katalog(1, kategoriaGry1);
            OpisStanu opisStanu1 = new OpisStanu(katalog1, nazwaGry1, autorGry1, opisGry1);
            Zdarzenie zdarzenie1 = new Zdarzenie(1, wykaz1, opisStanu1);

            dataRepository.AddZdarzenie(zdarzenie1);
            dataRepository.DeleteZdarzenie(1);

            CollectionAssert.DoesNotContain(dataContext.listaZdarzen, zdarzenie1);
        }

        [TestMethod]
        public void GetZdarzenieTest()
        {
            string imie1 = "Imie1";
            string nazwisko1 = "Nazwisko1";
            string kategoriaGry1 = "kategoriaGry1";
            string nazwaGry1 = "nazwaGry1";
            string autorGry1 = "autorGry1";
            string opisGry1 = "opisGry1";

            IFillingColection fillingColection = new WypelnianieStalymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);
            Wykaz wykaz1 = new Wykaz(imie1, nazwisko1, 1, new System.DateTime(2018, 11, 1));
            Katalog katalog1 = new Katalog(1, kategoriaGry1);
            OpisStanu opisStanu1 = new OpisStanu(katalog1, nazwaGry1, autorGry1, opisGry1);
            Zdarzenie zdarzenie1 = new Zdarzenie(1, wykaz1, opisStanu1);

            dataRepository.AddZdarzenie(zdarzenie1);

            Assert.AreEqual("Imie1", dataRepository.GetZdarzenie(1).Wykaz.Imie);
        }

        [TestMethod]
        public void GetAllZdarzenieTest()
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

            Wykaz wykaz1 = new Wykaz(imie1, nazwisko1, 1, new System.DateTime(2018, 11, 1));
            Wykaz wykaz2 = new Wykaz(imie2, nazwisko2, 2, new System.DateTime(2018, 11, 2));
            Katalog katalog1 = new Katalog(1, kategoriaGry1);
            Katalog katalog2 = new Katalog(2, kategoriaGry2);
            OpisStanu opisStanu1 = new OpisStanu(katalog1, nazwaGry1, autorGry1, opisGry1);
            OpisStanu opisStanu2 = new OpisStanu(katalog2, nazwaGry2, autorGry2, opisGry2);
            Zdarzenie zdarzenie1 = new Zdarzenie(1, wykaz1, opisStanu1);
            Zdarzenie zdarzenie2 = new Zdarzenie(2, wykaz1, opisStanu2);

            dataRepository.AddZdarzenie(zdarzenie1);
            dataRepository.AddZdarzenie(zdarzenie2);

            Assert.AreEqual(2, dataContext.listaZdarzen.Count);
        }
    }
}
