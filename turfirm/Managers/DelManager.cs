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
    public partial class DelManager : Form
    {
        public DelManager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int code=0;
            try
            {
                code = Convert.ToInt32(textBox1.Text);
                

            }
            catch
            {
                MessageBox.Show("Enter code!");
                textBox1.Text = "";
            }
            if(code!=0)ManagerFactory.DeleteManager(code);
        }
    }
}
