using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    public class FoodCol
    {

        static public Food[] coll;
        private Dictionary<int, string> dict;

        public FoodCol()
        {
            dict = new Dictionary<int, string>();
            AddToDict();
            coll = new Food[dict.Count];
            AddToArray();

        }

        public void AddToDict()
        {
            dict.Add(0, "HB+");
            dict.Add(1, "FB+");
            dict.Add(2, "RO");
            dict.Add(3, "AIP");
            dict.Add(4, "HB");
            dict.Add(5, "FB");
            dict.Add(6, "AL");
            dict.Add(7, "BB");
            dict.Add(8, "UAI");
            

        }

        public void AddToArray()
        {
            for (int i = 0; i < dict.Count; i++)
            {
                coll[i] = new Food();
                coll[i].Name = dict[i];
            }
        }
    }
}
