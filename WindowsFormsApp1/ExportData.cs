using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Exsel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public class ExportData
    {
        public static void WriteToExsel(DataGridView dataGridView)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + @"\" + "RussianCity.xlsx";
            Exsel.Application application = new Exsel.Application();
            var workbook = application.Workbooks.Add();
            var worksheet = workbook.ActiveSheet;
            worksheet.Cells[1, 1] = "Код города";
            worksheet.Cells[1, 2] = "Название";
            worksheet.Cells[1, 3] = "Регион";
            int rowCount = dataGridView.Rows.Count + 1;
            int columnCount = dataGridView.Columns.Count + 1;
            for (int i = 1; i < rowCount; i++)
            {
                for (int j = 1; j < columnCount; j++)
                {                   
                    worksheet.Cells[i+1, j] = dataGridView.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            workbook.SaveAs(path);
            application.Quit();
        }
        
    }
}
