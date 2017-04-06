using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using ExcelObj = Microsoft.Office.Interop.Excel;
using System.IO;


namespace turfirm
{
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
        }

 
        static public void openData()
        {
            string filename = "C:\\Users\\Angela\\Documents\\visual studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\Orders.xlsx";

            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Open(filename, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false,
                false, 0, true, 1, 0);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            
            int i = 1;
            int flag = 0;
            while (true)
            {
                dataOrders.Rows.Add(1);
                for (int j = 1; j <= dataOrders.ColumnCount; j++)
                {
                    dataOrders.Rows[i - 1].Cells[j - 1].Value = ExcelApp.Cells[i, j].Value;
                    if (dataOrders.Rows[i - 1].Cells[j - 1].Value == null)
                    {
                        flag = 1;
                        dataOrders.Rows.RemoveAt(i - 1);
                        break;

                    }

                }
                if (flag == 1) break;
                ++i;
            }

            OrderFactory obj = new OrderFactory();
        }

        private void orders_Load(object sender, EventArgs e)
        {
            
        }

        static public void ShowNewOrder(Order ord)
        {
            dataOrders.Rows.Add(ord.client.Name,ord.manager.Name,ord.DateOrder,ord.Code,ord._tour._name.Name);

            string filename = "C:\\Users\\Angela\\Documents\\visual studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\Orders.xlsx";
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Open(filename);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Cells[dataOrders.Rows.Count - 1, 1] = ord.client.Name;
            ExcelWorkSheet.Cells[dataOrders.Rows.Count - 1, 2] = ord.manager.Name;
            ExcelWorkSheet.Cells[dataOrders.Rows.Count - 1, 3] = ord.DateOrder;
            ExcelWorkSheet.Cells[dataOrders.Rows.Count - 1, 4] = ord.Code;
            ExcelWorkSheet.Cells[dataOrders.Rows.Count - 1, 5] = ord._tour._name.Name;
            

            ExcelWorkBook.Save();
            ExcelApp.Quit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrder add = new AddOrder();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkout check = new checkout();
            check.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
