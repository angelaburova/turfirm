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
    public partial class Filtres : Form
    {
        public tours tour;
        public Filtres(tours b)
        {
            tour = b;
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) comboBox1.Enabled = true;
            else comboBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (check() == false) MessageBox.Show("Enter correct data!");
            else
            {
                
                    FilterCol obj = new FilterCol(this);
                obj.checkingBoxes();
                FilterContr contr = new FilterContr(obj);
                contr.filtering();

            }
            stdObj();
        }

        public void stdObj()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox8.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;

        }

        public bool check()
        {
            try
            {
                if (checkBox7.Checked == true)
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "")) return false;
                    int a = Convert.ToInt32(textBox1.Text);
                    a = Convert.ToInt32(textBox2.Text);
                }
            }
            catch
            {
                
                return false;
            }

            if ((checkBox1.Checked == true) && (comboBox1.Text == "")) return false;
            if ((checkBox2.Checked == true) && (comboBox2.Text == "")) return false;
            if ((checkBox4.Checked == true) && (comboBox4.Text == "")) return false;
            if ((checkBox5.Checked == true) && (comboBox5.Text == "")) return false;
            if ((checkBox6.Checked == true) && (comboBox6.Text == "")) return false;
            if ((checkBox8.Checked == true) && (comboBox8.Text == "")) return false;
            
            return true;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) comboBox2.Enabled = true;
            else comboBox2.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true) checkBox9.Enabled=true;
            else checkBox9.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true) comboBox4.Enabled = true;
            else comboBox4.Enabled = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true) comboBox5.Enabled = true;
            else comboBox5.Enabled = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true) comboBox6.Enabled = true;
            else comboBox6.Enabled = false;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox7.Checked==true)
            {
                label10.Enabled = true;
                label12.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else
            {
                label10.Enabled = false;
                label12.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
         
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true) comboBox8.Enabled = true;
            else comboBox8.Enabled = false;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Filtres_Load(object sender, EventArgs e)
        {
            foreach(TourType i in TourTypeCol.list)
            {
                comboBox1.Items.Add(i.Name);
            }
            foreach(Hotel i in HotelFactory.array_Hotels)
            {
                comboBox4.Items.Add(i.Name);
            }
            foreach(Country i in Countries_Col.Coll_of_country)
            {
                comboBox2.Items.Add(i.Name);
            }
            foreach (Transport i in TransportCol.coll)
            {
                comboBox5.Items.Add(i.Name);
            }
            foreach (Food i in FoodCol.coll)
            {
                comboBox6.Items.Add(i.Name);
            }


        }
    }
}
