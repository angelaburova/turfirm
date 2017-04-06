using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    public class Order
    {
        
        public int number;
        public Client client;
        public Manager manager;
        private string _dateOrder;
        private double _code;
        public Tour _tour;

        public Order()
        {
            
        }

        public string DateOrder
        {
            set { _dateOrder = value; }
            get { return _dateOrder; }
        }
        public double Code
        {
            set { _code = value; }
            get { return _code; }
        }

        public void IsYourClient(string nameCl)
        {
            Client[] arr = ClientFactory.AddClientToOrder();
            foreach (Client i in arr)
            {
                if(nameCl==i.Name)
                {
                    client = i;
                }
            }
        }

        public void IsYourTour(string nameTour)
        {
            Tour[] arr = TourFactory.array_Tours;
            foreach(Tour i in arr)
            {
                if(nameTour==i._name.Name)
                {
                    _tour = i;
                }
            }
        }
        public void ISYourManager(string nameMan)
        {
            Manager[] arr = ManagerFactory.AddManagerToOrder();
            foreach (Manager i in arr)
            {
                if (nameMan == i.Name)
                {
                    manager = i;
                }
            }
        }

        public void SetFields()
        {
            DateOrder = (String)orders.dataOrders[2, number].Value; 
            Code = Convert.ToDouble(orders.dataOrders[3, number].Value);
            IsYourClient((String)orders.dataOrders[0, number].Value);
            ISYourManager((String)orders.dataOrders[1, number].Value);
            IsYourTour((String)orders.dataOrders[4, number].Value);
        }
    }
}
