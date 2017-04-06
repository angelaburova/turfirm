using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    public class ClientFactory
    {
        private static Client[] array_Clients;
        
        private int counter;

        public ClientFactory()
        {
            
            for (int i = 0; i < clients.dataClients.Rows.Count; i++)
            {
                if (clients.dataClients[0, i].Value != null) counter++;
                else break;
            }
            array_Clients = new Client[counter];
            for(int i=0;i<counter;i++)
            {
                
                    array_Clients[i] = new Client();
                    array_Clients[i].number = i;
                    array_Clients[i].SetFileds();
            }
        }

        static public Client[] AddClientToOrder()
        {
            return array_Clients;
        }

        static public void AddClient(string[] arr)
        {
            Client newClient = new Client();
            newClient.Code = Convert.ToInt32(arr[0]);
            newClient.Name = arr[1];
            newClient.Email = arr[2];
            newClient.Tel = arr[3];
            newClient.DateBd = arr[4];
            newClient.Passport = Convert.ToBoolean(arr[5]);
            newClient.IsYourType(arr[6]);

            Client[] new_arr = new Client[count() + 1];
            for (int i = 0; i < new_arr.Length; i++)
            {
                if (i == new_arr.Length - 1)
                {
                    new_arr[i] = newClient;
                    break;
                }
                new_arr[i] = array_Clients[i];
            }
            array_Clients = new_arr;
            new_arr = null;
            clients.ShowNewClient(newClient);
        }

        static public int count()
        {
            return array_Clients.Length;
        }

        static public void DeleteCLient(int code)
        {
            for (int i = 0; i < count(); i++)
            {
                if (array_Clients[i].Code == code)
                {
                    array_Clients[i] = null;
                }
            }

            Client[] arr = new Client[count() - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (array_Clients[i] == null) continue;
                arr[i] = array_Clients[i];
            }

            array_Clients = arr;
            arr = null;

            clients.DeleteClient(code);
        }
    }
}
