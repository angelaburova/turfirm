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
    public partial class tours : Form
    {
        public tours()
        {
            InitializeComponent();
        }

        private void tours_Load(object sender, EventArgs e)
        {
           
        }
    
        static public void openData()
        {
            string filename = "C:\\Users\\Angela\\Documents\\visual studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\Tours.xlsx";

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
                dataTours.Rows.Add(1);
                for (int j = 1; j <= dataTours.ColumnCount; j++)
                {
                    dataTours.Rows[i - 1].Cells[j - 1].Value = ExcelApp.Cells[i, j].Value;
                    if (dataTours.Rows[i - 1].Cells[j - 1].Value == null)
                    {
                        flag = 1;
                        dataTours.Rows.RemoveAt(i - 1);
                        break;

                    }

                }
                if (flag == 1)
                {

                    break;
                }
                ++i;
            }

            FoodCol food = new FoodCol();
            TransportCol col = new TransportCol();
            TourTypeCol coll = new TourTypeCol();
            TourFactory obj = new TourFactory();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        static public void ShowFiltrTours(List <Tour> tours)
        {
            for(int i= dataTours.Rows.Count-2;i>0 ;i--)
            {
                dataTours.Rows.RemoveAt(i);
            }
            dataTours.Rows.RemoveAt(0);

            foreach (Tour i in tours)
            {
                dataTours.Rows.Add(i._code.Value, i._name.Name, i._type.Name, i._country.Name, i._visa.Value, i._hotel.Name, i._transport.Name, i._food.Name, i._cost.Value, i._valuta.Name);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Filtres form = new Filtres(this);
            form.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AccessToSystem.UserNow.Prioritet <= 3)
            {
                Tours.AddTour obj = new Tours.AddTour();
                obj.Show();
            }
            else
            {
                MessageBox.Show("You don't have access!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AccessToSystem.UserNow.Prioritet <= 3)
            {
                Tours.DelTour obj = new Tours.DelTour();
                obj.Show();
            }
            else
            {
                MessageBox.Show("You don't have access!");
            }
        }

        private void dataTours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        static public void ShowNewTour(Tour newTour)
        {

            dataTours.Rows.Add(newTour._code.Value,newTour._name.Name,newTour._type.Name,
                newTour._country.Name,newTour._visa.Value,newTour._hotel.Name,
                newTour._transport.Name,newTour._food.Name,newTour._cost.Value,newTour._valuta.Name);

            string filename = "C:\\Users\\Angela\\Documents\\visual studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\Tours.xlsx";
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Open(filename);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Cells[dataTours.Rows.Count - 1, 1] = newTour._code.Value;
            ExcelWorkSheet.Cells[dataTours.Rows.Count - 1, 2] = newTour._name.Name;
            ExcelWorkSheet.Cells[dataTours.Rows.Count - 1, 3] = newTour._type.Name;
            ExcelWorkSheet.Cells[dataTours.Rows.Count - 1, 4] = newTour._country.Name;
            ExcelWorkSheet.Cells[dataTours.Rows.Count - 1, 5] = newTour._visa.Value;
            ExcelWorkSheet.Cells[dataTours.Rows.Count - 1, 6] = newTour._hotel.Name;
            ExcelWorkSheet.Cells[dataTours.Rows.Count - 1, 7] = newTour._transport.Name;
            ExcelWorkSheet.Cells[dataTours.Rows.Count - 1, 8] = newTour._food.Name;
            ExcelWorkSheet.Cells[dataTours.Rows.Count - 1, 9] = newTour._cost.Value;
            ExcelWorkSheet.Cells[dataTours.Rows.Count - 1, 10] = newTour._valuta.Name;


            ExcelWorkBook.Save();
            ExcelApp.Quit();
        }

        static public void DeleteNewTour(int code)
        {
            int j = 0;
            for(int i=0;i<dataTours.Rows.Count;i++)
            {
                if(Convert.ToInt32(dataTours[0,i].Value)==code)
                {
                    j = i;
                    dataTours.Rows.RemoveAt(i);
                    break;
                }
            }

            string filename = "C:\\Users\\Angela\\Documents\\visual studio 2015\\Projects\\turfirm\\turfirm\\bin\\Debug\\Tours.xlsx";
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
    }
}
