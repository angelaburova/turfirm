using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    public class TransportCol
    {
        static public Transport[] coll;
        private Dictionary<int, string> dict;

        public TransportCol()
        {
            dict = new Dictionary<int, string>();
            AddToDict();
            coll = new Transport[dict.Count];
            AddToArray();
            
        }

        public void AddToDict()
        {
            dict.Add(0,"Ж/Д");
            dict.Add(1,"Авиа");
            dict.Add(2,"Автобус");
            dict.Add(3,"Речной");

        }

        public void AddToArray()
        {
            for(int i=0;i<dict.Count;i++)
            {
                coll[i] = new Transport();
                coll[i].Name = dict[i];
            }
        }

    }
}
