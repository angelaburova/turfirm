using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    public class OrderFactory
    {
        
        public static Order[] array_of_Orders;
        private int counter;

        public OrderFactory()
        {
            
            for (int i = 0; i < orders.dataOrders.Rows.Count; i++)
            {
                if (orders.dataOrders[0, i].Value != null) counter++;
                else break;
            }
            array_of_Orders = new Order[counter];
            for(int i=0;i<counter;i++)
            {
                    array_of_Orders[i] = new Order();
                    array_of_Orders[i].number = i;
                    array_of_Orders[i].SetFields();
                
            }
        }

        static public int count()
        {
            return array_of_Orders.Length;
        }

        static public void AddOrder(string[] arr)
        {
            Order newOrder = new Order();
            newOrder.Code = Convert.ToDouble(arr[0]);
            newOrder.ISYourManager(arr[1]);
            newOrder.IsYourClient(arr[2]);
            newOrder.DateOrder = arr[3];
            newOrder.IsYourTour(arr[4]);

            Order[] new_arr = new Order[count() + 1];
            for (int i = 0; i < new_arr.Length; i++)
            {
                if (i == new_arr.Length - 1)
                {
                    new_arr[i] = newOrder;
                    break;
                }
                new_arr[i] = array_of_Orders[i];
            }
            array_of_Orders = new_arr;
            new_arr = null;
           orders.ShowNewOrder(newOrder);
        }
    }
}
