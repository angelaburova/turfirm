using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    public class HotelFactory
    {
        static public Hotel[] array_Hotels;
        
        private int counter;
        public HotelFactory()
        {
            
            for (int i = 0; i < hotels.dataHotels.Rows.Count; i++)
            {
                if (hotels.dataHotels[0, i].Value!=null) counter++;
                else break;
            }
              array_Hotels = new Hotel[counter];
            for(int i=0;i<counter;i++)
            {
               
                    array_Hotels[i] = new Hotel();
                    array_Hotels[i].number = i;
                    array_Hotels[i].SetFields();
                                                                    
            }

            
        }

       static public int count()
        {
            return array_Hotels.Length;
        }
        static public Hotel[] addHotelToFirm()
        {
            return array_Hotels;
        }
    }
}
