using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TP_Zadanie1_KolekcjeTestyDI_v2;

namespace TP_Zadanie1_KolekcjeTestyDI_v2.Tests
{
    [TestClass]
    public class WypelnianieLosowymiTest
    {
        [TestMethod]
        public void FillCollectionTest()
        {
            IFillingColection fillingColection = new WypelnianieLosowymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);

            dataContext.iloscElementowListy = 10;
            dataRepository.FillColection(dataContext);

            Assert.AreEqual(10, dataContext.listaWykazow.Count);
        }

        [TestMethod]
        public void FillCollectionTest2()
        {
            IFillingColection fillingColection = new WypelnianieLosowymi();
            DataContext dataContext = new DataContext();
            DataRepository dataRepository = new DataRepository(fillingColection, dataContext);

            dataContext.iloscElementowListy = 100000;
            dataRepository.FillColection(dataContext);

            Assert.AreEqual(100000, dataContext.listaWykazow.Count);
        }
    }
}