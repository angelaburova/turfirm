using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turfirm.Tours
{
    public partial class AddTour : Form
    {
        public AddTour()
        {
            InitializeComponent();
            textBox1.Text = (TourFactory.count()+1).ToString();
        }

        private void AddTour_Load(object sender, EventArgs e)
        {
            for(int i=0;i<HotelFactory.count();i++)
            {
                comboBox2.Items.Add(HotelFactory.array_Hotels[i]._name);
            }

            for(int i=0;i<TourTypeCol.count();i++)
            {
                comboBox1.Items.Add(TourTypeCol.list[i].Name);
            }

            for(int i=0;i<Countries_Col.count();i++)
            {
                comboBox5.Items.Add(Countries_Col.Coll_of_country[i].Name);
            }



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        static string[] values;
        private void button1_Click(object sender, EventArgs e)
        {
            int num_fields = 10;
            
            values = new string[num_fields];
            values[0] = textBox1.Text;
            values[1] = textBox2.Text;
            values[2] = comboBox1.Text;
            values[3] = (checkBox1.Enabled).ToString();
            values[4] = comboBox2.Text;
            values[5] = comboBox3.Text;
            values[6] = comboBox4.Text;
            values[7] = textBox3.Text;
            values[8] = textBox4.Text;
            values[9] = comboBox5.Text;

            if (check(values) == 1)
            {
                TourFactory.Add_Tour(values);
                textBox1.Text = (Convert.ToInt32(textBox1.Text)+1).ToString();
                textBox2.Text = "";
                comboBox1.Text = "";
                checkBox1.Enabled = false;
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }

        }

        private int check(string [] arr)
        {

            try
            {
                int a = Convert.ToInt16(values[7]);
            }
            catch
            {
                MessageBox.Show("Enter the number in the price!");
                return 0;
            }

            for (int i = 0; i < 10; i++)
            {
                if (values[i] == "")
                {
                    MessageBox.Show("Complete all fields!");
                    return 0;
                }

            }
            return 1;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
