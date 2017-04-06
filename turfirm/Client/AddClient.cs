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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        static string[] values;
        private void button1_Click(object sender, EventArgs e)
        {
            int num_fields = 7;

            values = new string[num_fields];
            values[0] = textBox1.Text;
            values[1] = textBox2.Text;
            values[2] = textBox3.Text;
            values[3] = textBox4.Text;
            values[4] = textBox5.Text;
            values[5] = (checkBox1.Enabled).ToString();
            values[6] = comboBox1.Text;
            

            if (check(values) == 1)
            {
                ClientFactory.AddClient(values);
                textBox1.Text = (Convert.ToInt32(textBox1.Text) + 1).ToString();
                textBox2.Text = "";
                textBox3.Text = "";
                checkBox1.Enabled = false;
                textBox4.Text = "";
                textBox5.Text = ""; 
                comboBox1.Text = "";
                
            }

        }
        private int check(string[] arr)
        {


            for (int i = 0; i < 7; i++)
            {
                if (values[i] == "")
                {
                    MessageBox.Show("Complete all fields!");
                    return 0;
                }

            }
            return 1;
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            textBox1.Text = (ClientFactory.count() + 1).ToString();
            for (int i=0;i<ClientTypeCol.count();i++)
            {
                comboBox1.Items.Add(ClientTypeCol.coll_of_type[i].Type);
            }
        }
    }
    
}
