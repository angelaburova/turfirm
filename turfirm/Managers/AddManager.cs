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
    public partial class AddManager : Form
    {
        public AddManager()
        {
            InitializeComponent();
        }

        private void AddManager_Load(object sender, EventArgs e)
        {
            textBox1.Text = (ManagerFactory.count()+1).ToString();

            for(int i=0;i<ManagerTypeCol.count();i++)
            {
                comboBox1.Items.Add(ManagerTypeCol.collection[i].Type);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string[] values;
        private void button1_Click(object sender, EventArgs e)
        {
            values = new string[5];
            
            values[0] = textBox1.Text;
            values[1] = textBox2.Text;
            values[2] = textBox3.Text;
            values[3] = comboBox1.Text;
            values[4] = textBox4.Text;
            if (check() == 1)
            {
                ManagerFactory.AddNewManager(values);

                textBox1.Text = (Convert.ToInt32(textBox1.Text) + 1).ToString();
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
                textBox4.Text = "";
            }

        }

        private int check()
        {
            for(int i=0;i<4;i++)
            {
                if (values[i] == "")
                {
                    MessageBox.Show("Complete all fields!");
                    return 0;
                }
            }
            return 1;
        }
    }
}
