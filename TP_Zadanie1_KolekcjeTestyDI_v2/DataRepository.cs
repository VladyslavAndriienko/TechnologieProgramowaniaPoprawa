using System.Collections.Generic;

using TP_Zadanie1_KolekcjeTestyDI;

namespace TP_Zadanie1_KolekcjeTestyDI_v2
{
    class DataRepository
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
    }
}
