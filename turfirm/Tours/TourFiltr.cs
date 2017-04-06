using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    class TourFiltr
    {
        static public List <Tour> filtrTours;

        public void addTour(Tour tour)
        {
            filtrTours.Add(tour);
        }

        static public void fun()
        {
            int a = 1;
            foreach(Tour i in filtrTours)
            {
                a++;
            }
        }
        public TourFiltr()
        {
            filtrTours = new List<Tour>();
        }
        static public int count()
        {
            return filtrTours.Count();
        }
    }
}
