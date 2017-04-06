using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    abstract public class field
    {
        protected string name;
        virtual public string Name
        {
            set { name = value; }
            get { return name; }
        }
    }

    public class Food :field { }
    public class TourType:field { }
    public class Hotel :field
    {
       
        private int _code;
        public int number;
        public string _name;
        private string _rating;
        private double _cost;

        
        private int Code
        {
            set { _code = Convert.ToInt32(hotels.dataHotels[0, value].Value); }
            get { return _code; }
        }
        override public string Name
        {
            set { _name = (String)hotels.dataHotels[1, Convert.ToInt32(value, 10)].Value; }
            get { return _name; }
        }
        private string Rating
        {
            set { _rating = (String)hotels.dataHotels[2, Convert.ToInt32(value, 10)].Value; }
            get { return _rating; }
        }
        private double Cost
        {
            set { _cost = Convert.ToDouble(hotels.dataHotels[3, Convert.ToInt32(value)].Value); }
            get { return _cost; }
        }

        public void SetFields()
        {
            Code = number;
            Name = number.ToString();
            Rating = number.ToString();
            Cost = number;
        }
    }
    public class Country :field { }
    public class Transport :field { }
    public class Name :field { }
    public class Cost :field
    {
        new private double name;
        public double Value
        {
            set { name = value; }
            get { return name; }
        }
    }
    public class Valuta :field { }
   
    public class Code :field
    {
        new private int name;
        public int Value
        {
            set { name = value; }
            get { return name; }
        }
    }
    public class Visa : field
    {
        new private bool name;

        public bool Value
        {
            set { name = value; }
            get { return name; }
        }
    }

}
