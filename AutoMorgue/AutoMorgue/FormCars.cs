using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMorgue
{
    public partial class FormCars : Form
    {
        public FormCars()
        {
            InitializeComponent();
        }

        private void FormCars_Load(object sender, EventArgs e)
        {
            using (AutoMorgueEntities con =  new AutoMorgueEntities())
            {
                List<Car> cars = con.Cars.ToList();
                DataGrid.DataSource = cars;
                DataGrid.Columns["Engine"].Visible = false;
                DataGrid.Columns["Parts"].Visible = false;
                DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            FormAddCars formAddCars = new FormAddCars();
            formAddCars.ShowDialog();
        }
    }
}
