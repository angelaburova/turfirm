using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using turfirm;

namespace tests
{
    [TestClass]
    public class tests
    {

        [TestMethod]
        public void checkDelManager()
        {
            managers form = new managers();
            //add 3 records
            managers.dataManagers.Rows.Add("1", "Petya", "8888", "Менеджер", "petya");
            managers.dataManagers.Rows.Add("2", "Vasya", "6666", "Менеджер", "vas");
            managers.dataManagers.Rows.Add("3", "Egor", "3333", "Менеджер", "egor");

            ManagerTypeCol coll = new ManagerTypeCol();
            ManagerFactory fact = new ManagerFactory();
            int a = ManagerFactory.count();
            ManagerFactory.DeleteManager(1);
            Assert.AreEqual(a-1, ManagerFactory.count());
        }


        [TestMethod]
        public void checkAddManager()
        {
            //new manager
            string[] manager = new string[5];
            manager[0] = "125";
            manager[1] = "John";
            manager[2] = "893-88";
            manager[3] = "Генеральный директор";
            manager[4] = "user";

            //create form with table
            managers form = new managers();
            //add 3 records
            managers.dataManagers.Rows.Add("1", "Petya", "8888", "Менеджер", "petya");
            managers.dataManagers.Rows.Add("2", "Vasya", "6666", "Менеджер", "vas");
            managers.dataManagers.Rows.Add("3", "Egor", "3333", "Менеджер", "egor");

            ManagerTypeCol coll = new ManagerTypeCol();
            ManagerFactory fact = new ManagerFactory();
            int a = ManagerFactory.count();
            ManagerFactory.AddNewManager(manager);
            Assert.AreEqual(a+1, ManagerFactory.count());
        }

        [TestMethod]
        public void checkDelClien()
        {

            clients form = new clients();
            clients.dataClients.Rows.Add("1", "Petya", "1@gmail.com", "88-88", "12 may 1990", "true", "VIP");
            clients.dataClients.Rows.Add("2", "Vasya", "12gmail.com", "66-66", "13 may 1990", "false", "VIP");
            clients.dataClients.Rows.Add("3", "Egor", "123@gmail.com", "333-3", "14 may 1990", "true", "VIP");

            ClientTypeCol col = new ClientTypeCol();
            ClientFactory fact = new ClientFactory();
            int a = ClientFactory.count();
            ClientFactory.DeleteCLient(1);
            Assert.AreEqual(a - 1, ClientFactory.count());

        }

        [TestMethod]
        public void checkAddClien()
        {
            string[] client = new string[7];
            client[0] = "225";
            client[1] = "Petr";
            client[2] = "petr@gmail.com";
            client[3] = "8932422-34";
            client[4] = "11 may 1990";
            client[5] = "true";
            client[6] = "VIP";

            clients form = new clients();
            clients.dataClients.Rows.Add("1", "Petya","1@gmail.com", "88-88", "12 may 1990", "true", "VIP");
            clients.dataClients.Rows.Add("2", "Vasya", "12gmail.com", "66-66", "13 may 1990",  "false", "VIP");
            clients.dataClients.Rows.Add("3", "Egor", "123@gmail.com", "333-3", "14 may 1990",  "true", "VIP");

            ClientTypeCol col = new ClientTypeCol();
            ClientFactory fact = new ClientFactory();
            int a = ClientFactory.count();
            ClientFactory.AddClient(client);
            Assert.AreEqual(a + 1, ClientFactory.count());

        }
        [TestMethod]
        public void checkAddOrder()
        {
            string[] order = new string[7];
            order[0] = "225";
            order[1] = "Petr";
            order[2] = "Vasya";
            order[3] = "12 may 2013";
            order[4] = "tour";

            clients formCL = new clients();
            clients.dataClients.Rows.Add("1", "Pet", "1@gmail.com", "88-88", "12 may 1990", "true", "VIP");
            ClientTypeCol col = new ClientTypeCol();
            ClientFactory factCl = new ClientFactory();

            managers formMan = new managers();
            managers.dataManagers.Rows.Add("1", "Petya", "8888", "Менеджер", "petya");
            ManagerTypeCol coll = new ManagerTypeCol();
            ManagerFactory factMan = new ManagerFactory();

            orders formOrd = new orders();
            orders.dataOrders.Rows.Add( "Pet", "Petya", "12 may 2015","1", "tour1");
            orders.dataOrders.Rows.Add( "Pet", "Petya", "13 may 2014","2",  "tou2");
            orders.dataOrders.Rows.Add( "Pet", "Petya", "14 may 2014","3", "tou3");

            countries contr = new countries();
            countries.dataCountries.Rows.Add("1","Россия");
            Countries_Col obj = new Countries_Col();

            hotels hot = new hotels();
            hotels.dataHotels.Rows.Add("1", "hotel", "****", "12000");
            HotelFactory hotelfac = new HotelFactory();

            FoodCol food = new FoodCol();
            TransportCol tr = new TransportCol();
            TourTypeCol tourtype = new TourTypeCol();

            tours formTour = new tours();
            tours.dataTours.Rows.Add("1","tour","VIP туры", "Россия","true","hotel","Автобус","BB","12000","Рубль");
            TourFactory factTour = new TourFactory();
            OrderFactory fact = new OrderFactory();
            int a = OrderFactory.count();
            OrderFactory.AddOrder(order);
            Assert.AreEqual(a + 1, OrderFactory.count());

        }
        [TestMethod]
        public void checkDelTour()
        {

            countries contr = new countries();
            countries.dataCountries.Rows.Add("1", "Америка");
            Countries_Col obj = new Countries_Col();

            hotels hot = new hotels();
            hotels.dataHotels.Rows.Add("1", "hotel", "****", "12000");
            HotelFactory hotelfac = new HotelFactory();

            tours formTour = new tours();
            tours.dataTours.Rows.Add("1", "tour", "VIP туры", "Россия", "True", "hotel", "Автобус", "BB", "12000", "Рубль");
            tours.dataTours.Rows.Add("2", "tour", "VIP туры", "Россия", "True", "hotel", "Автобус", "BB", "12000", "Рубль");
            tours.dataTours.Rows.Add("3", "tour", "VIP туры", "Россия", "True", "hotel", "Автобус", "BB", "12000", "Рубль");

            FoodCol food = new FoodCol();
            TransportCol tr = new TransportCol();
            TourTypeCol tourtype = new TourTypeCol();

            TourFactory factTour = new TourFactory();
            int a = TourFactory.count();
            TourFactory.DeleteTour(1);
            Assert.AreEqual(a - 1, TourFactory.count());
        }
        [TestMethod]
        public void checkAddTour()
        {

            string[] tour= new string[10];
            tour[0] = "2";
            tour[1] = "tour1";
            tour[2] = "VIP туры";
            tour[3] = "true";
            tour[4] = "hotel";
            tour[5] = "Авиа";
            tour[6] = "HB";
            tour[7] = "35500";
            tour[8] = "Доллар";
            tour[9] = "Америка";

            countries contr = new countries();
            countries.dataCountries.Rows.Add("1", "Америка");
            Countries_Col obj = new Countries_Col();

            hotels hot = new hotels();
            hotels.dataHotels.Rows.Add("1", "hotel", "****", "12000");
            HotelFactory hotelfac = new HotelFactory();

            tours formTour = new tours();
            tours.dataTours.Rows.Add("1", "tour", "VIP туры",  "Россия", "True", "hotel", "Автобус", "BB", "12000", "Рубль");

            FoodCol food = new FoodCol();
            TransportCol tr = new TransportCol();
            TourTypeCol tourtype = new TourTypeCol();

            TourFactory factTour = new TourFactory();
            int a = TourFactory.count();
            TourFactory.Add_Tour(tour);
            Assert.AreEqual(a + 1, TourFactory.count());
        }

        [TestMethod]
        public void checkWrongPassword()
        {
            AccessToSystem acc = new AccessToSystem();
            Assert.AreNotEqual(User.Check("Anisimov", "fjdsfadfaf"), true);

        }
        
        [TestMethod]
        public void checkCorrectPassword()
        {
            AccessToSystem acc = new AccessToSystem();
            Assert.AreEqual(User.Check("Anisimov", "password"),true);
        }

        [TestMethod]
        public void changePassword()
        {
            AccessToSystem acc = new AccessToSystem();
            User.Check("Anisimov", "password");

            change_password form = new change_password();
            form.textBox1.Text = "pass";
            form.ChangePass();

            Assert.AreEqual(User.Check("Anisimov","pass"),true);

        }


    }
}
