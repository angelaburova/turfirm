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
    public partial class access : Form
    {
        public access()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            AccessToSystem obj = new AccessToSystem();
           
            if(User.Check(name,password))
            {
                this.Hide();
                turfirm mainform = new turfirm();
                mainform.Show();
               

        }
            else
            {
                MessageBox.Show("You entered incorrect password or name of user. Try again. ","Error",MessageBoxButtons.OK);
            }
            
        }

        private void access_Load(object sender, EventArgs e)
        {
           
        }
    }
}
