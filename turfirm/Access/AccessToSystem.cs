using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace turfirm
{
    public class AccessToSystem
    {

        public static User UserNow;
        public static List <User> list;
        static public string[] arr;
        
        public AccessToSystem()
        {
           
            list = new List<User>();
            AddUser();
           
        }
        static public void AddUser()
        {
                ReadFile();
                for (int i = 0; i < arr.Length; i++)
                {
                    try
                    {
                        string[] user=Regex.Split(arr[i], ";");
                        list.Add(new User(user[0], user[1], Convert.ToInt32(user[2])));
                        
                    
                    }
                     catch
                    {
                        break;
                    }
                }

        }

        static public void ReadFile()
        {
            string text = File.ReadAllText("C:\\Users\\Angela\\Documents\\Visual Studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\acc.txt");
             arr = Regex.Split(text, "@");
            
        }
       
  
    }
}
