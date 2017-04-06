using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turfirm
{
    public partial class checkout : Form
    {
        public checkout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            int code = 0;
            Order ord = null;
            try
            {
                code = Convert.ToInt32(textBox2.Text);
                flag = 1;
            }
            catch
            {
                MessageBox.Show("Enter code!");
                flag = 0;
            }
            if (flag == 1)
            {
                foreach (Order i in OrderFactory.array_of_Orders)
                {
                    if (i.Code == code)
                    {
                        ord = i;
                    }
                }
                if (ord != null)
                {
                    string path = "C:\\Users\\Angela\\Documents\\Visual Studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\" + code.ToString() + ".rtf";
                    FileStream fstream = new FileStream(path, FileMode.Open, FileAccess.Write);
                    StreamWriter newfile = new StreamWriter(fstream, Encoding.Unicode);
                    newfile.WriteLine("Заказ № " + ord.Code);
                    newfile.WriteLine("ФИО заказчика: " + ord.client.Name);
                    newfile.WriteLine("Сотрудник: " + ord.manager._tpy.Type + " " + ord.manager.Name);
                    newfile.WriteLine("Дата заключения договора: " + ord.DateOrder);
                    newfile.WriteLine("Название тура: " + ord._tour._name.Name);
                    newfile.WriteLine("Сумма заказа: " + ord._tour._cost.Value);
                    newfile.Close();

                    richTextBox1.LoadFile(path, RichTextBoxStreamType.UnicodePlainText);
                }
                else
                {
                    MessageBox.Show("This order doesn't exist!");
                }
            }
        }
    }
}
