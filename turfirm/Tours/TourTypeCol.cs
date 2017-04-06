using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    public class TourTypeCol
    {
        private Dictionary<int, string> dict;
        static public TourType[] list;
        public TourTypeCol()
        {
            dict = new Dictionary<int, string>();
            list = new TourType[6];
            AddToList();
            for(int i=0;i<6;i++)
            {
                list[i] = new TourType();
                list[i].Name = dict[i];
            }
        }

        public void AddToList()
        {
            dict.Add(0, "Горнолыжные туры");
            dict.Add(1, "VIP туры");
            dict.Add(2, "Экскурсионные туры");
            dict.Add(3, "Шоппинг туры");
            dict.Add(4, "Туры по России");
            dict.Add(5, "Горящие туры");
        }

       static public int count()
        {
            return list.Length;
        }
    }
}
