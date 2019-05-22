using TP_Zadanie1_KolekcjeTestyDI_v2;

namespace TP_Zadanie1_KolekcjeTestyDI
{
    public class WypelnianieStalymi : IFillingColection
    {
        public void FillColection(DataContext dataContext)
        {
            Wykaz wykaz1 = new Wykaz("Imie1", "Nazwisko1", 1, new System.DateTime(2019, 05, 21));
            Wykaz wykaz2 = new Wykaz("Imie2", "Nazwisko2", 2, new System.DateTime(2019, 05, 22));
            Wykaz wykaz3 = new Wykaz("Imie3", "Nazwisko3", 3, new System.DateTime(2019, 05, 23));
            Katalog katalog1 = new Katalog(1);
            Katalog katalog2 = new Katalog(2);
            Katalog katalog3 = new Katalog(3);
            OpisStanu opisStanu1 = new OpisStanu(katalog1, "nazwaGry1", "autorGry1", "opisGry1");
            OpisStanu opisStanu2 = new OpisStanu(katalog2, "nazwaGry2", "autorGry2", "opisGry2");
            OpisStanu opisStanu3 = new OpisStanu(katalog3, "nazwaGry3", "autorGry3", "opisGry3");
            Zdarzenie zdarzenie1 = new Zdarzenie(1, wykaz1, opisStanu1);
            Zdarzenie zdarzenie2 = new Zdarzenie(2, wykaz2, opisStanu2);
            Zdarzenie zdarzenie3 = new Zdarzenie(3, wykaz3, opisStanu3);

            dataContext.listaWykazow.Add(wykaz1);
            dataContext.listaWykazow.Add(wykaz2);
            dataContext.listaWykazow.Add(wykaz3);
            dataContext.listaKatalogow.Add(1, katalog1);
            dataContext.listaKatalogow.Add(2, katalog2);
            dataContext.listaKatalogow.Add(3, katalog3);
            dataContext.listaOpisowStanu.Add(opisStanu1);
            dataContext.listaOpisowStanu.Add(opisStanu2);
            dataContext.listaOpisowStanu.Add(opisStanu3);
            dataContext.listaZdarzen.Add(zdarzenie1);
            dataContext.listaZdarzen.Add(zdarzenie2);
            dataContext.listaZdarzen.Add(zdarzenie3);
        }
    }
}