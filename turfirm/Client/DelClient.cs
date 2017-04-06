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
    public partial class DelClient : Form
    {
        public DelClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int code = Convert.ToInt32(textBox1.Text);
                ClientFactory.DeleteCLient(code);
            }
            catch
            {
                MessageBox.Show("Enter code!");
            }
        }
    }
}
