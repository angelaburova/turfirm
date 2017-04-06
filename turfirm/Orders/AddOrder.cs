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
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            textBox1.Text = (OrderFactory.count() + 1).ToString();

            for (int i = 0; i < ManagerTypeCol.count(); i++)
            {
                comboBox1.Items.Add(ManagerTypeCol.collection[i].Type);
            }

            for (int i = 0; i < ClientTypeCol.count(); i++)
            {
                comboBox2.Items.Add(ClientTypeCol.coll_of_type[i].Type);
            }
            for (int i = 0; i < TourFactory.count(); i++)
            {
                comboBox3.Items.Add(TourFactory.array_Tours[i]._name.Name);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(check()==0)
            {
                MessageBox.Show("Enter all fields!");
            }
            else
            {
                string[] arr = new string[5];
                arr[0] = textBox1.Text;
                arr[1] = comboBox1.Text;
                arr[2] = comboBox2.Text;
                arr[3] = textBox2.Text;
                arr[4] = comboBox3.Text;
                OrderFactory.AddOrder(arr);
            }
        }

        private int check()
        {
            if ((textBox1.Text == "") || (comboBox1.Text == "") || (comboBox2.Text == "") || (textBox2.Text == "")||(comboBox3.Text=="")) return 0;
            else return 1;
        }
    }
}
