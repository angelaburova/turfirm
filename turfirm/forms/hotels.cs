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
    public partial class hotels : Form
    {
        public hotels()
        {
            InitializeComponent();
        }

        static public void openData()
        {
            string filename = "C:\\Users\\Angela\\Documents\\visual studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\Hotels.xlsx";

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
                dataHotels.Rows.Add(1);
                for (int j = 1; j <= dataHotels.ColumnCount; j++)
                {
                    dataHotels.Rows[i - 1].Cells[j - 1].Value = ExcelApp.Cells[i, j].Value;
                    if (dataHotels.Rows[i - 1].Cells[j - 1].Value == null)
                    {
                        flag = 1;
                        dataHotels.Rows.RemoveAt(i - 1);
                        break;
                    }

                }
                if (flag == 1) break;
                ++i;
            }

            HotelFactory obj = new HotelFactory();
        }

        private void hotels_Load(object sender, EventArgs e)
        {
            
        }
    }
}
