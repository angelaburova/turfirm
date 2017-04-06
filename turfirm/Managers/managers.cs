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
    public partial class managers : Form
    {
        public managers()
        {
            InitializeComponent();
        }

        static public void openData()
        {
            string filename = "C:\\Users\\Angela\\Documents\\visual studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\Managers.xlsx";

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
                dataManagers.Rows.Add(1);
                for (int j = 1; j <= dataManagers.ColumnCount; j++)
                {
                    dataManagers.Rows[i - 1].Cells[j - 1].Value = ExcelApp.Cells[i, j].Value;
                    if (dataManagers.Rows[i - 1].Cells[0].Value == null)
                    {
                        flag = 1;
                        dataManagers.Rows.RemoveAt(i - 1);
                        break;

                    }

                }
                if (flag == 1) break;
                ++i;
            }
            ManagerTypeCol coll = new ManagerTypeCol();
            ManagerFactory obj = new ManagerFactory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AccessToSystem.UserNow.Prioritet == 1)
            {
                AddManager form = new AddManager();
                form.Show();
            }
            else
            {
                MessageBox.Show("You don't have access!");
            }
        }

        static public void ShowNewManager(Manager newManager)
        {
            dataManagers.Rows.Add(newManager.Code, newManager.Name, newManager.Tel, newManager._tpy.Type,newManager.NameUser);

            string filename = "C:\\Users\\Angela\\Documents\\visual studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\Managers.xlsx";
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Open(filename);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Cells[dataManagers.Rows.Count-1, 1] = newManager.Code;
            ExcelWorkSheet.Cells[dataManagers.Rows.Count-1,2] = newManager.Name;
            ExcelWorkSheet.Cells[dataManagers.Rows.Count-1, 3] = newManager.Tel;
            ExcelWorkSheet.Cells[dataManagers.Rows.Count-1, 4] = newManager._tpy.Type;
            ExcelWorkSheet.Cells[dataManagers.Rows.Count - 1, 5] = newManager.NameUser;

            ExcelWorkBook.Save();
            ExcelApp.Quit();
       
        }

        private void managers_Load(object sender, EventArgs e)
        {
            
        }

        static public void DeleteManager(int code)
        {
            int j = 0;
            for (int i = 0; i < dataManagers.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataManagers[0, i].Value) == code)
                {
                    j = i;
                    dataManagers.Rows.RemoveAt(i);
                    break;
                }
            }

            string filename = "C:\\Users\\Angela\\Documents\\visual studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\Managers.xlsx";
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Open(filename);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
           

            Microsoft.Office.Interop.Excel.Range rg = (Microsoft.Office.Interop.Excel.Range)ExcelWorkSheet.Rows[j+1];
            rg.Delete(Microsoft.Office.Interop.Excel.XlDeleteShiftDirection.xlShiftUp);
            ExcelWorkBook.Save();
            ExcelApp.Quit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AccessToSystem.UserNow.Prioritet == 1)
            {
                DelManager form = new DelManager();
                form.Show();
            }
            else
            {
                MessageBox.Show("You don't have access!");
            }
        }
    }
}
