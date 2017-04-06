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
    public partial class DelTour : Form
    {
        public DelTour()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int code = Convert.ToInt32(textBox1.Text);
                TourFactory.DeleteTour(code);
            }
            catch
            {
                MessageBox.Show("Enter the number!");
            }
            

        }
    }
}
