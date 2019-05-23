using System;

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
    }
}