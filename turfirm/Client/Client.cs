using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    public class Client
    {
        
        public int number;
        private int _code;
        public string _name;
        private string _email;
        private string _tel;
        private string _dateBd;
        private bool _passport;
        public ClientType _tpy;

        public Client()
        {
            
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
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        public string Tel
        {
            set { _tel = value; }
            get { return _tel; }
        }
        public string DateBd
        {
            set { _dateBd = value; }
            get { return _dateBd; }
        }
        public bool Passport
        {
         
               set { _passport = value; }
            get { return _passport; }
        }

        public void IsYourType(string typeClient)
        {
            ClientType[] arr = ClientType.addClient();
            _tpy = new ClientType();
            
            foreach(ClientType i in arr)
            {
                if(i.Type==typeClient)
                {
                    _tpy = i;
                }
            }
            
        }

        public void SetFileds()
        {
            Code = Convert.ToInt32(clients.dataClients[0, number].Value);
            Name = (String)clients.dataClients[1, number].Value; ;
            Email = (String)clients.dataClients[2, number].Value;
            Tel = (String)clients.dataClients[3, number].Value;
            DateBd = (String)clients.dataClients[4, number].Value;
            Passport= Convert.ToBoolean(clients.dataClients[5, number].Value);

            IsYourType((String)clients.dataClients[6, number].Value);

        }

    }
}
