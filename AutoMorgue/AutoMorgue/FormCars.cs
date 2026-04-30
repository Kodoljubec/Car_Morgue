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
            LoadDataGridView();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            FormAddCars formAddCars = new FormAddCars();
            formAddCars.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtVIN.Text == "" || txtMake.Text == "" || txtModel.Text == "" || txtYear.Text == "" || txtEngine.Text == "")
                MessageBox.Show("One of the text fields is empty!");
            else
            {
                using (var con = new AutoMorgueEntities())
                {
                    Car tempCar = new Car();
                    tempCar.vinID = int.Parse(txtVIN.Text);
                    tempCar.Make = txtMake.Text;
                    tempCar.Model = txtModel.Text;
                    tempCar.Year = int.Parse(txtYear.Text);
                    tempCar.engineID = int.Parse(txtEngine.Text);
                    con.Cars.Add(tempCar);
                    con.SaveChanges();
                }
                LoadDataGridView();
            }
        }
        private void LoadDataGridView()
        {
            using (var con = new AutoMorgueEntities())
            {
                List<Car> cars = con.Cars.ToList();
                DataGrid.DataSource = cars;
                DataGrid.Columns["Engine"].Visible = false;
                DataGrid.Columns["Parts"].Visible = false;
                DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int tempVIN = int.Parse(DataGrid.CurrentRow.Cells["vinID"].Value.ToString());
            using (var con = new AutoMorgueEntities())
            {
                var item = con.Cars.Find(tempVIN);
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete car?", "Car deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        con.Cars.Remove(item);
                        con.SaveChanges();
                    }
                }
                catch { MessageBox.Show("Cannot delete the car!"); }
            }
            LoadDataGridView();
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            txtVIN.Text = (DataGrid.CurrentRow.Cells["vinID"].Value).ToString();
            txtMake.Text = (DataGrid.CurrentRow.Cells["Make"].Value).ToString();
            txtModel.Text = (DataGrid.CurrentRow.Cells["Model"].Value).ToString();
            txtYear.Text = (DataGrid.CurrentRow.Cells["Year"].Value).ToString();
            txtEngine.Text = (DataGrid.CurrentRow.Cells["EngineID"].Value).ToString();
        }
    }
}
