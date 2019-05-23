using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TP_Zadanie1_KolekcjeTestyDI_v2
{
    public class DataService
    {
        private DataRepository dataRepository;

        public DataRepository DataRepository { get => dataRepository; set => dataRepository = value; }

        public DataService(DataRepository dataRepository)
        {
            this.dataRepository = dataRepository;        
        }

        public void ShowListaWykazow(List<Wykaz> listaWykazow)
        {
            foreach (Wykaz wykaz in listaWykazow)
            {
                Console.WriteLine(wykaz.ToString());
            }
        }

        public void ShowListaKatalogow(Dictionary<int, Katalog> listaKatalogow)
        {
            foreach (KeyValuePair<int, Katalog> kvp in listaKatalogow)
            {
                Console.WriteLine(kvp.Value.ToString());
            }
        }

        public void ShowListaOpisowStanu(List<OpisStanu> listaOpisowStanu)
        {
            foreach (OpisStanu opisStanu in listaOpisowStanu)
            {
                Console.WriteLine(opisStanu.ToString());
            }
        }

        public void ShowListaZdarzen(ObservableCollection<Zdarzenie> listaZdarzenia)
        {
            foreach (Zdarzenie zdarzenie in listaZdarzenia)
            {
                Console.WriteLine(zdarzenie.ToString());
            }
        }
    }
}
