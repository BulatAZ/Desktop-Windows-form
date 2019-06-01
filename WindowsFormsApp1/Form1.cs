using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CitiesDBContext dbContext;

            InitializeComponent();            
            dbContext = new CitiesDBContext();
            SampleData.EditCity(dbContext);
            dbContext.Cities.Load();

            dataGridView1.DataSource = dbContext.Cities.Local.ToBindingList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {           
            ExportData.WriteToExsel(dataGridView1);
        }

        

    }
}
