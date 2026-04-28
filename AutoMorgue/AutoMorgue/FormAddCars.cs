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
    public partial class FormAddCars : Form
    {
        public FormAddCars()
        {
            InitializeComponent();
        }

        private void FormAddCars_Load(object sender, EventArgs e)
        {
            using (AutoMorgueEntities con = new AutoMorgueEntities())
            {
                List<Car> cars = con.Cars.ToList();
                List<Engine> engines = con.Engines.ToList();
                cbMake.DataSource = cars;
                cbMake.DisplayMember = "Make";
                cbMake.ValueMember = "VinID";
                cbMake.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (AutoMorgueEntities con = new AutoMorgueEntities())
            {
                List<Car> cars = con.Cars.ToList();
                Car car = new Car();
                car.vinID = int.Parse(txtVIN.Text);
                bool check = false;
                foreach (var item in cars)
                {
                    if (car.vinID == item.vinID)
                    {
                        check = true;
                        break;
                    }
                }
                if (check) MessageBox.Show("VIN is already taken by another car!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
