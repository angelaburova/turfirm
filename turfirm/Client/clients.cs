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

namespace turfirm
{
    public partial class clients : Form
    {
        public clients()
        {
            InitializeComponent();
        }

        static public void openData()
        {
            string filename = "C:\\Users\\Angela\\Documents\\Visual Studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\Clients.xlsx";

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
                dataClients.Rows.Add(1);
                for (int j = 1; j <= dataClients.ColumnCount; j++)
                {
                    dataClients.Rows[i - 1].Cells[j - 1].Value = ExcelApp.Cells[i, j].Value;
                    if (dataClients.Rows[i - 1].Cells[0].Value == null)
                    {
                        flag = 1;
                        dataClients.Rows.RemoveAt(i - 1);
                        break;
                    }
                }
                if (flag == 1) break;
                ++i;
            }
            ClientTypeCol col = new ClientTypeCol();
            ClientFactory obj = new ClientFactory();
        }

        private void clients_Load(object sender, EventArgs e)
        {
           
        }

        static public void ShowNewClient(Client newClient)
        {
            dataClients.Rows.Add(newClient.Code, newClient.Name, newClient.Email, newClient.Tel, newClient.DateBd, newClient.Passport, newClient._tpy.Type);
            string filename = "C:\\Users\\Angela\\Documents\\visual studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\Clients.xlsx";
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Open(filename);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Cells[dataClients.Rows.Count - 1, 1] = newClient.Code;
            ExcelWorkSheet.Cells[dataClients.Rows.Count - 1, 2] = newClient.Name;
            ExcelWorkSheet.Cells[dataClients.Rows.Count - 1, 3] = newClient.Email;
            ExcelWorkSheet.Cells[dataClients.Rows.Count - 1, 4] = newClient.Tel;
            ExcelWorkSheet.Cells[dataClients.Rows.Count - 1, 5] = newClient.DateBd;
            ExcelWorkSheet.Cells[dataClients.Rows.Count - 1, 6] = newClient.Passport;
            ExcelWorkSheet.Cells[dataClients.Rows.Count - 1, 7] = newClient._tpy.Type;

            ExcelWorkBook.Save();
            ExcelApp.Quit();

        }

        static public void DeleteClient(int code)
        {
            int j = 0;
            for (int i = 0; i < dataClients.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataClients[0, i].Value) == code)
                {
                    j = i;
                    dataClients.Rows.RemoveAt(i);
                    break;
                }
            }
            string filename = "C:\\Users\\Angela\\Documents\\visual studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\Clients.xlsx";
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Open(filename);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);


            Microsoft.Office.Interop.Excel.Range rg = (Microsoft.Office.Interop.Excel.Range)ExcelWorkSheet.Rows[j + 1];
            rg.Delete(Microsoft.Office.Interop.Excel.XlDeleteShiftDirection.xlShiftUp);
            ExcelWorkBook.Save();
            ExcelApp.Quit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User n = AccessToSystem.UserNow;
            
            if (AccessToSystem.UserNow.Prioritet <= 2)
            {
                AddClient form = new AddClient();
                form.Show();
            }
            else
            {
                MessageBox.Show("You don't have access!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AccessToSystem.UserNow.Prioritet <= 2)
            {
                DelClient form = new DelClient();
                form.Show();
            }
            else
            {
                MessageBox.Show("You don't have access!");
            }
        }
    }
}
