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
            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //addata();
        }
        private void Button1_Click(object sender, EventArgs e)
        {           
            ExportData.WriteToExsel(dataGridView1);
        }

        CheckBox HeaderCheckBox = null;
        bool IsHeaderCheckBoxClicked = false;
        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();
            HeaderCheckBox.Size = new Size(15, 15);
            this.dataGridView1.Controls.Add(HeaderCheckBox);
        }

        private void HeaderCheckBoxClick(CheckBox HcheckBox)
        {
            IsHeaderCheckBoxClicked = true;
            foreach(DataGridViewRow Row in dataGridView1.Rows)
            {
                ((DataGridViewCheckBoxCell)Row.Cells["chk"]).Value = HcheckBox.Checked;
            }
            dataGridView1.RefreshEdit();
            IsHeaderCheckBoxClicked = false;
        }

        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }
       

    }
}
