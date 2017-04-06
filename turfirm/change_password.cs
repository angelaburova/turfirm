using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turfirm
{
    public partial class change_password : Form
    {
        public change_password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePass();
           
        }

        public void ChangePass()
        {
            string neww = null;
            string text1 = null;
            int j = 0;
            AccessToSystem.UserNow.Password = textBox1.Text;
            string text = File.ReadAllText("C:\\Users\\Angela\\Documents\\Visual Studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\acc.txt");
            string[] users = Regex.Split(text, "@");

            for (int i = 0; i < users.Length; i++)
            {
                string[] arr = Regex.Split(users[i], ";");
                if (AccessToSystem.UserNow.Name == arr[0])
                {
                    j = i;
                    arr[1] = textBox1.Text;
                    neww = arr[0] + ";" + arr[1] + ";" + arr[2];
                }
            }
            for (int i = 0; i < users.Length; i++)
            {
                if (i == j) text1 = text1 + neww + "@";
                else
                    text1 = text1 + users[i] + "@";
            }

            File.WriteAllText("C:\\Users\\Angela\\Documents\\Visual Studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\acc.txt", text1);
        }

        private void change_password_Load(object sender, EventArgs e)
        {

        }
    }
}
