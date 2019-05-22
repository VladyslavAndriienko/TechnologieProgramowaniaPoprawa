﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using TP_Zadanie1_KolekcjeTestyDI_v2;

namespace TP_Zadanie1_KolekcjeTestyDI
{
    public class DataContext
    {
        public List<Wykaz> listaWykazow = new List<Wykaz>();
        public Dictionary<int, Katalog> listaKatalogow = new Dictionary<int, Katalog>();
        public List<OpisStanu> listaOpisowStanu = new List<OpisStanu>();
        public ObservableCollection<Zdarzenie> listaZdarzen = new ObservableCollection<Zdarzenie>();
    }
}