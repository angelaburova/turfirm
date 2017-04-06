using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    public class User
    {
        
        private string name;
        private string password;
        public int prioritet;
        
        public User(string NewName,string newPassword,int prior)
        {
            name = NewName;
            password = newPassword;
            prioritet = prior;
            
        }

        public string Name
        {
            get { return name; }
            
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Prioritet
        {
            get { return prioritet; }
            
        }


        static public bool Check(string name, string password)
        {
            foreach(User i in AccessToSystem.list)
            {
                if(i.Name==name)
                {
                    if(i.Password==password)
                    {
                        AccessToSystem.UserNow = i;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
