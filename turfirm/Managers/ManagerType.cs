using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    public class ManagerType
    {
        private string type;
        private int prior;
        public ManagerType()
        {

        }
        public string Type
        {
            set { type = value; }
            get { return type; }
        }

        public int Prior
        {
            set { prior = value; }
            get { return prior; }
        }
    }
}
