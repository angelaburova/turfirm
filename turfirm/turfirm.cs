using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turfirm
{
    public partial class turfirm : Form
    {
        public turfirm()
        {
            InitializeComponent();
           
        }
        public countries form_countries=null;
        public tours form_tours = null;
        public hotels form_hotels = null;
        public clients form_clients = null;
        public managers form_managers = null;
        public orders form_orders = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        }

        private void button_tours_Click(object sender, EventArgs e)
        {
            form_tours = new tours();
            form_tours.Show();
            if (form_countries==null)
            {
                form_countries = new countries();
                countries.openData();
            }
            if(form_hotels==null)
            {
                form_hotels = new hotels();
                hotels.openData();
            }

            tours.openData();
        }

        private void button_clients_Click(object sender, EventArgs e)
        {
            form_clients = new clients();
            form_clients.Show();
            clients.openData();
        }

        private void button_managers_Click(object sender, EventArgs e)
        {
            form_managers = new managers();
            form_managers.Show();
            managers.openData();

        }

        private void button_orders_Click(object sender, EventArgs e)
        {
            form_orders = new orders();
            form_orders.Show();
            if (form_managers==null)
            {
                form_managers = new managers();
                managers.openData();
            }
            if(form_clients==null)
            {
                form_clients = new clients();
                clients.openData();
            }
            if(form_tours==null)
            {
                form_tours = new tours();
                if (form_countries == null)
                {
                    form_countries = new countries();
                    countries.openData();
                }
                if (form_hotels == null)
                {
                    form_hotels = new hotels();
                    hotels.openData();
                }

                tours.openData();
            }
            
            orders.openData();
        }

        private void _countriesutton1_Click(object sender, EventArgs e)
        {
            form_countries = new countries();
            
            form_countries.Show();
            countries.openData();
        }

        private void button_hotels_Click(object sender, EventArgs e)
        {
            form_hotels = new hotels();
            
            form_hotels.Show();
            hotels.openData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            change_password form = new change_password();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            access form = new access();
            form.Show();
            this.Close();
        }
    }
}
