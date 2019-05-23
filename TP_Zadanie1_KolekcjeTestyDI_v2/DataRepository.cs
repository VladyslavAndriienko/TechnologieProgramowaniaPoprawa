using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TP_Zadanie1_KolekcjeTestyDI_v2
{
    public class DataRepository
    {
        private DataContext dataContext;
        private IFillingColection fillingColection;

        public DataContext DataContext { get => dataContext; set => dataContext = value; }
        public IFillingColection FillingColection { get => fillingColection; set => fillingColection = value; }

        public DataRepository(IFillingColection fillingColection, DataContext dataContext)
        {
            this.FillingColection = fillingColection;
            this.DataContext = dataContext;
        }

        public void FillColection(DataContext dataContext)
        {
            FillingColection.FillColection(dataContext);
        }

        public WypelnianieStalymi GetWypelnianieStalymi(WypelnianieStalymi wypelnianieStalymi)
        {
            return wypelnianieStalymi;
        }

        public void AddWykaz(Wykaz wykaz)
        {
            DataContext.listaWykazow.Add(wykaz);
        }

        public void DeleteWykaz(int pesel)
        {
            for (int i = 0; i < DataContext.listaWykazow.Count; i++)
            {
                Wykaz wykaz = DataContext.listaWykazow[i];
                if (wykaz.Pesel.Equals(pesel))
                {
                    DataContext.listaWykazow.Remove(wykaz);
                }
            }
        }

        public Wykaz GetWykaz(int pesel)
        {
            foreach (Wykaz wykaz in DataContext.listaWykazow)
            {
                if (wykaz.Pesel.Equals(pesel)) return wykaz;
            }
            return null;
        }

        public List<Wykaz> GetAllWykaz()
        {
            return DataContext.listaWykazow;
        }

        public void AddKatalog(int key, Katalog katalog)
        {
            DataContext.listaKatalogow.Add(key, katalog);
        }

        public void DeleteKatalog(int key)
        {
            DataContext.listaKatalogow.Remove(key);
        }

        public Katalog GetKatalog(int key)
        {
            foreach (KeyValuePair<int, Katalog> kvp in DataContext.listaKatalogow)
            {
                if (kvp.Key.Equals(key))
                {
                    return kvp.Value;
                }
            }
            return null;
        }

        public Dictionary<int, Katalog> GetAllKatalog()
        {
            return DataContext.listaKatalogow;
        }

        public void AddOpisStanu(OpisStanu opisStanu)
        {
            DataContext.listaOpisowStanu.Add(opisStanu);
        }

        public void DeleteOpisStanu(string nazwaGry)
        {
            for (int i = 0; i < DataContext.listaOpisowStanu.Count; i++)
            {
                OpisStanu opisStanu = DataContext.listaOpisowStanu[i];
                if (opisStanu.NazwaGry.Equals(nazwaGry))
                {
                    DataContext.listaOpisowStanu.Remove(opisStanu);
                }
            }
        }

        public OpisStanu GetOpisStanu(string nazwaGry)
        {
            foreach (OpisStanu opisStanu in DataContext.listaOpisowStanu)
            {
                if (opisStanu.NazwaGry.Equals(nazwaGry))
                {
                    return opisStanu;
                }
            }
            return null;
        }

        public List<OpisStanu> GetAllOpisStanu()
        {
            return DataContext.listaOpisowStanu;
        }

        public void AddZdarzenie(Zdarzenie zdarzenie)
        {
            DataContext.listaZdarzen.Add(zdarzenie);
        }

        public void DeleteZdarzenie(int idZdarzenia)
        {
            for (int i = 0; i < DataContext.listaZdarzen.Count; i++)
            {
                Zdarzenie zdarzenie = DataContext.listaZdarzen[i];
                if (zdarzenie.IdZdarzenia.Equals(idZdarzenia))
                {
                    DataContext.listaZdarzen.Remove(zdarzenie);
                }
            }
        }

        public Zdarzenie GetZdarzenie(int idZdarzenia)
        {
            foreach (Zdarzenie zdarzenie in DataContext.listaZdarzen)
            {
                if (zdarzenie.IdZdarzenia.Equals(idZdarzenia))
                {
                    return zdarzenie;
                }
            }
            return null;
        }

        public ObservableCollection<Zdarzenie> GetAllZdarzenie()
        {
            return DataContext.listaZdarzen;
        }
    }
}