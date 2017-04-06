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
    public partial class countries : Form
    {
        public countries()
        {
            InitializeComponent();
        }

        static public void openData()
        {
            string filename = "C:\\Users\\Angela\\Documents\\visual studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\Countries.xlsx";

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
                dataCountries.Rows.Add(1);
                for (int j = 1; j <= dataCountries.ColumnCount; j++)
                {
                    dataCountries.Rows[i - 1].Cells[j - 1].Value = ExcelApp.Cells[i, j].Value;
                    if (dataCountries.Rows[i - 1].Cells[j - 1].Value == null)
                    {
                        flag = 1;
                        dataCountries.Rows.RemoveAt(i - 1);
                        break;

                    }

                }
                if (flag == 1) break;
                ++i;
            }

            Countries_Col obj = new Countries_Col();
        }

        private void countries_Load(object sender, EventArgs e)
        {
            
        }

        private void dataCountries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
