using System;
using System.Collections.Generic;

namespace turfirm
{
   public class Tour
    {
       
        public int number;
        public Code _code;
        public Name _name;
        public TourType _type;
        public Country _country;
        public Visa _visa;
        public Hotel _hotel;
        public Transport _transport;
        public Food _food;
        public Cost _cost;
        public Valuta _valuta;

        public Tour()
        {
            _code = new Code();
            _name = new Name();
            _visa = new Visa();
            _transport = new Transport();
            _food = new Food();
            _cost = new Cost();
            _valuta = new Valuta();
        }
       
        public void Transport(string nameTransport)
        {
            Transport[] arr = TransportCol.coll;
            foreach(Transport i in arr)
            {
                if(nameTransport==i.Name)
                {
                    _transport = i;
                }
            }
        }
        public void Food(string nameFood)
        {
            Food []arr = FoodCol.coll;
            foreach(Food i in arr)
            {
                if (nameFood == i.Name)
                {
                    _food = i;
                }
            }
        }
       

      
        public void Type( string nameType)
        {
            TourType[] arr = TourTypeCol.list;
            _type = new TourType();
            foreach(TourType i in arr)
            {
                if(nameType==i.Name)
                {
                    _type = i;
                }
            }
        }

        public void Hotel(string nameHotel)
        {
            Hotel[] arr = HotelFactory.addHotelToFirm();
            foreach (Hotel i in arr )
            {
                if(i._name==nameHotel)
                {
                    _hotel = i;
                }
            }
        }
        public void Country(string country)
        {
            Country[] arr = Countries_Col.Coll_of_country;
            foreach (Country i in arr)
            {
                if (i.Name==country)
                {
                    _country = new Country();
                    _country = i;
                }
            }
        }

        public void SetFields()
        {
            

            _code.Value = Convert.ToInt32(tours.dataTours[0, number].Value);
            _name.Name = (String)tours.dataTours[1, number].Value;
             Transport((String)tours.dataTours[6, number].Value);
             Food((String)tours.dataTours[7, number].Value);
            _cost.Value = Convert.ToDouble(tours.dataTours[8, number].Value);
            _valuta.Name = (String)tours.dataTours[9, number].Value;
            _visa.Value=(Convert.ToBoolean(tours.dataTours[4, number].Value));
            Type((String)tours.dataTours[2, number].Value);
            Hotel((String)tours.dataTours[5, number].Value);
            Country((String)tours.dataTours[3, number].Value);


        }
    }
}
