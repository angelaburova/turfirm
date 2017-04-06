using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    public class ManagerFactory
    {

        
        public static Manager[] array_of_Managers;
        private int counter;
        static private string path = "C:\\Users\\Angela\\Documents\\Visual Studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\acc.txt";
        public ManagerFactory()
        {
            
            for (int i = 0; i < managers.dataManagers.Rows.Count; i++)
            {
                if (managers.dataManagers[0, i].Value != null) counter++;
                else break;
            }
            array_of_Managers = new Manager[counter];
            for(int i=0;i<counter;i++)
            {
             
                    array_of_Managers[i] = new Manager();
                    array_of_Managers[i].number = i;
                    array_of_Managers[i].SetFields();
                
            }
            int n = count();
        }

        static public Manager[] AddManagerToOrder()
        {
            return array_of_Managers;
        }

        static public int count()
        {
            return array_of_Managers.Length;
        }

        static public void AddNewManager(string []arr)
        {
            
            Manager newManager = new Manager();
            newManager.Code = Convert.ToInt32(arr[0]);
            newManager.Name = arr[1];
            newManager.Tel = arr[2];
            newManager.IsYourType(arr[3]);
            newManager.NameUser = arr[4];

            Manager[] new_arr = new Manager[count() + 1];
            for(int i=0;i<new_arr.Length;i++)
            {
                if(i==new_arr.Length-1)
                {
                    new_arr[i] = newManager;
                    break;
                }
                new_arr[i] = array_of_Managers[i];
            }
            array_of_Managers = new_arr;
            new_arr = null;
            
            AccessToSystem.list.Add(new User(newManager.NameUser, "password", newManager._tpy.Prior));
            AddUserToAccessFile(newManager);
            managers.ShowNewManager(newManager);
            
        }
        static public void AddUserToAccessFile(Manager user)
        {

            using (StreamWriter sw = File.AppendText(path))
            {
                    sw.WriteLine("@"+user.NameUser+";"+"password"+";"+user._tpy.Prior);
                }
            
        }
        static public void DeleteUserFromAccessFile(int code)
        {
            int j = 0;
           for(int i=0;i<managers.dataManagers.Rows.Count;i++)
            {
                if(Convert.ToInt32(managers.dataManagers[0,i].Value)==code)
                {
                    j = i;
                }
            }
            string[] readText = System.IO.File.ReadAllLines(path);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, false))
            {

                for (int i = 0; i < readText.Length; i++)
                {
                    if (i != j)// if(i!=1)
                        file.WriteLine(readText[i]);
                }
            }
        }

        static public void DeleteManager(int code)
        {
            for(int i=0;i<count();i++)
            {
                if(array_of_Managers[i].Code==code)
                {
                    array_of_Managers[i] = null;
                }
            }

            Manager[] arr = new Manager[count() - 1];
            for(int i=0;i<arr.Length;i++)
            {
                if (array_of_Managers[i] == null) continue;
                arr[i] = array_of_Managers[i];
            }

            array_of_Managers = arr;
            arr = null;
            DeleteUserFromAccessFile(code);
            managers.DeleteManager(code);
        }
    }
}
