using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    abstract public class Filter
    {
         protected string value;
        protected string type;

        
        virtual public void setType(string newType) { type = newType; }
        virtual public void setValue(string newValue) { value = newValue; }
        virtual public bool check(Tour tour) { return true; }
        

    }

    class typeFilter: Filter
    {
      override public bool check(Tour tour)
        {
            if (tour._type.Name == value)
            {
                return true;
            }
            else return false;
        }
    }
    class countryFilter:Filter
    {
        override public bool check(Tour tour)
        {
            if (tour._country.Name == value)
            {
                return true;
            }
            else return false;
        }
    }
    class hotelFilter: Filter
    {
       override public bool check(Tour tour)
        {
            if (tour._hotel.Name == value)
            {
                return true;
            }
            else return false;
        }
    }
    class transportFilter:Filter
    {
        override public bool check(Tour tour)
        {
            if (tour._transport.Name == value)
            {
                return true;
            }
            else return false;
        }
    }

    class foodFilter : Filter
    {
        override public bool check(Tour tour)
        {
            if (tour._food.Name == value)
            {
                return true;
            }
            else return false;
        }
    }
    class priceFromFilter:Filter
    {
        override public bool check(Tour tour)
        {
            if (tour._cost.Value > Convert.ToDouble(value))
            {
                return true;
            }
            else return false;
        }
    }
    class priceToFilter : Filter
    {
        override public bool check(Tour tour)
        {
            if (tour._cost.Value < Convert.ToDouble(value))
            {
                return true;
            }
            else return false;
        }
    }
    class valutaFilter : Filter
    {
        override public bool check(Tour tour)
        {
            if (tour._valuta.Name == value)
            {
                return true;
            }
            else return false;
        }
    }
    class visaFilter:Filter
    {
        override public bool check(Tour tour)
        {
            if (tour._visa.Value == Convert.ToBoolean(value))
            {
                return true;
            }
            else return false;
        }
    }
       

        
    
}
