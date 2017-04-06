using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    public class Manager
    {
       
        private int _code;
        public int number;
         public  string _name;
        private string _tel;
        public ManagerType _tpy;
        public string nameUser;

       public Manager()
        {
            
        }

        public string NameUser
        {
            set { nameUser = value; }
            get { return nameUser; }
        }
        public int Code
        {
            set { _code = value; }
            get { return _code; }
        }
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public string Tel
        {
            set { _tel = value; }
            get { return _tel; }
        }

        public void IsYourType(string typeManager)
        {
            _tpy = new ManagerType();
            ManagerType[] arr = ManagerTypeCol.collection;
            foreach(ManagerType i in arr)
            {
                if(typeManager==i.Type)
                {
                    _tpy = i;
                }
            }
        }

        public void SetFields()
        {
            Code = Convert.ToInt32(managers.dataManagers[0, number].Value);
            Name = managers.dataManagers[1, number].Value.ToString();
            Tel = managers.dataManagers[2, number].Value.ToString();
            IsYourType((String)managers.dataManagers[3, number].Value);
            NameUser= managers.dataManagers[4, number].Value.ToString();
        }
    }
}
