using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    public class Countries_Col
    {
        
        static public Country[] Coll_of_country;
        private int counter;
        public Countries_Col()
        {
            
            for (int i = 0; i < countries.dataCountries.Rows.Count; i++)
            {
                if (countries.dataCountries[0, i].Value != null) counter++;
                else break;
            }
            Coll_of_country = new Country[counter];
            for (int i = 0; i < counter; i++)
            {
              
                    Coll_of_country[i] = new Country();
                    Coll_of_country[i].Name = (String)countries.dataCountries[1, i].Value;
                    
                
            }
        }
      

        static public Country[] addCountriesToTour()
        {
            return Coll_of_country;
        }

        static public int count()
        {
            return Coll_of_country.Length;
        }
    }
}
