using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    public class TourFactory
    {
        
        static public Tour[] array_Tours;
        static private Tour new_tour;
        private int counter;

        public TourFactory()
        {
            for (int i = 0; i < tours.dataTours.Rows.Count; i++)
            {
                if (tours.dataTours[0, i].Value != null) counter++;
                else break;
            }
            array_Tours = new Tour[counter];
            for(int i=0;i< counter;i++)
            {
                    array_Tours[i] = new Tour();
                    array_Tours[i].number = i;
                    array_Tours[i].SetFields();
            }


        }

        static public Tour[] getTours()
        {
            return array_Tours;
        }

        static public int count()
        {
            return array_Tours.Length;
        }

        static public void Add_Tour(string[] tour)
        {
           
            new_tour = new Tour();
            new_tour._code.Value = Convert.ToInt32(tour[0]);
            new_tour._name.Name = tour[1];
            new_tour.Type(tour[2]);
            new_tour._visa.Value=Convert.ToBoolean(tour[3]);
            new_tour.Hotel(tour[4]);
            new_tour.Transport(tour[5]);
            new_tour._food.Name = tour[6];
            new_tour._cost.Value = Convert.ToDouble(tour[7]);
            new_tour._valuta.Name = tour[8];
            new_tour.Country(tour[9]);

            Tour[] new_arr = new Tour[count() + 1];
            for (int i = 0; i < new_arr.Length; i++)
            {
                if (i == new_arr.Length - 1)
                {
                    new_arr[i] = new_tour;
                    break;
                }
                new_arr[i] = array_Tours[i];
            }
            array_Tours = new_arr;
            new_arr = null;
            tours.ShowNewTour(new_tour);



        }

        static public void DeleteTour(int code)
        {
           
            for(int i=0;i<count();i++)
            {
                if(array_Tours[i]._code.Value==code)
                {
                    array_Tours[i] = null;
                }
                    
            }

            Tour[] arr = new Tour[count() - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (array_Tours[i] == null) continue;
                arr[i] = array_Tours[i];
            }

            array_Tours = arr;
            arr = null;
            tours.DeleteNewTour(code);
        }
    }
}
