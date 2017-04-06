using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    public class ClientTypeCol
    {
        static public ClientType[] coll_of_type;
        public Dictionary<int, string> dict;

        public ClientTypeCol()
        {
            dict = new Dictionary<int, string>();
            Add();
            coll_of_type = new ClientType[4];
            for(int i=1;i<=4;i++)
            {
                coll_of_type[i-1] = new ClientType();
                coll_of_type[i-1].Type = dict[i];
                coll_of_type[i-1].Prioritet = i;
            }
        }
        
        public void Add()
        {
            dict.Add(4, "New");
            dict.Add(3, "Regular");
            dict.Add(2, "Aged");
            dict.Add(1, "VIP");
        }

        static public int count()
        {
            return coll_of_type.Length;
        }
    }
}
