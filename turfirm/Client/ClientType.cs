using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    public class ClientType
    {
        private int _prioritet;
        private string _type;

        public int Prioritet
        {
            set { _prioritet = value; }
            get { return _prioritet; }
        }
        public string Type
        {
            set { _type = value; }
            get { return _type; }
        }
        public ClientType()
        {

        }
       static public ClientType[] addClient()
        {
            return ClientTypeCol.coll_of_type;
        }
    }
}
