using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    class FilterContr
    {
        
        private Tour[] allTours;
        private TourFiltr filtrationTours;
        
        public FilterContr(FilterCol obj)
        {
            filtrationTours = new TourFiltr();
            
            allTours = TourFactory.getTours();
        }

        public void filtering()
        {
            foreach(Tour i in allTours)
            {
                bool res=true;
                foreach(Filter j in FilterCol.filtres)
                    if(!(res=j.check(i))) break;
                    if(res) filtrationTours.addTour(i);

            }
           
            tours.ShowFiltrTours(TourFiltr.filtrTours);
        }

        
    }
}
